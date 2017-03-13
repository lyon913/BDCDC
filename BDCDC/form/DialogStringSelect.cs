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
    public partial class DialogStringSelect : Form
    {
        private string[] data;

        public DialogStringSelect(List<String> data)
        {
            InitializeComponent();
            this.data = data.ToArray();
            this.list.Items.AddRange(this.data);
        }

        private void DialogStringSelect_Load(object sender, EventArgs e)
        {

        }

        public String getSelectedString()
        {
            return (String)this.list.SelectedItem;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
