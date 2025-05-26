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

namespace UCmobilisations
{
    public partial class UCmobilisations: UserControl
    {
        DataTable dtEngins;
        DataTable dtPompiers;
        SQLiteConnection cx;

        public UCmobilisations(DataTable datatableEngins, DataTable datatablePompier)
        {
            InitializeComponent();
            dtEngins = datatableEngins;
            dtPompiers = datatablePompier;
        }

        public UCmobilisations() //ce Constructeurs sera a supprimer ultérieurement 
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

            dtEngins = new DataTable();
            dtPompiers = new DataTable();


            string qry = @"select codeTypeEngin, nombre FROM Necessiter where idNatureSinistre = 9;";


            
            // /!\ NE PAS OUBLIER DES CHANGER LES REQUETES DANS L'AUTRE UC /!\

            SQLiteCommand cmd = new SQLiteCommand(qry, cx);

            SQLiteDataAdapter daEngins = new SQLiteDataAdapter(cmd);
            daEngins.Fill(dtEngins);


            //Remplissage d'une DataTable avec les Pompiers à affecter

            qry = @"";


            cmd = new SQLiteCommand(qry, cx);

            SQLiteDataAdapter daPompiers = new SQLiteDataAdapter(cmd);  
            daPompiers.Fill(dtPompiers);
        }

        private void UCmobilisations_Load(object sender, EventArgs e)
        {
            tblEngins.Controls.Clear();
            tblEngins.RowStyles.Clear();
            tblEngins.RowCount = 0;

            
            for(int i = 0;  i < dtEngins.Rows.Count;i++)
            {
                

                tblEngins.RowCount++;
                tblEngins.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                //Ajout des images
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile("Images/engin.png");
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 40;
                pic.Height = 40;
                tblEngins.Controls.Add(pic, 0, i);

                Label lbl = new Label();
                lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold); 
                lbl.AutoSize = true;
                lbl.Text = dtEngins.Rows[i]["codeTypeEngin"].ToString();
                lbl.Margin = new Padding(11);
                tblEngins.Controls.Add(lbl, 1, i);

            }

        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void UCmobilisations_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void lblTitre_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void lblTitre_MouseHover(object sender, EventArgs e)
        {
        }

        private void lblTitre_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
