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
using nouvelleMission;

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
            UCnouvelleMission nv = new UCnouvelleMission(MesDatas.DsGlobal);
            panel1.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
            nv.Show();

            //teste pour verifier si les nouvelles missions sont bien ajouter dans le dsGlobal
        }

        private void btnMission_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MesDatas.DsGlobal.Tables["Mission"];
        }
    }
}
