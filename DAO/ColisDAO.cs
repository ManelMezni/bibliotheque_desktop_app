using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Metier;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAO
{
    public class ColisDAO
    {
        public static List<Colis> FindAll()
        {
            List<Colis> lesColis = new List<Colis>();
            List<Produit>lesProduits=ProduitDAO.FindAll();

            try
            {
                SqlConnection cnx = ConnexionVente.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from tcolis", cnx);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produit prod = null;
                    foreach (Produit pp in lesProduits)
                        if (pp.Reference.Equals(dr.GetString(3)))
                        {  prod = pp;
                            break;
                        }
                    Colis cl = new Colis(dr.GetString(0), dr.GetDateTime(1),
                        dr.GetInt32(2), prod);
                    lesColis.Add(cl);

                }
                cnx.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Att Colis Pb Find All " + ex.Message);
            }

            return lesColis;
        }

        public static bool Add(Colis col)
        {
            try
            {
                //String url = "Server=localhost\\SQLEXPRESS; 		Database=BDCom2026Gr5; Trusted_Connection=True;";
                SqlConnection cnx = ConnexionVente.GetInstance();
                //new SqlConnection(url);
                // cnx.Open();
                String reqSQL = "insert into tcolis values (@num, @date, @qt, @refProd )";
                SqlCommand cmd = new SqlCommand(reqSQL, cnx);
                cmd.Parameters.Add("@num", col.Numero);
                cmd.Parameters.Add("@date", col.DateLiv);
                cmd.Parameters.Add("@qt", col.QteCol);
                cmd.Parameters.Add("@refProd", col.ProduitCol.Reference);


                int nbLigne = cmd.ExecuteNonQuery();
                if (nbLigne != 0)
                {
                    MessageBox.Show("Produit est ajouté ");
                    return true;
                }
                cnx.Close();
                // MessageBox.Show("Le premier produit est ajoué");


            }
            catch (SqlException ex)
            {   MessageBox.Show("L’erreur dans l’ajout " + ex.Message);
            }
            return false;
        }

    }
}
