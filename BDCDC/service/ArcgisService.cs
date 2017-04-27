using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Spatial;
using System.Runtime.InteropServices;

namespace BDCDC.service
{
    static class ArcgisService
    {
        /// <summary>
        /// 系统使用的投影坐标系WKID
        /// </summary>
        public static int SRID = ConfigManager.SRID;

        /// <summary>
        /// 系统使用的投影坐标系
        /// </summary>
        public static IProjectedCoordinateSystem PCS = getPcsById(SRID);

        /// <summary>
        /// 从srid获取投影坐标系统
        /// </summary>
        /// <param name="srid"></param>
        /// <returns></returns>
        public static IProjectedCoordinateSystem getPcsById(int srid)
        {
            ISpatialReferenceFactory spatialReferenceFactory = new SpatialReferenceEnvironmentClass();
            return spatialReferenceFactory.CreateProjectedCoordinateSystem(SRID);
        }

        /// <summary>
        /// 构造RGB颜色
        /// </summary>
        /// <param name="intR"></param>
        /// <param name="intG"></param>
        /// <param name="intB"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 构造RGBa颜色
        /// </summary>
        /// <param name="intR"></param>
        /// <param name="intG"></param>
        /// <param name="intB"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 构造空颜色
        /// </summary>
        /// <returns></returns>
        static public IRgbColor getNullColor()
        {
            IRgbColor pRgbColor = new RgbColor();
            pRgbColor.NullColor = true;
            return pRgbColor;
        }

        /// <summary>
        /// 打开数据库工作空间
        /// </summary>
        /// <returns></returns>
        public static IWorkspace openBdcWorkspace()
        {
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.SdeWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            //IWorkspaceFactory workspaceFactory = new SqlWorkspaceFactoryClass();

            IPropertySet props = getDbProperties();
            return workspaceFactory.Open(props, 0);
        }

        /// <summary>
        /// 获取数据库连接参数，用于arc SDE 数据库连接
        /// </summary>
        /// <returns></returns>
        private static IPropertySet getDbProperties()
        {
            string server = ConfigurationManager.AppSettings["server"];
            string port = ConfigurationManager.AppSettings["port"];
            string database = ConfigurationManager.AppSettings["database"];
            string user = ConfigurationManager.AppSettings["user"];
            string password = ConfigurationManager.AppSettings["password"];

            IPropertySet props = new PropertySet();
            props.SetProperty("dbclient", "SQLServer");
            props.SetProperty("instance", "sde:sqlserver:"+ server+","+port);
            props.SetProperty("database", database); 
            props.SetProperty("authentication_mode", "DBMS");
            props.SetProperty("user", user);
            props.SetProperty("password", password);

            return props;
        }

        /// <summary>
        /// 打开CAD数据集
        /// </summary>
        /// <param name="cadWorkspacePath"></param>
        /// <param name="cadFileName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 打开CAD工作空间
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static IWorkspace openCadWorkspace(string folderPath)
        {
            //Create a WorkspaceName object
            CadWorkspaceFactoryClass factory = new CadWorkspaceFactoryClass();
            IWorkspace ws = factory.OpenFromFile(folderPath, 0);
            return ws;
        }

        /// <summary>
        /// 获取ITable记录的某一字段唯一值
        /// </summary>
        /// <param name="table"></param>
        /// <param name="fieldName"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static List<string> getUniqeValues(ITable table, string fieldName, string whereClause)
        {
            IQueryFilter qf = new QueryFilter();
            qf.WhereClause = whereClause;
            ICursor cur = table.Search(qf, false);
            DataStatistics dataStatistics = new DataStatistics();
            dataStatistics.Field = fieldName;
            dataStatistics.Cursor = cur;

            IEnumerator uniqueValues = dataStatistics.UniqueValues;
            List<string> list = new List<string>();
            while (uniqueValues.MoveNext())
            {
                list.Add((string)uniqueValues.Current);
            }
            Marshal.ReleaseComObject(cur);
            return list;
        }


