using BDCDC.model;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BDCDC.service
{
    public class DcxmService : Service
    {

        public static string QJDCXM_PREFIX = "QD";
        private ZdService zdServ = new ZdService();
        private ZrzService zrzServ = new ZrzService();

        public QJDCXM newQjdcxm(string xmlx)
        {
            QJDCXM dcxm = new QJDCXM();
            dcxm = new QJDCXM();
            dcxm.XMBH = getXmbh();
            dcxm.ZT = 0;
            dcxm.XMLX = xmlx;
            dcxm.DCRQ = DateTime.Now;
            dcxm.SLRQ = DateTime.Now;
            dcxm.SLR = UserService.getCurrentUser().XM;
            return dcxm;
        }

        public class LayerInfo
        {
            public string layerName { get; set; }
            public string tableName { get; set; }
            public string annoExp { get; set; }

            public ISymbol symbol { get; set; }
            public ITextSymbol textSymbol { get; set; }
        }

        public void importZdFeatures(int dcxmId,List<IFeature> features)
        {
            foreach (IFeature feature in features)
            {
                ZDJBXX zd = zdServ.newZdjbxx();
                zd.SHAPE = ArcgisService.featureToDbGeometry(feature);
                zd.QJDCXMID = dcxmId;

                zdServ.saveWithoutValidate(zd);
            }
        }

        public void importZrzFeatures(int dcxmId, List<IFeature> features)
        {
            foreach (IFeature feature in features)
            {
                ZRZ zrz = zrzServ.newZrz(dcxmId);
                zrz.SHAPE = ArcgisService.featureToDbGeometry(feature);
                zrzServ.saveWithoutValidate(zrz);
            }
        }



        public void save(QJDCXM xm)
        {
            validate(xm);
            useTransaction(ctx =>
            {
                
                insertOrUpdate(xm, ctx);
                return xm;
            });

        }

        public void validate(QJDCXM dcxm)
        {
            if (String.IsNullOrEmpty(dcxm.XMMC))
            {
                throw new Exception("项目名称不能为空");
            }
            if (String.IsNullOrEmpty(dcxm.XMLX))
            {
                throw new Exception("项目类型不能为空");
            }
            if (String.IsNullOrEmpty(dcxm.XMBH))
            {
                throw new Exception("项目编号不能为空");
            }

            if (String.IsNullOrEmpty(dcxm.DCDW))
            {
                throw new Exception("调查单位不能为空");
            }

            if (String.IsNullOrEmpty(dcxm.DCDW))
            {
                throw new Exception("调查人不能为空");
            }

            if (dcxm.DCRQ == null)
            {
                throw new Exception("调查日期不能为空");
            }

        }

        public QJDCXM findById(int id)
        {
            return useDbContext(ctx =>
            {
                return ctx.QJDCXM.Where(xm => xm.fId == id).Single();
            });

        }

        public String getXmbh()
        {
            return useDbContext(ctx =>
            {
                String number= ctx.Database.SqlQuery<String>("execute dbo.getSysNo2 'BHLB_QJDC','530124000000'").Single();

                return "QD" + ConfigManager.QXBZ + number;
            });
        }



        public IFeatureLayer getDcxmLayer(int dcxmId, string tableName)
        {
            ISqlWorkspace ws = ArcgisService.openBdcWorkspace() as ISqlWorkspace;

            string query = "select * from " + tableName + " where QJDCXM_ID=" + dcxmId;
            IQueryDescription q = ws.GetQueryDescription(query);
            q.OIDFields = "fId";
            q.GeometryType = esriGeometryType.esriGeometryPolygon;
            string qName = "";
            ws.CheckDatasetName(tableName, q, out qName);
            ITable table = ws.OpenQueryClass(qName, q);

            IFeatureLayer layer = new FeatureLayer();
            layer.FeatureClass = table as IFeatureClass;
            return layer;
        }

        public List<IFeatureLayer> getDcxmLayers(int dcxmId)
        {
            Dictionary<string, string> layerQuerys = new Dictionary<string, string>();
            layerQuerys.Add("ZDJBXX", "QJDCXM_ID=" + dcxmId);
            layerQuerys.Add("ZRZ", "QJDCXM_ID=" + dcxmId);
            layerQuerys.Add("JZD", "QJDCXM_ID=" + dcxmId);
            return LayerConfig.getAllConfigedLayers(layerQuerys);
        }

        public List<QJDCXM> getTodoList()
        {
            return useDbContext(ctx =>
            {
                return ctx.QJDCXM.Where(xm => xm.ZT == 0).OrderByDescending(xm => xm.SLRQ).ToList();
            });
        }

        public int countTableByDcxmId(int dcxmId, string tableName)
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




    }
}
