using BDCDC.model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDCDC.service
{
    class LjzService : Service
    {
        public LJZ newLjz(ZRZ zrz)
        {
            LJZ ljz = new LJZ();
            ljz.ZT = 0;
            ljz.ZRZH = zrz.ZRZH;
            ljz.ZRZBDCDYH = zrz.BDCDYH;
            ljz.FWYT1 = zrz.GHYT;
            ljz.FWJG1 = zrz.FWJG;
            ljz.SCJZMJ = zrz.SCJZMJ;
            ljz.YCJZMJ = zrz.YCJZMJ;
            ljz.JGRQ = zrz.JGRQ;
            ljz.ZTS = zrz.ZTS;
            ljz.ZCS = zrz.ZCS;
            ljz.DSCS = zrz.DSCS;
            ljz.DXCS = zrz.DXCS;

            return ljz;
        }

        public LJZ findById(int ljzId)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Where(l => l.fId == ljzId).Single();
            });
        }

        /// <summary>
        /// 根据调查项目ID查找逻辑幢
        /// </summary>
        /// <param name="dcxmId"></param>
        /// <returns></returns>
        public List<LJZ> findByDcxmId(int dcxmId)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Join(ctx.H, ljz => ljz.fId, h => h.LJZID, (ljz, h) => new
                {
                    H = h,
                    LJZ = ljz
                }).Where(a => a.H.QJDCXMID == dcxmId).Select(a => a.LJZ).Distinct().OrderBy(a => a.LJZH).ToList();
            });
        }

        /// <summary>
        /// 根据房地产项目id查找逻辑幢
        /// </summary>
        /// <param name="xmid"></param>
        /// <returns></returns>
        public List<LJZ> findByXmId(int xmid)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Where(ljz => ljz.XMID == xmid).OrderBy(a => a.fId).ToList();
            });
        }

        public List<LJZ> findByZrzh(string zrzh)
        {
            return useDbContext(ctx =>
            {
                return ctx.LJZ.Where(ljz => ljz.ZRZH == zrzh && (ljz.ZT ==0 || ljz.ZT == 1)).ToList();
            });
        }

        public LJZ saveOrUpdate(LJZ ljz)
        {
            validate(ljz);
            return useTransaction(ctx =>
            {
                insertOrUpdate(ljz, ctx);
                return ljz;
            });
        }

        private void validate(LJZ ljz)
        {
            if(ljz == null)
            {
                throw new Exception("逻辑幢对象为空");
            }

            //住建导入的逻辑幢存在暂时无自然幢号的情况
            //if (String.IsNullOrEmpty(ljz.ZRZH))
            //{
                //throw new Exception("自然幢号不能为空");
            //}

            //if (String.IsNullOrEmpty(ljz.ZRZBDCDYH))
            //{
            //    throw new Exception("自然幢不动产单元号不能为空");
            //}

            if (String.IsNullOrEmpty(ljz.LJZH))
            {
                throw new Exception("逻辑幢号不能为空");
            }
        }
    }
}
