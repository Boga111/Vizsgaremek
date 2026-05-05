namespace turboTanyer
{
    partial class frmPincerIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbasztalszam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pladatok = new System.Windows.Forms.Panel();
            this.btbezaras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfizetendo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btszamla = new System.Windows.Forms.Button();
            this.bthozzaad = new System.Windows.Forms.Button();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.rendeles_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto_egyseg_ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_db_szam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto_osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allapot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgkeszetelek = new System.Windows.Forms.DataGridView();
            this.kesz_termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kesz_asztalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kesz_rendelesid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbkesz = new System.Windows.Forms.Label();
            this.pladatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkeszetelek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbasztalszam
            // 
            this.cbasztalszam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbasztalszam.FormattingEnabled = true;
            this.cbasztalszam.Location = new System.Drawing.Point(593, 66);
            this.cbasztalszam.Name = "cbasztalszam";
            this.cbasztalszam.Size = new System.Drawing.Size(121, 21);
            this.cbasztalszam.TabIndex = 1;
            this.cbasztalszam.SelectedIndexChanged += new System.EventHandler(this.cbasztalszam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asztal megadása:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(508, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turbó tányér";
            // 
            // pladatok
            // 
            this.pladatok.BackColor = System.Drawing.Color.IndianRed;
            this.pladatok.Controls.Add(this.btbezaras);
            this.pladatok.Controls.Add(this.label4);
            this.pladatok.Controls.Add(this.lbfizetendo);
            this.pladatok.Controls.Add(this.label3);
            this.pladatok.Controls.Add(this.btszamla);
            this.pladatok.Controls.Add(this.bthozzaad);
            this.pladatok.Controls.Add(this.dgadatok);
            this.pladatok.Location = new System.Drawing.Point(34, 111);
            this.pladatok.Name = "pladatok";
            this.pladatok.Size = new System.Drawing.Size(913, 482);
            this.pladatok.TabIndex = 3;
            // 
            // btbezaras
            // 
            this.btbezaras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbezaras.ForeColor = System.Drawing.Color.Black;
            this.btbezaras.Location = new System.Drawing.Point(702, 378);
            this.btbezaras.Name = "btbezaras";
            this.btbezaras.Size = new System.Drawing.Size(131, 53);
            this.btbezaras.TabIndex = 7;
            this.btbezaras.Text = "Bezárás";
            this.btbezaras.UseVisualStyleBackColor = true;
            this.btbezaras.Click += new System.EventHandler(this.btbezaras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eddigi rendelések:";
            // 
            // lbfizetendo
            // 
            this.lbfizetendo.AutoSize = true;
            this.lbfizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbfizetendo.Location = new System.Drawing.Point(826, 136);
            this.lbfizetendo.Name = "lbfizetendo";
            this.lbfizetendo.Size = new System.Drawing.Size(31, 15);
            this.lbfizetendo.TabIndex = 4;
            this.lbfizetendo.Text = "0 Ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(699, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eddig fizetendő:";
            // 
            // btszamla
            // 
            this.btszamla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btszamla.ForeColor = System.Drawing.Color.Black;
            this.btszamla.Location = new System.Drawing.Point(702, 300);
            this.btszamla.Name = "btszamla";
            this.btszamla.Size = new System.Drawing.Size(131, 53);
            this.btszamla.TabIndex = 3;
            this.btszamla.Text = "Számla kiállítás";
            this.btszamla.UseVisualStyleBackColor = true;
            this.btszamla.Click += new System.EventHandler(this.btszamla_Click);
            // 
            // bthozzaad
            // 
            this.bthozzaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthozzaad.ForeColor = System.Drawing.Color.Black;
            this.bthozzaad.Location = new System.Drawing.Point(702, 223);
            this.bthozzaad.Name = "bthozzaad";
            this.bthozzaad.Size = new System.Drawing.Size(131, 53);
            this.bthozzaad.TabIndex = 2;
            this.bthozzaad.Text = "Hozzáadás";
            this.bthozzaad.UseVisualStyleBackColor = true;
            this.bthozzaad.Click += new System.EventHandler(this.bthozzaad_Click);
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendeles_id,
            this.termek_nev,
            this.netto_egyseg_ar,
            this.term_db_szam,
            this.brutto_osszeg,
            this.allapot});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgadatok.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgadatok.Location = new System.Drawing.Point(9, 44);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.RowHeadersWidth = 51;
            this.dgadatok.Size = new System.Drawing.Size(671, 430);
            this.dgadatok.TabIndex = 0;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // rendeles_id
            // 
            this.rendeles_id.HeaderText = "Rendelés id";
            this.rendeles_id.MinimumWidth = 6;
            this.rendeles_id.Name = "rendeles_id";
            this.rendeles_id.ReadOnly = true;
            this.rendeles_id.Width = 125;
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
            this.netto_egyseg_ar.FillWeight = 80F;
            this.netto_egyseg_ar.HeaderText = "Darab ár";
            this.netto_egyseg_ar.MinimumWidth = 6;
            this.netto_egyseg_ar.Name = "netto_egyseg_ar";
            this.netto_egyseg_ar.ReadOnly = true;
            this.netto_egyseg_ar.Width = 70;
            // 
            // term_db_szam
            // 
            this.term_db_szam.HeaderText = "Darab szám";
            this.term_db_szam.MinimumWidth = 6;
            this.term_db_szam.Name = "term_db_szam";
            this.term_db_szam.ReadOnly = true;
            this.term_db_szam.Width = 50;
            // 
            // brutto_osszeg
            // 
            this.brutto_osszeg.HeaderText = "Bruttó fizetendő";
            this.brutto_osszeg.MinimumWidth = 6;
            this.brutto_osszeg.Name = "brutto_osszeg";
            this.brutto_osszeg.ReadOnly = true;
            this.brutto_osszeg.Width = 125;
            // 
            // allapot
            // 
            this.allapot.HeaderText = "Állapot";
            this.allapot.MinimumWidth = 6;
            this.allapot.Name = "allapot";
            this.allapot.ReadOnly = true;
            this.allapot.Width = 125;
            // 
            // dgkeszetelek
            // 
            this.dgkeszetelek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkeszetelek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kesz_termek_nev,
            this.kesz_asztalszam,
            this.kesz_rendelesid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgkeszetelek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgkeszetelek.Location = new System.Drawing.Point(977, 164);
            this.dgkeszetelek.Name = "dgkeszetelek";
            this.dgkeszetelek.RowHeadersWidth = 51;
            this.dgkeszetelek.Size = new System.Drawing.Size(267, 388);
            this.dgkeszetelek.TabIndex = 4;
            this.dgkeszetelek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkeszetelek_CellClick);
            // 
            // kesz_termek_nev
            // 
            this.kesz_termek_nev.HeaderText = "Név";
            this.kesz_termek_nev.MinimumWidth = 6;
            this.kesz_termek_nev.Name = "kesz_termek_nev";
            this.kesz_termek_nev.ReadOnly = true;
            this.kesz_termek_nev.Width = 120;
            // 
            // kesz_asztalszam
            // 
            this.kesz_asztalszam.HeaderText = "Asztalszám";
            this.kesz_asztalszam.MinimumWidth = 6;
            this.kesz_asztalszam.Name = "kesz_asztalszam";
            this.kesz_asztalszam.ReadOnly = true;
            this.kesz_asztalszam.Width = 90;
            // 
            // kesz_rendelesid
            // 
            this.kesz_rendelesid.HeaderText = "Rendelésid";
            this.kesz_rendelesid.MinimumWidth = 6;
            this.kesz_rendelesid.Name = "kesz_rendelesid";
            this.kesz_rendelesid.ReadOnly = true;
            this.kesz_rendelesid.Visible = false;
            this.kesz_rendelesid.Width = 125;
            // 
            // lbkesz
            // 
            this.lbkesz.AutoSize = true;
            this.lbkesz.Location = new System.Drawing.Point(974, 142);
            this.lbkesz.Name = "lbkesz";
            this.lbkesz.Size = new System.Drawing.Size(100, 13);
            this.lbkesz.TabIndex = 5;
            this.lbkesz.Text = "Kiadható ételek:";
            // 
            // frmPincerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1277, 619);
            this.Controls.Add(this.lbkesz);
            this.Controls.Add(this.dgkeszetelek);
            this.Controls.Add(this.pladatok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbasztalszam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPincerIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turbó Tányér Pincér";
            this.Load += new System.EventHandler(this.frmFoform_Load);
            this.pladatok.ResumeLayout(false);
            this.pladatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgkeszetelek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbasztalszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pladatok;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.Button btszamla;
        private System.Windows.Forms.Button bthozzaad;
        private System.Windows.Forms.Label lbfizetendo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgkeszetelek;
        private System.Windows.Forms.Label lbkesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendeles_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto_egyseg_ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_db_szam;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto_osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn allapot;
        private System.Windows.Forms.Button btbezaras;
        private System.Windows.Forms.DataGridViewTextBoxColumn kesz_termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn kesz_asztalszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn kesz_rendelesid;
    }
}

