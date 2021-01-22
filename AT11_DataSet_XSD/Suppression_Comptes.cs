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
    public partial class Suppression_Comptes : Form
    {
        public Suppression_Comptes()
        {
            InitializeComponent();
        }

        private void Suppression_Comptes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.dataSet1.Compte);
            // TODO: This line of code loads data into the 'dataSet1.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.dataSet1.Compte);

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.compteBindingSource.RemoveAt(this.compteBindingSource.Position);
                MessageBox.Show("Suppression effectuée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
