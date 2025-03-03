using Eindwerk_Domain.Business.Norm.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence.Mapper
{
    internal class OrderInformatieMapper
    {
        private string _connectionString;
        public OrderInformatieMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public OrderInformatieMapper(string connstring)
        {
            _connectionString = connstring;
        }
        public List<OrderInformatie> GetOrderInformatieFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string command = "SELECT * FROM eindwerk.orderinformatie";
            MySqlCommand cmd = new MySqlCommand(command, conn);
            List<OrderInformatie> returnList = new List<OrderInformatie>();
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int aantal, fkorder, fkproduct;
                if (reader[0] != DBNull.Value) aantal = Convert.ToInt32(reader[0]); else aantal = 0;
                if (reader[1] != DBNull.Value) fkorder = Convert.ToInt32(reader[1]); else fkorder = 0;
                if (reader[2] != DBNull.Value) fkproduct = Convert.ToInt32(reader[2]); else fkproduct = 0;
                OrderInformatie item = new OrderInformatie(aantal, fkorder, fkproduct);
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
    }
}
