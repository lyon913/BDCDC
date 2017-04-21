using BDCDC.model;
using BDCDC.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BDCDC.form.ctrl
{
    /// <summary>
    /// Test.xaml 的交互逻辑
    /// </summary>
    public partial class Test : UserControl
    {

        private QJDCXM dcxm;
        private DataItemsService ds = new DataItemsService();

        public Test()
        {
            InitializeComponent();
        }
        public void setData(QJDCXM dcxm)
        {
            this.dcxm = dcxm;
            update();
        }

        private void update()
        {
            if (dcxm == null)
            {
                dcxm = new QJDCXM();
            }
            tb_xmmc.Text = dcxm.XMMC;
            tb_xmlx.Text = ds.translateDataItem("权籍调查项目类型", dcxm.XMLX);

        }

    }
}
