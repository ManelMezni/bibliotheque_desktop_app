using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Metier;
using DAO;
namespace Controller
{
    public class ContollerColis
    {
        static List<Produit> lesProduits;
        static List<Colis> lesColis;
        public static List<Produit>GetProduits()
        {
            if(lesProduits==null)
            {
                lesProduits = ProduitDAO.FindAll();
            }
            return lesProduits;
        }
        public static List<Colis>GetColis()
        {if(lesColis==null)
                lesColis= ColisDAO.FindAll();
        return lesColis;
        }

        public static bool AjouterColis(Colis cl)
        {
            if(cl.QteCol< cl.ProduitCol.Quantite)
            {
                ColisDAO.Add(cl);
                cl.ProduitCol.Quantite -= cl.QteCol;
                ProduitDAO.Update(cl.ProduitCol);
                lesColis = ColisDAO.FindAll();
                lesProduits = ProduitDAO.FindAll();
                return true;
            }

            return false;

        }


    }
}
