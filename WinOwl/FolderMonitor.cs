using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ActivityMonitoring;
using WinOwl.Network;

namespace WinOwl
{
    /// <summary>
    /// Folder monitor.
    /// </summary>
    public class FolderMonitor 
        //: IResourceMonitor
    {
        public const String FOLDER_CREATE = "CREATE";
        public const String FOLDER_RENAME = "RENAME";
        public const String FOLDER_DELETION = "DELETION";
        public const String FOLDER_VIEW = "VIEW";
        static List<FileSystemWatcher> listofwatcherfolder = new List<FileSystemWatcher>();

        private static FolderMonitor instance = new FolderMonitor();
        private static  FileSystemWatcher watcher = new FileSystemWatcher();


        private FolderMonitor() { }

        /// <summary>
        /// Singleton implementation.
        /// </summary>
        /// <returns>the instance</returns>
        public static FolderMonitor GetInstance()
        {
            return instance;
        }

        public void StartMonitoring()
        {
            Watch();
            FolderWatcher.GetInstance().Start();
        }

        /// <summary>
        /// Helper method to run the FSW (FileSystemWatcher) functionality.
        /// </summary>
        private void Watch()
        {
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {

                if (d.DriveType != DriveType.Unknown && d.DriveType != DriveType.CDRom && d.DriveType != DriveType.Removable && d.Name != @"C:\")
                {
                    //        //Console.WriteLine(d.Name);
                    FileSystemWatcher f = new FileSystemWatcher();


                    // string[] drive = Directory.GetLogicalDrives();
                    //  Console.WriteLine(drive[0]);
                    //  f.Path = Directory.GetDirectoryRoot(d.Name); //start from the root (Top - Down)
                    //  Console.WriteLine(watcher.Path);
                    //f.IncludeSubdirectories = true;   //recurse watch
                    //f.EnableRaisingEvents = true;     //allow events to be notified..

                    //f.NotifyFilter = NotifyFilters.DirectoryName;
                    //f.Filter = "*.*";                 //watch every type of file..


                    //f.Created += new FileSystemEventHandler(watcher_Created);
                    ////watcher.Changed += new FileSystemEventHandler(watcher_Changed);
                    //f.Deleted += new FileSystemEventHandler(watcher_Deleted);
                    //f.Renamed += new RenamedEventHandler(watcher_Renamed);

                    f.Path = Directory.GetDirectoryRoot(d.Name); //start from the root (Top - Down)

                    f.IncludeSubdirectories = true;   //recurse watch
                    f.EnableRaisingEvents = true;     //allow events to be notified..

                    f.Filter = "*.*";                 //watch every type of file..
                     f.Created += new FileSystemEventHandler(watcher_Created);
                     f.Renamed += new RenamedEventHandler(watcher_Renamed);
                     f.Deleted += new FileSystemEventHandler(watcher_Deleted);
                    listofwatcherfolder.Add(f);
                }
            }
        }

        /// <summary>
        /// Event handler to handle folder renamed.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private void watcher_Renamed(object sender, RenamedEventArgs e)
        {

            String message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.Name + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.FullPath + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 FOLDER_RENAME + Constants.SPACE + Constants.SPLITTER + Constants.SPACE + //still need old name/path
                                 DateTime.Now;
            message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + FOLDER_RENAME + Constants.SPACE + "Name " + e.Name + "Path " + e.FullPath;

            Console.WriteLine(message);

            //EventSender.GetInstance().ProcessMessage(message);
        }

        /// <summary>
        /// Event handler to handle folder deletion.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            String message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.Name + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.FullPath + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 FOLDER_DELETION + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 DateTime.Now;
            message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + FOLDER_DELETION + Constants.SPACE + "Name " + e.Name + "Path " + e.FullPath;

            Console.WriteLine(message);

            //EventSender.GetInstance().ProcessMessage(message);
        }

        /// <summary>
        /// Event handler to handle folder created.
        /// </summary>
        /// <param name="sender">triggered source</param>
        /// <param name="e">event arguments</param>
        private void watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (Directory.Exists(e.FullPath))
            {
                String message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.Name + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 e.FullPath + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 FOLDER_CREATE + Constants.SPACE + Constants.SPLITTER + Constants.SPACE +
                                 DateTime.Now;

                message = ResourceIdentifiers.FOLDER_IDENTIFIER + Constants.SPACE + FOLDER_CREATE + Constants.SPACE + "Name " + e.Name + "Path " + e.FullPath;

                Console.WriteLine(message);

                //EventSender.GetInstance().ProcessMessage(message);
            }

        }

        #region IResourceMonitor Members


        public void EndMonitoring()
        {
            if (listofwatcherfolder.Count > 0)
            {
                foreach (FileSystemWatcher f in listofwatcherfolder)
                {
                    f.EnableRaisingEvents = false;
                    f.Dispose();
                }
                listofwatcherfolder.Clear();
            }
        }

        #endregion
    }
}
