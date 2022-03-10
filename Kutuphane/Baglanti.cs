using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane
{
    class Baglanti
    {
        public SqlConnectionStringBuilder ayarlar;
        public SqlConnection baglanti;
        public void VT_Baglanti()
        {
            ayarlar = new SqlConnectionStringBuilder
            {
                DataSource = @"ONUR-PC",
                InitialCatalog = "Kutuphane",
                IntegratedSecurity = true
            };
            baglanti = new SqlConnection(ayarlar.ConnectionString);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
    }
}
