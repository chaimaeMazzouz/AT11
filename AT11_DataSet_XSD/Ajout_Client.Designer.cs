namespace AT11_DataSet_XSD
{
    partial class Ajout_Client
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.ClientTableAdapter();
            this.numclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNumCl = new System.Windows.Forms.TextBox();
            this.textNomCli = new System.Windows.Forms.TextBox();
            this.textPrenomCl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ajout Clients";
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.ForeColor = System.Drawing.Color.White;
            this.btn_Quitter.Location = new System.Drawing.Point(627, 123);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(123, 57);
            this.btn_Quitter.TabIndex = 23;
            this.btn_Quitter.Text = "Enregistrer et Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter.Location = new System.Drawing.Point(435, 123);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(123, 59);
            this.btn_Ajouter.TabIndex = 22;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(52, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Prénom de client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(52, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Num de Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(52, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nom de client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numclientDataGridViewTextBoxColumn,
            this.nomclientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 150);
            this.dataGridView1.TabIndex = 35;
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
            // numclientDataGridViewTextBoxColumn
            // 
            this.numclientDataGridViewTextBoxColumn.DataPropertyName = "Num_client";
            this.numclientDataGridViewTextBoxColumn.HeaderText = "Num_client";
            this.numclientDataGridViewTextBoxColumn.Name = "numclientDataGridViewTextBoxColumn";
            this.numclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "Nom_client";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "Nom_client";
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            this.nomclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            this.prenomClientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.HeaderText = "Prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            this.prenomClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textNumCl
            // 
            this.textNumCl.Location = new System.Drawing.Point(213, 139);
            this.textNumCl.Name = "textNumCl";
            this.textNumCl.Size = new System.Drawing.Size(100, 20);
            this.textNumCl.TabIndex = 36;
            // 
            // textNomCli
            // 
            this.textNomCli.Location = new System.Drawing.Point(213, 191);
            this.textNomCli.Name = "textNomCli";
            this.textNomCli.Size = new System.Drawing.Size(100, 20);
            this.textNomCli.TabIndex = 37;
            // 
            // textPrenomCl
            // 
            this.textPrenomCl.Location = new System.Drawing.Point(213, 237);
            this.textPrenomCl.Name = "textPrenomCl";
            this.textPrenomCl.Size = new System.Drawing.Size(100, 20);
            this.textPrenomCl.TabIndex = 38;
            // 
            // Ajout_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPrenomCl);
            this.Controls.Add(this.textNomCli);
            this.Controls.Add(this.textNumCl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_Client";
            this.Text = "Ajout_Client";
            this.Load += new System.EventHandler(this.Ajout_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textNumCl;
        private System.Windows.Forms.TextBox textNomCli;
        private System.Windows.Forms.TextBox textPrenomCl;
    }
}