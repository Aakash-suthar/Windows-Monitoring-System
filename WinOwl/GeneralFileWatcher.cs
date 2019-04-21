
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinOwl
{
    /// <summary>
    /// Generally used to watch files for changes.
    /// </summary>
    public class GeneralFileWatcher
    {
        #region Private members

        private static string[] extension = { ".txt",".doc",".docx",".html",".bmp",".cs",".pdf",".wav",".mkv",".mp4",".mp3",".jpeg",".jpg",".png",".xlsx",".xls",".php" };
        private static GeneralFileWatcher _instance = new GeneralFileWatcher();
        static List<FileSystemWatcher> listofwatcher = new List<FileSystemWatcher>();
        
        #endregion

        #region Constructor
        private GeneralFileWatcher() { }
        #endregion

        /// <summary>
        /// Singleton implementation
        /// </summary>
        /// <returns>this class's instance</returns>
        public static GeneralFileWatcher GetInstance()
        {
            return _instance;
        }

        public void Start()
        {
            Watch();
        }

        #region Watch method
        /// <summary>
        /// Helper to utilise the FSW (FileSystemWatcher).
        /// </summary>
        private void Watch()
        {
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                //Console.WriteLine(d.Name);
                if (d.DriveType != DriveType.Unknown && d.DriveType != DriveType.CDRom && d.DriveType != DriveType.Removable && d.Name!=@"C:\")
                {
                    FileSystemWatcher f = new FileSystemWatcher();
                    //        Console.WriteLine(d.Name);
                    //for (int j =0; j <= Drivecount; j++) {
                    // string[] i = Directory.GetLogicalDrives();
                    // Console.WriteLine(i[2]);
                    f.Path = Directory.GetDirectoryRoot(d.Name); //start from the root (Top - Down)

                f.IncludeSubdirectories = true;   //recurse watch
                f.EnableRaisingEvents = true;     //allow events to be notified..

                f.Filter = "*.*";                 //watch every type of file..
                 f.Created += new FileSystemEventHandler(watcher_Created);
                 f.Renamed += new RenamedEventHandler(watcher_Renamed);
                 f.Deleted += new FileSystemEventHandler(watcher_Deleted);
                 f.Changed += new FileSystemEventHandler(watcher_Changed);
                    listofwatcher.Add(f);
                }
            }
            //}

        }
        #endregion

        #region All events

        /// <summary>
        /// Event handler to handle file changed.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (!(e.FullPath.Contains("RECYCLE")))
            {
                string ext = Path.GetExtension(e.FullPath);
                if (extension.Any(ext.Equals))
                    Log.LogIt(EventType.Change, e.FullPath, "");
            }

        }

        /// <summary>
        /// Event handler to handle file deleted.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!(e.FullPath.Contains("RECYCLE")))
            {
                string ext = Path.GetExtension(e.FullPath);
                if (extension.Any(ext.Equals))  Log.LogIt(EventType.Delete, e.FullPath, "");
            }

        }

        /// <summary>
        /// Event handler to handle file renamed.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (!(e.FullPath.Contains("RECYCLE")))
            {
                string ext = Path.GetExtension(e.FullPath);
                if (extension.Any(ext.Equals)) Log.LogIt(EventType.Rename, e.OldFullPath, e.FullPath);
            }

        }

        /// <summary>
        /// Event handler to handle file created.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (!(e.FullPath.Contains("RECYCLE")))
            {
                string ext = Path.GetExtension(e.FullPath);
                if (extension.Any(ext.Equals)) Log.LogIt(EventType.Create, e.FullPath, "");
            }

        }
        #endregion

        #region Stop all services method
        public void Stop()
        {
            if (listofwatcher.Count > 0)
            {
                foreach (FileSystemWatcher f in listofwatcher)
                {
                    f.EnableRaisingEvents = false;
                    f.Dispose();
                }
                listofwatcher.Clear();
            }
            MessageBox.Show("All services are stop monitoring.","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion
    }
}
