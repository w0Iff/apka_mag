namespace sprPolaczenia
{
    partial class Form1
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
            this.kntrSpr = new System.Windows.Forms.Button();
            this.kntrOK = new System.Windows.Forms.Label();
            this.kntrERR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kntrSpr
            // 
            this.kntrSpr.Location = new System.Drawing.Point(103, 36);
            this.kntrSpr.Name = "kntrSpr";
            this.kntrSpr.Size = new System.Drawing.Size(129, 92);
            this.kntrSpr.TabIndex = 0;
            this.kntrSpr.Text = "Sprawdz";
            this.kntrSpr.UseVisualStyleBackColor = true;
            this.kntrSpr.Click += new System.EventHandler(this.kntrSpr_Click);
            // 
            // kntrOK
            // 
            this.kntrOK.AutoSize = true;
            this.kntrOK.BackColor = System.Drawing.Color.LawnGreen;
            this.kntrOK.Location = new System.Drawing.Point(122, 151);
            this.kntrOK.Name = "kntrOK";
            this.kntrOK.Size = new System.Drawing.Size(95, 16);
            this.kntrOK.TabIndex = 1;
            this.kntrOK.Text = "Polaczenie OK";
            // 
            // kntrERR
            // 
            this.kntrERR.AutoSize = true;
            this.kntrERR.BackColor = System.Drawing.Color.Crimson;
            this.kntrERR.ForeColor = System.Drawing.Color.Black;
            this.kntrERR.Location = new System.Drawing.Point(113, 151);
            this.kntrERR.Name = "kntrERR";
            this.kntrERR.Size = new System.Drawing.Size(104, 16);
            this.kntrERR.TabIndex = 2;
            this.kntrERR.Text = "Blad polaczenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 233);
            this.Controls.Add(this.kntrERR);
            this.Controls.Add(this.kntrOK);
            this.Controls.Add(this.kntrSpr);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaczenie z BAZA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kntrSpr;
        private System.Windows.Forms.Label kntrOK;
        private System.Windows.Forms.Label kntrERR;
    }
}

