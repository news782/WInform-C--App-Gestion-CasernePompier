using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Engin
{
    public partial class Engin: UserControl
    {

        
        
        public Engin()
        {
            InitializeComponent();


            /*string chcon = @"Data Source = SDIS67.db";

            try
            {
                cx = new SQLiteConnection(chcon);
                cx.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cx.Close();*/
        }

        SQLiteConnection cx;
        public Engin(SQLiteConnection connec)
        {
            InitializeComponent();
            cx = connec;

        }



        BindingSource bs = new BindingSource();

        private void Engin_Load(object sender, EventArgs e)
        {
            string texteStatut = lblStatut.Text;

            string qry = "Select id, nom From Caserne ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCaserne.DataSource = dt;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";


            // Ne déclenche pas SelectedIndexChanged ici (on l’ignore au chargement)
            cboCaserne.SelectedIndexChanged -= cboCaserne_SelectedIndexChanged;
            cboCaserne.SelectedIndex = -1;
            cboCaserne.SelectedIndexChanged += cboCaserne_SelectedIndexChanged;

            btnPrem.Image = Properties.Resources.boutonEngin1R;
            btnAvant.Image = Properties.Resources.boutonEngin2_removebg_preview;
            btnApres.Image = Properties.Resources.boutonEngin2R;
            btnDernier.Image = Properties.Resources.boutonEngin_removebg_preview__1_;
            /*pbLogo.Image = Properties.Resources.Logo_FireBase_HQ_removebg_preview;*/

        }

        private void btnPrem_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnApres_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedIndex == -1 || cboCaserne.SelectedValue == null)
                return;

            // Évite l’erreur DataRowView
            if (cboCaserne.SelectedValue is DataRowView)
                return;

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);

            string qry2 = "SELECT  (idCaserne || '-' || codeTypeEngin || '-' || numero) AS numero, dateReception, enMission, enPanne FROM Engin WHERE idCaserne = @id";
            SQLiteDataAdapter da = new SQLiteDataAdapter(qry2, cx);
            da.SelectCommand.Parameters.AddWithValue("@id", idCaserne);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);

            lblStatut.Text = "Statut de l'engin : Disponible";

            bs.DataSource = dt2;

            // Rafraîchir les champs
            lblNum2.DataBindings.Clear();
            lblDate2.DataBindings.Clear();
            chkMission.DataBindings.Clear();
            chkPanne.DataBindings.Clear();

            lblNum2.DataBindings.Add("Text", bs, "numero");
            lblDate2.DataBindings.Add("Text", bs, "dateReception");
            chkMission.DataBindings.Add("Checked", bs, "enMission");
            chkPanne.DataBindings.Add("Checked", bs, "enPanne");

            bs.MoveFirst();
        }
        
        

        private void chkPanne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPanne.Checked)
            {
                lblPanne.Visible = true;
                lblStatut.Text = "Statut de l'engin : Non disponible";
            }
            else
            {
                lblPanne.Visible = false;
                lblStatut.Text = "Statut de l'engin : Disponible";
            }
        }

        private void lblNum2_TextChanged(object sender, EventArgs e)
        {
            string code = lblNum2.Text;

            if (code.Contains("BRS"))
            {
                pb1.Image = Properties.Resources.BRS;
            }
            else if (code.Contains("CCF"))
            {
                pb1.Image = Properties.Resources.CCF;
            }
            else if (code.Contains("EPA"))
            {
                pb1.Image = Properties.Resources.EPA;
            }
            else if (code.Contains("FCYN"))
            {
                pb1.Image = Properties.Resources.FCYN;
            }
            else if (code.Contains("FPT"))
            {
                pb1.Image = Properties.Resources.FPT;
            }
            else if (code.Contains("VID"))
            {
                pb1.Image = Properties.Resources.VID;
            }
            else if (code.Contains("VPC"))
            {
                pb1.Image = Properties.Resources.VPC;
            }
            else if (code.Contains("VSAV"))
            {
                pb1.Image = Properties.Resources.VSAV;
            }
            else if (code.Contains("VSR"))
            {
                pb1.Image = Properties.Resources.VSR;
            }
            else if (code.Contains("VSS"))
            {
                pb1.Image = Properties.Resources.VSS;
            }
            else
            {
                pb1.Image = null;
            }
        }

        private void chkMission_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMission.Checked)
            {
                lblMission.Visible = true;
                lblStatut.Text = "Statut de l'engin : Non disponible";
            }
            else
            {
                lblMission.Visible = false;
                lblStatut.Text = "Statut de l'engin : Disponible";
            }
        }
    }
}
