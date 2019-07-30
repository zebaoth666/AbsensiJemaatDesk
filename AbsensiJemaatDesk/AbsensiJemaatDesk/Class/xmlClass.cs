using System;
using System.IO;
using System.Xml;
using System.Configuration;

namespace AbsensiJemaatDesk
{
    public class xmlClass 
    {
        public static Boolean detectXml() {
            Boolean ada = false;

            if (File.Exists(Directory.GetCurrentDirectory() + @"\config.xml")){
                ada = true;
            }
            else
            {
                ada = false;
            }
            
            return ada; 
        }

        public static void createXml(string server, string port, string user, string pass, string db) {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = new XmlTextWriter(sw);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();
            tw.WriteStartElement("Connection");
            tw.WriteElementString("Server", server);
            tw.WriteElementString("Port", port);
            tw.WriteElementString("User", user);
            tw.WriteElementString("Password", pass);
            tw.WriteElementString("Database", db);
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Close();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sw.ToString());

            doc.Save(Directory.GetCurrentDirectory() + @"\config.xml");
        }

        public static void readXml() {
            XmlTextReader tr = new XmlTextReader(Directory.GetCurrentDirectory() + @"\config.xml");
            while (tr.Read())
            {
                switch (tr.Name) { 
                    case "Server":
                        AbsensiJemaatDesk.Properties.Settings.Default.server = tr.ReadString();
                        break;
                    case "Port":
                        AbsensiJemaatDesk.Properties.Settings.Default.port = tr.ReadString();
                        break;
                    case "User":
                        AbsensiJemaatDesk.Properties.Settings.Default.user = tr.ReadString();
                        break;
                    case "Password":
                        AbsensiJemaatDesk.Properties.Settings.Default.password = tr.ReadString();
                        break;
                    case "Database":
                        AbsensiJemaatDesk.Properties.Settings.Default.db = tr.ReadString();
                        break;
                    default:
                        break;
                }
            }

            AbsensiJemaatDesk.Properties.Settings.Default.conStr = "server=" + AbsensiJemaatDesk.Properties.Settings.Default.server +
                                                                "; port=" + AbsensiJemaatDesk.Properties.Settings.Default.port +
                                                                "; user=" + AbsensiJemaatDesk.Properties.Settings.Default.user +
                                                                "; password=" + AbsensiJemaatDesk.Properties.Settings.Default.password +
                                                                "; database=" + AbsensiJemaatDesk.Properties.Settings.Default.db + ";";
            tr.Close();
        }
    }
}