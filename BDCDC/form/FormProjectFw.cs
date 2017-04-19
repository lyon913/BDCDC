using BDCDC.model;
using BDCDC.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormProjectFw : Form
    {
        private QJDCXM dcxm;

        private List<LJZ> ljzList;

        private HService hs = new HService();
        private LjzService ls = new LjzService();

        public FormProjectFw(QJDCXM dcxm)
        {
            this.dcxm = dcxm;
            InitializeComponent();
            init();
        }

        private void init()
        {
            initData();
            initTreeView();
        }

        private void initData()
        {
            ljzList = ls.findByDcxmId(dcxm.fId);
        }

        private void initTreeView()
        {
            TreeNode root = new TreeNode("逻辑幢");
            tv.Nodes.Add(root);

            foreach (LJZ ljz in ljzList)
            {
                TreeNode n = new TreeNode(ljz.LJZH);
                n.Tag = ljz;
                root.Nodes.Add(n);
            }

            tv.ExpandAll();
            
        }

        private void FormProjectFw_Load(object sender, EventArgs e)
        {

        }

        private void m_create_ljz_Click(object sender, EventArgs e)
        {

        }

        private void create_h_Click(object sender, EventArgs e)
        {
            FormLjzSelect f = new FormLjzSelect();
            DialogResult r = f.ShowDialog(this);
            if(r == DialogResult.OK)
            {
                ZRZ z = f.selectedZrz;
                LJZ l = f.selectedLjz;

                H h = hs.newH(dcxm.fId, z, l);
                FormH fh = new FormH(h);
                DialogResult rh = fh.ShowDialog(this);
                if(rh == DialogResult.OK)
                {
                    loadHList();
                }
            }
        }

        private void m_fwlz_Click(object sender, EventArgs e)
        {

        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            loadHList();
        }

        private void loadHList()
        {
            TreeNode n = tv.SelectedNode;
            if (n != null && n.Tag is LJZ)
            {
                LJZ ljz = (LJZ)n.Tag;
                int id = ljz.fId;
                List<H> hList = hs.findByLjzId(id);
                dgv.DataSource = hList;
            }
        }
    }
}
