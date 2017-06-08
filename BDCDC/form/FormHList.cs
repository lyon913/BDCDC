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

            dgv.AutoGenerateColumns = false;
            //UiUtils.dgvAddHeaderCheckBox(dgv);
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
            foreach (DataGridViewRow row in dgv.Rows)
            {
                H h = (H)row.DataBoundItem;
                if(h.QJDCXMID != null)
                {
                    row.Cells["c_select"].ReadOnly = true;
                }
                
            }
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            if (dgv.Columns[e.ColumnIndex].Name == "c_select")
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                toggleCheckBoxCell(cell);
            }
            
        }

        private void checkAll()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["c_select"].Value = true;
            }
        }

        private void checkInvert()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["c_select"];
                toggleCheckBoxCell(cell);
            }
        }

        private void uncheckAll()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["c_select"].Value = false;
            }
        }

        private void toggleCheckBoxCell(DataGridViewCheckBoxCell cell)
        {
            if (cell.Value == null)
            {
                cell.Value = true;
            }
            else
            {
                cell.Value = !(bool)cell.Value;
            }
        }

        private List<H> getSelectedHList()
        {
            List<H> list = new List<H>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                object value = row.Cells["c_select"].Value;
                if (value != null && (bool)value == true)
                {
                    list.Add((H)row.DataBoundItem);
                }
            }

            return list;
        }

        private void b_checkAll_Click(object sender, EventArgs e)
        {
            checkAll();
        }

        private void b_checkInvert_Click(object sender, EventArgs e)
        {
            checkInvert();
        }

        private void b_uncheckAll_Click(object sender, EventArgs e)
        {
            uncheckAll();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            selectedH = getSelectedHList();
            if(selectedH == null || selectedH.Count < 1)
            {
                MessageBox.Show(this, "请选择要操作的户信息。");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<H> getData()
        {
            return this.selectedH;
        }
    }
}
 