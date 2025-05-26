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
using System.Security.Cryptography;

namespace nouvelleMission
{
    public partial class UCnouvelleMission: UserControl
    {
        static DataSet dsGlobal;

        public UCnouvelleMission()// A SUPPIMER
        {
            InitializeComponent();
            //  /!\ A SUPPRIMER ABSOLUEMENT /!\
            initDs();
            
        }

        public UCnouvelleMission(DataSet ds)
        {
            InitializeComponent();
            dsGlobal = ds;
        }


        private void UCnouvelleMission_Load(object sender, EventArgs e)
        {
            //remplissage des cbo Casernes et Nature du sinistre
            
            
            DataTable dt = dsGlobal.Tables["NatureSinistre"];
            
            cboNature.DataSource = dt;
            cboNature.DisplayMember = "libelle";
            cboNature.ValueMember = "id";



            dt = dsGlobal.Tables["Caserne"];

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            //changement libellé n° mission et date de déclenchement
            int nbr = dsGlobal.Tables["Mission"].Rows.Count + 1;

            lblMission.Text = "Mission n°" + nbr.ToString();

            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");

            
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


            int id = dsGlobal.Tables["Mission"].Rows.Count + 1;

            DataRow drMission = dsGlobal.Tables["Mission"].NewRow();

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

            dsGlobal.Tables["Mission"].Rows.Add(drMission);



            //Récuperation des engins nécessaires

            DataTable dtEngins = dsGlobal.Tables["Engin"].Clone();

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);


            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);

            DataRow[] besoins = dsGlobal.Tables["Necessiter"].Select($"idNatureSinistre = '{idSinistre}'");

            foreach (DataRow besoin in besoins)
            {
                string codeTypeEngin = besoin["codeTypeEngin"].ToString();
                int nombre = Convert.ToInt32(besoin["nombre"]);

                string filtre = $"enPanne = 0 AND enMission = 0 AND idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}'";
                DataRow[] enginsDisponibles = dsGlobal.Tables["Engin"].Select(filtre);

                int max = Math.Min(nombre, enginsDisponibles.Length);
                for (int i = 0; i < max; i++)
                {
                    dtEngins.ImportRow(enginsDisponibles[i]);
                }
            }            

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e) 
        {
            this.Parent.Controls.Remove(this);
        }

        public static void initDs() //initialisation du DataSet dsGlobal (a utiliser lors du FormLoad du Form de base)
        {
            string[] tables = { "Admin", "Affectation", "Caserne", "Embarquer", "Engin", "Grade", "Habilitation", "Mission", "Mobiliser", "NatureSinistre", "Necessiter", "PartirAvec", "Passer", "Pompier", "TypeEngin", "sqlite_sequence" };

            dsGlobal = new DataSet();
            SQLiteConnection connec = new SQLiteConnection(@"Data Source = SDIS67.db");

            connec.Open();

            foreach (string table in tables)
            {
                string qry = "select * from " + table;
                SQLiteDataAdapter da = new SQLiteDataAdapter(qry, connec);
                DataTable dt = new DataTable(table);
                da.Fill(dt);
                dsGlobal.Tables.Add(dt);
            }

            connec.Close();
        }
    }
}
