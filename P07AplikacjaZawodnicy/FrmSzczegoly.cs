using P07AplikacjaZawodnicy.Domain;
using P07AplikacjaZawodnicy.Repositories;
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

namespace P07AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        private Zawodnik zawodnik;
        private FrmStartowy fs;




        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy fs)
        {
            InitializeComponent();
            UzupelnijFormularz(zawodnik);

            this.zawodnik = zawodnik;
            this.fs = fs;
        }

        public void DodajZawodnika(Zawodnik zawodnik)
        {
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKrajZawodnika.Text = zawodnik.Kraj;
            txtDataUr.Text = zawodnik.DataSformatowana;
            txtWzrost.Text = zawodnik.Wzrost.ToString();
            txtWaga.Text = zawodnik.Waga.ToString();
        }


        public void UzupelnijFormularz(Zawodnik zawodnik)
        {
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKrajZawodnika.Text = zawodnik.Kraj;
            txtDataUr.Text = zawodnik.DataSformatowana;
            txtWzrost.Text = zawodnik.Wzrost.ToString();
            txtWaga.Text = zawodnik.Waga.ToString();
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.frmSzczegoly = null;
        }

        private async void btnZapisz_Click(object sender, EventArgs e)
        {
            ZczytytajFormularz();

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(zawodnik);


        }

        private void ZczytytajFormularz()
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKrajZawodnika.Text;
            
            if (string.IsNullOrEmpty(txtDataUr.Text))
                zawodnik.DataUrodzenia = null;
            else
                zawodnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);

            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            ZczytytajFormularz();
            ZawodnicyRepository nowy = new ZawodnicyRepository();
            nowy.Dodaj(zawodnik);



            //private void NewServe_Click(object sender, EventArgs e)
            //{
            //    // Do no pass an instance of Class here, just pass null 
            //    // or remove it at all if you don't plan to reuse the form for updating 
            //    TypeService form = new TypeService(null);
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        // Add the using statement to ensure a proper release of resources.
            //        using SqlConnection Con = new SqlConnection(connectionString);
            //        Con.Open();
            //        // Parameterized query
            //        string Que = "INSERT INTO type_service VALUES(@id,@name,@price);";
            //        SqlCommand cmd = new SqlCommand(Que, Con);
            //        cmd.Parameters.Add("@id", SqlDbType.Int).Value = form.Class.id_serv;
            //        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = form.Class.name;
            //        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = form.Class.price;
            //        cmd.ExecuteNonQuery();

            //        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM type_service", Con);
            //        DataTable d = new DataTable();
            //        sqlDa.Fill(d);
            //        dataGridView3.AutoGenerateColumns = false;
            //        dataGridView3.DataSource = d;
            //    }
            //}







        }
    }
}
