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

namespace Kutuphane
{
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }

        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataReader verioku;

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            Hide();
        }

        private void Guncelle_button_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "UPDATE KitapBilgileri SET KitapAdi = @KitapAdi, KitapYazari = @KitapYazari, KitapISBN = @KitapISBN, KitapSayfaSayisi = @KitapSayfaSayisi," +
                              "KitapYayinevi = @KitapYayinevi, KitapBasimYili = @KitapBasimYili, KitapAciklama = @KitapAciklama WHERE KitapID = @KitapID"
            };
            //
            SqlParameter KitapID = new SqlParameter
            {
                ParameterName = "@KitapID",
                SqlDbType = SqlDbType.Int,
                Value = Convert.ToInt32(KitapID_textBox.Text)
            };
            komut.Parameters.Add(KitapID);
            //
            SqlParameter KitapAdi = new SqlParameter
            {
                ParameterName = "@KitapAdi",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = KitapAdi_textBox.Text
            };
            komut.Parameters.Add(KitapAdi);
            //
            SqlParameter KitapYazari = new SqlParameter
            {
                ParameterName = "@KitapYazari",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Yazar_textBox.Text
            };
            komut.Parameters.Add(KitapYazari);
            //
            SqlParameter KitapISBN = new SqlParameter
            {
                ParameterName = "@KitapISBN",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ISBN_textBox.Text
            };
            komut.Parameters.Add(KitapISBN);
            //
            SqlParameter KitapSayfaSayisi = new SqlParameter
            {
                ParameterName = "@KitapSayfaSayisi",
                SqlDbType = SqlDbType.Int,
                Value = int.Parse(SayfaSayisi_textBox.Text)
            };
            komut.Parameters.Add(KitapSayfaSayisi);
            //
            SqlParameter KitapYayinevi = new SqlParameter
            {
                ParameterName = "@KitapYayinevi",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Yayinevi_textBox.Text
            };
            komut.Parameters.Add(KitapYayinevi);
            //
            SqlParameter KitapBasimYili = new SqlParameter
            {
                ParameterName = "@KitapBasimYili",
                SqlDbType = SqlDbType.Date,
                Value = DateTime.Parse(BasimYili_textBox.Text)
            };
            komut.Parameters.Add(KitapBasimYili);
            //
            SqlParameter KitapAciklama = new SqlParameter
            {
                ParameterName = "@KitapAciklama",
                SqlDbType = SqlDbType.NVarChar,
                Size = 200,
                Value = Aciklama_textBox.Text
            };
            komut.Parameters.Add(KitapAciklama);
            // 
            DialogResult durum = MessageBox.Show("Güncellemek istiyor musunuz?", "Güncelle", MessageBoxButtons.YesNo);
            if (durum == DialogResult.Yes)
            {
                if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
                {
                    VT_Baglanti.baglanti.Open();
                }
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı!");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi.");
            }
        }

        private void KitapID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }

            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM KitapBilgileri WHERE KitapID = '" + KitapID_textBox.Text + "'"
            };
            verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                KitapAdi_textBox.Text = verioku["KitapAdi"].ToString();
                Yazar_textBox.Text = verioku["KitapYazari"].ToString();
                ISBN_textBox.Text = verioku["KitapISBN"].ToString();
                SayfaSayisi_textBox.Text = verioku["KitapSayfaSayisi"].ToString();
                Yayinevi_textBox.Text = verioku["KitapYayinevi"].ToString();
                BasimYili_textBox.Text = verioku["KitapBasimYili"].ToString();
                Aciklama_textBox.Text = verioku["KitapAciklama"].ToString();
            }
            verioku.Close();
            VT_Baglanti.baglanti.Close();
        }
    }
}
