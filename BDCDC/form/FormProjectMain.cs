using BDCDC.model;
using BDCDC.Properties;
using BDCDC.service;
using BDCDC.utils;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Maplex;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BDCDC.service.DcxmService;

namespace BDCDC.form
{
    public partial class FormProjectMain : Form
    {
        private QJDCXM dcxm;
        private ZdService zdServ = new ZdService();
        private ZrzService zrzServ = new ZrzService();
        private DcxmService dcServ = new DcxmService();

        public List<LayerInfo> layerInfos = null;

        public FormProjectMain(QJDCXM dcxm)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            initArcgisControls();
        }

        private void initArcgisControls()
        {
            layerInfos = dcServ.getLayerInfos();

            this.mapControl.Map.Name = "图层";
            this.tocControl.SetBuddyControl(this.mapControl);

            this.mapToolbar1.setMapControl(this.mapControl);
            this.mapToolbar1.addButton("编辑属性", Resources.arcgis_EditingPolygonTool32, b_propEdit_Click);
                        
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

            TreeNode root = new TreeNode();
            root.Text = ZD_LAYER_NAME;
            addZdTreeNode(root);
            this.tv_zd.Nodes.Add(root);
            this.tv_zd.ExpandAll();
        }

        private void addZdTreeNode(TreeNode root)
        {
            List<ZDJBXX> zdList = dcServ.getZdjbxxByDcxmId(dcxm.fId);
            foreach (ZDJBXX zd in zdList)
            {
                TreeNode zdNode = new TreeNode(zd.ZDDM);
                zdNode.Tag = zd;
                addZrzTreeNode(zdNode);

                root.Nodes.Add(zdNode);
            }
        }

        private void addZrzTreeNode(TreeNode zdNode)
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
            List<ZRZ> zList = zrzServ.getZrzByDcxmIdAndZddm(zd.QJDCXMID, zd.ZDDM);
            foreach(ZRZ zrz in zList)
            {
                TreeNode zNode = new TreeNode();
                zNode.Text = zrz.ZRZH + "(" + zrz.JZWMC + ")";
                zNode.Tag = zrz;
                zdNode.Nodes.Add(zNode);
            }
        }

        private void removeAllTreeNode()
        {
            this.tv_zd.Nodes.Clear();
        }

        private void loadMapLayers()
        {
            ArcgisService.removeAllLayers(this.mapControl);

            foreach(LayerInfo info in layerInfos){
                String layerName = info.layerName;
                String tableName = info.tableName;
                String annoField = info.annoField;
                ISymbol symbol = info.symbol;
                Debug.WriteLine((symbol as ISimpleFillSymbol).Outline.Width);
                Debug.WriteLine((symbol as ISimpleFillSymbol).Outline.Color.RGB.ToString());
                if (dcServ.countTableByDcxmId(dcxm.fId, tableName) > 0)
                {
                    IFeatureLayer layer = dcServ.getDcxmLayer(dcxm.fId,tableName);
                    layer.Name = layerName;
                    ArcgisService.setLayerAnnotation(layer, annoField, ArcgisService.getRgbColor(200, 0, 0), 10);
                    ArcgisService.setLayerSymbol(layer, symbol);
                    mapControl.AddLayer(layer);
                }
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
                ZDJBXX zd = zdServ.getZdjbxxById(feature.OID);
                FormZdjbxx form = new FormZdjbxx(zd);
                return form.ShowDialog(this);
            }
            else if (name.Contains("ZRZ"))
            {
                ZRZ zrz = zrzServ.getZrzById(feature.OID);
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
            DialogCadImport d = new DialogCadImport();
            if (d.ShowDialog() == DialogResult.OK)
            {
                List<IFeature> features = d.getFeatures();
                foreach (IFeature feature in features)
                {
                    ZDJBXX zd = zdServ.newZdjbxx(dcxm.fId, ArcgisService.featureToDbGeometry(feature));
                    zdServ.saveOrUpdate(zd);
                }
                loadData();
            }
        }

        private void b_importZrz_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tv_zd.SelectedNode;
            if(selectedNode == null)
            {
                MessageBox.Show("请先选择一个宗地。");
                return;
            }
            if(!(selectedNode.Tag is ZDJBXX))
            {
                MessageBox.Show("请先选择一个宗地。");
                return;
            }

            ZDJBXX zd = selectedNode.Tag as ZDJBXX;
            if(zd.ZDDM == null || zd.BDCDYH == null)
            {
                MessageBox.Show("宗地尚未编号，无法导入自然幢。");
                return;
            }
            DialogCadImport d = new DialogCadImport();
            if (d.ShowDialog() == DialogResult.OK)
            {
                List<IFeature> features = d.getFeatures();
                foreach (IFeature feature in features)
                {
                    ZRZ z = zrzServ.newZRZ(dcxm.fId, zd.ZDDM, zd.BDCDYH, ArcgisService.featureToDbGeometry(feature));
                    zrzServ.saveOrUpdate(z);
                }
                loadData();
            }
        }

        private void tv_zd_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

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

        private void b_selectFeature_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsSelectFeaturesTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }

        private void b_pan_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapPanTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }
    }
}
