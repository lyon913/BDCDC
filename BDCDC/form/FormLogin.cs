using BDCDC.model;
using BDCDC.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormLogin : Form
    {
        private UserService us = new UserService();

        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = b_login;
        }

        private void b_config_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDbConfig f = new FormDbConfig();
            f.ShowDialog(this);
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                string loginName = this.tb_name.Text;
                string pwd = this.tb_password.Text;
                us.login(loginName, pwd);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this,ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
