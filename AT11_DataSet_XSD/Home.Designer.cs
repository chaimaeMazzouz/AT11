namespace AT11_DataSet_XSD
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataSetXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataSetXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.exportDataSetXmlToolStripMenuItem,
            this.importDataSetXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.suppressionToolStripMenuItem1,
            this.modificationToolStripMenuItem1});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem1,
            this.ajoutToolStripMenuItem1,
            this.suppressionToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // navigationToolStripMenuItem1
            // 
            this.navigationToolStripMenuItem1.Name = "navigationToolStripMenuItem1";
            this.navigationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.navigationToolStripMenuItem1.Text = "Navigation";
            this.navigationToolStripMenuItem1.Click += new System.EventHandler(this.navigationToolStripMenuItem1_Click);
            // 
            // ajoutToolStripMenuItem1
            // 
            this.ajoutToolStripMenuItem1.Name = "ajoutToolStripMenuItem1";
            this.ajoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajoutToolStripMenuItem1.Text = "Ajout";
            this.ajoutToolStripMenuItem1.Click += new System.EventHandler(this.ajoutToolStripMenuItem1_Click);
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.suppressionToolStripMenuItem_Click);
            // 
            // suppressionToolStripMenuItem1
            // 
            this.suppressionToolStripMenuItem1.Name = "suppressionToolStripMenuItem1";
            this.suppressionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.suppressionToolStripMenuItem1.Text = "Suppression";
            this.suppressionToolStripMenuItem1.Click += new System.EventHandler(this.suppressionToolStripMenuItem1_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.modificationToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem1
            // 
            this.modificationToolStripMenuItem1.Name = "modificationToolStripMenuItem1";
            this.modificationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificationToolStripMenuItem1.Text = "Modification";
            this.modificationToolStripMenuItem1.Click += new System.EventHandler(this.modificationToolStripMenuItem1_Click);
            // 
            // exportDataSetXmlToolStripMenuItem
            // 
            this.exportDataSetXmlToolStripMenuItem.Name = "exportDataSetXmlToolStripMenuItem";
            this.exportDataSetXmlToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.exportDataSetXmlToolStripMenuItem.Text = "Export DataSet Xml";
            this.exportDataSetXmlToolStripMenuItem.Click += new System.EventHandler(this.exportDataSetXmlToolStripMenuItem_Click);
            // 
            // importDataSetXMLToolStripMenuItem
            // 
            this.importDataSetXMLToolStripMenuItem.Name = "importDataSetXMLToolStripMenuItem";
            this.importDataSetXMLToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.importDataSetXMLToolStripMenuItem.Text = "Import DataSet XML";
            this.importDataSetXMLToolStripMenuItem.Click += new System.EventHandler(this.importDataSetXMLToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Banque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportDataSetXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataSetXMLToolStripMenuItem;
    }
}

