using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapalaca
{
    class Abonnement
    {
        public int Id;
        public int KlantId;
        public int TypeId;
        public DateTime StartDatum;
        public DateTime EindDatum;
        public int OverigeRitten;
        public int Actief;




        public override string ToString()
        {
            return $"Id: {Id}, KlantId: {KlantId}, TypeId: {TypeId}, StartDatum: {StartDatum.ToShortDateString()}, EindDatum: {EindDatum.ToShortDateString()}, OverigeRitten: {OverigeRitten}, Actief: {Actief}";
        }

        public static List<Abonnement> getAbonnementen()
        {
            List<Abonnement> abonnementlist = new List<Abonnement>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM subscriptions";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Abonnement abonnementobject = new Abonnement();
                abonnementobject.Id = reader["subscription_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_id"]);
                abonnementobject.KlantId = reader["subscription_customer_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_customer_id"]);
                abonnementobject.TypeId = reader["subscription_type_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_type_id"]);
                abonnementobject.StartDatum = reader["subscription_start_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["subscription_start_date"]);
                abonnementobject.EindDatum = reader["subscription_end_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["subscription_end_date"]);
                abonnementobject.OverigeRitten = reader["subscription_remaining_rides"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_remaining_rides"]);
                abonnementobject.Actief = reader["subscription_active"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_active"]);
                abonnementlist.Add(abonnementobject);
            }

            con.Close();

            return abonnementlist;
        }

        public static List<Abonnement> GetAbonnementenByCustomerId(int klantId)
        {
            List<Abonnement> abonnementlist = new List<Abonnement>();

            using (MySqlConnection con = Databases.start())
            {
                con.Open();

                string sql = "SELECT * FROM subscriptions WHERE subscription_customer_id = @klantId";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@klantId", klantId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Abonnement abonnementobject = new Abonnement
                            {
                                Id = reader["subscription_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_id"]),
                                KlantId = reader["subscription_customer_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_customer_id"]),
                                TypeId = reader["subscription_type_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_type_id"]),
                                StartDatum = reader["subscription_start_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["subscription_start_date"]),
                                EindDatum = reader["subscription_end_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["subscription_end_date"]),
                                OverigeRitten = reader["subscription_remaining_rides"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_remaining_rides"]),
                                Actief = reader["subscription_active"] == DBNull.Value ? 0 : Convert.ToInt32(reader["subscription_active"])
                            };
                            abonnementlist.Add(abonnementobject);
                        }
                    }
                }
            }

            return abonnementlist;
        }

        public void Insert()
        {

            //Werkt nog niet
            using (MySqlConnection con = Databases.start())
            {
                con.Open();

                string sql = @"INSERT INTO subscriptions (
                            subscription_customer_id, 
                            subscription_type_id, 
                            subscription_start_date,
                            subscription_end_date,
                            subscription_remaining_rides,
                            subscription_active
                       ) VALUES (
                            @KlantId, 
                            @TypeId, 
                            @StartDatum,
                            @EindDatum,
                            @OverigeRitten,
                            @Actief
                       )";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@KlantId", this.KlantId);
                    cmd.Parameters.AddWithValue("@TypeId", this.TypeId);
                    cmd.Parameters.AddWithValue("@StartDatum", this.StartDatum);
                    cmd.Parameters.AddWithValue("@EindDatum", this.EindDatum);
                    cmd.Parameters.AddWithValue("@OverigeRitten", this.OverigeRitten);
                    cmd.Parameters.AddWithValue("@Actief", this.Actief);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
