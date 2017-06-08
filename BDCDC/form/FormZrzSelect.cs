using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
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

        private ZRZ selected = null;

        public FormZrzSelect()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initUi();
            initDataBindings();
        }

        private void initUi()
        {
            dgv.AutoGenerateColumns = false;
        }

        private void initDataBindings()
        {
            tb_zddm.DataBindings.Add("Text", queryKey, "ZDDM", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zrzh.DataBindings.Add("Text", queryKey, "ZRZH", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_jzwmc.DataBindings.Add("Text", queryKey, "JZWMC", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_xmmc.DataBindings.Add("Text", queryKey, "XMMC", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            search(queryKey);
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count == 0)
            {
                UiUtils.alertInfo(this, "错误", "请选择一个自然幢");
                return;
            }
            selected = (ZRZ)dgv.SelectedRows[0].DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void search(ZRZ queryKey)
        {
            List<ZRZ> list = zs.findByExample(queryKey);
            loadDgvData(list);
        }

        private void loadDgvData(List<ZRZ> list)
        {
            dgv.DataSource = list;
        }

        public ZRZ getSelectedData()
        {
            return selected;
        }
    }
}
