namespace Interfejs
{
    partial class magazynier_m
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
            this.btn_pozycja = new System.Windows.Forms.Button();
            this.btn_usunpoz = new System.Windows.Forms.Button();
            this.btn_aktm = new System.Windows.Forms.Button();
            this.kntrSpr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kntrOK = new System.Windows.Forms.Label();
            this.kntrERR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pozycja
            // 
            this.btn_pozycja.Location = new System.Drawing.Point(30, 63);
            this.btn_pozycja.Name = "btn_pozycja";
            this.btn_pozycja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pozycja.Size = new System.Drawing.Size(132, 48);
            this.btn_pozycja.TabIndex = 0;
            this.btn_pozycja.Text = "Dodaj Pozycje";
            this.btn_pozycja.UseVisualStyleBackColor = true;
            // 
            // btn_usunpoz
            // 
            this.btn_usunpoz.Location = new System.Drawing.Point(30, 135);
            this.btn_usunpoz.Name = "btn_usunpoz";
            this.btn_usunpoz.Size = new System.Drawing.Size(132, 43);
            this.btn_usunpoz.TabIndex = 1;
            this.btn_usunpoz.Text = "Usun pozycje";
            this.btn_usunpoz.UseVisualStyleBackColor = true;
            // 
            // btn_aktm
            // 
            this.btn_aktm.Location = new System.Drawing.Point(30, 199);
            this.btn_aktm.Name = "btn_aktm";
            this.btn_aktm.Size = new System.Drawing.Size(132, 39);
            this.btn_aktm.TabIndex = 2;
            this.btn_aktm.Text = "Zaktualizuj dane";
            this.btn_aktm.UseVisualStyleBackColor = true;
            // 
            // kntrSpr
            // 
            this.kntrSpr.Location = new System.Drawing.Point(30, 262);
            this.kntrSpr.Name = "kntrSpr";
            this.kntrSpr.Size = new System.Drawing.Size(132, 42);
            this.kntrSpr.TabIndex = 3;
            this.kntrSpr.Text = "Sprawdzenie połączenia";
            this.kntrSpr.UseVisualStyleBackColor = true;
            this.kntrSpr.Click += new System.EventHandler(this.kntrSpr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(184, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 425);
            this.dataGridView1.TabIndex = 4;
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
            this.Column4.HeaderText = "Cena";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // kntrOK
            // 
            this.kntrOK.AutoSize = true;
            this.kntrOK.BackColor = System.Drawing.Color.Lime;
            this.kntrOK.Location = new System.Drawing.Point(27, 319);
            this.kntrOK.Name = "kntrOK";
            this.kntrOK.Size = new System.Drawing.Size(140, 16);
            this.kntrOK.TabIndex = 5;
            this.kntrOK.Text = "Połączenie Uzyskane";
            this.kntrOK.Click += new System.EventHandler(this.label1_Click);
            // 
            // kntrERR
            // 
            this.kntrERR.AutoSize = true;
            this.kntrERR.BackColor = System.Drawing.Color.Crimson;
            this.kntrERR.Location = new System.Drawing.Point(38, 359);
            this.kntrERR.Name = "kntrERR";
            this.kntrERR.Size = new System.Drawing.Size(111, 16);
            this.kntrERR.TabIndex = 6;
            this.kntrERR.Text = "Błąd Połączenia";
            // 
            // magazynier_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kntrERR);
            this.Controls.Add(this.kntrOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kntrSpr);
            this.Controls.Add(this.btn_aktm);
            this.Controls.Add(this.btn_usunpoz);
            this.Controls.Add(this.btn_pozycja);
            this.Name = "magazynier_m";
            this.Text = "Magazyn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pozycja;
        private System.Windows.Forms.Button btn_usunpoz;
        private System.Windows.Forms.Button btn_aktm;
        private System.Windows.Forms.Button kntrSpr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label kntrOK;
        private System.Windows.Forms.Label kntrERR;
    }
}