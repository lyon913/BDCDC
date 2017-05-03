using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class XmService : Service
    {

        public XM newXm()
        {
            XM xm = new XM();
            return xm;
        }

        public void save(XM xm)
        {
            validate(xm);
            useTransaction(ctx =>
            {
                insertOrUpdate(xm, ctx);
                return xm;
            });
        }

        public void validate(XM xm)
        {
            if (String.IsNullOrEmpty(xm.XMMC))
            {
                throw new Exception("项目名称不能为空。");
            }

            if (String.IsNullOrEmpty(xm.XMZL))
            {
                throw new Exception("项目坐落不能为空。");
            }
        }

        public List<XM> search(string xmmc, string kfqymc, string xmzl)
        {
            return useDbContext(ctx =>
            {
                IQueryable<XM> query = ctx.XM.AsQueryable<XM>();
                if (!String.IsNullOrEmpty(xmmc))
                {
                    query.Where(xm => xm.XMMC.Contains(xmmc));
                }

                if (!String.IsNullOrEmpty(kfqymc))
                {
                    query.Where(xm => xm.KFSMC.Contains(kfqymc));
                }

                if (!String.IsNullOrEmpty(xmzl))
                {
                    query.Where(xm => xm.XMZL.Contains(xmzl));
                }

                return query.OrderByDescending(xm => xm.fId).ToList();
            });
        }
    }
}
