using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormZrz : Form
    {
        private ZRZ zrz;

        private ZrzService zrzService;
        private DataItemsService items;

        private void init()
        {
            zrzService = new ZrzService();
            items = new DataItemsService();
        }

        public FormZrz(String zddm)
        {
            InitializeComponent();
            init();

            //新增自然幢
            this.zrz = new ZRZ();
            zrz.ZDDM = zddm;
        }

        public FormZrz(ZRZ zrz)
        {
            InitializeComponent();
            init();

            //编辑已有自然幢
            this.zrz = zrz;
        }

        private void FormZrz_Load(object sender, EventArgs e)
        {

            using (var ctx = new BdcContext())
            {
                /*
                //规划用途下拉
                List<DataItems> ghytList = items.getItemsByType("房屋用途", ctx);
                DataItemsService.formatItemName(ghytList);
                this.cb_ghyt.DataSource = ghytList;
                this.cb_ghyt.DisplayMember = "ItemName";
                this.cb_ghyt.ValueMember = "ItemCode";

                //房屋结构下拉
                List<DataItems> fwjgList = items.getItemsByType("房屋结构", ctx);
                this.cb_fwjg.DataSource = fwjgList;
                this.cb_fwjg.DisplayMember = "ItemName";
                this.cb_fwjg.ValueMember = "ItemCode";
                */
            }

            //表单绑定
            //宗地代码
            tb_zddm.DataBindings.Add("Text", zrz, "ZDDM", false, DataSourceUpdateMode.OnPropertyChanged);
            //不动产单元号
            tb_bdcdyh.DataBindings.Add("Text", zrz, "BDCDYH", false, DataSourceUpdateMode.OnPropertyChanged);
            //自然幢号
            tb_zrzh.DataBindings.Add("Text", zrz, "ZRZH", false, DataSourceUpdateMode.OnPropertyChanged);
            //规划用途
            cb_ghyt.DataBindings.Add("SelectedValue", zrz, "GHYT", false, DataSourceUpdateMode.OnPropertyChanged);
            //房屋结构
            cb_fwjg.DataBindings.Add("SelectedValue", zrz, "FWJG", false, DataSourceUpdateMode.OnPropertyChanged);
            //项目名称
            tb_xmmc.DataBindings.Add("Text", zrz, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
            //建筑物名称
            tb_jzwmc.DataBindings.Add("Text", zrz, "JZWMC", false, DataSourceUpdateMode.OnPropertyChanged);
            //竣工日期
            dp_jgrq.DataBindings.Add("Value", zrz, "JGRQ", true, DataSourceUpdateMode.OnPropertyChanged,new DateTime(2010,1,1));
            //总套数
            nb_zts.DataBindings.Add("Value", zrz, "ZTS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_zydmj.DataBindings.Add("Value", zrz, "ZYDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_zzdmj.DataBindings.Add("Value", zrz, "ZZDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycjzmj.DataBindings.Add("Value", zrz, "YCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scjzmj.DataBindings.Add("Value", zrz, "SCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_zcs.DataBindings.Add("Value", zrz, "ZCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dscs.DataBindings.Add("Value", zrz, "DSCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dxcs.DataBindings.Add("Value", zrz, "DXCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dxsd.DataBindings.Add("Value", zrz, "DXSD", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_jzwgd.DataBindings.Add("Value", zrz, "JZWGD", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            //备注
            tb_bz.DataBindings.Add("Text", zrz, "BZ", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bt_getZrzsxh_Click(object sender, EventArgs e)
        {
            using (var ctx = new BdcContext())
            {
                String sxh = zrzService.getZrzsxh(this.zrz.ZDDM,ctx);
                this.tb_zsxh.Text = sxh;
                upateBdcdyh();
            }
        }

        private void upateBdcdyh()
        {
            String zddm = tb_zddm.Text;
            String sxh = tb_zsxh.Text;
            String dzwtzm = "F";

            //自然幢号
            String zrzh = zddm + dzwtzm + sxh;

            //不动产单元号
            String bdcdyh = zrzh + "0000";

            tb_bdcdyh.Text = bdcdyh;
            tb_zrzh.Text = zrzh;
        }

        private void tb_zsxh_TextChanged(object sender, EventArgs e)
        {
            upateBdcdyh();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                zrzService.saveOrUpdate(this.zrz);
            }
            
        }

        private void bt_zdt_Click(object sender, EventArgs e)
        {
            //用户选取自然幢图形，设置到SHAPE字段

            //TODO 此代码为模拟的多边形，需要替换为实际图形代码
            //坐标系4543为：CGCS2000_3_Degree_GK_CM_102E
            zrz.SHAPE = DbGeometry.PolygonFromText("POLYGON ((0 450000, 50 450000, 50 450050, 0 450050,0 450000))", 4543);
        }

        public bool validate()
        {
            if(zrz.BDCDYH == null || "".Equals(zrz.BDCDYH))
            {
                MessageBox.Show(this, "请编制不动产单元号", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (zrz.SHAPE == null)
            {
                MessageBox.Show(this, "请先关联自然幢图形", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
