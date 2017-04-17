using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class LjzService:Service
    {
        public LJZ newLjz(ZRZ zrz)
        {
            LJZ ljz = new LJZ();
            ljz.ZT = 0;
            ljz.ZRZH = zrz.ZRZH;
            ljz.ZRZBDCDYH = zrz.BDCDYH;

            return ljz;
        }
        public List<LJZ> findByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Join(ctx.H, ljz => ljz.fId, h => h.LJZID, (ljz, h) => new
                {
                    H = h,
                    LJZ = ljz
                }).Where(a => a.H.QJDCXMID == dcxmId).Select(a => a.LJZ).ToList();
            });
        }

        public List<LJZ> findByZrzh(string zrzh)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Where(ljz => ljz.ZRZH == zrzh && (ljz.ZT ==0 || ljz.ZT == 1)).ToList();
            });
        }
    }
}
