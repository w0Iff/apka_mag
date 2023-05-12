namespace Interfejs
{
    partial class gl_menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_glnazwa = new System.Windows.Forms.Label();
            this.lbl_wersja = new System.Windows.Forms.Label();
            this.btn_sprzedawca = new System.Windows.Forms.Button();
            this.btn_magazynier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_glnazwa
            // 
            this.lbl_glnazwa.AutoSize = true;
            this.lbl_glnazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_glnazwa.Location = new System.Drawing.Point(240, 46);
            this.lbl_glnazwa.Name = "lbl_glnazwa";
            this.lbl_glnazwa.Size = new System.Drawing.Size(276, 29);
            this.lbl_glnazwa.TabIndex = 0;
            this.lbl_glnazwa.Text = "Aplikacja magazynowa";
            this.lbl_glnazwa.Click += new System.EventHandler(this.lbl_glnazwa_Click);
            // 
            // lbl_wersja
            // 
            this.lbl_wersja.AutoSize = true;
            this.lbl_wersja.Location = new System.Drawing.Point(25, 396);
            this.lbl_wersja.Name = "lbl_wersja";
            this.lbl_wersja.Size = new System.Drawing.Size(46, 16);
            this.lbl_wersja.TabIndex = 1;
            this.lbl_wersja.Text = "ver 1.0";
            this.lbl_wersja.Click += new System.EventHandler(this.lbl_wersja_Click);
            // 
            // btn_sprzedawca
            // 
            this.btn_sprzedawca.Location = new System.Drawing.Point(289, 146);
            this.btn_sprzedawca.Name = "btn_sprzedawca";
            this.btn_sprzedawca.Size = new System.Drawing.Size(184, 76);
            this.btn_sprzedawca.TabIndex = 2;
            this.btn_sprzedawca.Text = "Menu: Sprzedawca";
            this.btn_sprzedawca.UseVisualStyleBackColor = true;
            this.btn_sprzedawca.Click += new System.EventHandler(this.btn_sprzedawca_Click);
            // 
            // btn_magazynier
            // 
            this.btn_magazynier.Location = new System.Drawing.Point(289, 259);
            this.btn_magazynier.Name = "btn_magazynier";
            this.btn_magazynier.Size = new System.Drawing.Size(184, 76);
            this.btn_magazynier.TabIndex = 3;
            this.btn_magazynier.Text = "Menu: Magazynier";
            this.btn_magazynier.UseVisualStyleBackColor = true;
            this.btn_magazynier.Click += new System.EventHandler(this.btn_magazynier_Click);
            // 
            // gl_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_magazynier);
            this.Controls.Add(this.btn_sprzedawca);
            this.Controls.Add(this.lbl_wersja);
            this.Controls.Add(this.lbl_glnazwa);
            this.Name = "gl_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja Magazyn";
            this.Load += new System.EventHandler(this.gl_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_glnazwa;
        private System.Windows.Forms.Label lbl_wersja;
        private System.Windows.Forms.Button btn_sprzedawca;
        private System.Windows.Forms.Button btn_magazynier;
    }
}

