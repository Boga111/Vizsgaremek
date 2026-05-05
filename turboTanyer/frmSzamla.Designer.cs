namespace turboTanyer
{
    partial class frmSzamla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbasztal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbszamlasorszam = new System.Windows.Forms.Label();
            this.lbszervizdíj = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbvegeafaval = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbafaertekossz = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbfizmod = new System.Windows.Forms.ComboBox();
            this.dtkiallitasido = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.pmagan = new System.Windows.Forms.Panel();
            this.txmaganhazszam = new System.Windows.Forms.TextBox();
            this.txmaganutca = new System.Windows.Forms.TextBox();
            this.txmagantelepules = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txmagannev = new System.Windows.Forms.TextBox();
            this.txmaganirszam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pceges = new System.Windows.Forms.Panel();
            this.txcegesnev = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txcegeshazszam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txcegesutca = new System.Windows.Forms.TextBox();
            this.txcegestelepules = new System.Windows.Forms.TextBox();
            this.txcegesadoszam = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txcegesirszam = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbceg = new System.Windows.Forms.RadioButton();
            this.rbmagan = new System.Windows.Forms.RadioButton();
            this.lbvegeafanelkul = new System.Windows.Forms.Label();
            this.btmegszakit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btkiallitas = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_egyseg_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_db_szam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto_osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afa_kulcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afa_ertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pmagan.SuspendLayout();
            this.pceges.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turbó tányér";
            // 
            // cbasztal
            // 
            this.cbasztal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbasztal.FormattingEnabled = true;
            this.cbasztal.Location = new System.Drawing.Point(505, 45);
            this.cbasztal.Name = "cbasztal";
            this.cbasztal.Size = new System.Drawing.Size(121, 21);
            this.cbasztal.TabIndex = 1;
            this.cbasztal.SelectedIndexChanged += new System.EventHandler(this.cbasztal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asztal kiválasztása:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbszamlasorszam);
            this.panel1.Controls.Add(this.lbszervizdíj);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lbvegeafaval);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbafaertekossz);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbfizmod);
            this.panel1.Controls.Add(this.dtkiallitasido);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pmagan);
            this.panel1.Controls.Add(this.pceges);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbvegeafanelkul);
            this.panel1.Controls.Add(this.btmegszakit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btkiallitas);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.dgadatok);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 687);
            this.panel1.TabIndex = 3;
            // 
            // lbszamlasorszam
            // 
            this.lbszamlasorszam.AutoSize = true;
            this.lbszamlasorszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbszamlasorszam.Location = new System.Drawing.Point(1079, 20);
            this.lbszamlasorszam.Name = "lbszamlasorszam";
            this.lbszamlasorszam.Size = new System.Drawing.Size(61, 15);
            this.lbszamlasorszam.TabIndex = 5;
            this.lbszamlasorszam.Text = "sorszam";
            this.lbszamlasorszam.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbszervizdíj
            // 
            this.lbszervizdíj.AutoSize = true;
            this.lbszervizdíj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbszervizdíj.Location = new System.Drawing.Point(884, 558);
            this.lbszervizdíj.Name = "lbszervizdíj";
            this.lbszervizdíj.Size = new System.Drawing.Size(31, 15);
            this.lbszervizdíj.TabIndex = 24;
            this.lbszervizdíj.Text = "0 Ft";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(948, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Számla sorszáma:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(606, 558);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 15);
            this.label21.TabIndex = 23;
            this.label21.Text = "Szervíz díj:";
            // 
            // lbvegeafaval
            // 
            this.lbvegeafaval.AutoSize = true;
            this.lbvegeafaval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbvegeafaval.Location = new System.Drawing.Point(884, 582);
            this.lbvegeafaval.Name = "lbvegeafaval";
            this.lbvegeafaval.Size = new System.Drawing.Size(31, 15);
            this.lbvegeafaval.TabIndex = 22;
            this.lbvegeafaval.Text = "0 Ft";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(606, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Teljes végösszeg (áfa-val):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(606, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fizetési mód:";
            // 
            // lbafaertekossz
            // 
            this.lbafaertekossz.AutoSize = true;
            this.lbafaertekossz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbafaertekossz.Location = new System.Drawing.Point(888, 535);
            this.lbafaertekossz.Name = "lbafaertekossz";
            this.lbafaertekossz.Size = new System.Drawing.Size(27, 15);
            this.lbafaertekossz.TabIndex = 20;
            this.lbafaertekossz.Text = "0Ft";
            this.lbafaertekossz.Click += new System.EventHandler(this.lbafaertekossz_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(606, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Áfa értéke összesen:";
            // 
            // cbfizmod
            // 
            this.cbfizmod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfizmod.FormattingEnabled = true;
            this.cbfizmod.Location = new System.Drawing.Point(798, 633);
            this.cbfizmod.Name = "cbfizmod";
            this.cbfizmod.Size = new System.Drawing.Size(121, 21);
            this.cbfizmod.TabIndex = 5;
            this.cbfizmod.SelectedIndexChanged += new System.EventHandler(this.cbfizmod_SelectedIndexChanged);
            // 
            // dtkiallitasido
            // 
            this.dtkiallitasido.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtkiallitasido.Enabled = false;
            this.dtkiallitasido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkiallitasido.Location = new System.Drawing.Point(740, 604);
            this.dtkiallitasido.Name = "dtkiallitasido";
            this.dtkiallitasido.Size = new System.Drawing.Size(179, 20);
            this.dtkiallitasido.TabIndex = 18;
            this.dtkiallitasido.ValueChanged += new System.EventHandler(this.dtkiallitasido_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(606, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kiállítás dátuma:";
            // 
            // pmagan
            // 
            this.pmagan.Controls.Add(this.txmaganhazszam);
            this.pmagan.Controls.Add(this.txmaganutca);
            this.pmagan.Controls.Add(this.txmagantelepules);
            this.pmagan.Controls.Add(this.label15);
            this.pmagan.Controls.Add(this.label14);
            this.pmagan.Controls.Add(this.label9);
            this.pmagan.Controls.Add(this.label7);
            this.pmagan.Controls.Add(this.txmagannev);
            this.pmagan.Controls.Add(this.txmaganirszam);
            this.pmagan.Controls.Add(this.label10);
            this.pmagan.Controls.Add(this.label5);
            this.pmagan.Location = new System.Drawing.Point(951, 161);
            this.pmagan.Name = "pmagan";
            this.pmagan.Size = new System.Drawing.Size(452, 187);
            this.pmagan.TabIndex = 16;
            // 
            // txmaganhazszam
            // 
            this.txmaganhazszam.Location = new System.Drawing.Point(149, 156);
            this.txmaganhazszam.Name = "txmaganhazszam";
            this.txmaganhazszam.Size = new System.Drawing.Size(59, 20);
            this.txmaganhazszam.TabIndex = 22;
            // 
            // txmaganutca
            // 
            this.txmaganutca.Location = new System.Drawing.Point(149, 130);
            this.txmaganutca.Name = "txmaganutca";
            this.txmaganutca.Size = new System.Drawing.Size(152, 20);
            this.txmaganutca.TabIndex = 21;
            // 
            // txmagantelepules
            // 
            this.txmagantelepules.Location = new System.Drawing.Point(149, 104);
            this.txmagantelepules.Name = "txmagantelepules";
            this.txmagantelepules.Size = new System.Drawing.Size(152, 20);
            this.txmagantelepules.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Házszám:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Utca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Település:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Irányítószám:";
            // 
            // txmagannev
            // 
            this.txmagannev.Location = new System.Drawing.Point(149, 15);
            this.txmagannev.Name = "txmagannev";
            this.txmagannev.Size = new System.Drawing.Size(260, 20);
            this.txmagannev.TabIndex = 9;
            // 
            // txmaganirszam
            // 
            this.txmaganirszam.Location = new System.Drawing.Point(149, 78);
            this.txmaganirszam.MaxLength = 4;
            this.txmaganirszam.Name = "txmaganirszam";
            this.txmaganirszam.Size = new System.Drawing.Size(59, 20);
            this.txmaganirszam.TabIndex = 15;
            this.txmaganirszam.TextChanged += new System.EventHandler(this.txmaganirszam_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(38, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Számlázási adatok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Számlán szereplő név:";
            // 
            // pceges
            // 
            this.pceges.Controls.Add(this.txcegesnev);
            this.pceges.Controls.Add(this.label22);
            this.pceges.Controls.Add(this.txcegeshazszam);
            this.pceges.Controls.Add(this.label8);
            this.pceges.Controls.Add(this.txcegesutca);
            this.pceges.Controls.Add(this.txcegestelepules);
            this.pceges.Controls.Add(this.txcegesadoszam);
            this.pceges.Controls.Add(this.label16);
            this.pceges.Controls.Add(this.label6);
            this.pceges.Controls.Add(this.label17);
            this.pceges.Controls.Add(this.txcegesirszam);
            this.pceges.Controls.Add(this.label18);
            this.pceges.Controls.Add(this.label19);
            this.pceges.Location = new System.Drawing.Point(951, 354);
            this.pceges.Name = "pceges";
            this.pceges.Size = new System.Drawing.Size(452, 214);
            this.pceges.TabIndex = 13;
            // 
            // txcegesnev
            // 
            this.txcegesnev.Location = new System.Drawing.Point(153, 46);
            this.txcegesnev.Name = "txcegesnev";
            this.txcegesnev.Size = new System.Drawing.Size(161, 20);
            this.txcegesnev.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Számlán szereplő név:";
            // 
            // txcegeshazszam
            // 
            this.txcegeshazszam.Location = new System.Drawing.Point(153, 178);
            this.txcegeshazszam.Name = "txcegeshazszam";
            this.txcegeshazszam.Size = new System.Drawing.Size(57, 20);
            this.txcegeshazszam.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(68, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telephely adatai";
            // 
            // txcegesutca
            // 
            this.txcegesutca.Location = new System.Drawing.Point(153, 152);
            this.txcegesutca.Name = "txcegesutca";
            this.txcegesutca.Size = new System.Drawing.Size(152, 20);
            this.txcegesutca.TabIndex = 29;
            // 
            // txcegestelepules
            // 
            this.txcegestelepules.Location = new System.Drawing.Point(153, 126);
            this.txcegestelepules.Name = "txcegestelepules";
            this.txcegestelepules.Size = new System.Drawing.Size(152, 20);
            this.txcegestelepules.TabIndex = 28;
            // 
            // txcegesadoszam
            // 
            this.txcegesadoszam.Location = new System.Drawing.Point(153, 20);
            this.txcegesadoszam.MaxLength = 15;
            this.txcegesadoszam.Name = "txcegesadoszam";
            this.txcegesadoszam.Size = new System.Drawing.Size(197, 20);
            this.txcegesadoszam.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(86, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Házszám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adószám:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(109, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Utca:";
            // 
            // txcegesirszam
            // 
            this.txcegesirszam.Location = new System.Drawing.Point(153, 100);
            this.txcegesirszam.MaxLength = 4;
            this.txcegesirszam.Name = "txcegesirszam";
            this.txcegesirszam.Size = new System.Drawing.Size(57, 20);
            this.txcegesirszam.TabIndex = 23;
            this.txcegesirszam.TextChanged += new System.EventHandler(this.txcegesirszam_TextChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Település:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Irányítószám:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbceg);
            this.panel2.Controls.Add(this.rbmagan);
            this.panel2.Location = new System.Drawing.Point(951, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 90);
            this.panel2.TabIndex = 12;
            // 
            // rbceg
            // 
            this.rbceg.AutoSize = true;
            this.rbceg.Location = new System.Drawing.Point(30, 57);
            this.rbceg.Name = "rbceg";
            this.rbceg.Size = new System.Drawing.Size(47, 17);
            this.rbceg.TabIndex = 1;
            this.rbceg.TabStop = true;
            this.rbceg.Text = "Cég";
            this.rbceg.UseVisualStyleBackColor = true;
            this.rbceg.CheckedChanged += new System.EventHandler(this.rbceg_CheckedChanged);
            // 
            // rbmagan
            // 
            this.rbmagan.AutoSize = true;
            this.rbmagan.Location = new System.Drawing.Point(26, 22);
            this.rbmagan.Name = "rbmagan";
            this.rbmagan.Size = new System.Drawing.Size(107, 17);
            this.rbmagan.TabIndex = 0;
            this.rbmagan.TabStop = true;
            this.rbmagan.Text = "Magánszemély";
            this.rbmagan.UseVisualStyleBackColor = true;
            this.rbmagan.CheckedChanged += new System.EventHandler(this.rbmagan_CheckedChanged);
            // 
            // lbvegeafanelkul
            // 
            this.lbvegeafanelkul.AutoSize = true;
            this.lbvegeafanelkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbvegeafanelkul.Location = new System.Drawing.Point(888, 511);
            this.lbvegeafanelkul.Name = "lbvegeafanelkul";
            this.lbvegeafanelkul.Size = new System.Drawing.Size(27, 15);
            this.lbvegeafanelkul.TabIndex = 7;
            this.lbvegeafanelkul.Text = "0Ft";
            // 
            // btmegszakit
            // 
            this.btmegszakit.ForeColor = System.Drawing.Color.Black;
            this.btmegszakit.Location = new System.Drawing.Point(1031, 633);
            this.btmegszakit.Name = "btmegszakit";
            this.btmegszakit.Size = new System.Drawing.Size(305, 47);
            this.btmegszakit.TabIndex = 6;
            this.btmegszakit.Text = "Megszakítás";
            this.btmegszakit.UseVisualStyleBackColor = true;
            this.btmegszakit.Click += new System.EventHandler(this.btmegszakit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rendelés összegző:";
            // 
            // btkiallitas
            // 
            this.btkiallitas.ForeColor = System.Drawing.Color.Black;
            this.btkiallitas.Location = new System.Drawing.Point(1031, 574);
            this.btkiallitas.Name = "btkiallitas";
            this.btkiallitas.Size = new System.Drawing.Size(305, 47);
            this.btkiallitas.TabIndex = 2;
            this.btkiallitas.Text = "Számla kiállítása";
            this.btkiallitas.UseVisualStyleBackColor = true;
            this.btkiallitas.Click += new System.EventHandler(this.btkiallitas_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(606, 511);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(157, 15);
            this.label.TabIndex = 1;
            this.label.Text = "Végösszeg (áfa nélkül):";
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termek_nev,
            this.netto_egyseg_ar,
            this.term_db_szam,
            this.netto_osszeg,
            this.brutto_osszeg,
            this.afa_kulcs,
            this.afa_ertek});
            this.dgadatok.Location = new System.Drawing.Point(16, 48);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.RowHeadersWidth = 51;
            this.dgadatok.Size = new System.Drawing.Size(929, 440);
            this.dgadatok.TabIndex = 0;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // termek_nev
            // 
            this.termek_nev.HeaderText = "Termék neve";
            this.termek_nev.MinimumWidth = 6;
            this.termek_nev.Name = "termek_nev";
            this.termek_nev.ReadOnly = true;
            this.termek_nev.Width = 125;
            // 
            // netto_egyseg_ar
            // 
            this.netto_egyseg_ar.HeaderText = "Darab ár";
            this.netto_egyseg_ar.MinimumWidth = 6;
            this.netto_egyseg_ar.Name = "netto_egyseg_ar";
            this.netto_egyseg_ar.ReadOnly = true;
            this.netto_egyseg_ar.Width = 125;
            // 
            // term_db_szam
            // 
            this.term_db_szam.HeaderText = "Rendelt darab";
            this.term_db_szam.MinimumWidth = 6;
            this.term_db_szam.Name = "term_db_szam";
            this.term_db_szam.ReadOnly = true;
            this.term_db_szam.Width = 125;
            // 
            // netto_osszeg
            // 
            this.netto_osszeg.HeaderText = "Nettó végösszeg";
            this.netto_osszeg.MinimumWidth = 6;
            this.netto_osszeg.Name = "netto_osszeg";
            this.netto_osszeg.ReadOnly = true;
            this.netto_osszeg.Width = 125;
            // 
            // brutto_osszeg
            // 
            this.brutto_osszeg.HeaderText = "Bruttó végösszeg";
            this.brutto_osszeg.MinimumWidth = 6;
            this.brutto_osszeg.Name = "brutto_osszeg";
            this.brutto_osszeg.ReadOnly = true;
            this.brutto_osszeg.Width = 125;
            // 
            // afa_kulcs
            // 
            this.afa_kulcs.HeaderText = "Áfa (%)";
            this.afa_kulcs.MinimumWidth = 6;
            this.afa_kulcs.Name = "afa_kulcs";
            this.afa_kulcs.ReadOnly = true;
            this.afa_kulcs.Width = 125;
            // 
            // afa_ertek
            // 
            this.afa_ertek.HeaderText = "Áfa értéke";
            this.afa_ertek.MinimumWidth = 6;
            this.afa_ertek.Name = "afa_ertek";
            this.afa_ertek.ReadOnly = true;
            this.afa_ertek.Width = 125;
            // 
            // frmSzamla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1445, 784);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbasztal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSzamla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Számla kiállítása";
            this.Load += new System.EventHandler(this.frmSzamla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pmagan.ResumeLayout(false);
            this.pmagan.PerformLayout();
            this.pceges.ResumeLayout(false);
            this.pceges.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbasztal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btkiallitas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbfizmod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmegszakit;
        private System.Windows.Forms.Label lbvegeafanelkul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txmagannev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbceg;
        private System.Windows.Forms.RadioButton rbmagan;
        private System.Windows.Forms.TextBox txcegesadoszam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pceges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txmaganirszam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pmagan;
        private System.Windows.Forms.DateTimePicker dtkiallitasido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbvegeafaval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbafaertekossz;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_egyseg_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_db_szam;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto_osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn afa_kulcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn afa_ertek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txmaganhazszam;
        private System.Windows.Forms.TextBox txmaganutca;
        private System.Windows.Forms.TextBox txmagantelepules;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txcegeshazszam;
        private System.Windows.Forms.TextBox txcegesutca;
        private System.Windows.Forms.TextBox txcegestelepules;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txcegesirszam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbszamlasorszam;
        private System.Windows.Forms.Label lbszervizdíj;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txcegesnev;
        private System.Windows.Forms.Label label22;
    }
}