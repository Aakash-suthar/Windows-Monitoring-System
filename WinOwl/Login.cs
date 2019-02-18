using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOwl
{
    public partial class Login : MetroForm
    {
        private static readonly string StartupKey = @"HKEY_CURRENT_USER\MyApplication";
        private static readonly string StartupValue = "WinOwl";
        public static MetroForm Form1Instance;

        public Login()
        {
            Form1Instance = this;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text == "smit" && PasswordTextbox.Text == "smit123")
            {
                Hide();
                if (Main.MainForm == null)
                {
                    Main f = new Main();
                    f.Show();
                }
                else { Main.MainForm.Show(); }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (Main.MainForm == null)
            {
                Dispose();
            }
            else
            {
                LoginNotify.Visible = true;
                Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(Registry.GetValue(StartupKey, StartupValue, 0)) == 0)
            //{
               // RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
               // key.SetValue(StartupValue, Application.ExecutablePath.ToString());
               // //Registry.SetValue(REGISTRY_KEY, REGISTY_VALUE, 1, Microsoft.Win32.RegistryValueKind.DWord);
           // }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Login.Form1Instance.Show();
            LoginNotify.Visible = false;
        }


        //private static void SetStartup()
        //{
        //    //Set the application to run at startup
        //    RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
        //    key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        //}
    }
}
