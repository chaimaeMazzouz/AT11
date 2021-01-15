namespace AT11_DataSet_XSD
{
    partial class Navigation_client
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNbreClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumCl = new System.Windows.Forms.TextBox();
            this.textNomCl = new System.Windows.Forms.TextBox();
            this.textPrenomCl = new System.Windows.Forms.TextBox();
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.ClientTableAdapter();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.Export_xml = new System.Windows.Forms.Button();
            this.Import_xml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre des Clients";
            // 
            // txtNbreClient
            // 
            this.txtNbreClient.Location = new System.Drawing.Point(201, 89);
            this.txtNbreClient.Name = "txtNbreClient";
            this.txtNbreClient.ReadOnly = true;
            this.txtNbreClient.Size = new System.Drawing.Size(41, 20);
            this.txtNbreClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num de Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom de Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prénom de Client";
            // 
            // textNumCl
            // 
            this.textNumCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Num_client", true));
            this.textNumCl.Location = new System.Drawing.Point(181, 184);
            this.textNumCl.Name = "textNumCl";
            this.textNumCl.Size = new System.Drawing.Size(100, 20);
            this.textNumCl.TabIndex = 6;
            // 
            // textNomCl
            // 
            this.textNomCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom_client", true));
            this.textNomCl.Location = new System.Drawing.Point(181, 240);
            this.textNomCl.Name = "textNomCl";
            this.textNomCl.Size = new System.Drawing.Size(100, 20);
            this.textNomCl.TabIndex = 8;
            // 
            // textPrenomCl
            // 
            this.textPrenomCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom_Client", true));
            this.textPrenomCl.Location = new System.Drawing.Point(181, 283);
            this.textPrenomCl.Name = "textPrenomCl";
            this.textPrenomCl.Size = new System.Drawing.Size(100, 20);
            this.textPrenomCl.TabIndex = 9;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(415, 184);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(75, 23);
            this.btnPremier.TabIndex = 10;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(415, 213);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 11;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(415, 243);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 12;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(415, 280);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 13;
            this.btnDernier.Text = "Dérnier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // Export_xml
            // 
            this.Export_xml.Location = new System.Drawing.Point(583, 133);
            this.Export_xml.Name = "Export_xml";
            this.Export_xml.Size = new System.Drawing.Size(103, 36);
            this.Export_xml.TabIndex = 14;
            this.Export_xml.Text = "Enregistrer la table client en xml";
            this.Export_xml.UseVisualStyleBackColor = true;
            this.Export_xml.Click += new System.EventHandler(this.Export_xml_Click);
            // 
            // Import_xml
            // 
            this.Import_xml.Location = new System.Drawing.Point(583, 224);
            this.Import_xml.Name = "Import_xml";
            this.Import_xml.Size = new System.Drawing.Size(103, 36);
            this.Import_xml.TabIndex = 15;
            this.Import_xml.Text = "Importer la table client en xml";
            this.Import_xml.UseVisualStyleBackColor = true;
            this.Import_xml.Click += new System.EventHandler(this.Import_xml_Click);
            // 
            // Navigation_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Import_xml);
            this.Controls.Add(this.Export_xml);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.textPrenomCl);
            this.Controls.Add(this.textNomCl);
            this.Controls.Add(this.textNumCl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNbreClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Navigation_client";
            this.Text = "Navigation_client";
            this.Load += new System.EventHandler(this.Navigation_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNbreClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNumCl;
        private System.Windows.Forms.TextBox textNomCl;
        private System.Windows.Forms.TextBox textPrenomCl;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button Export_xml;
        private System.Windows.Forms.Button Import_xml;
    }
}