﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class Form_İstatislik : Form
    {
        public Form_İstatislik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-UCTBOF1K\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");


        private void Form_İstatislik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                toplam_personel_sayisi.Text = dr1[0].ToString();
            }

            baglanti.Close();
            

            //Evli Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                evli_personel.Text = dr2[0].ToString();
            }
            baglanti.Close();


            //Bekar Personel Sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                bekar_personel.Text = dr3[0].ToString();    
            }
            baglanti.Close();


            //Şehir Sayısı
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select count(distinct(PerSehir)) From Tbl_Personel",baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                sehir_sayisi.Text = dr4[0].ToString();
            }

            baglanti.Close();


            //Toplam Maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                toplam_maas.Text = dr5[0].ToString();
            }
            baglanti.Close();


            //ORtalama Maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                ortalama_maas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
