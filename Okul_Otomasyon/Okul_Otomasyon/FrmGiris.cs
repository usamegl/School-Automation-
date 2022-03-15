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


namespace Okul_Otomasyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        DbOkulEntities db = new DbOkulEntities(); 
        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm frm1 = new frm();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya şifre");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void BtnOgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenAnaModul frm2 = new FrmOgretmenAnaModul();
                frm2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya şifre");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }
            bgl.baglanti().Close();

        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBL_OGRAYARLAR
                        join d2 in db.TBL_OGRENCILER
                        on d1.AYARLAROGRID equals d2.OGRID
                        where d2.OGRTC == MskTC.Text &&
                        d1.OGRSIFRE == TxtSifre.Text
                        select new { };
            if(sorgu.Any())
            {
                FrmOgrenciAnaModul frm3 = new FrmOgrenciAnaModul();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı veya şifre");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }
            bgl.baglanti().Close();

        }
    }
}
