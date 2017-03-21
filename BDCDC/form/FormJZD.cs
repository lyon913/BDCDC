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
        private ZDJBXX zdjbxx;

        private JzdService jzdService;

        public FormJZD(QJDCXM dcxm, ZDJBXX zdjbxx)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            this.zdjbxx = zdjbxx;
            init();
        }

        private void init()
        {
            jzdService = new JzdService();

            this.dg_jzd.AutoGenerateColumns = false;
            this.dg_jzd.ReadOnly = false;
            this.dg_jzd.EditMode = DataGridViewEditMode.EditOnEnter;

            UiUtils.dataGridComboboxDataItems(this.JZDLX, "界址点类型", false);
            UiUtils.dataGridComboboxDataItems(this.JBLX, "界标类型", false);

            String info1 = "宗地面积：{0}";
            String info2 = "宗地代码：{0}";
            this.l_info1.Text = String.Format(info1, zdjbxx.ZDMJ);
            this.l_info2.Text = String.Format(info2, zdjbxx.ZDDM);

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
            loadDataFromShape();
        }

        private void loadDataFromShape()
        {
            List<JZD> jzdList = jzdService.getJzdListFromZdjbxx(zdjbxx);
            this.dg_jzd.DataSource = jzdList;
        }
    }
}
