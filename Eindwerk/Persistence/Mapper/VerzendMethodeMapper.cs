using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class VerzendMethodeMapper
    {
        private string _connectionString;
        public VerzendMethodeMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public VerzendMethodeMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<VerzendMethode> GetVerzendMethodeFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.verzendmethode";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<VerzendMethode> returnList = new List<VerzendMethode>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idVerzendMethode;
                double prijs;
                string omschrijving;
                if (reader[0] != DBNull.Value) idVerzendMethode = Convert.ToInt32(reader[0]); else idVerzendMethode = 0;
                if (reader[1] != DBNull.Value) omschrijving = Convert.ToString(reader[1]); else omschrijving = string.Empty;
                if (reader[2] != DBNull.Value) prijs = Convert.ToDouble(reader[2]); else prijs = 0;
                VerzendMethode item = new VerzendMethode(idVerzendMethode, omschrijving, prijs);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
    }
}
