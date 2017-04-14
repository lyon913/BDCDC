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
        public List<H> findByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.H.Where(h => h.QJDCXMID == dcxmId && (h.ZT == 0 || h.ZT == 1)).ToList();
            });
        }
    }
}
