namespace AracAlisSatis
{
    partial class frmIlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIlan));
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.rgTarih = new DevExpress.XtraEditors.RadioGroup();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spnMaxKm = new DevExpress.XtraEditors.SpinEdit();
            this.spnMinKm = new DevExpress.XtraEditors.SpinEdit();
            this.spnMaxFiyat = new DevExpress.XtraEditors.SpinEdit();
            this.spnMinFiyat = new DevExpress.XtraEditors.SpinEdit();
            this.cmbRenk = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbVitesTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbYakitTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSehir = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRenk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVitesTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYakitTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSehir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(254, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(128, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 31);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(6, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(291, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.btnFilter);
            this.groupControl1.Controls.Add(this.rgTarih);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.spnMaxKm);
            this.groupControl1.Controls.Add(this.spnMinKm);
            this.groupControl1.Controls.Add(this.spnMaxFiyat);
            this.groupControl1.Controls.Add(this.spnMinFiyat);
            this.groupControl1.Controls.Add(this.cmbRenk);
            this.groupControl1.Controls.Add(this.cmbVitesTuru);
            this.groupControl1.Controls.Add(this.cmbYakitTuru);
            this.groupControl1.Controls.Add(this.cmbSehir);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 444);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Filtre";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(111, 32);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(162, 20);
            this.txtMarka.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(15, 338);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(258, 46);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // rgTarih
            // 
            this.rgTarih.Location = new System.Drawing.Point(15, 244);
            this.rgTarih.Name = "rgTarih";
            this.rgTarih.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("24Saat", "Son 24 Saat"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1Hafta", "Son 1 Hafta"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1Ay", "Son 1 Ay")});
            this.rgTarih.Size = new System.Drawing.Size(258, 33);
            this.rgTarih.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "--";
            // 
            // spnMaxKm
            // 
            this.spnMaxKm.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMaxKm.Location = new System.Drawing.Point(216, 172);
            this.spnMaxKm.Name = "spnMaxKm";
            this.spnMaxKm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaxKm.Properties.Mask.EditMask = "n0";
            this.spnMaxKm.Size = new System.Drawing.Size(57, 20);
            this.spnMaxKm.TabIndex = 2;
            // 
            // spnMinKm
            // 
            this.spnMinKm.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMinKm.Location = new System.Drawing.Point(111, 172);
            this.spnMinKm.Name = "spnMinKm";
            this.spnMinKm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMinKm.Properties.Mask.EditMask = "n0";
            this.spnMinKm.Size = new System.Drawing.Size(57, 20);
            this.spnMinKm.TabIndex = 2;
            // 
            // spnMaxFiyat
            // 
            this.spnMaxFiyat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMaxFiyat.Location = new System.Drawing.Point(216, 96);
            this.spnMaxFiyat.Name = "spnMaxFiyat";
            this.spnMaxFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaxFiyat.Properties.Mask.EditMask = "n0";
            this.spnMaxFiyat.Size = new System.Drawing.Size(57, 20);
            this.spnMaxFiyat.TabIndex = 2;
            // 
            // spnMinFiyat
            // 
            this.spnMinFiyat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnMinFiyat.Location = new System.Drawing.Point(111, 96);
            this.spnMinFiyat.Name = "spnMinFiyat";
            this.spnMinFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMinFiyat.Properties.Mask.EditMask = "n0";
            this.spnMinFiyat.Size = new System.Drawing.Size(57, 20);
            this.spnMinFiyat.TabIndex = 2;
            // 
            // cmbRenk
            // 
            this.cmbRenk.EditValue = "";
            this.cmbRenk.Location = new System.Drawing.Point(111, 199);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRenk.Properties.NullText = "<Seçiniz>";
            this.cmbRenk.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbRenk.Size = new System.Drawing.Size(162, 20);
            this.cmbRenk.TabIndex = 1;
            // 
            // cmbVitesTuru
            // 
            this.cmbVitesTuru.EditValue = "";
            this.cmbVitesTuru.Location = new System.Drawing.Point(111, 146);
            this.cmbVitesTuru.Name = "cmbVitesTuru";
            this.cmbVitesTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVitesTuru.Properties.NullText = "<Seçiniz>";
            this.cmbVitesTuru.Size = new System.Drawing.Size(162, 20);
            this.cmbVitesTuru.TabIndex = 1;
            // 
            // cmbYakitTuru
            // 
            this.cmbYakitTuru.EditValue = "";
            this.cmbYakitTuru.Location = new System.Drawing.Point(111, 122);
            this.cmbYakitTuru.Name = "cmbYakitTuru";
            this.cmbYakitTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYakitTuru.Properties.NullText = "<Seçiniz>";
            this.cmbYakitTuru.Size = new System.Drawing.Size(162, 20);
            this.cmbYakitTuru.TabIndex = 1;
            // 
            // cmbSehir
            // 
            this.cmbSehir.EditValue = "";
            this.cmbSehir.Location = new System.Drawing.Point(111, 65);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSehir.Properties.NullText = "<Seçiniz>";
            this.cmbSehir.Size = new System.Drawing.Size(162, 20);
            this.cmbSehir.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araç İlan Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Km Aralığı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vites Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat Aralığı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(291, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(599, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(376, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 31);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmIlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmIlan";
            this.Text = "İlan";
            this.Load += new System.EventHandler(this.frmIlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRenk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVitesTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYakitTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSehir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSehir;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SpinEdit spnMaxFiyat;
        private DevExpress.XtraEditors.SpinEdit spnMinFiyat;
        private DevExpress.XtraEditors.RadioGroup rgTarih;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SpinEdit spnMaxKm;
        private DevExpress.XtraEditors.SpinEdit spnMinKm;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRenk;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVitesTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYakitTuru;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}