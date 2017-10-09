using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_1
{
    public partial class formInscription : Form
    {
        public formInscription()
        {
            InitializeComponent();

            // Remplissage de cbAnneeNaissance
            for (int i = int.Parse(DateTime.Now.Year.ToString()); i >= 1900 ; i--)
            {
                this.cbAnneeNaissance.Items.Add(i);
            }
            tbNom.ForeColor = Color.Gray;
            tbPrenom.ForeColor = Color.Gray;
            tbNom.Text = "Entrez votre Nom";
            tbPrenom.Text = "Entrez votre Prenom";
            cbAnneeNaissance.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void cbAnneeNaissance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(tbNom.Text)) || (String.IsNullOrWhiteSpace(tbPrenom.Text)) || (cbAnneeNaissance.SelectedItem == null))
                MessageBox.Show("Veuillez remplir les champs Nom, Prénom et Année de naissance pour continuer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                MessageBox.Show(tbNom.Text + " , sexe , né en " + cbAnneeNaissance.SelectedItem + "\nRecevoir courriels : \nRemarques : " + tbRemarques.Text, "Récapitulatif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbNom_GotFocus(object sender, EventArgs e)
        {
            tbNom.ForeColor = Color.Black;
            if (tbNom.Text == "Entrez votre Nom")
            {
                tbNom.Text = "";
            }
        }

        private void tbNom_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNom.Text))
            {
                tbNom.ForeColor = Color.Gray;
                tbNom.Text = "Entrez votre Nom";
            }
        }

        private void tbPrenom_GotFocus(object sender, EventArgs e)
        {
            tbPrenom.ForeColor = Color.Black;
            if (tbPrenom.Text == "Entrez votre Prenom")
            {
                tbPrenom.Text = "";
            }
        }

        private void tbPrenom_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPrenom.Text))
            {
                tbPrenom.ForeColor = Color.Gray;
                tbPrenom.Text = "Entrez votre Prenom";
            }
        }
    }
}
