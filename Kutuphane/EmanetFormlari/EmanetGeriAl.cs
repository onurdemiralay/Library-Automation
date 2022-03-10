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
    public partial class EmanetGeriAl : Form
    {
        public EmanetGeriAl()
        {
            InitializeComponent();
        }

        readonly private Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter verial;
        readonly DataTable tablo = new DataTable();

        private void Geri_button_Click(object sender, EventArgs e)
        {
            KitapEmanet kitapEmanet = new KitapEmanet();
            kitapEmanet.Show();
            Hide();
        }

        private void EmanetGeriAl_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Ara_button_Click(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM EmanetBilgileri WHERE UyeNo = '" + UyeNo_textBox.Text + "'"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Emanetler_dataGridView.DataSource = tablo;
        }

        private void GeriAl_button_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(Emanetler_dataGridView.CurrentRow.Cells["EmanetID"].Value);
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "UPDATE EmanetBilgileri SET EmanetTeslimEdilis = @EmanetTeslimEdilis WHERE EmanetID = @EmanetID"
            };
            //
            SqlParameter EmanetID = new SqlParameter
            {
                ParameterName = "@EmanetID",
                SqlDbType = SqlDbType.Int,
                Value = deger
            };
            komut.Parameters.Add(EmanetID);
            //
            SqlParameter EmanetTeslimEdilis = new SqlParameter
            {
                ParameterName = "@EmanetTeslimEdilis",
                SqlDbType = SqlDbType.Bit,
                Value = 1
            };
            komut.Parameters.Add(EmanetTeslimEdilis);
            //
            DialogResult durum = MessageBox.Show("Geri alma işlemini onayla.", "Geri Al", MessageBoxButtons.YesNo);
            if (durum == DialogResult.Yes)
            {
                if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
                {
                    VT_Baglanti.baglanti.Open();
                }
                komut.ExecuteNonQuery();
                MessageBox.Show("Geri alma işlemi başarılı!");
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }
    }
}
