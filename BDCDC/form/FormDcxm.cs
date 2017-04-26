using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormDcxm : Form
    {

        private QJDCXM dcxm;
        private DcxmService xs = new DcxmService();
        private DataItemsService ds = new DataItemsService();



        public FormDcxm(QJDCXM dcxm)
        {
            InitializeComponent();
            this.dcxm = dcxm;

            init();
        }

        void init()
        {
            initUI();
            initDataBinding();
        }

        private void initUI()
        {
            UiUtils.comboboxDataItems(this.cb_xmlx, "权籍调查项目类型", false);
        }

        private void initDataBinding()
        {
            cb_xmlx.DataBindings.Add("SelectedValue", dcxm, "XMLX", false, DataSourceUpdateMode.OnPropertyChanged);

            tb_xmbh.DataBindings.Add("Text", dcxm, "XMBH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_xmmc.DataBindings.Add("Text", dcxm, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_bsdw.DataBindings.Add("Text", dcxm, "DCDW", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_dcr.DataBindings.Add("Text", dcxm, "DCR", false, DataSourceUpdateMode.OnPropertyChanged);
            
            tb_lxr.DataBindings.Add("Text", dcxm, "LXR", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_lxdh.DataBindings.Add("Text", dcxm, "LXDH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_slr.DataBindings.Add("Text", dcxm, "SLR", false, DataSourceUpdateMode.OnPropertyChanged);

            dp_slri.DataBindings.Add("Value", dcxm, "SLRQ", true, DataSourceUpdateMode.OnPropertyChanged);
            dp_dcrq.DataBindings.Add("Value", dcxm, "DCRQ", true, DataSourceUpdateMode.OnPropertyChanged);
            

        }

        private void FormDcxm_Load(object sender, EventArgs e)
        {
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                xs.save(dcxm);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                UiUtils.alertException(this,ex);
            }
        }

        public QJDCXM getQjdcxm()
        {
            return this.dcxm;
        }
    }
}
