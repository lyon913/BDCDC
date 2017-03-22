﻿using BDCDC.model;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class JzdService : Service
    {
        public List<JZD> getJzdListFromShape(ZDJBXX zdjbxx)
        {
            List<IPoint> pList = ArcgisService.getPolygonPoints(zdjbxx.SHAPE);
            List<JZD> list = new List<JZD>();
            for (int i = 0; i < pList.Count; i++)
            {
                IPoint point = pList[i];
                double x = point.X;
                double y = point.Y;
                JZD d = new JZD();
                d.ZDDM = zdjbxx.ZDDM;
                d.JZDLX = "1";
                d.JBLX = "2";
                d.SXH = i + 1;
                d.JZDH = "J" + d.SXH;
                d.X = Decimal.Round(new Decimal(x),3);
                d.Y = Decimal.Round(new Decimal(y),3);
                d.SHAPE = DbGeometry.FromText(wktPoint(x, y));
                d.ZT = 0;
                list.Add(d);
            }
            return list;
        }

        public List<JZX> getJzxListFromJzd(ZDJBXX zdjbxx, List<JZD> jzdList)
        {
            if(jzdList == null || jzdList.Count < 2)
            {
                return null;
            }
            List<JZX> jzxList = new List<JZX>();
            for(int i = 0; i < jzdList.Count ; i++)
            {
                JZD start = jzdList[i];
                int endIndex = i+1;
                if(endIndex== jzdList.Count)
                {
                    endIndex = 0;
                }
                JZD end = jzdList[endIndex];

                JZX x = new JZX();
                x.ZDDM = zdjbxx.ZDDM;
                x.QDH = start.JZDH;
                x.ZDH = end.JZDH;
                double cd = distance((double)start.X, (double)start.Y, (double)end.X, (double)end.Y);
                x.JZXCD = Decimal.Round((decimal)cd,3);
                x.JXXZ = "600001";
                x.JZXLB = "6";
                x.JZXWZ = "2";
                x.ZT = 0;
                jzxList.Add(x);
            }
            return jzxList;
        }

        public void importJzdJzxFromShape(ZDJBXX zdjbxx,int dcxmId)
        {
            List<JZD> jzdList = getJzdListFromShape(zdjbxx);
            List<JZX> jzxList = getJzxListFromJzd(zdjbxx, jzdList);
            useTransaction(ctx =>
            {
                removeAll(zdjbxx.ZDDM, dcxmId);
                saveJzdJzx(zdjbxx.ZDDM, dcxmId, jzdList, jzxList);
                return 1;
            });
        }

        public List<JZD> getJzdListFromDb(String zddm,int dcxmId)
        {
            return useDbContext(ctx => {
                return ctx.JZD.Where(jzd => jzd.ZDDM == zddm && jzd.QJDCXMID == dcxmId && (jzd.ZT >= 0)).ToList();
            });
        }

        public List<JZX> getJzxListFromDb(String zddm, int dcxmId)
        {
            return useDbContext(ctx => {
                return ctx.JZX.Where(jzx => jzx.ZDDM == zddm && jzx.QJDCXMID == dcxmId && (jzx.ZT >= 0)).ToList();
            });
        }

        private double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
        }

        private String wktPoint(double x,double y)
        {
            String wkt = "POINT({0} {1})";
            return String.Format(wkt, x, y);
        }

        private String wktLine(double x1,double y1,double x2,double y2)
        {
            String wkt = "LINESTRING({0} {1},{2} {3})";
            return String.Format(wkt, x1,y1,x2,y2);
        }

        public void saveJzdJzx(String zddm,int dcxmId, List<JZD> jzdList, List<JZX> jzxList)
        {
            checkJzd(jzdList);
            checkJzx(jzxList, jzdList);
            useTransaction(ctx =>
            {
                saveJzdList(zddm, dcxmId, jzdList,ctx);
                saveJzxList(zddm, dcxmId, jzxList, ctx);
                return 1;
            });
        }

        private void saveJzdList(String zddm, int dcxmId, List<JZD> jzdList,DbContext ctx)
        {

            foreach(JZD jzd in jzdList)
            {
                
                jzd.ZDDM = zddm;
                jzd.QJDCXMID = dcxmId;
                if(jzd.SHAPE == null)
                {
                    jzd.SHAPE = DbGeometry.FromText(wktPoint((double)jzd.X, (double)jzd.Y));
                }
                insertOrUpdate(jzd,ctx);
            }
        }

        private void saveJzxList(String zddm, int dcxmId, List<JZX> jzxList, DbContext ctx)
        {
            foreach (JZX jzx in jzxList)
            {
                jzx.ZDDM = zddm;
                jzx.QJDCXMID = dcxmId;
                insertOrUpdate(jzx, ctx);
            }
        }

        private void checkJzd(List<JZD> jzdList)
        {
            if (jzdList == null || jzdList.Count < 3)
            {
                throw new Exception("界址点数量不足，请检查。");
            }
            foreach (JZD jzd in jzdList)
            {
                if (jzd.SXH == null)
                {
                    throw new Exception("顺序号不能为空");
                }
                if (jzd.JZDH == null || jzd.JZDH.Length == 0)
                {
                    throw new Exception("界址点号不能为空");
                }
                if (jzd.X == null || jzd.Y == null)
                {
                    throw new Exception("界址点坐标不能为空。");
                }
            }
        }
        private void checkJzx(List<JZX> jzxList, List<JZD> jzdList)
        {
            if(jzxList == null || jzxList.Count < jzdList.Count)
            {
                throw new Exception("界址线数量不正确。");
            }
            for(int i= 0;i < jzdList.Count; i++) 
            {
                //TODO 检查界址线连接情况是否正确
            }
        }

        public void removeAll(String zddm, int dcxmId)
        {
            useTransaction(ctx =>
            {
                String deleteJzd = "delete JZD where ZDDM=@zddm and QJDCXM_ID=@dcxmId and ZT=0";
                ctx.Database.ExecuteSqlCommand(deleteJzd, new SqlParameter("zddm",zddm), new SqlParameter("dcxmId", dcxmId));

                String deleteJzx = "delete JZX where ZDDM=@zddm and QJDCXM_ID=@dcxmId and ZT=0";
                ctx.Database.ExecuteSqlCommand(deleteJzx, new SqlParameter("zddm", zddm), new SqlParameter("dcxmId", dcxmId));

                return 1;
            });
        }
    }
}
