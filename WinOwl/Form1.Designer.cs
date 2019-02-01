namespace Vault
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.CreateLink1 = new MetroFramework.Controls.MetroLink();
            this.UserTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.GetaLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Welcome = new System.Windows.Forms.Label();
            this.PassTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(727, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "AkaTech Registered©";
            this.label2.UseMnemonic = false;
            // 
            // CreateLink1
            // 
            this.CreateLink1.BackColor = System.Drawing.Color.Aqua;
            this.CreateLink1.DisplayFocus = true;
            this.CreateLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.CreateLink1.Location = new System.Drawing.Point(342, 253);
            this.CreateLink1.Name = "CreateLink1";
            this.CreateLink1.Size = new System.Drawing.Size(196, 35);
            this.CreateLink1.Style = MetroFramework.MetroColorStyle.White;
            this.CreateLink1.TabIndex = 3;
            this.CreateLink1.TabStop = false;
            this.CreateLink1.Text = "Create Account";
            this.CreateLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CreateLink1.UseCustomBackColor = true;
            this.CreateLink1.UseSelectable = true;
            this.CreateLink1.UseStyleColors = true;
            this.CreateLink1.Click += new System.EventHandler(this.CreateLink1_Click);
            // 
            // UserTextBox1
            // 
            this.UserTextBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UserTextBox1.CustomButton.Image = null;
            this.UserTextBox1.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.UserTextBox1.CustomButton.Name = "";
            this.UserTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserTextBox1.CustomButton.TabIndex = 1;
            this.UserTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserTextBox1.CustomButton.UseSelectable = true;
            this.UserTextBox1.Enabled = false;
            this.UserTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UserTextBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UserTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("UserTextBox1.Icon")));
            this.UserTextBox1.Lines = new string[0];
            this.UserTextBox1.Location = new System.Drawing.Point(359, 224);
            this.UserTextBox1.MaxLength = 10;
            this.UserTextBox1.Name = "UserTextBox1";
            this.UserTextBox1.PasswordChar = '\0';
            this.UserTextBox1.PromptText = "Enter Username";
            this.UserTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTextBox1.SelectedText = "";
            this.UserTextBox1.SelectionLength = 0;
            this.UserTextBox1.SelectionStart = 0;
            this.UserTextBox1.ShortcutsEnabled = true;
            this.UserTextBox1.ShowButton = true;
            this.UserTextBox1.Size = new System.Drawing.Size(179, 23);
            this.UserTextBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.UserTextBox1.TabIndex = 0;
            this.UserTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserTextBox1.UseSelectable = true;
            this.UserTextBox1.UseStyleColors = true;
            this.UserTextBox1.Visible = false;
            this.UserTextBox1.WaterMark = "Enter Username";
            this.UserTextBox1.WaterMarkColor = System.Drawing.Color.Black;
            this.UserTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GetaLink1
            // 
            this.GetaLink1.BackColor = System.Drawing.Color.Transparent;
            this.GetaLink1.BackgroundImage = global::Vault.Properties.Resources.grey;
            this.GetaLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetaLink1.Enabled = false;
            this.GetaLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.GetaLink1.ForeColor = System.Drawing.Color.Transparent;
            this.GetaLink1.ImageSize = 30;
            this.GetaLink1.Location = new System.Drawing.Point(544, 294);
            this.GetaLink1.Name = "GetaLink1";
            this.GetaLink1.Size = new System.Drawing.Size(30, 23);
            this.GetaLink1.TabIndex = 3;
            this.GetaLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GetaLink1.UseMnemonic = false;
            this.GetaLink1.UseSelectable = true;
            this.GetaLink1.Visible = false;
            this.GetaLink1.Click += new System.EventHandler(this.GetaLink1_Click);
            this.GetaLink1.MouseEnter += new System.EventHandler(this.GetaLink1_MouseEnter);
            this.GetaLink1.MouseLeave += new System.EventHandler(this.GetaLink1_MouseLeave);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(3, 401);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(78, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "Exit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseMnemonic = false;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(661, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(209, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "--Remember One to Access All!!!!";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseMnemonic = false;
            this.metroLabel1.UseStyleColors = true;
            // 
            // Welcome
            // 
            this.Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(39, 44);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(809, 107);
            this.Welcome.TabIndex = 20;
            this.Welcome.Text = "Welcome To Vault";
            // 
            // PassTextBox1
            // 
            // 
            // 
            // 
            this.PassTextBox1.CustomButton.Image = null;
            this.PassTextBox1.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.PassTextBox1.CustomButton.Name = "";
            this.PassTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextBox1.CustomButton.TabIndex = 1;
            this.PassTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PassTextBox1.CustomButton.UseSelectable = true;
            this.PassTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PassTextBox1.Lines = new string[0];
            this.PassTextBox1.Location = new System.Drawing.Point(359, 294);
            this.PassTextBox1.MaxLength = 32767;
            this.PassTextBox1.Name = "PassTextBox1";
            this.PassTextBox1.PasswordChar = '*';
            this.PassTextBox1.PromptText = "Password";
            this.PassTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextBox1.SelectedText = "";
            this.PassTextBox1.SelectionLength = 0;
            this.PassTextBox1.SelectionStart = 0;
            this.PassTextBox1.ShortcutsEnabled = false;
            this.PassTextBox1.ShowButton = true;
            this.PassTextBox1.Size = new System.Drawing.Size(179, 23);
            this.PassTextBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.PassTextBox1.TabIndex = 1;
            this.PassTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PassTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextBox1.UseSelectable = true;
            this.PassTextBox1.UseStyleColors = true;
            this.PassTextBox1.Visible = false;
            this.PassTextBox1.WaterMark = "Password";
            this.PassTextBox1.WaterMarkColor = System.Drawing.Color.Black;
            this.PassTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 425);
            this.ControlBox = false;
            this.Controls.Add(this.PassTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.GetaLink1);
            this.Controls.Add(this.UserTextBox1);
            this.Controls.Add(this.CreateLink1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLink CreateLink1;
        private MetroFramework.Controls.MetroTextBox UserTextBox1;
        private MetroFramework.Controls.MetroLink GetaLink1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label Welcome;
        private MetroFramework.Controls.MetroTextBox PassTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

