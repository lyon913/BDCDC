using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDCDC.form
{
    /**
     * 宗地基本信息编辑窗口
     * 
     * */
    public partial class FormZdjbxx : Form
    {
        //获取系统配置项服务类
        private DataItemsService items;
        //宗地服务类
        private ZdService zdService;

        public ZDJBXX zdjbxx { get; set; }

        /**
         * 已有宗地信息编辑
         * 
         * */
        public FormZdjbxx(ZDJBXX zdjbxx)
        {
            InitializeComponent();
            this.zdjbxx = zdjbxx;
            init();
        }
        private void init()
        {
            initServices();
            initDataItems();
            initDataBandings();
            initBdcdyh();
        }

        private void initServices()
        {
            items = new DataItemsService();
            zdService = new ZdService();
        }

        private void initDataItems()
        {
            //地籍子区
            List<DataItems> djzqList = zdService.getDjzqAsDataItems();
            UiUtils.comboboxDataItems(this.cb_djzq, djzqList, true);

            //宗地特征码--所有权类型
            UiUtils.comboboxDataItems(cb_syqlx, "所有权类型", true);

            //宗地特征码--特征码
            UiUtils.comboboxDataItems(cb_zdtzm, "宗地（宗海）特征码", true);

            //定着物特征码
            UiUtils.comboboxDataItems(cb_dzwtzm, "定着物特征码", true);

            //权利类型
            UiUtils.comboboxDataItems(cb_qllx, "权利类型", false);

            //权利性质
            UiUtils.comboboxDataItems(cb_qlxz, "权利性质", false);

            //用途
            UiUtils.comboboxDataItems(cb_yt, "土地用途", true);

            //面积单位
            UiUtils.comboboxDataItems(cb_mjdw, "面积单位", false);

            //等级
            UiUtils.comboboxDataItems(cb_dj, "土地等级", false);
        }

        private void initDataBandings()
        {
            //表单数据绑定

            //宗地代码
            tb_zddm.DataBindings.Add("Text", zdjbxx, "ZDDM", false, DataSourceUpdateMode.OnPropertyChanged);

            //不动产单元号
            tb_bdcdyh.DataBindings.Add("Text", zdjbxx, "BDCDYH", false, DataSourceUpdateMode.OnPropertyChanged);
            //权利类型
            cb_qllx.DataBindings.Add("SelectedValue", zdjbxx, "QLLX", true, DataSourceUpdateMode.OnPropertyChanged, "3");
            //权利性质
            cb_qlxz.DataBindings.Add("SelectedValue", zdjbxx, "QLXZ", true, DataSourceUpdateMode.OnPropertyChanged, "102");
            //土地用途
            cb_yt.DataBindings.Add("SelectedValue", zdjbxx, "YT", true, DataSourceUpdateMode.OnPropertyChanged, "71");
            //土地等级
            cb_dj.DataBindings.Add("SelectedValue", zdjbxx, "DJ", true, DataSourceUpdateMode.OnPropertyChanged, "1");
            //面积单位
            cb_mjdw.DataBindings.Add("SelectedValue", zdjbxx, "MJDW", true, DataSourceUpdateMode.OnPropertyChanged, "1");

            //宗地面积
            nb_zdmj.DataBindings.Add("Value", zdjbxx, "ZDMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            //容积率
            nb_rjl.DataBindings.Add("Value", zdjbxx, "RJL", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            //建筑密度
            nb_jzmd.DataBindings.Add("Value", zdjbxx, "JZMD", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            //建筑限高
            nb_jzxg.DataBindings.Add("Value", zdjbxx, "JZXG", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            //价格
            nb_jg.DataBindings.Add("Value", zdjbxx, "JG", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            //宗地四至
            tb_zdszb.DataBindings.Add("Text", zdjbxx, "ZDSZB", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zdszd.DataBindings.Add("Text", zdjbxx, "ZDSZD", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zdszx.DataBindings.Add("Text", zdjbxx, "ZDSZX", false, DataSourceUpdateMode.OnPropertyChanged);
            tb_zdszn.DataBindings.Add("Text", zdjbxx, "ZDSZN", false, DataSourceUpdateMode.OnPropertyChanged);

            //坐落
            tb_zl.DataBindings.Add("Text", zdjbxx, "ZL", false, DataSourceUpdateMode.OnPropertyChanged);
            //地籍号
            tb_djh.DataBindings.Add("Text", zdjbxx, "DJH", false, DataSourceUpdateMode.OnPropertyChanged);
            //图幅号
            tb_tfh.DataBindings.Add("Text", zdjbxx, "TFH", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void initBdcdyh()
        {
            if (zdjbxx != null && zdjbxx.BDCDYH != null)
            {
                String bdcdyh = zdjbxx.BDCDYH;
                if (bdcdyh.Length == 28)
                {
                    String djzq = bdcdyh.Substring(0, 12);
                    String tzm1 = bdcdyh.Substring(12, 1);
                    String tzm2 = bdcdyh.Substring(13, 1);
                    String zdsxh = bdcdyh.Substring(14, 5);
                    String dzwtzm = bdcdyh.Substring(19, 1);
                    String dzwsxh = bdcdyh.Substring(20, 8);

                    this.cb_djzq.SelectedValue = djzq;
                    this.cb_syqlx.SelectedValue = tzm1;
                    this.cb_zdtzm.SelectedValue = tzm2;
                    this.tb_zdsxh.Text = zdsxh;
                    this.cb_dzwtzm.SelectedValue = dzwtzm;
                    this.tb_dzwsxh.Text = dzwsxh;
                }
            }
        }

        //初始化
        private void FormZdjbxx_Load(object sender, EventArgs e)
        {

        }

        //自动获取宗地顺序号
        private void bt_getMaxZdsxh_Click(object sender, EventArgs e)
        {
            DataItems djzq = (DataItems)cb_djzq.SelectedItem;
            if (djzq == null)
            {
                MessageBox.Show(this, "请先选择地籍子区", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String sxh = zdService.getMaxZdsxh(djzq.itemCode);
            this.tb_zdsxh.Text = sxh;
            updateZddm();
        }

        //自动获取定着物顺序号
        private void bt_getDzwsxh_Click(object sender, EventArgs e)
        {
            String zddm = tb_zddm.Text;
            String dzwtzm = (String)cb_dzwtzm.SelectedValue;
            if (zddm == null || zddm.Length != 19)
            {
                MessageBox.Show("请先确定宗地代码");
                return;
            }
            String dzwsxh = zdService.getMaxDzwsxh(zddm, dzwtzm);
            tb_dzwsxh.Text = dzwsxh;
            updateBdcdyh();

        }

        //格式化地籍子区下拉列表
        private void formatDjzqName(List<DJZQ> list)
        {
            foreach (DJZQ djzq in list)
            {
                djzq.DJZQMC = djzq.DJZQMC + "(" + djzq.DJZQDM + ")";
            }
        }

        private void updateBm()
        {
            updateZddm();
            updateBdcdyh();
        }


        private void updateZddm()
        {
            String zdsxh = tb_zdsxh.Text;
            if (zdsxh != null && !"".Equals(zdsxh))
            {
                String djzq = (String)cb_djzq.SelectedValue;
                String syqlx = (String)cb_syqlx.SelectedValue;
                String zdtzm = (String)cb_zdtzm.SelectedValue;

                tb_zddm.Text = djzq + syqlx + zdtzm + zdsxh;
            }

        }

        private void updateBdcdyh()
        {
            String dzwsxh = tb_dzwsxh.Text;

            if (dzwsxh != null && !"".Equals(dzwsxh))
            {

                String dzwtzm = (String)cb_dzwtzm.SelectedValue;
                String zddm = (String)tb_zddm.Text;
                if (zddm != null && !"".Equals(zddm))
                {
                    tb_bdcdyh.Text = zddm + dzwtzm + dzwsxh;
                }
            }
        }



        //宗地顺序号变化后，更新宗地代码值
        private void tb_zdsxh_TextChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void cb_djzq_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void cb_syqlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void cb_zdtzm_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void tb_dzwsxh_TextChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void cb_dzwtzm_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBm();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //存储ZDJBXX 和对应的宗地图
                zdService.saveOrUpdate(zdjbxx);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validate()
        {
            if (zdjbxx.ZDDM == null || "".Equals(zdjbxx.ZDDM))
            {
                MessageBox.Show(this, "请编制宗地代码", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (zdjbxx.BDCDYH == null || "".Equals(zdjbxx.BDCDYH))
            {
                MessageBox.Show(this, "请编制不动产单元号", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (zdjbxx.SHAPE == null)
            {
                MessageBox.Show(this, "请选择宗地图", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //退出按钮
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //宗地面积计算按钮
        private void bt_calc_Click(object sender, EventArgs e)
        {
            //根据宗地图计算面积
            if (zdjbxx != null && zdjbxx.SHAPE != null)
            {
                double area = (double)zdjbxx.SHAPE.Area;
                this.nb_zdmj.Value = Decimal.Round(new Decimal(area), 4);
            }
        }

    }
}
