namespace UCGestionPompier
{
    partial class UCgestionPompier
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCgestionPompier));
            this.grpEste = new System.Windows.Forms.GroupBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblFiche = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNumMatricule = new System.Windows.Forms.Label();
            this.picGrade = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNaissance = new System.Windows.Forms.TextBox();
            this.txtDateEmbauche = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lbHabilitions = new System.Windows.Forms.ListBox();
            this.lblConger = new System.Windows.Forms.Label();
            this.lbAncienneAffectation = new System.Windows.Forms.ListBox();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnConfirmerModif = new System.Windows.Forms.Button();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.chklstHabilitations = new System.Windows.Forms.CheckedListBox();
            this.grpEste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEste
            // 
            this.grpEste.Controls.Add(this.btnModif);
            this.grpEste.Controls.Add(this.btnLogin);
            this.grpEste.Controls.Add(this.cboPompier);
            this.grpEste.Controls.Add(this.cboCaserne);
            this.grpEste.Location = new System.Drawing.Point(-32, -19);
            this.grpEste.Name = "grpEste";
            this.grpEste.Size = new System.Drawing.Size(1140, 95);
            this.grpEste.TabIndex = 0;
            this.grpEste.TabStop = false;
            this.grpEste.Text = "groupBox1";
            // 
            // btnModif
            // 
            this.btnModif.AutoSize = true;
            this.btnModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(760, 39);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(198, 31);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Ajouter pompier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Visible = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(760, 39);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Connexion Admin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPompier
            // 
            this.cboPompier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(429, 41);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(280, 29);
            this.cboPompier.TabIndex = 1;
            this.cboPompier.SelectedIndexChanged += new System.EventHandler(this.cboPompier_SelectedIndexChanged);
            this.cboPompier.SelectionChangeCommitted += new System.EventHandler(this.cboPompier_SelectionChangeCommitted);
            this.cboPompier.SelectedValueChanged += new System.EventHandler(this.cboPompier_SelectedValueChanged);
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(94, 41);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(280, 29);
            this.cboCaserne.TabIndex = 0;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            this.cboCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboCaserne_SelectionChangeCommitted);
            // 
            // lblFiche
            // 
            this.lblFiche.AutoSize = true;
            this.lblFiche.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiche.Location = new System.Drawing.Point(85, 103);
            this.lblFiche.Name = "lblFiche";
            this.lblFiche.Size = new System.Drawing.Size(153, 30);
            this.lblFiche.TabIndex = 1;
            this.lblFiche.Text = "Fiche pompier";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(85, 147);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(104, 25);
            this.lblMatricule.TabIndex = 2;
            this.lblMatricule.Text = "Matricule :";
            this.lblMatricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumMatricule
            // 
            this.lblNumMatricule.AutoSize = true;
            this.lblNumMatricule.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMatricule.Location = new System.Drawing.Point(183, 147);
            this.lblNumMatricule.Name = "lblNumMatricule";
            this.lblNumMatricule.Size = new System.Drawing.Size(53, 25);
            this.lblNumMatricule.TabIndex = 3;
            this.lblNumMatricule.Text = "3108";
            this.lblNumMatricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGrade
            // 
            this.picGrade.Location = new System.Drawing.Point(90, 175);
            this.picGrade.Name = "picGrade";
            this.picGrade.Size = new System.Drawing.Size(146, 146);
            this.picGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrade.TabIndex = 4;
            this.picGrade.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNom.Location = new System.Drawing.Point(285, 175);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(288, 33);
            this.txtNom.TabIndex = 5;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPrenom.Location = new System.Drawing.Point(625, 175);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(288, 33);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNaissance
            // 
            this.txtNaissance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNaissance.Location = new System.Drawing.Point(285, 231);
            this.txtNaissance.Name = "txtNaissance";
            this.txtNaissance.ReadOnly = true;
            this.txtNaissance.Size = new System.Drawing.Size(288, 33);
            this.txtNaissance.TabIndex = 7;
            this.txtNaissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateEmbauche
            // 
            this.txtDateEmbauche.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDateEmbauche.Location = new System.Drawing.Point(625, 231);
            this.txtDateEmbauche.Name = "txtDateEmbauche";
            this.txtDateEmbauche.ReadOnly = true;
            this.txtDateEmbauche.Size = new System.Drawing.Size(288, 33);
            this.txtDateEmbauche.TabIndex = 8;
            this.txtDateEmbauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTel.Location = new System.Drawing.Point(285, 288);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(288, 33);
            this.txtTel.TabIndex = 9;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBip
            // 
            this.txtBip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBip.Location = new System.Drawing.Point(625, 288);
            this.txtBip.Name = "txtBip";
            this.txtBip.ReadOnly = true;
            this.txtBip.Size = new System.Drawing.Size(288, 33);
            this.txtBip.TabIndex = 10;
            this.txtBip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chklstHabilitations);
            this.grpInfo.Controls.Add(this.lbHabilitions);
            this.grpInfo.Controls.Add(this.lblConger);
            this.grpInfo.Controls.Add(this.lbAncienneAffectation);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Location = new System.Drawing.Point(285, 347);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(641, 212);
            this.grpInfo.TabIndex = 11;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations carrière";
            // 
            // lbHabilitions
            // 
            this.lbHabilitions.BackColor = System.Drawing.Color.FloralWhite;
            this.lbHabilitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHabilitions.FormattingEnabled = true;
            this.lbHabilitions.ItemHeight = 25;
            this.lbHabilitions.Location = new System.Drawing.Point(17, 113);
            this.lbHabilitions.Name = "lbHabilitions";
            this.lbHabilitions.Size = new System.Drawing.Size(601, 77);
            this.lbHabilitions.TabIndex = 2;
            // 
            // lblConger
            // 
            this.lblConger.AutoSize = true;
            this.lblConger.Location = new System.Drawing.Point(438, 45);
            this.lblConger.Name = "lblConger";
            this.lblConger.Size = new System.Drawing.Size(142, 25);
            this.lblConger.TabIndex = 1;
            this.lblConger.Text = "EnCongé/dispo";
            // 
            // lbAncienneAffectation
            // 
            this.lbAncienneAffectation.BackColor = System.Drawing.Color.FloralWhite;
            this.lbAncienneAffectation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAncienneAffectation.FormattingEnabled = true;
            this.lbAncienneAffectation.ItemHeight = 25;
            this.lbAncienneAffectation.Location = new System.Drawing.Point(17, 45);
            this.lbAncienneAffectation.Name = "lbAncienneAffectation";
            this.lbAncienneAffectation.Size = new System.Drawing.Size(318, 50);
            this.lbAncienneAffectation.TabIndex = 0;
            // 
            // pnlLog
            // 
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Location = new System.Drawing.Point(342, 215);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(375, 227);
            this.pnlLog.TabIndex = 12;
            this.pnlLog.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(717, 103);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(196, 63);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // btnConfirmerModif
            // 
            this.btnConfirmerModif.AutoSize = true;
            this.btnConfirmerModif.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerModif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmerModif.ForeColor = System.Drawing.Color.White;
            this.btnConfirmerModif.Location = new System.Drawing.Point(728, 588);
            this.btnConfirmerModif.Name = "btnConfirmerModif";
            this.btnConfirmerModif.Size = new System.Drawing.Size(198, 31);
            this.btnConfirmerModif.TabIndex = 4;
            this.btnConfirmerModif.Text = "Confirmer modifications";
            this.btnConfirmerModif.UseVisualStyleBackColor = false;
            this.btnConfirmerModif.Visible = false;
            // 
            // cboGrade
            // 
            this.cboGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(90, 366);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(146, 33);
            this.cboGrade.TabIndex = 15;
            this.cboGrade.Visible = false;
            this.cboGrade.SelectionChangeCommitted += new System.EventHandler(this.cboGrade_SelectionChangeCommitted);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtGrade.Location = new System.Drawing.Point(90, 327);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(146, 33);
            this.txtGrade.TabIndex = 16;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chklstHabilitations
            // 
            this.chklstHabilitations.BackColor = System.Drawing.Color.FloralWhite;
            this.chklstHabilitations.FormattingEnabled = true;
            this.chklstHabilitations.Location = new System.Drawing.Point(17, 113);
            this.chklstHabilitations.Name = "chklstHabilitations";
            this.chklstHabilitations.Size = new System.Drawing.Size(601, 88);
            this.chklstHabilitations.TabIndex = 3;
            // 
            // UCgestionPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.btnConfirmerModif);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.txtBip);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDateEmbauche);
            this.Controls.Add(this.txtNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.picGrade);
            this.Controls.Add(this.lblNumMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblFiche);
            this.Controls.Add(this.grpEste);
            this.Name = "UCgestionPompier";
            this.Size = new System.Drawing.Size(1000, 649);
            this.Load += new System.EventHandler(this.UCgestionPompier_Load);
            this.grpEste.ResumeLayout(false);
            this.grpEste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrade)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEste;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.Label lblFiche;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNumMatricule;
        private System.Windows.Forms.PictureBox picGrade;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNaissance;
        private System.Windows.Forms.TextBox txtDateEmbauche;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ListBox lbAncienneAffectation;
        private System.Windows.Forms.Label lblConger;
        private System.Windows.Forms.ListBox lbHabilitions;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnConfirmerModif;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.CheckedListBox chklstHabilitations;
    }
}
