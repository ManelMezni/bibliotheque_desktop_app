using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Ouvrage
    {
        [Key]
        public String ISBN { get; set; }
        public String Titre { get; set; }
        public virtual Auteur AuteurOuv { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Ouvrage ouvrage &&
                   ISBN == ouvrage.ISBN;
        }

        public override string ToString()
        {
            return Titre;
        }
    }
}
