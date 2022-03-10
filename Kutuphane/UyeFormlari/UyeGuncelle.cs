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
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
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
        SqlDataReader verioku;

        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
            Hide();
        }

        private void UyeID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }

            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM UyeBilgileri WHERE UyeID = '" + UyeID_textBox.Text + "'"
            };
            verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                UyeAdi_textBox.Text = verioku["UyeAdi"].ToString();
                UyeSoyadi_textBox.Text = verioku["UyeSoyadi"].ToString();
                UyeTelefonNo_textBox.Text = verioku["UyeTelefonNo"].ToString();
                UyeEposta_textBox.Text = verioku["UyeEposta"].ToString();
                UyeNo_textBox.Text = verioku["UyeNo"].ToString();
            }
            verioku.Close();
            VT_Baglanti.baglanti.Close();
        }

        private void Guncelle_button_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "UPDATE UyeBilgileri SET UyeAdi = @UyeAdi, UyeSoyadi = @UyeSoyadi, UyeTelefonNo = @UyeTelefonNo, UyeEposta = @UyeEposta" +
                                " WHERE UyeID = @UyeID"
            };
            //
            SqlParameter UyeID = new SqlParameter
            {
                ParameterName = "@UyeID",
                SqlDbType = SqlDbType.Int,
                Value = Convert.ToInt32(UyeID_textBox.Text)
            };
            komut.Parameters.Add(UyeID);
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
                Size = 50,
                Value = UyeTelefonNo_textBox.Text
            };
            komut.Parameters.Add(UyeTelefonNo);
            //
            SqlParameter UyeEposta = new SqlParameter
            {
                ParameterName = "@UyeEposta",
                SqlDbType = SqlDbType.NVarChar,
                Value = UyeEposta_textBox.Text
            };
            komut.Parameters.Add(UyeEposta);
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
    }
}
