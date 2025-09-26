using Aquapalaca;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Aquapalaca
{
    class Checkin
    {
        public int Id;
        public int SubscriptieId;
        public int KlantId;
        public DateTime CheckinTijd;
        public string CheckinMethode;

        public static List<Checkin> getCheckIn()
        {
            List<Checkin> checkinlist = new List<Checkin>();

            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM checkins", con);
                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    Checkin checkinobject = new Checkin();
                    checkinobject.Id = Convert.ToInt32(reader["checkin_id"]);
                    checkinobject.SubscriptieId = Convert.ToInt32(reader["checkin_subscription_id"]);
                    checkinobject.KlantId = Convert.ToInt32(reader["checkin_customer_id"]);
                    checkinobject.CheckinTijd = Convert.ToDateTime(reader["checkin_time"]);
                    checkinobject.CheckinMethode = Convert.ToString(reader["checkin_method"]);
                    checkinlist.Add(checkinobject);
                }
            }

            return checkinlist;
        }

        public void Inchecken()
        {
            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                MySqlCommand myCommand = new MySqlCommand(@"
                    UPDATE checkins
                    SET 
                        checkin_subscription_id = @SubscriptieId,
                        checkin_customer_id = @KlantId,
                        checkin_time = @CheckinTijd,
                        checkin_method = @CheckinMethode
                    WHERE checkin_id = @Id;", con);

                myCommand.Parameters.AddWithValue("@SubscriptieId", this.SubscriptieId);
                myCommand.Parameters.AddWithValue("@KlantId", this.KlantId);
                myCommand.Parameters.AddWithValue("@CheckinTijd", this.CheckinTijd);
                myCommand.Parameters.AddWithValue("@CheckinMethode", this.CheckinMethode);
                myCommand.Parameters.AddWithValue("@Id", this.Id);

                myCommand.ExecuteNonQuery();
            }
        }

        public void Insert()
        {
            using (MySqlConnection con = Databases.start())
            {
                con.Open();
                string sql = @"
                    INSERT INTO checkins (
                        checkin_subscription_id,
                        checkin_customer_id,
                        checkin_time,
                        checkin_method
                    ) VALUES (
                        @SubscriptieId,
                        @KlantId,
                        @CheckinTijd,
                        @CheckinMethode
                    );";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@SubscriptieId", this.SubscriptieId);
                    cmd.Parameters.AddWithValue("@KlantId", this.KlantId);
                    cmd.Parameters.AddWithValue("@CheckinTijd", this.CheckinTijd);
                    cmd.Parameters.AddWithValue("@CheckinMethode", this.CheckinMethode);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
