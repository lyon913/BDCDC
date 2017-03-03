using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class DataItemsService:Service
    {
        
        public List<DataItems> getItemsByType(String type)
        {
            return useDbContext(ctx =>
            {
                String sql = "select * from DataItems where typeName={0} order by isNull(itemOrder,999),fid";
                return ctx.DataItems.SqlQuery(sql, type).ToList();
            });
            
        }


    }
}
