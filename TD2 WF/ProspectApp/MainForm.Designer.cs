namespace ProspectApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lvProspects = new System.Windows.Forms.ListView();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.lblDernierContact = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.dtpDernierContact = new System.Windows.Forms.DateTimePicker();
            this.btnPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(251, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvProspects
            // 
            this.lvProspects.Location = new System.Drawing.Point(12, 12);
            this.lvProspects.Name = "lvProspects";
            this.lvProspects.Size = new System.Drawing.Size(167, 399);
            this.lvProspects.TabIndex = 1;
            this.lvProspects.UseCompatibleStateImageBehavior = false;
            this.lvProspects.SelectedIndexChanged += new System.EventHandler(this.lvPropects_SelectedIndexChanged);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(328, 34);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(231, 22);
            this.tbNom.TabIndex = 2;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(328, 90);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.ReadOnly = true;
            this.tbPrenom.Size = new System.Drawing.Size(231, 22);
            this.tbPrenom.TabIndex = 3;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(231, 90);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom :";
            this.lblPrenom.Click += new System.EventHandler(this.lblPrenom_Click);
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(231, 148);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(65, 17);
            this.lblCourriel.TabIndex = 5;
            this.lblCourriel.Text = "Courriel :";
            this.lblCourriel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDernierContact
            // 
            this.lblDernierContact.AutoSize = true;
            this.lblDernierContact.Location = new System.Drawing.Point(181, 194);
            this.lblDernierContact.Name = "lblDernierContact";
            this.lblDernierContact.Size = new System.Drawing.Size(115, 17);
            this.lblDernierContact.TabIndex = 6;
            this.lblDernierContact.Text = "Dernier Contact :";
            this.lblDernierContact.Click += new System.EventHandler(this.lblDernierContact_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(243, 241);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 17);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notes :";
            this.lblNotes.Click += new System.EventHandler(this.lblNotes_Click);
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(328, 148);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.ReadOnly = true;
            this.tbCourriel.Size = new System.Drawing.Size(231, 22);
            this.tbCourriel.TabIndex = 8;
            this.tbCourriel.TextChanged += new System.EventHandler(this.tbCourriel_TextChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(328, 241);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ReadOnly = true;
            this.rtbNotes.Size = new System.Drawing.Size(231, 170);
            this.rtbNotes.TabIndex = 10;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // dtpDernierContact
            // 
            this.dtpDernierContact.Enabled = false;
            this.dtpDernierContact.Location = new System.Drawing.Point(328, 194);
            this.dtpDernierContact.Name = "dtpDernierContact";
            this.dtpDernierContact.Size = new System.Drawing.Size(231, 22);
            this.dtpDernierContact.TabIndex = 11;
            this.dtpDernierContact.ValueChanged += new System.EventHandler(this.dtpDernierContact_ValueChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(184, 427);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 27);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 466);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.dtpDernierContact);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDernierContact);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lvProspects);
            this.Controls.Add(this.lblNom);
            this.Name = "MainForm";
            this.Text = "Gestion des Prospects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnPlus_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ListView lvProspects;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblDernierContact;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.DateTimePicker dtpDernierContact;
        private System.Windows.Forms.Button btnPlus;
    }
}

