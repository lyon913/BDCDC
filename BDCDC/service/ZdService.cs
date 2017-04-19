using BDCDC.model;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDCDC.service
{
    /**
     * 宗地相关业务类
     * */
    class ZdService:Service
    {
        private static String REGEX_ZDDM = @"\d{12}(G|J)(A|B|C|D|E|F|G|H|S|X|W|Y)\d{5}";
        private static String REGEX_BDCDYH = @"\d{12}(G|J)(A|B|C|D|E|F|G|H|S|X|W|Y)\d{5}(W|F|L|Q)\d{8}";

        public ZDJBXX newZdjbxx()
        {
            ZDJBXX zd = new ZDJBXX();
            zd.ZT = 0;
            return zd;
        }

        public void saveOrUpdate(ZDJBXX zd)
        {
            useTransaction(ctx =>
            {
                insertOrUpdate(zd,ctx);
                return zd;
            });
        }

        /**
         * 获取地籍子区内的宗地顺序号可取的值（当前最大值+1）
         * 
         * */
        public String getMaxZdsxh(String djzq)
        {
            return useDbContext(ctx =>
            {
                //宗地代码编制规则：
                //6位行政区划码 + 3位地籍区码 + 3位地籍子区码 + 2位特征码（GB、JA等） + 5位宗地顺序号（00001-99999）

                //查询该地籍子区下当前最大的顺序号
                String sql = "SELECT max(right(zddm,5))  from ZDJBXX where ZT in(0,1) and ZDDM like {0}+'%'";
                String sxh = ctx.Database.SqlQuery<String>(sql, djzq).Single();
                sxh = StringUtils.addSxh(sxh, 5);
                return sxh;
            });
            
        }


        public String getMaxDzwsxh(String zddm, String dzwtzm)
        {
            return useDbContext(ctx => {
                if ("W".Equals(dzwtzm))
                {
                    //使用权宗地无定着物
                    return "00000000";
                }
                else if ("L".Equals(dzwtzm) || "Q".Equals(dzwtzm))
                {
                    //林地或其他
                    String sql = "SELECT max(right(zddm,8))  from ZDJBXX where BDCDYH like {0}+{1}+'%' and ZT in(0,1)";
                    String sxh = ctx.Database.SqlQuery<String>(sql, zddm, dzwtzm).Single();
                    sxh = StringUtils.addSxh(sxh, 8);
                    return sxh;
                }
                else
                {
                    throw new Exception("不支持的定着物类型");
                }
            });
            
        }


        /**
         * 取出地籍子区，按代码排序
         * 
         * */
        public List<DJZQ> getDjzqAll()
        {
            return useDbContext(ctx => {
                return ctx.DJZQ.OrderBy(djzq => djzq.DJZQDM).ToList();
            });
            
        }

        public List<DataItems> getDjzqAsDataItems()
        {
            List<DJZQ> djzqList = getDjzqAll();
            List<DataItems> result = new List<DataItems>();

            foreach(DJZQ djzq in djzqList)
            {
                DataItems item = new DataItems();
                item.itemName = djzq.DJZQMC;
                item.itemCode = djzq.DJZQDM;
                result.Add(item);
            }

            return result;

        }

        public List<ZDJBXX> findByDcxm(int dcxmId)
        {
            return useDbContext(ctx => {
                return ctx.ZDJBXX.Where(zd => zd.QJDCXMID == dcxmId).ToList();
            });
            
        }


        public ZDJBXX findZdjbxxById(int zdId)
        {
            return useDbContext(ctx => {
                return ctx.ZDJBXX.Where(zd => zd.fId == zdId).Single();
            });
        }
        public ZDJBXX findZdjbxxByZdmd(String zddm)
        {
            if(zddm == null)
            {
                return null;
            }
            return useDbContext(ctx => {
                List<ZDJBXX> list = ctx.ZDJBXX.Where(zd => zd.ZDDM == zddm && (zd.ZT == 0 || zd.ZT == 1)).ToList();
                if(list.Count == 1)
                {
                    return list[0];
                }
                if(list.Count == 0)
                {
                    return null;
                }else
                {
                    throw new Exception("查找到多个重复的宗地号");
                }
            });
        }

        public decimal? getZdmjByZdmd(String zddm)
        {
            ZDJBXX zd = findZdjbxxByZdmd(zddm);
            if(zd == null)
            {
                return null;
            }
            return zd.ZDMJ;
        }




        public bool checkZddm(String zddm)
        {
            if(zddm == null)
            {
                return false;
            }
            return Regex.Match(zddm, REGEX_ZDDM).Success;
        }

        public bool checkZddmDuplicate(String zddm)
        {
            useDbContext(ctx =>
            {
                int count = ctx.ZDJBXX.Where(zd=>zd.ZDDM == zddm && (zd.ZT == 0||zd.ZT == 1)).Count();
                return count > 0;
            });
            return true;
        }

        public bool checkBdcdyh(String bdcdyh)
        {
            if (bdcdyh == null)
            {
                return false;
            }
            return Regex.Match(bdcdyh, REGEX_BDCDYH).Success;
        }
        
        

    }
}
