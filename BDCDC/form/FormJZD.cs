using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
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
    public partial class FormJZD : Form
    {
        private QJDCXM dcxm;
        private ZDJBXX zd;

        private JzdService jzdService;

        public FormJZD(QJDCXM dcxm, ZDJBXX zd)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            this.zd = zd;
            init();
        }

        private void init()
        {
            this.dg_jzd.AutoGenerateColumns = false;
            UiUtils.dataGridComboboxDataItems(this.JZDLX, "界址点类型", false);
            UiUtils.dataGridComboboxDataItems(this.JBLX, "界标类型", false);
            jzdService = new JzdService();
        }

        private void FormJZD_Load(object sender, EventArgs e)
        {

        }

        private void b_import_from_cad_Click(object sender, EventArgs e)
        {
            DialogCadImport d = new DialogCadImport(EnumFeatureType.Point);
            d.ShowDialog(this);

        }

        private void b_import_from_shape_Click(object sender, EventArgs e)
        {

            this.dg_jzd.DataSource = jzdService.getJzdListFromZdjbxx(zd);
        }
    }
}
