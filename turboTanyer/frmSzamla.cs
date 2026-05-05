using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turboTanyer
{
    public partial class frmSzamla : Form
    {
        string[] asztalszamok = { "A1", "A2", "A3", "A4", "A5",
                      "B1", "B2", "B3", "B4", "B5",
                      "C1", "C2", "C3", "C4", "C5",
                      "D1", "D2", "D3", "D4", "D5",
                      "E1", "E2", "E3", "E4", "E5"};
        string[] fizmod = { "Kártya", "Kézpénz" };
        string rid = "";
        string sorszam = "000001";
        string teljsorsz = "";
        void feltoltes()
        {
            string lekerdezes = "select termek_nev, netto_egyseg_ar, term_db_szam, netto_osszeg, brutto_osszeg, afa_kulcs, brutto_osszeg - netto_osszeg as afa_ertek from kosar, rendeles where kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = '" + cbasztal.Text+"' and rendeles.allapot = 'kiadva'";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while(ab.Dr.Read() )
            {
                dgadatok.Rows.Add(ab.Dr["termek_nev"], ab.Dr["netto_egyseg_ar"], ab.Dr["term_db_szam"], ab.Dr["netto_osszeg"], ab.Dr["brutto_osszeg"], ab.Dr["afa_kulcs"], ab.Dr["afa_ertek"]);
            }
        }

        void Vegosszegek()
        {
            int vane = 0;
            string lekerd = "select count(*) as db from rendeles where allapot = 'kiadva' and asztalszam = '"+ cbasztal.Text +"'";
            Adatbazis ab = new Adatbazis(lekerd);
            if (ab.Dr.Read())
            {
                vane = Convert.ToInt32(ab.Dr["db"]);
            }
            ab.lezaras();
            if(vane > 0)
            {
                int afaNelkul = 0;
                int afaErtek = 0;
                int szervizDij = 0;
                int vegeAfaval = 0;
                lekerd = "select rendeles.rendeles_id, sum(kosar.brutto_osszeg) - sum(kosar.netto_osszeg) as afa_ertek,sum(netto_osszeg) * 0.05 as szervizdij, sum(netto_osszeg) as netto_ossz, sum(brutto_osszeg) + sum(netto_osszeg) * 0.05 as brutto_ossz from kosar,rendeles where kosar.rendeles_id = rendeles.rendeles_id and rendeles.asztalszam = '" + cbasztal.Text + "' and rendeles.allapot = 'kiadva'";
                ab = new Adatbazis(lekerd);
                if (ab.Dr.Read())
                {
                    afaNelkul = Convert.ToInt32(ab.Dr["netto_ossz"]);
                    afaErtek = Convert.ToInt32(ab.Dr["afa_ertek"]);
                    szervizDij = Convert.ToInt32(ab.Dr["szervizdij"]);
                    vegeAfaval = Convert.ToInt32(ab.Dr["brutto_ossz"]);
                    rid = ab.Dr["rendeles_id"].ToString();
                }
                lbvegeafanelkul.Text = $"{afaNelkul} Ft";
                lbafaertekossz.Text = $"{afaErtek} Ft";
                lbszervizdíj.Text = $"{szervizDij} Ft";
                lbvegeafaval.Text = $"{vegeAfaval} Ft";
                ab.lezaras();
            }
            else
            {
                MessageBox.Show($"Nincsenek megjeleníthető adatok ehez az asztalhoz: {cbasztal.Text}!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void szlaSorszam()
        {
            int utsoid = 0;
            string lekerd = "select szamla_id as utsoid from szamla order by szamla_id desc limit 1";
            Adatbazis ab = new Adatbazis(lekerd);
            if (ab.Dr.Read())
            {
                utsoid = Convert.ToInt32(ab.Dr["utsoid"]);
                utsoid = utsoid + 1;
            }
            else
            {
                utsoid = 1;
            }
            sorszam = utsoid.ToString().PadLeft(6, '0');
            
            DateTime ev = DateTime.Now;
            teljsorsz = $"TUT/{ev.Year}/{sorszam}";
            lbszamlasorszam.Text = teljsorsz;
        }

        void cegesCim()
        {
            if (txcegesadoszam.TextLength < 1)
            {
                MessageBox.Show("Az adószám kitöltése kötelező.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesadoszam.Focus();
            }
            else if (txcegesadoszam.TextLength < 10)
            {
                MessageBox.Show("Az adószám hiányos.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesadoszam.Focus();
            }
            else if(txcegesadoszam.TextLength > 14)
            {
                MessageBox.Show("Az adószám túl hosszú!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesadoszam.Clear();
                txcegesadoszam.Focus();
            }
            else if (txcegesnev.TextLength < 1)
            {
                MessageBox.Show("A cég nevének megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesnev.Focus();
            }
            else if (txcegesirszam.TextLength != 4)
            {
                MessageBox.Show("Az irányítószám hiányos!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesirszam.Clear();
                txcegesirszam.Focus();
            }
            else if (txcegestelepules.TextLength < 1)
            {
                MessageBox.Show("A település mező kitötlése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegestelepules.Focus();
            }
            else if (txcegesutca.TextLength < 1)
            {
                MessageBox.Show("Az utca mező kitötlése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegesutca.Focus();
            }
            else if (txcegeshazszam.TextLength < 1)
            {
                MessageBox.Show("A házszám megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txcegeshazszam.Focus();
            }
            else if (cbfizmod.Text == "")
            {
                MessageBox.Show("A fizetési mód megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult valasz = MessageBox.Show($"Minden megadott adat jó? \nAdószám: {txcegesadoszam.Text} \nIrányítószám:{txcegesirszam.Text} \nTelepülés: {txcegestelepules.Text} \nUtca: {txcegesutca.Text} \nHázszám: {txcegeshazszam.Text}", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (valasz == DialogResult.Yes)
                {
                    string cim = $"{txcegesirszam.Text}, {txcegestelepules.Text}, {txcegesutca.Text}, {txcegeshazszam.Text}";
                    string mentes = "insert into szamla (rendeles_id, nev, tipus, teljesites_datuma, cim, fiz_mod, szla_sorszam, szla_teljsorszam, vegosszeg) values('"+ rid +"', '" + txcegesnev.Text + "', 'ceg', '"+ DateTime.Now.ToString("yyyy-MM-dd") +"', '" + cim + "', '"+ cbfizmod.Text +"', '" + sorszam + "', '" + teljsorsz + "', '" + lbvegeafaval.Text + "')";
                    Adatbazis ab = new Adatbazis(mentes);
                    ab.Dr.Read();
                    ab.lezaras();

                    string szamlaMappaEleres = "..\\..\\..\\turboTanyer\\szamlak\\";
                    Directory.CreateDirectory(szamlaMappaEleres);
                    string lekerdezes = "select szla_teljsorszam from szamla order by szla_sorszam desc limit 1";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    string szamlaNeve = ab.Dr["szla_teljsorszam"].ToString().Replace("/", "_");
                    ab.lezaras();
                    string filePath = Path.Combine(szamlaMappaEleres, szamlaNeve + ".txt");

                    List<string> tetelL = new List<string>();
                    lekerdezes = "select kosar.termek_nev, kosar.term_db_szam, kosar.brutto_osszeg from kosar, rendeles where rendeles.rendeles_id = kosar.rendeles_id and rendeles.asztalszam ='" + cbasztal.Text + "' and rendeles.allapot = 'kiadva'";
                    ab = new Adatbazis(lekerdezes);
                    while (ab.Dr.Read())
                    {
                        string termek_nev = ab.Dr["termek_nev"].ToString();
                        string db = ab.Dr["term_db_szam"].ToString();
                        string osszeg = ab.Dr["brutto_osszeg"].ToString();
                        string sor = termek_nev.PadRight(25) +
                                     db.PadLeft(3) + " db   " +
                                     osszeg.PadLeft(8) + " Ft";
                        tetelL.Add(sor);
                    }
                    string tartalom = "                  Turbó Tányér                  " +
                                      "\n         1129, Budapest, Üteg utca 15.        " +
                                      "\n             Adószám: 12345678-1-2            " +
                                      "\n      Elérhetőségünk: tel.: 06 20 1234567     " +
                                      "\n----------------------------------------------" +
                                      "\n                Megadott adatok               " +
                                      $"\nMegnevezés: {txcegesnev.Text}" +
                                      $"\nAdószám: {txcegesadoszam.Text}" +
                                      $"\nCím: {txcegesirszam.Text}, {txcegestelepules.Text} {txcegesutca.Text} {txcegeshazszam.Text}." +
                                      "\n----------------------------------------------" +
                                      "\n                    Számla                    " +
                                      "\n----------------------------------------------" +
                                      $"\nSzámla sorszáma: {teljsorsz}" +
                                      $"\nSzámla kelte: {dtkiallitasido.Text}" +
                                      $"\nTeljesítési határidő: {DateTime.Now.ToString("yyyy.MM.dd")}" +
                                      $"\nFizetési mód: {cbfizmod.Text}" +
                                      "\n----------------------------------------------" +
                                      $"\n                     Tételek:                " +
                                      "\n----------------------------------------------\n\n";
                    tartalom += "Termék".PadRight(25) +
                                "db".PadLeft(5) +
                                "   Ár".PadLeft(10) + "\n" +
                                "----------------------------------------------\n";
                    foreach (var tetel in tetelL)
                    {
                        tartalom += tetel + "\n";
                    }
                    tartalom += "\n----------------------------------------------\n" +
                               $"Végösszeg áfa nélkül:".PadRight(35) + lbvegeafanelkul.Text.PadLeft(10) + "\n" +
                               $"Áfa értéke összesen:".PadRight(35) + lbafaertekossz.Text.PadLeft(10) + "\n" +
                               $"Szervízdíj:".PadRight(35) + lbszervizdíj.Text.PadLeft(10) + "\n" +
                               "\n" +
                               "==============================================\n" + "\n" +
                               $"TELJES VÉGÖSSZEG:".PadRight(30) + lbvegeafaval.Text.PadLeft(15) + "\n" +
                               "\n" +
                               "==============================================\n";
                    File.WriteAllText(filePath, tartalom);
                    string veglegesites = "update rendeles set allapot = 'lezárva' where asztalszam = '" + cbasztal.Text + "'";
                    ab = new Adatbazis(veglegesites);
                    ab.Dr.Read();
                    ab.lezaras();
                    MessageBox.Show("A számla elkészült, megtekinthető a 'szamlak' mappában.", "Sikeres mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        void maganCim()
        {
            if (txmagannev.TextLength < 1)
            {
                MessageBox.Show("A név megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmagannev.Focus();
            }
            else if (txmaganirszam.TextLength != 4)
            {
                MessageBox.Show("Az irányítószám hiányos!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmaganirszam.Clear();
                txmaganirszam.Focus();
            }
            else if (txmagantelepules.TextLength < 1)
            {
                MessageBox.Show("A település mező kitötlése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmagantelepules.Focus();
            }
            else if (txmaganutca.TextLength < 1)
            {
                MessageBox.Show("Az utca mező kitötlése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmaganutca.Focus();
            }
            else if (txmaganhazszam.TextLength < 1)
            {
                MessageBox.Show("A házszám megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmaganhazszam.Focus();
            }
            else if (cbfizmod.Text == "")
            {
                MessageBox.Show("A fizetési mód megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult valasz = MessageBox.Show($"Minden megadott adat jó? \nNév: {txmagannev.Text} \nIrányítószám:{txmaganirszam.Text} \nTelepülés: {txmagantelepules.Text} \nUtca: {txmaganutca.Text} \nHázszám: {txmaganhazszam.Text}", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (valasz == DialogResult.Yes)
                {
                    string cim = $"{txmaganirszam.Text}, {txmagantelepules.Text}, {txmaganutca.Text}, {txmaganhazszam.Text}";
                    string mentes = "insert into szamla (rendeles_id, nev, tipus, teljesites_datuma, cim, fiz_mod, szla_sorszam, szla_teljsorszam, vegosszeg) values('"+ rid +"', '" + txmagannev.Text + "', 'magan', '"+ DateTime.Now.ToString("yyyy-MM-dd") +"', '" + cim + "','"+ cbfizmod.Text +"', '" + sorszam + "', '" + teljsorsz + "', '" + lbvegeafaval.Text + "')";
                    Adatbazis ab = new Adatbazis(mentes);
                    ab.Dr.Read();
                    ab.lezaras();

                    string szamlaMappaEleres = "..\\..\\..\\turboTanyer\\szamlak\\";
                    Directory.CreateDirectory(szamlaMappaEleres);
                    string lekerdezes = "select szla_teljsorszam from szamla order by szla_sorszam desc limit 1";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    string szamlaNeve = ab.Dr["szla_teljsorszam"].ToString().Replace("/", "_");
                    ab.lezaras();
                    string filePath = Path.Combine(szamlaMappaEleres, szamlaNeve + ".txt");

                    List<string> tetelL = new List<string>();
                    lekerdezes = "select kosar.termek_nev, kosar.term_db_szam, kosar.brutto_osszeg from kosar, rendeles where rendeles.rendeles_id = kosar.rendeles_id and rendeles.asztalszam ='" + cbasztal.Text + "' and rendeles.allapot = 'kiadva'";
                    ab = new Adatbazis(lekerdezes);
                    while (ab.Dr.Read())
                    {
                        string termek_nev = ab.Dr["termek_nev"].ToString();
                        string db = ab.Dr["term_db_szam"].ToString();
                        string osszeg = ab.Dr["brutto_osszeg"].ToString();
                        string sor = termek_nev.PadRight(25) +
                                     db.PadLeft(3) + " db   " +
                                     osszeg.PadLeft(8) + " Ft";
                        tetelL.Add(sor);
                    }
                    string tartalom = "                  Turbó Tányér                  " +
                                      "\n         1129, Budapest, Üteg utca 15.        " +
                                      "\n             Adószám: 12345678-1-2            " +
                                      "\n      Elérhetőségünk: tel.: 06 20 1234567     " +
                                      "\n----------------------------------------------" +
                                      "\n                    Számla                    " +
                                      "\n----------------------------------------------" +
                                      $"\nSzámla sorszáma: {teljsorsz}" +
                                      $"\nSzámla kelte: {dtkiallitasido.Text}" +
                                      $"\nTeljesítési határidő: {DateTime.Now}" +
                                      $"\nFizetési mód: {cbfizmod.Text}" +
                                      "\n----------------------------------------------" +
                                      $"\n                     Tételek:                " +
                                      "\n----------------------------------------------\n\n";
                    tartalom += "Termék".PadRight(25) +
                                "db".PadLeft(5) +
                                "   Ár".PadLeft(10) + "\n" +
                                "----------------------------------------------\n";
                    foreach (var tetel in tetelL)
                    {
                        tartalom += tetel + "\n";
                    }
                    tartalom += "\n----------------------------------------------\n" +
                               $"Végösszeg áfa nélkül:".PadRight(35) + lbvegeafanelkul.Text.PadLeft(10) + "\n" +
                               $"Áfa értéke összesen:".PadRight(35) + lbafaertekossz.Text.PadLeft(10) + "\n" +
                               $"Szervízdíj:".PadRight(35) + lbszervizdíj.Text.PadLeft(10) + "\n" +
                               "\n" +
                               "==============================================\n\n" +
                               $"TELJES VÉGÖSSZEG:".PadRight(30) + lbvegeafaval.Text.PadLeft(15) + "\n" +
                               "\n" +
                               "==============================================\n";
                    File.WriteAllText(filePath, tartalom);

                    string veglegesites = "update rendeles set allapot = 'lezárva' where asztalszam = '" + cbasztal.Text + "'";
                    ab = new Adatbazis(veglegesites);
                    ab.Dr.Read();
                    ab.lezaras();
                    MessageBox.Show("A számla elkészült, megtekinthető a 'szamlak' mappában.", "Sikeres mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
        public frmSzamla()
        {
            InitializeComponent();
            panel1.Visible = false;
            for (int i = 0; i < asztalszamok.Length; i++)
            {
                cbasztal.Items.Add(asztalszamok[i]);
            }
            for (int i = 0;i < fizmod.Length; i++)
            {
                cbfizmod.Items.Add(fizmod[i]);
            }
            dtkiallitasido.Value = DateTime.Now;
            pceges.Visible = false;
            pmagan.Visible = false;
            szlaSorszam();
            dgadatok.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void cbasztal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbasztal.SelectedIndex >= 0)
            {
                panel1.Visible = true;
                feltoltes();
                Vegosszegek();
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void btmegszakit_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan megszakítja?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(valasz == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cbfizmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmSzamla_Load(object sender, EventArgs e)
        {
            
        }

        private void rbmagan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmagan.Checked)
            {
                pmagan.Visible = true;
                pceges.Visible = false;
            }

        }

        private void dtkiallitasido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbceg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbceg.Checked)
            {
                pmagan.Visible = false;
                pceges.Visible = true;
            }
        }

        private void btkiallitas_Click(object sender, EventArgs e)
        {
            if (rbceg.Checked)
            {
                cegesCim();
            }
            else if(rbmagan.Checked)
            {
                maganCim();
            }
            else
            {
                MessageBox.Show("Az adatok megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
        }

        private void lbafaertekossz_Click(object sender, EventArgs e)
        {
            Vegosszegek();
        }

        private void txmaganirszam_TextChanged(object sender, EventArgs e)
        {
            if (txmaganirszam.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txmaganirszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az irányítószám csak számokból áll!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txmaganirszam.Clear();
                    txmaganirszam.Focus();
                }
            }
        }

        private void txcegesirszam_TextChanged(object sender, EventArgs e)
        {
            if (txcegesirszam.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txcegesirszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az irányítószám csak számokból áll!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txcegesirszam.Clear();
                    txcegesirszam.Focus();
                }
            }
        }

        private void txcegeshazszam_TextChanged(object sender, EventArgs e)
        {
            if (txcegeshazszam.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txcegeshazszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az házszám csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txcegeshazszam.Clear();
                    txcegeshazszam.Focus();
                }
            }
        }

        private void txmaganhazszam_TextChanged(object sender, EventArgs e)
        {
            if (txmaganhazszam.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txmaganhazszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az házszám csak szám lehet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txmaganhazszam.Clear();
                    txmaganhazszam.Focus();
                }
            }
        }

        private void txmaganirszam_TextChanged_1(object sender, EventArgs e)
        {
            if (txmaganirszam.TextLength > 1)
            {
                try
                {
                    int irszam = Convert.ToInt32(txmaganirszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az irámyítószám csak számokat tartalmazhat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txmaganirszam.Clear();
                    txmaganirszam.Focus();
                }
            }
        }

        private void txcegesirszam_TextChanged_1(object sender, EventArgs e)
        {
            if (txcegesirszam.TextLength > 1)
            {
                try
                {
                    int irszam = Convert.ToInt32(txcegesirszam.Text);
                }
                catch
                {
                    MessageBox.Show("Az irámyítószám csak számokat tartalmazhat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txcegesirszam.Clear();
                    txcegesirszam.Focus();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
