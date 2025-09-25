using Aquapalaca;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aquapalaca
{
    class CheckIn
    {
        public int Id;
        public string SubscriptionId;
        public string CustomerId;
        public DateTime Time;
        public string Method;

        public static List<CheckIn> getCheckIn()
        {
            List<CheckIn> checkinlist = new List<CheckIn>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM checkins";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                CheckIn checkinobject = new CheckIn();
                checkinobject.Id = Convert.ToInt32((reader["checkin_id"]));
                checkinobject.SubscriptionId = Convert.ToString(reader["checkin_subscription_id"]);
                checkinobject.CustomerId = Convert.ToString(reader["checkin_customer_id"]);
                checkinobject.Time = Convert.ToDateTime(reader["checkin_time"]);
                checkinobject.Method = Convert.ToString(reader["checkin_method"]);
                checkinlist.Add(checkinobject);
            }

            con.Close();

            return checkinlist;
        }


        public void Inchecken()
        {
            MySqlConnection con = Databases.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE checkins 
                                        SET 
                                        checkin_subscription_id = @SubscriptionId,
                                        checkin_customer_id = @CustomerId,
                                        checkin_time = @Time,
                                        checkin_method = @Method
                                        WHERE
                                        checkin_id = @Id;";
            myCommand.Parameters.AddWithValue("@SubscriptionId", this.SubscriptionId);
            myCommand.Parameters.AddWithValue("@CustomerId", this.CustomerId);
            myCommand.Parameters.AddWithValue("@Time", this.Time);
            myCommand.Parameters.AddWithValue("@Method", this.Method);
            myCommand.Parameters.AddWithValue("@Id", this.Id);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        
    }
}


    