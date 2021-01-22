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
    public partial class Modification_Comptes : Form
    {
        public Modification_Comptes()
        {
            InitializeComponent();
        }

        private void Modification_Comptes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.dataSet1.Compte);
            comboTypeC.Text = "-Faites votre choix-";
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            this.compteBindingSource.EndEdit();
            MessageBox.Show("Modification effectuée");
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

        private void comboTypeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            textTypeC.Text = comboTypeC.Text;
        }
    }
}
