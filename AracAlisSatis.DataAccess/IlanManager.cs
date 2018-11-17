using AracAlisSatis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AracAlisSatis.DataAccess
{
    public class IlanManager
    {
        public static List<Ilan> GetObjects()
        {
            List<Ilan> items = new List<Ilan>();

            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_ilan";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Ilan item = new Ilan();
                        item.IlanID = Convert.ToInt32(dr["IlanID"]);
                        item.Ilan_Adi = dr["Ilan_Adi"] != DBNull.Value ? dr["Ilan_Adi"].ToString():string.Empty;
                        item.Ilan_ArabaID = dr["Ilan_ArabaID"] != DBNull.Value ? Convert.ToInt32(dr["Ilan_ArabaID"]) : default(int);
                        item.Ilan_Fiyat = dr["Ilan_Fiyat"] != DBNull.Value ? Convert.ToDouble(dr["Ilan_Fiyat"]) : default(double);
                        item.Ilan_Km = dr["Ilan_Km"] != DBNull.Value ? Convert.ToDouble(dr["Ilan_Km"]) : default(double);
                        item.Ilan_SehirID = dr["Ilan_SehirID"] != DBNull.Value ? Convert.ToInt32(dr["Ilan_SehirID"]) : default(int);
                        item.Ilan_Tarih = dr["Ilan_Tarih"] != DBNull.Value ? Convert.ToDateTime(dr["Ilan_Tarih"]) : DateTime.MinValue;

                        items.Add(item);
                    }
                }
            }
            return items;
        }

        public static void Insert(Ilan item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "INSERT INTO tbl_ilan(IlanID,Ilan_Adi,Ilan_ArabaID,Ilan_Fiyat,Ilan_Km,Ilan_SehirID,Ilan_Tarih) VALUES(0,@Ilan_Adi,@Ilan_ArabaID,@Ilan_Fiyat,@Ilan_Km,@Ilan_SehirID,@Ilan_Tarih)";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@Ilan_Adi", item.Ilan_Adi);
                    cmd.Parameters.AddWithValue("@Ilan_ArabaID", item.Ilan_ArabaID);
                    cmd.Parameters.AddWithValue("@Ilan_Fiyat", item.Ilan_Fiyat);
                    cmd.Parameters.AddWithValue("@Ilan_Km", item.Ilan_Km);
                    cmd.Parameters.AddWithValue("@Ilan_SehirID", item.Ilan_SehirID);
                    cmd.Parameters.AddWithValue("@Ilan_Tarih", item.Ilan_Tarih);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Ilan item)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "UPDATE tbl_ilan SET Ilan_Adi=@Ilan_Adi,Ilan_ArabaID=@Ilan_ArabaID,Ilan_Fiyat=@Ilan_Fiyat,Ilan_Km=@Ilan_Km,Ilan_SehirID=@Ilan_SehirID,Ilan_Tarih=@Ilan_Tarih WHERE IlanID=@IlanID";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@Ilan_Adi", item.Ilan_Adi);
                    cmd.Parameters.AddWithValue("@Ilan_ArabaID", item.Ilan_ArabaID);
                    cmd.Parameters.AddWithValue("@Ilan_Fiyat", item.Ilan_Fiyat);
                    cmd.Parameters.AddWithValue("@Ilan_Km", item.Ilan_Km);
                    cmd.Parameters.AddWithValue("@Ilan_SehirID", item.Ilan_SehirID);
                    cmd.Parameters.AddWithValue("@Ilan_Tarih", item.Ilan_Tarih);
                    cmd.Parameters.AddWithValue("@IlanID", item.IlanID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "DELETE FROM tb_ilan WHERE IlanID=@IlanID";

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@IlanID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Ilan GetObjectById(int id)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = "SELECT * FROM tbl_ilan WHERE IlanID=@IlanID";

            Ilan item = null;

            using (MySqlConnection con=new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd=new MySqlCommand(commandString,con))
                {
                    cmd.Parameters.AddWithValue("@IlanID", id);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        item = new Ilan();
                        item.IlanID = Convert.ToInt32(dr["IlanID"]);
                        item.Ilan_Adi = dr["Ilan_Adi"] != DBNull.Value ? dr["Ilan_Adi"].ToString() : string.Empty;
                        item.Ilan_ArabaID = dr["Ilan_ArabaID"] != DBNull.Value ? Convert.ToInt32(dr["Ilan_ArabaID"]) : default(int);
                        item.Ilan_Fiyat = dr["Ilan_Fiyat"] != DBNull.Value ? Convert.ToDouble(dr["Ilan_Fiyat"]) : default(double);
                        item.Ilan_Km = dr["Ilan_Km"] != DBNull.Value ? Convert.ToDouble(dr["Ilan_Km"]) : default(double);
                        item.Ilan_SehirID = dr["Ilan_SehirID"] != DBNull.Value ? Convert.ToInt32(dr["Ilan_SehirID"]) : default(int);
                        item.Ilan_Tarih = dr["Ilan_Tarih"] != DBNull.Value ? Convert.ToDateTime(dr["Ilan_Tarih"]) : DateTime.MinValue;
                    }
                }
            }
            return item;
        }

        public static DataTable GetObjectsWithTable()
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = @"SELECT I.IlanID,I.Ilan_Adi AS 'İlan Adı',I.Ilan_Fiyat AS 'İlan Fiyat',I.Ilan_Km AS 'İlan Kilometre'
,I.Ilan_Tarih AS 'İlan Tarih',A.Araba_Marka AS 'Araba',S.Sehir AS 'Şehir'
FROM tbl_ilan AS I LEFT JOIN 
tbl_araba AS A ON A.ArabaID=I.Ilan_ArabaID LEFT JOIN
tbl_sehir AS S ON S.SehirID=I.Ilan_SehirID
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

        public static DataTable GetObjectsWithTable(string queryStr)
        {
            string connectionString = "Server=localhost;Database=aracalissatis;Uid=root;Pwd=P@ssw0rd1!;";
            string commandString = queryStr;

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
