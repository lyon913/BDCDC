using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using stdole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class LayerInfo
    {
        public String LAYER_NAME { get; set; }
        public String TABLE_NAME { get; set; }
        public String ANNOTATION_EXPRESSION { get; set; }
        public short LAYER_TRANSPARENCY { get; set; }
        public IFillSymbol LAYER_SYMBOL { get; set; }
        public ITextSymbol LAYER_TEXT_SYMBOL { get; set; }
    }
    static class LayerConfig
    {
        public static IColor COLOR_RED = ArcgisService.getRgbColor(255, 0, 0);
        public static IColor COLOR_BLACK = ArcgisService.getRgbColor(0, 0, 0);
        public static IColor COLOR_NULL = ArcgisService.getNullColor();

        public static List<LayerInfo> layerInfos = new List<LayerInfo>();
        static LayerConfig()
        {
            //宗地图层配置
            LayerInfo ZD_LAYERINFO = new LayerInfo
            {
                LAYER_NAME = "宗地",
                TABLE_NAME = "ZDJBXX",
                ANNOTATION_EXPRESSION = "[ZDDM]",
                LAYER_TRANSPARENCY = 0,
                LAYER_SYMBOL = new SimpleFillSymbol
                {
                    Color = COLOR_NULL,
                    Outline = new SimpleLineSymbol
                    {
                        Color = COLOR_RED,
                        Width = 1.5
                    }
                },
                LAYER_TEXT_SYMBOL = new TextSymbol
                {
                    Color = COLOR_RED,
                    Font = (IFontDisp)new StdFont
                    {
                        Name = "黑体",
                        Bold = false,
                        Size = 11
                    }
                }
            };
            layerInfos.Add(ZD_LAYERINFO);

            //自然幢图层配置
            LayerInfo ZRZ_LAYERINFO = new LayerInfo
            {
                LAYER_NAME = "自然幢",
                TABLE_NAME = "ZRZ",
                ANNOTATION_EXPRESSION = @"[JZWMC]+Chr(10)+[ZRZH]",
                LAYER_TRANSPARENCY = 0,
                LAYER_SYMBOL = new SimpleFillSymbol
                {
                    Color = COLOR_NULL,
                    Outline = new SimpleLineSymbol
                    {
                        Color = COLOR_BLACK,
                        Width = 0.6
                    }
                },
                LAYER_TEXT_SYMBOL = new TextSymbol
                {
                    Color = COLOR_BLACK,
                    Font = (IFontDisp)new StdFont
                    {
                        Name = "宋体",
                        Size = 8
                    }
                }
            };
            layerInfos.Add(ZRZ_LAYERINFO);
        }

        public static IFeatureLayer getConfigedLayer(String tableName,String whereClause)
        {
            LayerInfo info = layerInfos.Where(item => item.TABLE_NAME == tableName).Single();
            IFeatureLayer layer = queryLayer(tableName, whereClause);
            configLayer(layer, info);
            return layer;
        }

        public static List<IFeatureLayer> getAllConfigedLayers(Dictionary<String,String> layerQueries)
        {
            List<IFeatureLayer> result = new List<IFeatureLayer>();
            foreach(KeyValuePair<String,String> item in layerQueries)
            {
                result.Add(getConfigedLayer(item.Key, item.Value));
            }
            return result;
        }

        private static void configLayer(IFeatureLayer layer, LayerInfo info)
        {
            ArcgisService.setLayerAnnotation(layer, info.ANNOTATION_EXPRESSION, info.LAYER_TEXT_SYMBOL);
            ArcgisService.setLayerSymbol(layer, (ISymbol)info.LAYER_SYMBOL);
            ArcgisService.setLayerTransparency(layer, info.LAYER_TRANSPARENCY);
        }

        public static IFeatureLayer queryLayer(String tableName,String whereClause)
        {
            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            String query = "select * from " + tableName + " " + whereClause;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            String qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = table as IFeatureClass;
            return layer;
        }

        public static int countLayer(String tableName, String whereClause)
        {
            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            String query = "select * from " + tableName + " " + whereClause;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            String qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = table as IFeatureClass;
            return layer;
        }

    }
}
