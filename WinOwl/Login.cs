using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.BackColor = Color.FromArgb(43, 39, 59);
            Form1Instance = this;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Creditional c = new Creditional();
            if(UsernameTextbox.Text == c.Readuser() && PasswordTextbox.Text == c.Readpass())
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
            if (File.Exists(Log.RecentFile))
            {
                MessageBox.Show("Login to save file.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!File.Exists(Creditional.sam1))
            {
                Hide();
                Registerform r = new Registerform();
                r.Show();
            }
            else MessageBox.Show("Admin already registered.");
        }


        //private static void SetStartup()
        //{
        //    //Set the application to run at startup
        //    RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
        //    key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        //}
    }
}
