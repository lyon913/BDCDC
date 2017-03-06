using BDCDC.model;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class ZrzService : Service
    {
        public ZRZ newZRZ(int dcxmId, String zddm, String zdBdcdyh,DbGeometry shape)
        {
            ZRZ z = new ZRZ();
            z.JZWMC = "未编号建筑物";
            z.ZDBDCDYH = zdBdcdyh;
            z.ZDDM = zddm;
            z.ZT = 0;
            z.SHAPE = shape;
            z.QJDCXMID = dcxmId;
            return z;
        }

        //自动获取自然幢顺序号
        public String getZrzsxh(String zddm, BdcContext ctx)
        {
            //自然幢不动产单元号规则：
            //宗地代码 + F + 4位幢顺序号（0001-9999） + 0000

            //查询宗地下当前最大的顺序号
            String sql = "SELECT max(right(BDCDYH,8))  from ZRZ where BDCDYH like {0}+'F%'";
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

        public List<ZRZ> getZrzByDcxmIdAndZddm(int dcxmId, String zddm)
        {
            return useDbContext(ctx =>
            {
                return ctx.ZRZ.Where(z => z.QJDCXMID == dcxmId && z.ZDDM == zddm).ToList();
            });
        }

        public ZRZ getZrzById(int zrzId)
        {
            return useDbContext(ctx => {
                return ctx.ZRZ.Where(zd => zd.fId == zrzId).Single();
            });
        }
    }
}
