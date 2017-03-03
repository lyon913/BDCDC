using BDCDC.form;
using BDCDC.vo;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.DataSourcesOleDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Maplex;

namespace BDCDC.service
{
    static class ArcgisService
    {
        public static class CAD_FEATURE_TYPE
        {
            public static String POLYGON = "Polygon";
            public static String ANNOTATION = "Annotation";
            public static String POLYLINE = "Polyline";
            public static String POINT = "Point";
        }

        public static class MAP_COLOR
        {
            public static IColor COLOR_ZD_OUTLINE= getRgbColor(200,0,0);

        }

        static public IRgbColor getRgbColor(int intR, int intG, int intB)
        {
            IRgbColor pRgbColor = null;
            if (intR < 0 || intR > 255 || intG < 0 || intG > 255 || intB < 0 || intB > 255)
            {
                return pRgbColor;
            }
            pRgbColor = new RgbColorClass();
            pRgbColor.Red = intR;
            pRgbColor.Green = intG;
            pRgbColor.Blue = intB;
            return pRgbColor;
        }

        public static IWorkspace openBdcWorkspace()
        {
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.SdeWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            //IWorkspaceFactory workspaceFactory = new SqlWorkspaceFactoryClass();

            IPropertySet props = getDbProperties();
            return workspaceFactory.Open(props, 0);
        }

        private static IPropertySet getDbProperties()
        {
            IPropertySet props = new PropertySet();
            props.SetProperty("dbclient", "SQLServer");
            //props.SetProperty("serverinstance", "127.0.0.1");
            props.SetProperty("instance", "sde:sqlserver:127.0.0.1");
            props.SetProperty("database", "bdcdj_fm"); // Only if it is needed
            props.SetProperty("authentication_mode", "DBMS");
            props.SetProperty("user", "sa");
            props.SetProperty("password", "xqx123456@");

            return props;
        }

        /**
         * 
         * 打开CAD数据集
         * */
        public static ICadDrawingDataset getCadDataset(string cadWorkspacePath, string cadFileName)
        {
            //Create a WorkspaceName object
            IWorkspaceName workspaceName = new WorkspaceNameClass();
            workspaceName.WorkspaceFactoryProgID = "esriDataSourcesFile.CadWorkspaceFactory";
            workspaceName.PathName = cadWorkspacePath;

            //Create a CadDrawingName object
            IDatasetName cadDatasetName = new CadDrawingNameClass();
            cadDatasetName.Name = cadFileName;
            cadDatasetName.WorkspaceName = workspaceName;

            //Open the CAD drawing
            IName name = (IName)cadDatasetName;
            return (ICadDrawingDataset)name.Open();
        }

        /**
         * 
         * 打开CAD工作空间
         * */
        public static IWorkspace openCadWorkspace(string folderPath)
        {
            //Create a WorkspaceName object
            CadWorkspaceFactoryClass factory = new CadWorkspaceFactoryClass();
            IWorkspace ws = factory.OpenFromFile(folderPath, 0);
            return ws;
        }

        /**
         * 获取ITable记录的某一字段唯一值
         * */
        public static List<String> getUniqeValues(ITable table, String fieldName, String whereClause)
        {
            IQueryFilter qf = new QueryFilter();
            qf.WhereClause = whereClause;

            DataStatistics dataStatistics = new DataStatistics();
            dataStatistics.Field = fieldName;
            dataStatistics.Cursor = table.Search(qf, false);

            IEnumerator uniqueValues = dataStatistics.UniqueValues;
            List<String> list = new List<string>();
            while (uniqueValues.MoveNext())
            {
                list.Add((String)uniqueValues.Current);
            }
            return list;
        }

        public static IFeatureLayer getCadFeatureLayer(IFeatureWorkspace ws ,String cadFileName)
        {
            IFeatureClass fcPolygon = ws.OpenFeatureClass(cadFileName + ":Polygon");
            IFeatureLayer layer_import = new FeatureLayer();
            layer_import.FeatureClass = fcPolygon;
            layer_import.Name = cadFileName;

            List<String> layers = ArcgisService.getUniqeValues((ITable)fcPolygon, "Layer", null);
            String cadLayer = DialogLayerSelect.showDialog("CAD图层选择", layers);

            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = "Layer = '" + cadLayer + "'";
            ((IFeatureSelection)layer_import).SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);
            IFeatureLayerDefinition layer_import_def = (IFeatureLayerDefinition)layer_import;
            IFeatureLayer layer_selected = layer_import_def.CreateSelectionLayer(cadLayer + "@" + cadFileName, true, null, null);
            return layer_selected;
        }

        public static DbGeometry featureToDbGeometry(IFeature feature)
        {
            IWkb wkb = (IWkb)feature.Shape;
            byte[] wkb_bytes = new byte[wkb.WkbSize];
            int byte_count = wkb.WkbSize;
            wkb.ExportToWkb(ref byte_count, out wkb_bytes[0]);
            DbGeometry result = DbGeometry.FromBinary(wkb_bytes);
            return result;
        }

