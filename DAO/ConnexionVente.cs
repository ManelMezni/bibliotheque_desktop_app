using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAO
{
    public class ConnexionVente
    {
        static String url = "Server=localhost\\SQLEXPRESS; 		Database=BDCom2026Gr5; Trusted_Connection=True;";
        static SqlConnection cnx = new SqlConnection(url);

        public static SqlConnection GetInstance()
        {  try
            {
                if (cnx != null && cnx.State == System.Data.ConnectionState.Closed)
                    cnx.Open();
            }
            catch (SqlException ex)
            { MessageBox.Show("Att Probleme de Connexion ***  : "+ex.Message);
            }
                return cnx;
        }
    }
}
