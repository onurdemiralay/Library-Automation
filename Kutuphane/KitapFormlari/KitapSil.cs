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
    public partial class KitapSil : Form
    {
        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataAdapter verial;
        readonly DataTable tablo = new DataTable();

        public KitapSil()
        {
            InitializeComponent();
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            Hide();
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "DELETE KitapBilgileri WHERE KitapID=@KitapID"
            };
            //
            SqlParameter KitapID = new SqlParameter
            {
                ParameterName = "@KitapID",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Value = ID_textBox.Text
            };
            komut.Parameters.Add(KitapID);
            //
            DialogResult durum = MessageBox.Show("Silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo);
            if (durum == DialogResult.Yes)
            {
                if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
                {
                    VT_Baglanti.baglanti.Open();
                }
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı!");
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void Ara_button_Click(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM KitapBilgileri WHERE KitapID = '" + ID_textBox.Text + "'"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Kitaplar_dataGridView.DataSource = tablo;
        }
    }
}
