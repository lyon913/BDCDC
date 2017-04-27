using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormZrz : Form
    {
        private ZRZ zrz;

        private ZrzService zrzService = new ZrzService();
        private ZdService zdService = new ZdService();
        private DataItemsService itemService = new DataItemsService();



        public FormZrz(ZRZ zrz)
        {
            InitializeComponent();
            this.zrz = zrz;
            init();
        }

        private void init()
        {
            initUI();
            initDataBinding();
            initSxh();
        }

        private void initUI()
        {
            UiUtils.comboboxDataItems(cb_ghyt, "房屋用途", false);
            UiUtils.comboboxDataItems(cb_fwjg, "房屋结构", false);
        }

        private void initDataBinding()
        {
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
            cb_fwjg.DataBindings.Add("SelectedValue", zrz, "FWJG", true, DataSourceUpdateMode.OnPropertyChanged);
            //项目名称
            tb_xmmc.DataBindings.Add("Text", zrz, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
            //建筑物名称
            tb_jzwmc.DataBindings.Add("Text", zrz, "JZWMC", false, DataSourceUpdateMode.OnPropertyChanged);
            //竣工日期
            dp_jgrq.DataBindings.Add("Value", zrz, "JGRQ", true, DataSourceUpdateMode.OnPropertyChanged, new DateTime(2010, 1, 1));
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

        private void initSxh()
        {
            if (!String.IsNullOrEmpty(zrz.ZRZH))
            {
                string sxh = zrz.ZRZH.Substring(20);
                tb_zsxh.Text = sxh;
            }
        }

        private void FormZrz_Load(object sender, EventArgs e)
        {

        }

        private void bt_getZrzsxh_Click(object sender, EventArgs e)
        {
            using (var ctx = new BdcContext())
            {
                string sxh = zrzService.getZrzsxh(this.zrz.ZDDM,ctx);
                this.tb_zsxh.Text = sxh;
                upateBdcdyh();
            }
        }

        private void upateBdcdyh()
        {
            string zddm = tb_zddm.Text;
            string sxh = tb_zsxh.Text;
            string dzwtzm = "F";

            //自然幢号
            string zrzh = zddm + dzwtzm + sxh;

            //不动产单元号
            string bdcdyh = zrzh + "0000";
            if (zdService.checkBdcdyh(bdcdyh))
            {
                tb_bdcdyh.Text = bdcdyh;
                tb_zrzh.Text = zrzh;
            }
            
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool validate()
        {
            if(!zdService.checkZddm(zrz.ZDDM))
            {
                MessageBox.Show(this, "宗地代码无效", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (zrz.BDCDYH == null || "".Equals(zrz.BDCDYH))
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

        private void tb_zddm_TextChanged(object sender, EventArgs e)
        {
            upateBdcdyh();
        }

        private void b_zydmj_get_Click(object sender, EventArgs e)
        {
            decimal? zydmj = zdService.getZdmjByZddm(zrz.ZDDM);
            if(zydmj == null)
            {
                zydmj = 0;
            }
            this.nb_zydmj.Value = Decimal.Round((decimal)zydmj, 2);
        }

        private void b_zzdmj_calc_Click(object sender, EventArgs e)
        {
            if(zrz.SHAPE == null)
            {
                return;
            }
            double area = (double)zrz.SHAPE.Area;
            this.nb_zzdmj.Value = Decimal.Round(new Decimal(area), 2);
        }

        private void b_get_zddm_Click(object sender, EventArgs e)
        {
            if(zrz.SHAPE == null)
            {
                MessageBox.Show("未找到自然幢图形数据。");
                return;
            }

            List<string> dmList = zrzService.findZddmIntersectZrz(zrz);
            if(dmList.Count == 0)
            {
                MessageBox.Show("未找到与该自然幢相交的宗地，请检查宗地和自然幢图形数据。");
                return;
            }
            if (dmList.Count == 1)
            {
                this.tb_zddm.Text = dmList[0];
                return;
            }
            if (dmList.Count > 1)
            {
                DialogStringSelect d = new DialogStringSelect("宗地代码选取", dmList);
                d.ShowDialog(this);
                if(d.DialogResult == DialogResult.OK)
                {
                    this.tb_zddm.Text = d.getSelectedString();
                }
                return;
            }
        }
    }
}
