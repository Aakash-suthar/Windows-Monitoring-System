namespace WinOwl
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.CreateTab = new System.Windows.Forms.TabPage();
            this.CreateGrid = new System.Windows.Forms.DataGridView();
            this.RenameTab = new MetroFramework.Controls.MetroTabPage();
            this.RenameGrid = new System.Windows.Forms.DataGridView();
            this.DeleteTab = new MetroFramework.Controls.MetroTabPage();
            this.DeleteGrid = new System.Windows.Forms.DataGridView();
            this.RecentTab = new System.Windows.Forms.TabPage();
            this.RecentGrid = new System.Windows.Forms.DataGridView();
            this.ChangeTab = new System.Windows.Forms.TabPage();
            this.ChangeGrid = new System.Windows.Forms.DataGridView();
            this.ProgramTab = new System.Windows.Forms.TabPage();
            this.ProgramGrid = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroTabControl1.SuspendLayout();
            this.CreateTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateGrid)).BeginInit();
            this.RenameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenameGrid)).BeginInit();
            this.DeleteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGrid)).BeginInit();
            this.RecentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentGrid)).BeginInit();
            this.ChangeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeGrid)).BeginInit();
            this.ProgramTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.CreateTab);
            this.metroTabControl1.Controls.Add(this.RenameTab);
            this.metroTabControl1.Controls.Add(this.DeleteTab);
            this.metroTabControl1.Controls.Add(this.RecentTab);
            this.metroTabControl1.Controls.Add(this.ChangeTab);
            this.metroTabControl1.Controls.Add(this.ProgramTab);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 21);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 5;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 408);
            this.metroTabControl1.TabIndex = 14;
            this.metroTabControl1.UseSelectable = true;
            // 
            // CreateTab
            // 
            this.CreateTab.Controls.Add(this.CreateGrid);
            this.CreateTab.Location = new System.Drawing.Point(4, 47);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Size = new System.Drawing.Size(746, 357);
            this.CreateTab.TabIndex = 3;
            this.CreateTab.Text = "CreateLog";
            // 
            // CreateGrid
            // 
            this.CreateGrid.AllowUserToAddRows = false;
            this.CreateGrid.AllowUserToDeleteRows = false;
            this.CreateGrid.AllowUserToOrderColumns = true;
            this.CreateGrid.AllowUserToResizeColumns = false;
            this.CreateGrid.AllowUserToResizeRows = false;
            this.CreateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CreateGrid.BackgroundColor = System.Drawing.Color.White;
            this.CreateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreateGrid.Location = new System.Drawing.Point(3, 0);
            this.CreateGrid.Name = "CreateGrid";
            this.CreateGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CreateGrid.Size = new System.Drawing.Size(743, 366);
            this.CreateGrid.TabIndex = 3;
            // 
            // RenameTab
            // 
            this.RenameTab.Controls.Add(this.RenameGrid);
            this.RenameTab.HorizontalScrollbarBarColor = true;
            this.RenameTab.HorizontalScrollbarHighlightOnWheel = false;
            this.RenameTab.HorizontalScrollbarSize = 10;
            this.RenameTab.Location = new System.Drawing.Point(4, 47);
            this.RenameTab.Name = "RenameTab";
            this.RenameTab.Size = new System.Drawing.Size(746, 357);
            this.RenameTab.TabIndex = 0;
            this.RenameTab.Text = "RenameLog";
            this.RenameTab.VerticalScrollbarBarColor = true;
            this.RenameTab.VerticalScrollbarHighlightOnWheel = false;
            this.RenameTab.VerticalScrollbarSize = 10;
            // 
            // RenameGrid
            // 
            this.RenameGrid.AllowUserToAddRows = false;
            this.RenameGrid.AllowUserToDeleteRows = false;
            this.RenameGrid.AllowUserToOrderColumns = true;
            this.RenameGrid.AllowUserToResizeColumns = false;
            this.RenameGrid.AllowUserToResizeRows = false;
            this.RenameGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RenameGrid.BackgroundColor = System.Drawing.Color.White;
            this.RenameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RenameGrid.Location = new System.Drawing.Point(3, 0);
            this.RenameGrid.Name = "RenameGrid";
            this.RenameGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RenameGrid.Size = new System.Drawing.Size(743, 366);
            this.RenameGrid.TabIndex = 2;
            // 
            // DeleteTab
            // 
            this.DeleteTab.Controls.Add(this.DeleteGrid);
            this.DeleteTab.HorizontalScrollbarBarColor = true;
            this.DeleteTab.HorizontalScrollbarHighlightOnWheel = false;
            this.DeleteTab.HorizontalScrollbarSize = 10;
            this.DeleteTab.Location = new System.Drawing.Point(4, 47);
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Size = new System.Drawing.Size(746, 357);
            this.DeleteTab.TabIndex = 1;
            this.DeleteTab.Text = "DeleteLog";
            this.DeleteTab.VerticalScrollbarBarColor = true;
            this.DeleteTab.VerticalScrollbarHighlightOnWheel = false;
            this.DeleteTab.VerticalScrollbarSize = 10;
            // 
            // DeleteGrid
            // 
            this.DeleteGrid.AllowUserToAddRows = false;
            this.DeleteGrid.AllowUserToDeleteRows = false;
            this.DeleteGrid.AllowUserToOrderColumns = true;
            this.DeleteGrid.AllowUserToResizeColumns = false;
            this.DeleteGrid.AllowUserToResizeRows = false;
            this.DeleteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeleteGrid.BackgroundColor = System.Drawing.Color.White;
            this.DeleteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteGrid.Location = new System.Drawing.Point(3, 0);
            this.DeleteGrid.Name = "DeleteGrid";
            this.DeleteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DeleteGrid.Size = new System.Drawing.Size(743, 366);
            this.DeleteGrid.TabIndex = 2;
            // 
            // RecentTab
            // 
            this.RecentTab.Controls.Add(this.RecentGrid);
            this.RecentTab.Location = new System.Drawing.Point(4, 47);
            this.RecentTab.Name = "RecentTab";
            this.RecentTab.Size = new System.Drawing.Size(746, 357);
            this.RecentTab.TabIndex = 2;
            this.RecentTab.Text = "RecentLog";
            // 
            // RecentGrid
            // 
            this.RecentGrid.AllowUserToAddRows = false;
            this.RecentGrid.AllowUserToDeleteRows = false;
            this.RecentGrid.AllowUserToResizeColumns = false;
            this.RecentGrid.AllowUserToResizeRows = false;
            this.RecentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecentGrid.BackgroundColor = System.Drawing.Color.White;
            this.RecentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecentGrid.GridColor = System.Drawing.Color.White;
            this.RecentGrid.Location = new System.Drawing.Point(3, 0);
            this.RecentGrid.Name = "RecentGrid";
            this.RecentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RecentGrid.Size = new System.Drawing.Size(743, 361);
            this.RecentGrid.TabIndex = 3;
            // 
            // ChangeTab
            // 
            this.ChangeTab.Controls.Add(this.ChangeGrid);
            this.ChangeTab.Location = new System.Drawing.Point(4, 47);
            this.ChangeTab.Name = "ChangeTab";
            this.ChangeTab.Size = new System.Drawing.Size(746, 357);
            this.ChangeTab.TabIndex = 4;
            this.ChangeTab.Text = "ChangeLog";
            // 
            // ChangeGrid
            // 
            this.ChangeGrid.AllowUserToAddRows = false;
            this.ChangeGrid.AllowUserToDeleteRows = false;
            this.ChangeGrid.AllowUserToOrderColumns = true;
            this.ChangeGrid.AllowUserToResizeColumns = false;
            this.ChangeGrid.AllowUserToResizeRows = false;
            this.ChangeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChangeGrid.BackgroundColor = System.Drawing.Color.White;
            this.ChangeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChangeGrid.Location = new System.Drawing.Point(3, 0);
            this.ChangeGrid.Name = "ChangeGrid";
            this.ChangeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ChangeGrid.Size = new System.Drawing.Size(743, 366);
            this.ChangeGrid.TabIndex = 3;
            // 
            // ProgramTab
            // 
            this.ProgramTab.Controls.Add(this.ProgramGrid);
            this.ProgramTab.Location = new System.Drawing.Point(4, 47);
            this.ProgramTab.Name = "ProgramTab";
            this.ProgramTab.Size = new System.Drawing.Size(746, 357);
            this.ProgramTab.TabIndex = 5;
            this.ProgramTab.Text = "ProgramLog";
            // 
            // ProgramGrid
            // 
            this.ProgramGrid.AllowUserToAddRows = false;
            this.ProgramGrid.AllowUserToDeleteRows = false;
            this.ProgramGrid.AllowUserToOrderColumns = true;
            this.ProgramGrid.AllowUserToResizeColumns = false;
            this.ProgramGrid.AllowUserToResizeRows = false;
            this.ProgramGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProgramGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProgramGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramGrid.Location = new System.Drawing.Point(3, 0);
            this.ProgramGrid.Name = "ProgramGrid";
            this.ProgramGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProgramGrid.Size = new System.Drawing.Size(743, 366);
            this.ProgramGrid.TabIndex = 4;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(310, 450);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(122, 48);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LogForm";
            this.ShowInTaskbar = false;
            this.metroTabControl1.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateGrid)).EndInit();
            this.RenameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RenameGrid)).EndInit();
            this.DeleteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteGrid)).EndInit();
            this.RecentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecentGrid)).EndInit();
            this.ChangeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeGrid)).EndInit();
            this.ProgramTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage CreateTab;
        private System.Windows.Forms.DataGridView CreateGrid;
        private MetroFramework.Controls.MetroTabPage RenameTab;
        private System.Windows.Forms.DataGridView RenameGrid;
        private MetroFramework.Controls.MetroTabPage DeleteTab;
        private System.Windows.Forms.DataGridView DeleteGrid;
        private System.Windows.Forms.TabPage RecentTab;
        private System.Windows.Forms.DataGridView RecentGrid;
        private System.Windows.Forms.TabPage ChangeTab;
        private System.Windows.Forms.DataGridView ChangeGrid;
        private System.Windows.Forms.TabPage ProgramTab;
        private System.Windows.Forms.DataGridView ProgramGrid;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}