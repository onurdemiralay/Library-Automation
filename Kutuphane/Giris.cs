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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        readonly Baglanti VT_Baglanti = new Baglanti();
        SqlCommand komut;
        SqlDataReader verioku;

        private void Giris_Load(object sender, EventArgs e)
        {
            VT_Baglanti.VT_Baglanti();
        }

        private void Giris_button_Click(object sender, EventArgs e)
        {
            string YetkiliNo = YetkiliNo_textBox.Text;
            string Parola = Parola_textBox.Text;
            komut = new SqlCommand
            {
                Connection = VT_Baglanti.baglanti,
                CommandText = "SELECT * FROM YetkiliBilgileri WHERE YetkiliNo='" + YetkiliNo + "' AND YetkiliParola='" + Parola + "'"
            };
            verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Yetkili no veya parola yanlış.");
            }

            this.Hide();
        }
    }
}