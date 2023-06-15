namespace Interfejs
{
    partial class sprzedawca_m
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
            this.tabela_sprzedawca = new System.Windows.Forms.DataGridView();
            this.kntrSpr = new System.Windows.Forms.Button();
            this.kntrOK = new System.Windows.Forms.Label();
            this.kntrERR = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_akt_sprz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_sprzedawca)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_sprzedawca
            // 
            this.tabela_sprzedawca.AllowUserToAddRows = false;
            this.tabela_sprzedawca.AllowUserToDeleteRows = false;
            this.tabela_sprzedawca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_sprzedawca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tabela_sprzedawca.Location = new System.Drawing.Point(155, 4);
            this.tabela_sprzedawca.Name = "tabela_sprzedawca";
            this.tabela_sprzedawca.ReadOnly = true;
            this.tabela_sprzedawca.RowHeadersWidth = 51;
            this.tabela_sprzedawca.RowTemplate.Height = 24;
            this.tabela_sprzedawca.Size = new System.Drawing.Size(642, 444);
            this.tabela_sprzedawca.TabIndex = 0;
            this.tabela_sprzedawca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kntrSpr
            // 
            this.kntrSpr.BackColor = System.Drawing.Color.Transparent;
            this.kntrSpr.FlatAppearance.BorderSize = 0;
            this.kntrSpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kntrSpr.ForeColor = System.Drawing.Color.White;
            this.kntrSpr.Image = global::Interfejs.Properties.Resources.smallbt;
            this.kntrSpr.Location = new System.Drawing.Point(12, 164);
            this.kntrSpr.Name = "kntrSpr";
            this.kntrSpr.Size = new System.Drawing.Size(101, 91);
            this.kntrSpr.TabIndex = 4;
            this.kntrSpr.Text = "Sprawdzenie Połączenia";
            this.kntrSpr.UseVisualStyleBackColor = false;
            this.kntrSpr.Click += new System.EventHandler(this.kntrSpr_Click);
            // 
            // kntrOK
            // 
            this.kntrOK.AutoSize = true;
            this.kntrOK.BackColor = System.Drawing.Color.Lime;
            this.kntrOK.Location = new System.Drawing.Point(22, 270);
            this.kntrOK.Name = "kntrOK";
            this.kntrOK.Size = new System.Drawing.Size(74, 16);
            this.kntrOK.TabIndex = 6;
            this.kntrOK.Text = "Połączono";
            this.kntrOK.Click += new System.EventHandler(this.kntrOK_Click);
            // 
            // kntrERR
            // 
            this.kntrERR.AutoSize = true;
            this.kntrERR.BackColor = System.Drawing.Color.Crimson;
            this.kntrERR.Location = new System.Drawing.Point(39, 300);
            this.kntrERR.Name = "kntrERR";
            this.kntrERR.Size = new System.Drawing.Size(38, 16);
            this.kntrERR.TabIndex = 7;
            this.kntrERR.Text = "Błąd";
            this.kntrERR.Click += new System.EventHandler(this.kntrERR_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dostępna Ilość";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cena za sztukę";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // btn_akt_sprz
            // 
            this.btn_akt_sprz.BackColor = System.Drawing.Color.Transparent;
            this.btn_akt_sprz.BackgroundImage = global::Interfejs.Properties.Resources.smallbt;
            this.btn_akt_sprz.FlatAppearance.BorderSize = 0;
            this.btn_akt_sprz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_akt_sprz.ForeColor = System.Drawing.Color.White;
            this.btn_akt_sprz.Image = global::Interfejs.Properties.Resources.smallbt;
            this.btn_akt_sprz.Location = new System.Drawing.Point(12, 56);
            this.btn_akt_sprz.Name = "btn_akt_sprz";
            this.btn_akt_sprz.Size = new System.Drawing.Size(101, 91);
            this.btn_akt_sprz.TabIndex = 0;
            this.btn_akt_sprz.Text = "Aktualizacja Danych";
            this.btn_akt_sprz.UseVisualStyleBackColor = false;
            this.btn_akt_sprz.Click += new System.EventHandler(this.btn_akt_sprz_Click);
            // 
            // sprzedawca_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfejs.Properties.Resources.finalkoniec;
            this.ClientSize = new System.Drawing.Size(846, 473);
            this.Controls.Add(this.kntrERR);
            this.Controls.Add(this.kntrOK);
            this.Controls.Add(this.btn_akt_sprz);
            this.Controls.Add(this.kntrSpr);
            this.Controls.Add(this.tabela_sprzedawca);
            this.Name = "sprzedawca_m";
            this.Text = "Sklep";
            this.Load += new System.EventHandler(this.sprzedawca_m_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_sprzedawca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabela_sprzedawca;
        private System.Windows.Forms.Button btn_akt_sprz;
        private System.Windows.Forms.Button kntrSpr;
        private System.Windows.Forms.Label kntrOK;
        private System.Windows.Forms.Label kntrERR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}