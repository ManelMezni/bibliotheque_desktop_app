using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Metier;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAO
{
    public class ProduitDAO
    {

        public static List<Produit>FindAll()
        {List<Produit> lesProduits = new List<Produit>();
            try
            {
                SqlConnection cnx = ConnexionVente.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from tproduit", cnx);

              SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Produit p = new Produit(dr.GetString(0), dr.GetString(1),
                                            dr.GetInt32(2),dr.GetFloat(3));
                    lesProduits.Add(p);

                }
                cnx.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show("Att Pb Find All " + ex.Message);
            }



            return lesProduits;
        }

        public static void Add(Produit p)
        {  try
            {
                //String url = "Server=localhost\\SQLEXPRESS; 		Database=BDCom2026Gr5; Trusted_Connection=True;";
                SqlConnection cnx = ConnexionVente.GetInstance();
                //new SqlConnection(url);
                // cnx.Open();
                String reqSQL = "insert into tproduit values (@reference, @desig, @qt, @prix )";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@reference", p.Reference);
                cmd.Parameters.Add("@desig", p.Designation);
                cmd.Parameters.Add("@qt", p.Quantite);
                cmd.Parameters.Add("@prix", p.Prix);


                int nbLigne = cmd.ExecuteNonQuery();
                if (nbLigne != 0)
                    MessageBox.Show("Produit est ajouté ");
                cnx.Close();
                // MessageBox.Show("Le premier produit est ajoué");


            }
            catch (SqlException ex)
            {
                
                    MessageBox.Show("L’erreur dans l’ajout " + ex.Message);
            }
        }

        public static void Update(Produit p)
        {
            try
            {
                SqlConnection cnx = ConnexionVente.GetInstance();
                String reqSQL = "update tproduit set quantite=@qt where reference=@refer";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@refer", p.Reference);
                cmd.Parameters.Add("@qt", p.Quantite);


                int nbLigne = cmd.ExecuteNonQuery();
                if (nbLigne != 0)
                    MessageBox.Show("Produit est MAJ ");
                cnx.Close();
                // MessageBox.Show("Le premier produit est ajoué");


            }
            catch (SqlException ex)
            {

                MessageBox.Show("L’erreur dans l’ajout " + ex.Message);
            }
        }
    }
}
