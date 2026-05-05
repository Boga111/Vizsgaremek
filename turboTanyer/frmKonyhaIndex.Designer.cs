namespace turboTanyer
{
    partial class frmKonyhaIndex
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
            this.dgrendelesek = new System.Windows.Forms.DataGridView();
            this.rendeles_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_db_szam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asztalszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btbezaras = new System.Windows.Forms.Button();
            this.btfrissites = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgfutar = new System.Windows.Forms.DataGridView();
            this.futar_rend_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar_rend_ido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar_termek_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futar_term_db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrendelesek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfutar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(541, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turbó Tányér";
            // 
            // dgrendelesek
            // 
            this.dgrendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrendelesek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendeles_id,
            this.termek_nev,
            this.term_db_szam,
            this.asztalszam});
            this.dgrendelesek.Location = new System.Drawing.Point(22, 141);
            this.dgrendelesek.Name = "dgrendelesek";
            this.dgrendelesek.RowHeadersWidth = 51;
            this.dgrendelesek.Size = new System.Drawing.Size(556, 446);
            this.dgrendelesek.TabIndex = 1;
            this.dgrendelesek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrendelesek_CellClick);
            // 
            // rendeles_id
            // 
            this.rendeles_id.HeaderText = "Sorszám";
            this.rendeles_id.MinimumWidth = 6;
            this.rendeles_id.Name = "rendeles_id";
            this.rendeles_id.Width = 125;
            // 
            // termek_nev
            // 
            this.termek_nev.HeaderText = "Név";
            this.termek_nev.MinimumWidth = 6;
            this.termek_nev.Name = "termek_nev";
            this.termek_nev.Width = 125;
            // 
            // term_db_szam
            // 
            this.term_db_szam.HeaderText = "Rendelt darab";
            this.term_db_szam.MinimumWidth = 6;
            this.term_db_szam.Name = "term_db_szam";
            this.term_db_szam.Width = 125;
            // 
            // asztalszam
            // 
            this.asztalszam.HeaderText = "Asztal száma";
            this.asztalszam.MinimumWidth = 6;
            this.asztalszam.Name = "asztalszam";
            this.asztalszam.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rendelések helyben:";
            // 
            // btbezaras
            // 
            this.btbezaras.ForeColor = System.Drawing.Color.Black;
            this.btbezaras.Location = new System.Drawing.Point(188, 602);
            this.btbezaras.Name = "btbezaras";
            this.btbezaras.Size = new System.Drawing.Size(232, 45);
            this.btbezaras.TabIndex = 3;
            this.btbezaras.Text = "Bezárás";
            this.btbezaras.UseVisualStyleBackColor = true;
            this.btbezaras.Click += new System.EventHandler(this.btbezaras_Click);
            // 
            // btfrissites
            // 
            this.btfrissites.ForeColor = System.Drawing.Color.Black;
            this.btfrissites.Location = new System.Drawing.Point(812, 602);
            this.btfrissites.Name = "btfrissites";
            this.btfrissites.Size = new System.Drawing.Size(232, 45);
            this.btfrissites.TabIndex = 4;
            this.btfrissites.Text = "Frissítés";
            this.btfrissites.UseVisualStyleBackColor = true;
            this.btfrissites.Click += new System.EventHandler(this.btfrissites_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rendelések elvitelre:";
            // 
            // dgfutar
            // 
            this.dgfutar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfutar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.futar_rend_id,
            this.futar_rend_ido,
            this.futar_termek_nev,
            this.futar_term_db});
            this.dgfutar.Location = new System.Drawing.Point(647, 141);
            this.dgfutar.Name = "dgfutar";
            this.dgfutar.RowHeadersWidth = 51;
            this.dgfutar.RowTemplate.Height = 24;
            this.dgfutar.Size = new System.Drawing.Size(491, 446);
            this.dgfutar.TabIndex = 6;
            this.dgfutar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgfutar_CellClick);
            // 
            // futar_rend_id
            // 
            this.futar_rend_id.HeaderText = "Sorszám";
            this.futar_rend_id.MinimumWidth = 6;
            this.futar_rend_id.Name = "futar_rend_id";
            this.futar_rend_id.Width = 80;
            // 
            // futar_rend_ido
            // 
            this.futar_rend_ido.HeaderText = "Rendelési idő";
            this.futar_rend_ido.MinimumWidth = 6;
            this.futar_rend_ido.Name = "futar_rend_ido";
            this.futar_rend_ido.Width = 150;
            // 
            // futar_termek_nev
            // 
            this.futar_termek_nev.HeaderText = "Termék neve";
            this.futar_termek_nev.MinimumWidth = 6;
            this.futar_termek_nev.Name = "futar_termek_nev";
            this.futar_termek_nev.Width = 125;
            // 
            // futar_term_db
            // 
            this.futar_term_db.HeaderText = "Rendelt darab";
            this.futar_term_db.MinimumWidth = 6;
            this.futar_term_db.Name = "futar_term_db";
            this.futar_term_db.Width = 80;
            // 
            // frmKonyhaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1162, 663);
            this.Controls.Add(this.dgfutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btfrissites);
            this.Controls.Add(this.btbezaras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrendelesek);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKonyhaIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turbó Tányér Konyha";
            this.Load += new System.EventHandler(this.frmKonyhaIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrendelesek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgfutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrendelesek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbezaras;
        private System.Windows.Forms.Button btfrissites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgfutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar_rend_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar_rend_ido;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar_termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn futar_term_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendeles_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_db_szam;
        private System.Windows.Forms.DataGridViewTextBoxColumn asztalszam;
    }
}