using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormProjectMain : Form
    {
        private QJDCXM dcxm;
        private ZdService zdServ = new ZdService();
        private DcxmService dcServ = new DcxmService();

        public FormProjectMain(QJDCXM dcxm)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            initArcgisControls();
        }

        private void initArcgisControls()
        {
            this.tocControl.SetBuddyControl(this.mapControl);
            this.toolbarControl.SetBuddyControl(this.mapControl);
            UiUtils.initArcgisToolbar(this.toolbarControl);
        }

        private void b_importZd_Click(object sender, EventArgs e)
        {
            DialogCadImport d = new DialogCadImport();
            if(d.ShowDialog() == DialogResult.OK)
            {
                List<IFeature> features = d.getFeatures();
                foreach(IFeature feature in features)
                {
                    ZDJBXX zd = dcServ.newZdjbxx(dcxm.fId, feature);
                    zdServ.saveOrUpdate(zd);
                }
            }

            loadData();
        }


        private void FormProjectMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            loadMapLayers();
        }

        private void loadMapLayers()
        {


            removeAllLayers();
            IFeatureLayer zdLayer = dcServ.getDcxmZdLayer(dcxm.fId);
            if(zdLayer != null)
            {
                mapControl.AddLayer(zdLayer);
            }
            
        }

        private void removeAllLayers()
        {
            int count = mapControl.Map.LayerCount;
            for(var i = 0; i< count; i++)
            {
                mapControl.DeleteLayer(i);
            }
            mapControl.Refresh();
        }

        private void b_propEdit_Click(object sender, EventArgs e)
        {
            List<IFeature> features = ArcgisService.getFeaturesFromMapSelection(mapControl);
            if(features == null || features.Count == 0)
            {
                MessageBox.Show("请选择要编辑的图形。");
                return;
            }else if(features.Count > 1)
            {
                MessageBox.Show("每次只能选一个图形进行编辑。");
                return;
            }

            IFeature feature = features[0];
            promptEditForm(feature);

        }

        private void promptEditForm(IFeature feature)
        {
            IFeatureClass fc = feature.Table as IFeatureClass;
            String name = fc.AliasName;
            if (name.Contains("ZDJBXX"))
            {
                ZDJBXX zd = zdServ.getZdjbxxById(feature.OID);
                FormZdjbxx form = new FormZdjbxx(zd);
                form.ShowDialog(this);
            }
            else if (name.Contains("ZRZ"))
            {

            }else
            {
                MessageBox.Show("仅支持宗地和自然幢图层属性编辑。");
            }
        }

        private void b_importZrz_Click(object sender, EventArgs e)
        {

        }
    }
}
