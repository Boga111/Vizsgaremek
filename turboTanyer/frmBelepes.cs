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
    public partial class frmBelepes : Form
    {
        string pincer_pin = "";
        string konyha_pin = "";
        string helyf_pin = "";
        void pinLekerdezes()
        {
            string lekerd = "select pin from alkalm_felhasz where felhasznalok = 'pincer'";
            Adatbazis ab = new Adatbazis(lekerd);
            if (ab.Dr.Read())
            {
                pincer_pin = ab.Dr["pin"].ToString();
            }
            ab.lezaras();

            lekerd = "select pin from alkalm_felhasz where felhasznalok = 'konyha'";
            ab = new Adatbazis(lekerd);
            if (ab.Dr.Read())
            {
                konyha_pin = ab.Dr["pin"].ToString();
            }
            ab.lezaras();

            lekerd = "select pin from alkalm_felhasz where felhasznalok = 'helyfoglalas'";
            ab = new Adatbazis(lekerd);
            if (ab.Dr.Read())
            {
                helyf_pin = ab.Dr["pin"].ToString();
            }
            ab.lezaras();
        }
        public frmBelepes()
        {
            InitializeComponent();
            pinLekerdezes();
        }

        private void frmBelepes_Load(object sender, EventArgs e)
        {

        }

        private void btbelepes_Click(object sender, EventArgs e)
        {
            if (cbfelhaszn.Text == "")
            {
                MessageBox.Show("Válasszon ki egy felhasználó típust!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbfelhaszn.Focus();
            }
            else if (cbfelhaszn.Text == "Pincér")
            {
                if (txpin.Text == pincer_pin)
                {
                    frmPincerIndex pincer = new frmPincerIndex();
                    pincer.ShowDialog();
                    txpin.Clear();
                }
                else
                {
                    MessageBox.Show("Hibás pinkód!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txpin.Focus();
                    txpin.Clear();
                }
            }
            else if (cbfelhaszn.Text == "Konyha")
            {
                if (txpin.Text == konyha_pin)
                {
                    frmKonyhaIndex konyha = new frmKonyhaIndex();
                    konyha.ShowDialog();
                    txpin.Clear();
                }
                else
                {
                    MessageBox.Show("Hibás pinkód!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txpin.Focus();
                    txpin.Clear();
                }
            }
            else if (cbfelhaszn.Text == "Asztalfoglalás")
            {
                if (txpin.Text == helyf_pin)
                {
                    frmhelyfoglalas foglalas = new frmhelyfoglalas();
                    foglalas.ShowDialog();
                    txpin.Clear();
                }
                else
                {
                    MessageBox.Show("Hibás pinkód!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txpin.Clear();
                    txpin.Focus();
                }
            }
        }
    }
}
