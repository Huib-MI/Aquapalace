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
            return $"Id: {Id}, KlantId: {KlantId}, TypeId: {TypeId}, StartDatum: {StartDatum.ToShortDateString()}, EindDatum: {EindDatum.ToShortDateString()}, OverigeRitten: {OverigeRitten}";
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
        public static List<Abonnement> filterAbonnementen(int klantId, int typeId)
        {
            List<Abonnement> abonnementlist = new List<Abonnement>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;

            string sql = "SELECT * FROM subscriptions WHERE 1=1";

            if (klantId > 0)
            {
                sql += " AND subscription_customer_id = @klantId";
                myCommand.Parameters.AddWithValue("@klantId", klantId);
            }

            if (typeId > 0)
            {
                sql += " AND subscription_type_id = @typeId";
                myCommand.Parameters.AddWithValue("@typeId", typeId);
            }

            myCommand.CommandText = sql;

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

        public void KoppelKlant(int newKlantId)
        {
            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE subscriptions 
                        SET subscription_customer_id = @newKlantId 
                        WHERE subscription_id = @subscriptionId";
            cmd.Parameters.AddWithValue("@newKlantId", newKlantId);
            cmd.Parameters.AddWithValue("@subscriptionId", this.Id);

            cmd.ExecuteNonQuery();
            con.Close();

            this.KlantId = newKlantId;
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
