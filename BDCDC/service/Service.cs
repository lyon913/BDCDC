using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    public class Service
    {


        protected TResult useTransaction<TResult>(Func<BdcContext, TResult> action)
        {
            using (var __dbcontext = new BdcContext())
            {
                using (var tx = __dbcontext.Database.BeginTransaction())
                {
                    try
                    {

                        TResult result = (TResult)action.DynamicInvoke(__dbcontext);
                        __dbcontext.SaveChanges();
                        tx.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        throw ex;
                    }

                }

            }
        }
        protected TResult useDbContext<TResult>(Func<BdcContext, TResult> action)
        {
            using (var __dbcontext = new BdcContext())
            {
                return (TResult)action.DynamicInvoke(__dbcontext);
            }
        }

        protected void insertOrUpdate(BaseEntity entity,DbContext ctx)
        {
                setAuditInfo(entity);

                ctx.Entry(entity).State = entity.fId == 0 ?
                                   EntityState.Added :
                                   EntityState.Modified;

        }

        protected DbRawSqlQuery<T> createSqlQuery<T>(String sqlQuery,object[] param)
        {
            return useDbContext(ctx => {
                return ctx.Database.SqlQuery<T>(sqlQuery, param);
            });
        }


        private void setAuditInfo(BaseEntity entity)
        {
            bool isCreate = entity.fId == 0 ? true : false;
           
            if (entity is BaseAuditEntity)
            {
                SysUser u = UserService.getCurrentUser();
                if (isCreate)
                {
                    ((BaseAuditEntity)entity).QXDM = u.QXDM;
                    ((BaseAuditEntity)entity).QXMC = u.QXMC;
                    ((BaseAuditEntity)entity).fCreateTime = DateTime.Now;
                    ((BaseAuditEntity)entity).fCreatorId = u.fId;
                    ((BaseAuditEntity)entity).fCreatorIp = "0.0.0.0";
                    ((BaseAuditEntity)entity).fCreatorLoginName = u.DLM;
                    ((BaseAuditEntity)entity).fCreatorName = u.XM;
                }

                ((BaseAuditEntity)entity).fLstUpdateTime = DateTime.Now;
                ((BaseAuditEntity)entity).fLastUpdaterId = u.fId;
                ((BaseAuditEntity)entity).fLastUpdaterIp = "0.0.0.0";
                ((BaseAuditEntity)entity).fLastUpdaterLoginName = u.DLM;
                ((BaseAuditEntity)entity).fLastUpdaterName = u.XM;
            }
        }
    }
}
