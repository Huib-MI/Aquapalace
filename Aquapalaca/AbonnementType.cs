using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Aquapalaca
{
    class AbonnementType
    {
        public int Id;
        public string Name;
        public string Description;
        public decimal Price;
        public int DurationDays;
        public int Rides;

        public override string ToString()
        {
            return Name;
        }

        public static List<AbonnementType> getTypes()
        {
            List<AbonnementType> typeList = new List<AbonnementType>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT * FROM subscription_types";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                AbonnementType type = new AbonnementType();
                type.Id = reader["subscription_type_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_type_id"]);
                type.Name = reader["subscription_type_name"].ToString();
                type.Description = reader["subscription_type_description"].ToString();
                type.Price = reader["subscription_type_price"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["subscription_type_price"]);
                type.DurationDays = reader["subscription_type_duration_days"] == DBNull.Value ? 0 : (int)Convert.ToInt32(reader["subscription_type_duration_days"]);
                type.Rides = reader["subscription_type_rides"] == DBNull.Value ? 0 : (int)Convert.ToInt32(reader["subscription_type_rides"]);

                typeList.Add(type);
            }

            con.Close();

            return typeList;
        }
    }
}
