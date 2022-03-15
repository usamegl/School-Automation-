using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Otomasyon
{
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }

        DbOkulEntities db = new DbOkulEntities();
        
        void listele()
        {
            //2. yöntem
            var query = from item in db.TBL_VELILER
                        select new { item.VELIID, item.VELIANNE, item.VELIBABA, item.VELITEL1, item.VELITEL2, item.VELIMAIL };
            gridControl1.DataSource = query.ToList();
        }
        
        void temizle()
        {
            TxtID.Text = "";
            TxtAnneAd.Text = "";
            TxtBabaAd.Text = "";
            TxtMail.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
        }

        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
           


            /*TBL_OGRENCİLERİ KAYBETME 1.yöntem
            gridView1.Columns[6].Visible = false; **/
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_VELILER veli = new TBL_VELILER();
            veli.VELIANNE = TxtAnneAd.Text;
            veli.VELIBABA = TxtBabaAd.Text;
            veli.VELITEL1 = MskTelefon1.Text;
            veli.VELITEL2 = MskTelefon2.Text;
            veli.VELIMAIL = TxtMail.Text;
            db.TBL_VELILER.Add(veli);
            db.SaveChanges();
            listele();
            temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            TxtAnneAd.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            TxtBabaAd.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            MskTelefon1.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            MskTelefon2.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            TxtMail.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            var item = db.TBL_VELILER.Find(id);
            item.VELIANNE = TxtAnneAd.Text;
            item.VELIBABA = TxtBabaAd.Text;
            item.VELITEL1 = MskTelefon1.Text;
            item.VELITEL2 = MskTelefon2.Text;
            item.VELIMAIL = TxtMail.Text;
            db.SaveChanges();
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            var item = db.TBL_VELILER.Find(id);
            db.TBL_VELILER.Remove(item);
            db.SaveChanges();
            listele();
            temizle();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }   
    }
}
