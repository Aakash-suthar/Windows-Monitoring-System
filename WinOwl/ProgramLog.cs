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
    public static class ProgramLog
    {

        #region Program Filename 
        public static string ProgramFile = @"C:\Users\vishal\Desktop\ProgramFileLog.xml";
        #endregion

        public static void LogIt(string Programname)
        {
            try
            {
                if (!File.Exists(ProgramFile))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(ProgramFile, xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("Programs");
                        xmlWriter.WriteStartElement("Program");
                        xmlWriter.WriteElementString("Programname", Programname);
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
                    XDocument xDocument = XDocument.Load(ProgramFile);
                    XElement root = xDocument.Element("Programs");
                    root.Add(
                        new XElement("Program",
                        new XElement("Programname", Programname),
                        new XElement("DateTime", DateTime.Now.ToString())));
                    xDocument.Save(ProgramFile);
                    //xDocument = null;
                }
                //using(StreamWriter s =new StreamWriter(new FileStream(ProgramFile,FileMode.Append,FileAccess.Write)))
                //{
                //    s.WriteLine(Programname+" "+DateTime.Now.ToString());
                //}

            }
            catch (Exception e) { MessageBox.Show(e.Message, "Program Error"); }
        }
    }
}
