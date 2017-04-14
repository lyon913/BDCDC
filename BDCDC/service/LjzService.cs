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
    }
}
