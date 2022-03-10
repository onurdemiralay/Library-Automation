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
    public partial class EmanetEdilenKitaplar : Form
    {
        public EmanetEdilenKitaplar()
        {
            InitializeComponent();
        }

        readonly private Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataAdapter verial;
        readonly DataTable tablo = new DataTable();

        private void Geri_button_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            Hide();
        }

        private void EmanetEdilenKitaplar_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
            if (VT_Baglanti.baglanti.State == ConnectionState.Closed)
            {
                VT_Baglanti.baglanti.Open();
            }
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM EmanetBilgileri"
            };
            verial = new SqlDataAdapter(komut);
            verial.Fill(tablo);
            Emanet_dataGridView.DataSource = tablo;
        }
    }
}
