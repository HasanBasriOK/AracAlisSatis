using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AracAlisSatis.Entity;

namespace AracAlisSatis.DataAccess
{
    public class VitesTuruManager
    {
        public static List<VitesTuru> GetObjects()
        {
            List<VitesTuru> items = new List<VitesTuru>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_vitesturu";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        VitesTuru item = new VitesTuru();
                        item.VitesTuruAdi = dr["Vites_Turu"] != DBNull.Value ? dr["Vites_Turu"].ToString() : string.Empty;
                        item.VitesTuruID = Convert.ToInt32(dr["VitesTuruID"]);
                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(VitesTuru item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_vitesturu(VitesTuruID,Vites_Turu) VALUES(0,@Vites_Turu)";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Vites_Turu", item.VitesTuruAdi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(VitesTuru item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_vitesturu SET Vites_Turu=@Vites_Turu WHERE VitesTuruID=@VitesTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Vites_Turu", item.VitesTuruAdi);
                    cmd.Parameters.AddWithValue("@VitesTuruID", item.VitesTuruID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tbl_vitesturu WHERE VitesTuruID=@VitesTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@VitesTuruID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static VitesTuru GetObjectById(int id)
        {
            VitesTuru item = null;

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_vitesturu WHERE VitesTuruID=@VitesTuruID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@VitesTuruID", id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new VitesTuru();
                        item.VitesTuruAdi = dr["Vites_Turu"] != DBNull.Value ? dr["Vites_Turu"].ToString() : string.Empty;
                        item.VitesTuruID = Convert.ToInt32(dr["VitesTuruID"]);
                    }
                }
            }
            return item;
        }
    }
}
