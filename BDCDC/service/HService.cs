using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class HService:Service
    {
        public H newH(ZRZ zrz, LJZ ljz)
        {
            H h = new H();
            h.ZT = 0;
            h.ZRZH = zrz.ZRZH;
            h.ZRZBDCDYH = zrz.BDCDYH;
            h.LJZH = ljz.LJZH;
            h.LJZID = ljz.fId;

            h.FWYT1 = ljz.FWYT1;
            h.FWYT2 = ljz.FWYT2;
            h.FWYT3 = ljz.FWYT3;
            h.FWLX = "1";
            h.FWXZ = "99";

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
    }
}
