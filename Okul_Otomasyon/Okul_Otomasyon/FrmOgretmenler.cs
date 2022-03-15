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
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_OGRETMENLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
          

        }
        void ilkekle()
        {
            SqlCommand komut = new SqlCommand("Select* from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbİl.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

        }

        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("Select* from TBL_BRANSLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();


        }
        void temizle()
        {
            TxtID.Text = ""; 
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTC.Text = "";
            MskTelefon.Text = "";
            Cmbİl.Text = "";
            Cmbİlce.Text = "";
            CmbBrans.Text = "";
            TxtMail.Text = "";
            RchAdres.Text = "";
            PcrResim.ImageLocation = "";

        }



        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilkekle();
            bransgetir();

           

        }

        private void Cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbİlce.Properties.Items.Clear();
            Cmbİlce.Text = ""; 
            
            SqlCommand komut = new SqlCommand("Select * from TBL_ILCELER where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbİl.SelectedIndex+1  );
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Cmbİlce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMENLER (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p7", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                TxtID.Text = dr["OGRTID"].ToString();
                TxtAd.Text = dr["OGRTAD"].ToString();
                TxtSoyad.Text = dr["OGRTSOYAD"].ToString();
                MskTC.Text = dr["OGRTTC"].ToString();
                MskTelefon.Text = dr["OGRTTEL"].ToString();
                Cmbİl.Text = dr["OGRTIL"].ToString();
                Cmbİlce.Text = dr["OGRTILCE"].ToString();
                CmbBrans.Text = dr["OGRTBRANS"].ToString();
                TxtMail.Text = dr["OGRTMAIL"].ToString();
                RchAdres.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                PcrResim.ImageLocation = yeniyol;
            }
        }
        public string yeniyol;

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim dosyası |*.jpg;*.png;*.nef | Tüm Dosyalar | *.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\USAME\\Desktop\\C# Otomasyon\\Okul_Otomasyon\\Okul_Otomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu,yeniyol);
            PcrResim.ImageLocation = yeniyol;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  TBL_OGRETMENLER set OGRTAD=@p1,OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAIL=@p5,OGRTIL=@p6,OGRTILCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10  where OGRTID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p7", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_OGRETMENLER where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
