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
    public partial class Registerform : Form
    {
        char[] b = { '@', '.', 'c', 'o', 'm' };
        char[] c = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'q', 'v', 'w', 'r', 's', 't', 'u', 'x', 'y', 'z' };

        public Registerform()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Form1Instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametextbox.Text.Length < 6) {usernametextbox.Text = ""; usernametextbox.PromptText = "min 8 chars";}
            else if(passwordtextbox.Text.Length<8) { passwordtextbox.Text = ""; confirmtextbox.Text = ""; }
            else if(passwordtextbox.Text != confirmtextbox.Text) { confirmtextbox.Text = "";confirmtextbox.PromptText = "Pass did not match"; }
            else if (emailtextbox.Text.Length < 10 || emailtextbox.Text.Contains('@') == false || emailtextbox.Text.Contains('.') == false)
            { emailtextbox.Text = "";emailtextbox.PromptText = "Enter correct email";            }
            else if (check.Checked) { MessageBox.Show("Agree terms and conditons.."); }
            else
            {
                Creditional c = new Creditional();
                
                c.Savefile(usernametextbox.Text,passwordtextbox.Text);
                Hide();
                MessageBox.Show("Successfully registered.","Success",MessageBoxButtons.OK);
                Login.Form1Instance.Show();
            }
        }
    }
}
