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
    public partial class frmYakitTuruDetay : Form
    {
        YakitTuru willUpdateItem;
        public frmYakitTuruDetay()
        {
            InitializeComponent();
        }
        public frmYakitTuruDetay(YakitTuru item)
        {
            InitializeComponent();
            willUpdateItem = item;
            txtYakitTuru.Text = item.YakitTuruAdi;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (willUpdateItem != null)
                {
                    willUpdateItem.YakitTuruAdi = txtYakitTuru.Text;
                    YakitTuruManager.Update(willUpdateItem);
                }
                else
                {
                    YakitTuru yakitTuru = new YakitTuru();
                    yakitTuru.YakitTuruAdi = txtYakitTuru.Text;
                    YakitTuruManager.Insert(yakitTuru);
                }

                MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :"+ex.Message);
            }
        }
    }
}