        /// <summary>
        /// IFeature转换为DbGeometry
        /// </summary>
        /// <param name="feature"></param>
        /// <returns></returns>
        public static DbGeometry featureToDbGeometry(IFeature feature)
        {
            IWkb wkb = (IWkb)feature.Shape;
            byte[] wkb_bytes = new byte[wkb.WkbSize];
            int byte_count = wkb.WkbSize;
            wkb.ExportToWkb(ref byte_count, out wkb_bytes[0]);
            DbGeometry result = DbGeometry.FromBinary(wkb_bytes, SRID);
            return result;
        }

        /// <summary>
        /// 从坐标点构造DbGeometry的点
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <returns></returns>
        public static DbGeometry pointToDbGeometry(double x, double y)
        {
            return DbGeometry.FromText(wktPoint(x, y), SRID);
        }

        /// <summary>
        /// 从坐标点构造DbGeometry的直线
        /// </summary>
        /// <param name="x1">点1的x坐标</param>
        /// <param name="y1">点1的y坐标</param>
        /// <param name="x2">点2的x坐标</param>
        /// <param name="y2">点2的y坐标</param>
        /// <returns></returns>
        public static DbGeometry lineToDbGeometry(double x1, double y1, double x2, double y2)
        {
            return DbGeometry.FromText(wktLine(x1,y1,x2,y2),SRID);
        }

        /// <summary>
        /// 构造点的文本表达形式（WKT）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static string wktPoint(double x, double y)
        {
            string wkt = "POINT({0} {1})";
            return String.Format(wkt, x, y);
        }

