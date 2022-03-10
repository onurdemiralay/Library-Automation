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
    public partial class KitapEmanet : Form
    {
        public KitapEmanet()
        {
            InitializeComponent();
        }

        private void Emanet_button_Click(object sender, EventArgs e)
        {
            KitapEmanetEt kitapEmanetEt = new KitapEmanetEt();
            kitapEmanetEt.Show();
            Hide();
        }

        private void Geri_button_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            Hide();
        }

        private void GeriAl_button_Click(object sender, EventArgs e)
        {
            EmanetGeriAl emanetGeriAl = new EmanetGeriAl();
            emanetGeriAl.Show();
            Hide();
        }
    }
}
