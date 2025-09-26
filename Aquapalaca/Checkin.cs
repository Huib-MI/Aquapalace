using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapalaca
{
    class Checkin
    {
        public int Id;
        public int SubscriptieId;
        public int KlantId;
        public string CheckinMethode;
        public DateTime CheckinTijd;

        public void Insert()
        {
            using (MySqlConnection con = Databases.start())
            {
                con.Open();

                string sql = @"INSERT INTO checkins (
                                    checkin_subscription_id,
                                    checkin_customer_id,
                                    checkin_time,
                                    checkin_method
                               ) VALUES (
                                    @SubscriptieId,
                                    @KlantId,
                                    @CheckinTijd,
                                    @CheckinMethode
                               )";

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
