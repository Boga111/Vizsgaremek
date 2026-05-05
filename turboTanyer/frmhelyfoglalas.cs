using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class frmhelyfoglalas : Form
    {
        string[] asztalszamok = { "A1", "A2", "A3", "A4", "A5",
                                  "B1", "B2", "B3", "B4", "B5",
                                  "C1", "C2", "C3", "C4", "C5",
                                  "D1", "D2", "D3", "D4", "D5",
                                  "E1", "E2", "E3", "E4", "E5"};
        string valasztottAsztal;
        int varhatoFo = 0;
        void feltoltes()
        {
            dgfoglalasok.Rows.Clear();
            string kereses = "";
            if (txfoglalas.TextLength > 0)
            {
                kereses = " and nev like '" + txfoglalas.Text + "%'";
            }
            string lekerdezes = "select nev, asztalszam, idopont, fo_db from helyfoglalas where allapot = 'folyamatban' " + kereses + " order by idopont asc";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while(ab.Dr.Read())
            {
                dgfoglalasok.Rows.Add(ab.Dr["nev"], ab.Dr["asztalszam"], ab.Dr["idopont"], ab.Dr["fo_db"]);
            }
        }

        void asztalEllenorzes()
        {
            string asztal;
            int fo = 0;
            if (txasztalszam.TextLength > 0 && txfo_db.TextLength > 0)
            { 
                asztal = txasztalszam.Text.Trim().ToUpper();
                fo = Convert.ToInt32(txfo_db.Text);

                if (!asztalszamok.Contains(asztal))
                {
                    MessageBox.Show("Ilyen asztal nem létezik, válasszon másikat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txasztalszam.Clear();
                    txfo_db.Clear();
                    txasztalszam.Focus();
                    return;
                }

                int maxFo = 0;

                if (asztal.StartsWith("A")) maxFo = 2;
                else if (asztal.StartsWith("B")) maxFo = 4;
                else if (asztal.StartsWith("C")) maxFo = 6;
                else if (asztal.StartsWith("D")) maxFo = 8;
                else if (asztal.StartsWith("E")) maxFo = 10;

                if (fo > maxFo)
                {
                    MessageBox.Show($"A személyek száma nem lehet több mint {maxFo}!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txfo_db.Clear();
                    txasztalszam.Clear();
                    txfo_db.Focus();
                }
                if(txasztalszam.TextLength != 2)
                {
                    MessageBox.Show("Nem megfelelő asztalszám!", "Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txasztalszam.Focus();
                    return;
                }

                DateTime ujido = dtdatum.Value;
                if (ujido < DateTime.Now)
                {
                    MessageBox.Show("Múltbeli időpontra nem lehet foglalni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtdatum.Focus();
                    return;
                }
                string lekerd = "select idopont from helyfoglalas where asztalszam = '"+txasztalszam.Text+ "' and idopont between DATE_ADD('"+ ujido.ToString("yyyy-MM-dd HH:mm:ss") + "', INTERVAL -2 HOUR) and DATE_ADD('"+ ujido.ToString("yyyy-MM-dd HH:mm:ss") +"', INTERVAL 2 HOUR) order by idopont";
                Adatbazis ab = new Adatbazis(lekerd);
                List<DateTime> foglalasok = new List<DateTime>();
                while (ab.Dr.Read())
                {
                    foglalasok.Add(Convert.ToDateTime(ab.Dr["idopont"]));
                }
                if (foglalasok.Count > 0)
                {
                    string uzi = "Az asztal foglalt: \n\n";
                    DateTime legkesobbiidopont = DateTime.MinValue;
                    foreach(var ido in foglalasok)
                    {
                        DateTime utsofoglalas = ido.AddHours(2);
                        uzi += $"{ido:yyyy. MM. dd. HH:mm} - {utsofoglalas:yyyy. MM. dd. HH:mm}\n";
                        if (legkesobbiidopont < utsofoglalas)
                        {
                            legkesobbiidopont = utsofoglalas;
                        }
                    }
                    uzi += $"\nLegközelebb: {legkesobbiidopont:yyyy. MM. dd. HH:mm} kor foglalható az asztal.";
                    MessageBox.Show(uzi, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtdatum.Focus();
                    ab.lezaras();
                }
                else
                {
                    valasztottAsztal = asztal;
                    varhatoFo = fo;
                }
            }
        }


        void tisztitas()
        {
            txnev.Clear();
            txfo_db.Clear();
            txasztalszam.Clear();
            dtdatum.Value = DateTime.Now;
        }
        public frmhelyfoglalas()
        {
            InitializeComponent();
            feltoltes();
            panel1.Visible = false;
            dtdatum.Value = DateTime.Now;
            dtdatum.MinDate = DateTime.Now;
            dgfoglalasok.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btvissza_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos kilép?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(valasz == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgfoglalasok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewRow sor = dgfoglalasok.Rows[e.RowIndex];
            string hnev = sor.Cells["nev"].Value.ToString();
            DateTime foglaltNap = Convert.ToDateTime(sor.Cells["idopont"].Value.ToString());
            DateTime maiNap = DateTime.Today;
            DialogResult valasz = MessageBox.Show("Megjött a foglaló?", "Kérdés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                if (foglaltNap.Date != maiNap)
                {
                    MessageBox.Show("Csak a mai napi foglalást lehet átállítani!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string lekerdezes = "update helyfoglalas set allapot = 'megjött' where nev = '" + hnev + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    feltoltes();
                    ab.lezaras();
                }
            }
            else if(valasz == DialogResult.No)
            {
                string lekerdezes = "update helyfoglalas set allapot = 'törölve' where nev = '" + hnev + "'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                feltoltes();
                ab.lezaras();
            }
        }

        private void txfoglalas_TextChanged(object sender, EventArgs e)
        {
            feltoltes();
        }

        private void rbujfoglalas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbujfoglalas.Checked)
            {
                panel1.Visible = true;
                rtasztalsegitseg.Text = "A1 - A5: 2 személyes asztalok\r\nB1 - B5: 4 személyes asztalok\r\nC1 - C5: 6 személyes asztalok\r\nD1 - D5: 8 személyes asztalok\r\nE1 - E5: 10 személyes asztalok";
            }
        }

        private void txfo_db_TextChanged(object sender, EventArgs e)
        {
            if (txfo_db.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txfo_db.Text);
                    asztalEllenorzes();
                }
                catch
                {
                    MessageBox.Show("Csak számot adhat meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txfo_db.Clear();
                    txfo_db.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength < 1)
            {
                MessageBox.Show("A név megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if (txfo_db.TextLength < 1)
            {
                MessageBox.Show("A várható személyek számának megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txfo_db.Focus();
            }
            else if (txasztalszam.TextLength < 1)
            {
                MessageBox.Show("Az asztalszám megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txasztalszam.Focus();
            }
            else
            {
                string lekerdezes = "insert into helyfoglalas(asztalszam, idopont, fo_db, nev) values('" + valasztottAsztal +"', '"+dtdatum.Text+"', '"+ varhatoFo +"', '"+txnev.Text+"')";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                ab.lezaras();
                tisztitas();
                feltoltes();
            }
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("biztosan elveti?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                tisztitas();
            }
        }

        private void txasztalszam_TextChanged(object sender, EventArgs e)
        {
            if (txasztalszam.TextLength > 1)
            {
                asztalEllenorzes();
            }
        }

        private void frmhelyfoglalas_Load(object sender, EventArgs e)
        {

        }
    }
}
