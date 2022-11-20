using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class PolaczenieZBaza
    {
        const string connectionString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";

        public object[][] WyslijPolecenieSQL(string sql)
        {
            SqlConnection connection; //do nawiazywania polaczenia z baza
            SqlCommand command; // przechowywanie polecen sql
            SqlDataReader sqlDataReader; // czytanie wynikow z bazy 
            connection = new SqlConnection(connectionString);
            command = new SqlCommand(sql, connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader(); // wysylamy polecenie do bazy danych 
            int liczbaKolumn = sqlDataReader.FieldCount;
            var listaWierszy = new List<object[]>();
            while (sqlDataReader.Read()) // czytaj odpowiedz z bazy
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i] = sqlDataReader.GetValue(i);

                listaWierszy.Add(komorki);
            }
            connection.Close();
            return listaWierszy.ToArray();
        }

    }
}
