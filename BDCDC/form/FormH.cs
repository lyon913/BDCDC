using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormH : Form
    {
        private H h;

        private HService hs = new HService();

        public FormH(H h)
        {
            this.h = h;
            InitializeComponent();
            init();
        }

        private void init()
        {
            initUI();
            dataBinding();
        }

        private void initUI()
        {
            UiUtils.comboboxDataItems(cb_fwlx, "房屋类型", false);
            UiUtils.comboboxDataItems(cb_fwxz, "房屋性质", false);

            UiUtils.comboboxDataItems(cb_fwyt1, "房屋用途", false);
            UiUtils.comboboxDataItems(cb_fwyt2, "房屋用途", false);
            UiUtils.comboboxDataItems(cb_fwyt3, "房屋用途", false);

            UiUtils.comboboxDataItems(cb_hx, "户型", false);
            UiUtils.comboboxDataItems(cb_hxjg, "户型结构", false);
        }

        private void dataBinding()
        {
            tb_bdcdyh.DataBindings.Add("Text", h, "BDCDYH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_dyh.DataBindings.Add("Text", h, "DYH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_ljzh.DataBindings.Add("Text", h, "LJZH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_shbw.DataBindings.Add("Text", h, "SHBW", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zl.DataBindings.Add("Text", h, "ZL", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zrzh.DataBindings.Add("Text", h, "ZRZH", false, DataSourceUpdateMode.OnPropertyChanged);

            cb_fwlx.DataBindings.Add("SelectedValue", h, "FWLX", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwxz.DataBindings.Add("SelectedValue", h, "FWXZ", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_hx.DataBindings.Add("SelectedValue", h, "HX", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_hxjg.DataBindings.Add("SelectedValue", h, "HXJG", false, DataSourceUpdateMode.OnPropertyChanged, null);

            cb_fwyt1.DataBindings.Add("SelectedValue", h, "FWYT1", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt2.DataBindings.Add("SelectedValue", h, "FWYT2", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt3.DataBindings.Add("SelectedValue", h, "FWYT3", false, DataSourceUpdateMode.OnPropertyChanged, null);

            nb_qsc.DataBindings.Add("Value", h, "QSC", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_zzc.DataBindings.Add("Value", h, "ZZC", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_hh.DataBindings.Add("Value", h, "HH", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_ycjzmj.DataBindings.Add("Value", h, "YCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_yctnmj.DataBindings.Add("Value", h, "YCTNJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycftmj.DataBindings.Add("Value", h, "YCFTJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycdxjzmj.DataBindings.Add("Value", h, "YCDXBFJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycqtmj.DataBindings.Add("Value", h, "YCQTJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycftxs.DataBindings.Add("Value", h, "YCFTXS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_scjzmj.DataBindings.Add("Value", h, "SCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_sctnmj.DataBindings.Add("Value", h, "SCTNJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scftmj.DataBindings.Add("Value", h, "SCFTJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scdxjzmj.DataBindings.Add("Value", h, "SCDXBFJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scqtmj.DataBindings.Add("Value", h, "SCQTJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scftxs.DataBindings.Add("Value", h, "SCFTXS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_gytdmj.DataBindings.Add("Value", h, "GYTDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_fttdmj.DataBindings.Add("Value", h, "FTTDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dytdmj.DataBindings.Add("Value", h, "DYTDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
        }

        private void getMaxSxh()
        {
            string sxh = hs.getMaxSxh(h);
            tb_sxh.Text = sxh;
            updateBdcdyh();

        }

        private void updateBdcdyh()
        {
            string sxh = tb_sxh.Text;
            if(string.IsNullOrEmpty(sxh) || sxh.Length < 4)
            {
                return;
            }
            tb_bdcdyh.Text = h.ZRZH + tb_sxh.Text;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                hs.saveOrUpdate(h);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this,ex.Message);
            }
            
        }

        private void b_getMaxSxh_Click(object sender, EventArgs e)
        {
            getMaxSxh();
        }

        private void b_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
