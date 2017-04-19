using BDCDC.model;
using BDCDC.utils;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDCDC.service
{
    class ZrzService : Service
    {
        public ZRZ newZrz()
        {
            ZRZ z = new ZRZ();
            z.ZT = 0;
            return z;
        }

        //自动获取自然幢顺序号
        public String getZrzsxh(String zddm, BdcContext ctx)
        {
            //自然幢不动产单元号规则：
            //宗地代码 + F + 4位幢顺序号（0001-9999） + 0000

            //查询宗地下当前最大的顺序号
            String sql = "SELECT max(right(BDCDYH,8))  from ZRZ where ZT in(0,1) and BDCDYH like {0}+'F%'";
            String sxh = ctx.Database.SqlQuery<String>(sql, zddm).Single();
            if(sxh == null)
            {
                sxh = "00000000";
            }
            //截取前四位
            sxh = sxh.Substring(0, 4);

            //当前最大值+1
            sxh = StringUtils.addSxh(sxh, 4);
            return sxh;
        }

        //保存或更新 ZRZ
        public void saveOrUpdate(ZRZ zrz)
        {

            useTransaction(ctx =>
            {
                insertOrUpdate(zrz,ctx);
                return zrz;
            });
        }

        public List<ZRZ> findByDcxmIdAndZddm(int dcxmId, String zddm)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.QJDCXMID == dcxmId && z.ZDDM == zddm).ToList();
            });
        }

        public List<ZRZ> findByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.QJDCXMID == dcxmId).ToList();
            });
        }

        public List<ZRZ> findByZddm(string zddm)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.ZDDM == zddm && (z.ZT == 0 || z.ZT == 1)).ToList();
            });
        }

        public List<ZRZ> findByZrzh(string zrzh)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.ZRZH == zrzh && (z.ZT == 0 || z.ZT == 1)).ToList();
            });
        }

        public ZRZ findById(int zrzId)
        {
            return useDbContext(ctx => {
                return ctx.ZRZ.Where(zd => zd.fId == zrzId).Single();
            });
        }

        public List<String> findZddmOfZrz(ZRZ zrz)
        {
            ITable table = ArcgisService.queryTable("ZDJBXX", "ZT in (0,1)");
            IGeometry geom = ArcgisService.dbGeometryToGeometry(zrz.SHAPE);
            List<IFeature> list = ArcgisService.spatialQuery(table as IFeatureClass, geom, esriSpatialRelEnum.esriSpatialRelIntersects);
            List<String> result = new List<string>();
            foreach (IFeature feature in list){
                int idx_zddm = feature.Fields.FindField("ZDDM");
                String dm = feature.Value[idx_zddm].ToString();
                result.Add(dm);
            }
            return result;
        }
    }
}
