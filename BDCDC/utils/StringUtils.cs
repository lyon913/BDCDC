using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.utils
{
    class StringUtils
    {
        /**
         * 字符型顺序号加1
         * 如：StringUtils.addSxh.("001",5) 输出:"00002"
         **/
        public static String addSxh(String sxh, int pad)
        {
            if (sxh == null || "".Equals(sxh))
            {
                sxh = "0";
            }
            //转为int
            int sxh_int = Int32.Parse(sxh);
            //+1
            sxh_int++;

            String pad_str = "".PadRight(pad, '0');
            //格式化为X位字符串
            sxh = pad_str + sxh_int.ToString();
            sxh = sxh.Substring(sxh.Length - pad, pad);
            return sxh;
        }
    }
}
