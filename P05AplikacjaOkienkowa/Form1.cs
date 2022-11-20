using P06BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb;
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                var d= MessageBox.Show("Nie podano parametrów polaczenia z bazą. Czy chcesz użyć parametrów domyślnych?", "Pytanie",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                    pzb = new PolaczenieZBaza();
                else
                    return;
            }else
                pzb = new PolaczenieZBaza(txtConnectionString.Text);

            if (string.IsNullOrEmpty(txtSQL.Text))
            {
                MessageBox.Show("Nie podano polecenia SQL", "Ostrzeżenie",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


          //  string connString = pzb.ConnectionString;
          //  pzb.ConnectionString = "x";

            object[][] wynik= pzb.WyslijPolecenieSQL(txtSQL.Text);

            dgvDane.Rows.Clear();
            dgvDane.ColumnCount = wynik[0].Length;

            foreach (var wiersz in wynik)
                dgvDane.Rows.Add(wiersz);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///
        }
    }
}
