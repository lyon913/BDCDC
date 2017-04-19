using ESRI.ArcGIS.Carto;
using System.Collections.Generic;

namespace BDCDC.vo
{
    class BasicLayers
    {
        public IFeatureLayer XZQ { get; set; }
        public IFeatureLayer DJQ { get; set; }
        public IFeatureLayer DJZQ { get; set; }
        public IFeatureLayer ZDJBXX { get; set; }
        public IFeatureLayer ZRZ { get; set; }
        public IFeatureLayer JZD { get; set; }

        public List<IFeatureLayer> getAllLayers()
        {
            List<IFeatureLayer> list = new List<IFeatureLayer>();
            list.Add(XZQ);
            list.Add(DJQ);
            list.Add(DJZQ);
            list.Add(ZDJBXX);
            list.Add(ZRZ);
            list.Add(JZD);
            return list;
        }
    }
}
