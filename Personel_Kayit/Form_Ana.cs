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

namespace Personel_Kayit
{
    public partial class Form_Ana : Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection ("Data Source=LAPTOP-UCTBOF1K\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        void temizle()
        {
            Txt_id.Text = "";
            Txt_ad.Text = "";
            Txt_Meslek.Text = "";
            Cmb_Sehir.Text = "";
            Txt_soyad.Text = "";
            Msk_Maas.Text = "";
            Rb_Evli.Checked = false;
            Rb_Bekar.Checked = false;
            Txt_ad.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabaniDataSet3.Tbl_Personel);

        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabaniDataSet3.Tbl_Personel);
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", Txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", Cmb_Sehir.Text);
            komut.Parameters.AddWithValue("@p4", Msk_Maas.Text);
            komut.Parameters.AddWithValue("@p5",Txt_Meslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void Rb_Evli_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Evli.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void Rb_Bekar_CheckedChanged(object sender, EventArgs e)
        {

            if (Rb_Bekar.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmb_Sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Msk_Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Txt_Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                Rb_Evli.Checked = true;
            }
            if (label8.Text == "False")
            {
                Rb_Bekar.Checked = true;
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutSil.Parameters.AddWithValue("@k1",Txt_id.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 Where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", Txt_ad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Txt_soyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Cmb_Sehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4",Msk_Maas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", Txt_Meslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txt_id.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgi Güncellendi...");
        }

        private void Btn_İstatislik_Click(object sender, EventArgs e)
        {
            Form_İstatislik fr = new Form_İstatislik();
            fr.Show();
        }

        private void Btn_Grafik_Click(object sender, EventArgs e)
        {
            Form_Grafikler frg = new Form_Grafikler();
            frg.Show();
            
        }
    }
}
