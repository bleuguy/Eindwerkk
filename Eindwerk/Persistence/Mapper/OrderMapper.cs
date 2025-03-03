using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class OrderMapper
    {
        private string _connectionString;
        public OrderMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public OrderMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<Order> GetOrderFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.order";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<Order> returnList = new List<Order>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int orderID, fkGebruiker;
                DateTime datumBetaald, datumOrder;
                if (reader[0] != DBNull.Value) orderID = Convert.ToInt32(reader[0]); else orderID = 0;
                if (reader[1] != DBNull.Value) datumBetaald = Convert.ToDateTime(reader[1]); else datumBetaald = new DateTime();
                if (reader[2] != DBNull.Value) datumOrder = Convert.ToDateTime(reader[2]); else datumOrder = new DateTime();
                if (reader[3] != DBNull.Value) fkGebruiker = Convert.ToInt32(reader[3]); else fkGebruiker = 0;
                Order item = new Order(orderID, datumBetaald, datumOrder, fkGebruiker);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }

    }
}
