namespace P05AplikacjaOkienkowa
{
    partial class Form1
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
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDane = new System.Windows.Forms.DataGridView();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(15, 71);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(376, 20);
            this.txtSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Polecenie SQL";
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(15, 97);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(858, 462);
            this.dgvDane.TabIndex = 2;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(397, 71);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 3;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parametry Polaczenia z bazą";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(15, 32);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(243, 20);
            this.txtConnectionString.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.dgvDane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDane;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnectionString;
    }
}

