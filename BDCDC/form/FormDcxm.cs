using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormDcxm : Form
    {

        private int? dcxm_id;
        private QJDCXM dcxm;
        private DcxmService xmService = new DcxmService();
        private DataItemsService diService = new DataItemsService();



        public FormDcxm(int? dcxm_id)
        {
            InitializeComponent();
            this.dcxm_id = dcxm_id;

            init();
        }

        void init()
        {
            if (dcxm_id == null)
            {
                dcxm = new QJDCXM();
                dcxm.XMLX = "1";
                dcxm.SLRQ = DateTime.Now;
                dcxm.ZT = 0;
                dcxm.SLR = UserService.getCurrentUser().XM;
            }
            else
            {
                dcxm = xmService.findById((int)dcxm_id);
            }

        }

        private void FormDcxm_Load(object sender, EventArgs e)
        {
            UiUtils.comboboxDataItems(this.cb_xmlx, "权籍调查项目类型",false);

            t_xmmc.DataBindings.Add("Text", dcxm, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
            cb_xmlx.DataBindings.Add("SelectedValue", dcxm, "XMLX", false, DataSourceUpdateMode.OnPropertyChanged);
            t_bsdw.DataBindings.Add("Text", dcxm, "DCDW", false, DataSourceUpdateMode.OnPropertyChanged);
            t_lxr.DataBindings.Add("Text", dcxm, "LXR", false, DataSourceUpdateMode.OnPropertyChanged);
            t_lxdh.DataBindings.Add("Text", dcxm, "LXDH", false, DataSourceUpdateMode.OnPropertyChanged);
            t_slr.DataBindings.Add("Text", dcxm, "SLR", false, DataSourceUpdateMode.OnPropertyChanged);
            dp_slri.DataBindings.Add("Value", dcxm, "SLRQ", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            xmService.save(dcxm);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public QJDCXM getQjdcxm()
        {
            return this.dcxm;
        }
    }
}
