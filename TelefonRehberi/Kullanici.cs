using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =
        new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand
          ("select COUNT(*) from Kullanici where KullaniciAdi =@ad and Sifre =@sifre", baglanti);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            baglanti.Open();
            int kayit = komut.ExecuteNonQuery();
            baglanti.Close();

            if (kayit < 0)
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bağlantı");
            }
           

        }
    }
}
