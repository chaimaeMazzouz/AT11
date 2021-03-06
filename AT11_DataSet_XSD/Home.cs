﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Navigation_client());
        }

        private void navigationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Navigation_Compte());

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Ajout_Client());

        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Ajout_Comptes());
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Suppression_Comptes());

        }

        private void suppressionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Suppression_Clients());

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Modification_Comptes());

        }

        private void modificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Modification_Clients());

        }

        private void exportDataSetXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1 ds = new DataSet1();
                ds.WriteXmlSchema("Banque_xml.xsd");
                MessageBox.Show("Enregitrement en Xml effectuée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importDataSetXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1 ds = new DataSet1();
                ds.ReadXmlSchema("Banque_xml.xsd");
                MessageBox.Show("Importation en Xml effectuée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
