using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using Metier;
namespace Vues
{
    public partial class GestionProduits : Form
    {
        public GestionProduits()
        {
            InitializeComponent();
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            dgvProduits.DataSource = ProduitDAO.FindAll();

        }

        private void btnAjouterProdConstant_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = ConnexionVente.GetInstance(); 

     String reqSQL = "insert into tproduit values ('55555', 'Imprimante', '5', '1000' )";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.ExecuteNonQuery();

                cnx.Close();
                MessageBox.Show("Le premier produit est ajoué");


            }
            catch (SqlException ex)
            {
                {
                    MessageBox.Show("L’erreur dans l’ajout " + ex.Message);
                }

            }
        }

        private void btnAjouterProdReel_Click(object sender, EventArgs e)
        {
            try
            {
                //String url = "Server=localhost\\SQLEXPRESS; 		Database=BDCom2026Gr5; Trusted_Connection=True;";
                SqlConnection cnx = ConnexionVente.GetInstance();
                //new SqlConnection(url);
               // cnx.Open();
                String reqSQL = "insert into tproduit values (@reference, @desig, @qt, @prix )";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@reference", txtRefernce.Text);
                cmd.Parameters.Add("@desig", txtDesg.Text);
                cmd.Parameters.Add("@qt",Convert.ToInt32( txtQuantite.Text));
                cmd.Parameters.Add("@prix", Convert.ToDouble(txtPRix.Text));


                int nbLigne=cmd.ExecuteNonQuery();
                if (nbLigne != 0)
                    MessageBox.Show("Produit est ajouté ");
                cnx.Close();
               // MessageBox.Show("Le premier produit est ajoué");


            }
            catch (SqlException ex)
            {
                {
                    MessageBox.Show("L’erreur dans l’ajout " + ex.Message);
                }

            }
        }
        private void viderChamps()
        {
            txtRefernce.Text = txtDesg.Text = txtQuantite.Text = txtPRix.Text = "";
        }
        private void btnAJouterDAO_Click(object sender, EventArgs e)
        {
            Produit p = new Produit(txtRefernce.Text, txtDesg.Text,
                                Convert.ToInt32(txtQuantite.Text),
                                Convert.ToDouble(txtPRix.Text));
            if (ProduitDAO.FindAll().Contains(p) == true)
                MessageBox.Show("Att produit existe déjà");
            else
            {
                ProduitDAO.Add(p);
                dgvProduits.DataSource = ProduitDAO.FindAll();
                viderChamps();
            
            }
        }
    }
}
