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

namespace BDCDC.service
{
    class ArcgisService
    {
        public static class CAD_FEATURE_TYPE
        {
            public static String POLYGON = "Polygon";
            public static String ANNOTATION = "Annotation";
            public static String POLYLINE = "Polyline";
            public static String POINT = "Point";
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
            props.SetProperty("database", "bdcdj"); // Only if it is needed
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