        public static void addCadLayersToMap(AxMapControl mapControl,String cadFullPath, String featureType)
        {
            String fileName = System.IO.Path.GetFileName(cadFullPath);
            String fileDir = System.IO.Path.GetDirectoryName(cadFullPath);
            IFeatureWorkspace ws = openCadWorkspace(fileDir) as IFeatureWorkspace;

            IFeatureClass fc = ws.OpenFeatureClass(fileName + ":" + featureType);
            IFeatureLayer layer = new FeatureLayerClass();
            layer.FeatureClass = fc;
            layer.Name = fileName;


            List<String> cadLayers = getUniqeValues(fc as ITable, "Layer", "");
            if (cadLayers == null || cadLayers.Count == 0)
            {
                return;
            }
            foreach (String layerName in cadLayers)
            {

                String where = "Layer = '" + layerName + "'";
                IFeatureLayer layer_filtered = createFilterLayer(layer, layerName, where);
                layer_filtered.Visible = false;
                mapControl.Map.AddLayer(layer_filtered);
                mapControl.ActiveView.Refresh();
            }

        }

        public static void addCadToMapAsRaster(AxMapControl mapControl, String cadFullPath)
        {
            String fileName = System.IO.Path.GetFileName(cadFullPath);
            String fileDir = System.IO.Path.GetDirectoryName(cadFullPath);
            ICadDrawingWorkspace ws = openCadWorkspace(fileDir) as ICadDrawingWorkspace;
            ICadDrawingDataset ds = ws.OpenCadDrawingDataset(fileName);

            ICadLayer layer = new CadLayerClass();
            layer.Name = fileName;
            layer.CadDrawingDataset = ds;

            mapControl.Map.AddLayer(layer);
            mapControl.ActiveView.Refresh();
        }

        public static IFeatureLayer createFilterLayer(IFeatureLayer layer, String newLayerName,String whereClause)
        {

            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = whereClause;

            IFeatureSelection fSelection = layer as IFeatureSelection;
            fSelection.SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);

