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
    public partial class frmVitesTuruDetay : Form
    {
        VitesTuru willUpdateItem;

        public frmVitesTuruDetay()
        {
            InitializeComponent();
        }

        public frmVitesTuruDetay(VitesTuru item)
        {
            InitializeComponent();
            willUpdateItem = item;
            txtVitesTuru.Text = item.VitesTuruAdi;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (willUpdateItem != null)
                {
                    willUpdateItem.VitesTuruAdi = txtVitesTuru.Text;
                    VitesTuruManager.Update(willUpdateItem);
                }
                else
                {
                    VitesTuru vitesTuru = new VitesTuru();
                    vitesTuru.VitesTuruAdi = txtVitesTuru.Text;
                    VitesTuruManager.Insert(vitesTuru);
                }

                MessageBox.Show("İşleminiz başarıyla gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :"+ex.Message);
            }
        }
    }
}
