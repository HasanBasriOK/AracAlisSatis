using AracAlisSatis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AracAlisSatis.DataAccess
{
    public class RenkManager
    {
        public static List<Renk> GetObjects()
        {
            List<Renk> items = new List<Renk>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_renk";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Renk item = new Renk();
                        item.RenkAdi = dr["Renk"] != DBNull.Value ? dr["Renk"].ToString() : string.Empty;
                        item.RenkID = Convert.ToInt32(dr["RenkID"]);
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(Renk item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_renk(RenkId,Renk) VALUES(0,@Renk)";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Renk", item.RenkAdi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Renk item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_renk SET Renk=@Renk WHERE RenkID=@RenkID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Renk", item.RenkAdi);
                    cmd.Parameters.AddWithValue("@RenkID", item.RenkID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tbl_renk WHERE RenkID=@RenkID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@RenkID",id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Renk GetObjectById(int id)
        {
            Renk item = null;

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_renk WHERE RenkID=@RenkID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@RenkID", id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if(dr.HasRows)
                    {
                        item = new Renk();
                        item.RenkAdi = dr["Renk"] != DBNull.Value ? dr["Renk"].ToString() : string.Empty;
                        item.RenkID = Convert.ToInt32(dr["RenkID"]);
                    }
                }
            }
            return item;
        }
    }
}
