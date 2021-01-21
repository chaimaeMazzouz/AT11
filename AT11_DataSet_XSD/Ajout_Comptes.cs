using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT11_DataSet_XSD
{
    public partial class Ajout_Comptes : Form
    {
        public Ajout_Comptes()
        {
            InitializeComponent();
        }

        private void Ajout_Comptes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.dataSet1.Compte);
            // TODO: This line of code loads data into the 'dataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.Client);
            comboNumClient.Text = "-Faites votre choix-";
            comboTypeC.Text = "-Faites votre choix-";

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (textNumCompte.Text!=""&& textSolde.Text!=""&& comboNumClient.Text != "-Faites votre choix-" && comboTypeC.Text != "-Faites votre choix-")
            {
                try
                {
                    DataRow C1 = this.dataSet1.Compte.NewRow();
                    C1.BeginEdit();
                    C1[0] = textNumCompte.Text;
                    C1[1] = comboNumClient.Text;
                    C1[2] = textSolde.Text;
                    C1[3] = comboTypeC.Text;
                    C1.EndEdit();
                    this.dataSet1.Compte.Rows.Add(C1);

                    MessageBox.Show("Ajout effectué");

                    comboNumClient.Text = "-Faites votre choix-";
                    comboTypeC.Text = "-Faites votre choix-";
                    textNumCompte.Text = "";
                    textSolde.Text = "";

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            try
            {
                this.compteTableAdapter.Update(this.dataSet1.Compte);
                MessageBox.Show("MAJ de la base de données effectué");
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
