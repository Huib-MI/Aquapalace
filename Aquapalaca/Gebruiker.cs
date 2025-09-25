using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aquapalaca
{
    public class Gebruiker
    {
        public int Id;
        public string Gebruikersnaam;
        public string Hashwachtwoord;
        public string Rol;
        public DateTime CreatedAt;
        public override string ToString()
        {
            return $"Id = {this.Id}    Gebruikersnaam = {this.Gebruikersnaam}    Rol = {this.Rol}";
        }

        public static Gebruiker getLoginGebruiker(string gebruikersnaam, string wachtwoord)
        {
            Gebruiker gebruikersobject = null;
            MySqlConnection con = Databases.start();
            con.Open();
            MySqlCommand myCommand =  new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users WHERE user_username = @gebruikersnaam;";
            myCommand.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    string bestaandWachtwoord = Convert.ToString((reader["user_password_hash"]));
                    bool isMatch = BCrypt.Net.BCrypt.Verify(wachtwoord, bestaandWachtwoord);

                    if (isMatch)
                    {
                        gebruikersobject = new Gebruiker();
                        gebruikersobject.Id = Convert.ToInt32(reader["user_id"]);
                        gebruikersobject.Gebruikersnaam = Convert.ToString(reader["user_username"]);
                        gebruikersobject.Hashwachtwoord = bestaandWachtwoord;
                        gebruikersobject.Rol = Convert.ToString(reader["user_role"]);
                        gebruikersobject.CreatedAt = Convert.ToDateTime(reader["user_created_at"]);
                    }
                }
            }
            con.Close();
            return gebruikersobject;
        }

        public static List<Gebruiker> getGebruikers()
        {
            List<Gebruiker> gebruikerlist = new List<Gebruiker>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Gebruiker gebruikerobject = new Gebruiker();
                gebruikerobject.Id = Convert.ToInt32((reader["user_id"]));
                gebruikerobject.Gebruikersnaam = Convert.ToString((reader["user_username"]));
                gebruikerobject.Hashwachtwoord = Convert.ToString(reader["user_password_hash"]);
                gebruikerobject.Rol = Convert.ToString(reader["user_role"]);
                gebruikerobject.CreatedAt = Convert.ToDateTime(reader["user_created_at"]);
                gebruikerlist.Add(gebruikerobject);
            }

            con.Close();

            return gebruikerlist;
        }

        public void wijzigen()
        {
            MySqlConnection con = Databases.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE users SET user_username = @Gebruikersnaam, user_password_hash = @Wachtwoord, user_role = @Rol, user_created_at = @GemaaktOp WHERE user_id = @Id";
            myCommand.Parameters.AddWithValue("@Gebruikersnaam", this.Gebruikersnaam);
            myCommand.Parameters.AddWithValue("@Wachtwoord", this.Hashwachtwoord);
            myCommand.Parameters.AddWithValue("@Rol", this.Rol);
            myCommand.Parameters.AddWithValue("@GemaaktOp", this.CreatedAt);
            myCommand.Parameters.AddWithValue("@Id", this.Id);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        public static List<Gebruiker> OphalenDropDown()
        {
            List<Gebruiker> geblist = new List<Gebruiker>();

            MySqlConnection con = Databases.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT DISTINCT(user_role) FROM users;";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Gebruiker gebobj = new Gebruiker();
                gebobj.Rol = Convert.ToString(reader["user_role"]);
                geblist.Add(gebobj);
            }

            con.Close();
            return geblist;
        }




    }   
}
