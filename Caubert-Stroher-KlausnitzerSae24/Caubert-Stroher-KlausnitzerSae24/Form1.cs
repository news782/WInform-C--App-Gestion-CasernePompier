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
using System.Diagnostics;

namespace Caubert_Stroher_KlausnitzerSae24
{
    public partial class frmSoldatFeu : Form
    {
        private int startTop;
        private int endTop;
        private double animationTime; // temps écoulé
        private double animationDuration = 400; // durée totale en ms
        private DateTime animationStart;

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
            /*nv.Dock = DockStyle.Fill;*/
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
            MoveFlameSmooth(btnStats);

            panel1.Controls.Clear();
            UCStats stats = new UCStats(Connexion.Connec);
            panel1.Controls.Add(stats);
            stats.Dock = DockStyle.Fill;
            stats.Show();
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnEngins);

            panel1.Controls.Clear();
            E.Engin UCengin = new E.Engin(MesDatas.DsGlobal);
            panel1.Controls.Add(UCengin);
            UCengin.Show();


        }


        private void MoveFlameSmooth(Button targetButton)
        {
            startTop = picIndicator.Top;
            endTop = targetButton.Top + (targetButton.Height - picIndicator.Height) / 2;
            animationStart = DateTime.Now;
            timeIndicator.Start();
        }


        private void btnTDB_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnTDB);
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            MoveFlameSmooth(btnPersonnel);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animationTime = (DateTime.Now - animationStart).TotalMilliseconds;

            double t = animationTime / animationDuration;
            if (t >= 1)
            {
                t = 1;
                timeIndicator.Stop();
            }

            // Ease-in-out sinusoidal : (1 - cos(π * t)) / 2
            double easedT = (1 - Math.Cos(t * Math.PI)) / 2;

            int newTop = (int)(startTop + (endTop - startTop) * easedT);
            picIndicator.Top = newTop;
        }
    }
}
