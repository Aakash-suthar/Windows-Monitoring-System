using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        private static bool newcreate = false;
        private static string key2 = "HR$2pIjHR$2pIj12sef";
        private static SymmetricAlgorithm obj2;



        #region File names
        public static string CreateFile = @"C:\Users\vishal\Desktop\CreateFileLog.xml";
        public static string RenameFile = @"C:\Users\vishal\Desktop\RenameFileLog.xml";
        public static string DeleteFile = @"C:\Users\vishal\Desktop\DeleteFileLog.xml";
        public static string ChangeFile = @"C:\Users\vishal\Desktop\ChangeFileLog.xml";
        public static string RecentFile = @"C:\Users\vishal\Desktop\RecentFileLog.xml";
        #endregion


        #region Log Methods
        public static void LogIt(EventType eventtype, string oldfilename,string newfilename) {
            try
            {
                if (EventType.Create == eventtype)
                {
                    filename = CreateFile;
                    if (oldfilename.IndexOf("new", StringComparison.OrdinalIgnoreCase) > 0) goto Next;
                }
                else if (eventtype == EventType.Rename)
                {
                    if (oldfilename.IndexOf("new", StringComparison.OrdinalIgnoreCase) > 0) { filename = CreateFile; eventtype = EventType.Create; newcreate = true; }
                    else filename = RenameFile;
                }
                else if (eventtype == EventType.Change)
                {
                filename = ChangeFile;
                if (oldfilename.IndexOf("new", StringComparison.OrdinalIgnoreCase) > 0) goto Next;
              
                }
                else if (EventType.Delete == eventtype) filename = DeleteFile;

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
                        else if(newcreate)
                            {
                                xmlWriter.WriteElementString("Filename", newfilename); newcreate = false;
                        }
                        else
                        {
                            xmlWriter.WriteElementString("Filename", oldfilename);
                        }
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
                      
                        if (EventType.Rename == eventtype)
                        {
                        XDocument xDocument = XDocument.Load(RenameFile);
                         
                        XElement root = xDocument.Element("Files");
                        root.Add(
                           new XElement("File",
                           new XAttribute("ID", ID),
                           new XElement("Filename", oldfilename),
                           new XElement("NewFilename", newfilename),
                           new XElement("DateTime", DateTime.Now.ToString())));
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
                               new XElement("DateTime", DateTime.Now.ToString())));
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
                Next:
                ID++;
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
                XmlDocument doc = new XmlDocument();
                doc.Load(RenameFile);
                XmlNodeList fromselectors;
                XmlElement root = doc.DocumentElement;
                fromselectors = root.SelectNodes("File");
                foreach (XmlNode n in fromselectors)
                {
                    if (File.Exists(n["NewFilename"].InnerText.ToString()))
                    {
                        //n["Filename"].InnerText.ToString();
                        File.Move(n["NewFilename"].InnerText.ToString(),n["Filename"].InnerText.ToString());
                    }
                }
            }
                File.Delete(RenameFile);
        }
        public static void clear()
        {
            if (File.Exists(ChangeFile)) File.Delete(ChangeFile);
            if (File.Exists(DeleteFile)) File.Delete(DeleteFile);
            if (File.Exists(RecentFile)) File.Delete(RecentFile);
        }

        public static void Createreset()
        {
            if (File.Exists(CreateFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(CreateFile);
                XmlNodeList fromselectors;
                XmlElement root = doc.DocumentElement;
                fromselectors = root.SelectNodes("File/Filename");

                foreach (XmlNode n in fromselectors)
                {

                    try
                    {
                        if (File.Exists(n.InnerXml.ToString()))
                        { File.Delete(n.InnerXml.ToString()); }
                    }
                    catch (Exception exc) { MessageBox.Show(exc.Message, "Delete Eror", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                File.Delete(CreateFile);
            }
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
      
        #endregion
    }
}
