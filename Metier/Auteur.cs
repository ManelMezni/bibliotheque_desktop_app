using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Auteur auteur &&
                   Id == auteur.Id;
        }

        public override string ToString()
        {
            return Nom+ " - "+Prenom;
        }
    }
}
