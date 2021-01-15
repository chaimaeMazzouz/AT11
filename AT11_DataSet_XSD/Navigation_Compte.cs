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
    public partial class Navigation_Compte : Form
    {
        public Navigation_Compte()
        {
            InitializeComponent();
        }

        private void Navigation_Compte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.dataSet1.Compte);
            txtNbreCompte.Text = this.dataSet1.Compte.Count.ToString();


        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position = 0;

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position ++;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position--;

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.Position = this.compteBindingSource.Count - 1;

        }

        private void Export_xml_Click(object sender, EventArgs e)
        {
            this.dataSet1.Compte.WriteXml("Compte.xml");
            MessageBox.Show("Enregistremente en XML effectué");
        }

        private void Import_xml_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataSet1.Compte.Clear();
                this.dataSet1.Compte.ReadXml("Compte.xml");
                txtNbreCompte.Text = this.dataSet1.Compte.Count.ToString();
                MessageBox.Show("Importation en XML effectué");

            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur: " + exp.Message);

            }
        }
    }
}
