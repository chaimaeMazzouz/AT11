namespace AT11_DataSet_XSD
{
    partial class Navigation_Compte
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
            this.Import_xml = new System.Windows.Forms.Button();
            this.Export_xml = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.textNumCl = new System.Windows.Forms.TextBox();
            this.textNumComp = new System.Windows.Forms.TextBox();
            this.txtNbreCompte = new System.Windows.Forms.TextBox();
            this.textTypeC = new System.Windows.Forms.TextBox();
            this.compteTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.CompteTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Import_xml
            // 
            this.Import_xml.Location = new System.Drawing.Point(613, 279);
            this.Import_xml.Name = "Import_xml";
            this.Import_xml.Size = new System.Drawing.Size(103, 36);
            this.Import_xml.TabIndex = 30;
            this.Import_xml.Text = "Importer la table compte en xml";
            this.Import_xml.UseVisualStyleBackColor = true;
            this.Import_xml.Click += new System.EventHandler(this.Import_xml_Click);
            // 
            // Export_xml
            // 
            this.Export_xml.Location = new System.Drawing.Point(613, 188);
            this.Export_xml.Name = "Export_xml";
            this.Export_xml.Size = new System.Drawing.Size(103, 36);
            this.Export_xml.TabIndex = 29;
            this.Export_xml.Text = "Enregistrer la table compte en xml";
            this.Export_xml.UseVisualStyleBackColor = true;
            this.Export_xml.Click += new System.EventHandler(this.Export_xml_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(445, 335);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 28;
            this.btnDernier.Text = "Dérnier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(445, 298);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 27;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(445, 268);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 26;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(445, 239);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(75, 23);
            this.btnPremier.TabIndex = 25;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // textSolde
            // 
            this.textSolde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Solde", true));
            this.textSolde.Location = new System.Drawing.Point(211, 338);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 24;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataMember = "Compte";
            this.compteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textNumCl
            // 
            this.textNumCl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Num_Client", true));
            this.textNumCl.Location = new System.Drawing.Point(211, 295);
            this.textNumCl.Name = "textNumCl";
            this.textNumCl.Size = new System.Drawing.Size(100, 20);
            this.textNumCl.TabIndex = 23;
            // 
            // textNumComp
            // 
            this.textNumComp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "Num_Compte", true));
            this.textNumComp.Location = new System.Drawing.Point(211, 245);
            this.textNumComp.Name = "textNumComp";
            this.textNumComp.Size = new System.Drawing.Size(100, 20);
            this.textNumComp.TabIndex = 22;
            // 
            // txtNbreCompte
            // 
            this.txtNbreCompte.Location = new System.Drawing.Point(231, 144);
            this.txtNbreCompte.Name = "txtNbreCompte";
            this.txtNbreCompte.ReadOnly = true;
            this.txtNbreCompte.Size = new System.Drawing.Size(41, 20);
            this.txtNbreCompte.TabIndex = 18;
            // 
            // textTypeC
            // 
            this.textTypeC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "TypeC", true));
            this.textTypeC.Location = new System.Drawing.Point(211, 380);
            this.textTypeC.Name = "textTypeC";
            this.textTypeC.Size = new System.Drawing.Size(100, 20);
            this.textTypeC.TabIndex = 32;
            // 
            // compteTableAdapter
            // 
            this.compteTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(72, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Type Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(72, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Num de Compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(72, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Num de Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(72, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Solde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Navigation Comptes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre des Comptes";
            // 
            // Navigation_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTypeC);
            this.Controls.Add(this.Import_xml);
            this.Controls.Add(this.Export_xml);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.textNumCl);
            this.Controls.Add(this.textNumComp);
            this.Controls.Add(this.txtNbreCompte);
            this.Name = "Navigation_Compte";
            this.Text = "Navigation_Compte";
            this.Load += new System.EventHandler(this.Navigation_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import_xml;
        private System.Windows.Forms.Button Export_xml;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.TextBox textNumCl;
        private System.Windows.Forms.TextBox textNumComp;
        private System.Windows.Forms.TextBox txtNbreCompte;
        private System.Windows.Forms.TextBox textTypeC;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private DataSet1TableAdapters.CompteTableAdapter compteTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}