using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;

namespace BDCDC.form.ctrl
{
    public partial class DcxmInfo : UserControl
    {
        private QJDCXM dcxm;
        private DataItemsService ds = new DataItemsService();

        public DcxmInfo()
        {
            InitializeComponent();
        }

        public void setData(QJDCXM dcxm)
        {
            this.dcxm = dcxm;
            update();
        }

        private void update()
        {
            if(dcxm == null)
            {
                dcxm = new QJDCXM();
            }
            l_xmmc.Text = dcxm.XMMC;
            l_xmlx.Text = ds.translateDataItem("权籍调查项目类型",dcxm.XMLX);
            l_dcdw.Text = dcxm.DCDW;
            l_lxr.Text = dcxm.LXR;
            l_lxdh.Text = dcxm.LXDH;
            l_slr.Text = dcxm.SLR;
            l_slrq.Text = StringUtils.formatDateTime(dcxm.SLRQ,"yyyy-MM-dd hh:mm");
        }
    }
}
