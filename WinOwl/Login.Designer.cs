namespace WinOwl
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.UsernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(88, 170);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(77, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Location = new System.Drawing.Point(254, 170);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(77, 32);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.TabStop = false;
            this.metroButton2.Text = "Exit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // UsernameTextbox
            // 
            // 
            // 
            // 
            this.UsernameTextbox.CustomButton.Image = null;
            this.UsernameTextbox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.UsernameTextbox.CustomButton.Name = "";
            this.UsernameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextbox.CustomButton.TabIndex = 1;
            this.UsernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextbox.CustomButton.UseSelectable = true;
            this.UsernameTextbox.CustomButton.Visible = false;
            this.UsernameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UsernameTextbox.Lines = new string[0];
            this.UsernameTextbox.Location = new System.Drawing.Point(136, 55);
            this.UsernameTextbox.MaxLength = 32767;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.PromptText = "Username";
            this.UsernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.SelectionLength = 0;
            this.UsernameTextbox.SelectionStart = 0;
            this.UsernameTextbox.ShortcutsEnabled = true;
            this.UsernameTextbox.Size = new System.Drawing.Size(144, 23);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTextbox.UseSelectable = true;
            this.UsernameTextbox.WaterMark = "Username";
            this.UsernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextbox
            // 
            // 
            // 
            // 
            this.PasswordTextbox.CustomButton.Image = null;
            this.PasswordTextbox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.PasswordTextbox.CustomButton.Name = "";
            this.PasswordTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextbox.CustomButton.TabIndex = 1;
            this.PasswordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextbox.CustomButton.UseSelectable = true;
            this.PasswordTextbox.CustomButton.Visible = false;
            this.PasswordTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordTextbox.Lines = new string[0];
            this.PasswordTextbox.Location = new System.Drawing.Point(136, 109);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.PromptText = "Password";
            this.PasswordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.SelectionLength = 0;
            this.PasswordTextbox.SelectionStart = 0;
            this.PasswordTextbox.ShortcutsEnabled = true;
            this.PasswordTextbox.Size = new System.Drawing.Size(144, 23);
            this.PasswordTextbox.TabIndex = 1;
            this.PasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextbox.UseSelectable = true;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.WaterMark = "Password";
            this.PasswordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(433, 233);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox UsernameTextbox;
        private MetroFramework.Controls.MetroTextBox PasswordTextbox;
    }
}