using BDCDC.model;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class ZrzService
    {
        //自动获取自然幢顺序号
        public String getZrzsxh(String zddm, BdcContext ctx)
        {
            //自然幢不动产单元号规则：
            //宗地代码 + F + 4位幢顺序号（0001-9999） + 0000

            //查询宗地下当前最大的顺序号
            String sql = "SELECT max(right(BDCDYH,8))  from ZRZ where BDCDYH like {0}+'F%' and ZT=1";
            String sxh = ctx.Database.SqlQuery<String>(sql, zddm).Single();
            //截取前四位
            sxh = sxh.Substring(0, 4);

            //当前最大值+1
            sxh = StringUtils.addSxh(sxh, 4);
            return sxh;
        }

        //保存或更新 ZRZ
        public void saveOrUpdate(ZRZ zrz)
        {
            //设置状态为有效
            zrz.ZT = 1;


            //审计信息
            zrz.fLastUpdateTime = DateTime.Now;
            zrz.fLastUpdaterName = "修改操作员姓名";
            zrz.fLastUpdaterId = 0;//操作员id

            //保存
            using (var ctx = new BdcContext())
            {
                ctx.ZRZ.Add(zrz);
                if (zrz.fId == 0)
                {
                    //审计信息
                    zrz.fCreateTime = DateTime.Now;
                    zrz.fCreatorName = "记录创建操作员姓名";
                    zrz.fCreatorId = 0;//操作员id
                    //新增 insert
                    ctx.Entry(zrz).State = EntityState.Added;
                }
                else
                {
                    //更新 update
                    ctx.Entry(zrz).State = EntityState.Modified;
                }
                ctx.SaveChanges();
            }
        }
    }
}
