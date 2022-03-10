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
    public partial class GecikenKitaplar : Form
    {
        public GecikenKitaplar()
        {
            InitializeComponent();
        }

        readonly private Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataAdapter verial;
        DataTable tablo = new DataTable();

        private void GecikenKitaplar_Load(object sender, EventArgs e)
        {
            string tarih = (DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day).ToString();
            VT_Baglanti.VT_Baglanti();
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM EmanetBilgileri WHERE (EmanetGeriAlisTarihi < '" + tarih + "' AND EmanetTeslimEdilis = 'False')"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            GecikenKitaplar_dataGridView.DataSource = tablo;
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            Hide();
        }
    }
}
