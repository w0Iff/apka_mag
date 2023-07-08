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
            this.kntrSpr = new System.Windows.Forms.Button();
            this.kntrOK = new System.Windows.Forms.Label();
            this.kntrERR = new System.Windows.Forms.Label();
            this.btn_akt_sprz = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridViewSprzedawca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzedawca)).BeginInit();
            this.SuspendLayout();
            // 
            // kntrSpr
            // 
            this.kntrSpr.BackColor = System.Drawing.Color.Transparent;
            this.kntrSpr.BackgroundImage = global::Interfejs.Properties.Resources.medbt;
            this.kntrSpr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kntrSpr.FlatAppearance.BorderSize = 0;
            this.kntrSpr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kntrSpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kntrSpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kntrSpr.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.kntrSpr.ForeColor = System.Drawing.Color.White;
            this.kntrSpr.Location = new System.Drawing.Point(437, 116);
            this.kntrSpr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kntrSpr.Name = "kntrSpr";
            this.kntrSpr.Size = new System.Drawing.Size(99, 46);
            this.kntrSpr.TabIndex = 4;
            this.kntrSpr.Text = "Sprawdzenie Połączenia";
            this.kntrSpr.UseVisualStyleBackColor = false;
            this.kntrSpr.Click += new System.EventHandler(this.kntrSpr_Click);
            // 
            // kntrOK
            // 
            this.kntrOK.AutoSize = true;
            this.kntrOK.BackColor = System.Drawing.Color.Lime;
            this.kntrOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.kntrOK.Location = new System.Drawing.Point(446, 204);
            this.kntrOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kntrOK.Name = "kntrOK";
            this.kntrOK.Size = new System.Drawing.Size(74, 15);
            this.kntrOK.TabIndex = 6;
            this.kntrOK.Text = "Połączono";
            this.kntrOK.Click += new System.EventHandler(this.kntrOK_Click);
            // 
            // kntrERR
            // 
            this.kntrERR.AutoSize = true;
            this.kntrERR.BackColor = System.Drawing.Color.Crimson;
            this.kntrERR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.kntrERR.Location = new System.Drawing.Point(463, 238);
            this.kntrERR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kntrERR.Name = "kntrERR";
            this.kntrERR.Size = new System.Drawing.Size(36, 15);
            this.kntrERR.TabIndex = 7;
            this.kntrERR.Text = "Błąd";
            this.kntrERR.Click += new System.EventHandler(this.kntrERR_Click);
            // 
            // btn_akt_sprz
            // 
            this.btn_akt_sprz.BackColor = System.Drawing.Color.Transparent;
            this.btn_akt_sprz.BackgroundImage = global::Interfejs.Properties.Resources.medbt;
            this.btn_akt_sprz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_akt_sprz.FlatAppearance.BorderSize = 0;
            this.btn_akt_sprz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_akt_sprz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_akt_sprz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_akt_sprz.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_akt_sprz.ForeColor = System.Drawing.Color.White;
            this.btn_akt_sprz.Location = new System.Drawing.Point(437, 58);
            this.btn_akt_sprz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_akt_sprz.Name = "btn_akt_sprz";
            this.btn_akt_sprz.Size = new System.Drawing.Size(99, 46);
            this.btn_akt_sprz.TabIndex = 0;
            this.btn_akt_sprz.Text = "Aktualizacja Danych";
            this.btn_akt_sprz.UseVisualStyleBackColor = false;
            this.btn_akt_sprz.Click += new System.EventHandler(this.btn_akt_sprz_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(221, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 29);
            this.textBox4.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(221, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 29);
            this.textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(221, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 29);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 29);
            this.textBox1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(133, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Dostepna ilosc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cena za sztuke";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BackgroundImage = global::Interfejs.Properties.Resources.medbt;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(588, 7);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(99, 46);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.Text = "Odśwież";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridViewSprzedawca
            // 
            this.dataGridViewSprzedawca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSprzedawca.Location = new System.Drawing.Point(588, 68);
            this.dataGridViewSprzedawca.Name = "dataGridViewSprzedawca";
            this.dataGridViewSprzedawca.RowTemplate.Height = 24;
            this.dataGridViewSprzedawca.Size = new System.Drawing.Size(528, 296);
            this.dataGridViewSprzedawca.TabIndex = 34;
            this.dataGridViewSprzedawca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSprzedawca_CellContentClick);
            // 
            // sprzedawca_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfejs.Properties.Resources.finalkoniec;
            this.ClientSize = new System.Drawing.Size(1128, 376);
            this.Controls.Add(this.dataGridViewSprzedawca);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kntrERR);
            this.Controls.Add(this.kntrOK);
            this.Controls.Add(this.btn_akt_sprz);
            this.Controls.Add(this.kntrSpr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "sprzedawca_m";
            this.Text = "Sklep";
            this.Load += new System.EventHandler(this.sprzedawca_m_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzedawca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_akt_sprz;
        private System.Windows.Forms.Button kntrSpr;
        private System.Windows.Forms.Label kntrOK;
        private System.Windows.Forms.Label kntrERR;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridViewSprzedawca;
    }
}