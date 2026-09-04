using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;
using Metier;
namespace Vues
{
    public partial class GestionColis : Form
    {
        public GestionColis()
        {
            InitializeComponent();
        }

        private void GestionColis_Load(object sender, EventArgs e)
        {
            dgvColis.DataSource = ContollerColis.GetColis();
            cbProds.DataSource=ContollerColis.GetProduits();


        }
        private void Viderchamps()
        {
            dtpLiv.Value = DateTime.Now;
            cbProds.SelectedIndex = -1;
            txtNum.Text = txtQte.Text = ""; 
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Colis cl = new Colis(txtNum.Text, dtpLiv.Value,
                              Convert.ToInt32(txtQte.Text),
                              (Produit)cbProds.SelectedItem);

            if(ContollerColis.AjouterColis(cl))
            {
                dgvColis.DataSource = ContollerColis.GetColis();
                cbProds.DataSource = ContollerColis.GetProduits();
                Viderchamps();
                MessageBox.Show("Colis est ajouté");
            }
            else
                MessageBox.Show("Quantité insuffisante du Colis");

        }
    }
}
