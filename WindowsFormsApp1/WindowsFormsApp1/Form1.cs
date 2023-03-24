using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // コンストラクタ
        public Form1()
        {
            InitializeComponent();

            // アセンブリバージョンを取得
            string assemblyVersion = GetAssemblyVersion();
            // バージョンを表示
            if (assemblyVersion != "")
            {
                AssemblyVersionLabel.Text = assemblyVersion;
            }
            else
            {
                AssemblyVersionLabel.Text = "";
            }


            // ClickOnce発行バージョンを取得
            string clickOnceVersion = GetClickOnceVersion();
            // バージョンを表示
            if (clickOnceVersion != "")
            {
                ClickOnceVersionLabel.Text = clickOnceVersion;
            }
            else
            {
                ClickOnceVersionLabel.Text = "";
            }
        }


        // アセンブリバージョン取得メソッド
        private string GetAssemblyVersion()
        {
            string verStr = "";

            // アセンブリを取得
            Assembly assem = Assembly.GetExecutingAssembly();
            // バージョンを取得
            verStr = assem.GetName().Version.ToString();

            return verStr;
        }


        // ClickOnce発行バージョン取得メソッド
        private string GetClickOnceVersion()
        {
            string verStr = "";

            // ClickOnceアプリケーションかチェック
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                // バージョンを取得
                Version ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                verStr = $"{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";
            }

            return verStr;
        }
    }
}