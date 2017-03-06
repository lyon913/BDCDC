using BDCDC.service;
using BDCDC.vo;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormMain : Form
    {
        private IFeatureLayer importedLayer;

        public FormMain()
        {
            InitializeComponent();

            this.mapCtrl.Map.Name = "不动产权籍调查数据";
            toc.SetBuddyControl(this.mapCtrl);

            toolBarCtrl.SetBuddyControl(this.mapCtrl);
            toolBarCtrl.AddItem("esriControls.ControlsMapZoomInTool", -1, -1, true, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsMapZoomOutTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsMapFullExtentCommand", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsMapPanTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsFeatureSelectionToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsMapIdentifyTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolBarCtrl.AddItem("esriControls.ControlsEditingToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            //ESRI.ArcGIS.Controls.ControlsEditingToolbar
        }

        private void bt_add_zdjbxx_Click(object sender, EventArgs e)
        {
            

            IEnumFeature selectedFeatures = (IEnumFeature)this.mapCtrl.Map.FeatureSelection;
            List<IFeature> fList = new List<IFeature>();
            IFeature f;
            while ((f = selectedFeatures.Next()) != null)
            {
                fList.Add(f);
            }


            if (fList.Count == 0)
            {
                MessageBox.Show("请选择宗地图。");
                return;
            }
            else if(fList.Count > 1)
            {
                MessageBox.Show("选择的图形数量不能多于一个。");
                return;
            }

            IFeature feature = fList[0];

            FormZdjbxx form = new FormZdjbxx(null);
            form.zdjbxx.SHAPE = ArcgisService.featureToDbGeometry(feature);
            form.ShowDialog(this);
        }

        private void bt_addZrz_Click(object sender, EventArgs e)
        {
            //String zddm = "530101001001GB00001";
            //FormZrz f = new FormZrz(zddm);
            //f.ShowDialog(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CtrlDcxm dcxm = new CtrlDcxm();
            dcxm.Dock = DockStyle.Fill;
            this.tab_dcxm.Controls.Add(dcxm);
        }

        private void bt_openWs_Click(object sender, EventArgs e)
        {
            IWorkspace ws = ArcgisService.openBdcWorkspace();
            BasicLayers layers = ArcgisService.getBasicLayers(ws);
            addLayers(layers.getAllLayers());
            this.mapCtrl.ActiveView.Extent = layers.ZDJBXX.AreaOfInterest;
        }

        private void addLayers(List<IFeatureLayer> layers)
        {
            foreach(IFeatureLayer layer in layers)
            {
                this.mapCtrl.AddLayer(layer);
            }
        }

        private void bt_openDAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "CAD文件(*.dwg)|*.dwg";
            if(d.ShowDialog(this) == DialogResult.OK)
            {
                String pathAndFileName = d.FileName;
                String path = System.IO.Path.GetDirectoryName(pathAndFileName);
                String fileName = d.SafeFileName;

                IFeatureWorkspace ws = ArcgisService.openCadWorkspace(path) as IFeatureWorkspace;
                IFeatureLayer cadLayer = ArcgisService.getCadFeatureLayer(ws, fileName);

                this.mapCtrl.AddLayer(cadLayer);
                this.mapCtrl.ActiveView.Extent = cadLayer.AreaOfInterest;
                this.mapCtrl.ActiveView.Refresh();

                importedLayer = cadLayer;
            }
            
        }

        private void mapCtrl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            this.sb_lb_coord.Text = "X:"+e.mapX.ToString("0.0000") + " Y:" + e.mapY.ToString("0.0000");
        }
    }
}
