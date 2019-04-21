using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinOwl
{
    public partial class Save : MetroForm
    {
        private List<string> checkrows;
        public Save()
        {
            InitializeComponent();
            if (File.Exists(Log.CreateFile))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Log.CreateFile);
                CreateGrid.DataSource = dataSet.Tables[0];
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Save";
                dgvCmb.HeaderText = "SaveFile";
                CreateGrid.Columns.Add(dgvCmb);
            }
            if (File.Exists(Log.RenameFile))
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.ReadXml(Log.RenameFile);
                RenameGrid.DataSource = dataSet1.Tables[0];
                DataGridViewCheckBoxColumn dgvCmb1 = new DataGridViewCheckBoxColumn();
                dgvCmb1.ValueType = typeof(bool);
                dgvCmb1.Name = "Save";
                dgvCmb1.HeaderText = "SaveFile";
                RenameGrid.Columns.Add(dgvCmb1);
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var checkedRows = from DataGridViewRow r in RenameGrid.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select r;
            var checkedRows1 = from DataGridViewRow r in CreateGrid.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select r;

            if (File.Exists(Log.RenameFile))
            {
                XDocument x = new XDocument();
                x = XDocument.Load(Log.RenameFile);
                foreach (var row in checkedRows)
                {
                    x.Descendants("File").Where(p => p.Attribute("ID").Value == (row.Cells["ID"].Value.ToString())).FirstOrDefault().Remove();

                }
                x.Save(Log.RenameFile);
            }
            if (File.Exists(Log.CreateFile))
            {
                XDocument x1 = new XDocument();
                x1 = XDocument.Load(Log.CreateFile);
                foreach (var row in checkedRows1)
                {
                    x1.Descendants("File").Where(p => p.Attribute("ID").Value == (row.Cells["ID"].Value.ToString())).FirstOrDefault().Remove();

                }
                x1.Save(Log.CreateFile);
            }            
           
           

            for (int i = RenameGrid.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)RenameGrid.Rows[i].Cells[0].FormattedValue)
                {
                    RenameGrid.Rows.RemoveAt(i);
                }
            }
            for (int i = CreateGrid.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)CreateGrid.Rows[i].Cells[0].FormattedValue)
                {
                    CreateGrid.Rows.RemoveAt(i);
                }
            }
        }
    }
}
