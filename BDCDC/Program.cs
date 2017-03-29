using BDCDC.form;
using ESRI.ArcGIS;
using ESRI.ArcGIS.esriSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //指定arcgis 版本
            if (!RuntimeManager.Bind(ProductCode.Engine))
            {
                MessageBox.Show("未找到Arcgis Engine。");
                return;
            }
            //初始化Arcgis授权
            AoInitialize init = new AoInitialize();
            esriLicenseStatus status = init.Initialize(esriLicenseProductCode.esriLicenseProductCodeEngineGeoDB);

            //程序初始化
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FormBdcMain());

            FormLogin loginForm = new FormLogin();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormBdcMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
