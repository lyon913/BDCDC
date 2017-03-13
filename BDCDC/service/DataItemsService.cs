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
                return ctx.DataItems
                    .Where(item => item.typeName == type)
                    .OrderBy(item => item.itemOrder ?? 999)
                    .ThenBy(item=>item.fid)
                    .ToList();
            });
            
        }


    }
}
