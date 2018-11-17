using AracAlisSatis.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracAlisSatis.DataAccess
{
    public class SehirManager
    {
        public static List<Sehir> GetObjects()
        {
            List<Sehir> items = new List<Sehir>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_sehir";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Sehir item = new Sehir();
                        item.SehirAdi = dr["Sehir"] != DBNull.Value ? dr["Sehir"].ToString() : string.Empty;
                        item.SehirID = Convert.ToInt32(dr["SehirID"]);
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(Sehir item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_sehir(SehirID,Sehir) VALUES(0,@Sehir)";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Sehir", item.SehirAdi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Sehir item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_sehir SET Sehir=@Sehir WHERE SehirID=@SehirID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Sehir", item.SehirAdi);
                    cmd.Parameters.AddWithValue("@SehirID", item.SehirID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tbl_sehir WHERE SehirID=@SehirID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@SehirID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Sehir GetObjectById(int id)
        {
            Sehir item = null;

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_sehir WHERE SehirID=@SehirID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@SehirID", id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new Sehir();
                        item.SehirAdi = dr["Sehir"] != DBNull.Value ? dr["Sehir"].ToString() : string.Empty;
                        item.SehirID = Convert.ToInt32(dr["SehirID"]);
                    }
                }
            }
            return item;
        }
    }
}
