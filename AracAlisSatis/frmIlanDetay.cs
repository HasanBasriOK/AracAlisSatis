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
    public partial class frmIlanDetay : Form
    {
        Ilan willUpdateItem;
        List<Araba> arabaList = new List<Araba>();
        List<Sehir> sehirList = new List<Sehir>();

        public frmIlanDetay()
        {
            InitializeComponent();
            FillAraba();
            FillSehir();
        }

        public frmIlanDetay(Ilan item)
        {
            InitializeComponent();
            FillAraba();
            FillSehir();
            willUpdateItem = item;

            if (item.Ilan_ArabaID != 0)
            {
                cmbAraba.Text = arabaList.FirstOrDefault(x => x.ArabaID == item.Ilan_ArabaID).Marka;
            }

            if (item.Ilan_SehirID != 0)
            {
                cmbSehir.Text = sehirList.FirstOrDefault(x => x.SehirID == item.Ilan_SehirID).SehirAdi;
            }
            txtIlanAdi.Text = item.Ilan_Adi;
            spnFiyat.EditValue = item.Ilan_Fiyat;
            spnKilometre.EditValue = item.Ilan_Km;
            dteTarih.EditValue = item.Ilan_Tarih;
        }

        private void FillAraba()
        {
            arabaList = ArabaManager.GetObjects();
            foreach (var item in arabaList)
            {
                cmbAraba.Properties.Items.Add(item.Marka);
            }
        }

        private void FillSehir()
        {
            sehirList = SehirManager.GetObjects();
            foreach (var item in sehirList)
            {
                cmbSehir.Properties.Items.Add(item.SehirAdi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (willUpdateItem != null)
                {
                    willUpdateItem.Ilan_Adi = txtIlanAdi.Text;
                    willUpdateItem.Ilan_ArabaID = arabaList.FirstOrDefault(x => x.Marka == cmbAraba.SelectedText).ArabaID;
                    willUpdateItem.Ilan_Fiyat = (double)spnFiyat.EditValue;
                    willUpdateItem.Ilan_Km = (double)spnKilometre.EditValue;
                    willUpdateItem.Ilan_SehirID = sehirList.FirstOrDefault(x=> x.SehirAdi== cmbSehir.SelectedText).SehirID;
                    willUpdateItem.Ilan_Tarih = Convert.ToDateTime(dteTarih.EditValue);

                    IlanManager.Update(willUpdateItem);
                }
                else
                {
                    Ilan ilan = new Ilan();

                    ilan.Ilan_Adi = txtIlanAdi.Text;
                    ilan.Ilan_ArabaID = arabaList.FirstOrDefault(x => x.Marka == cmbAraba.SelectedText).ArabaID;
                    ilan.Ilan_Fiyat =Convert.ToDouble( spnFiyat.EditValue);
                    ilan.Ilan_Km = Convert.ToDouble(spnKilometre.EditValue);
                    ilan.Ilan_SehirID = sehirList.FirstOrDefault(x => x.SehirAdi == cmbSehir.SelectedText).SehirID;
                    ilan.Ilan_Tarih = Convert.ToDateTime(dteTarih.EditValue);

                    IlanManager.Insert(ilan);

                    MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem gerçekleştiriirken hata oluştu : " + ex.Message);
            }
        }
    }
}
