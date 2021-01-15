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
    public partial class Navigation_client : Form
    {
        public Navigation_client()
        {
            InitializeComponent();
        }

        private void Navigation_client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.Client);
            txtNbreClient.Text = this.dataSet1.Client.Count.ToString();

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.Position = 0;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.Position ++;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.Position--;
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.Position = this.clientBindingSource.Count -1;
        }

        private void Export_xml_Click(object sender, EventArgs e)
        {
            this.dataSet1.Client.WriteXml("Client.xml");
            MessageBox.Show("Enregistremente en XML effectué");
        }

        private void Import_xml_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataSet1.Client.Clear();
                this.dataSet1.Client.ReadXml("Client.xml");
                txtNbreClient.Text = this.dataSet1.Client.Count.ToString();
                MessageBox.Show("Importation en XML effectué");

            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur: "+exp.Message);

            }
        }
    }
}
