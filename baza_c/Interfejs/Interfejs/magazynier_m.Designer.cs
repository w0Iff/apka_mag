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
            this.kntrSpr.Click += new System.EventHandler(this.button1_Click);
            // 
            // magazynier_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kntrSpr);
            this.Controls.Add(this.btn_aktm);
            this.Controls.Add(this.btn_usunpoz);
            this.Controls.Add(this.btn_pozycja);
            this.Name = "magazynier_m";
            this.Text = "Magazyn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pozycja;
        private System.Windows.Forms.Button btn_usunpoz;
        private System.Windows.Forms.Button btn_aktm;
        private System.Windows.Forms.Button kntrSpr;
    }
}