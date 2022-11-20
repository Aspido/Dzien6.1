namespace P07AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(3, 41);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(368, 316);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(3, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(53, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(273, 12);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(98, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Pokaż szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(60, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj Zawodnika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(168, 12);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(101, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń Zawodnika";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 366);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmStartowy";
            this.Text = "Zawodnicy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
    }
}

