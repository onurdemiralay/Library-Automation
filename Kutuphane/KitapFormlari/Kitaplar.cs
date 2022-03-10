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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        readonly DataTable tablo = new DataTable();
        SqlDataAdapter verial;

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM KitapBilgileri"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Kitaplar_dataGridView.DataSource = tablo;
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Hide();
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            KitapSil kitapSil = new KitapSil();
            kitapSil.Show();
        }

        private void Guncelle_button_Click(object sender, EventArgs e)
        {
            KitapGuncelle kitapGuncelle = new KitapGuncelle();
            kitapGuncelle.Show();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
