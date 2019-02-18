using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinOwl
{
    public static class Log
    {
        private static string filename = null;

        #region File names
        public static string CreateFile = @"C:\Users\vishal\Desktop\CreateFileLog.tp";
        public static string RenameFile = @"C:\Users\vishal\Desktop\RenameFileLog.tp";
        public static string DeleteFile = @"C:\Users\vishal\Desktop\DeleteFileLog.tp";
        public static string ChangeFile = @"C:\Users\vishal\Desktop\ChangeFileLog.tp";
        public static string RecentFile = @"C:\Users\vishal\Desktop\RecentFileLog.tp";
        #endregion

        #region Program Filename 
        private static string ProgramFile = @"C:\Users\vishal\Desktop\ProgramFileLog.tp";
        #endregion

        #region Folder FIlename
        private static string FolderFile = @"C:\Users\vishal\Desktop\FolderFileLog.tp";
        #endregion

        #region Log Methods
        public static void LogIt(EventType eventtype, string message) {

            if (eventtype == EventType.Create) filename = CreateFile;
            else if (eventtype == EventType.Rename) filename = RenameFile;
            else if (eventtype == EventType.Change) filename = ChangeFile;
            else if (eventtype == EventType.Program) filename = ProgramFile;
            else if (eventtype == EventType.Folder) filename = FolderFile;
            else if(EventType.Delete == eventtype) filename = DeleteFile;

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(File.Open(filename, FileMode.OpenOrCreate | FileMode.Append)))
                {
                    streamWriter.WriteLine(message);
                }
                using (StreamWriter stream = new StreamWriter(File.Open(RecentFile, FileMode.OpenOrCreate | FileMode.Append)))
                {
                    stream.WriteLine(message);
                }
                filename = null;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); filename = null; }

        }

        public static void Renamereset() {
            if (File.Exists(RenameFile))
            {
                var lines = File.ReadAllLines(RenameFile);
                foreach (string line in lines)
                {
                    string[] array = line.Split(new char[] { '+','+' }, 3);
                    try
                    {
                        if (array[2] != null && array[2].Length > 0) { File.Delete(array[0]); }
                        else { File.Move(array[0], array[1]); }
                        

                    }
                    catch (Exception exc) { MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            File.Delete(RenameFile);
        }
        public static void clear()
        {
          //  if (File.Exists(CreateFile)) File.Delete(CreateFile);
          //  if (File.Exists(RenameFile)) File.Delete(RenameFile);
            if (File.Exists(ChangeFile)) File.Delete(ChangeFile);
            if (File.Exists(DeleteFile)) File.Delete(DeleteFile);
            if (File.Exists(RecentFile)) File.Delete(RecentFile);
        }

        public static void Createreset()
        {

            if (File.Exists(CreateFile))
            {
                var lines = File.ReadAllLines(CreateFile);
                foreach (var line in lines)
                {
                    try
                    {
                        if (File.Exists(line))
                        { File.Delete(line); }
                       // Console.WriteLine("delete success");
                    }
                    catch (Exception exc) { MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            File.Delete(CreateFile);
        }

        public static bool reset(){
            try
            {
                GeneralFileWatcher.GetInstance().Stop();
                FolderMonitor.GetInstance().EndMonitoring();
                ProgramWatcher.GetInstance().EndMonitoring();
                Renamereset();
                Createreset();
                clear();
                return true;
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return false; }


        }
        #endregion
    }
}
