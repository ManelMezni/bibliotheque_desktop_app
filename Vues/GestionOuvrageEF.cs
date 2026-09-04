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
    public partial class GestionOuvrageEF : Form
    {
        public GestionOuvrageEF()
        {
            InitializeComponent();
        }

        private void GestionOuvrageEF_Load(object sender, EventArgs e)
        {
            using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
            {
                dgvOuvrages.DataSource = null;
                dgvOuvrages.DataSource = db.LesOuvrages.ToList();
                cbAuteurs.Items.Clear();
                cbAuteurs.Items.AddRange(db.LesAuteurs.ToArray());

                foreach (Ouvrage o in db.LesOuvrages.ToList())
                {
                    dgvN.Rows.Add(
                        o.ISBN,
                        o.Titre,
                        o.AuteurOuv.Nom
                    );
                }

            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
            {
                Ouvrage ovRech = db.LesOuvrages.Find(txtISBN.Text);
                Auteur idAuteur = (Auteur)cbAuteurs.SelectedItem;
                Auteur auteur = db.LesAuteurs.Find(idAuteur.Id);

                if (ovRech != null)
                    MessageBox.Show("Ouvrage existe déjà");
                else
                {
                    Ouvrage ouvNov = new Ouvrage
                    {
                        ISBN = txtISBN.Text,
                        Titre = txtTitre.Text,
                        AuteurOuv = auteur
                    };

                    db.LesOuvrages.Add(ouvNov);
                    db.SaveChanges();
                    dgvOuvrages.DataSource = db.LesOuvrages.ToArray();
                    dgvOuvrages.Refresh();
                    dgvN.Rows.Clear();
                    foreach (Ouvrage o in db.LesOuvrages.ToList())
                    {
                        dgvN.Rows.Add(
                            o.ISBN,
                            o.Titre,
                            o.AuteurOuv.Nom
                        );
                    }


                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show("Voulez vous modif", "Att", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {

                using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
                {
                    Ouvrage o = db.LesOuvrages.Find(txtISBN.Text);

                    if (o == null)
                        MessageBox.Show("ouvrage n'existe pas");
                    else
                    {
                        o.Titre = txtTitre.Text;
                        o.AuteurOuv = (Auteur)cbAuteurs.SelectedItem;
                        // ou o.AuteurOuv = db.LesAuteurs.Find((Auteur)cbAuteurs.SelectedItem.Id);

                        db.LesOuvrages.AddOrUpdate(o);
                        db.SaveChanges();
                        dgvOuvrages.DataSource = db.LesOuvrages.ToArray();
                        MessageBox.Show("ouvrage est modifié ");
                    }
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
                    Ouvrage o = db.LesOuvrages.Find(txtISBN.Text);

                    if (o == null)
                        MessageBox.Show("ouvrage n'existe pas");
                    else
                    {

                        db.LesOuvrages.Remove(o);
                        db.SaveChanges();
                        dgvOuvrages.DataSource = db.LesOuvrages.ToArray();
                        MessageBox.Show("ouvrage est supprimé ");

                    }
                }
            }
        }


        private void sup_Click(object sender, EventArgs e)
        {
            if (dgvOuvrages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
                return;
            }

            DialogResult choix = MessageBox.Show("Voulez-vous supprimer ?", "Att", MessageBoxButtons.YesNo);

            if (choix == DialogResult.Yes)
            {
                using (MDBibliothequeGr5 db = new MDBibliothequeGr5())
                {
                    // Récupérer ISBN depuis la ligne sélectionnée
                    string isbn = dgvOuvrages.SelectedRows[0].Cells["ISBN"].Value.ToString();

                    Ouvrage o = db.LesOuvrages.Find(isbn);

                    if (o == null)
                    {
                        MessageBox.Show("Ouvrage n'existe pas");
                    }
                    else
                    {
                        db.LesOuvrages.Remove(o);
                        db.SaveChanges();

                        // Rafraîchir le DataGridView
                        dgvOuvrages.DataSource = db.LesOuvrages.ToList();

                        MessageBox.Show("Ouvrage est supprimé");
                    }
                }
            }
        }
    }
    }