            IFeatureLayerDefinition layer_def = fSelection as IFeatureLayerDefinition;
            IFeatureLayer layer_filtered = layer_def.CreateSelectionLayer(newLayerName, true, null, null);
            return layer_filtered;
        }

        public static List<IFeature> getFeaturesFromMapSelection(AxMapControl mapControl)
        {
            ISelection selection = mapControl.Map.FeatureSelection;
            //IEnumFeatureSetup selectionSetup = selection as IEnumFeatureSetup;
            //selectionSetup.AllFields = true;//所有字段

            IEnumFeature selectedFeatures = selection as IEnumFeature;
            List<IFeature> fList = new List<IFeature>();
            IFeature f;
            while ((f = selectedFeatures.Next()) != null)
            {
                fList.Add(f);
            }
            return fList;
        }

        public static ILayer findMapLayer(AxMapControl mapControl, String name)
        {
            IEnumLayer layers = mapControl.Map.Layers;
            ILayer layer = null;
            while ((layer = layers.Next()) != null)
            {
                if (name.Equals(layer.Name))
                {
                    return layer;
                }
            }

            return null;
        }

        public static void selectMapFeatures(String whereClause, IFeatureLayer layer, AxMapControl mapControl)
        {
            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = whereClause;
            IFeatureSelection selection = layer as IFeatureSelection;
            selection.SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);
            mapControl.Refresh();
        }

        public static void selectMapFeatures(String whereClause, String layerName, AxMapControl mapControl)
        {
            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = whereClause;
            IFeatureSelection selection = findMapLayer(mapControl, layerName) as IFeatureSelection;
            selection.SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);
            mapControl.Refresh();
        }

        public static void clearMapSelection(AxMapControl mapControl)
        {
            IFeatureSelection zdLayer = mapControl.get_Layer(0) as IFeatureSelection;
            zdLayer.Clear();
            mapControl.Refresh();
        }

        public static void removeAllLayers(AxMapControl mapControl)
        {
            mapControl.Map.ClearLayers();
            mapControl.Refresh();
        }

        public static void enableFeatureLayerLabel(IFeatureLayer pFeaturelayer, string sLableField, IRgbColor pRGB, int size)
        {
            //判断图层是否为空
            if (pFeaturelayer == null)
            {
                return;
            }
               
            IGeoFeatureLayer pGeoFeaturelayer = (IGeoFeatureLayer)pFeaturelayer;
            IAnnotateLayerPropertiesCollection pAnnoLayerPropsCollection;
            pAnnoLayerPropsCollection = pGeoFeaturelayer.AnnotationProperties;
            pAnnoLayerPropsCollection.Clear();

            //stdole.IFontDisp  pFont; //字体
            ITextSymbol pTextSymbol;

            //pFont.Name = "新宋体";
            //pFont.Size = 9;

            pTextSymbol = new TextSymbolClass();
            pTextSymbol.Color = pRGB;
            pTextSymbol.Size = size; //标注大小

            IBasicOverposterLayerProperties4 pBasicOverposterlayerProps = new BasicOverposterLayerPropertiesClass();
            switch (pFeaturelayer.FeatureClass.ShapeType)//判断图层类型
            {
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolygon:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolygon;
                    pBasicOverposterlayerProps.PolygonPlacementMethod = esriOverposterPolygonPlacementMethod.esriAlwaysHorizontal;
                    break;
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPoint:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPoint;
                    pBasicOverposterlayerProps.PointPlacementMethod = esriOverposterPointPlacementMethod.esriAroundPoint;
                    break;
                case ESRI.ArcGIS.Geometry.esriGeometryType.esriGeometryPolyline:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolyline;
                    break;
            }
            
            pBasicOverposterlayerProps.PlaceOnlyInsidePolygon = true;
            pBasicOverposterlayerProps.NumLabelsOption = esriBasicNumLabelsOption.esriOneLabelPerShape;


            ILabelEngineLayerProperties pLabelEnginelayerProps = new LabelEngineLayerPropertiesClass();
            pLabelEnginelayerProps.Expression = "[" + sLableField + "]";
            pLabelEnginelayerProps.Symbol = pTextSymbol;
            pLabelEnginelayerProps.BasicOverposterLayerProperties = pBasicOverposterlayerProps as IBasicOverposterLayerProperties;
            pAnnoLayerPropsCollection.Add((IAnnotateLayerProperties)pLabelEnginelayerProps);
            pGeoFeaturelayer.DisplayAnnotation = true;//很重要，必须设置 
        }

        public static void annotateLayer(IGeoFeatureLayer pGeoFeatLyr, string annoField)
        {

            //如果Map没有用Maplex引擎，要先设置Map使用这个引擎
            //IAnnotateMap pAnnotateMap;
            //pAnnotateMap = new MaplexAnnotateMapClass();
            //pMap.AnnotationEngine = pAnnotateMap;

            IGeoFeatureLayer pGeoFeatLayer;
            pGeoFeatLayer = pGeoFeatLyr;
            IAnnotateLayerPropertiesCollection pAnnoProps;
            pAnnoProps = pGeoFeatLyr.AnnotationProperties;
            pAnnoProps.Clear();
            ILabelEngineLayerProperties2 pLabelEngine2 = new MaplexLabelEngineLayerPropertiesClass();
            pLabelEngine2.Expression = "[" + annoField + "]";

            IMaplexOverposterLayerProperties pMaplexPro = new MaplexOverposterLayerPropertiesClass();
            pMaplexPro.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolygon;
            pMaplexPro.PolygonPlacementMethod = esriMaplexPolygonPlacementMethod.esriMaplexHorizontalInPolygon;
            pMaplexPro.CanPlaceLabelOutsidePolygon = false;
            pMaplexPro.CanRemoveOverlappingLabel = true;
            pMaplexPro.RepeatLabel = false;
            pMaplexPro.CanStackLabel = true;


            pLabelEngine2.OverposterLayerProperties = pMaplexPro as IOverposterLayerProperties;
            //IMapOverposter pMapPos = axMapControl1.Map as IMapOverposter;
            //IOverposterProperties pOP = pMapPos.OverposterProperties;
            //IMaplexOverposterProperties pMaplexOP = pOP as IMaplexOverposterProperties;
            //pMaplexOP.LabelLargestPolygon = false;
            pAnnoProps.Add(pLabelEngine2 as IAnnotateLayerProperties);
            pGeoFeatLyr.DisplayAnnotation = true;
        }

        public static BasicLayers getBasicLayers(IWorkspace ws)
        {
            BasicLayers layers = new BasicLayers();

            IFeatureClass fcTmp = null;
            IEnumDataset ds = ws.Datasets[esriDatasetType.esriDTFeatureClass];
            while ((fcTmp = (IFeatureClass)ds.Next()) != null)
            {
                if ("bdcdj.dbo.ZDJBXX".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "宗地";
                    layers.ZDJBXX = layer;
                }
                if ("bdcdj.dbo.ZRZ".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "自然幢";
                    layers.ZRZ = layer;
                }
                if ("bdcdj.dbo.XZQ".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "行政区";
                    layers.XZQ = layer;
                }
                if ("bdcdj.dbo.DJQ".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "地籍区";
                    layers.DJQ = layer;
                }
                if ("bdcdj.dbo.DJZQ".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "地籍子区";
                    layers.DJZQ = layer;
                }
                if ("bdcdj.dbo.JZD".Equals(fcTmp.AliasName))
                {
                    IFeatureLayer layer = new FeatureLayer();
                    layer.FeatureClass = (IFeatureClass)fcTmp;
                    layer.Name = "界址点";
                    layers.JZD = layer;
                }

            }

            return layers;
        }
        
    }
}
