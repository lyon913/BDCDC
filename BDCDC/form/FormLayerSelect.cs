using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormLayerSelect : Form
    {
        private string selectedValue = null;

        public string getSelectedValue()
        {
            return this.selectedValue;
        }

        public FormLayerSelect(List<string> layers)
        {
            InitializeComponent();
            this.cb_layers.DataSource = layers;
        }

        private void bt_selected_Click(object sender, EventArgs e)
        {
            this.selectedValue = (string)cb_layers.SelectedValue;
            this.Close();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.selectedValue = null;
            this.Close();
        }

        private void FormLayerSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
