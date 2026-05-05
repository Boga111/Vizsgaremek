using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turboTanyer
{
    public partial class frmKonyhaIndex : Form
    {
        void konyhaFeltoltes()
        {
            dgrendelesek.Rows.Clear();
            string lekerdezes = "select rendeles.rendeles_id, kosar.termek_nev, sum(kosar.term_db_szam) as db, asztalok.asztalszam FROM kosar, rendeles, asztalok WHERE kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = asztalok.asztalszam and rendeles.rendeles_tipus = 'APP' and rendeles.allapot = 'készítés alatt' group by rendeles.asztalszam, kosar.termek_nev ORDER BY rendeles.rendeles_id ASC";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgrendelesek.Rows.Add(ab.Dr["rendeles_id"], ab.Dr["termek_nev"], ab.Dr["db"], ab.Dr["asztalszam"]);
            }
        }

        void futarFeltoltes()
        {
            dgfutar.Rows.Clear();
            string lekerdezes = "select rendeles.rendeles_id as futar_rend_id, rendeles.rendeles_ido as futar_rend_ido, kosar.termek_nev as futar_termek_nev, sum(kosar.term_db_szam) as futar_term_db FROM kosar, rendeles WHERE kosar.rendeles_id = rendeles.rendeles_id and  rendeles.rendeles_tipus = 'WEB' and (rendeles.allapot = 'készítés alatt' or rendeles.allapot = 'kész') group by kosar.termek_nev ORDER BY rendeles.rendeles_id ASC";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while(ab.Dr.Read())
            {
                dgfutar.Rows.Add(ab.Dr["futar_rend_id"], ab.Dr["futar_rend_ido"], ab.Dr["futar_termek_nev"], ab.Dr["futar_term_db"]);
            }
        }
        public frmKonyhaIndex()
        {
            InitializeComponent();
            konyhaFeltoltes();
            futarFeltoltes();
            dgfutar.DefaultCellStyle.ForeColor = Color.Black;
            dgrendelesek.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void frmKonyhaIndex_Load(object sender, EventArgs e)
        {

        }

        private void btbezaras_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan ki akar lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btfrissites_Click(object sender, EventArgs e)
        {
            konyhaFeltoltes();
            futarFeltoltes();
        }

        private void dgrendelesek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewRow sor = dgrendelesek.Rows[e.RowIndex];
            DialogResult valasz = MessageBox.Show("Elkészült az étel?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                string rid = sor.Cells["rendeles_id"].Value.ToString();
                string lekerdezes = "update rendeles set allapot = 'kész' where rendeles_id = " + rid;
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                konyhaFeltoltes();
            }

        }

        private void dgfutar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewRow sor = dgfutar.Rows[e.RowIndex];
            DialogResult valasz = MessageBox.Show("Elkészült az étel?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                string rid = sor.Cells["rendeles_id"].Value.ToString();
                string lekerdezes = "update rendeles set allapot = 'kész' where rendeles_id = '" + rid + "'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                futarFeltoltes();
            }
        }
    }
}
