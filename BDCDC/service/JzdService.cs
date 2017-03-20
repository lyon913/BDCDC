using BDCDC.model;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    class JzdService : Service
    {
        public List<JZD> getJzdListFromZdjbxx(ZDJBXX zd)
        {
            Polygon p = (Polygon)ArcgisService.dbGeometryToGeometry(zd.SHAPE);
            int? pCount = p.PointCount;
            List<JZD> list = new List<JZD>();
            for (int i = 0; i < pCount; i++)
            {
                IPoint point = p.Point[i];
                double x = point.X;
                double y = point.Y;
                JZD d = new JZD();
                d.ZDDM = zd.ZDDM;

                d.SXH = i + 1;
                d.X = Decimal.Round(new Decimal(x),3);
                d.Y = Decimal.Round(new Decimal(y),3);
                list.Add(d);
            }

            return list;
        }
    }
}
