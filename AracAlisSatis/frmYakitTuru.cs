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
    public partial class frmYakitTuru : Form
    {
        public frmYakitTuru()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmYakitTuruDetay frm = new frmYakitTuruDetay();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int yakitTuruId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            YakitTuru yakitTuru = YakitTuruManager.GetObjectById(yakitTuruId);
            frmYakitTuruDetay frm = new frmYakitTuruDetay(yakitTuru);
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
                    int yakitTuruId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    YakitTuruManager.Delete(yakitTuruId);

                    MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = YakitTuruManager.GetObjects();
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmYakitTuru_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = YakitTuruManager.GetObjects();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = YakitTuruManager.GetObjects();
            dataGridView1.Refresh();
        }
    }
}
