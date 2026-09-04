using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Colis
    {
        private String numero;
        private DateTime dateLiv ;
        private int qteCol;
        private Produit produitCol;

        public Colis(string numero, DateTime dateLiv, int qteCol, Produit produitCol)
        {
            this.numero = numero;
            this.dateLiv = dateLiv;
            this.qteCol = qteCol;
            this.produitCol = produitCol;
        }

        public string Numero { get => numero; set => numero = value; }
        public DateTime DateLiv { get => dateLiv; set => dateLiv = value; }
        public int QteCol { get => qteCol; set => qteCol = value; }
        public Produit ProduitCol { get => produitCol; set => produitCol = value; }

        public override bool Equals(object obj)
        {
            return obj is Colis colis &&
                   numero == colis.numero;
        }

        public override string ToString()
        {
            return numero+" "+dateLiv.ToShortDateString()+produitCol.Designation;
        }
    }
}
