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
    public partial class frmArabaDetay : Form
    {
        Araba willUpdateItem;
        List<Renk> renkList = new List<Renk>();
        List<VitesTuru> vitesTuruList = new List<VitesTuru>();
        List<YakitTuru> yakitTuruList = new List<YakitTuru>();
        public frmArabaDetay()
        {
            InitializeComponent();
            FillRenk();
            FillVitesTuru();
            FillYakitTuru();
        }

        public frmArabaDetay(Araba item)
        {
            InitializeComponent();
            willUpdateItem = item;
            FillRenk();
            FillVitesTuru();
            FillYakitTuru();

            if(item.RenkID!=0)
            {
                cmbRenk.Text = renkList.FirstOrDefault(x => x.RenkID == item.RenkID).RenkAdi;
            }
           
            if (item.YakitTuruID!=0)
            {
                cmbYakitTuru.Text= yakitTuruList.FirstOrDefault(x => x.YakitTuruID == item.YakitTuruID).YakitTuruAdi;
            }

            if (item.VitesTuruID!=0)
            {
                cmbVitesTuru.Text = vitesTuruList.FirstOrDefault(x => x.VitesTuruID == item.VitesTuruID).VitesTuruAdi;
            }

            txtMarka.Text = item.Marka;
            txtModel.Text = item.Model;
        }

        private void FillRenk()
        {
            renkList = RenkManager.GetObjects();
            foreach (var item in renkList)
            {
                cmbRenk.Properties.Items.Add(item.RenkAdi);
            }
        }

        private void FillYakitTuru()
        {
            yakitTuruList = YakitTuruManager.GetObjects();
            foreach (var item in yakitTuruList)
            {
                cmbYakitTuru.Properties.Items.Add(item.YakitTuruAdi);
            }
        }

        private void FillVitesTuru()
        {
            vitesTuruList = VitesTuruManager.GetObjects();
            foreach (var item in vitesTuruList)
            {
                cmbVitesTuru.Properties.Items.Add(item.VitesTuruAdi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (willUpdateItem != null)
                {
                    willUpdateItem.Marka = txtMarka.Text;
                    willUpdateItem.Model = txtModel.Text;
                    willUpdateItem.RenkID = renkList.FirstOrDefault(x=> x.RenkAdi== cmbRenk.Text).RenkID;
                    willUpdateItem.VitesTuruID = vitesTuruList.FirstOrDefault(x=> x.VitesTuruAdi== cmbVitesTuru.Text).VitesTuruID;
                    willUpdateItem.YakitTuruID = yakitTuruList.FirstOrDefault(x=> x.YakitTuruAdi== cmbYakitTuru.Text).YakitTuruID;

                    ArabaManager.Update(willUpdateItem);
                }
                else
                {
                    Araba araba = new Araba();

                    araba.Marka = txtMarka.Text;
                    araba.Model = txtModel.Text;
                    araba.RenkID = renkList.FirstOrDefault(x => x.RenkAdi == cmbRenk.Text).RenkID;
                    araba.VitesTuruID = vitesTuruList.FirstOrDefault(x => x.VitesTuruAdi == cmbVitesTuru.Text).VitesTuruID;
                    araba.YakitTuruID = yakitTuruList.FirstOrDefault(x => x.YakitTuruAdi == cmbYakitTuru.Text).YakitTuruID;

                    ArabaManager.Insert(araba);
                }

                MessageBox.Show("İşleminiz başarıyla gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem gerçekleştirilirken bir hata oluştu :"+ex.Message);
            }
        }
    }
}
