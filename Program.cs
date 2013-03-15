using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SimpleWebBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
   }
    public class XmlAccess
    {
        /**This Method is used to set a new homepage in SimpleXml.xml file, it take String 
            parameter that represents the homepage to be sent*/
        public void setnewhomepage(String homepage)
        {
            XDocument data = loadXmlData();
            data.Descendants("home").First().SetElementValue("url", homepage.Trim());
            data.Save("SimpleXml.xml");
        }

        /**This method is used to add a favourite to the xml file it takes a parameter of the Name of
            the favourite and the url of the favourite*/
        public void addfavourites(String Name, String Url)
        {
            XDocument data = loadXmlData();
            data.Descendants("favourites").Last().Add(new XElement("favourite",
                                                              new XElement("name", Name),
                                                              new XElement("url", Url)));
            data.Save("SimpleXml.xml");
        }


        /**This method Load the Date from the Xml File*/
        public XDocument loadXmlData()
        {
            XDocument home = XDocument.Load("SimpleXml.xml");
            return home;
        }

        /**This method creates a new history entry into the Xml file*/
        public void newhistory(XDocument data,String addressvalue) {
            DateTime time = DateTime.Now;
            DateTime today = DateTime.Today;
            String date = time.TimeOfDay.ToString() + " " + time.Day.ToString() + " "
              + time.Month.ToString() + " " + time.Year.ToString();

            data.Descendants("historylist").Last().Add(new XElement("history",
                                                              new XElement("time", date),
                                                              new XElement("url", addressvalue)));
            data.Save("SimpleXml.xml");
        }

    }
}
