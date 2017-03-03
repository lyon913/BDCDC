using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDCDC.service;
using BDCDC.model;

namespace BDCDC.form
{
    public partial class CtrlDcxm : UserControl
    {
        private ZdService zdServ;
        public CtrlDcxm()
        {
            InitializeComponent();

            zdServ = new ZdService();

            this.map_ctrl.Map.Name = "导入图形";
            this.map_toc.SetBuddyControl(this.map_ctrl);
            
            this.map_toolbar.SetBuddyControl(this.map_ctrl);
        }

        private void CtrlDcxm_Load(object sender, EventArgs e)
        {
            using(var ctx = new BdcContext())
            {
            }

        }
    }
}
