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
    public partial class frmAraba : Form
    {
        public frmAraba()
        {
            InitializeComponent();
        }

        private void frmAraba_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ArabaManager.GetObjectsWithTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmArabaDetay frm = new frmArabaDetay();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int arabaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            Araba araba = ArabaManager.GetObjectById(arabaId);
            frmArabaDetay frm = new frmArabaDetay(araba);
            frm.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek istediğiniz satırı seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result==DialogResult.Yes)
            {
                try
                {
                    int arabaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    ArabaManager.Delete(arabaId);

                    MessageBox.Show("İşleminiz başarıyla gerçekleşti","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView1.DataSource = ArabaManager.GetObjectsWithTable();
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşleminiz gerçekleştirilirken hata oluştu :"+ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ArabaManager.GetObjectsWithTable();
            dataGridView1.Refresh();
        }
    }
}
