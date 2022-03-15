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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        DbOkulEntities db = new DbOkulEntities();
            
        //ADO.NET Öğretmen-Şifre Bilgileri
        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgretmenler", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;


        }
        //entity framework öğrenci listele
        void ogrlistele()
        {
            gridControl2.DataSource = db.AyarlarOgrenciler();

        }


        









        //ADO.NET LookUpEdit Aracı Veri getirme
        void ogretmenListesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(OGRTAD + ' ' +OGRTSOYAD) as OGRTADSOYAD,OGRTBRANS from TBL_OGRETMENLER", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEdit1.Properties.ValueMember = "OGRTID";
            lookUpEdit1.Properties.DisplayMember = "OGRTADSOYAD";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz";
            lookUpEdit1.Properties.DataSource = dt2;
        }
        void temizle()
        {
            TxtOgrtID.Text = "";
            TxtOgrID.Text = "";
            TxtBrans.Text = "";
            TxtOgrSifre.Text = "";
            TxtOgrtSifre.Text = "";
            MskOgrTC.Text = "";
            pictureEdit1.Text = "";
            pictureEdit2.Text = "";
            lookUpEdit1.Text = "";
            lookUpEdit2.Text = "";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz";
            lookUpEdit1.Properties.NullText = "Öğrenci Seçiniz";
        }

        // entity framework ile lookupedit verilerini getirme
        void ogrenciListesi()
        {
            var deger = from item in db.TBL_OGRENCILER
                        select new
                        {
                            OGRID = item.OGRID,
                            OGRADSOYAD = item.OGRAD + " " + item.OGRSOYAD,
                            OGRSINIF = item.OGRSINIF,
                        };
            lookUpEdit2.Properties.ValueMember = "OGRID";
            lookUpEdit2.Properties.DisplayMember = "OGRADSOYAD";
            lookUpEdit2.Properties.NullText = "Öğrenci Seçiniz";
            lookUpEdit2.Properties.DataSource = deger.ToList();

        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenListesi();
            ogrlistele();
            ogrenciListesi();
            temizle();

        }

        //ADO.NET ile GridControl verilerini araçlara aktarma

        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgrtSifre.Text = "";
                TxtOgrtID.Text = dr["AYARLARID"].ToString();
                lookUpEdit1.Text = dr["OGRTADSOYAD"].ToString();
                TxtBrans.Text = dr["OGRTBRANS"].ToString();
                MskOgrtTC.Text = dr["OGRTTC"].ToString();
                TxtOgrtSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);




            }
        }

        //ADO.NET ile LookUpEdit seçimi sonrası verilerin güncellenmesi
        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_OGRETMENLER where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.ItemIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                TxtOgrtID.Text = dr3["AYARLARID"].ToString();
                TxtBrans.Text = dr3["OGRTBRANS"].ToString();
                MskOgrtTC.Text = dr3["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr3["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);

            }
            bgl.baglanti().Close();



        }
        //entity framework lookupedit seçimi sonrası verilerin getirilmesi
        

        //ADO.NET Öğretmenler Şifre kaydetme
        private void BtnOgrtKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBL_AYARLAR (AYARLARID,OGRTSIFRE) values(@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtOgrtID.Text);
            komut2.Parameters.AddWithValue("@p2", TxtOgrtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }
        //ADO.NET Öğretmen Şifre Güncelle
        private void BtnOgrtGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update TBL_AYARLAR set OGRTSIFRE=@p1 where AYARLARID=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtOgrtSifre.Text);
            komut3.Parameters.AddWithValue("@p2", TxtOgrtID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void BtnOgrtTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtOgrtID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID").ToString();
            lookUpEdit2.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRADSOYAD").ToString();
            TxtOgrSinif.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSINIF").ToString();
            MskOgrTC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRTC").ToString();
            TxtOgrSifre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRSIFRE").ToString();
            string uzanti= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OGRFOTO").ToString();
            yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + uzanti;
            pictureEdit2.Image = Image.FromFile(yeniyol);

        }

        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            TxtOgrSifre.Text = "";
            using(DbOkulEntities db =new DbOkulEntities())
            {
                TBL_OGRENCILER sorgu = db.TBL_OGRENCILER.Find(lookUpEdit2.ItemIndex + 1);
                TxtOgrtID.Text = sorgu.OGRID.ToString();
                TxtOgrSinif.Text = sorgu.OGRSINIF.ToString();
                MskOgrTC.Text = sorgu.OGRTC;
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + sorgu.OGRFOTO;
                pictureEdit2.Image = Image.FromFile(yeniyol);
            }
        }

        private void BtnOgrKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRAYARLAR komut = new TBL_OGRAYARLAR();
            komut.AYARLAROGRID = Convert.ToInt32(TxtOgrtID.Text);
            komut.OGRSIFRE = TxtOgrSifre.Text;
            db.TBL_OGRAYARLAR.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
        }

        private void BtnOgrGuncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AYARLAROGRID"));
            var item = db.TBL_OGRAYARLAR.FirstOrDefault(x => x.AYARLAROGRID == id);
            item.OGRSIFRE = TxtOgrSifre.Text;
            MessageBox.Show("Öğrenci Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrlistele();
            db.SaveChanges();
            ogrlistele();
            temizle();
        }

        private void BtnOgrTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}


