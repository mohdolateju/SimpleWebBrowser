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
using System.Drawing.Printing;



namespace SimpleWebBrowser
{
    public partial class MainForm : Form
    {
        //Instance variables used
        private Font printFont;
        private StreamReader reader;
        private XmlAccess xmldata= new XmlAccess();

        /**Constructor used to initialize methods at start up*/
        public MainForm()
        {
            InitializeComponent();
            startuphomepage();
            favouriteslist();
        }
        
        /**Event Handler used to clear the address text box*/
        private void addresslabel_Click(object sender, EventArgs e)
        {
            TextBox t = this.addressvalue;
            t.Text = " ";
        }

        /**Event Handler for a button used to request a webpage*/
        private void go_Click(object sender, EventArgs e)
        {
            runConnection(this.addressvalue.Text);
        }

        /**Send a page request when the user presses the 'Enter' Key on the keyboard*/
        private void addressvalue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runConnection(this.addressvalue.Text);
            }
        }

        /**Used to send a request for the homepage at startup by getting the homepage value from 
            SimpleXml.xml file through the getHomepage method in the XmlAccess class*/
        public void startuphomepage() {
            XDocument data = this.xmldata.loadXmlData();
            var urls = from x in data.Descendants("home")
                       select new
                       {
                           x.Descendants("url").First().Value
                       };

            foreach (var url in urls){
                this.addressvalue.Text = url.Value;
                this.webpage1.Text = url.ToString();
            }

            runConnection(this.addressvalue.Text);
        }

        /**This Method is used to request a page using the WebRequest and WebResponse clas and prints 
            errors encounterd, it takes the webaddress as a String parameter*/
        public void runConnection(String url)
        {
            //gets the url from parameter adds a web protocol if isn't specified by the user
            this.addressvalue.Text= url;
            String certurl;
            if (url.Trim().StartsWith("http://") || url.Trim().StartsWith("https://"))
            {
                certurl = url;
            }
            else
            {
                certurl = "http://" + url;
            }

            //sends a http request if the gets the page its prints it in the webpage textbox
            //or it catches an exception and prints the error code.
            try
            {
                WebRequest myRequest = WebRequest.Create(certurl);
                WebResponse myResponse = myRequest.GetResponse();
                Stream dataStream = myResponse.GetResponseStream();
                this.reader = new StreamReader(dataStream);
                StringBuilder webcontent = new StringBuilder(reader.ReadToEnd());
                this.webpage1.Text = webcontent.ToString();
                this.status.BackColor = System.Drawing.Color.Green;
                this.status.Text = "Status: 200 OK";
                this.webpage1.BackColor = System.Drawing.Color.White;
            }
            catch (WebException ex)
            {

                if (ex.Status.ToString().Equals("NameResolutionFailure"))
                {
                    this.webpage1.BackColor = System.Drawing.Color.Red;
                    this.status.BackColor = System.Drawing.Color.Red;
                    this.status.Text = "Status: 404 Not Found";
                    this.webpage1.Text = "Webpage Not Found";
                }
                else if (ex.Message.ToString().Contains("403"))
                {
                    this.webpage1.BackColor = System.Drawing.Color.Red;
                    this.status.BackColor = System.Drawing.Color.Red;
                    this.status.Text = "Status: 403 Forbidden";
                    this.webpage1.Text = "Unauthorized Access";
                }
                else
                {
                    this.status.BackColor = System.Drawing.Color.Red;
                    this.status.Text = "Status: Something is Wrong";
                    this.webpage1.Text = ex.Message.ToString();
                }
            }

            catch (UriFormatException)
            {
                this.webpage1.BackColor = System.Drawing.Color.Red;
                this.status.BackColor = System.Drawing.Color.Red;
                this.status.Text = "Status: 400 Bad Request";
                this.webpage1.Text = "Please Enter A Valid Web Address";
            }

            //After each requestion is sent the historylist is repopulated
            xmldata.newhistory(xmldata.loadXmlData(), this.addressvalue.Text);
            this.historyToolStripMenuItem.DropDownItems.Clear();
            historylist();
        }

        /**Event handler that sets currently viewedpage as the default homepage by calling the setnewhomepage
            method*/
        private void setCurrentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmldata.setnewhomepage(this.addressvalue.Text);
        }

        /**Event hander that Clears the TextBox when a user clicks the field to enter a new home page*/
        private void typenewhomepage_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripTextBox address = this.typenewhomepage;
            String Stringaddress = address.Text;

            if (Stringaddress.Equals("Type New Home Page"))
            {
                address.Text = " ";               
            } 

        }

        /**Event handler to send a http request for the homepage when the home button is clicked*/
        private void home_Click(object sender, EventArgs e)
        {
            String mainurl = "";
            XDocument data = this.xmldata.loadXmlData();
            var urls = from x in data.Descendants("home")
                       select new
                       {
                           x.Descendants("url").First().Value
                       };

            foreach (var url in urls)
            {
                this.addressvalue.Text = url.Value;
                mainurl = url.Value;
                this.webpage1.Text = url.ToString();
            }
            //Sends a http request after getting the homepage from the xml file
            runConnection(mainurl);
        }

        /**Event Handler for that sets a new home page when the 'Enter' key is pressed*/
        private void typenewhomepage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                xmldata.setnewhomepage(this.typenewhomepage.Text);
            }
        }

        /**Event Handler for clearing the new favourite name textbox*/
        private void newFavName_Click(object sender, EventArgs e)
        {
            if(this.newFavName.Text.Equals("New Name")){
                this.newFavName.Text = "";
                }
        }

        /**add Favourite Button method is also an event handler that adds a new favourite to the favouritelist*/
        private void addfavbutton_Click(object sender, EventArgs e)
        {
            if (this.newFavName.Text.Trim() != "" && this.newFavUrl.Text.Trim() != "")
            {
            xmldata.addfavourites(this.newFavName.Text, this.newFavUrl.Text);
            System.Windows.Forms.ToolStripMenuItem newfavourite = new System.Windows.Forms.ToolStripMenuItem();
            newfavourite.Name = this.newFavName.Text;
            newfavourite.Text = this.newFavName.Text;
            newfavourite.Tag = this.newFavName.Text;
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    newfavourite});
            }
            else if (this.newFavName.Text.Trim() == "") {
                this.newFavName.BackColor = System.Drawing.Color.Red;
                this.newFavName.Text = "Enter Name";
            }
            else if (this.newFavUrl.Text.Trim() == "")
            {
                this.newFavUrl.BackColor = System.Drawing.Color.Red;
            }
        }

        
        /**This method updates the favourite list from the xml file to the User Interface
            by adding each name of the favourites to the dropdown menustripbar*/
        public void favouriteslist()
        {
            XDocument data = this.xmldata.loadXmlData();
            var favourites = from x in data.Descendants("favourite")
                             select new
                             {
                                 name = x.Descendants("name").First().Value
                             };

            foreach (var favourite in favourites)
            {
                System.Windows.Forms.ToolStripMenuItem newfavourite = new System.Windows.Forms.ToolStripMenuItem();
                newfavourite.Name = favourite.name;
                newfavourite.Text = favourite.name;
                this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    newfavourite});
            }
            

        }

        /**This Event Handler assigns the current viewed webaddress to the add new favourites url textbox*/
        private void favouritesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.newFavUrl.Text = this.addressvalue.Text;
        }

        /**This Event Handler sends a http request for any favourite clicked from the favourites dropdown menu
            (This method has buggs as only the last favourite is sent as request)*/
        private void favouritesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
                XDocument data = this.xmldata.loadXmlData();
                if(e.ClickedItem.ToString()==data.Descendants("favourite").Descendants("name").Last().Value){
                    runConnection(data.Descendants("favourite").Last().Descendants("url").Last().Value);
                }

        }

        /**This method updates the history list from the xml file to the User Interface
            by adding each name of the history to the dropdown menustripbar*/
        public void historylist()
        {
            XDocument data = this.xmldata.loadXmlData();
            var historylist = from x in data.Descendants("history")
                             select new
                             {
                                 name = x.Descendants("url").First().Value
                             };

            foreach (var history in historylist)
            {
                System.Windows.Forms.ToolStripMenuItem newhistory = new System.Windows.Forms.ToolStripMenuItem();
                newhistory.Text = history.name;
                
                this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    newhistory});
            }
            
        }

        /**This method sends any url gotten from the history dropdown list as a http request to be 
            displayed to webpage*/
        private void historyToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            runConnection(e.ClickedItem.ToString());
        }

        /**The Algorithm for specifying how the webpage should be printed*/
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float rightMargin = ev.MarginBounds.Right;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);
            
            
            for(int i=0 ;i<webpage1.Lines.Length;i++,count++){
                    line=webpage1.Lines[i];
                    yPos = topMargin + (count *
                    printFont.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFont, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                }

            line = null;
            
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }


        /**This Event Handler prints a the webpage to a user defined printer*/
        private void printpage_Click(object sender, EventArgs e)
        {
            this.printDialog1.AllowSomePages = true;
            printDialog1.ShowDialog();
            try
            {

                printFont = new Font("Arial", 10);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler
                   (this.pd_PrintPage);
                pd.Print();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
        
    
}
