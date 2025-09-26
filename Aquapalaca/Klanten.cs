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
        public string Address;
        public string Zipcode;
        public string City;
        public string Email;
        public string Phone;

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
        public string ToDetailedString()
        {
            return $"{Id} {Firstname} {Lastname} {Address} {Zipcode} {City} {Email} {Phone}";
        }

        public static List<Klanten> getCustomers()
        {
            List<Klanten> customers = new List<Klanten>();

            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                string sql = "SELECT customer_id, customer_firstname, customer_lastname, customer_address, customer_zipcode, customer_city, customer_email, customer_phone FROM customers";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Klanten
                        {
                            Id = reader["customer_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["customer_id"]),
                            Firstname = reader["customer_firstname"] == DBNull.Value ? "" : reader["customer_firstname"].ToString(),
                            Lastname = reader["customer_lastname"] == DBNull.Value ? "" : reader["customer_lastname"].ToString(),
                            Address = reader["customer_address"] == DBNull.Value ? "" : reader["customer_address"].ToString(),
                            Zipcode = reader["customer_zipcode"] == DBNull.Value ? "" : reader["customer_zipcode"].ToString(),
                            City = reader["customer_city"] == DBNull.Value ? "" : reader["customer_city"].ToString(),
                            Email = reader["customer_email"] == DBNull.Value ? "" : reader["customer_email"].ToString(),
                            Phone = reader["customer_phone"] == DBNull.Value ? "" : reader["customer_phone"].ToString(),
                        });
                    }
                }
            }

            return customers;
        }
        public void Update()
        {
            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                string sql = @"UPDATE customers 
                       SET customer_firstname = @Firstname,
                           customer_lastname = @Lastname,
                           customer_address = @Address,
                           customer_zipcode = @Zipcode,
                           customer_city = @City,
                           customer_email = @Email,
                           customer_phone = @Phone
                       WHERE customer_id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", Lastname);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Zipcode", Zipcode);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
