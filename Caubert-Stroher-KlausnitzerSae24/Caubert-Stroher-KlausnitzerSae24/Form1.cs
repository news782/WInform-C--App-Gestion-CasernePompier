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
using E = Engin;
using Statistiques;
using m = UCmobilisations;

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
            
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCnouvelleMission nv = new UCnouvelleMission(MesDatas.DsGlobal);

            nv.MissionAjouter += Uc_missionAjouter;
            

            panel1.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
            nv.Show();
        }

        private void Uc_missionAjouter(object sender, EventArgs e)
        {
            var uc = sender as UCnouvelleMission;
            //donne accès au champs dtEngins et dtPompier du UCnouvelleMission
            if(uc.enginsDispo)
            {
                m.UCmobilisations mobil = new m.UCmobilisations(uc.dtEngins, uc.dtPompier);
                panel1.Controls.Clear();
                panel1.Controls.Add(mobil);
                mobil.Show();
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = MesDatas.DsGlobal.Tables["Mission"];
        }

        private void grpbtnVolet_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCStats stats = new UCStats(Connexion.Connec);
            panel1.Controls.Add(stats);
            stats.Dock = DockStyle.Fill;
            stats.Show();
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            E.Engin UCengin = new E.Engin(Connexion.Connec);
            panel1.Controls.Add(UCengin);
            UCengin.Show();
        }
    }
}
