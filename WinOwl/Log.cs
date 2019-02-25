using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinOwl
{
    public static class Log
    {
        private static int ID = 0;
        private static string filename = null;

        #region File names
        public static string CreateFile = @"C:\Users\vishal\Desktop\CreateFileLog.xml";
        public static string RenameFile = @"C:\Users\vishal\Desktop\RenameFileLog.xml";
        public static string DeleteFile = @"C:\Users\vishal\Desktop\DeleteFileLog.xml";
        public static string ChangeFile = @"C:\Users\vishal\Desktop\ChangeFileLog.xml";
        public static string RecentFile = @"C:\Users\vishal\Desktop\RecentFileLog.xml";
        #endregion


   

        #region Log Methods
        public static void LogIt(EventType eventtype, string oldfilename,string newfilename) {

            if (eventtype == EventType.Create) filename = CreateFile;
            else if (eventtype == EventType.Rename) filename = RenameFile;
            else if (eventtype == EventType.Change) filename = ChangeFile;
            else if(EventType.Delete == eventtype) filename = DeleteFile;            
                try
                {
                    if (!File.Exists(filename))
                    {
                        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                        xmlWriterSettings.Indent = true;
                        xmlWriterSettings.NewLineOnAttributes = true;
                    
                        using (XmlWriter xmlWriter = XmlWriter.Create(filename, xmlWriterSettings))
                        {
                            xmlWriter.WriteStartDocument();
                            xmlWriter.WriteStartElement("Files");
                            xmlWriter.WriteStartElement("File");
                        xmlWriter.WriteAttributeString("ID",ID.ToString());
                        if (eventtype == EventType.Rename)
                            {
                            
                                xmlWriter.WriteElementString("Filename", oldfilename);
                                xmlWriter.WriteElementString("NewFilename", newfilename);
                        }
                        else
                            {
                                xmlWriter.WriteElementString("Filename", oldfilename);
                        }
                        xmlWriter.WriteElementString("DateTime", DateTime.Now.ToString());
                        xmlWriter.WriteElementString("Delete", true.ToString());
                        xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndDocument();
                            xmlWriter.Flush();
                            xmlWriter.Close();
                        }
                    }
                    else
                    {
                      
                        if (EventType.Rename == eventtype)
                        {
                        XDocument xDocument = XDocument.Load(RenameFile);
                         
                        XElement root = xDocument.Element("Files");
                            root.Add(
                               new XElement("File",
                               new XAttribute("ID",ID),
                               new XElement("Filename", oldfilename),
                               new XElement("NewFilename", newfilename),
                               new XElement("DateTime", DateTime.Now.ToString()),
                               new XElement("Delete", true)));
                               xDocument.Save(RenameFile);
                            //  xDocument = null;
                        }
                        else
                        {
                        XDocument xDocument = XDocument.Load(filename);
                         
                        XElement root = xDocument.Element("Files");
                            root.Add(
                               new XElement("File",
                               new XAttribute("ID", ID),
                               new XElement("Filename", oldfilename),
                               new XElement("DateTime", DateTime.Now.ToString()),
                               new XElement("Delete", true)));
                               xDocument.Save(filename);
                            // xDocument = null;
                        }


                    }
           
            if (!File.Exists(RecentFile))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(RecentFile, xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("AllFiles");
                        xmlWriter.WriteStartElement("File");
                        xmlWriter.WriteAttributeString("ID",ID.ToString());
                        xmlWriter.WriteElementString("OldFilename", oldfilename);
                        xmlWriter.WriteElementString("NewFilename", newfilename);
                        xmlWriter.WriteElementString("EventType", eventtype.ToString());
                        xmlWriter.WriteElementString("DateTime", DateTime.Now.ToString());
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                }
                else
                {
                    XDocument xDocument = XDocument.Load(RecentFile);
                    XElement root = xDocument.Element("AllFiles");
                  root.Add(
                       new XElement("File",
                       new XAttribute("ID",ID),
                       new XElement("OldFilename", oldfilename),
                       new XElement("NewFilename", newfilename),
                       new XElement("EventType", eventtype.ToString()),
                       new XElement("DateTime", DateTime.Now.ToString())));
                    xDocument.Save(RecentFile);
                    xDocument = null;
                }

                 filename = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Not Recent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filename = null; 
            }

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
                    catch (Exception exc) { MessageBox.Show(exc.Message, "REname Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                    catch (Exception exc) { MessageBox.Show(exc.Message, "CReate Eror", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            catch (Exception exc) { MessageBox.Show(exc.Message, "REsert error", MessageBoxButtons.OK, MessageBoxIcon.Error);return false; }


        }
        #endregion


        #region SaveFile method
        public static void Savefile()
        {
          
        }
        #endregion
    }
}
