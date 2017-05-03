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
    public partial class FormXm : Form
    {
        private XM xm;
        private XmService xs = new XmService();

        public FormXm(XM xm)
        {
            this.xm = xm;
            InitializeComponent();
            init();
        }

        public void init()
        {
            initDataBinding();
        }

        public void initDataBinding()
        {
            tb_xmmc.DataBindings.Add("Text", xm, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_kfqymc.DataBindings.Add("Text", xm, "KFSMC", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_xmzl.DataBindings.Add("Text", xm, "XMZL", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_bz.DataBindings.Add("Text", xm, "BZ", false, DataSourceUpdateMode.OnPropertyChanged);

            dp_kgrq.DataBindings.Add("Value", xm, "KGSJ", true, DataSourceUpdateMode.OnPropertyChanged, new DateTime());
            dp_jgrq.DataBindings.Add("Value", xm, "JGSJ", true, DataSourceUpdateMode.OnPropertyChanged, new DateTime());

            nb_xmzmj.DataBindings.Add("Value", xm, "XMZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_zzmj.DataBindings.Add("Value", xm, "QZZZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_fzzmj.DataBindings.Add("Value", xm, "QZFZZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            nb_rjl.DataBindings.Add("Value", xm, "RJL", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_lhl.DataBindings.Add("Value", xm, "LHL", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_jzmd.DataBindings.Add("Value", xm, "JZMD", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
        }

        public XM getData()
        {
            return this.xm;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                xs.save(xm);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex)
            {
                UiUtils.alertException(this, ex);
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
