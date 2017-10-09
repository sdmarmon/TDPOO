namespace Exercice_1
{
    partial class formInscription
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.cbAnneeNaissance = new System.Windows.Forms.ComboBox();
            this.rbHomme = new System.Windows.Forms.RadioButton();
            this.rbFemme = new System.Windows.Forms.RadioButton();
            this.lbSexe = new System.Windows.Forms.Label();
            this.lbAnneeNaissance = new System.Windows.Forms.Label();
            this.lblRemarques = new System.Windows.Forms.Label();
            this.tbRemarques = new System.Windows.Forms.TextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cbCourriel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 35);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // tbNom
            // 
            this.tbNom.AccessibleDescription = "Entrez votre Nom";
            this.tbNom.Location = new System.Drawing.Point(144, 35);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(245, 20);
            this.tbNom.TabIndex = 1;
            this.tbNom.GotFocus += new System.EventHandler(tbNom_GotFocus);
            this.tbNom.LostFocus += new System.EventHandler(tbNom_LostFocus);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 75);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            this.lblPrenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPrenom
            // 
            this.tbPrenom.AccessibleDescription = "Entrez votre Prénom";
            this.tbPrenom.Location = new System.Drawing.Point(144, 68);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(245, 20);
            this.tbPrenom.TabIndex = 3;
            this.tbPrenom.GotFocus += new System.EventHandler(tbPrenom_GotFocus);
            this.tbPrenom.LostFocus += new System.EventHandler(tbPrenom_LostFocus);
            // 
            // cbAnneeNaissance
            // 
            this.cbAnneeNaissance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnneeNaissance.FormattingEnabled = true;
            this.cbAnneeNaissance.Location = new System.Drawing.Point(144, 156);
            this.cbAnneeNaissance.Name = "cbAnneeNaissance";
            this.cbAnneeNaissance.Size = new System.Drawing.Size(245, 21);
            this.cbAnneeNaissance.TabIndex = 4;
            this.cbAnneeNaissance.SelectedIndexChanged += new System.EventHandler(this.cbAnneeNaissance_SelectedIndexChanged);
            // 
            // rbHomme
            // 
            this.rbHomme.AutoSize = true;
            this.rbHomme.Location = new System.Drawing.Point(144, 114);
            this.rbHomme.Name = "rbHomme";
            this.rbHomme.Size = new System.Drawing.Size(34, 17);
            this.rbHomme.TabIndex = 5;
            this.rbHomme.TabStop = true;
            this.rbHomme.Text = "M";
            this.rbHomme.UseVisualStyleBackColor = true;
            // 
            // rbFemme
            // 
            this.rbFemme.AutoSize = true;
            this.rbFemme.Location = new System.Drawing.Point(220, 114);
            this.rbFemme.Name = "rbFemme";
            this.rbFemme.Size = new System.Drawing.Size(31, 17);
            this.rbFemme.TabIndex = 6;
            this.rbFemme.TabStop = true;
            this.rbFemme.Text = "F";
            this.rbFemme.UseVisualStyleBackColor = true;
            // 
            // lbSexe
            // 
            this.lbSexe.AutoSize = true;
            this.lbSexe.Location = new System.Drawing.Point(12, 118);
            this.lbSexe.Name = "lbSexe";
            this.lbSexe.Size = new System.Drawing.Size(37, 13);
            this.lbSexe.TabIndex = 7;
            this.lbSexe.Text = "Sexe :";
            // 
            // lbAnneeNaissance
            // 
            this.lbAnneeNaissance.AutoSize = true;
            this.lbAnneeNaissance.Location = new System.Drawing.Point(12, 156);
            this.lbAnneeNaissance.Name = "lbAnneeNaissance";
            this.lbAnneeNaissance.Size = new System.Drawing.Size(112, 13);
            this.lbAnneeNaissance.TabIndex = 8;
            this.lbAnneeNaissance.Text = "Année de Naissance :";
            // 
            // lblRemarques
            // 
            this.lblRemarques.AutoSize = true;
            this.lblRemarques.Location = new System.Drawing.Point(12, 264);
            this.lblRemarques.Name = "lblRemarques";
            this.lblRemarques.Size = new System.Drawing.Size(67, 13);
            this.lblRemarques.TabIndex = 9;
            this.lblRemarques.Text = "Remarques :";
            this.lblRemarques.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbRemarques
            // 
            this.tbRemarques.Location = new System.Drawing.Point(144, 264);
            this.tbRemarques.Multiline = true;
            this.tbRemarques.Name = "tbRemarques";
            this.tbRemarques.Size = new System.Drawing.Size(245, 144);
            this.tbRemarques.TabIndex = 10;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(15, 425);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 11;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(144, 425);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnReinitialiser.TabIndex = 12;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(btnReinitialiser_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(314, 425);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cbCourriel
            // 
            this.cbCourriel.AutoSize = true;
            this.cbCourriel.Checked = true;
            this.cbCourriel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCourriel.Location = new System.Drawing.Point(15, 211);
            this.cbCourriel.Name = "cbCourriel";
            this.cbCourriel.Size = new System.Drawing.Size(127, 17);
            this.cbCourriel.TabIndex = 14;
            this.cbCourriel.Text = "Recevoir les courriels";
            this.cbCourriel.UseVisualStyleBackColor = true;
            // 
            // formInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 475);
            this.Controls.Add(this.cbCourriel);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.tbRemarques);
            this.Controls.Add(this.lblRemarques);
            this.Controls.Add(this.lbAnneeNaissance);
            this.Controls.Add(this.lbSexe);
            this.Controls.Add(this.rbFemme);
            this.Controls.Add(this.rbHomme);
            this.Controls.Add(this.cbAnneeNaissance);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Name = "formInscription";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.ComboBox cbAnneeNaissance;
        private System.Windows.Forms.RadioButton rbHomme;
        private System.Windows.Forms.RadioButton rbFemme;
        private System.Windows.Forms.Label lbSexe;
        private System.Windows.Forms.Label lbAnneeNaissance;
        private System.Windows.Forms.Label lblRemarques;
        private System.Windows.Forms.TextBox tbRemarques;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.CheckBox cbCourriel;


    }
}

