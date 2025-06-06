﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
using System.Data.SqlClient;
using UCLogin;

namespace UCGestionPompier
{
    public partial class UCgestionPompier: UserControl
    {
        DataSet dsGlobal;
        SQLiteConnection cx;
        bool estConnecter;

        public UCgestionPompier(DataSet ds, SQLiteConnection conn)
        {
            dsGlobal = ds;
            InitializeComponent();
            this.cx = conn;
            estConnecter = false;
        }
        public UCgestionPompier()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) //bouton Login
        {
            pnlLog.Visible = true;

            UcLogin log = new UcLogin(cx);
            log.connexionReussi += connexionReussie;
            log.btnAnnulClick += connexionAnnuler;

            pnlLog.Controls.Add(log);
            log.Show(); 

        }

        public void connexionAnnuler(object sender, EventArgs e)
        {
            pnlLog.Controls.Clear();
            pnlLog.Visible = false; 
        }

        public void connexionReussie(object sender, EventArgs e)
        {
            estConnecter = true;
            pnlLog.Controls.Clear();
            pnlLog.Visible=false;
            btnLogin.Visible=false;
            btnModif.Visible = true;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

        }


        private void UCgestionPompier_Load(object sender, EventArgs e)
        {
            // D'abord on remplie la comboBox cboCaserne avec toutes les casernes

            cboCaserne.DataSource = dsGlobal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";


            //Ensuite on remplie la comboBox cboPompier avec tout les pompiers de cette caserne

            string qry = @"select p.nom || ' ' || p.prenom as nomPrenom, p.matricule 
                            from Pompier p JOIN Affectation a 
                                ON p.matricule = a.matriculePompier 
                                    WHERE idCaserne = " + (cboCaserne.SelectedValue);

            DataTable dtToutPompier = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
            da.Fill(dtToutPompier);

            cboPompier.DataSource = dtToutPompier;
            cboPompier.DisplayMember = "nomPrenom";
            cboPompier.ValueMember = "matricule";

            // et ensuite on recupere toutes les info du pompier selectioner
            recupInfoPompier();
        }

        private void recupInfoPompier()
        {
            string qry = @"Select * from Pompier where matricule = " + cboPompier.SelectedValue;
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);

            DataTable dtCePompier = new DataTable();
            da = new SQLiteDataAdapter(qry, cx);
            da.Fill(dtCePompier);

            if (dtCePompier.Rows[0]["type"].ToString() == "p")
            {
                lblFiche.Text = "Fiche pompier professionel";
            }

            else
            {
                lblFiche.Text = "Fiche pompier volontaire";
            }

            qry = @"Select count(*) from Affectation where matriculePompier = " + cboPompier.SelectedValue;
            SQLiteCommand cmd = new SQLiteCommand(qry, cx);

            if(Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                lbAncienneAffectation.Items.Clear();
                lbAncienneAffectation.Items.Add("Aucune anciennes affectations");

            }

            else
            {
                lbAncienneAffectation.Items.Clear();

                qry = @"select a.dateA || "" - "" || c.nom as ancien 
	                        from Affectation a JOIN Caserne c 
		                        ON a.idCaserne = c.id 
			                        where a.matriculePompier = " + cboPompier.SelectedValue + @" 
				                         AND a.dateFin is not null";

                da = new SQLiteDataAdapter(qry, cx);
                DataTable dtAncienAff = new DataTable();
                da.Fill(dtAncienAff);

                foreach(DataRow dr in dtAncienAff.Rows)
                {
                    lbAncienneAffectation.Items.Add(dr["ancien"].ToString());
                }
            }

            if (Convert.ToInt32(dtCePompier.Rows[0]["enConge"]) == 1)
            {
                lblConger.Text = dtCePompier.Rows[0]["prenom"] + " est en conger";
            }

            else
            {
                lblConger.Text = dtCePompier.Rows[0]["prenom"] + " est disponible";
            }


            qry = @"SELECT  h.libelle 
	                    FROM Passer p JOIN Habilitation h 
		                    ON h.id = p.idHabilitation 
			                    WHERE p.matriculePompier = " + cboPompier.SelectedValue;

            DataTable dtHabi = new DataTable();
            da = new SQLiteDataAdapter(qry, cx);
            da.Fill(dtHabi);

            lbHabilitions.Items.Clear();

            if(dtHabi.Rows.Count > 0)
            { 
                foreach(DataRow dr in dtHabi.Rows)
                {
                    lbHabilitions.Items.Add(dr["libelle"].ToString());
                }
            }

            else
            {
                lbHabilitions.Items.Add(dtCePompier.Rows[0]["prenom"] + " ne possède aucune habilitation");
            }


            lblNumMatricule.Text = dtCePompier.Rows[0]["matricule"].ToString();
            txtNom.Text = dtCePompier.Rows[0]["nom"].ToString();
            txtPrenom.Text = dtCePompier.Rows[0]["prenom"].ToString();
            txtNaissance.Text = "Né(e) le " + dtCePompier.Rows[0]["dateNaissance"].ToString();
            txtDateEmbauche.Text = "Embauché(e) le " + dtCePompier.Rows[0]["dateEmbauche"].ToString();
            txtTel.Text = "N° tel : " + afficheTel(dtCePompier.Rows[0]["portable"].ToString());
            txtBip.Text = "Bip : " + dtCePompier.Rows[0]["bip"].ToString();





            afficheGrade(dtCePompier.Rows[0]["codeGrade"].ToString());
        }

        private void afficheGrade(string grade)
        {
            string chemin = @"ImagesGrades\" + grade + ".png";

            picGrade.Image = Image.FromFile(chemin);
        }

        private void cboPompier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            recupInfoPompier();
        }


        private string afficheTel(string numero)
        {
            string resultat = "";
            for (int i = 0; i < numero.Length; i += 2)
            {
                if (i + 2 <= numero.Length)
                    resultat += numero.Substring(i, 2) + " ";
                else
                    resultat += numero.Substring(i); // Au cas où il reste un chiffre
            }
            return resultat;
        }


        private void cboCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // D'abord on remplie la comboBox cboCaserne avec toutes les casernes

            cboCaserne.DataSource = dsGlobal.Tables["Caserne"];
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";


            //Ensuite on remplie la comboBox cboPompier avec tout les pompiers de cette caserne

            string qry = @"select p.nom || ' ' || p.prenom as nomPrenom, p.matricule 
                            from Pompier p JOIN Affectation a 
                                ON p.matricule = a.matriculePompier 
                                    WHERE idCaserne = " + (cboCaserne.SelectedValue);

            DataTable dtToutPompier = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
            da.Fill(dtToutPompier);

            cboPompier.DataSource = dtToutPompier;
            cboPompier.DisplayMember = "nomPrenom";
            cboPompier.ValueMember = "matricule";

            // et ensuite on recupere toutes les info du pompier selectioner
            recupInfoPompier();
        }




        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPompier_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
