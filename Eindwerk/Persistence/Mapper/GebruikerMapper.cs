using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class GebruikerMapper
    {
        private string _connectionString;
        public GebruikerMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public GebruikerMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<Gebruiker> GetGebruikerFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.gebruiker";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<Gebruiker> returnList = new List<Gebruiker>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int gebruikerID, telefoonnummer;
                string naam, voornaam, email, wachtwoord;
                DateTime geboortedatum;
                if (reader[0] != DBNull.Value) gebruikerID = Convert.ToInt32(reader[0]); else gebruikerID = 0;
                if (reader[1] != DBNull.Value) naam = Convert.ToString(reader[1]); else naam = string.Empty;
                if (reader[2] != DBNull.Value) voornaam = Convert.ToString(reader[2]); else voornaam = string.Empty;
                if (reader[3] != DBNull.Value) email = Convert.ToString(reader[3]); else email = string.Empty;
                if (reader[0] != DBNull.Value) telefoonnummer = Convert.ToInt32(reader[4]); else telefoonnummer = 0;
                if (reader[4] != DBNull.Value) geboortedatum = Convert.ToDateTime(reader[5]); else geboortedatum = DateTime.Today;
                if (reader[5] != DBNull.Value) wachtwoord = Convert.ToString(reader[6]); else wachtwoord = string.Empty;
                Gebruiker item = new Gebruiker(gebruikerID, naam, voornaam, email, telefoonnummer, geboortedatum, wachtwoord);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
        public void AddGebruikerToDB(Gebruiker gebruiker)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO eindwerk.gebruiker (naam, voornaam, email, telefoonnummer, geboortedatum, wachtwoord) " +
                                   "VALUES (@Naam, @Voornaam, @Email, @Telefoonnummer, @Geboortedatum, @Wachtwoord)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Naam", gebruiker.Naam);
                    cmd.Parameters.AddWithValue("@Voornaam", gebruiker.Voornaam);
                    cmd.Parameters.AddWithValue("@Email", gebruiker.Email);
                    cmd.Parameters.AddWithValue("@Telefoonnummer", gebruiker.Telefoonnummer);
                    cmd.Parameters.AddWithValue("@Geboortedatum", gebruiker.Geboortedatum);
                    cmd.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"DatabaseFout: {ex.Message}");
                }
            }
        }

            public bool ControleerGebruiker(string email, string wachtwoord)
            {
                bool isGeldig = false;
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM eindwerk.gebruiker WHERE email = @Email AND wachtwoord = @Wachtwoord";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isGeldig = count > 0;
                       
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"DatabaseFout: {ex.Message}");
                    }
                }
                return isGeldig;
            }
        

    }
}
