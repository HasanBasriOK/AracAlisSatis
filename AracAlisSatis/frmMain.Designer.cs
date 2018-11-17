namespace AracAlisSatis
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTanimlamalar = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAraba = new DevExpress.XtraBars.BarButtonItem();
            this.btnRenk = new DevExpress.XtraBars.BarButtonItem();
            this.btnIlan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSehir = new DevExpress.XtraBars.BarButtonItem();
            this.btnVitesTuru = new DevExpress.XtraBars.BarButtonItem();
            this.btnYakitTuru = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTanimlamalar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(599, 82);
            this.panelControl1.TabIndex = 1;
            // 
            // btnTanimlamalar
            // 
            this.btnTanimlamalar.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnTanimlamalar.DropDownControl = this.popupMenu1;
            this.btnTanimlamalar.Image = ((System.Drawing.Image)(resources.GetObject("btnTanimlamalar.Image")));
            this.btnTanimlamalar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTanimlamalar.Location = new System.Drawing.Point(5, 5);
            this.btnTanimlamalar.Name = "btnTanimlamalar";
            this.btnTanimlamalar.Size = new System.Drawing.Size(80, 65);
            this.btnTanimlamalar.TabIndex = 1;
            this.btnTanimlamalar.Text = "Menü";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAraba, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRenk),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIlan),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSehir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVitesTuru),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYakitTuru)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnAraba
            // 
            this.btnAraba.Caption = "Araba";
            this.btnAraba.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAraba.Glyph")));
            this.btnAraba.Id = 0;
            this.btnAraba.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAraba.LargeGlyph")));
            this.btnAraba.Name = "btnAraba";
            this.btnAraba.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAraba_ItemClick);
            // 
            // btnRenk
            // 
            this.btnRenk.Caption = "Renk";
            this.btnRenk.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRenk.Glyph")));
            this.btnRenk.Id = 1;
            this.btnRenk.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRenk.LargeGlyph")));
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRenk_ItemClick);
            // 
            // btnIlan
            // 
            this.btnIlan.Caption = "İlan";
            this.btnIlan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIlan.Glyph")));
            this.btnIlan.Id = 2;
            this.btnIlan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIlan.LargeGlyph")));
            this.btnIlan.Name = "btnIlan";
            this.btnIlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIlan_ItemClick);
            // 
            // btnSehir
            // 
            this.btnSehir.Caption = "Şehir";
            this.btnSehir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSehir.Glyph")));
            this.btnSehir.Id = 3;
            this.btnSehir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSehir.LargeGlyph")));
            this.btnSehir.Name = "btnSehir";
            this.btnSehir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSehir_ItemClick);
            // 
            // btnVitesTuru
            // 
            this.btnVitesTuru.Caption = "Vites Türü";
            this.btnVitesTuru.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVitesTuru.Glyph")));
            this.btnVitesTuru.Id = 4;
            this.btnVitesTuru.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVitesTuru.LargeGlyph")));
            this.btnVitesTuru.Name = "btnVitesTuru";
            this.btnVitesTuru.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVitesTuru_ItemClick);
            // 
            // btnYakitTuru
            // 
            this.btnYakitTuru.Caption = "Yakıt Türü";
            this.btnYakitTuru.Glyph = ((System.Drawing.Image)(resources.GetObject("btnYakitTuru.Glyph")));
            this.btnYakitTuru.Id = 5;
            this.btnYakitTuru.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnYakitTuru.LargeGlyph")));
            this.btnYakitTuru.Name = "btnYakitTuru";
            this.btnYakitTuru.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYakitTuru_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAraba,
            this.btnRenk,
            this.btnIlan,
            this.btnSehir,
            this.btnVitesTuru,
            this.btnYakitTuru});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(599, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 375);
            this.barDockControlBottom.Size = new System.Drawing.Size(599, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(599, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 375);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Araç Alış Satış";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DropDownButton btnTanimlamalar;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnAraba;
        private DevExpress.XtraBars.BarButtonItem btnRenk;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnIlan;
        private DevExpress.XtraBars.BarButtonItem btnSehir;
        private DevExpress.XtraBars.BarButtonItem btnVitesTuru;
        private DevExpress.XtraBars.BarButtonItem btnYakitTuru;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
    }
}