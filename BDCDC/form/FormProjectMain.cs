using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Maplex;
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
        public static String ZD_LAYER_NAME = "宗地";
        public static String ZRZ_LAYER_NAME = "自然幢";

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

            /*
            IAnnotateMap pAnnotateMap;
            pAnnotateMap = new MaplexAnnotateMapClass();
            mapControl.Map.AnnotationEngine = pAnnotateMap;
            */
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
            loadTree();
            loadMapLayers();
        }

        private void loadTree()
        {
            removeAllTreeNode();

            TreeNode nodeZd = new TreeNode();
            nodeZd.Text = ZD_LAYER_NAME;

            List<ZDJBXX> zdList = dcServ.getZdjbxxByDcxmId(dcxm.fId);
            foreach(ZDJBXX zd in zdList)
            {
                TreeNode node = new TreeNode(zd.ZDDM);
                node.Tag = zd;
                nodeZd.Nodes.Add(node);
            }

            this.tv_zd.Nodes.Add(nodeZd);
            this.tv_zd.ExpandAll();
        }

        private void removeAllTreeNode()
        {
            this.tv_zd.Nodes.Clear();
        }

        private void loadMapLayers()
        {
            ArcgisService.removeAllLayers(this.mapControl);
            IFeatureLayer zdLayer = dcServ.getDcxmZdLayer(dcxm.fId);
            if(zdLayer != null)
            {
                ArcgisService.enableFeatureLayerLabel(zdLayer,"ZDDM",ArcgisService.getRgbColor(200,0,0),10);
                //ArcgisService.annotateLayer(zdLayer as IGeoFeatureLayer, "ZDDM");
                mapControl.AddLayer(zdLayer);
                mapControl.Refresh();
            }
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

        private void tv_zd_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            object data = node.Tag;
            if(data != null && data is BaseEntity)
            {
                int id = (data as BaseEntity).fId;
                if (data is ZDJBXX)
                {
                    String where = "fId=" + id;
                    ArcgisService.selectMapFeatures(where, ZD_LAYER_NAME, this.mapControl);
                }
            }
            else
            {
                ArcgisService.clearMapSelection(this.mapControl);
            }
        }
    }
}
