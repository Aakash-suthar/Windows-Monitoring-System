using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinOwl
{
    public partial class Save : MetroForm
    {
        public static MetroForm SaveForm = null;
        public Save()
        {
            SaveForm = this;
            InitializeComponent();
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Save";
            dgvCmb.HeaderText = "SaveFile";
            dataGridView1.Columns.Add(dgvCmb);

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Log.RenameFile);
            dataGridView1.DataSource = dataSet.Tables[0];
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Log.DeleteFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Save";
            dgvCmb.HeaderText = "SaveFile";
            dataGridView1.Columns.Add(dgvCmb);

        }
    }
}
