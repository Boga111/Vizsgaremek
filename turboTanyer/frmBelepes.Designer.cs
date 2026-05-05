namespace turboTanyer
{
    partial class frmBelepes
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
            this.txpin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbelepes = new System.Windows.Forms.Button();
            this.cbfelhaszn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txpin
            // 
            this.txpin.Location = new System.Drawing.Point(254, 177);
            this.txpin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txpin.MaxLength = 4;
            this.txpin.Name = "txpin";
            this.txpin.PasswordChar = '*';
            this.txpin.Size = new System.Drawing.Size(70, 20);
            this.txpin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pinkód:";
            // 
            // btbelepes
            // 
            this.btbelepes.ForeColor = System.Drawing.Color.Black;
            this.btbelepes.Location = new System.Drawing.Point(168, 271);
            this.btbelepes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btbelepes.Name = "btbelepes";
            this.btbelepes.Size = new System.Drawing.Size(133, 56);
            this.btbelepes.TabIndex = 7;
            this.btbelepes.Text = "Belépés";
            this.btbelepes.UseVisualStyleBackColor = true;
            this.btbelepes.Click += new System.EventHandler(this.btbelepes_Click);
            // 
            // cbfelhaszn
            // 
            this.cbfelhaszn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfelhaszn.FormattingEnabled = true;
            this.cbfelhaszn.Items.AddRange(new object[] {
            "Asztalfoglalás",
            "Pincér",
            "Konyha"});
            this.cbfelhaszn.Location = new System.Drawing.Point(254, 135);
            this.cbfelhaszn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbfelhaszn.Name = "cbfelhaszn";
            this.cbfelhaszn.Size = new System.Drawing.Size(104, 21);
            this.cbfelhaszn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Munkakör választás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(164, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Turbó Tányér";
            // 
            // frmBelepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(455, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txpin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbelepes);
            this.Controls.Add(this.cbfelhaszn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBelepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.frmBelepes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txpin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbelepes;
        private System.Windows.Forms.ComboBox cbfelhaszn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}