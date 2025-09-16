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
                abonnementobject.Id = Convert.ToInt32((reader["subscription_id"]));
                abonnementobject.KlantId = Convert.ToInt32((reader["subscription_customer_id"]));
                abonnementobject.TypeId = Convert.ToInt32(reader["subscription_type_id"]);
                abonnementobject.StartDatum = Convert.ToDateTime(reader["subscription_start_date"]);
                abonnementobject.EindDatum = Convert.ToDateTime(reader["subscription_end_date"]);
                abonnementobject.OverigeRitten = Convert.ToInt32((reader["subscription_remaining_rides"]));
                abonnementobject.Actief = Convert.ToInt32((reader["subscription_active"]));
                abonnementlist.Add(abonnementobject);
            }

            con.Close();

            return abonnementlist;
        }
    }
}
