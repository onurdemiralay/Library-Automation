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
    public partial class KitapEkle : Form
    {
        readonly Baglanti VT_Baglanti = new Baglanti();

        public KitapEkle()
        {
            InitializeComponent();        
        }
        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "SELECT COUNT(KitapISBN) FROM KitapBilgileri WHERE KitapISBN='" + aranan + "'";
            komut = new SqlCommand(sorgu, VT_Baglanti.baglanti);
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            VT_Baglanti.baglanti.Close();
            return sonuc;
        }

        SqlCommand komut;

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();    
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            if (VarMi(ISBN_textBox.Text) != 0)
            {
                MessageBox.Show("Bu kitap zaten kayıtlı!");
            }
            else
            {
                komut = new SqlCommand
                {
                    Connection = VT_Baglanti.baglanti,
                    CommandText = "INSERT INTO KitapBilgileri (KitapAdi, KitapYazari, KitapISBN, KitapSayfaSayisi, KitapYayinevi, KitapBasimYili, KitapAciklama)" +
                                 " VALUES (@KitapAdi, @KitapYazari, @KitapISBN, @KitapSayfaSayisi, @KitapYayinevi, @KitapBasimYili, @KitapAciklama)"
                };
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
                DialogResult durum = MessageBox.Show("Eklemek istiyor musunuz?", "Ekle", MessageBoxButtons.YesNo);
                if (durum == DialogResult.Yes)
                {
                    if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
                    {
                        VT_Baglanti.baglanti.Open();
                    }
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ekleme işlemi başarılı!");
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi iptal edildi.");
                }
            }
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            this.Hide();
        }
    }
}
