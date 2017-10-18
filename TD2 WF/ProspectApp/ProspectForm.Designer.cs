namespace ProspectApp
{
    partial class ProspectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDernierContact = new System.Windows.Forms.DateTimePicker();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDernierContact = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lvPropects = new System.Windows.Forms.ListView();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDernierContact
            // 
            this.dtpDernierContact.Location = new System.Drawing.Point(328, 194);
            this.dtpDernierContact.Name = "dtpDernierContact";
            this.dtpDernierContact.Size = new System.Drawing.Size(231, 22);
            this.dtpDernierContact.TabIndex = 22;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(328, 241);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(231, 170);
            this.rtbNotes.TabIndex = 21;
            this.rtbNotes.Text = "";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(328, 148);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(231, 22);
            this.tbCourriel.TabIndex = 20;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(243, 241);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 17);
            this.lblNotes.TabIndex = 19;
            this.lblNotes.Text = "Notes :";
            // 
            // lblDernierContact
            // 
            this.lblDernierContact.AutoSize = true;
            this.lblDernierContact.Location = new System.Drawing.Point(181, 194);
            this.lblDernierContact.Name = "lblDernierContact";
            this.lblDernierContact.Size = new System.Drawing.Size(115, 17);
            this.lblDernierContact.TabIndex = 18;
            this.lblDernierContact.Text = "Dernier Contact :";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(231, 148);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(65, 17);
            this.lblCourriel.TabIndex = 17;
            this.lblCourriel.Text = "Courriel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(231, 90);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 16;
            this.lblPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(328, 90);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(231, 22);
            this.tbPrenom.TabIndex = 15;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(328, 34);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(231, 22);
            this.tbNom.TabIndex = 14;
            // 
            // lvPropects
            // 
            this.lvPropects.Location = new System.Drawing.Point(12, 12);
            this.lvPropects.Name = "lvPropects";
            this.lvPropects.Size = new System.Drawing.Size(167, 399);
            this.lvPropects.TabIndex = 13;
            this.lvPropects.UseCompatibleStateImageBehavior = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(251, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(483, 452);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ProspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 495);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpDernierContact);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDernierContact);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lvPropects);
            this.Controls.Add(this.lblNom);
            this.Name = "ProspectForm";
            this.Text = "Ajout d\'un Prospect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDernierContact;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDernierContact;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ListView lvPropects;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnOk;
    }
}