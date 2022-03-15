namespace Okul_Otomasyon
{
    partial class FrmNufusCuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNufusCuzdani));
            this.LblTC = new DevExpress.XtraEditors.LabelControl();
            this.LblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.LblAd = new DevExpress.XtraEditors.LabelControl();
            this.LblDogTar = new DevExpress.XtraEditors.LabelControl();
            this.LblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTC
            // 
            this.LblTC.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Appearance.Options.UseFont = true;
            this.LblTC.Location = new System.Drawing.Point(67, 164);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(157, 28);
            this.LblTC.TabIndex = 0;
            this.LblTC.Text = "labelControl1";
            // 
            // LblSoyad
            // 
            this.LblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Appearance.Options.UseFont = true;
            this.LblSoyad.Location = new System.Drawing.Point(398, 164);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(157, 28);
            this.LblSoyad.TabIndex = 1;
            this.LblSoyad.Text = "labelControl2";
            // 
            // LblAd
            // 
            this.LblAd.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Appearance.Options.UseFont = true;
            this.LblAd.Location = new System.Drawing.Point(398, 237);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(157, 28);
            this.LblAd.TabIndex = 2;
            this.LblAd.Text = "labelControl3";
            // 
            // LblDogTar
            // 
            this.LblDogTar.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogTar.Appearance.Options.UseFont = true;
            this.LblDogTar.Location = new System.Drawing.Point(398, 317);
            this.LblDogTar.Name = "LblDogTar";
            this.LblDogTar.Size = new System.Drawing.Size(157, 28);
            this.LblDogTar.TabIndex = 3;
            this.LblDogTar.Text = "labelControl4";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCinsiyet.Appearance.Options.UseFont = true;
            this.LblCinsiyet.Location = new System.Drawing.Point(666, 320);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(135, 24);
            this.LblCinsiyet.TabIndex = 4;
            this.LblCinsiyet.Text = "labelControl5";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(78, 230);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(267, 208);
            this.pictureEdit1.TabIndex = 6;
            // 
            // FrmNufusCuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 527);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblDogTar);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblTC);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmNufusCuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNufusCuzdani";
            this.Load += new System.EventHandler(this.FrmNufusCuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblTC;
        private DevExpress.XtraEditors.LabelControl LblSoyad;
        private DevExpress.XtraEditors.LabelControl LblAd;
        private DevExpress.XtraEditors.LabelControl LblDogTar;
        private DevExpress.XtraEditors.LabelControl LblCinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}