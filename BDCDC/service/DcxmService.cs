using BDCDC.model;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public static String ZD_ANNOTATION_FIELD = "ZDDM";

        public static String ZRZ_LAYER_NAME = "自然幢";
        public static String ZRZ_TABLE_NAME = "ZRZ";
        public static String ZRZ_ANNOTATION_FIELD = "JZWMC";

        public class LayerInfo
        {
            public String layerName { get; set; }
            public String tableName { get; set; }
            public String annoField { get; set; }
        }

        public List<LayerInfo> getLayerInfos()
        {
            List<LayerInfo> result = new List<LayerInfo>();

            LayerInfo zd = new LayerInfo();
            zd.layerName = ZD_LAYER_NAME;
            zd.tableName = ZD_TABLE_NAME;
            zd.annoField = ZD_ANNOTATION_FIELD;
            result.Add(zd);

            LayerInfo zrz = new LayerInfo();
            zrz.layerName = ZRZ_LAYER_NAME;
            zrz.tableName = ZRZ_TABLE_NAME;
            zrz.annoField = ZRZ_ANNOTATION_FIELD;
            result.Add(zrz);

            return result;
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
