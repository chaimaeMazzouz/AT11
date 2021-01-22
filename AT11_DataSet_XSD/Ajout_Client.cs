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
    public partial class Ajout_Client : Form
    {
        public Ajout_Client()
        {
            InitializeComponent();
        }

        private void Ajout_Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (textNumCl.Text != "" && textNomCli.Text != "" && textPrenomCl.Text !="")
            {
                try
                {
                    DataRow C1 = this.dataSet1.Client.NewRow();
                    C1.BeginEdit();
                    C1[0] = textNumCl.Text;
                    C1[1] = textNomCli.Text;
                    C1[2] = textPrenomCl.Text;
                    C1.EndEdit();
                    this.dataSet1.Client.Rows.Add(C1);
                    dataGridView1.Refresh();
                    MessageBox.Show("Ajout effectué");


                    textNomCli.Text = "";
                    textNumCl.Text = "";
                    textPrenomCl.Text = "";

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.Update(this.dataSet1.Client);
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
