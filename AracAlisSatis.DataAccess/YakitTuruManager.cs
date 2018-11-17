using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracAlisSatis.Entity;
using MySql.Data.MySqlClient;

namespace AracAlisSatis.DataAccess
{
    public class YakitTuruManager
    {
        public static List<YakitTuru> GetObjects()
        {
            List<YakitTuru> items = new List<YakitTuru>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_yakitturu";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        YakitTuru item = new YakitTuru();
                        item.YakitTuruAdi = dr["Yakit_Turu"] != DBNull.Value ? dr["Yakit_Turu"].ToString() : string.Empty;
                        item.YakitTuruID = Convert.ToInt32(dr["YakitTuruID"]);
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(YakitTuru item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_yakitturu(YakitTuruID,Yakit_Turu) VALUES(0,@Yakit_Turu)";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Yakit_Turu", item.YakitTuruAdi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(YakitTuru item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_yakitturu SET Yakit_Turu=@Yakit_Turu WHERE YakitTuruID=@YakitTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Yakit_Turu", item.YakitTuruAdi);
                    cmd.Parameters.AddWithValue("@YakitTuruID", item.YakitTuruID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tbl_yakitturu WHERE YakitTuruID=@YakitTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@YakitTuruID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static YakitTuru GetObjectById(int id)
        {
            YakitTuru item = null;

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_yakitturu WHERE YakitTuruID=@YakitTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@YakitTuruID", id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new YakitTuru();
                        item.YakitTuruAdi = dr["Yakit_Turu"] != DBNull.Value ? dr["Yakit_Turu"].ToString() : string.Empty;
                        item.YakitTuruID = Convert.ToInt32(dr["YakitTuruID"]);
                    }
                }
            }
            return item;
        }
    }
}
