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
    public partial class frmSehirDetay : Form
    {
        Sehir willUpdateItem;

        //ekle
        public frmSehirDetay()
        {
            InitializeComponent();
        }

        //düzenle
        public frmSehirDetay(Sehir item)
        {
            InitializeComponent();
            willUpdateItem = item;
            txtSehirAdi.Text = item.SehirAdi;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Düzenlenecek
                if (willUpdateItem != null)
                {
                    willUpdateItem.SehirAdi = txtSehirAdi.Text;
                    SehirManager.Update(willUpdateItem);
                }
                //Yeni eklenecek
                else
                {
                    Sehir sehir = new Sehir();
                    sehir.SehirAdi = txtSehirAdi.Text;
                    SehirManager.Insert(sehir);
                }
                MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :" + ex.Message);
            }
           
        }
    }
}
