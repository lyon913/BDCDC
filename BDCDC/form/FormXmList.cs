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
    public partial class FormXmList : Form
    {
        private XmService xs = new XmService();

        public XM selectedXm { get; set; }

        public FormXmList()
        {
            InitializeComponent();
        }

        private void b_createXm_Click(object sender, EventArgs e)
        {
            openCreateXmForm();
        }

        private void openCreateXmForm()
        {
            XM xm = xs.newXm();
            FormXm f = new FormXm(xm);
            DialogResult r = f.ShowDialog(this);
            if(r == DialogResult.OK)
            {
                loadSingleData(xm);
            }
        }

        private void loadDataList(List<XM> list)
        {
            dgv.DataSource = list;
        }

        private void loadSingleData(XM xm)
        {
            List<XM> list = new List<XM>();
            list.Add(xm);
            loadDataList(list);
        }

        private void search()
        {
            string xmmc = tb_xmmc.Text;
            string kfqymc = tb_kfqymc.Text;
            string xmzl = tb_xmzl.Text;

            List<XM> list = xs.search(xmmc, kfqymc, xmzl);
            loadDataList(list);
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows == null || dgv.SelectedRows.Count < 1)
            {
                MessageBox.Show(this, "请选择一个项目");
                return;
            }
            selectedXm = (XM)dgv.SelectedRows[0].DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
