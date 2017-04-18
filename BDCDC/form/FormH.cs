using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
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
            UiUtils.comboboxDataItems(cb_fwlx, "房屋房屋类型", false);
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
            tb_sxh.DataBindings.Add("Text", h, "SXH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zl.DataBindings.Add("Text", h, "ZL", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zrzh.DataBindings.Add("Text", h, "ZRZH", false, DataSourceUpdateMode.OnPropertyChanged);

            cb_fwlx.DataBindings.Add("SelectedValue", h, "FWLX", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwxz.DataBindings.Add("SelectedValue", h, "FWXZ", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_hx.DataBindings.Add("SelectedValue", h, "HX", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_hxjg.DataBindings.Add("SelectedValue", h, "HXJG", false, DataSourceUpdateMode.OnPropertyChanged, null);

            cb_fwyt1.DataBindings.Add("SelectedValue", h, "FWYT1", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt2.DataBindings.Add("SelectedValue", h, "FWYT2", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt3.DataBindings.Add("SelectedValue", h, "FWYT3", false, DataSourceUpdateMode.OnPropertyChanged, null);
        }

        private void b_save_Click(object sender, EventArgs e)
        {

        }
    }
}
