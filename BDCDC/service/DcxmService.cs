using BDCDC.model;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class DcxmService : Service
    {
        public static String QJDCXM_PREFIX = "QD";

        public void save(QJDCXM xm)
        {
            xm.XMBH = generateXmbh();
            insertOrUpdate(xm);
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
            return QJDCXM_PREFIX+DateTime.Now.ToShortTimeString();
        }

        public ZDJBXX newZdjbxx(int dcxmId, IFeature feature)
        {
            ZDJBXX zd = new ZDJBXX();
            zd.SHAPE = ArcgisService.featureToDbGeometry(feature);
            zd.ZDDM = "尚未编号";
            zd.ZT = 0;
            zd.QJDCXMID = dcxmId;
            return zd;
        }

        public IFeatureLayer getDcxmZdLayer(int dcxmId)
        {
            if(countZdByDcxmId(dcxmId) == 0)
            {
                return null;
            }

            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            String query = "select * from ZDJBXX where QJDCXM_ID=" + dcxmId;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            q.GeometryType = esriGeometryType.esriGeometryPolygon;
            String qName = "";
            ws.CheckDatasetName("ZDJBXX", q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.Name = "宗地";
            layer.FeatureClass = table as IFeatureClass;

            return layer;
        }

        public List<QJDCXM> getTodoList()
        {
            return useDbContext(ctx => {
                return ctx.QJDCXM.Where(xm => xm.ZT == 0 ).OrderByDescending(xm=>xm.SLRQ).ToList();
            });
        }

        public int countZdByDcxmId(int dcxmId)
        {
            return useDbContext(ctx => {
                return ctx.ZDJBXX.Where(zd => zd.QJDCXMID == dcxmId).Count();
            });
        }

        public List<ZDJBXX> getZdjbxxByDcxmId(int dcxmId)
        {
            return useDbContext(ctx => {
                return ctx.ZDJBXX.Where(zd => zd.QJDCXMID == dcxmId).ToList();
            });
        }
    }
}
