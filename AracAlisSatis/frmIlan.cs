using AracAlisSatis.DataAccess;
using AracAlisSatis.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracAlisSatis
{
    public partial class frmIlan : Form
    {
        #region Variables
        List<Renk> renkList = new List<Renk>();
        List<VitesTuru> vitesTuruList = new List<VitesTuru>();
        List<YakitTuru> yakitTuruList = new List<YakitTuru>();
        List<Sehir> sehirList = new List<Sehir>();
        #endregion

        #region Constructors
        public frmIlan()
        {
            InitializeComponent();
            FillSehir();
            FillRenk();
            FillVitesTuru();
            FillYakitTuru();
        } 
        #endregion

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmIlanDetay frm = new frmIlanDetay();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ilanId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            Ilan ilan = IlanManager.GetObjectById(ilanId);
            frmIlanDetay frm = new frmIlanDetay(ilan);
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int ilanId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    IlanManager.Delete(ilanId);

                    MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = IlanManager.GetObjectsWithTable();
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmIlan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IlanManager.GetObjectsWithTable();
        }
        #endregion

        #region Private Methods
        private void FillSehir()
        {
            sehirList = SehirManager.GetObjects();
            cmbSehir.Properties.Items.Add("Seçiniz...");
            foreach (var item in sehirList)
            {
                cmbSehir.Properties.Items.Add(item.SehirAdi);
            }
        }

        private void FillRenk()
        {
            renkList = RenkManager.GetObjects();
            cmbRenk.Properties.Items.Add("Seçiniz...");

            foreach (var item in renkList)
            {
                cmbRenk.Properties.Items.Add(item.RenkAdi);
            }
        }

        private void FillYakitTuru()
        {
            yakitTuruList = YakitTuruManager.GetObjects();
            cmbYakitTuru.Properties.Items.Add("Seçiniz...");

            foreach (var item in yakitTuruList)
            {
                cmbYakitTuru.Properties.Items.Add(item.YakitTuruAdi);
            }
        }

        private void FillVitesTuru()
        {
            vitesTuruList = VitesTuruManager.GetObjects();
            cmbVitesTuru.Properties.Items.Add("Seçiniz...");

            foreach (var item in vitesTuruList)
            {
                cmbVitesTuru.Properties.Items.Add(item.VitesTuruAdi);
            }
        }
        #endregion

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectQuery = @"SELECT * 
FROM tbl_Ilan AS I LEFT JOIN
tbl_araba AS A ON I.Ilan_ArabaID=A.ArabaID LEFT  JOIN 
tbl_vitesturu AS VT ON A.Araba_VitesTuruID=VT.VitesTuruID LEFT  JOIN 
tbl_yakitturu AS YT ON YT.YakitTuruID=A.Araba_YakitTuruID LEFT  JOIN
tbl_renk AS R ON R.RenkID=A.Araba_RenkID WHERE ";

            string whereQuery = String.Empty;

            if (!string.IsNullOrEmpty(cmbRenk.SelectedText) && cmbRenk.SelectedText!="Seçiniz...")
            {
                int renkId = renkList.FirstOrDefault(x => x.RenkAdi == cmbRenk.SelectedText).RenkID;
                whereQuery += " AND Ilan_RenkID=" + renkId;
            }

            if (!string.IsNullOrEmpty(cmbSehir.SelectedText) && cmbSehir.SelectedText!="Seçiniz...")
            {
                int sehirId = sehirList.FirstOrDefault(x => x.SehirAdi == cmbSehir.SelectedText).SehirID;
                whereQuery += " AND Ilan_SehirID=" + sehirId;
            }

            if (!string.IsNullOrEmpty(cmbVitesTuru.SelectedText) && cmbVitesTuru.SelectedText != "Seçiniz...")
            {
                int vitesTuruId = vitesTuruList.FirstOrDefault(x => x.VitesTuruAdi == cmbVitesTuru.SelectedText).VitesTuruID;
                whereQuery += " AND A.Araba_VitesTuruID= " + vitesTuruId;
            }

            if (!string.IsNullOrEmpty(cmbYakitTuru.SelectedText) && cmbYakitTuru.SelectedText != "Seçiniz...")
            {
                int yakitTuruId = yakitTuruList.FirstOrDefault(x => x.YakitTuruAdi == cmbYakitTuru.SelectedText).YakitTuruID;
                whereQuery += " AND A.Araba_YakitTuruID=" + yakitTuruId;
            }

            if (!string.IsNullOrEmpty(txtMarka.Text))
            {
                whereQuery += " AND A.Araba_Marka LIKE'%" + txtMarka.Text + "%'";
            }

            #region Fiyat Filtresi
            double fiyatMin = Convert.ToDouble(spnMinFiyat.EditValue);
            double fiyatMax = Convert.ToDouble(spnMaxFiyat.EditValue);

            if (fiyatMin == 0 && fiyatMax == 0)
            {

            }
            else if (fiyatMin != 0 && fiyatMax == 0)
            {
                //minimum fiyattan büyük olanları getir
                whereQuery += " AND I.Ilan_Fiyat>"+fiyatMin;
            }
            else if (fiyatMin == 0 && fiyatMax != 0)
            {
                //maximum fiyattan küçük olanları getir
                whereQuery += " AND I.Ilan_Fiyat<" + fiyatMax;
            }
            else
            {
                // 2 fiyat arasındakileri getir
                whereQuery += " AND I.Ilan_Fiyat>" + fiyatMin +" AND I.Ilan_Fiyat<"+fiyatMax;
            } 
            #endregion

            #region Kilometre Filtresi
            double kmMin = Convert.ToDouble(spnMinKm.EditValue);
            double kmMax = Convert.ToDouble(spnMaxKm.EditValue);

            if (kmMin == 0 && kmMax == 0)
            {
                
            }
            else if (kmMin != 0 && kmMax == 0)
            {
                //minimum fiyattan büyük olanları getir
                whereQuery += " AND I.Ilan_Km>" + kmMin;
            }
            else if (kmMin == 0 && kmMax != 0)
            {
                //maximum fiyattan küçük olanları getir
                whereQuery += " AND I.Ilan_Km<" + kmMax;
            }
            else
            {
                // 2 fiyat arasındakileri getir
                whereQuery += " AND I.Ilan_Km>" + kmMin + " AND I.Ilan_Km<" + kmMax;
            } 
            #endregion



            #region Tarih Filtresi
            if (rgTarih.EditValue != null)
            {
                if (rgTarih.EditValue.ToString() == "24Saat")
                {
                    whereQuery += " AND TIMESTAMPDIFF(HOUR, I.Ilan_Tarih, NOW()) <=24";
                }
                else if (rgTarih.EditValue.ToString() == "1Hafta")
                {//168  
                    whereQuery += " AND TIMESTAMPDIFF(HOUR, I.Ilan_Tarih, NOW()) <=168";
                }
                //1 ay
                else
                {
                    whereQuery += " AND TIMESTAMPDIFF(HOUR, I.Ilan_Tarih, NOW()) <=720";
                }
            }
            #endregion

            whereQuery = whereQuery.Substring(4, whereQuery.Length - 4);

            DataTable dt = IlanManager.GetObjectsWithTable(selectQuery + whereQuery);
            dataGridView1.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IlanManager.GetObjectsWithTable();
            dataGridView1.Refresh();
        }
    }
}
