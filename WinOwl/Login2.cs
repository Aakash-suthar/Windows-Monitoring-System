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
    public partial class Login2 : Form
    {
        public static Form Form1Instance;
        public Login2()
        {
            Form1Instance = this;
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          //  if (UsernameTextbox.Text == "smit" && PasswordTextbox.Text == "smit123")
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

        private void Login2_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(Log.RecentFile))
            {
                MessageBox.Show("Login to save file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
