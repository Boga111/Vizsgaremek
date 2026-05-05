namespace turboTanyer
{
    partial class frmHozzaadas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txossz = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txdb = new System.Windows.Forms.TextBox();
            this.txnear = new System.Windows.Forms.TextBox();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btvissza = new System.Windows.Forms.Button();
            this.txkereses = new System.Windows.Forms.TextBox();
            this.btelvet = new System.Windows.Forms.Button();
            this.bthozzaad = new System.Windows.Forms.Button();
            this.lbleiras = new System.Windows.Forms.Label();
            this.lbnear = new System.Windows.Forms.Label();
            this.lbnev = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dgtermekek = new System.Windows.Forms.DataGridView();
            this.termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_egyseg_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbasztal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtermekek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turbó tányér";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txossz);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txdb);
            this.panel1.Controls.Add(this.txnear);
            this.panel1.Controls.Add(this.txnev);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btvissza);
            this.panel1.Controls.Add(this.txkereses);
            this.panel1.Controls.Add(this.btelvet);
            this.panel1.Controls.Add(this.bthozzaad);
            this.panel1.Controls.Add(this.lbleiras);
            this.panel1.Controls.Add(this.lbnear);
            this.panel1.Controls.Add(this.lbnev);
            this.panel1.Controls.Add(this.lb4);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.dgtermekek);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(57, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 499);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Ft";
            // 
            // txossz
            // 
            this.txossz.Enabled = false;
            this.txossz.Location = new System.Drawing.Point(506, 203);
            this.txossz.Name = "txossz";
            this.txossz.Size = new System.Drawing.Size(79, 20);
            this.txossz.TabIndex = 6;
            this.txossz.TextChanged += new System.EventHandler(this.txossz_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Összesen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Termék felvétele:";
            // 
            // txdb
            // 
            this.txdb.Location = new System.Drawing.Point(506, 172);
            this.txdb.MaxLength = 2;
            this.txdb.Name = "txdb";
            this.txdb.Size = new System.Drawing.Size(100, 20);
            this.txdb.TabIndex = 5;
            this.txdb.TextChanged += new System.EventHandler(this.txdb_TextChanged);
            // 
            // txnear
            // 
            this.txnear.Enabled = false;
            this.txnear.Location = new System.Drawing.Point(506, 142);
            this.txnear.Name = "txnear";
            this.txnear.Size = new System.Drawing.Size(100, 20);
            this.txnear.TabIndex = 4;
            // 
            // txnev
            // 
            this.txnev.Enabled = false;
            this.txnev.Location = new System.Drawing.Point(506, 111);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(100, 20);
            this.txnev.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kért darab:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nettó ár:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Termék választás:";
            // 
            // btvissza
            // 
            this.btvissza.ForeColor = System.Drawing.Color.Black;
            this.btvissza.Location = new System.Drawing.Point(481, 311);
            this.btvissza.Name = "btvissza";
            this.btvissza.Size = new System.Drawing.Size(92, 65);
            this.btvissza.TabIndex = 9;
            this.btvissza.Text = "Vissza";
            this.btvissza.UseVisualStyleBackColor = true;
            this.btvissza.Click += new System.EventHandler(this.btvissza_Click);
            // 
            // txkereses
            // 
            this.txkereses.Location = new System.Drawing.Point(95, 43);
            this.txkereses.Name = "txkereses";
            this.txkereses.Size = new System.Drawing.Size(193, 20);
            this.txkereses.TabIndex = 2;
            this.txkereses.TextChanged += new System.EventHandler(this.txkereses_TextChanged_1);
            // 
            // btelvet
            // 
            this.btelvet.ForeColor = System.Drawing.Color.Black;
            this.btelvet.Location = new System.Drawing.Point(529, 240);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(92, 65);
            this.btelvet.TabIndex = 8;
            this.btelvet.Text = "Elvet";
            this.btelvet.UseVisualStyleBackColor = true;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // bthozzaad
            // 
            this.bthozzaad.ForeColor = System.Drawing.Color.Black;
            this.bthozzaad.Location = new System.Drawing.Point(410, 240);
            this.bthozzaad.Name = "bthozzaad";
            this.bthozzaad.Size = new System.Drawing.Size(113, 65);
            this.bthozzaad.TabIndex = 7;
            this.bthozzaad.Text = "Hozzáadás a rendeléshez";
            this.bthozzaad.UseVisualStyleBackColor = true;
            this.bthozzaad.Click += new System.EventHandler(this.bthozzaad_Click_1);
            // 
            // lbleiras
            // 
            this.lbleiras.AutoSize = true;
            this.lbleiras.Location = new System.Drawing.Point(184, 452);
            this.lbleiras.Name = "lbleiras";
            this.lbleiras.Size = new System.Drawing.Size(136, 13);
            this.lbleiras.TabIndex = 22;
            this.lbleiras.Text = "kattintson egy mezőre*";
            // 
            // lbnear
            // 
            this.lbnear.AutoSize = true;
            this.lbnear.Location = new System.Drawing.Point(184, 417);
            this.lbnear.Name = "lbnear";
            this.lbnear.Size = new System.Drawing.Size(136, 13);
            this.lbnear.TabIndex = 21;
            this.lbnear.Text = "kattintson egy mezőre*";
            // 
            // lbnev
            // 
            this.lbnev.AutoSize = true;
            this.lbnev.Location = new System.Drawing.Point(184, 385);
            this.lbnev.Name = "lbnev";
            this.lbnev.Size = new System.Drawing.Size(136, 13);
            this.lbnev.TabIndex = 20;
            this.lbnev.Text = "kattintson egy mezőre*";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(61, 452);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(47, 13);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "Leírás:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(59, 417);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(101, 13);
            this.lb2.TabIndex = 18;
            this.lb2.Text = "Nettó egység ár:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(61, 385);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(82, 13);
            this.lb1.TabIndex = 17;
            this.lb1.Text = "Megnevezés:";
            // 
            // dgtermekek
            // 
            this.dgtermekek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtermekek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termek_nev,
            this.netto_egyseg_ar,
            this.leiras});
            this.dgtermekek.Location = new System.Drawing.Point(16, 71);
            this.dgtermekek.Name = "dgtermekek";
            this.dgtermekek.RowHeadersWidth = 51;
            this.dgtermekek.Size = new System.Drawing.Size(374, 288);
            this.dgtermekek.TabIndex = 16;
            this.dgtermekek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtermekek_CellClick_1);
            // 
            // termek_nev
            // 
            this.termek_nev.HeaderText = "Név";
            this.termek_nev.MinimumWidth = 6;
            this.termek_nev.Name = "termek_nev";
            this.termek_nev.ReadOnly = true;
            this.termek_nev.Width = 125;
            // 
            // netto_egyseg_ar
            // 
            this.netto_egyseg_ar.HeaderText = "Nettó ár";
            this.netto_egyseg_ar.MinimumWidth = 6;
            this.netto_egyseg_ar.Name = "netto_egyseg_ar";
            this.netto_egyseg_ar.ReadOnly = true;
            this.netto_egyseg_ar.Width = 70;
            // 
            // leiras
            // 
            this.leiras.HeaderText = "Leírás";
            this.leiras.MinimumWidth = 6;
            this.leiras.Name = "leiras";
            this.leiras.ReadOnly = true;
            this.leiras.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Keresés:";
            // 
            // cbasztal
            // 
            this.cbasztal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbasztal.FormattingEnabled = true;
            this.cbasztal.Location = new System.Drawing.Point(407, 84);
            this.cbasztal.Name = "cbasztal";
            this.cbasztal.Size = new System.Drawing.Size(86, 21);
            this.cbasztal.TabIndex = 1;
            this.cbasztal.SelectedIndexChanged += new System.EventHandler(this.cbasztal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Válasszon asztalt:";
            // 
            // frmHozzaadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(744, 672);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbasztal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHozzaadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Termék hozzáadása";
            this.Load += new System.EventHandler(this.frmHozzaadas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtermekek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txkereses;
        private System.Windows.Forms.Button btelvet;
        private System.Windows.Forms.Button bthozzaad;
        private System.Windows.Forms.Label lbleiras;
        private System.Windows.Forms.Label lbnear;
        private System.Windows.Forms.Label lbnev;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dgtermekek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbasztal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btvissza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txdb;
        private System.Windows.Forms.TextBox txnear;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txossz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_egyseg_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn leiras;
    }
}