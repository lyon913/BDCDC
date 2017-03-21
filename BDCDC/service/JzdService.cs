using BDCDC.model;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class JzdService : Service
    {
        public List<JZD> getJzdListFromZdjbxx(ZDJBXX zd)
        {
            List<IPoint> pList = ArcgisService.getPolygonPoints(zd.SHAPE);
            List<JZD> list = new List<JZD>();
            for (int i = 0; i < pList.Count; i++)
            {
                IPoint point = pList[i];
                double x = point.X;
                double y = point.Y;
                JZD d = new JZD();
                d.ZDDM = zd.ZDDM;
                d.JZDLX = "1";
                d.JBLX = "2";
                d.SXH = i + 1;
                d.JZDH = "J" + d.SXH;
                d.X = Decimal.Round(new Decimal(x),3);
                d.Y = Decimal.Round(new Decimal(y),3);
                d.SHAPE = DbGeometry.FromText(wktPoint(x, y));
                list.Add(d);
            }
            return list;
        }

        public List<JZX> generateJzx(ZDJBXX zd, List<JZD> jzdList)
        {
            if(jzdList == null || jzdList.Count < 2)
            {
                return null;
            }
            List<JZX> jzxList = new List<JZX>();
            for(int i = 0; i < jzdList.Count - 1 ; i++)
            {
                JZD b = jzdList[i];
                JZD e = jzdList[i+1];

                JZX x = new JZX();
                x.ZDDM = zd.ZDDM;
                x.QDH = b.JZDH;
                x.ZDH = e.JZDH;
                
                x.JZXCD = (decimal)distance((double)b.X, (double)b.Y, (double)e.X, (double)e.Y);
                x.JXXZ = "";
                x.JZXLB = "";
                x.JZXWZ = "";
                
                
            }
            return jzxList;
        }

        private double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));
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
    }
}
