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

        private List<JZD> jzdList;
        private List<JZX> jzxList;

        public FormJZD(QJDCXM dcxm, ZDJBXX zdjbxx)
        {
            InitializeComponent();
            this.dcxm = dcxm;
            this.zdjbxx = zdjbxx;
            init();
            loadData();
        }

        private void init()
        {
            jzdService = new JzdService();

            this.dg_jzd.AutoGenerateColumns = false;
            this.dg_jzd.ReadOnly = false;
            this.dg_jzd.EditMode = DataGridViewEditMode.EditOnEnter;

            this.dg_jzx.AutoGenerateColumns = false;
            this.dg_jzx.ReadOnly = false;
            this.dg_jzx.EditMode = DataGridViewEditMode.EditOnEnter;

            UiUtils.dataGridComboboxDataItems(this.JZDLX, "界址点类型", false);
            UiUtils.dataGridComboboxDataItems(this.JBLX, "界标类型", false);

            UiUtils.dataGridComboboxDataItems(this.JZXLB, "界址线类别", false);
            UiUtils.dataGridComboboxDataItems(this.JZXWZ, "界址线位置", false);
            UiUtils.dataGridComboboxDataItems(this.JXXZ, "界线性质", false);

            String info1 = "宗地面积：{0} ";
            String info2 = "宗地代码：{0} ";
            this.l_info1.Text = String.Format(info1, zdjbxx.ZDMJ);
            this.l_info2.Text = String.Format(info2, zdjbxx.ZDDM);

        }

        private void loadData()
        {
            loadDataFromDb();
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
            importDataFromShape();


        }

        private void importDataFromShape()
        {
            DialogResult confirm = MessageBox.Show(this, "该操作将删除已有的界址点和界址线列表并从宗地图重新生成数据。是否确定要这么做？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                jzdService.importJzdJzxFromShape(zdjbxx, dcxm.fId);
                loadDataFromDb();
            }
        }

        private void loadDataFromDb()
        {
            jzdList = jzdService.getJzdListFromDb(zdjbxx.ZDDM, dcxm.fId);
            jzxList = jzdService.getJzxListFromDb(zdjbxx.ZDDM, dcxm.fId);
            this.dg_jzd.DataSource = jzdList;
            this.dg_jzx.DataSource = jzxList;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.dg_jzd.EndEdit();
                this.dg_jzx.EndEdit();
                jzdService.saveJzdJzx(zdjbxx.ZDDM, dcxm.fId, jzdList, jzxList);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误");
            }
            
        }
    }
}
