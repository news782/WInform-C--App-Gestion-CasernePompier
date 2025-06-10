using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using System.IO;
using UC_Tab_de_bord;
using iText.Layout.Borders; // ⚠️ Ton namespace pour accéder à MesDatas

namespace UC_Tableau_de_bord
{
    public partial class UserControl1 : UserControl
    {
        private List<Probleme> toutesLesMissions;

        public UserControl1()
        {
            InitializeComponent();

            // CheckBox "En cours"
            CheckBox chkEnCours = new CheckBox();
            chkEnCours.Text = "Mission en cours ";
            chkEnCours.AutoSize = true;
            chkEnCours.Location = new System.Drawing.Point(10, 10);
            chkEnCours.CheckedChanged += ChkEnCours_CheckedChanged;
            this.Controls.Add(chkEnCours);

            // Charger les missions depuis la base
            toutesLesMissions = MesDatas.ChargerProblemesDepuisBase();
            AfficherTableauDeBord(toutesLesMissions);
        }

        private void ChkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            var liste = chk.Checked
                ? toutesLesMissions.Where(p => !p.DateRetour.HasValue).ToList()
                : toutesLesMissions;

            AfficherTableauDeBord(liste);
        }

        private void AfficherTableauDeBord(List<Probleme> listeProblemes)
        {
            // Supprimer l'ancien panel d'affichage
            Control scrollable = this.Controls.Find("panelScrollable", true).FirstOrDefault();
            if (scrollable != null)
                this.Controls.Remove(scrollable);

            // Supprimer l'ancien titre s'il existe
            Control ancienTitre = this.Controls.Find("labelTitreTableau", true).FirstOrDefault();
            if (ancienTitre != null)
                this.Controls.Remove(ancienTitre);

            // Supprimer l'ancienne barre de séparation si elle existe
            Control ancienneBarre = this.Controls.Find("barreSeparation", true).FirstOrDefault();
            if (ancienneBarre != null)
                this.Controls.Remove(ancienneBarre);

            // Titre
            Label titre = new Label();
            titre.Name = "labelTitreTableau";
            titre.Text = "Tableau de bord";
            titre.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titre.Location = new System.Drawing.Point(this.Width / 2 - 120, 10);
            titre.AutoSize = true;
            this.Controls.Add(titre);

            // Ligne séparation
            Panel barreSeparation = new Panel();
            barreSeparation.Name = "barreSeparation";
            barreSeparation.Height = 2;
            barreSeparation.Width = this.Width - 20;
            barreSeparation.BackColor = Color.Gray;
            barreSeparation.Location = new System.Drawing.Point(10, 50);
            this.Controls.Add(barreSeparation);

            // Panel scrollable
            FlowLayoutPanel panelScrollable = new FlowLayoutPanel();
            panelScrollable.Location = new System.Drawing.Point(0, 60);
            panelScrollable.Size = new Size(this.Width, this.Height - 60);
            panelScrollable.AutoScroll = true;
            panelScrollable.Name = "panelScrollable";
            panelScrollable.FlowDirection = FlowDirection.TopDown;
            panelScrollable.WrapContents = false;
            this.Controls.Add(panelScrollable);

            if (listeProblemes.Count == 0)
            {
                Label lblVide = new Label();
                lblVide.Text = "Aucune mission à afficher";
                lblVide.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                lblVide.ForeColor = Color.Gray;
                lblVide.AutoSize = true;
                panelScrollable.Controls.Add(lblVide);
            }
            else
            {
                foreach (var probleme in listeProblemes)
                {
                    Panel ligne = new Panel();
                    ligne.Width = panelScrollable.ClientSize.Width - 20;
                    ligne.Height = 120;
                    ligne.Margin = new Padding(5); // Ajout d'un espacement entre les lignes

                    Panel carte = new Panel();
                    carte.Width = ligne.Width - 120;
                    carte.Height = 100;
                    carte.Location = new System.Drawing.Point(0, 10);
                    carte.BackColor = Color.WhiteSmoke;
                    carte.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox icone = new PictureBox();
                    icone.Image = Properties.Resources.alarme;
                    icone.Size = new Size(60, 60);
                    icone.Location = new System.Drawing.Point(10, 20);
                    icone.SizeMode = PictureBoxSizeMode.Zoom;

                    Label infos = new Label();
                    infos.Text = $"Id mission : {probleme.Id}    Début : {probleme.DateSignalement.ToShortDateString()}    Caserne : {probleme.Caserne}";
                    infos.Font = new Font("Segoe UI", 9);
                    infos.Location = new System.Drawing.Point(80, 10);
                    infos.AutoSize = true;

                    Label titreProblème = new Label();
                    titreProblème.Text = probleme.Titre;
                    titreProblème.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    titreProblème.Location = new System.Drawing.Point(80, 35);
                    titreProblème.AutoSize = true;

                    Label desc = new Label();
                    desc.Text = "--> " + probleme.Description;
                    desc.Font = new Font("Segoe UI", 9);
                    desc.Location = new System.Drawing.Point(250, 35);
                    desc.AutoSize = true;

                    carte.Controls.Add(icone);
                    carte.Controls.Add(infos);
                    carte.Controls.Add(titreProblème);
                    carte.Controls.Add(desc);

                    Panel panelBoutons = new Panel();
                    panelBoutons.Width = 110;
                    panelBoutons.Height = 100;
                    panelBoutons.Location = new System.Drawing.Point(carte.Width + 10, 10);

                    Button btnPDF = new Button();
                    btnPDF.Size = new Size(40, 40);
                    btnPDF.Location = new System.Drawing.Point(0, 5);
                    btnPDF.BackColor = Color.LightBlue;
                    btnPDF.BackgroundImage = Properties.Resources.pdf;
                    btnPDF.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPDF.FlatStyle = FlatStyle.Flat;
                    btnPDF.FlatAppearance.BorderSize = 0;
                    btnPDF.Cursor = Cursors.Hand;
                    btnPDF.MouseEnter += (s, e) => btnPDF.BackColor = Color.DodgerBlue;
                    btnPDF.MouseLeave += (s, e) => btnPDF.BackColor = Color.LightBlue;

                    btnPDF.Click += (s, e) =>
                    {
                        var mission = MesDatas.GetMissionParId(probleme.Id);
                        GenererPDF(mission);
                    };

                    Button btnSupprimer = new Button();
                    btnSupprimer.Size = new Size(40, 40);
                    btnSupprimer.Location = new System.Drawing.Point(0, 50);
                    btnSupprimer.BackColor = Color.IndianRed;
                    btnSupprimer.BackgroundImage = Properties.Resources.croix_rouge;
                    btnSupprimer.BackgroundImageLayout = ImageLayout.Stretch;
                    btnSupprimer.FlatStyle = FlatStyle.Flat;
                    btnSupprimer.FlatAppearance.BorderSize = 0;
                    btnSupprimer.Cursor = Cursors.Hand;
                    btnSupprimer.MouseEnter += (s, e) => btnSupprimer.BackColor = Color.Firebrick;
                    btnSupprimer.MouseLeave += (s, e) => btnSupprimer.BackColor = Color.IndianRed;
                    btnSupprimer.Click += (s, e) =>
                    {
                        panelScrollable.Controls.Remove(ligne);
                    };

                    panelBoutons.Controls.Add(btnPDF);
                    panelBoutons.Controls.Add(btnSupprimer);

                    ligne.Controls.Add(carte);
                    ligne.Controls.Add(panelBoutons);
                    panelScrollable.Controls.Add(ligne);
                }
            }
        }



