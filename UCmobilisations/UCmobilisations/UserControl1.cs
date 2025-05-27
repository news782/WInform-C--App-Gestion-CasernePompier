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
using System.Security.Cryptography.X509Certificates;

namespace UCmobilisations
{
    public partial class UCmobilisations: UserControl
    {
        DataTable dtEngins;
        DataTable dtPompiers;


        static DataSet dsGlobal;

        public UCmobilisations(DataTable datatableEngins, DataTable datatablePompier)
        {
            InitializeComponent();
            dtEngins = datatableEngins;
            dtPompiers = datatablePompier;
        }

        public UCmobilisations() //ce Constructeurs sera a supprimer ultérieurement 
        {
            InitializeComponent();
            initDs();




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

        //A SUPPRIMER

        private void UCmobilisations_Load(object sender, EventArgs e)
        {
            tblEngins.Controls.Clear();
            tblEngins.RowStyles.Clear();
            tblEngins.RowCount = 0;


            for (int i = 0; i < dtEngins.Rows.Count; i++)
            {
                tblEngins.RowCount++;
                tblEngins.RowStyles.Add(new RowStyle(SizeType.AutoSize));

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

            tblPompier.Controls.Clear();
            tblPompier.RowStyles.Clear();
            tblPompier.RowCount = 0;

            for (int i = 0; i < dtPompiers.Rows.Count; i++)
            {
                tblPompier.RowCount++;
                tblPompier.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile("Images/pompier.png");
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 40;
                pic.Height = 40;
                tblPompier.Controls.Add(pic, 0, i);

                Label lbl = new Label();
                lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lbl.AutoSize = true;
                lbl.Text = dtPompiers.Rows[i]["matricule"].ToString();
                lbl.Margin = new Padding(11);
                tblPompier.Controls.Add(lbl, 1, i);
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
            this.Parent.Controls.Remove(this);
        }
    }
}
