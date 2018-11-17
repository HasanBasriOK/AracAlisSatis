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
    public partial class frmRenkDetay : Form
    {
        Renk willUpdateItem;

        public frmRenkDetay()
        {
            InitializeComponent();
        }

        public frmRenkDetay(Renk item)
        {
            InitializeComponent();
            willUpdateItem = item;
            txtRenkAdi.Text = item.RenkAdi;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (willUpdateItem!=null)
                {
                    willUpdateItem.RenkAdi = txtRenkAdi.Text;
                    RenkManager.Update(willUpdateItem);
                }
                else
                {
                    Renk renk = new Renk();
                    renk.RenkAdi = txtRenkAdi.Text;
                    RenkManager.Insert(renk);
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
