using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Okul_Otomasyon
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //5.SINIF
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='5.SINIF'",bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

            //6.SINIF
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='6.SINIF'", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            //7.SINIF
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='7.SINIF'", bgl.baglanti());
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;

            //8.SINIF
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='8.SINIF'", bgl.baglanti());
            da4.Fill(dt4);
            gridControl4.DataSource = dt4;
            
        }

        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select VELIID,(VELIANNE+ '  | '+VELIBABA) as VELIANNEBABA from TBL_VELILER ", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "VELIID";
            lookUpEdit1.Properties.DisplayMember = "VELI ANNE BABA";
            lookUpEdit1.Properties.DataSource = dt;



        }
            void sehirekle()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbİl.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskOgrenciNo.Text = "";
            MskTC.Text = "";
            RdBtnErkek.Checked = false;
            RdBtnBayan.Checked = false;
            CmbSinif.Text = "";
            Cmbİl.Text = "";
            dateEdit1.Text = "";
            Cmbİlce.Text = "";
            RchAdres.Text = "";
            pictureEdit1.Text = "";
        }

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            sehirekle();
            temizle();
            velilistesi();

        }

        private void Cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cmbİlce.Properties.Items.Clear();
            Cmbİlce.Text = "";


            SqlCommand komut = new SqlCommand("Select* from TBL_ILCELER where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbİl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Cmbİlce.Properties.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString()=="E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdBtnBayan.Checked = true;
                }
                Cmbİl.Text = dr["OGRIL"].ToString();
                Cmbİlce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdBtnBayan.Checked = true;
                }
                Cmbİl.Text = dr["OGRIL"].ToString();
                Cmbİlce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }


        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdBtnBayan.Checked = true;
                }
                Cmbİl.Text = dr["OGRIL"].ToString();
                Cmbİlce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }

        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["OGRID"].ToString();
                TxtAd.Text = dr["OGRAD"].ToString();
                TxtSoyad.Text = dr["OGRSOYAD"].ToString();
                MskTC.Text = dr["OGRTC"].ToString();
                MskOgrenciNo.Text = dr["OGRNO"].ToString();
                CmbSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    RdBtnErkek.Checked = true;
                }
                else
                {
                    RdBtnBayan.Checked = true;
                }
                Cmbİl.Text = dr["OGRIL"].ToString();
                Cmbİlce.Text = dr["OGRILCE"].ToString();
                dateEdit1.Text = dr["OGRDOGTAR"].ToString();
                RchAdres.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }
        public string cinsiyet;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRENCILER(OGRAD,OGRSOYAD,OGRNO,OGRSINIF,OGRDOGTAR,OGRCINSIYET,OGRTC,OGRIL,OGRILCE,OGRADRES,OGRFOTO)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", CmbSinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6",cinsiyet="E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet="B");
            }
            komut.Parameters.AddWithValue("@p7", MskTC.Text);
            komut.Parameters.AddWithValue("@p8", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p9", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p10", RchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();

        }
        public string yeniyol;

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter="Resim Dosyası |*.jpg;*.png;*.nef| Tüm Dosyalar|*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image = Image.FromFile(yeniyol);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCILER set OGRAD=@p1,OGRSOYAD=@p2,OGRNO=@p3,OGRSINIF=@p4,OGRDOGTAR=@p5,OGRCINSIYET=@p6,OGRTC=@p7,OGRIL=@p8,OGRILCE=@p9,OGRADRES=@p10,OGRFOTO=@p11 where OGRID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", CmbSinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEdit1.Text);
            if (RdBtnErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }
            komut.Parameters.AddWithValue("@p7", MskTC.Text);
            komut.Parameters.AddWithValue("@p8", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p9", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p10", RchAdres.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRENCILER where OGRID=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufusCuzdani frmczdn = new FrmNufusCuzdani();
            if (dr!=null)
            {
                frmczdn.ad = dr["OGRAD"].ToString();
                frmczdn.soyad = dr["OGRSOYAD"].ToString();
                frmczdn.tc = dr["OGRTC"].ToString();
                frmczdn.cinsiyet = dr["OGRCINSIYET"].ToString();
                frmczdn.dogtarihi = dr["OGRDOGTAR"].ToString();
                frmczdn.uzanti= "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();

            }
            frmczdn.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            FrmNufusCuzdani frmczdn = new FrmNufusCuzdani();
            if (dr != null)
            {
                frmczdn.ad = dr["OGRAD"].ToString();
                frmczdn.soyad = dr["OGRSOYAD"].ToString();
                frmczdn.tc = dr["OGRTC"].ToString();
                frmczdn.cinsiyet = dr["OGRCINSIYET"].ToString();
                frmczdn.dogtarihi = dr["OGRDOGTAR"].ToString();
                frmczdn.uzanti = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRFOTO"].ToString();

            }
            frmczdn.Show();

        }
    }
}
