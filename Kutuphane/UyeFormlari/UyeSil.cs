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
    public partial class UyeSil : Form
    {
        public UyeSil()
        {
            InitializeComponent();
        }

        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataAdapter verial;
        readonly DataTable tablo = new DataTable();


        private void UyeSil_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Ara_button_Click(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM UyeBilgileri WHERE UyeID = '" + UyeID_textBox.Text + "'"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Kitaplar_dataGridView.DataSource = tablo;

        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "DELETE UyeBilgileri WHERE UyeID=@UyeID"
            };
            //
            SqlParameter UyeID = new SqlParameter
            {
                ParameterName = "@UyeID",
                SqlDbType = SqlDbType.Int,
                Value = UyeID_textBox.Text
            };
            komut.Parameters.Add(UyeID);
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

        private void Geri_button_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
            Hide();
        }
    }
}
