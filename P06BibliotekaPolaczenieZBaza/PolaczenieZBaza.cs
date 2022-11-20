using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06BibliotekaPolaczenieZBaza
{
    public class PolaczenieZBaza
    {
         string connectionString = @"Data Source=KRZYSZTOF-DELL\WINCC;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        //public string ConnectionString => connectionString; 

        //public PolaczenieZBaza()
        //{

        //}
        //public PolaczenieZBaza(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

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
