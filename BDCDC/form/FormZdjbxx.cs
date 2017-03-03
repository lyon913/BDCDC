using BDCDC.model;
using BDCDC.service;
using BDCDC.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
         * 新建宗地
         * 
         * */
        public FormZdjbxx()
        {
            InitializeComponent();

            //初始化成员变量
            items = new DataItemsService();
            zdService = new ZdService();

            //待编辑的宗地基本信息
            zdjbxx = new ZDJBXX();
            //设置初始默认值
            zdjbxx.QLLX = "3";
            zdjbxx.QLXZ = "102";
            zdjbxx.YT = "71";
            zdjbxx.DJ = "1";
            zdjbxx.MJDW = "1";

        }

        /**
         * 已有宗地信息编辑
         * 
         * */
        public FormZdjbxx( ZDJBXX zdjbxx)
        {
            InitializeComponent();

            //初始化成员变量
            items = new DataItemsService();
            zdService = new ZdService();

            //待编辑的宗地基本信息
            this.zdjbxx = zdjbxx;

        }

        //初始化
        private void FormZdjbxx_Load(object sender, EventArgs e)
        {
            using (var ctx = new BdcContext())
            {
                List<DJZQ> djzqList = zdService.getDjzqAll(ctx);
                formatDjzqName(djzqList);
                this.cb_djzq.DataSource = djzqList;
                this.cb_djzq.DisplayMember = "DJZQMC";
                this.cb_djzq.ValueMember = "DJZQDM";

                //宗地特征码--所有权类型
                UiUtils.comboboxDataItems(cb_syqlx, "所有权类型", true);

                //宗地特征码--特征码
                UiUtils.comboboxDataItems(cb_zdtzm, "宗地（宗海）特征码", true);

                //定着物特征码--特征码
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

                /*
                //地籍子区下拉
                List<DJZQ> djzqList = zdService.getDjzqAll(ctx);
                formatDjzqName(djzqList);
                this.cb_djzq.DataSource = djzqList;
                this.cb_djzq.DisplayMember = "DJZQMC";
                this.cb_djzq.ValueMember = "DJZQDM";

                //宗地特征码--所有权类型
                List<DataItems> syqlxList = items.getItemsByType("所有权类型", ctx);
                DataItemsService.formatItemName(syqlxList);
                this.cb_syqlx.DataSource = syqlxList;
                this.cb_syqlx.DisplayMember = "itemName";
                this.cb_syqlx.ValueMember = "itemCode";

                //宗地特征码--特征码
                List<DataItems> zdtzmList = items.getItemsByType("宗地（宗海）特征码", ctx);
                DataItemsService.formatItemName(zdtzmList);
                this.cb_zdtzm.DataSource = zdtzmList;
                this.cb_zdtzm.DisplayMember = "itemName";
                this.cb_zdtzm.ValueMember = "itemCode";

                //定着物特征码--特征码
                List<DataItems> dzwtzmList = items.getItemsByType("定着物特征码", ctx);
                //过滤掉定着物类型为房屋的
                dzwtzmList = dzwtzmList.Where(item => !"F".Equals(item.itemCode)).ToList();
                DataItemsService.formatItemName(dzwtzmList);
                this.cb_dzwtzm.DataSource = dzwtzmList;
                this.cb_dzwtzm.DisplayMember = "itemName";
                this.cb_dzwtzm.ValueMember = "itemCode";

                //权利类型
                List<DataItems> qllxList = items.getItemsByType("权利类型", ctx);
                this.cb_qllx.DataSource = qllxList;
                this.cb_qllx.DisplayMember = "itemName";
                this.cb_qllx.ValueMember = "itemCode";

                //权利性质
                List<DataItems> qlxzList = items.getItemsByType("权利性质", ctx);
                this.cb_qlxz.DataSource = qlxzList;
                this.cb_qlxz.DisplayMember = "itemName";
                this.cb_qlxz.ValueMember = "itemCode";

                //用途
                List<DataItems> ytList = items.getItemsByType("土地用途", ctx);
                DataItemsService.formatItemName(ytList);
                this.cb_yt.DataSource = ytList;
                this.cb_yt.DisplayMember = "itemName";
                this.cb_yt.ValueMember = "itemCode";

                //面积单位
                List<DataItems> mjdwList = items.getItemsByType("面积单位", ctx);
                this.cb_mjdw.DataSource = mjdwList;
                this.cb_mjdw.DisplayMember = "itemName";
                this.cb_mjdw.ValueMember = "itemCode";

                //等级
                List<DataItems> djList = items.getItemsByType("土地等级", ctx);
                this.cb_dj.DataSource = djList;
                this.cb_dj.DisplayMember = "itemName";
                this.cb_dj.ValueMember = "itemCode";
                */

                //表单数据绑定

                //宗地代码
                tb_zddm.DataBindings.Add("Text", zdjbxx, "ZDDM", false, DataSourceUpdateMode.OnPropertyChanged);

                //不动产单元号
                tb_bdcdyh.DataBindings.Add("Text", zdjbxx, "BDCDYH", false, DataSourceUpdateMode.OnPropertyChanged);
                //权利类型
                cb_qllx.DataBindings.Add("SelectedValue", zdjbxx, "QLLX", false, DataSourceUpdateMode.OnPropertyChanged);
                //权利性质
                cb_qlxz.DataBindings.Add("SelectedValue", zdjbxx, "QLXZ", false, DataSourceUpdateMode.OnPropertyChanged);
                //土地用途
                cb_yt.DataBindings.Add("SelectedValue", zdjbxx, "YT", false, DataSourceUpdateMode.OnPropertyChanged);
                //土地等级
                cb_dj.DataBindings.Add("SelectedValue", zdjbxx, "DJ", false, DataSourceUpdateMode.OnPropertyChanged);
                //土地等级
                cb_mjdw.DataBindings.Add("SelectedValue", zdjbxx, "MJDW", false, DataSourceUpdateMode.OnPropertyChanged);

                //宗地面积
                nb_zdmj.DataBindings.Add("Value", zdjbxx, "ZDMJ", true, DataSourceUpdateMode.OnPropertyChanged,decimal.Zero);
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

        }

        //自动获取宗地顺序号
        private void bt_getMaxZdsxh_Click(object sender, EventArgs e)
        {
            DJZQ djzq = (DJZQ)cb_djzq.SelectedItem;
            if(djzq == null)
            {
                MessageBox.Show(this, "请先选择地籍子区", "校验", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var ctx = new BdcContext())
            {
                String sxh = zdService.getMaxZdsxh(djzq.DJZQDM, ctx);
                this.tb_zdsxh.Text = sxh;

                updateZddm();
            }

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
            using (var ctx = new BdcContext())
            {
                String dzwsxh = zdService.getMaxDzwsxh(zddm, dzwtzm, ctx);
                tb_dzwsxh.Text = dzwsxh;
                updateBdcdyh();
            }

        }

        //格式化地籍子区下拉列表
        private void formatDjzqName(List<DJZQ> list)
        {
            foreach(DJZQ djzq in list)
            {
                djzq.DJZQMC = djzq.DJZQMC + "(" + djzq.DJZQDM + ")";
            }
        }




        private void updateZddm()
        {
            String zdsxh = tb_zdsxh.Text;
            if(zdsxh != null && !"".Equals(zdsxh))
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
            String dzwtzm = cb_dzwtzm.SelectedValue.ToString();

            if (dzwsxh != null && !"".Equals(dzwsxh))
            {
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
            updateZddm();
        }

        private void cb_djzq_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateZddm();
        }

        private void cb_syqlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateZddm();
        }

        private void cb_zdtzm_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateZddm();
        }

        private void tb_dzwsxh_TextChanged(object sender, EventArgs e)
        {
            updateBdcdyh();
        }

        private void cb_dzwtzm_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBdcdyh();
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
                MessageBox.Show(this,"请选择宗地图","校验",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        }

        //选择宗地图按钮
        private void bt_zdt_Click(object sender, EventArgs e)
        {
            //用户选取宗地对应的宗地图，设置到SHAPE字段

            //TODO 此代码为模拟的多边形，需要替换为实际图形代码
            //坐标系4543为：CGCS2000_3_Degree_GK_CM_102E
            zdjbxx.SHAPE = DbGeometry.PolygonFromText("POLYGON ((0 450000, 100 450000, 100 450100, 0 450100,0 450000))", 4543);
        }

    }
}
