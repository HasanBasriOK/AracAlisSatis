namespace AracAlisSatis
{
    partial class frmArabaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArabaDetay));
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.cmbVitesTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbYakitTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbRenk = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVitesTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYakitTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRenk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(90, 25);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(158, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(90, 51);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(158, 20);
            this.txtModel.TabIndex = 0;
            // 
            // cmbVitesTuru
            // 
            this.cmbVitesTuru.Location = new System.Drawing.Point(90, 78);
            this.cmbVitesTuru.Name = "cmbVitesTuru";
            this.cmbVitesTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVitesTuru.Size = new System.Drawing.Size(158, 20);
            this.cmbVitesTuru.TabIndex = 1;
            // 
            // cmbYakitTuru
            // 
            this.cmbYakitTuru.Location = new System.Drawing.Point(90, 105);
            this.cmbYakitTuru.Name = "cmbYakitTuru";
            this.cmbYakitTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYakitTuru.Size = new System.Drawing.Size(158, 20);
            this.cmbYakitTuru.TabIndex = 2;
            // 
            // cmbRenk
            // 
            this.cmbRenk.Location = new System.Drawing.Point(90, 132);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRenk.Size = new System.Drawing.Size(158, 20);
            this.cmbRenk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vites Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yakıt Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Renk :";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(29, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmArabaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.cmbYakitTuru);
            this.Controls.Add(this.cmbVitesTuru);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "frmArabaDetay";
            this.Text = "Araba Detay";
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVitesTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYakitTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRenk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVitesTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYakitTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRenk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}