using BDCDC.model;
using BDCDC.service;
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
    public partial class FormProjectFw : Form
    {
        private QJDCXM dcxm;

        private List<LJZ> ljzList;

        private HService hs = new HService();
        private LjzService ls = new LjzService();

        public FormProjectFw(QJDCXM dcxm)
        {
            this.dcxm = dcxm;
            InitializeComponent();
            init();
        }

        private void init()
        {
            ljzList = ls.findByDcxmId(dcxm.fId);
        }

        private void m_create_ljz_Click(object sender, EventArgs e)
        {

        }

        private void create_h_Click(object sender, EventArgs e)
        {

        }

        private void m_fwlz_Click(object sender, EventArgs e)
        {

        }
    }
}
