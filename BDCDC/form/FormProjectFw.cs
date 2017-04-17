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
            foreach(LJZ ljz in ljzList)
            {
                TreeNode n = new TreeNode(ljz.LJZH);
                n.Tag = ljz;
                root.Nodes.Add(n);
            }
        }

        private void FormProjectFw_Load(object sender, EventArgs e)
        {

        }

        private void m_create_ljz_Click(object sender, EventArgs e)
        {

        }

        private void create_h_Click(object sender, EventArgs e)
        {

        }

        private void m_fwlz_Click(object sender, EventArgs e)
        {

        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode n = e.Node;
            if(n.Tag is LJZ)
            {
                LJZ ljz = (LJZ)n.Tag;
                int id = ljz.fId;
                List<H> hList = hs.findByLjzId(id);
                dgv.DataSource = hList;
            }
        }
    }
}
