using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class ProductenMapper
    {
        private string _connectionString;
        public ProductenMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public ProductenMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<Producten> GetProductenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.producten";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<Producten> returnList = new List<Producten>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productID, prijs, fkCategorie;
                string omschrijving, naamProduct, image;
                if (reader[0] != DBNull.Value) productID = Convert.ToInt32(reader[0]); else productID = 0;
                if (reader[1] != DBNull.Value) prijs = Convert.ToInt32(reader[1]); else prijs = 0;
                if (reader[2] != DBNull.Value) omschrijving = Convert.ToString(reader[2]); else omschrijving = string.Empty;
                if (reader[3] != DBNull.Value) naamProduct = Convert.ToString(reader[3]); else naamProduct = string.Empty;
                if (reader[4] != DBNull.Value) fkCategorie = Convert.ToInt32(reader[4]); else fkCategorie = 0;
                if (reader[4] != DBNull.Value) image = Convert.ToString(reader[4]); else image = string.Empty;
                Producten item = new Producten(productID, prijs, omschrijving, naamProduct, fkCategorie, image);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }

    }
}
