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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAraba_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmAraba)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmAraba frm = new frmAraba();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRenk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmRenk)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmRenk frm = new frmRenk();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnIlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmIlan)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmIlan frm = new frmIlan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSehir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmSehir)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmSehir frm = new frmSehir();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVitesTuru_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmVitesTuru)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmVitesTuru frm = new frmVitesTuru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYakitTuru_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmYakitTuru)
                {
                    openForm.Activate();
                    return;
                }
            }
            frmYakitTuru frm = new frmYakitTuru();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
