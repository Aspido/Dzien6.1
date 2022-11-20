using P06BibliotekaPolaczenieZBaza;
using P07AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P07AplikacjaZawodnicy.Repositories
{
    internal class ZawodnicyRepository
    {
        public Zawodnik[] PodajZawodnikow()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik = 
                pzb.WyslijPolecenieSQL(
        "select id_zawodnika, id_trenera, imie, nazwisko,kraj,data_ur,wzrost,waga from zawodnicy");

            // teraz należy przprowadzić transformacje wyniku na tablice Zaowdnikow 

            Zawodnik[] zawodnicy = new Zawodnik[wynik.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                var w = wynik[i];
                //for (int j = 0; j < w.Length; j++)
                //    if (w[j] == DBNull.Value)
                //        w[j] = null;

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)w[0];

                if (w[1] != DBNull.Value)
                    z.Id_trenera = (int)w[1]; // null w c# różni się od null w bazie danych

                z.Imie = (string)w[2];
                z.Nazwisko = (string)w[3];
                z.Kraj = (string)w[4];

                if (w[5] != DBNull.Value)
                    z.DataUrodzenia = (DateTime)w[5];
               // if (w[6] != DBNull.Value)
                    z.Wzrost = (int)w[6];
                if (w[7] != DBNull.Value)
                    z.Waga = (int)w[7];
                zawodnicy[i] = z;
            }
            return zawodnicy;
        }

        public void Edytuj(Zawodnik z)
        {
            string update = @"update zawodnicy set 
                            imie = '{0}',
                            nazwisko = '{1}',
                            kraj = '{2}',
                            data_ur = {3},
                            waga = {4},
                            wzrost = {5} where id_zawodnika = {6}";

            string sql = string.Format(update, z.Imie, z.Nazwisko, z.Kraj,
                    
                    z.DataUrodzenia == null ? "null" : $"'{z.DataUrodzenia?.ToString("yyyyMMdd")}'" , 
                    
                    z.Waga.ToString(), z.Wzrost.ToString(),
                    z.Id_zawodnika);

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }

        public void Dodaj(Zawodnik n)

        {
            SqlConnection con = new SqlConnection(@"Data Source=KRZYSZTOF-DELL\WINCC;Initial Catalog=A_Zawodnicy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", txtImie.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);

            cmd.CommandType = CommandType.StoredProcedure;
            string add = @"Insert INTO zawodnicy VALUES
                            imie = '{0}',
                            nazwisko = '{1}',
                            kraj = '{2}',
                            data_ur = {3},
                            waga = {4},
                            wzrost = {5} where id_zawodnika = {6}";

            string addsql = string.Format(add, n.Imie, n.Nazwisko, n.Kraj,

                    n.DataUrodzenia == null ? "null" : $"'{n.DataUrodzenia?.ToString("yyyyMMdd")}'",

                    n.Waga.ToString(), n.Wzrost.ToString(),
                    n.Id_zawodnika);

            PolaczenieZBaza pzb2 = new PolaczenieZBaza();
            pzb2.WyslijPolecenieSQL(addsql);


            Console.WriteLine("dfs");

        }


    }
}
