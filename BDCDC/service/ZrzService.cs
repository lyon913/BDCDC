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
        public ZRZ newZrz(int dcxmId)
        {
            ZRZ z = new ZRZ();
            z.ZT = 0;
            z.QJDCXMID = dcxmId;
            return z;
        }

        //自动获取自然幢顺序号
        public string getZrzsxh(string zddm)
        {
            //自然幢不动产单元号规则：
            //宗地代码 + F + 4位幢顺序号（0001-9999） + 0000

            //查询宗地下当前最大的顺序号
            string sql = "SELECT max(right(BDCDYH,8))  from ZRZ where ZT in(0,1) and BDCDYH like {0}+'F%'";
            string sxh = useDbContext(ctx =>
            {
                return ctx.Database.SqlQuery<string>(sql, zddm).SingleOrDefault();
            });
           
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
            validate(zrz);
            useTransaction(ctx =>
            {
                insertOrUpdate(zrz,ctx);
                return zrz;
            });
        }


        //保存或更新 ZRZ
        public void saveWithoutValidate(ZRZ zrz)
        {
            useTransaction(ctx =>
            {
                insertOrUpdate(zrz, ctx);
                return zrz;
            });
        }

        public void validate(ZRZ zrz)
        {
            if (!StringUtils.checkZddm(zrz.ZDDM))
            {
                throw new Exception("宗地代码无效");
            }

            if (String.IsNullOrEmpty(zrz.BDCDYH))
            {
                throw new Exception("不动产单元号不能为空");
            }

            if (String.IsNullOrEmpty(zrz.ZRZH))
            {
                throw new Exception("自然幢号不能为空");
            }

            if (zrz.SHAPE == null)
            {
                throw new Exception("自然幢图形不能为空");
            }

            if (String.IsNullOrEmpty(zrz.XMMC))
            {
                throw new Exception("项目名称不能为空");
            }

            if (String.IsNullOrEmpty(zrz.JZWMC))
            {
                throw new Exception("建筑物名称不能为空");
            }

            if (String.IsNullOrEmpty(zrz.GHYT))
            {
                throw new Exception("规划用途称不能为空");
            }

            if (String.IsNullOrEmpty(zrz.FWJG))
            {
                throw new Exception("建筑物结构不能为空");
            }

            if (zrz.ZTS == null)
            {
                throw new Exception("总套数不能为空");
            }

            if (zrz.ZCS == null)
            {
                throw new Exception("总层数不能为空");
            }

            if (zrz.ZCS == null)
            {
                throw new Exception("幢占地面积不能为空");
            }

            if (zrz.ZYDMJ == null)
            {
                throw new Exception("幢用地面积不能为空");
            }
            if (zrz.SCJZMJ == null)
            {
                throw new Exception("实测建筑面积不能为空");
            }

        }

        public List<ZRZ> findByDcxmIdAndZddm(int dcxmId, string zddm)
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

        public ZRZ findByZrzh(string zrzh)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.ZRZH == zrzh && (z.ZT == 0 || z.ZT == 1)).SingleOrDefault();
            });
        }

        public ZRZ findById(int zrzId)
        {
            return useDbContext(ctx => {
                return ctx.ZRZ.Where(zd => zd.fId == zrzId).Single();
            });
        }

        public List<string> findZddmIntersectZrz(ZRZ zrz)
        {
            ITable table = ArcgisService.queryTable("ZDJBXX", "ZT in (0,1)");
            IGeometry geom = ArcgisService.dbGeometryToGeometry(zrz.SHAPE);
            List<IFeature> list = ArcgisService.spatialQuery(table as IFeatureClass, geom, esriSpatialRelEnum.esriSpatialRelIntersects);
            List<string> result = new List<string>();
            foreach (IFeature feature in list){
                int idx_zddm = feature.Fields.FindField("ZDDM");
                string dm = feature.Value[idx_zddm].ToString();
                result.Add(dm);
            }
            return result;
        }
    }
}
