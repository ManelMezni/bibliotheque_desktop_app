using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Produit
    {
        private String reference;
        private String designation;
        private int quantite;
        private double prix;

        public Produit(string reference, string designation, int quantite, double prix)
        {
            this.reference = reference;
            this.designation = designation;
            this.quantite = quantite;
            this.prix = prix;
        }

        public Produit()
        {
        }

        [Key]
        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double Prix { get => prix; set => prix = value; }

        public override string ToString()
        {
            return Reference + " "+designation+ " : "+quantite;
        }

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   reference == produit.reference;
        }
    }
}