        private void GenererPDF(MissionComplete mission)
        {
            string chemin = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Rapport_Mission_{mission.Id}.pdf"
            );

            using (PdfWriter writer = new PdfWriter(chemin))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document doc = new Document(pdf, PageSize.A4);
                doc.SetMargins(30, 30, 30, 30);

                PdfFont fontTitre = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                PdfFont fontItalique = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE);

                // Titre principal
                doc.Add(new Paragraph("Rapport de mission").SetFont(fontTitre).SetFontSize(16));

                // Table à deux colonnes
                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).UseAllAvailableWidth();

                // Colonne gauche : Informations générales
                var colGauche = new Paragraph()
                    .Add($"Déclenchée le {mission.DateDebut:dd-MM-yyyy à HH\\hmm}\n")
                    .Add($"Retour le {(mission.DateRetour.HasValue ? mission.DateRetour.Value.ToString("dd-MM-yyyy à HH\\hmm") : "N/A")}\n\n")
                    .Add(new Text("Type de sinistre : ").SetFont(fontTitre)).Add($"{mission.Titre}\n")
                    .Add(new Text("Motif : ").SetFont(fontTitre)).Add($"{mission.Description}\n")
                    .Add(new Text("Adresse : ").SetFont(fontTitre)).Add($"{mission.Adresse}\n")
                    .Add(new Text("Compte-rendu : ").SetFont(fontTitre)).Add($"{mission.CompteRendu}\n\n")
                    .Add(new Text("Caserne : ").SetFont(fontTitre)).Add($"{mission.Caserne}\n\n")
                    .Add(new Text("Pompiers affectés :\n").SetFont(fontTitre));

                if (mission.Pompiers.Any())
                    mission.Pompiers.ForEach(p => colGauche.Add(new Paragraph("→ " + p).SetFont(fontItalique).SetMargin(0)));
                else
                    colGauche.Add(new Paragraph("Aucun pompier enregistré.").SetFont(fontItalique));

                table.AddCell(new Cell().Add(colGauche).SetBorder(Border.NO_BORDER));

                // Colonne droite : Engins
                var colDroite = new Paragraph()
                    .Add(new Text("Engins utilisés :\n").SetFont(fontTitre));

                if (mission.Engins.Any())
                    mission.Engins.ForEach(e => colDroite.Add(new Paragraph("→ " + e).SetFont(fontNormal).SetMargin(0)));
                else
                    colDroite.Add(new Paragraph("Aucun engin enregistré.").SetFont(fontItalique));

                table.AddCell(new Cell().Add(colDroite).SetBorder(Border.NO_BORDER));

                doc.Add(table);
                doc.Close();
            }

            MessageBox.Show("PDF généré avec succès sur le Bureau.", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLayoutPanelProbleme_Paint(object sender, PaintEventArgs e)
        {
            // Laisser vide ou ajouter du code si nécessaire
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Laisser vide ou ajouter du code si nécessaire
        }


    }
}
