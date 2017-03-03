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
    public partial class FormLayerSelect : Form
    {
        private String selectedValue = null;

        public String getSelectedValue()
        {
            return this.selectedValue;
        }

        public FormLayerSelect(List<String> layers)
        {
            InitializeComponent();
            this.cb_layers.DataSource = layers;
        }

        private void bt_selected_Click(object sender, EventArgs e)
        {
            this.selectedValue = (String)cb_layers.SelectedValue;
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
