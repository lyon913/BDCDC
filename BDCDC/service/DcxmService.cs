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
            return QJDCXM_PREFIX;
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
            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;
            /*
            IQueryDef queryDef = ws.CreateQueryDef();
            queryDef.Tables = "bdcdj1016.dbo.ZRZ";
            queryDef.WhereClause = "QJDCXM_ID = " + dcxmId;
            IFeatureDataset featureDataset = ws.OpenFeatureQuery("bdcdj1016.dbo.ZRZ", queryDef);
            IFeatureClassContainer featureClassContainer = (IFeatureClassContainer)featureDataset;
            IFeatureClass featureClass = featureClassContainer.get_ClassByName("bdcdj1016.dbo.ZRZ");
            */

            int zdCount = countZdByDcxmId(dcxmId);
            if(zdCount == 0)
            {
                return null;
            }

            String query = "select fId,shape from ZDJBXX where QJDCXM_ID=" + dcxmId;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            q.GeometryType = esriGeometryType.esriGeometryPolygon;

            String qName = "";
            ws.CheckDatasetName("ZDJBXX", q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = table as IFeatureClass;
            layer.Name = "宗地";

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
    }
}
