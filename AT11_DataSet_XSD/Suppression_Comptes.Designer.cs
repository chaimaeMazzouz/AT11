namespace AT11_DataSet_XSD
{
    partial class Suppression_Comptes
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new AT11_DataSet_XSD.DataSet1();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteTableAdapter = new AT11_DataSet_XSD.DataSet1TableAdapters.CompteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numCompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Suppression Comptes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Num de Compte";
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.ForeColor = System.Drawing.Color.White;
            this.btn_Quitter.Location = new System.Drawing.Point(607, 100);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(123, 57);
            this.btn_Quitter.TabIndex = 35;
            this.btn_Quitter.Text = "Enregistrer et Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Supprimer.Location = new System.Drawing.Point(415, 100);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(123, 59);
            this.btn_Supprimer.TabIndex = 34;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.compteBindingSource;
            this.comboBox1.DisplayMember = "Num_Compte";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.ValueMember = "Num_Compte";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataMember = "Compte";
            this.compteBindingSource.DataSource = this.dataSet1;
            // 
            // compteTableAdapter
            // 
            this.compteTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(192, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 37;
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
            // Suppression_Comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Suppression_Comptes";
            this.Text = "Suppression_Comptes";
            this.Load += new System.EventHandler(this.Suppression_Comptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private DataSet1TableAdapters.CompteTableAdapter compteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCDataGridViewTextBoxColumn;
    }
}