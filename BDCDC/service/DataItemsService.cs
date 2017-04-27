using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDCDC.service
{
    class DataItemsService:Service
    {
        
        public List<DataItems> getItemsByType(string type)
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

        public string translateDataItem(string type,string itemCode)
        {
            return useDbContext(ctx =>
            {
                DataItems result = ctx.DataItems
                    .Where(item => item.typeName == type && item.itemCode == itemCode).Single();
                return result.itemName;
            });
        }


    }
}
