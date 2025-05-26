using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.Common;

namespace nouvelleMission
{
    public partial class UCnouvelleMission: UserControl
    {
        SQLiteConnection cx;// a supprimer
        DataSet dsGlobal;

        public UCnouvelleMission()// A SUPPIMER
        {
            InitializeComponent();

            string chaine = "Data Source=SDIS67.db";

            try
            {
                cx = new SQLiteConnection(chaine);
                cx.Open();
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cx.Close();
        }

        public UCnouvelleMission(DataSet ds)
        {
            InitializeComponent();
            dsGlobal = ds;
        }


        private void UCnouvelleMission_Load(object sender, EventArgs e)
        {
            //remplissage des cbo Casernes et Nature du sinistre
            cx.Open();
            string qry = "select libelle, id from NatureSinistre;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx) ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            cboNature.DataSource = dt;
            cboNature.DisplayMember = "libelle";
            cboNature.ValueMember = "id";

            
            qry = "select id, nom from Caserne;";
            da = new SQLiteDataAdapter (qry, cx);
            dt = new DataTable();
            da.Fill(dt);

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            //changement libellé n° mission et date de déclenchement
            qry = "select count(*) from Mission";
            SQLiteCommand cm = new SQLiteCommand(qry, cx);
            int nbr = Convert.ToInt32(cm.ExecuteScalar()) + 1;

            lblMission.Text = "Mission n°" + nbr.ToString();

            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");

            cx.Close();

        }

        private void grpInfoUsager_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpDecisions_Enter(object sender, EventArgs e)
        {

        }

        private void lblCaserne_Click(object sender, EventArgs e)
        {

        }

        private void lblMission_Click(object sender, EventArgs e)
        {

        }

        private void lblNumMission_Click(object sender, EventArgs e)
        {

        }

        private void btnConstituer_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Id de la caserne selectionne : " + cboCaserne.SelectedValue.ToString());
            MessageBox.Show("Id de la nutureSinistre selectionne : " + cboNature.SelectedValue.ToString());*/


            //Remplissage d'une DataTable avec les engins à affecter

            //ajout d'une mission en mode déconnecter
            string qry = "select * from Mission";

            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
            DataTable dtMissions = new DataTable();
            da.Fill(dtMissions);

            cx.Open();

            SQLiteCommand cmd = new SQLiteCommand("Select max(id) + 1 from Mission", cx);
            int id = Convert.ToInt32(cmd.ExecuteScalar());   

            DataRow drMission = dtMissions.NewRow();
            drMission["id"] = id;
            drMission["dateHeureDepart"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            /*dr["dateHeureRetour"] = null;*/
            drMission["motifAppel"] = txtMotif.Text;
            drMission["adresse"] = txtRue.Text;
            drMission["cp"] = txtCodePostal.Text;
            drMission["ville"] = txtVille.Text;
            drMission["terminee"] = 0;
            drMission["compteRendu"] = null;
            drMission["idNatureSinistre"] = cboNature.SelectedValue;
            drMission["idCaserne"] = cboCaserne.SelectedValue; 

            dtMissions.Rows.Add(drMission);

            cx.Close();

            /*dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;    
            dgv.Visible = true;*/

            //Test pour voir les modification DataTable (a supprimer)


            //Récupération du nombre de véhicule nécessaire pour chaque mission
            qry = @"select codeTypeEngin, nombre FROM Necessiter where idNatureSinistre = " + cboNature.SelectedValue;

            da = new SQLiteDataAdapter(qry, cx);
            DataTable dtNecessiter = new DataTable();
            da.Fill(dtNecessiter);

            dgv.DataSource = dtNecessiter;
            /*dgv.Visible = true;*/


            DataTable dtEngins = new DataTable();
            int i = 0;
            foreach (DataRow dr in dtNecessiter.Rows)
            {
                qry = @"SELECT * FROM Engin 
                            WHERE   enPanne = 0 AND 
                                    enMission = 0 AND
                                    idCaserne = " + cboCaserne.SelectedValue + @" AND 
                                    codeTypeEngin = '" + dtNecessiter.Rows[i]["codeTypeEngin"] +  @"'
                                        limit " + dtNecessiter.Rows[i]["nombre"];

                i++;

                da = new SQLiteDataAdapter(qry, cx);

                da.Fill(dtEngins);
            }
            
            dgv.DataSource = dtEngins;
            dgv.Visible = true;

            


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e) 
        {
            
        }
    }
}
