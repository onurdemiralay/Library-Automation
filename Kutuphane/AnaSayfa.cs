using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Kitaplar_button_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();
            Hide();
        }

        private void Uyeler_button_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();
            uyeler.Show();
            Hide();
        }

        private void KitapEmanet_button_Click(object sender, EventArgs e)
        {
            KitapEmanet kitapEmanet = new KitapEmanet();
            kitapEmanet.Show();
            Hide();
        }

        private void EmanetEdilenler_button_Click(object sender, EventArgs e)
        {
            EmanetEdilenKitaplar emanetEdilenKitaplar = new EmanetEdilenKitaplar();
            emanetEdilenKitaplar.Show();
            Hide();
        }

        private void Geciken_button_Click(object sender, EventArgs e)
        {
            GecikenKitaplar gecikenKitaplar = new GecikenKitaplar();
            gecikenKitaplar.Show();
            Hide();
        }
    }
}
