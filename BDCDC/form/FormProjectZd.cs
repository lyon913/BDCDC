using BDCDC.model;
using BDCDC.Properties;
using BDCDC.service;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormProjectZd : Form
    {
        private static int srid = ArcgisService.SRID;

        private static String ZD_LAYER_NAME = "宗地";
        private static String ZRZ_LAYER_NAME = "自然幢";

        private QJDCXM dcxm;
        private ZdService zdServ = new ZdService();
        private ZrzService zrzServ = new ZrzService();
        private DcxmService dcServ = new DcxmService();
        
        public FormProjectZd(QJDCXM dcxm)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            initArcgisControls();
        }

        private void initArcgisControls()
        {
            this.mapControl.Map.SpatialReference = ArcgisService.PCS;
            this.mapControl.Map.Name = "不动产要素图层";
            this.tocControl.SetBuddyControl(this.mapControl);

            this.mapToolbar1.setMapControl(this.mapControl);
            this.mapToolbar1.addButton("编辑属性", Resources.arcgis_EditingPolygonTool32, b_propEdit_Click);

            this.lb_spring.Spring = true;
            this.lb_coords.Alignment = ToolStripItemAlignment.Right;
                        
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

            loadTreeNodes();
        }

        private void loadTreeNodes()
        {
            loadZdNodes();
            loadZrzNodes();

            this.treeVew.ExpandAll();
        }

        private void loadZdNodes()
        {
            TreeNode zdRoot = new TreeNode();
            zdRoot.Text = ZD_LAYER_NAME;
            addZdTreeNode(zdRoot);
            this.treeVew.Nodes.Add(zdRoot);
        }

        private void addZdTreeNode(TreeNode root)
        {
            List<ZDJBXX> zdList = zdServ.findByDcxmId(dcxm.fId);
            foreach (ZDJBXX zd in zdList)
            {
                TreeNode zdNode = new TreeNode();
                zdNode.Text = getZdDisplayText(zd);
                zdNode.Tag = zd;
                addZrzToZdNode(zdNode);

                root.Nodes.Add(zdNode);
            }
        }

        private void addZrzToZdNode(TreeNode zdNode)
        {
            if(zdNode == null || zdNode.Tag == null)
            {
                return;
            }
            if(!(zdNode.Tag is ZDJBXX))
            {
                return;
            }
            ZDJBXX zd = zdNode.Tag as ZDJBXX;
            if(zd.ZDDM == null)
            {
                return;
            }
            List<ZRZ> zList = zrzServ.findByDcxmIdAndZddm(zd.QJDCXMID, zd.ZDDM);
            foreach(ZRZ zrz in zList)
            {
                TreeNode zNode = new TreeNode();
                zNode.Text = getZrzDisplayText(zrz);
                zNode.Tag = zrz;
                zdNode.Nodes.Add(zNode);
            }
        }

        private void loadZrzNodes()
        {
            TreeNode zrzRoot = new TreeNode(ZRZ_LAYER_NAME);
            treeVew.Nodes.Add(zrzRoot);

            List<ZRZ> zrzList = zrzServ.findByDcxmId(dcxm.fId);
            foreach (ZRZ zrz in zrzList)
            {
                TreeNode zrzNode = new TreeNode();
                zrzNode.Text = getZrzDisplayText(zrz);
                zrzNode.Tag = zrz;
                zrzRoot.Nodes.Add(zrzNode);
            }
        }

        private String getZdDisplayText(ZDJBXX zd)
        {
            return zd.ZDDM == null ? "未编号宗地" : zd.ZDDM;
        }

        private String getZrzDisplayText(ZRZ zrz)
        {
            return zrz.ZRZH == null ? "未编号建筑物" : (zrz.ZRZH + "(" + zrz.JZWMC + ")");
        }

        private void removeAllTreeNode()
        {
            this.treeVew.Nodes.Clear();
        }

        private void loadMapLayers()
        {
            ArcgisService.removeAllLayers(this.mapControl);

            List<IFeatureLayer> layers = dcServ.getDcxmLayers(dcxm.fId);
            foreach(IFeatureLayer layer in layers)
            {
                mapControl.AddLayer(layer);
            }

            //this.mapControl.ActiveView.ScreenDisplay.DisplayTransformation.ScaleRatio = 1000;
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
            DialogResult result = promptEditForm(feature);
            if(result == DialogResult.OK)
            {
                loadData();
            }
        }

        private DialogResult promptEditForm(IFeature feature)
        {
            IFeatureClass fc = feature.Table as IFeatureClass;
            String name = fc.AliasName;
            if (name.Contains("ZDJBXX"))
            {
                ZDJBXX zd = zdServ.findById(feature.OID);
                FormZdjbxx form = new FormZdjbxx(zd);
                return form.ShowDialog(this);
            }
            else if (name.Contains("ZRZ"))
            {
                ZRZ zrz = zrzServ.findById(feature.OID);
                FormZrz form = new FormZrz(zrz);
                return form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("仅支持宗地和自然幢图层属性编辑。");
                return DialogResult.Abort;
            }
        }

        private void b_importZd_Click(object sender, EventArgs e)
        {
            DialogCadImport d = new DialogCadImport(EnumFeatureType.Polygon);
            if (d.ShowDialog(this) == DialogResult.OK)
            {
                List<IFeature> features = d.getFeatures();
                dcServ.importZdFeatures(dcxm.fId, features);
                loadData();
            }
        }

        private void b_importZrz_Click(object sender, EventArgs e)
        {


            DialogCadImport d = new DialogCadImport(EnumFeatureType.Polygon);
            if (d.ShowDialog(this) == DialogResult.OK)
            {
                List<IFeature> features = d.getFeatures();
                dcServ.importZrzFeatures(dcxm.fId, features);
                loadData();
            }
        }


        private void tv_zd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ArcgisService.clearMapSelection(this.mapControl);
            TreeNode node = e.Node;
            object data = node.Tag;
            if (data != null && data is BaseEntity)
            {
                int id = (data as BaseEntity).fId;
                if (data is ZDJBXX)
                {
                    String where = "fId=" + id;
                    ArcgisService.selectMapFeatures(where, ZD_LAYER_NAME, this.mapControl);
                }
                else if (data is ZRZ)
                {
                    String where = "fId=" + id;
                    ArcgisService.selectMapFeatures(where, ZRZ_LAYER_NAME, this.mapControl);
                }
            }
        }

        private void treeVew_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            b_propEdit_Click(sender,e);
        }

        private void b_importJzd_Click(object sender, EventArgs e)
        {
            ZDJBXX zd = getSelectedZdjbxx();
            if(zd == null)
            {
                return;
            }
            FormJzdJzx f = new FormJzdJzx(dcxm, zd);
            f.ShowDialog(this);
        }

        private ZDJBXX getSelectedZdjbxx()
        {
            
            TreeNode selectedNode = treeVew.SelectedNode;
            if(selectedNode == null)
            {
                MessageBox.Show("请先选择一个宗地。");
                return null;
            }
            if(!(selectedNode.Tag is ZDJBXX))
            {
                MessageBox.Show("请先选择一个宗地。");
                return null;
            }

            ZDJBXX zd = selectedNode.Tag as ZDJBXX;
            if(zd.ZDDM == null || zd.BDCDYH == null)
            {
                MessageBox.Show("宗地尚未编号。");
                return null;
            }

            return zd;

        }

        private void mapControl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            this.lb_coords.Text = "坐标 " + e.mapX.ToString("0.000") + "  " + e.mapY.ToString("0.000");
            
        }

        private void mapControl_OnViewRefreshed(object sender, IMapControlEvents2_OnViewRefreshedEvent e)
        {
            double scale = mapControl.MapScale;
            this.lb_scale.Text = "比例尺 1:"+Math.Round(scale);
        }
    }
}
