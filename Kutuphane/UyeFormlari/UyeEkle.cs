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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        public int VarMi(string aranan)
        {
            int sonuc;
            string sorgu = "SELECT COUNT(UyeNo) FROM UyeBilgileri WHERE UyeNo = '" + aranan + "'";
            komut = new SqlCommand(sorgu, VT_Baglanti.baglanti);
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            VT_Baglanti.baglanti.Close();
            return sonuc;
        }

        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {

            if (VarMi(UyeNo_textBox.Text) != 0)
            {
                MessageBox.Show("Bu üye zaten kayıtlı!");
            }
            else
            {
                komut = new SqlCommand
                {
                    Connection = VT_Baglanti.baglanti,
                    CommandText = "INSERT INTO UyeBilgileri (UyeAdi, UyeSoyadi, UyeTelefonNo, UyeEposta, UyeNo) VALUES (@UyeAdi, @UyeSoyadi, @UyeTelefonNo, @UyeEposta, @UyeNo)"
                };
                //
                SqlParameter UyeAdi = new SqlParameter
                {
                    ParameterName = "@UyeAdi",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50,
                    Value = UyeAdi_textBox.Text
                };
                komut.Parameters.Add(UyeAdi);
                //
                SqlParameter UyeSoyadi = new SqlParameter
                {
                    ParameterName = "@UyeSoyadi",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50,
                    Value = UyeSoyadi_textBox.Text
                };
                komut.Parameters.Add(UyeSoyadi);
                //
                SqlParameter UyeTelefonNo = new SqlParameter
                {
                    ParameterName = "@UyeTelefonNo",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 11,
                    Value = UyeTelefonNo_textBox.Text
                };
                komut.Parameters.Add(UyeTelefonNo);
                //
                SqlParameter UyeEposta = new SqlParameter
                {
                    ParameterName = "@UyeEposta",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50,
                    Value = UyeEposta_textBox.Text
                };
                komut.Parameters.Add(UyeEposta);
                //
                SqlParameter UyeNo = new SqlParameter
                {
                    ParameterName = "@UyeNo",
                    SqlDbType = SqlDbType.Int,
                    Value = UyeNo_textBox.Text
                };
                komut.Parameters.Add(UyeNo);
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
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
            this.Hide();
        }
    }
}
