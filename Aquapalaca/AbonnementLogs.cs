using MySql.Data.MySqlClient;
using System;

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
    }
}
