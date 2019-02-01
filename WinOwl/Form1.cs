using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Vault
{
    public  partial class Form1 : MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CreateLink1_Click(object sender, EventArgs e)
        {
             this.Hide();
             Signup s = new Signup();
             s.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.First == 0)
            {
                if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
                {
                    Welcome.ForeColor = System.Drawing.Color.White;
                }
                else if (this.Theme == MetroFramework.MetroThemeStyle.Light)
                {
                    Welcome.ForeColor = System.Drawing.Color.Black;
                }
                this.UserTextBox1.Enabled = false;
                this.UserTextBox1.Visible = false;
                this.PassTextBox1.Enabled = false;
                this.PassTextBox1.Visible = false;
                this.GetaLink1.Enabled = false;
                this.GetaLink1.Visible = false;
            }
            
            else if (Properties.Settings.Default.First == 1)
            {
                if (this.UserTextBox1.Theme == MetroFramework.MetroThemeStyle.Dark)
                {
                    Welcome.ForeColor = System.Drawing.Color.White;
                    UserTextBox1.WaterMarkColor = System.Drawing.Color.White;
                    PassTextBox1.WaterMarkColor = System.Drawing.Color.White;
                }
                else if (this.UserTextBox1.Theme == MetroFramework.MetroThemeStyle.Light)
                {
                    UserTextBox1.WaterMarkColor = System.Drawing.Color.Black;
                    PassTextBox1.WaterMarkColor = System.Drawing.Color.Black;
                    Welcome.ForeColor = System.Drawing.Color.Black;
                }
                this.UserTextBox1.Enabled = true;
                this.UserTextBox1.Visible = true;
                this.CreateLink1.Enabled = false;
                this.CreateLink1.Visible = false;
                this.PassTextBox1.Visible = true;
                this.PassTextBox1.Enabled = true;
                this.GetaLink1.Enabled = true;
                this.GetaLink1.Visible = true;
            }
        }

        private void GetaLink1_Click(object sender, EventArgs e)
        {
            info f1=info.read();
            if (f1 != null)
            {
                if (PassTextBox1.Text == f1.pass && UserTextBox1.Text == f1.name)
                {
                    this.Hide();
                    Done d = new Done();
                    d.Show();
                }
                else {
                    MessageBox.Show(this,"Wrong Username Or Password","Alert",MessageBoxButtons.OK);
                    UserTextBox1.Text = "";
                    PassTextBox1.Text = "";
                }
            }
            else
            {
                if (MessageBox.Show(this, "FIle has been Deleted!! \nCreate New Account", "Error", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Hide();
                    Properties.Settings.Default.First = 0;

                     Signup fw = new Signup();
                    fw.Show();
                }
                else {
                    this.UserTextBox1.Text = "";
                    this.PassTextBox1.Text = "";
                }
            }
        }

        private void GetaLink1_MouseEnter(object sender, EventArgs e)
        {
            GetaLink1.BackgroundImage = Properties.Resources.balck__1_;
        }

        private void GetaLink1_MouseLeave(object sender, EventArgs e)
        {
            GetaLink1.BackgroundImage = Properties.Resources.grey; 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.Flag == 0) {
            //    Properties.Settings.Default.Theme = MetroFramework.MetroThemeStyle.Light;
            //}
            //else if (Properties.Settings.Default.Flag == 1){
            //    Properties.Settings.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
            //}
            Properties.Settings.Default.Save();
            timer1.Start();                   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity == 0.0) {
                timer1.Stop();
                this.Close();
                Application.Exit();
            }
        }

    }
}
