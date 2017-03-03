using BDCDC.service;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.SystemUI;
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
    public partial class DialogCadImport : Form
    {

        private List<IFeature> features;

        public DialogCadImport()
        {
            InitializeComponent();
        }

        private void FormCadImport_Load(object sender, EventArgs e)
        {

            this.tocControl.SetBuddyControl(this.mapControl);

            mapToolbar.SetBuddyControl(this.mapControl);
            mapToolbar.AddItem("esriControls.ControlsMapZoomInTool", -1, -1, true, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsMapZoomOutTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsMapFullExtentCommand", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsMapPanTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsFeatureSelectionToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsMapIdentifyTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            mapToolbar.AddItem("esriControls.ControlsEditingToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
        }

        private void b_openCadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                String file = fd.FileName;
                
                ArcgisService.addCadLayersToMap(this.mapControl, file, ArcgisService.CAD_FEATURE_TYPE.POLYGON);
                ArcgisService.addCadToMapAsRaster(this.mapControl, file);
            }

               
        }

        private void b_importFeatures_Click(object sender, EventArgs e)
        {
            List<IFeature> features = ArcgisService.getFeaturesFromMapSelection(this.mapControl);
            if(features == null || features.Count == 0)
            {
                MessageBox.Show("请选择要导入的图形。");
                return;
            }

            this.features = features;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<IFeature> getFeatures()
        {
            return this.features;
        }
    }
}
