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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.textNomCl = new System.Windows.Forms.TextBox();
            this.textPrenomCl = new System.Windows.Forms.TextBox();
            this.clientTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.ClientTableAdapter();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.Export_xml = new System.Windows.Forms.Button();
            this.Import_xml = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num de Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom de Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prénom de Client";
            // 
            // textNumCl
            // 
            this.textNumCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Num_client", true));
            this.textNumCl.Location = new System.Drawing.Point(156, 43);
            this.textNumCl.Name = "textNumCl";
            this.textNumCl.Size = new System.Drawing.Size(141, 22);
            this.textNumCl.TabIndex = 6;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textNomCl
            // 
            this.textNomCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom_client", true));
            this.textNomCl.Location = new System.Drawing.Point(156, 91);
            this.textNomCl.Name = "textNomCl";
            this.textNomCl.Size = new System.Drawing.Size(141, 22);
            this.textNomCl.TabIndex = 8;
            // 
            // textPrenomCl
            // 
            this.textPrenomCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom_Client", true));
            this.textPrenomCl.Location = new System.Drawing.Point(156, 140);
            this.textPrenomCl.Name = "textPrenomCl";
            this.textPrenomCl.Size = new System.Drawing.Size(141, 22);
            this.textPrenomCl.TabIndex = 9;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnPremier
            // 
            this.btnPremier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.ForeColor = System.Drawing.Color.White;
            this.btnPremier.Location = new System.Drawing.Point(341, 39);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(95, 23);
            this.btnPremier.TabIndex = 10;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(341, 68);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(95, 23);
            this.btnSuivant.TabIndex = 11;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.ForeColor = System.Drawing.Color.White;
            this.btnPrecedent.Location = new System.Drawing.Point(341, 98);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(95, 29);
            this.btnPrecedent.TabIndex = 12;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernier.ForeColor = System.Drawing.Color.White;
            this.btnDernier.Location = new System.Drawing.Point(341, 135);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(95, 25);
            this.btnDernier.TabIndex = 13;
            this.btnDernier.Text = "Dérnier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // Export_xml
            // 
            this.Export_xml.BackColor = System.Drawing.Color.LightCoral;
            this.Export_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_xml.ForeColor = System.Drawing.Color.White;
            this.Export_xml.Location = new System.Drawing.Point(583, 133);
            this.Export_xml.Name = "Export_xml";
            this.Export_xml.Size = new System.Drawing.Size(123, 59);
            this.Export_xml.TabIndex = 14;
            this.Export_xml.Text = "Enregistrer la table client en xml";
            this.Export_xml.UseVisualStyleBackColor = false;
            this.Export_xml.Click += new System.EventHandler(this.Export_xml_Click);
            // 
            // Import_xml
            // 
            this.Import_xml.BackColor = System.Drawing.Color.LightCoral;
            this.Import_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import_xml.ForeColor = System.Drawing.Color.White;
            this.Import_xml.Location = new System.Drawing.Point(583, 224);
            this.Import_xml.Name = "Import_xml";
            this.Import_xml.Size = new System.Drawing.Size(123, 57);
            this.Import_xml.TabIndex = 15;
            this.Import_xml.Text = "Importer la table client en xml";
            this.Import_xml.UseVisualStyleBackColor = false;
            this.Import_xml.Click += new System.EventHandler(this.Import_xml_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.textNomCl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.textNumCl);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.textPrenomCl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Navigation_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Import_xml);
            this.Controls.Add(this.Export_xml);
            this.Controls.Add(this.txtNbreClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Navigation_client";
            this.Text = "Navigation_client";
            this.Load += new System.EventHandler(this.Navigation_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}