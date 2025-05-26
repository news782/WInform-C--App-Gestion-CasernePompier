using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Caubert_Stroher_KlausnitzerSae24;
using Statistiques;
using E = Engin;

namespace Caubert_Stroher_KlausnitzerSae24
{
    public partial class frmSoldatFeu : Form
    {
        public frmSoldatFeu()
        {
            InitializeComponent();
            MesDatas.initDs(); //initialise le DataSet de la classe mesDatas
        }

        private void frmSoldatFeu_Load(object sender, EventArgs e)
        {
            /*UCStats stats = new UCStats(Connexion.Connec);
            panel1.Controls.Add(stats);
            stats.Dock = DockStyle.Fill;
            stats.Show();*/
            E.Engin enginUC = new E.Engin(Connexion.Connec);
            panel1.Controls.Add(enginUC);
            panel1.Size = new Size(enginUC.Width, enginUC.Height);
            enginUC.Dock = DockStyle.Fill;
            enginUC.Show();

        }

        private void btnMission_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
