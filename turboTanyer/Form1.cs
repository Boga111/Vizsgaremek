using Org.BouncyCastle.Asn1.Esf;
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
    public partial class frmPincerIndex : Form
    {
        string[] asztalszamok = { "A1", "A2", "A3", "A4", "A5", 
                              "B1", "B2", "B3", "B4", "B5",
                              "C1", "C2", "C3", "C4", "C5",
                              "D1", "D2", "D3", "D4", "D5",
                              "E1", "E2", "E3", "E4", "E5"};
        string rid;
        void adatBetoltes()
        {
            dgadatok.Rows.Clear();
            string lekerdezes = "";
            if(cbasztalszam.SelectedItem != null)
            {
                lekerdezes = "SELECT rendeles.rendeles_id, kosar.termek_nev, sum(kosar.term_db_szam) as db, kosar.netto_egyseg_ar, kosar.brutto_osszeg, rendeles.allapot FROM kosar, rendeles, asztalok WHERE kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = asztalok.asztalszam and rendeles.asztalszam = '" + cbasztalszam.Text + "' and rendeles.allapot <> 'lezárva' group by kosar.termek_nev";
                Adatbazis ab = new Adatbazis(lekerdezes);
                while (ab.Dr.Read())
                {
                    dgadatok.Rows.Add(ab.Dr["rendeles_id"], ab.Dr["termek_nev"], ab.Dr["netto_egyseg_ar"], ab.Dr["db"], ab.Dr["brutto_osszeg"], ab.Dr["allapot"]);
                }
                ab.lezaras();

                int vegossz = 0;
                string fizetendo = "SELECT sum(kosar.brutto_osszeg) as fizetendo FROM kosar, rendeles, asztalok where kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = asztalok.asztalszam and asztalok.asztalszam = '"+cbasztalszam.Text+ "' and rendeles.allapot <> 'lezárva'";
                ab = new Adatbazis(fizetendo);
                if (ab.Dr.Read())
                {
                    if (ab.Dr["fizetendo"] == DBNull.Value)
                    {
                        vegossz = 0;
                    }
                    else
                    {
                        vegossz = Convert.ToInt32(ab.Dr["fizetendo"]);
                    }
                }
                lbfizetendo.Text = vegossz + " Ft";
            }
        }

        void keszEtelek()
        {
            dgkeszetelek.Rows.Clear();
            string lekerd = "select kosar.termek_nev as kesz_termek_nev, asztalok.asztalszam as kesz_asztalszam, rendeles.rendeles_id as kesz_rendelesid from rendeles, kosar, asztalok where kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = asztalok.asztalszam and rendeles.allapot = 'kész' group by kosar.termek_nev";
            Adatbazis ab = new Adatbazis(lekerd);
            while (ab.Dr.Read())
            {
                dgkeszetelek.Rows.Add(ab.Dr["kesz_termek_nev"], ab.Dr["kesz_asztalszam"], ab.Dr["kesz_rendelesid"]);
            }
        }

        public frmPincerIndex()
        {
            InitializeComponent();
            pladatok.Visible = false;
            for (int i = 0; i < asztalszamok.Length; i++)
            {
                cbasztalszam.Items.Add(asztalszamok[i]);
            }
            adatBetoltes();
            keszEtelek();
            dgadatok.DefaultCellStyle.ForeColor = Color.Black;
            dgkeszetelek.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void bthozzaad_Click(object sender, EventArgs e)
        {
            frmHozzaadas hozzaad = new frmHozzaadas();
            hozzaad.AdatValtozott += adatBetoltes;
            hozzaad.Show();
            
        }

        private void btszamla_Click(object sender, EventArgs e)
        {
            frmSzamla szamla = new frmSzamla();
            szamla.ShowDialog();
        }

        private void frmFoform_Load(object sender, EventArgs e)
        {

        }

        private void cbasztalszam_SelectedIndexChanged(object sender, EventArgs e)
        {
            adatBetoltes();
            if (cbasztalszam.SelectedIndex >= 0)
            {
                pladatok.Visible = true;
                dgkeszetelek.Visible = false;
                lbkesz.Visible = false;
            }
            else
            {
                pladatok.Visible = false;
                dgkeszetelek.Visible = true;
                lbkesz.Visible = true;
            }
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string allapot = sor.Cells["allapot"].Value.ToString();
            if (allapot == "készítés alatt")
            {
                MessageBox.Show("A termék még nem készült el, nem lehet kiadni!\nCsak 'kész' állapotú terméket lehet kiadni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (allapot == "kiadva")
            {
                MessageBox.Show("A termék már kiadta!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult valasz = MessageBox.Show("Kiadta a terméket?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (valasz == DialogResult.Yes)
                {
                    rid = sor.Cells["rendeles_id"].Value.ToString();
                    string lekerd = "update rendeles set allapot = 'kiadva' where rendeles_id = " + rid;
                    Adatbazis ab = new Adatbazis(lekerd);
                    ab.Dr.Read();
                    ab.lezaras();
                    DateTime kiaddasiIdo = DateTime.Now;
                    lekerd = "update rendeles set atveteli_ido = NOW() where rendeles_id = " + rid;
                    ab = new Adatbazis(lekerd);
                    ab.Dr.Read();
                    ab.lezaras();
                    adatBetoltes();
                }
            }
        }

        private void btfrissites_Click(object sender, EventArgs e)
        {
            adatBetoltes();
        }

        private void dgkeszetelek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewRow sor = dgkeszetelek.Rows[e.RowIndex];
            DialogResult valasz = MessageBox.Show("Kiadta a rendelést?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                rid = sor.Cells["kesz_rendelesid"].Value.ToString();
                string lekerd = "update rendeles set allapot = 'kiadva' where rendeles_id = " + rid;
                Adatbazis ab = new Adatbazis(lekerd);
                ab.Dr.Read();
                ab.lezaras();
                DateTime kiaddasiIdo = DateTime.Now;
                lekerd = "update rendeles set atveteli_ido = NOW() where rendeles_id = " + rid;
                ab = new Adatbazis(lekerd);
                ab.Dr.Read();
                ab.lezaras();
                keszEtelek();
            }
        }

        private void btbezaras_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgkeszetelek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
