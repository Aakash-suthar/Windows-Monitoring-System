using MetroFramework.Forms;
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
    public partial class LogForm : MetroForm
    {
        public static MetroForm LogForm1 = null;
        public LogForm()
        {
            LogForm1 = this;
                InitializeComponent();

            if (File.Exists(Log.CreateFile))
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.ReadXml(Log.CreateFile);
                CreateGrid.DataSource = dataSet1.Tables[0];
            }
            if (File.Exists(Log.RenameFile))
            {
                DataSet dataSet2 = new DataSet();
                dataSet2.ReadXml(Log.RenameFile);
                RenameGrid.DataSource = dataSet2.Tables[0];
            }
            if (File.Exists(Log.ChangeFile))
            {
                DataSet dataSet3 = new DataSet();
                dataSet3.ReadXml(Log.ChangeFile);
                ChangeGrid.DataSource = dataSet3.Tables[0];
            }
            if (File.Exists(Log.DeleteFile))
            {
                DataSet dataSet4 = new DataSet();
                dataSet4.ReadXml(Log.DeleteFile);
                DeleteGrid.DataSource = dataSet4.Tables[0];
            }
            if (File.Exists(Log.RecentFile))
            {
                DataSet dataSet5 = new DataSet();
                dataSet5.ReadXml(Log.RecentFile);
                RecentGrid.DataSource = dataSet5.Tables[0];
            }
            if (File.Exists(ProgramLog.ProgramFile))
            {
                DataSet dataSet6 = new DataSet();
                dataSet6.ReadXml(ProgramLog.ProgramFile);
                ProgramGrid.DataSource = dataSet6.Tables[0];
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Log.CreateFile))
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.ReadXml(Log.CreateFile);
                CreateGrid.DataSource = dataSet1.Tables[0];
            }
            if (File.Exists(Log.RenameFile))
            {
                DataSet dataSet2 = new DataSet();
                dataSet2.ReadXml(Log.RenameFile);
                RenameGrid.DataSource = dataSet2.Tables[0];
            }
            if (File.Exists(Log.ChangeFile))
            {
                DataSet dataSet3 = new DataSet();
                dataSet3.ReadXml(Log.ChangeFile);
                ChangeGrid.DataSource = dataSet3.Tables[0];
            }
            if (File.Exists(Log.DeleteFile))
            {
                DataSet dataSet4 = new DataSet();
                dataSet4.ReadXml(Log.DeleteFile);
                DeleteGrid.DataSource = dataSet4.Tables[0];
            }
            if (File.Exists(Log.RecentFile))
            {
                DataSet dataSet5 = new DataSet();
                dataSet5.ReadXml(Log.RecentFile);
                RecentGrid.DataSource = dataSet5.Tables[0];
            }
            if (File.Exists(ProgramLog.ProgramFile))
            {
                DataSet dataSet6 = new DataSet();
                dataSet6.ReadXml(ProgramLog.ProgramFile);
                ProgramGrid.DataSource = dataSet6.Tables[0];
            }
        }
    }
}
