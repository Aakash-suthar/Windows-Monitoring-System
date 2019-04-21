namespace WinOwl
{
    partial class Registerform
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.confirmtextbox = new MetroFramework.Controls.MetroTextBox();
            this.emailtextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordtextbox = new MetroFramework.Controls.MetroTextBox();
            this.usernametextbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(23, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(23, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re-enter Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(23, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.Checked = false;
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(27, 472);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 10;
            this.check.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(53, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "I Agree Terms and Condition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(351, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "x";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // confirmtextbox
            // 
            // 
            // 
            // 
            this.confirmtextbox.CustomButton.FlatAppearance.BorderSize = 0;
            this.confirmtextbox.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmtextbox.CustomButton.Image = null;
            this.confirmtextbox.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.confirmtextbox.CustomButton.Name = "";
            this.confirmtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmtextbox.CustomButton.TabIndex = 1;
            this.confirmtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmtextbox.CustomButton.UseSelectable = true;
            this.confirmtextbox.CustomButton.Visible = false;
            this.confirmtextbox.Lines = new string[0];
            this.confirmtextbox.Location = new System.Drawing.Point(27, 331);
            this.confirmtextbox.MaxLength = 32767;
            this.confirmtextbox.Name = "confirmtextbox";
            this.confirmtextbox.PasswordChar = '*';
            this.confirmtextbox.PromptText = "Password confirm";
            this.confirmtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmtextbox.SelectedText = "";
            this.confirmtextbox.SelectionLength = 0;
            this.confirmtextbox.SelectionStart = 0;
            this.confirmtextbox.ShortcutsEnabled = true;
            this.confirmtextbox.Size = new System.Drawing.Size(259, 23);
            this.confirmtextbox.TabIndex = 14;
            this.confirmtextbox.UseSelectable = true;
            this.confirmtextbox.WaterMark = "Password confirm";
            this.confirmtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailtextbox
            // 
            // 
            // 
            // 
            this.emailtextbox.CustomButton.FlatAppearance.BorderSize = 0;
            this.emailtextbox.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailtextbox.CustomButton.Image = null;
            this.emailtextbox.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.emailtextbox.CustomButton.Name = "";
            this.emailtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailtextbox.CustomButton.TabIndex = 1;
            this.emailtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailtextbox.CustomButton.UseSelectable = true;
            this.emailtextbox.CustomButton.Visible = false;
            this.emailtextbox.Lines = new string[0];
            this.emailtextbox.Location = new System.Drawing.Point(27, 427);
            this.emailtextbox.MaxLength = 32767;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.PasswordChar = '\0';
            this.emailtextbox.PromptText = "example@gmail.com";
            this.emailtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailtextbox.SelectedText = "";
            this.emailtextbox.SelectionLength = 0;
            this.emailtextbox.SelectionStart = 0;
            this.emailtextbox.ShortcutsEnabled = true;
            this.emailtextbox.Size = new System.Drawing.Size(259, 23);
            this.emailtextbox.TabIndex = 15;
            this.emailtextbox.UseSelectable = true;
            this.emailtextbox.WaterMark = "example@gmail.com";
            this.emailtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordtextbox
            // 
            // 
            // 
            // 
            this.passwordtextbox.CustomButton.FlatAppearance.BorderSize = 0;
            this.passwordtextbox.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordtextbox.CustomButton.Image = null;
            this.passwordtextbox.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.passwordtextbox.CustomButton.Name = "";
            this.passwordtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordtextbox.CustomButton.TabIndex = 1;
            this.passwordtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordtextbox.CustomButton.UseSelectable = true;
            this.passwordtextbox.CustomButton.Visible = false;
            this.passwordtextbox.Lines = new string[0];
            this.passwordtextbox.Location = new System.Drawing.Point(27, 232);
            this.passwordtextbox.MaxLength = 32767;
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.PromptText = "Password min 8 chars";
            this.passwordtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtextbox.SelectedText = "";
            this.passwordtextbox.SelectionLength = 0;
            this.passwordtextbox.SelectionStart = 0;
            this.passwordtextbox.ShortcutsEnabled = true;
            this.passwordtextbox.Size = new System.Drawing.Size(259, 23);
            this.passwordtextbox.TabIndex = 16;
            this.passwordtextbox.UseSelectable = true;
            this.passwordtextbox.WaterMark = "Password min 8 chars";
            this.passwordtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernametextbox
            // 
            // 
            // 
            // 
            this.usernametextbox.CustomButton.FlatAppearance.BorderSize = 0;
            this.usernametextbox.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernametextbox.CustomButton.Image = null;
            this.usernametextbox.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.usernametextbox.CustomButton.Name = "";
            this.usernametextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernametextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernametextbox.CustomButton.TabIndex = 1;
            this.usernametextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernametextbox.CustomButton.UseSelectable = true;
            this.usernametextbox.CustomButton.Visible = false;
            this.usernametextbox.Lines = new string[0];
            this.usernametextbox.Location = new System.Drawing.Point(27, 141);
            this.usernametextbox.MaxLength = 32767;
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.PasswordChar = '\0';
            this.usernametextbox.PromptText = "Username min 6 chars";
            this.usernametextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametextbox.SelectedText = "";
            this.usernametextbox.SelectionLength = 0;
            this.usernametextbox.SelectionStart = 0;
            this.usernametextbox.ShortcutsEnabled = true;
            this.usernametextbox.Size = new System.Drawing.Size(259, 23);
            this.usernametextbox.TabIndex = 17;
            this.usernametextbox.UseSelectable = true;
            this.usernametextbox.WaterMark = "Username min 6 chars";
            this.usernametextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 576);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.confirmtextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCheckbox check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MetroFramework.Controls.MetroTextBox confirmtextbox;
        private MetroFramework.Controls.MetroTextBox usernametextbox;
        private MetroFramework.Controls.MetroTextBox passwordtextbox;
        private MetroFramework.Controls.MetroTextBox emailtextbox;
    }
}

