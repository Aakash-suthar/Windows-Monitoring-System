namespace WinOwl
{
    partial class Save
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.RenameTab = new MetroFramework.Controls.MetroTabPage();
            this.RenameGrid = new System.Windows.Forms.DataGridView();
            this.CreateTab = new MetroFramework.Controls.MetroTabPage();
            this.CreateGrid = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.RenameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenameGrid)).BeginInit();
            this.CreateTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.RenameTab);
            this.metroTabControl1.Controls.Add(this.CreateTab);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 28);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 408);
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.UseSelectable = true;
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
            this.RenameTab.Text = "Rename";
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
            // CreateTab
            // 
            this.CreateTab.Controls.Add(this.CreateGrid);
            this.CreateTab.HorizontalScrollbarBarColor = true;
            this.CreateTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CreateTab.HorizontalScrollbarSize = 10;
            this.CreateTab.Location = new System.Drawing.Point(4, 47);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Size = new System.Drawing.Size(746, 357);
            this.CreateTab.TabIndex = 1;
            this.CreateTab.Text = "Create";
            this.CreateTab.VerticalScrollbarBarColor = true;
            this.CreateTab.VerticalScrollbarHighlightOnWheel = false;
            this.CreateTab.VerticalScrollbarSize = 10;
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
            this.CreateGrid.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(371, 454);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 37);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 514);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Save";
            this.ShowInTaskbar = false;
            this.metroTabControl1.ResumeLayout(false);
            this.RenameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RenameGrid)).EndInit();
            this.CreateTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage RenameTab;
        private MetroFramework.Controls.MetroTabPage CreateTab;
        private System.Windows.Forms.DataGridView RenameGrid;
        private System.Windows.Forms.DataGridView CreateGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}