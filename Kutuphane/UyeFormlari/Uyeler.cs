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
    public partial class Uyeler : Form
    {
        public Uyeler()
        {
            InitializeComponent();
        }
        
        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataAdapter verial;
        readonly DataTable tablo = new DataTable();

        private void Uyeler_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM UyeBilgileri"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Uye_dataGridView.DataSource = tablo;
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }

        private void Guncelle_button_Click(object sender, EventArgs e)
        {
            UyeGuncelle uyeGuncelle = new UyeGuncelle();
            uyeGuncelle.Show();
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            UyeSil uyeSil = new UyeSil();
            uyeSil.Show();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
