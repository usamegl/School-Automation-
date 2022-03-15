namespace Okul_Otomasyon
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.MskTC = new DevExpress.XtraEditors.TextEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnYonetici = new System.Windows.Forms.Button();
            this.BtnOgretmen = new System.Windows.Forms.Button();
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MskTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(77, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(161, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(779, 67);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ELAZIĞ ORTAOKULU GİRİŞ PANELİ";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(308, 573);
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(138, 22);
            this.MskTC.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(684, 573);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(125, 22);
            this.TxtSifre.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(149, 559);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 38);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kullanıcı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(589, 559);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 37);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sifre:";
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnYonetici.BackgroundImage")));
            this.BtnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnYonetici.Location = new System.Drawing.Point(220, 617);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Size = new System.Drawing.Size(192, 154);
            this.BtnYonetici.TabIndex = 5;
            this.BtnYonetici.UseVisualStyleBackColor = true;
            this.BtnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // BtnOgretmen
            // 
            this.BtnOgretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgretmen.BackgroundImage")));
            this.BtnOgretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgretmen.Location = new System.Drawing.Point(427, 617);
            this.BtnOgretmen.Name = "BtnOgretmen";
            this.BtnOgretmen.Size = new System.Drawing.Size(199, 154);
            this.BtnOgretmen.TabIndex = 6;
            this.BtnOgretmen.UseVisualStyleBackColor = true;
            this.BtnOgretmen.Click += new System.EventHandler(this.BtnOgretmen_Click);
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgrenci.BackgroundImage")));
            this.BtnOgrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgrenci.Location = new System.Drawing.Point(658, 617);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(186, 154);
            this.BtnOgrenci.TabIndex = 7;
            this.BtnOgrenci.UseVisualStyleBackColor = true;
            this.BtnOgrenci.Click += new System.EventHandler(this.BtnOgrenci_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 794);
            this.Controls.Add(this.BtnOgrenci);
            this.Controls.Add(this.BtnOgretmen);
            this.Controls.Add(this.BtnYonetici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MskTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit MskTC;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button BtnYonetici;
        private System.Windows.Forms.Button BtnOgretmen;
        private System.Windows.Forms.Button BtnOgrenci;
    }
}