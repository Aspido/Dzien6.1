using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx"
            //  C:\Users\Krzysztof\Desktop\C#Szkolenie\Szkoleniowe\Dzien6\P01AplikacjaBazodanowa\A_ZawodnicyDataSet.xsd
            SqlConnection connection; //do nawiazywania polaczenia z baza
            SqlCommand command; // przechowywanie polecen sql
            SqlDataReader sqlDataReader; // czytanie wynikow z bazy 

            string connectionString = @"Data Source=KRZYSZTOF-DELL\WINCC;Initial Catalog=A_Zawodnicy;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            command = new SqlCommand("select * from trenerzy order by imie_t", connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader(); // wysylamy polecenie do bazy danych 


            while (sqlDataReader.Read()) // czytaj odpowiedz z bazy
            {
                string wynik = (string)sqlDataReader.GetValue(1) + " " +
                               (string)sqlDataReader.GetValue(2);
                Console.WriteLine(wynik);
            }
            
            connection.Close();

            Console.ReadKey();

        }
    }
}
