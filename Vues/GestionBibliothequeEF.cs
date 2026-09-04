using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vues
{
    public partial class GestionBibliothequeEF : Form
    {
        public GestionBibliothequeEF()
        {
            InitializeComponent();
        }

        private void GestionBibliothequeEF_Load(object sender, EventArgs e)
        {
            using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
            {
                /* Auteur a = new Auteur { Nom = "Khem", Prenom = "Aida" };
                 Auteur a2 = new Auteur { Id=3,Nom = "Khem", Prenom = "Aida" };


                 db.LesAuteurs.Add(a);
                 db.LesAuteurs.Add(a2);

                 Ouvrage ov = new Ouvrage { ISBN = "Liv22222", Titre = "Langage C#", AuteurOuv = a };
                 db.LesOuvrages.Add(ov); 

                 db.SaveChanges();
                */
                dgvAuteurs.DataSource = db.LesAuteurs.ToArray();
                dgvAuteurs.Refresh();

            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
            {
                var auts = from a in db.LesAuteurs
                           where a.Nom.Equals(txtNom.Text) &&
                           a.Prenom.Equals(txtPrenom.Text)
                           select a;
                if (auts.Count() != 0)
                    MessageBox.Show("Auteur existe déjà");
                else
                {
                    Auteur aut = new Auteur { Nom = txtNom.Text, Prenom = txtPrenom.Text };
                    db.LesAuteurs.Add(aut);
                    db.SaveChanges();
                    dgvAuteurs.DataSource = db.LesAuteurs.ToArray();
                }


            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
            {
                Auteur aut = db.LesAuteurs.Find(Convert.ToInt32(txtId.Text));

                if (aut == null)
                    MessageBox.Show("Auteur n'existe pas");
                else
                {
                    aut.Nom = txtNom.Text;
                    aut.Prenom = txtPrenom.Text;
                    db.LesAuteurs.AddOrUpdate(aut);
                    db.SaveChanges();
                    dgvAuteurs.DataSource = db.LesAuteurs.ToArray();
                    MessageBox.Show("Auteur est modifié ");
                }
            }


        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Voulez vous sup", "Att", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {

                using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
                {
                    Auteur aut = db.LesAuteurs.Find(Convert.ToInt32(txtId.Text));
                    if (aut == null)
                        MessageBox.Show("Auteur n'existe pas");
                    else
                    {
                        var ouvs = db.LesOuvrages.Where(ov => ov.AuteurOuv.Id.Equals(aut.Id));
                        if (ouvs.Count() != 0)
                            MessageBox.Show("On ne peut sup l'auteur car il a des ouvrages");
                        else
                        {
                            db.LesAuteurs.Remove(aut);
                            db.SaveChanges();
                            dgvAuteurs.DataSource = db.LesAuteurs.ToArray();
                            MessageBox.Show("Auteur est supprimé ");
                        }
                    }
                }
            }
        }
    }
}