        /// <summary>
        /// 构造直线的文本表达形式（WKT）
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static string wktLine(double x1, double y1, double x2, double y2)
        {
            string wkt = "LINESTRING({0} {1},{2} {3})";
            return String.Format(wkt, x1, y1, x2, y2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbGeometry"></param>
        /// <returns></returns>
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


        /// <summary>
        /// 向地图控件添加指定类型的CAD图层
        /// </summary>
        /// <param name="mapControl"></param>
        /// <param name="cadFullPath"></param>
        /// <param name="featureType"></param>
        public static void addCadLayersToMap(AxMapControl mapControl,string cadFullPath, EnumFeatureType featureType)
        {
            string fileName = System.IO.Path.GetFileName(cadFullPath);
            string fileDir = System.IO.Path.GetDirectoryName(cadFullPath);
            IFeatureWorkspace ws = openCadWorkspace(fileDir) as IFeatureWorkspace;

            IFeatureClass fc = ws.OpenFeatureClass(fileName + ":" + featureType.ToString());
            IFeatureLayer layer = new FeatureLayerClass();
            layer.FeatureClass = fc;
            layer.Name = fileName;


            List<string> cadLayers = getUniqeValues(fc as ITable, "Layer", "");
            if (cadLayers == null || cadLayers.Count == 0)
            {
                return;
            }
            foreach (string layerName in cadLayers)
            {

                string where = "Layer = '" + layerName + "'";
                IFeatureLayer layer_filtered = createFilterLayer(layer, layerName, where);
                layer_filtered.Visible = false;
                mapControl.Map.AddLayer(layer_filtered);
                mapControl.ActiveView.Refresh();
            }

        }

        /// <summary>
        /// 向地图控件中添加CAD所有图层
        /// </summary>
        /// <param name="mapControl"></param>
        /// <param name="cadFullPath"></param>
        public static void addCadToMapAsRaster(AxMapControl mapControl, string cadFullPath)
        {
            string fileName = System.IO.Path.GetFileName(cadFullPath);
            string fileDir = System.IO.Path.GetDirectoryName(cadFullPath);
            ICadDrawingWorkspace ws = openCadWorkspace(fileDir) as ICadDrawingWorkspace;
            ICadDrawingDataset ds = ws.OpenCadDrawingDataset(fileName);

            ICadLayer layer = new CadLayerClass();
            layer.Name = fileName;
            layer.CadDrawingDataset = ds;

            mapControl.Map.AddLayer(layer);
            mapControl.ActiveView.Refresh();
        }

        /// <summary>
        /// 以SQL where 条件创建IFeatureLayer
        /// </summary>
        /// <param name="layer"></param>
        /// <param name="newLayerName"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static IFeatureLayer createFilterLayer(IFeatureLayer layer, string newLayerName,string whereClause)
        {

            IQueryFilter qf = new QueryFilterClass();
            qf.WhereClause = whereClause;

            IFeatureSelection fSelection = layer as IFeatureSelection;
            fSelection.SelectFeatures(qf, esriSelectionResultEnum.esriSelectionResultNew, false);

            IFeatureLayerDefinition layer_def = fSelection as IFeatureLayerDefinition;
            IFeatureLayer layer_filtered = layer_def.CreateSelectionLayer(newLayerName, true, null, null);
            return layer_filtered;
        }

        /// <summary>
        /// 从地图控件获取所有被选中的要素
        /// </summary>
        /// <param name="mapControl"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 查找地图控件上的图层
        /// </summary>
        /// <param name="mapControl"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ILayer findMapLayer(AxMapControl mapControl, string name)
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

        /// <summary>
        /// 以SQL where 条件选择地图上的要素
        /// </summary>
        /// <param name="whereClause"></param>
        /// <param name="layerName"></param>
        /// <param name="mapControl"></param>
        public static void selectMapFeatures(string whereClause, string layerName, AxMapControl mapControl)
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

        /// <summary>
        /// 清空地图控件上已选择的图形
        /// </summary>
        /// <param name="mapControl"></param>
        public static void clearMapSelection(AxMapControl mapControl)
        {
            mapControl.Map.ClearSelection();
            mapControl.Refresh();
        }

        /// <summary>
        /// 从地图控件移除所有图层
        /// </summary>
        /// <param name="mapControl"></param>
        public static void removeAllLayers(AxMapControl mapControl)
        {
            mapControl.Map.ClearLayers();
            mapControl.Refresh();
        }

        /// <summary>
        /// 设置图层符号
        /// </summary>
        /// <param name="pFeaturelayer"></param>
        /// <param name="symbol"></param>
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

        /// <summary>
        /// 设置图层透明度
        /// </summary>
        /// <param name="pFeaturelayer"></param>
        /// <param name="transparency"></param>
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

        /// <summary>
        /// 设置图层注释
        /// </summary>
        /// <param name="pFeaturelayer"></param>
        /// <param name="expression"></param>
        /// <param name="textSymbol"></param>
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

        /// <summary>
        /// 用maplex渲染图层注释
        /// </summary>
        /// <param name="pGeoFeatLyr"></param>
        /// <param name="annoField"></param>
        public static void annotateLayerMaplexPro(IGeoFeatureLayer pGeoFeatLyr, string annoField)
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

        /// <summary>
        /// 从数据库中获取数据表记录
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static ITable queryTable(string tableName, string whereClause)
        {

            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            string query = "select * from " + tableName + " where 1=1 and " + whereClause;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            string qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            if (ws.OpenQueryCursor(query).NextRow() == null)
            {
                return null;
            }
            ITable table = ws.OpenQueryClass(qName, q);
            return table;
        }

        /// <summary>
        /// 从数据表中查询指定的记录并创建图层
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static IFeatureLayer queryLayer(string tableName, string whereClause)
        {
            //创建Layer对象的数据记录SHAPE不能为空，否则报错
            whereClause += " and SHAPE is not null";
            ITable fc = queryTable(tableName, whereClause);
            if (fc == null)
            {
                return null;
            }
            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = fc as IFeatureClass;
            return layer;
        }

        /// <summary>
        /// 从指定的要素集中进行空间查询
        /// </summary>
        /// <param name="featureClass">查询的要素集</param>
        /// <param name="geometry">查询参数几何图形</param>
        /// <param name="spatialRelationship">空间关系</param>
        /// <returns></returns>
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

        /// <summary>
        /// 获取多边形的折点集合
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
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


        /// <summary>
        ///检查几何图形的坐标是否为指定的投影带内
        /// </summary>
        /// <param name="geometry"></param>
        public static void checkGeometryCoordinates(IGeometry geometry)
        {
            IPoint p = geometry.Envelope.LowerLeft;
            if(p.X - PCS.FalseEasting < 0)
            {
                throw new Exception("坐标值不在投影坐标系允许的范围内，请检查坐标值、带号等是否正确。");
            }
        }
    }
}
