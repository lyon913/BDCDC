using BDCDC.model;
using BDCDC.service;
using System;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormMain : Form
    {
        private DcxmService xmServ = new DcxmService();

        public FormMain()
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
                openForm(form.getQjdcxm());
                loadData();
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

            openForm(dcxm);
        }

        private void m_connection_config_Click(object sender, EventArgs e)
        {
            FormDbConfig f = new FormDbConfig();
            f.ShowDialog(this);
        }

        private void openForm(QJDCXM dcxm)
        {
            //宗地调查项目
            if ("1".Equals(dcxm.XMLX))
            {
                FormProjectZd form = new FormProjectZd(dcxm);
                form.ShowDialog(this);
            }

            //房屋调查项目
            else if ("2".Equals(dcxm.XMLX))
            {
                FormProjectFw form = new FormProjectFw(dcxm);
                form.ShowDialog(this);
            }
        }
    }
}
