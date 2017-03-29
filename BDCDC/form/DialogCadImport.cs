using BDCDC.Properties;
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
        private EnumFeatureType featureType;

        public DialogCadImport(EnumFeatureType featureType)
        {
            InitializeComponent();
            this.featureType = featureType;
            init();
        }

        private void init()
        {
            this.mapControl.Map.Name = "导入图层";
            this.mapToolbar1.setMapControl(this.mapControl);
            this.tocControl.SetBuddyControl(this.mapControl);

            this.mapToolbar1.addButton("加载CAD", Resources.folder_search, openCad_click);
            this.mapToolbar1.addButton("导入选择的图形", Resources.arcgis_Import_Feature_Class32, import_click);
        }

        private void FormCadImport_Load(object sender, EventArgs e)
        {
       }

        private void openCad_click(object obj,EventArgs e)
        {
            showOpenCadFileDialog();
        }
        private void import_click(object obj, EventArgs e)
        {
            importAndClose();
        }


        private void showOpenCadFileDialog()
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                String file = fd.FileName;
                ArcgisService.addCadLayersToMap(this.mapControl, file, featureType);
                ArcgisService.addCadToMapAsRaster(this.mapControl, file);
            }
        }

        private void importAndClose()
        {
            List<IFeature> features = ArcgisService.getFeaturesFromMapSelection(this.mapControl);

            if (features == null || features.Count == 0)
            {
                MessageBox.Show("请选择要导入的图形。");
                return;
            }
            foreach (IFeature f in features)
            {
                try
                {
                    ArcgisService.checkGeometryCoordinates(f.Shape);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            this.features = features;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void b_openCadFile_Click(object sender, EventArgs e)
        {
            showOpenCadFileDialog();
        }

        private void b_importFeatures_Click(object sender, EventArgs e)
        {
            importAndClose();
        }

        public List<IFeature> getFeatures()
        {
            return this.features;
        }
    }
}
