﻿using BDCDC.form;
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
using System.Runtime.InteropServices;

namespace BDCDC.service
{
    static class ArcgisService
    {
        public static int SRID = int.Parse(ConfigurationManager.AppSettings["srid"]);
        public static double FALSE_EASTING = double.Parse(ConfigurationManager.AppSettings["false_easting"]);

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

        static public IRgbColor getRgbColor(int intR, int intG, int intB, byte alpha)
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
            pRgbColor.Transparency = alpha;
            return pRgbColor;
        }

        static public IRgbColor getNullColor()
        {
            IRgbColor pRgbColor = new RgbColor();
            pRgbColor.NullColor = true;
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
            String server = ConfigurationManager.AppSettings["server"];
            String port = ConfigurationManager.AppSettings["port"];
            String database = ConfigurationManager.AppSettings["database"];
            String user = ConfigurationManager.AppSettings["user"];
            String password = ConfigurationManager.AppSettings["password"];

            IPropertySet props = new PropertySet();
            props.SetProperty("dbclient", "SQLServer");
            props.SetProperty("instance", "sde:sqlserver:"+ server+","+port);
            props.SetProperty("database", database); 
            props.SetProperty("authentication_mode", "DBMS");
            props.SetProperty("user", user);
            props.SetProperty("password", password);

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
            ICursor cur = table.Search(qf, false);
            DataStatistics dataStatistics = new DataStatistics();
            dataStatistics.Field = fieldName;
            dataStatistics.Cursor = cur;

            IEnumerator uniqueValues = dataStatistics.UniqueValues;
            List<String> list = new List<string>();
            while (uniqueValues.MoveNext())
            {
                list.Add((String)uniqueValues.Current);
            }
            Marshal.ReleaseComObject(cur);
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
            DbGeometry result = DbGeometry.FromBinary(wkb_bytes, SRID);
            return result;
        }

        public static DbGeometry pointToDbGeometry(double x, double y)
        {
            return DbGeometry.FromText(wktPoint(x, y), SRID);
        }

        public static DbGeometry lineToDbGeometry(double x1, double y1, double x2, double y2)
        {
            return DbGeometry.FromText(wktLine(x1,y1,x2,y2),SRID);
        }


        public static String wktPoint(double x, double y)
        {
            String wkt = "POINT({0} {1})";
            return String.Format(wkt, x, y);
        }

        public static String wktLine(double x1, double y1, double x2, double y2)
        {
            String wkt = "LINESTRING({0} {1},{2} {3})";
            return String.Format(wkt, x1, y1, x2, y2);
        }

        public static IGeometry dbGeometryToGeometry(DbGeometry dbGeometry)
        {
            if(dbGeometry == null)
            {
                return null;
            }
            byte[] wkb = dbGeometry.AsBinary();
            IGeometry geomOut = new GeometryBag();
            IGeometryFactory gf = new GeometryEnvironment() as IGeometryFactory;
            int readCount = 0;
            gf.CreateGeometryFromWkbVariant(wkb, out geomOut, out readCount);
            return geomOut;
        }

        public static void addCadLayersToMap(AxMapControl mapControl,String cadFullPath, EnumFeatureType featureType)
        {
            String fileName = System.IO.Path.GetFileName(cadFullPath);
            String fileDir = System.IO.Path.GetDirectoryName(cadFullPath);
            IFeatureWorkspace ws = openCadWorkspace(fileDir) as IFeatureWorkspace;

            IFeatureClass fc = ws.OpenFeatureClass(fileName + ":" + featureType.ToString());
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
            IEnumFeature selectedFeatures = selection as IEnumFeature;
            List<IFeature> fList = new List<IFeature>();
            IFeature f = null;
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

        public static void selectMapFeatures(String whereClause, String layerName, AxMapControl mapControl)
        {
            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = whereClause;
            IFeatureSelection selection = findMapLayer(mapControl, layerName) as IFeatureSelection;
            if(selection == null)
            {
                return;
            }
            selection.SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);
            mapControl.Refresh();
        }

        public static void clearMapSelection(AxMapControl mapControl)
        {
            mapControl.Map.ClearSelection();
            mapControl.Refresh();
        }

