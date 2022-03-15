﻿using System;
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
    public partial class FrmNufusCuzdani : Form
    {
        public FrmNufusCuzdani()
        {
            InitializeComponent();
        }

        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void FrmNufusCuzdani_Load(object sender, EventArgs e)
        {
            LblAd.Text = ad;
            LblSoyad.Text = soyad;
            LblTC.Text = tc;
            LblDogTar.Text = dogtarihi;
            LblCinsiyet.Text = cinsiyet;
            pictureEdit1.Image = Image.FromFile(uzanti);
        }
    }
}
