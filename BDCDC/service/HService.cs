using BDCDC.model;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDCDC.service
{
    class HService:Service
    {
        private ZdService zs = new ZdService();

        public H newH(int dcxmId, ZRZ zrz, LJZ ljz)
        {
            H h = new H();
            h.QJDCXMID = dcxmId;
            h.ZT = 0;
            h.ZRZH = zrz.ZRZH;
            h.ZRZBDCDYH = zrz.BDCDYH;
            h.LJZH = ljz.LJZH;
            h.LJZID = ljz.fId;

            h.FWYT1 = ljz.FWYT1;

            h.FWLX = "1";
            h.FWXZ = "99";

            
            h.GYTDMJ = zs.getZdmjByZdmd(zrz.ZDDM);
            return h;
        }
        public List<H> findByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.H.Where(h => h.QJDCXMID == dcxmId && (h.ZT == 0 || h.ZT == 1)).ToList();
            });
        }

        public List<H> findByLjzId(int ljzId)
        {
            return useDbContext(ctx =>
            {
                return ctx.H.Where(h => h.LJZID == ljzId && (h.ZT == 0 || h.ZT == 1)).ToList();
            });
        }

        public H saveOrUpdate(H h)
        {
            validate(h);

            return useTransaction(ctx =>{
                insertOrUpdate(h, ctx);
                return h;
            });
        }

        public void validate(H h)
        {

        }

        public string getMaxSxh(H h)
        {
            if(h == null)
            {
                throw new Exception("户对象不能为空");
            }
            if (string.IsNullOrEmpty(h.ZRZH))
            {
                throw new Exception("自然幢不能为空");
            }

            return useDbContext(ctx =>
            {
                string zrzh = h.ZRZH;
                string sql = "SELECT max(right(BDCDYH,4))  from H where ZT in(0,1) and BDCDYH like {0}+'%'";
                string sxh = ctx.Database.SqlQuery<String>(sql, zrzh).Single();
                if (sxh == null)
                {
                    sxh = "0000";
                }

                sxh = StringUtils.addSxh(sxh, 4);
                return sxh;
            });
        }

        public string generateZl(H h)
        {
            string zrzZl = 
            return "";
        }
    }
}
