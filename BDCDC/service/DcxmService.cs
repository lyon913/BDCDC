using BDCDC.model;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    public class DcxmService : Service
    {

        public static String QJDCXM_PREFIX = "QD";

        public static String ZD_LAYER_NAME = "宗地";
        public static String ZD_TABLE_NAME = "ZDJBXX";
        public static String ZD_ANNOTATION_EXPRESSION = "[ZDDM]";
        public static IColor ZD_SYMBOL_COLOR = ArcgisService.getNullColor();
        public static IColor ZD_OUTLINE_COLOR = ArcgisService.getRgbColor(200, 0, 0);
        public static double ZD_OUTLINE_WITH = 1.5;
        public static IColor ZD_TEXT_COLOR = ArcgisService.getRgbColor(200, 0, 0);
        public static int ZD_TEXT_SIZE = 12;
        public static IFillSymbol ZD_SYMBOL = createSimpleFillSymbol(ZD_SYMBOL_COLOR, ZD_OUTLINE_COLOR, ZD_OUTLINE_WITH);
        public static ITextSymbol ZD_TEXT_SYMBOL = createTextSymbol(ZD_TEXT_COLOR, ZD_TEXT_SIZE);

        public static String ZRZ_LAYER_NAME = "自然幢";
        public static String ZRZ_TABLE_NAME = "ZRZ";
        public static String ZRZ_ANNOTATION_EXPRESSION = @"[JZWMC]+Chr(10)+[ZRZH]";
        public static IColor ZRZ_SYMBOL_COLOR = ArcgisService.getRgbColor(255,150,150);
        public static IColor ZRZ_OUTLINE_COLOR = ArcgisService.getRgbColor(0, 0, 0);
        public static double ZRZ_OUTLINE_WITH = 0.5;
        public static IColor ZRZ_TEXT_COLOR = ArcgisService.getRgbColor(0, 0, 0);
        public static int ZRZ_TEXT_SIZE = 8;
        public static IFillSymbol ZRZ_SYMBOL = createSimpleFillSymbol(ZRZ_SYMBOL_COLOR, ZRZ_OUTLINE_COLOR, ZRZ_OUTLINE_WITH);
        public static ITextSymbol ZRZ_TEXT_SYMBOL = createTextSymbol(ZRZ_TEXT_COLOR, ZRZ_TEXT_SIZE);

        public class LayerInfo
        {
            public String layerName { get; set; }
            public String tableName { get; set; }
            public String annoExp { get; set; }

            public ISymbol symbol { get; set; }
            public ITextSymbol textSymbol { get; set; }
        }

        public List<LayerInfo> getLayerInfos()
        {
            List<LayerInfo> result = new List<LayerInfo>();

            IFillSymbol zdSymbol = createSimpleFillSymbol(ZD_SYMBOL_COLOR, ZD_OUTLINE_COLOR, ZD_OUTLINE_WITH);
            LayerInfo zd = createLayerInfo(ZD_LAYER_NAME, ZD_TABLE_NAME, ZD_ANNOTATION_EXPRESSION, zdSymbol, ZD_TEXT_SYMBOL);
            result.Add(zd);

            IFillSymbol symbol_zrz = createSimpleFillSymbol(ZRZ_SYMBOL_COLOR, ZRZ_OUTLINE_COLOR, ZRZ_OUTLINE_WITH);
            LayerInfo zrz = createLayerInfo(ZRZ_LAYER_NAME, ZRZ_TABLE_NAME, ZRZ_ANNOTATION_EXPRESSION, symbol_zrz, ZRZ_TEXT_SYMBOL);
            result.Add(zrz);

            return result;
        }

        private LayerInfo createLayerInfo(String layerName,String tableName,String annExp, IFillSymbol symbol,ITextSymbol textSymbol)
        {
            LayerInfo info = new LayerInfo();
            info.layerName = layerName;
            info.tableName = tableName;
            info.annoExp = annExp;

            info.symbol = symbol as ISymbol;
            info.textSymbol = textSymbol;
            return info;
        }

        private static IFillSymbol createSimpleFillSymbol(IColor color, IColor outLineColor, double outLineWith)
        {
            SimpleFillSymbol symbol = new SimpleFillSymbol();
            symbol.Style = esriSimpleFillStyle.esriSFSSolid;
            symbol.Color = color;
            ILineSymbol line = new SimpleLineSymbol();
            line.Color = outLineColor;
            line.Width = outLineWith;
            //symbol.Outline.Color = outLineColor;
            //symbol.Outline.Width = outLineWith;
            symbol.Outline = line;
            symbol.Color.Transparency = 5;

            Debug.WriteLine("=1=" + outLineWith);
            Debug.WriteLine("=1=" + symbol.Outline.Width);
            Debug.WriteLine("=1="+outLineColor.RGB.ToString());
            Debug.WriteLine("=1="+symbol.Outline.Color.RGB.ToString());

            return symbol;
        }

        private static ITextSymbol createTextSymbol(IColor color, double size)
        {
            ITextSymbol pTextSymbol = new TextSymbolClass();
            pTextSymbol.Color = color;
            pTextSymbol.Size = size; 
            return pTextSymbol;
        }

        public void save(QJDCXM xm)
        {
            useTransaction(ctx =>
            {
                xm.XMBH = generateXmbh();
                insertOrUpdate(xm, ctx);
                return xm;
            });

        }

        public QJDCXM getById(int id)
        {
            return useDbContext(ctx =>
            {
                return ctx.QJDCXM.Where(xm => xm.fId == id).Single();
            });

        }

        private String generateXmbh()
        {
            return QJDCXM_PREFIX + DateTime.Now.ToShortTimeString();
        }



        public IFeatureLayer getDcxmLayer(int dcxmId, String tableName)
        {
            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            String query = "select * from " + tableName + " where QJDCXM_ID=" + dcxmId;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            q.GeometryType = esriGeometryType.esriGeometryPolygon;
            String qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = table as IFeatureClass;
            return layer;
        }

        public List<QJDCXM> getTodoList()
        {
            return useDbContext(ctx =>
            {
                return ctx.QJDCXM.Where(xm => xm.ZT == 0).OrderByDescending(xm => xm.SLRQ).ToList();
            });
        }

        public int countTableByDcxmId(int dcxmId, String tableName)
        {
            return useDbContext(ctx =>
            {
                return ctx.Database.SqlQuery<int>("select count(*) from " + tableName + " where QJDCXM_ID = @xmid", new SqlParameter("xmid", dcxmId)).Single();
                //return ctx.ZDJBXX.Where(zd => zd.QJDCXMID == dcxmId).Count();
            });
        }

        public int countZrzByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.QJDCXMID == dcxmId).Count();
            });
        }

        public List<ZDJBXX> getZdjbxxByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZDJBXX.Where(zd => zd.QJDCXMID == dcxmId).ToList();
            });
        }
    }
}
