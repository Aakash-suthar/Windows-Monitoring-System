using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinOwl
{
    public static class FolderLog
    {

        #region Folder FIlename
        public static string FolderFile = @"C:\Users\vishal\Desktop\FolderFileLog.log";
        #endregion
        public static void LogIt(string Foldername)
        {
            try
            {
                //if (!File.Exists(FolderFile))
                //{
                //    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                //    xmlWriterSettings.Indent = true;
                //    xmlWriterSettings.NewLineOnAttributes = true;
                //    using (XmlWriter xmlWriter = XmlWriter.Create(FolderFile, xmlWriterSettings))
                //    {
                //        xmlWriter.WriteStartDocument();
                //        xmlWriter.WriteStartElement("Folders");
                //        xmlWriter.WriteStartElement("Folder");
                //        xmlWriter.WriteElementString("Foldername", Foldername);
                //        xmlWriter.WriteEndElement();
                //        xmlWriter.WriteEndElement();
                //        xmlWriter.WriteEndDocument();
                //        xmlWriter.Flush();
                //        xmlWriter.Close();
                //    }
                //}
                //else
                //{
                //    XDocument xDocument = XDocument.Load(FolderFile);
                //    XElement root = xDocument.Element("Folders");
                //    root.Add(
                //            new XElement("Folder",
                //            new XElement("Foldername", Foldername),
                //            new XElement("DateTime", DateTime.Now.ToString())));
                //    xDocument.Save(FolderFile);
                //    xDocument = null;
                //}
                using (StreamWriter s = new StreamWriter(new FileStream(FolderFile, FileMode.Append, FileAccess.Write)))
                {
                    s.WriteLine(FolderFile + " " + DateTime.Now.ToString());
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Folder Error"); }
        }
    }
}
