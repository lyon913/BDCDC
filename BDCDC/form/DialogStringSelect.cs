using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class DialogStringSelect : Form
    {
        private string[] data;

        public DialogStringSelect(String title, List<String> data)
        {
            InitializeComponent();

            this.Text = title;
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
            if(this.list.SelectedItem == null)
            {
                MessageBox.Show("请选择一项内容");
                return;
            }
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
