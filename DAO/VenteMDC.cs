using Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAO
{
    public class VenteMDC
    {
        public static DataSet DsVente=new DataSet();//BD Locale 
        public static DataTable SupprimerProduit(String reference)
        {
            DataTable table = DsVente.Tables["TLProds"];
            foreach (DataRow dr in table.Rows)
            {if(dr.Field<String>(0).Equals(reference))
                {
                    dr.Delete();
                    break;
                }    
            }

            return table;
        }

        public static List<Produit>GetProduits()
        {
            List<Produit>lesProduits=new List<Produit>();
            DataTable dt = DsVente.Tables["TLProds"];
            if (dt == null)
                dt = ChargerProduit();
            foreach (DataRow dr in dt.Rows)
            {
                Produit p = new Produit(dr.Field<String>(0),
                                      dr.Field<String>(1),
                                       dr.Field<Int32>(2),
                                       dr.Field<float>(3));

                lesProduits.Add(p);
            }

            return lesProduits;
        }

        public static DataTable AjouterProduit(Produit p)
        {
            DataTable dt = DsVente.Tables["TLProds"];
            DataRow dr=dt.NewRow();
            dr[0] = p.Reference;
            dr[1] = p.Designation;
            dr[2] = p.Quantite;
            dr[3] = p.Prix;
            dt.Rows.Add(dr);

            return dt;
        }


        public static bool EnregistrerProduits()
        {
            SqlConnection cnx = ConnexionVente.GetInstance();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tproduit", cnx);
                // da.Fill(DsVente, "TLProds");
                SqlCommandBuilder cmdB=new SqlCommandBuilder(da);//génerer les Requettes de MAJ
               int nbLg= da.Update(DsVente, "TLProds");
                cnx.Close();
                if(nbLg!=0)
                    return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Pb d'enregistrement Produit " + ex.Message);
            }

            return false;
        }
       public static DataTable ChargerProduit()
        {
            DataTable dtProds = null;
            SqlConnection cnx = ConnexionVente.GetInstance();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tproduit", cnx);
                da.Fill(DsVente, "TLProds");
                cnx.Close();
                dtProds = DsVente.Tables["TLProds"];

            }catch(SqlException ex)
            { MessageBox.Show("Pb de chargment Produit "+ex.Message);
            }

        return dtProds;
        }




    }
}
