using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapalaca
{
    class Klanten
    {
        public int Id;
        public string Firstname;
        public string Lastname;

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }

        public static List<Klanten> getCustomers()
        {
            List<Klanten> customers = new List<Klanten>();

            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                string sql = "SELECT customer_id, customer_firstname, customer_lastname FROM customers";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Klanten
                        {
                            Id = reader["customer_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["customer_id"]),
                            Firstname = reader["customer_firstname"] == DBNull.Value ? "" : reader["customer_firstname"].ToString(),
                            Lastname = reader["customer_lastname"] == DBNull.Value ? "" : reader["customer_lastname"].ToString()
                        });
                    }
                }
            }

            return customers;
        }
    }
}
