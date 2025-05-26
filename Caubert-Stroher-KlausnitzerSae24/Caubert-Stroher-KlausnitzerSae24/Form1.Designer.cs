namespace Caubert_Stroher_KlausnitzerSae24
{
    partial class frmSoldatFeu
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
            this.grpbtnVolet = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();
            this.btnTDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.engin1 = new Engin.Engin();
            this.grpbtnVolet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbtnVolet
            // 
            this.grpbtnVolet.BackColor = System.Drawing.Color.IndianRed;
            this.grpbtnVolet.Controls.Add(this.btnQuitter);
            this.grpbtnVolet.Controls.Add(this.btnStats);
            this.grpbtnVolet.Controls.Add(this.btnPersonnel);
            this.grpbtnVolet.Controls.Add(this.btnEngins);
            this.grpbtnVolet.Controls.Add(this.btnMission);
            this.grpbtnVolet.Controls.Add(this.btnTDB);
            this.grpbtnVolet.Location = new System.Drawing.Point(35, 27);
            this.grpbtnVolet.Name = "grpbtnVolet";
            this.grpbtnVolet.Size = new System.Drawing.Size(218, 467);
            this.grpbtnVolet.TabIndex = 0;
            this.grpbtnVolet.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(11, 419);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(196, 42);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(11, 228);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(196, 42);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statistique";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Location = new System.Drawing.Point(11, 180);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(196, 42);
            this.btnPersonnel.TabIndex = 3;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnEngins
            // 
            this.btnEngins.Location = new System.Drawing.Point(11, 132);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(196, 42);
            this.btnEngins.TabIndex = 2;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.UseVisualStyleBackColor = true;
            // 
            // btnMission
            // 
            this.btnMission.Location = new System.Drawing.Point(11, 84);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(196, 42);
            this.btnMission.TabIndex = 1;
            this.btnMission.Text = "Nouvelle Mission";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // btnTDB
            // 
            this.btnTDB.Location = new System.Drawing.Point(11, 36);
            this.btnTDB.Name = "btnTDB";
            this.btnTDB.Size = new System.Drawing.Size(196, 42);
            this.btnTDB.TabIndex = 0;
            this.btnTDB.Text = "Tableau de bord";
            this.btnTDB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.engin1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 726);
            this.panel1.TabIndex = 1;
            // 
            // engin1
            // 
            this.engin1.Location = new System.Drawing.Point(168, 99);
            this.engin1.Name = "engin1";
            this.engin1.Size = new System.Drawing.Size(818, 360);
            this.engin1.TabIndex = 0;
            // 
            // frmSoldatFeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbtnVolet);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSoldatFeu";
            this.Text = "Les soldats du feu";
            this.Load += new System.EventHandler(this.frmSoldatFeu_Load);
            this.grpbtnVolet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbtnVolet;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnTDB;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private Engin.Engin engin1;
    }
}

