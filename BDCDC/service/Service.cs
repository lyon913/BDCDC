using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        private void setAuditInfo(BaseEntity entity)
        {
            bool isCreate = entity.fId == 0 ? true : false;

            if (entity is BaseAuditEntity)
            {
                //BaseAuditEntity audit = (BaseAuditEntity)entity;
                if (isCreate)
                {
                    ((BaseAuditEntity)entity).QXDM = "9999";
                    ((BaseAuditEntity)entity).QXMC = "审计功能未实现";
                    ((BaseAuditEntity)entity).fCreateTime = DateTime.Now;
                    ((BaseAuditEntity)entity).fCreatorId = 9999;
                    ((BaseAuditEntity)entity).fCreatorIp = "0.0.0.0";
                    ((BaseAuditEntity)entity).fCreatorLoginName = "test_user_1";
                    ((BaseAuditEntity)entity).fCreatorName = "审计功能未实现";
                }

                ((BaseAuditEntity)entity).fLstUpdateTime = DateTime.Now;
                ((BaseAuditEntity)entity).fLastUpdaterId = 9999;
                ((BaseAuditEntity)entity).fLastUpdaterIp = "0.0.0.0";
                ((BaseAuditEntity)entity).fLastUpdaterLoginName = "test_user_1";
                ((BaseAuditEntity)entity).fLastUpdaterName = "审计功能未实现";
            }
        }
    }
}
