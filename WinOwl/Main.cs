using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOwl
{
    public partial class Main : Form
    {
        private bool mouseDown,lb=false,about=false;
        private Point lastLocation;
        private int panelwidth=280;
        public static Form MainForm=null;

        public Main()
        {
            MainForm = this; 
            InitializeComponent();
          //  SystemEvents.SessionEnding += SessionEndingEvtHandler;
        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AnimateButton_Click(object sender, EventArgs e)
        {
            if (SlidePanel.Width==0)
            {
                SlidePanel.Visible = true;
                SlidePanel.Width = panelwidth;
              //  bunifuTransition1.ShowSync(SlidePanel);  
            }
            else {
                //SlidePanel.Visible = false; 
                //SlidePanel.Width = 0;
                SlidePanel.Width = 0;
               // bunifuFormFadeTransition1.ShowAsyc(SlidePanel);
                SlidePanel.Visible = false;

            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            StartButton.Text = "START";
            StartButton.Enabled = true;

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            GetCheckedNodes(treeView1.Nodes);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Log.reset();
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            lb = true;
            SlidePanel.Width = 0;
            Hide();
            Login.Form1Instance.Show();
        }

        private void disable(bool f) {
            StartButton.Enabled = StopButton.Enabled = f;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!notifyIcon1.Visible && (!lb) && (!about))
            {
                e.Cancel = true;
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Log.CreateFile = path + @"\CreateFileLog.xml";
                Log.RenameFile = path + @"\RenameFileLog.xml";
                Log.DeleteFile = path + @"\DeleteFileLog.xml";
                Log.ChangeFile = path + @"\ChangeFileLog.xml";
                Log.RecentFile = path + @"\RecentFileLog.xml";
                ProgramLog.ProgramFile = path + @"\ProgramFileLog.xml";
                FolderLog.FolderFile = path + @"\FolderFileLog.xml";
                Console.WriteLine(Log.CreateFile+Log.RenameFile+Log.DeleteFile+Log.RecentFile);
            }
            catch(Exception exc) { MessageBox.Show(exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = treeView1.Nodes.Add(drive);
                item.Tag = drive;
                item.Nodes.Add("");
                treeView1.AfterExpand += TreeView1_AfterExpand;
                treeView1.AfterCheck += node_AfterCheck;
            }
        }

        private void TreeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count != 1 && e.Node.Nodes[1] != null)
                return;
           
                e.Node.Nodes.Clear();
                foreach (var drive in Directory.GetDirectories(e.Node.Tag.ToString()))
                {

                    var item = e.Node.Nodes.Add(drive);
                    item.Tag = drive;
                    item.Checked = e.Node.Checked;
                    item.Text = getfilefolder(drive);
                    item.Nodes.Add("");
                }
                foreach (var drive in Directory.GetFiles(e.Node.Tag.ToString()))
                {
                    
                    var file = e.Node.Nodes.Add(getfilefolder(drive));
                    file.Checked = e.Node.Checked;
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!notifyIcon1.Visible)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            FileButton.Text = "MONITORING"; GeneralFileWatcher.GetInstance().Start();FileButton.Enabled = false;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
             FolderButton.Text = "MONITORING"; FolderMonitor.GetInstance().StartMonitoring(); FolderButton.Enabled = false;
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
           ProgramButton.Text = "MONITORING"; ProgramWatcher.GetInstance().StartMonitoring(); ProgramButton.Enabled = false;

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Width = 0;
            if (Log.reset())
            {
                if(MessageBox.Show("Successfully deleted", "INFO", MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Login.Form1Instance.Dispose();
                }
            }
            else { MessageBox.Show("Error in reseting..", "ALert", MessageBoxButtons.OK, MessageBoxIcon.Error);Login.Form1Instance.Dispose(); }
        }
        //private void SessionEndingEvtHandler(object sender, SessionEndingEventArgs e)
        //{
        //    MessageBox.Show("Cancelling Windows shutdown");
        //    string cmd = "shutdown /a";
        //    Process.Start(cmd);// for executing system command.


        //}


        #region Copied files
        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    foreach (var drive in Directory.GetLogicalDrives())
        //    {
        //        var item = new TreeViewItem()
        //        {
        //            Header = drive,
        //            Tag = drive
        //        };


        //        item.Items.Add(null);

        //        item.Expanded += Folder_Expanded;


        //        FolderView.Items.Add(item);
        //    }
        //}

        //public void Folder_Expanded(object sender, RoutedEventArgs e)
        //{
        //    var item = (TreeViewItem)sender;
        //    if (item.Items.Count != 1 && item.Items[1] != null)
        //        return;

        //    item.Items.Clear();

        //    var fullpath = item.Tag.ToString();
        //    var directiores = new List<string>();
        //    try
        //    {
        //        var dirs = Directory.GetDirectories(fullpath);
        //        if (dirs.Length > 0)
        //        {

        //            directiores.AddRange(dirs);
        //        }
        //    }
        //    catch { }
        //    directiores.ForEach(directypath =>
        //    {
        //        var subitem = new TreeViewItem()
        //        {
        //            Header = getfilefolder(directypath),
        //            Tag = directypath
        //        };
        //        subitem.Items.Add(null);
        //        subitem.Expanded += Folder_Expanded;

        //        item.Items.Add(subitem);
        //    });

        //    var file = new List<string>();
        //    try
        //    {
        //        var f = Directory.GetFiles(fullpath);
        //        if (f.Length > 0)
        //        {

        //            directiores.AddRange(f);
        //        }
        //    }
        //    catch { }
        //    directiores.ForEach(filepath =>
        //    {
        //        var subitem = new TreeViewItem()
        //        {
        //            Header = getfilefolder(filepath),
        //            Tag = filepath
        //        };

        //        item.Items.Add(subitem);
        //    });

        //}

        public static string getfilefolder(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;

            }
            var normal = path.Replace('/', '\\');

            var lastindex = normal.LastIndexOf('\\');

            if (lastindex <= 0)
            {
                return path;
            }

            return path.Substring(lastindex + 1);
        }
        #endregion

        public void GetCheckedNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked)
                    Console.WriteLine(aNode.Text);

                if (aNode.Nodes.Count != 0)
                    GetCheckedNodes(aNode.Nodes);
            }
        }

        private void SavefileButton_Click(object sender, EventArgs e)
        {
            if (Save.SaveForm == null)
            {
                Save s = new Save();
                s.Show();
            }
            else { Save.SaveForm.Show(); }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (LogForm.LogForm1 == null)
            {
                LogForm l = new LogForm();
                l.Show();
            }
            else LogForm.LogForm1.Show();
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        // NOTE   This code can be added to the BeforeCheck event handler instead of the AfterCheck event.
        // After a tree node's Checked property is changed, all its child nodes are updated to the same value.
        private void node_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == false) e.Node.Parent.Checked = false;
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
    }
}
