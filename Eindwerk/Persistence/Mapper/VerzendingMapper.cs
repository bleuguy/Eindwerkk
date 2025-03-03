using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class VerzendingMapper
    {
        private string _connectionString;
        public VerzendingMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public VerzendingMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<Verzending> GetVerzendingFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.verzending";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<Verzending> returnList = new List<Verzending>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int shippingID, huisnummer, postcode, fkOrder, fkVerzendMethode;
                string naam, voornaam, land, straat, bus;
                if (reader[0] != DBNull.Value) shippingID = Convert.ToInt32(reader[0]); else shippingID = 0;
                if (reader[1] != DBNull.Value) naam = Convert.ToString(reader[1]); else naam = string.Empty;
                if (reader[2] != DBNull.Value) voornaam = Convert.ToString(reader[2]); else voornaam = string.Empty;
                if (reader[3] != DBNull.Value) land = Convert.ToString(reader[3]); else land = string.Empty;
                if (reader[4] != DBNull.Value) straat = Convert.ToString(reader[4]); else straat = string.Empty;
                if (reader[5] != DBNull.Value) huisnummer = Convert.ToInt32(reader[5]); else huisnummer = 0;
                if (reader[6] != DBNull.Value) bus = Convert.ToString(reader[6]); else bus = string.Empty;
                if (reader[7] != DBNull.Value) postcode = Convert.ToInt32(reader[7]); else postcode = 0;
                if (reader[8] != DBNull.Value) fkOrder = Convert.ToInt32(reader[8]); else fkOrder = 0;
                if (reader[9] != DBNull.Value) fkVerzendMethode = Convert.ToInt32(reader[9]); else fkVerzendMethode = 0;
                Verzending item = new Verzending(shippingID, naam, voornaam, land, straat, huisnummer, bus, postcode, fkOrder, fkVerzendMethode);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
    }
}
