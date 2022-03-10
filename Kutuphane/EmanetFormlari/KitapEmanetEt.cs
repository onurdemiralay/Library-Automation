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
    public partial class KitapEmanetEt : Form
    {
        public KitapEmanetEt()
        {
            InitializeComponent();
        }

        private readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataReader verioku;

        private void KitapEmanetEt_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM KitapBilgileri"
            };
            verioku = komut.ExecuteReader();
            while (verioku.Read())
            {
                string[] Adlar = new string[] { verioku["KitapAdi"].ToString() };
                Kitaplar_comboBox.Items.AddRange(Adlar);
            }
            verioku.Close();
            VT_Baglanti.baglanti.Close();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            KitapEmanet kitapEmanet = new KitapEmanet();
            kitapEmanet.Show();
            Hide();
        }

        private void Emanet_button_Click(object sender, EventArgs e)
        {
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "INSERT INTO EmanetBilgileri (KitapAdi, UyeAdi, UyeNo, EmanetVerilisTarihi, EmanetGeriAlisTarihi, EmanetTeslimEdilis) VALUES (@KitapAdi, @UyeAdi, @UyeNo, @EmanetVerilisTarihi, @EmanetGeriAlisTarihi, @EmanetTeslimEdilis)"
            };
            //
            SqlParameter KitapAdi = new SqlParameter
            {
                ParameterName = "@KitapAdi",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Kitaplar_comboBox.SelectedItem.ToString()
            };
            komut.Parameters.Add(KitapAdi);
            //
            SqlParameter UyeAdi = new SqlParameter
            {
                ParameterName = "@UyeAdi",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = Uye_label.Text
            };
            komut.Parameters.Add(UyeAdi);
            //
            SqlParameter UyeNo = new SqlParameter
            {
                ParameterName = "@UyeNo",
                SqlDbType = SqlDbType.Int,
                Value = UyeNo_textBox.Text
            };
            komut.Parameters.Add(UyeNo);
            //
            SqlParameter EmanetVerilisTarihi = new SqlParameter
            {
                ParameterName = "@EmanetVerilisTarihi",
                SqlDbType = SqlDbType.DateTime,
                Value = Verilis_dateTimePicker.Value,
            };
            komut.Parameters.Add(EmanetVerilisTarihi);
            //
            SqlParameter EmanetGeriAlisTarihi = new SqlParameter
            {
                ParameterName = "@EmanetGeriAlisTarihi",
                SqlDbType = SqlDbType.DateTime,
                Value = Alinis_dateTimePicker.Value
            };
            komut.Parameters.Add(EmanetGeriAlisTarihi);
            //
            SqlParameter EmanetTeslimEdilis = new SqlParameter
            {
                ParameterName = "@EmanetTeslimEdilis",
                SqlDbType = SqlDbType.Bit,
                Value = 0
            };
            komut.Parameters.Add(EmanetTeslimEdilis);
            //
            DialogResult durum = MessageBox.Show("Emanet Vermek istiyor musunuz?", "Emanet Ver", MessageBoxButtons.YesNo);
            if (durum == DialogResult.Yes)
            {
                if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
                {
                    VT_Baglanti.baglanti.Open();
                }
                komut.ExecuteNonQuery();
                MessageBox.Show("Emanet Verme işlemi başarılı!");
            }
            else
            {
                MessageBox.Show("Emanet Verme işlemi iptal edildi.");
            }
        }

        private void UyeNo_textBox_TextChanged(object sender, EventArgs e)
        {
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM UyeBilgileri WHERE UyeNo = '" + UyeNo_textBox.Text + "'"
            };
            verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                Uye_label.Text = verioku["UyeAdi"] + " " + verioku["UyeSoyadi"];
            }
            verioku.Close();
        }
    }
}
