using System;
using System.Text.RegularExpressions;

namespace BDCDC.utils
{
    class StringUtils
    {
        private static string REGEX_ZDDM = @"\d{12}(G|J)(A|B|C|D|E|F|G|H|S|X|W|Y)\d{5}";
        private static string REGEX_BDCDYH = @"\d{12}(G|J)(A|B|C|D|E|F|G|H|S|X|W|Y)\d{5}(W|F|L|Q)\d{8}";

        /// <summary>
        /// 字符型顺序号加1
        /// 如：StringUtils.addSxh.("001",5) 输出:"00002"
        /// </summary>
        /// <param name="sxh">顺序号</param>
        /// <param name="pad">输入位数，不足用0占位</param>
        /// <returns>增加后的顺序号</returns>
        public static string addSxh(string sxh, int pad)
        {
            if (sxh == null || "".Equals(sxh))
            {
                sxh = "0";
            }
            //转为int
            int sxh_int = int.Parse(sxh);
            //+1
            sxh_int++;

            string pad_str = "".PadRight(pad, '0');
            //格式化为X位字符串
            sxh = pad_str + sxh_int.ToString();
            sxh = sxh.Substring(sxh.Length - pad, pad);
            return sxh;
        }

        /// <summary>
        /// 格式化日期类型
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string formatDateTime(DateTime? dateTime, string format)
        {
            return dateTime != null ? dateTime.Value.ToString(format) : "";
        }

        /// <summary>
        /// 检查不动产单元号是否符合国标规则
        /// </summary>
        /// <param name="bdcdyh">不动产单元号</param>
        /// <returns>检查结果</returns>
        public static bool checkBdcdyh(string bdcdyh)
        {
            if (String.IsNullOrEmpty(bdcdyh))
            {
                return false;
            }
            return Regex.Match(bdcdyh, REGEX_BDCDYH).Success;
        }

        /// <summary>
        /// 检查总代码是否符合国标规则
        /// </summary>
        /// <param name="zddm">宗地代码</param>
        /// <returns>检查结果</returns>
        public static bool checkZddm(string zddm)
        {
            if (String.IsNullOrEmpty(zddm))
            {
                return false;
            }
            return Regex.Match(zddm, REGEX_ZDDM).Success;
        }
    }
}
