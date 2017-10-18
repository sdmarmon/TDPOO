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
    public partial class ProspectForm : Form
    {
        public ProspectForm(IProspectRepository prospectRepository)
        {
            InitializeComponent();
            prospects = prospectRepository;
        }

        public IProspectRepository prospects;

        private void btnOk_Click(object sender, EventArgs e)
        {
            Prospect prospect = new Prospect(tbNom.Text, tbPrenom.Text, tbCourriel.Text, dtpDernierContact.Value);
            prospects.Add(prospect);
            this.Close();
        }
    }
}