        public static void removeAllLayers(AxMapControl mapControl)
        {
            mapControl.Map.ClearLayers();
            mapControl.Refresh();
        }

        public static void setLayerSymbol(IFeatureLayer pFeaturelayer, ISymbol symbol)
        {
            if(pFeaturelayer == null)
            {
                return;
            }
            IGeoFeatureLayer layer = pFeaturelayer as IGeoFeatureLayer;
            ISimpleRenderer renderer = new SimpleRenderer();
            renderer.Symbol = symbol;
            layer.Renderer = renderer as IFeatureRenderer;
        }

        public static void setLayerTransparency(IFeatureLayer pFeaturelayer, short transparency)
        {
            if (pFeaturelayer == null)
            {
                return;
            }
            ILayerEffects effects = pFeaturelayer as ILayerEffects;
            if (effects.SupportsTransparency)
            {
                effects.Transparency = transparency;
            }
        }

        public static void setLayerAnnotation(IFeatureLayer pFeaturelayer, string expression, ITextSymbol textSymbol)
        {
            //判断图层是否为空
            if (pFeaturelayer == null)
            {
                return;
            }
               
            IGeoFeatureLayer pGeoFeaturelayer = (IGeoFeatureLayer)pFeaturelayer;
            IAnnotateLayerPropertiesCollection pAnnoLayerPropsCollection;
            pAnnoLayerPropsCollection = pGeoFeaturelayer.AnnotationProperties;
            if(pAnnoLayerPropsCollection == null)
            {
                return;
            }
            pAnnoLayerPropsCollection.Clear();

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
            pLabelEnginelayerProps.Expression = expression;
            pLabelEnginelayerProps.Symbol = textSymbol;
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

        public static ITable queryTable(String tableName, String whereClause)
        {

            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            String query = "select * from " + tableName + " where 1=1 and " + whereClause;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            String qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            if (ws.OpenQueryCursor(query).NextRow() == null)
            {
                return null;
            }
            ITable table = ws.OpenQueryClass(qName, q);
            return table;
        }

        public static IFeatureLayer queryLayer(String tableName, String whereClause)
        {
            
            whereClause += " and SHAPE is not null";//创建Layer对象的数据记录SHAPE不能为空，否则报错
            ITable fc = queryTable(tableName, whereClause);
            if (fc == null)
            {
                return null;
            }
            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = fc as IFeatureClass;
            return layer;
        }

        /*
        public static int countFeatures(String tableName, String whereClause)
        {
            String query = "select count(*) from " + tableName + " where SHAPE is not null and " + whereClause;

        }
        */

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

        public static List<IFeature> spatialQuery(IFeatureClass featureClass, IGeometry geometry, esriSpatialRelEnum spatialRelationship)
        {
            ISpatialFilter spatialFilter = new SpatialFilterClass();
            spatialFilter.Geometry = geometry;
            spatialFilter.GeometryField = featureClass.ShapeFieldName;
            spatialFilter.SpatialRel = spatialRelationship;
            IFeatureCursor cur = featureClass.Search(spatialFilter, false);
            IFeature feature = null;
            List<IFeature> results = new List<IFeature>();
            while ((feature = cur.NextFeature()) != null)
            {
                results.Add(feature);
            }
            Marshal.ReleaseComObject(cur);
            return results;
        }

        public static List<IPoint> getPolygonPoints(DbGeometry shape)
        {
            Polygon p = (Polygon)ArcgisService.dbGeometryToGeometry(shape);
            int pCount = p.PointCount;
            List<IPoint> pList = new List<IPoint>();
            for (int i = 0; i < pCount-1; i++)
            {
                IPoint point = p.Point[i];
                pList.Add(point);
            }

            return pList;
        }

        /**
         * 检查坐标是否为指定的投影带内
         **/
        public static void checkGeometryCoordinates(IGeometry geometry)
        {
            IPoint p = geometry.Envelope.LowerLeft;
            if(p.X - FALSE_EASTING < 0)
            {
                throw new Exception("坐标值不在投影坐标系允许的范围内，请检查坐标值、带号等是否正确。");
            }
        }
    }
}
