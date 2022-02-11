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

namespace _10_02_2022_AdoNetGiris
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection
        //("Server=.;Database=KuzeyYeli; Integrated Security=true");
        SqlConnection baglanti = 
        new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        private void Urunler_Load(object sender, EventArgs e)
        {
            UrunListesi();

        }

        private void UrunListesi()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select*from Urunler where Sonlandi=0", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            string urunad = txt_urunadi.Text;
            decimal fiyat = nudfiyat.Value;
            int stok = (int)nudstok.Value;
            komut.CommandText = string.Format(
            "insert into Urunler(UrunAdi,Fiyat,Stok) values('{0}',{1},{2})", urunad, fiyat, stok);

            komut.CommandText = "insert Urunler(UrunAdi,Fiyat,Stok)values(@ad,@fiyat,@stok)";
            komut.Parameters.AddWithValue("@ad", txt_urunadi.Text);
            komut.Parameters.AddWithValue("@fiyat", nudfiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudstok.Value);
            komut.Connection = baglanti;
            baglanti.Open();
            int kayit = komut.ExecuteNonQuery();

            if (kayit > 0)
            {
                MessageBox.Show("Ürün Eklendi");

            }

            else
            {
                MessageBox.Show("Ürün Eklenemedi");
            }

            baglanti.Close(); 
            UrunListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunad", txt_urunadi.Text);
            komut.Parameters.AddWithValue("@fiyat", nudfiyat.Value);
            komut.Parameters.AddWithValue("@stok", nudstok.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunListesi();
       
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                SqlCommand komut = new SqlCommand("UrunSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@urunid", dataGridView1.CurrentRow.Cells["UrunID"].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                UrunListesi();
            }
          
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            Kategori kf = new Kategori();
            kf.Show();
        }
    }
}
