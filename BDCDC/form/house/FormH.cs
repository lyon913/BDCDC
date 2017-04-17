using BDCDC.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form.house
{
    public partial class FormH : Form
    {
        private ZRZ zrz;
        private H h;

        public FormH(ZRZ zrz,H h)
        {
            this.zrz = zrz;
            this.h = h;

            InitializeComponent();
        }

        private void init()
        {

        }

        private void dataBinding()
        {

        }

        private void b_save_Click(object sender, EventArgs e)
        {

        }
    }
}
