using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class CategroriënMapper
    {
        private string _connectionString;
        public CategroriënMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public CategroriënMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<Categorieën> GetCategorieënFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.categorieën";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<Categorieën> returnList = new List<Categorieën>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int categorieID;
                string categorieNaam, omschrijving;
                if (reader[0] != DBNull.Value) categorieID = Convert.ToInt32(reader[0]); else categorieID = 0;
                if (reader[1] != DBNull.Value) categorieNaam = Convert.ToString(reader[1]); else categorieNaam = string.Empty;
                if (reader[2] != DBNull.Value) omschrijving = Convert.ToString(reader[2]); else omschrijving = string.Empty;
                Categorieën item = new Categorieën(categorieID, categorieNaam, omschrijving);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }

    }
}
