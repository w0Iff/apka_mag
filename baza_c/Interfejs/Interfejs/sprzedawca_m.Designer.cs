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
            this.sprzedawca_panel = new System.Windows.Forms.Panel();
            this.btn_akt_sprz = new System.Windows.Forms.Button();
            this.tabela_sprzedawca = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntrSpr = new System.Windows.Forms.Button();
            this.sprzedawca_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_sprzedawca)).BeginInit();
            this.SuspendLayout();
            // 
            // sprzedawca_panel
            // 
            this.sprzedawca_panel.Controls.Add(this.kntrSpr);
            this.sprzedawca_panel.Controls.Add(this.btn_akt_sprz);
            this.sprzedawca_panel.Location = new System.Drawing.Point(12, 1);
            this.sprzedawca_panel.Name = "sprzedawca_panel";
            this.sprzedawca_panel.Size = new System.Drawing.Size(107, 447);
            this.sprzedawca_panel.TabIndex = 0;
            // 
            // btn_akt_sprz
            // 
            this.btn_akt_sprz.Location = new System.Drawing.Point(3, 116);
            this.btn_akt_sprz.Name = "btn_akt_sprz";
            this.btn_akt_sprz.Size = new System.Drawing.Size(101, 117);
            this.btn_akt_sprz.TabIndex = 0;
            this.btn_akt_sprz.Text = "Zaktualizuj dane";
            this.btn_akt_sprz.UseVisualStyleBackColor = true;
            this.btn_akt_sprz.Click += new System.EventHandler(this.btn_akt_sprz_Click);
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
            this.tabela_sprzedawca.Location = new System.Drawing.Point(125, 4);
            this.tabela_sprzedawca.Name = "tabela_sprzedawca";
            this.tabela_sprzedawca.ReadOnly = true;
            this.tabela_sprzedawca.RowHeadersWidth = 51;
            this.tabela_sprzedawca.RowTemplate.Height = 24;
            this.tabela_sprzedawca.Size = new System.Drawing.Size(672, 444);
            this.tabela_sprzedawca.TabIndex = 0;
            this.tabela_sprzedawca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Column3.HeaderText = "Dostepna Ilosc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cena za sztuke";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // kntrSpr
            // 
            this.kntrSpr.Location = new System.Drawing.Point(3, 239);
            this.kntrSpr.Name = "kntrSpr";
            this.kntrSpr.Size = new System.Drawing.Size(101, 91);
            this.kntrSpr.TabIndex = 4;
            this.kntrSpr.Text = "Sprawdzenie połączenia";
            this.kntrSpr.UseVisualStyleBackColor = true;
            // 
            // sprzedawca_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabela_sprzedawca);
            this.Controls.Add(this.sprzedawca_panel);
            this.Name = "sprzedawca_m";
            this.Text = "Sklep";
            this.Load += new System.EventHandler(this.sprzedawca_m_Load);
            this.sprzedawca_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_sprzedawca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sprzedawca_panel;
        private System.Windows.Forms.DataGridView tabela_sprzedawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_akt_sprz;
        private System.Windows.Forms.Button kntrSpr;
    }
}