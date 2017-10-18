using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace ProspectApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public IProspectRepository prospects;

        public MainForm(IProspectRepository prospectRepository)
        {
            InitializeComponent();
            prospects = prospectRepository;
            foreach (Prospect prospect in prospectRepository.GetAll())
            {
                lvProspects.Items.Add(prospect.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ProspectForm prospectform = new ProspectForm(prospects);
            prospectform.Show();
        }

        private void tbCourriel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDernierContact_Click(object sender, EventArgs e)
        {

        }

        private void dtpDernierContact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvPropects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
