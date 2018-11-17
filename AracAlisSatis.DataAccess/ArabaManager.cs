using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AracAlisSatis.Entity;
using System.Data;

namespace AracAlisSatis.DataAccess
{
    public class ArabaManager
    {
        public static List<Araba> GetObjects()
        {
            List<Araba> items = new List<Araba>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_araba";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Araba item = new Araba();
                        item.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                        item.Marka = dr["Araba_Marka"] != DBNull.Value ? dr["Araba_Marka"].ToString() :string.Empty;
                        item.Model = dr["Araba_Model"] != DBNull.Value ? dr["Araba_Model"].ToString() : string.Empty;
                        item.RenkID = dr["Araba_RenkID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_RenkID"]) : default(int);
                        item.VitesTuruID = dr["Araba_VitesTuruID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_VitesTuruID"]) : default(int);
                        item.YakitTuruID = dr["Araba_YakitTuruID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_YakitTuruID"]) : default(int);

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(Araba item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_araba(ArabaID,Araba_Marka,Araba_Model,Araba_VitesTuruID,Araba_YakitTuruID,Araba_RenkID) VALUES (0,@Marka,@Model,@VitesTuruID,@YakitTuruID,@RenkID)";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@Marka", item.Marka);
                    cmd.Parameters.AddWithValue("@Model", item.Model);
                    cmd.Parameters.AddWithValue("@RenkID", item.RenkID);
                    cmd.Parameters.AddWithValue("@VitesTuruID", item.VitesTuruID);
                    cmd.Parameters.AddWithValue("@YakitTuruID", item.YakitTuruID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Araba item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_araba SET Araba_Marka=@Marka,Araba_Model=@Model,Araba_VitesTuruID=@VitesTuruID,Araba_YakitTuruID=@YakitTuruID,Araba_RenkID=@RenkID WHERE ArabaID=@ArabaID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@Marka", item.Marka);
                    cmd.Parameters.AddWithValue("@Model", item.Model);
                    cmd.Parameters.AddWithValue("@RenkID", item.RenkID);
                    cmd.Parameters.AddWithValue("@VitesTuruID", item.VitesTuruID);
                    cmd.Parameters.AddWithValue("@YakitTuruID", item.YakitTuruID);
                    cmd.Parameters.AddWithValue("@ArabaID", item.ArabaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tbl_araba WHERE ArabaID=@ArabaID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@ArabaID",id);
                   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Araba GetObjectById(int id)
        {
            Araba item = null;

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_araba WHERE ArabaID=@ArabaID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    cmd.Parameters.AddWithValue("@ArabaID", id);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if(dr.HasRows)
                    {
                        item = new Araba();
                        item.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                        item.Marka = dr["Araba_Marka"] != DBNull.Value ? dr["Araba_Marka"].ToString() : string.Empty;
                        item.Model = dr["Araba_Model"] != DBNull.Value ? dr["Araba_Model"].ToString() : string.Empty;
                        item.RenkID = dr["Araba_RenkID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_RenkID"]) : default(int);
                        item.VitesTuruID = dr["Araba_VitesTuruID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_VitesTuruID"]) : default(int);
                        item.YakitTuruID = dr["Araba_YakitTuruID"] != DBNull.Value ? Convert.ToInt32(dr["Araba_YakitTuruID"]) : default(int);
                    }
                }
            }
            return item;
        }

        public static DataTable GetObjectsWithTable()
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = @"SELECT A.ArabaID,A.Araba_Marka AS 'Marka',A.Araba_Model AS 'Model',VT.Vites_Turu AS 'Vites Türü',
YT.Yakit_Turu 'Yakıt Türü',R.Renk AS 'Renk'
FROM tbl_araba AS A LEFT OUTER JOIN 
tbl_vitesturu AS VT ON A.Araba_VitesTuruID=VT.VitesTuruID LEFT OUTER JOIN 
tbl_yakitturu AS YT ON YT.YakitTuruID=A.Araba_YakitTuruID LEFT OUTER JOIN
tbl_renk AS R ON R.RenkID=A.Araba_RenkID
";

            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandString, con))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                }
            }
            return dt;
        }
    }
}
