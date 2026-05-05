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
    public partial class frmHozzaadas : Form
    {
        string[] asztalszamok = { "A1", "A2", "A3", "A4", "A5",
                              "B1", "B2", "B3", "B4", "B5",
                              "C1", "C2", "C3", "C4", "C5",
                              "D1", "D2", "D3", "D4", "D5",
                              "E1", "E2", "E3", "E4", "E5"};
        int aktualisRendelesId = 0;
        int x = 0;
        public event Action AdatValtozott;
        public frmHozzaadas()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }


            for (int i = 0; i < asztalszamok.Length; i++)
            {
                cbasztal.Items.Add(asztalszamok[i]);
            }
            panel1.Visible = false;
            feltoltes();
            dgtermekek.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void frmHozzaadas_Load(object sender, EventArgs e)
        {

        }

        void feltoltes()
        {
            dgtermekek.Rows.Clear();
            string kereses = "";
            if(txkereses.TextLength >= 0)
            {
                kereses = " where termek_nev like '" + txkereses.Text + "%' ";
            }
            string lekerdezes = "select termek_nev, netto_egyseg_ar, leiras from etlap" + kereses + " ";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgtermekek.Rows.Add(ab.Dr["termek_nev"], ab.Dr["netto_egyseg_ar"], ab.Dr["leiras"]);
            }
            ab.lezaras();
        }


        void tisztitas()
        {
            lbnev.Text = "kattintson egy mezőre*";
            lbnear.Text = "kattintson egy mezőre*";
            lbleiras.Text = "kattintson egy mezőre*";
            txnev.Clear();
            txnear.Clear();
            txdb.Clear();
            txossz.Clear();
            txkereses.Clear();
            feltoltes();
        }

        private void cbasztal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbasztal.SelectedIndex >= 0)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void btvissza_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txkereses_TextChanged_1(object sender, EventArgs e)
        {
            feltoltes();
        }

        private void dgtermekek_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewRow sor = dgtermekek.Rows[e.RowIndex];
            lbnev.Text = sor.Cells["termek_nev"].Value.ToString();
            lbnear.Text = sor.Cells["netto_egyseg_ar"].Value.ToString();
            lbleiras.Text = sor.Cells["leiras"].Value.ToString();

            txnev.Text = sor.Cells["termek_nev"].Value.ToString();
            txnear.Text = sor.Cells["netto_egyseg_ar"].Value.ToString();
        }

        private void bthozzaad_Click_1(object sender, EventArgs e)
        {
            if (lbnev.Text == "kattintson egy mezőre*")
            {
                MessageBox.Show("Nem választott ki terméket!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txdb.TextLength < 1)
            {
                MessageBox.Show("A rendelt darab megadása kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txdb.Focus();
            }
            else if (Convert.ToInt32(txdb.Text) > 7)
            {
                DialogResult valasz = MessageBox.Show($"Biztosan {Convert.ToInt32(txdb.Text)} db terméket szeretne felvenni?", "Kérdés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (valasz != DialogResult.Yes)
                {
                    txdb.Clear();
                    txdb.Focus();
                }
            }
            else
            {
                string rendeles = "insert into rendeles(rendeles_tipus, asztalszam, vegosszeg) values('APP', '" + cbasztal.Text + "', '" + Convert.ToInt32(txossz.Text) + "')";
                Adatbazis ab = new Adatbazis(rendeles);
                ab.lezaras();

                string idlek = "SELECT rendeles_id as aktualisRendelesId from rendeles order by rendeles_id desc limit 1";
                ab = new Adatbazis(idlek);
                if (ab.Dr.Read())
                {
                    aktualisRendelesId = Convert.ToInt32(ab.Dr["aktualisRendelesId"]);
                }
                ab.lezaras();
                string kosar = "insert into kosar(rendeles_id, termek_nev, term_db_szam, netto_egyseg_ar) values('" + aktualisRendelesId + "', '" + txnev.Text + "', '" + txdb.Text + "', '" + txnear.Text + "')";
                Adatbazis ab2 = new Adatbazis(kosar);
                ab2.lezaras();
                tisztitas();
                AdatValtozott?.Invoke();
            }
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan elveti?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(valasz == DialogResult.Yes)
            {
                tisztitas();
            }
        }

        private void txdb_TextChanged(object sender, EventArgs e)
        {
            if (txdb.TextLength >= 1)
            {
                try
                {
                    int db = Convert.ToInt32(txdb.Text);
                    txossz.Text = (Convert.ToInt32(txdb.Text) * Convert.ToInt32(txnear.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Csak számot adhat meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txdb.Clear();
                    txdb.Focus();
                }
            }
        }

        private void txossz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
