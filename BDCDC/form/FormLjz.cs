﻿using BDCDC.model;
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
    public partial class FormLjz : Form
    {
        private LJZ ljz;

        public FormLjz(LJZ ljz)
        {
            this.ljz = ljz;
            InitializeComponent();

            init();
        }
        private void init()
        {

        }

        private void databinding()
        {
            tb_zrzh.DataBindings.Add("Text", ljz, "ZRZH", false, DataSourceUpdateMode.OnPropertyChanged,null);
            tb_ljzh.DataBindings.Add("Text", ljz, "LJZH", false, DataSourceUpdateMode.OnPropertyChanged, null);
            tb_mph.DataBindings.Add("Text", ljz, "MPH", false, DataSourceUpdateMode.OnPropertyChanged, null);
            tb_bz.DataBindings.Add("Text", ljz, "BZ", false, DataSourceUpdateMode.OnPropertyChanged, null);

            nb_zts.DataBindings.Add("Value", ljz, "ZTS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_zcs.DataBindings.Add("Value", ljz, "ZCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dscs.DataBindings.Add("Value", ljz, "DSCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_dxcs.DataBindings.Add("Value", ljz, "DXCS", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_ycjzmj.DataBindings.Add("Value", ljz, "YCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);
            nb_scjzmj.DataBindings.Add("Value", ljz, "SCJZMJ", true, DataSourceUpdateMode.OnPropertyChanged, decimal.Zero);

            cb_fwyt1.DataBindings.Add("SelectedValue", ljz, "FWYT1", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt2.DataBindings.Add("SelectedValue", ljz, "FWYT2", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwyt3.DataBindings.Add("SelectedValue", ljz, "FWYT3", false, DataSourceUpdateMode.OnPropertyChanged, null);

            cb_fwjg1.DataBindings.Add("SelectedValue", ljz, "FWJG1", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwjg2.DataBindings.Add("SelectedValue", ljz, "FWJG2", false, DataSourceUpdateMode.OnPropertyChanged, null);
            cb_fwjg3.DataBindings.Add("SelectedValue", ljz, "FWJG3", false, DataSourceUpdateMode.OnPropertyChanged, null);

            dp_jgrq.DataBindings.Add("Value", ljz, "JGRQ", true, DataSourceUpdateMode.OnPropertyChanged, new DateTime(2010, 1, 1));
        }

        private void FormLjz_Load(object sender, EventArgs e)
        {

        }
    }
}