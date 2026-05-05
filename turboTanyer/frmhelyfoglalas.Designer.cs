namespace turboTanyer
{
    partial class frmhelyfoglalas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txfoglalas = new System.Windows.Forms.TextBox();
            this.dgfoglalasok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asztalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idopont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo_db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btvissza = new System.Windows.Forms.Button();
            this.rbujfoglalas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.rtasztalsegitseg = new System.Windows.Forms.RichTextBox();
            this.btelvet = new System.Windows.Forms.Button();
            this.btmentes = new System.Windows.Forms.Button();
            this.txfo_db = new System.Windows.Forms.TextBox();
            this.dtdatum = new System.Windows.Forms.DateTimePicker();
            this.txasztalszam = new System.Windows.Forms.TextBox();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgfoglalasok)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turbó tányér";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Foglalás keresése név alapján:";
            // 
            // txfoglalas
            // 
            this.txfoglalas.Location = new System.Drawing.Point(269, 109);
            this.txfoglalas.MaxLength = 50;
            this.txfoglalas.Name = "txfoglalas";
            this.txfoglalas.Size = new System.Drawing.Size(172, 20);
            this.txfoglalas.TabIndex = 1;
            this.txfoglalas.TextChanged += new System.EventHandler(this.txfoglalas_TextChanged);
            // 
            // dgfoglalasok
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgfoglalasok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgfoglalasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfoglalasok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.asztalszam,
            this.idopont,
            this.fo_db});
            this.dgfoglalasok.Location = new System.Drawing.Point(38, 141);
            this.dgfoglalasok.Name = "dgfoglalasok";
            this.dgfoglalasok.RowHeadersWidth = 51;
            this.dgfoglalasok.Size = new System.Drawing.Size(452, 392);
            this.dgfoglalasok.TabIndex = 3;
            this.dgfoglalasok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfoglalasok_CellClick);
            // 
            // nev
            // 
            this.nev.HeaderText = "Foglaló neve";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 125;
            // 
            // asztalszam
            // 
            this.asztalszam.HeaderText = "Asztal száma";
            this.asztalszam.MinimumWidth = 6;
            this.asztalszam.Name = "asztalszam";
            this.asztalszam.ReadOnly = true;
            this.asztalszam.Width = 50;
            // 
            // idopont
            // 
            this.idopont.HeaderText = "Időpont";
            this.idopont.MinimumWidth = 6;
            this.idopont.Name = "idopont";
            this.idopont.ReadOnly = true;
            this.idopont.Width = 150;
            // 
            // fo_db
            // 
            this.fo_db.HeaderText = "Személyek száma";
            this.fo_db.MinimumWidth = 6;
            this.fo_db.Name = "fo_db";
            this.fo_db.ReadOnly = true;
            this.fo_db.Width = 75;
            // 
            // btvissza
            // 
            this.btvissza.ForeColor = System.Drawing.Color.Black;
            this.btvissza.Location = new System.Drawing.Point(269, 570);
            this.btvissza.Name = "btvissza";
            this.btvissza.Size = new System.Drawing.Size(452, 47);
            this.btvissza.TabIndex = 9;
            this.btvissza.Text = "Kilépés";
            this.btvissza.UseVisualStyleBackColor = true;
            this.btvissza.Click += new System.EventHandler(this.btvissza_Click);
            // 
            // rbujfoglalas
            // 
            this.rbujfoglalas.AutoSize = true;
            this.rbujfoglalas.Location = new System.Drawing.Point(563, 118);
            this.rbujfoglalas.Name = "rbujfoglalas";
            this.rbujfoglalas.Size = new System.Drawing.Size(129, 17);
            this.rbujfoglalas.TabIndex = 2;
            this.rbujfoglalas.TabStop = true;
            this.rbujfoglalas.Text = "Foglalás rögzítése";
            this.rbujfoglalas.UseVisualStyleBackColor = true;
            this.rbujfoglalas.CheckedChanged += new System.EventHandler(this.rbujfoglalas_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rtasztalsegitseg);
            this.panel1.Controls.Add(this.btelvet);
            this.panel1.Controls.Add(this.btmentes);
            this.panel1.Controls.Add(this.txfo_db);
            this.panel1.Controls.Add(this.dtdatum);
            this.panel1.Controls.Add(this.txasztalszam);
            this.panel1.Controls.Add(this.txnev);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(563, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 392);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Választható asztalok:";
            // 
            // rtasztalsegitseg
            // 
            this.rtasztalsegitseg.Location = new System.Drawing.Point(93, 221);
            this.rtasztalsegitseg.Name = "rtasztalsegitseg";
            this.rtasztalsegitseg.Size = new System.Drawing.Size(196, 82);
            this.rtasztalsegitseg.TabIndex = 11;
            this.rtasztalsegitseg.Text = "";
            // 
            // btelvet
            // 
            this.btelvet.ForeColor = System.Drawing.Color.Black;
            this.btelvet.Location = new System.Drawing.Point(158, 330);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(131, 43);
            this.btelvet.TabIndex = 8;
            this.btelvet.Text = "Elvet";
            this.btelvet.UseVisualStyleBackColor = true;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // btmentes
            // 
            this.btmentes.ForeColor = System.Drawing.Color.Black;
            this.btmentes.Location = new System.Drawing.Point(21, 330);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(131, 43);
            this.btmentes.TabIndex = 7;
            this.btmentes.Text = "Mentés";
            this.btmentes.UseVisualStyleBackColor = true;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // txfo_db
            // 
            this.txfo_db.Location = new System.Drawing.Point(128, 134);
            this.txfo_db.MaxLength = 2;
            this.txfo_db.Name = "txfo_db";
            this.txfo_db.Size = new System.Drawing.Size(37, 20);
            this.txfo_db.TabIndex = 5;
            this.txfo_db.TextChanged += new System.EventHandler(this.txfo_db_TextChanged);
            // 
            // dtdatum
            // 
            this.dtdatum.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdatum.Location = new System.Drawing.Point(128, 95);
            this.dtdatum.Name = "dtdatum";
            this.dtdatum.Size = new System.Drawing.Size(159, 20);
            this.dtdatum.TabIndex = 4;
            // 
            // txasztalszam
            // 
            this.txasztalszam.Location = new System.Drawing.Point(128, 174);
            this.txasztalszam.MaxLength = 2;
            this.txasztalszam.Name = "txasztalszam";
            this.txasztalszam.Size = new System.Drawing.Size(50, 20);
            this.txasztalszam.TabIndex = 6;
            this.txasztalszam.TextChanged += new System.EventHandler(this.txasztalszam_TextChanged);
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(128, 58);
            this.txnev.MaxLength = 50;
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(159, 20);
            this.txnev.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Személyek száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Időpont:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asztal száma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Foglaló neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Új foglalás";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(217, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Foglalások";
            // 
            // frmhelyfoglalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(944, 638);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbujfoglalas);
            this.Controls.Add(this.btvissza);
            this.Controls.Add(this.dgfoglalasok);
            this.Controls.Add(this.txfoglalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmhelyfoglalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asztal foglalások";
            this.Load += new System.EventHandler(this.frmhelyfoglalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgfoglalasok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txfoglalas;
        private System.Windows.Forms.DataGridView dgfoglalasok;
        private System.Windows.Forms.Button btvissza;
        private System.Windows.Forms.RadioButton rbujfoglalas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txfo_db;
        private System.Windows.Forms.DateTimePicker dtdatum;
        private System.Windows.Forms.TextBox txasztalszam;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.Button btelvet;
        private System.Windows.Forms.RichTextBox rtasztalsegitseg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn asztalszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopont;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo_db;
        private System.Windows.Forms.Label label9;
    }
}