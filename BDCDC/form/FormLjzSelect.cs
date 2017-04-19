using BDCDC.model;
using BDCDC.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormLjzSelect : Form
    {
        private ZrzService zs = new ZrzService();
        private LjzService ls = new LjzService();

        public ZRZ selectedZrz { get; set; }
        public LJZ selectedLjz { get; set; }

        public FormLjzSelect()
        {
            InitializeComponent();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            string zddm = tb_zddm.Text;
            string zrzh = tb_zrzh.Text;

            loadZrzList(zddm, zrzh);
        }

        private void list_zrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZRZ zrz = (ZRZ)list_zrz.SelectedItem;
            loadLjzList(zrz);
            this.selectedZrz = zrz;
        }

        private void b_select_Click(object sender, EventArgs e)
        {
            if(this.selectedLjz == null)
            {
                MessageBox.Show(this, "请选择逻辑幢");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void list_ljz_SelectedValueChanged(object sender, EventArgs e)
        {
            this.selectedLjz = (LJZ)list_ljz.SelectedItem;
        }

        private void b_createLjz_Click(object sender, EventArgs e)
        {
            if(this.selectedZrz == null)
            {
                MessageBox.Show(this, "请先选择自然幢");
                return;
            }

            FormLjz form = new FormLjz(ls.newLjz(selectedZrz));
            DialogResult r = form.ShowDialog(this);
            if(r == DialogResult.OK)
            {
                loadLjzList(selectedZrz);
            }
        }

        private void loadLjzList(ZRZ zrz)
        {
            List<LJZ> list = ls.findByZrzh(zrz.ZRZH);
            list_ljz.DataSource = list;
            list_ljz.DisplayMember = "LJZH";
            list_ljz.ValueMember = "fId";
        }

        private void loadZrzList(string zddm, string zrzh)
        {
            List<ZRZ> zList = zs.findByZddm(zddm);
            list_zrz.DataSource = zList;
            list_zrz.DisplayMember = "ZRZH";
            list_zrz.ValueMember = "ZRZH";
        }
    }
}
