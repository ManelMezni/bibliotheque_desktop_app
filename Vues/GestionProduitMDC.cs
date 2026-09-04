using DAO;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vues
{
    public partial class GestionProduitMDC : Form
    {
        public GestionProduitMDC()
        {
            InitializeComponent();
        }

        private void GestionProduitMDC_Load(object sender, EventArgs e)
        {
            dgvProduits.DataSource = VenteMDC.ChargerProduit();

            ///Linq
            var lesProds = from pd in VenteMDC.GetProduits()
                           where pd.Designation.Contains("DVD")
                           select new {pd.Designation,
                                       pd.Quantite,
                               PrixVente = pd.Prix * 1.2,
                                       };

            
            dgvProdsLinq.DataSource= lesProds.ToArray();


        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Voulez vous enregistrer", 
                                                 "att", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                VenteMDC.EnregistrerProduits();
            }
        }

        private void btnAJouterDAO_Click(object sender, EventArgs e)
        {Produit p =new Produit(txtRefernce.Text,
                                txtDesg.Text,
                                Convert.ToInt32(txtQuantite.Text),
                              Convert.ToDouble(txtPRix.Text));
            if (VenteMDC.GetProduits().Contains(p))
                MessageBox.Show("Produit existe déjà");
            else
            {
                dgvProduits.DataSource = VenteMDC.AjouterProduit(p);
                MessageBox.Show("Produit est ajouté ");
            }

        }

        private void btnChercherParPrix_Click(object sender, EventArgs e)
        {
            var prix=Convert.ToDouble( txtPRix.Text);
            var lesProds = from p in VenteMDC.GetProduits()
                           where p.Prix == prix
                           select new { Desg=p.Designation,
                                        Qte=p.Quantite
                                       };
            dgvProdsLinq.DataSource = lesProds.ToList();

        }

        private void btnChercherParPrixDT_Click(object sender, EventArgs e)
        {
            DataTable dt = VenteMDC.DsVente.Tables["TLProds"];
            double prix =Convert.ToDouble(txtPRix.Text);
            var lesProds = from ligne in dt.AsEnumerable()
                           where ligne.Field<float>(3)==prix
                           select new {Desg= ligne.Field<String>(1),
                                      Qte=ligne.Field<Int32>(2),
                                      PrixVente= ligne.Field<float>(3)*1.2
                                        };
            dgvProdLinqDT.DataSource= lesProds.ToList();
        }

        private void btnSuppressionRef_Click(object sender, EventArgs e)
        {
            dgvProduits.DataSource = VenteMDC.SupprimerProduit(txtRefernce.Text);

        }
    }
}
