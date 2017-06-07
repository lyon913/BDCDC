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
    public partial class FormZrzSelect : Form
    {

        private ZRZ queryKey = new ZRZ();
        private ZrzService zs = new ZrzService();

        public FormZrzSelect()
        {
            InitializeComponent();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            zs.find
        }
    }
}
