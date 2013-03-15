namespace SimpleWebBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addressvalue = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newFavName = new System.Windows.Forms.ToolStripTextBox();
            this.newFavUrl = new System.Windows.Forms.ToolStripTextBox();
            this.addfavbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setcurrentpage = new System.Windows.Forms.ToolStripMenuItem();
            this.typenewhomepage = new System.Windows.Forms.ToolStripTextBox();
            this.go = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.webpage1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printpage = new System.Windows.Forms.Button();
            this.menubar.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressvalue
            // 
            this.addressvalue.Location = new System.Drawing.Point(155, 45);
            this.addressvalue.Name = "addressvalue";
            this.addressvalue.Size = new System.Drawing.Size(438, 20);
            this.addressvalue.TabIndex = 0;
            this.addressvalue.Text = "Enter Website Address Here";
            this.addressvalue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressvalue_KeyDown);
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(104, 48);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(45, 13);
            this.addresslabel.TabIndex = 1;
            this.addresslabel.Text = "Address";
            this.addresslabel.Click += new System.EventHandler(this.addresslabel_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(174, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(57, 20);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStripMenuItem});
            this.favouritesToolStripMenuItem.MergeIndex = 1;
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            this.favouritesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.favouritesToolStripMenuItem_DropDownItemClicked);
            this.favouritesToolStripMenuItem.MouseHover += new System.EventHandler(this.favouritesToolStripMenuItem_MouseHover);
            // 
            // addToFavouritesToolStripMenuItem
            // 
            this.addToFavouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.newFavName,
            this.newFavUrl,
            this.addfavbutton,
            this.toolStripSeparator2});
            this.addToFavouritesToolStripMenuItem.Name = "addToFavouritesToolStripMenuItem";
            this.addToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addToFavouritesToolStripMenuItem.Text = "Add to Favourites";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // newFavName
            // 
            this.newFavName.Name = "newFavName";
            this.newFavName.Size = new System.Drawing.Size(100, 23);
            this.newFavName.Text = "New Name";
            this.newFavName.Click += new System.EventHandler(this.newFavName_Click);
            // 
            // newFavUrl
            // 
            this.newFavUrl.Name = "newFavUrl";
            this.newFavUrl.Size = new System.Drawing.Size(100, 23);
            this.newFavUrl.Text = "New WebAddress";
            // 
            // addfavbutton
            // 
            this.addfavbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addfavbutton.Checked = true;
            this.addfavbutton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addfavbutton.Name = "addfavbutton";
            this.addfavbutton.ShowShortcutKeys = false;
            this.addfavbutton.Size = new System.Drawing.Size(160, 22);
            this.addfavbutton.Text = "Click to Add";
            this.addfavbutton.Click += new System.EventHandler(this.addfavbutton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // menubar
            // 
            this.menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.setHomepageToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(246, 10);
            this.menubar.Name = "menubar";
            this.menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menubar.Size = new System.Drawing.Size(235, 24);
            this.menubar.TabIndex = 5;
            this.menubar.Text = "menubar";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyToolStripMenuItem_DropDownItemClicked);
            // 
            // setHomepageToolStripMenuItem
            // 
            this.setHomepageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setcurrentpage,
            this.typenewhomepage});
            this.setHomepageToolStripMenuItem.Name = "setHomepageToolStripMenuItem";
            this.setHomepageToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.setHomepageToolStripMenuItem.Text = "Set Homepage";
            // 
            // setcurrentpage
            // 
            this.setcurrentpage.Name = "setcurrentpage";
            this.setcurrentpage.Size = new System.Drawing.Size(252, 22);
            this.setcurrentpage.Text = "Set Current Page";
            this.setcurrentpage.Click += new System.EventHandler(this.setCurrentPageToolStripMenuItem_Click);
            // 
            // typenewhomepage
            // 
            this.typenewhomepage.Name = "typenewhomepage";
            this.typenewhomepage.Size = new System.Drawing.Size(192, 23);
            this.typenewhomepage.Text = "Type New Home Page";
            this.typenewhomepage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typenewhomepage_KeyDown);
            this.typenewhomepage.Click += new System.EventHandler(this.typenewhomepage_Click);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(612, 45);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(39, 23);
            this.go.TabIndex = 6;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.status.Location = new System.Drawing.Point(549, 15);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(152, 17);
            this.status.TabIndex = 8;
            this.status.Text = "Status: ";
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabpage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(67, 110);
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(584, 312);
            this.tabcontrol.TabIndex = 10;
            
            // 
            // tabpage1
            // 
            this.tabpage1.AllowDrop = true;
            this.tabpage1.Controls.Add(this.webpage1);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(576, 286);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Tag = "";
            this.tabpage1.Text = "tabpage1";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // webpage1
            // 
            this.webpage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.webpage1.Location = new System.Drawing.Point(6, 6);
            this.webpage1.Multiline = true;
            this.webpage1.Name = "webpage1";
            this.webpage1.ReadOnly = true;
            this.webpage1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.webpage1.Size = new System.Drawing.Size(564, 274);
            this.webpage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "addnewtab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printpage
            // 
            this.printpage.Location = new System.Drawing.Point(576, 92);
            this.printpage.Name = "printpage";
            this.printpage.Size = new System.Drawing.Size(75, 23);
            this.printpage.TabIndex = 11;
            this.printpage.Text = "Print Page";
            this.printpage.UseVisualStyleBackColor = true;
            this.printpage.Click += new System.EventHandler(this.printpage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 434);
            this.Controls.Add(this.printpage);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.status);
            this.Controls.Add(this.go);
            this.Controls.Add(this.home);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.addressvalue);
            this.Controls.Add(this.menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubar;
            this.Name = "MainForm";
            this.Text = "SimpleWebBrowser";
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressvalue;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.ToolStripMenuItem setHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setcurrentpage;
        private System.Windows.Forms.ToolStripTextBox typenewhomepage;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox webpage1;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox newFavName;
        private System.Windows.Forms.ToolStripTextBox newFavUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addfavbutton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button printpage;
    }
}

