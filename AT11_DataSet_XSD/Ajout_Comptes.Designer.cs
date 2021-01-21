namespace AT11_DataSet_XSD
{
    partial class Ajout_Comptes
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumCompte = new System.Windows.Forms.TextBox();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.comboNumClient = new System.Windows.Forms.ComboBox();
            this.comboTypeC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.ClientTableAdapter();
            this.compteTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.CompteTableAdapter();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.ForeColor = System.Drawing.Color.White;
            this.btn_Quitter.Location = new System.Drawing.Point(610, 133);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(123, 57);
            this.btn_Quitter.TabIndex = 21;
            this.btn_Quitter.Text = "Enregistrer et Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter.Location = new System.Drawing.Point(418, 133);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(123, 59);
            this.btn_Ajouter.TabIndex = 20;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ajout Comptes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(70, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Num de Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(70, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Num de Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(70, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Solde";
            // 
            // textNumCompte
            // 
            this.textNumCompte.Location = new System.Drawing.Point(197, 73);
            this.textNumCompte.Name = "textNumCompte";
            this.textNumCompte.Size = new System.Drawing.Size(141, 20);
            this.textNumCompte.TabIndex = 25;
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(197, 167);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(141, 20);
            this.textSolde.TabIndex = 27;
            // 
            // comboNumClient
            // 
            this.comboNumClient.DataSource = this.clientBindingSource1;
            this.comboNumClient.DisplayMember = "Num_client";
            this.comboNumClient.FormattingEnabled = true;
            this.comboNumClient.Location = new System.Drawing.Point(197, 119);
            this.comboNumClient.Name = "comboNumClient";
            this.comboNumClient.Size = new System.Drawing.Size(141, 21);
            this.comboNumClient.TabIndex = 28;
            // 
            // comboTypeC
            // 
            this.comboTypeC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compteBindingSource, "TypeC", true));
            this.comboTypeC.DataSource = this.compteBindingSource;
            this.comboTypeC.DisplayMember = "TypeC";
            this.comboTypeC.FormattingEnabled = true;
            this.comboTypeC.Location = new System.Drawing.Point(197, 212);
            this.comboTypeC.Name = "comboTypeC";
            this.comboTypeC.Size = new System.Drawing.Size(141, 21);
            this.comboTypeC.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(70, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type Compte";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCompteDataGridViewTextBoxColumn,
            this.numClientDataGridViewTextBoxColumn,
            this.soldeDataGridViewTextBoxColumn,
            this.typeCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Compte";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // compteTableAdapter
            // 
            this.compteTableAdapter.ClearBeforeFill = true;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataMember = "Compte";
            this.compteBindingSource.DataSource = this.dataSet1;
            // 
            // numCompteDataGridViewTextBoxColumn
            // 
            this.numCompteDataGridViewTextBoxColumn.DataPropertyName = "Num_Compte";
            this.numCompteDataGridViewTextBoxColumn.HeaderText = "Num_Compte";
            this.numCompteDataGridViewTextBoxColumn.Name = "numCompteDataGridViewTextBoxColumn";
            // 
            // numClientDataGridViewTextBoxColumn
            // 
            this.numClientDataGridViewTextBoxColumn.DataPropertyName = "Num_Client";
            this.numClientDataGridViewTextBoxColumn.HeaderText = "Num_Client";
            this.numClientDataGridViewTextBoxColumn.Name = "numClientDataGridViewTextBoxColumn";
            // 
            // soldeDataGridViewTextBoxColumn
            // 
            this.soldeDataGridViewTextBoxColumn.DataPropertyName = "Solde";
            this.soldeDataGridViewTextBoxColumn.HeaderText = "Solde";
            this.soldeDataGridViewTextBoxColumn.Name = "soldeDataGridViewTextBoxColumn";
            // 
            // typeCDataGridViewTextBoxColumn
            // 
            this.typeCDataGridViewTextBoxColumn.DataPropertyName = "TypeC";
            this.typeCDataGridViewTextBoxColumn.HeaderText = "TypeC";
            this.typeCDataGridViewTextBoxColumn.Name = "typeCDataGridViewTextBoxColumn";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.dataSet1;
            // 
            // Ajout_Comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTypeC);
            this.Controls.Add(this.comboNumClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNumCompte);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_Comptes";
            this.Text = "Ajout_Comptes";
            this.Load += new System.EventHandler(this.Ajout_Comptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNumCompte;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.ComboBox comboNumClient;
        private System.Windows.Forms.ComboBox comboTypeC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DataSet1TableAdapters.CompteTableAdapter compteTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCDataGridViewTextBoxColumn;
    }
}