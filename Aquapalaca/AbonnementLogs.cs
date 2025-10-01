using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Aquapalaca
{
    class AbonnementLogs
    {
        public int Id;
        public int SubscriptieId;
        public int KlantId;
        public DateTime EindDatum;
        public DateTime LogTijd;
        public string Status;

        public void Insert()
        {
            using (MySqlConnection con = Databases.start())
            {
                con.Open();

                string sql = @"INSERT INTO subscription_log (
                                    subscription_log_subscription_id,
                                    subscription_log_customer_id,
                                    subscription_log_subscription_end_date,
                                    subscription_log_logged_at,
                                    subscription_log_status
                               ) VALUES (
                                    @SubscriptieId,
                                    @KlantId,
                                    @EindDatum,
                                    @LogTijd,
                                    @Status
                               )";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@SubscriptieId", this.SubscriptieId);
                    cmd.Parameters.AddWithValue("@KlantId", this.KlantId);
                    cmd.Parameters.AddWithValue("@EindDatum", this.EindDatum);
                    cmd.Parameters.AddWithValue("@LogTijd", this.LogTijd);
                    cmd.Parameters.AddWithValue("@Status", this.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }
            public static List<AbonnementLogs> GetLogsByCustomerId(int klantId)
        {
            List<AbonnementLogs> logs = new List<AbonnementLogs>();

            using (MySqlConnection con = Databases.start())
            {
                con.Open();

                string sql = @"SELECT * FROM subscription_log 
                       WHERE subscription_log_customer_id = @KlantId
                       ORDER BY subscription_log_logged_at DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@KlantId", klantId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AbonnementLogs log = new AbonnementLogs
                            {
                                Id = Convert.ToInt32(reader["subscription_log_id"]),
                                SubscriptieId = Convert.ToInt32(reader["subscription_log_subscription_id"]),
                                KlantId = Convert.ToInt32(reader["subscription_log_customer_id"]),
                                EindDatum = Convert.ToDateTime(reader["subscription_log_subscription_end_date"]),
                                LogTijd = Convert.ToDateTime(reader["subscription_log_logged_at"]),
                                Status = Convert.ToString(reader["subscription_log_status"])
                            };

                            logs.Add(log);
                        }
                    }
                }
            }

            return logs;
        }

    }
}

