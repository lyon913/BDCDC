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
    public partial class FormHList : Form
    {
        private XmService xs = new XmService();
        private LjzService ls = new LjzService();
        private HService hs = new HService();

        private XM selectedXm = null;
        private LJZ selectedLjz = null;
        private List<H> selectedH = null;
        

        public FormHList()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            initUI();
        }

        private void initUI()
        {
            list_xm.DisplayMember = "XMMC";
            list_ljz.DisplayMember = "LJZH";
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            string key_xmmc = tb_xmmc.Text;
            string key_xmlz = tb_xmzl.Text;

            if(String.IsNullOrEmpty(key_xmmc) && String.IsNullOrEmpty(key_xmlz))
            {
                MessageBox.Show(this, "请填写查询条件","错误");
                return;
            }

            List<XM> xmList = xs.search(key_xmmc, null, key_xmlz);
            loadXmList(xmList);

        }

        private void loadXmList(List<XM> list)
        {
            list_xm.DataSource = list;
        }

        private void loadLjzList(List<LJZ> list)
        {
            list_ljz.DataSource = list;
        }

        private void loadHList(List<H> list)
        {
            dgv.DataSource = list;
        }

        private void list_xm_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedXm = (XM)list_xm.SelectedItem;
            List<LJZ> ljzList = ls.findByXmId(selectedXm.fId);
            loadLjzList(ljzList);
        }

        private void list_ljz_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedLjz = (LJZ)list_ljz.SelectedItem;
            List<H> hList = hs.findByLjzId(selectedLjz.fId);
            loadHList(hList);
        }
    }
}
 