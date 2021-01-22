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
    public partial class Modification_Clients : Form
    {
        public Modification_Clients()
        {
            InitializeComponent();
        }

        private void Modification_Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.EndEdit();
            MessageBox.Show("Modification effectuée");
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
