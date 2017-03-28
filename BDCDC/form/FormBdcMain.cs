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
    public partial class FormBdcMain : Form
    {
        private DcxmService xmServ = new DcxmService();

        public FormBdcMain()
        {
            InitializeComponent();
            this.dgv_todoList.AutoGenerateColumns = false;
            this.dgv_todoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void mi_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_newProj_Click(object sender, EventArgs e)
        {
            FormDcxm form = new FormDcxm(null);
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                FormProjectMain formPrj = new FormProjectMain(form.getQjdcxm());
                formPrj.ShowDialog();
            }
        }

        private void FormBdcMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dgv_todoList.DataSource = xmServ.getTodoList();
        }


        private void dgv_todoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex < 0)
            {
                return;
            }
            QJDCXM dcxm = dgv_todoList.Rows[e.RowIndex].DataBoundItem as QJDCXM;
            FormProjectMain form = new FormProjectMain(dcxm);
            form.ShowDialog();
        }

        private void m_connection_config_Click(object sender, EventArgs e)
        {
            FormDbConfig f = new FormDbConfig();
            f.ShowDialog(this);
        }
    }
}
