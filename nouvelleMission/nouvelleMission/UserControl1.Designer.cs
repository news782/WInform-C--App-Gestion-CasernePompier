namespace nouvelleMission
{
    partial class UCnouvelleMission
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
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDeclenchéLe = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresseSinistre = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNature = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConstituer = new System.Windows.Forms.Button();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMission.ForeColor = System.Drawing.Color.White;
            this.lblMission.Location = new System.Drawing.Point(75, 27);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(104, 25);
            this.lblMission.TabIndex = 0;
            this.lblMission.Text = "Mission n°";
            this.lblMission.Click += new System.EventHandler(this.lblMission_Click);
            // 
            // lblDeclenchéLe
            // 
            this.lblDeclenchéLe.AutoSize = true;
            this.lblDeclenchéLe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDeclenchéLe.ForeColor = System.Drawing.Color.White;
            this.lblDeclenchéLe.Location = new System.Drawing.Point(380, 27);
            this.lblDeclenchéLe.Name = "lblDeclenchéLe";
            this.lblDeclenchéLe.Size = new System.Drawing.Size(142, 25);
            this.lblDeclenchéLe.TabIndex = 2;
            this.lblDeclenchéLe.Text = "Déclenchée le :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(529, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "2025-12-05 16:00";
            // 
            // lblAdresseSinistre
            // 
            this.lblAdresseSinistre.AutoSize = true;
            this.lblAdresseSinistre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAdresseSinistre.ForeColor = System.Drawing.Color.White;
            this.lblAdresseSinistre.Location = new System.Drawing.Point(454, 83);
            this.lblAdresseSinistre.Name = "lblAdresseSinistre";
            this.lblAdresseSinistre.Size = new System.Drawing.Size(149, 25);
            this.lblAdresseSinistre.TabIndex = 11;
            this.lblAdresseSinistre.Text = "Adresse sinistre";
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtVille.Location = new System.Drawing.Point(426, 212);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(273, 33);
            this.txtVille.TabIndex = 10;
            this.txtVille.TextChanged += new System.EventHandler(this.txtVille_TextChanged);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodePostal.Location = new System.Drawing.Point(426, 173);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(273, 33);
            this.txtCodePostal.TabIndex = 9;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRue.Location = new System.Drawing.Point(426, 132);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(273, 33);
            this.txtRue.TabIndex = 8;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblVille.ForeColor = System.Drawing.Color.White;
            this.lblVille.Location = new System.Drawing.Point(354, 215);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(50, 25);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville";
            this.lblVille.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCodePostal.ForeColor = System.Drawing.Color.White;
            this.lblCodePostal.Location = new System.Drawing.Point(287, 176);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(117, 25);
            this.lblCodePostal.TabIndex = 7;
            this.lblCodePostal.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRue.ForeColor = System.Drawing.Color.White;
            this.lblRue.Location = new System.Drawing.Point(358, 135);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(46, 25);
            this.lblRue.TabIndex = 7;
            this.lblRue.Text = "Rue";
            // 
            // txtMotif
            // 
            this.txtMotif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(21, 97);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(182, 94);
            this.txtMotif.TabIndex = 6;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMotif.ForeColor = System.Drawing.Color.White;
            this.lblMotif.Location = new System.Drawing.Point(16, 69);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(61, 25);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif";
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(202, 338);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(362, 33);
            this.cboCaserne.TabIndex = 19;
            // 
            // cboNature
            // 
            this.cboNature.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Location = new System.Drawing.Point(202, 299);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(362, 33);
            this.cboNature.TabIndex = 18;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(353, 422);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(189, 37);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConstituer
            // 
            this.btnConstituer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConstituer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConstituer.Location = new System.Drawing.Point(549, 422);
            this.btnConstituer.Name = "btnConstituer";
            this.btnConstituer.Size = new System.Drawing.Size(189, 37);
            this.btnConstituer.TabIndex = 16;
            this.btnConstituer.Text = "Constituer équipe";
            this.btnConstituer.UseVisualStyleBackColor = true;
            this.btnConstituer.Click += new System.EventHandler(this.btnConstituer_Click);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCaserne.ForeColor = System.Drawing.Color.White;
            this.lblCaserne.Location = new System.Drawing.Point(12, 341);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(184, 25);
            this.lblCaserne.TabIndex = 13;
            this.lblCaserne.Text = "Caserne à mobiliser";
            this.lblCaserne.Click += new System.EventHandler(this.lblCaserne_Click);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNature.ForeColor = System.Drawing.Color.White;
            this.lblNature.Location = new System.Drawing.Point(25, 302);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(171, 25);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature du sinistre";
            this.lblNature.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(177, 130);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(328, 169);
            this.dgv.TabIndex = 20;
            this.dgv.Visible = false;
            // 
            // UCnouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblAdresseSinistre);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.cboNature);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.btnConstituer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDeclenchéLe);
            this.Name = "UCnouvelleMission";
            this.Size = new System.Drawing.Size(762, 483);
            this.Load += new System.EventHandler(this.UCnouvelleMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDeclenchéLe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblAdresseSinistre;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConstituer;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNature;
        private System.Windows.Forms.DataGridView dgv;
    }
}
