namespace AracAlisSatis
{
    partial class frmIlanDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIlanDetay));
            this.txtIlanAdi = new DevExpress.XtraEditors.TextEdit();
            this.spnFiyat = new DevExpress.XtraEditors.SpinEdit();
            this.spnKilometre = new DevExpress.XtraEditors.SpinEdit();
            this.dteTarih = new DevExpress.XtraEditors.DateEdit();
            this.cmbAraba = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSehir = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlanAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnKilometre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAraba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSehir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIlanAdi
            // 
            this.txtIlanAdi.Location = new System.Drawing.Point(73, 28);
            this.txtIlanAdi.Name = "txtIlanAdi";
            this.txtIlanAdi.Size = new System.Drawing.Size(155, 20);
            this.txtIlanAdi.TabIndex = 0;
            // 
            // spnFiyat
            // 
            this.spnFiyat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnFiyat.Location = new System.Drawing.Point(73, 55);
            this.spnFiyat.Name = "spnFiyat";
            this.spnFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnFiyat.Size = new System.Drawing.Size(155, 20);
            this.spnFiyat.TabIndex = 1;
            // 
            // spnKilometre
            // 
            this.spnKilometre.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnKilometre.Location = new System.Drawing.Point(73, 81);
            this.spnKilometre.Name = "spnKilometre";
            this.spnKilometre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnKilometre.Size = new System.Drawing.Size(155, 20);
            this.spnKilometre.TabIndex = 1;
            // 
            // dteTarih
            // 
            this.dteTarih.EditValue = null;
            this.dteTarih.Location = new System.Drawing.Point(73, 108);
            this.dteTarih.Name = "dteTarih";
            this.dteTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTarih.Size = new System.Drawing.Size(155, 20);
            this.dteTarih.TabIndex = 2;
            // 
            // cmbAraba
            // 
            this.cmbAraba.Location = new System.Drawing.Point(73, 135);
            this.cmbAraba.Name = "cmbAraba";
            this.cmbAraba.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAraba.Size = new System.Drawing.Size(155, 20);
            this.cmbAraba.TabIndex = 3;
            // 
            // cmbSehir
            // 
            this.cmbSehir.Location = new System.Drawing.Point(73, 162);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSehir.Size = new System.Drawing.Size(155, 20);
            this.cmbSehir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlan Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kilometre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Araba :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şehir :";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(15, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmIlanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.cmbAraba);
            this.Controls.Add(this.dteTarih);
            this.Controls.Add(this.spnKilometre);
            this.Controls.Add(this.spnFiyat);
            this.Controls.Add(this.txtIlanAdi);
            this.Name = "frmIlanDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan Detay";
            ((System.ComponentModel.ISupportInitialize)(this.txtIlanAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnKilometre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAraba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSehir.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtIlanAdi;
        private DevExpress.XtraEditors.SpinEdit spnFiyat;
        private DevExpress.XtraEditors.SpinEdit spnKilometre;
        private DevExpress.XtraEditors.DateEdit dteTarih;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAraba;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}