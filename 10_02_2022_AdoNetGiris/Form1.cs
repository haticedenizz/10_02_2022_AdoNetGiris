using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_02_2022_AdoNetGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString =
            "Server=localhost;Database=KuzeyYeli;Integrated Security=true";
            /*"Server=localhost,Database=KuzeyYeli;user=sa;pwd=123";*/
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From Urunler";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader rdr= komut.ExecuteReader();
            while (rdr.Read())
            {
                string adi =rdr["UrunAdi"].ToString();
                string fiyat=rdr["Fiyat"].ToString();
                string stok = rdr["Stok"].ToString();
                listBox1.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyat, stok));
            }
            baglanti.Close();




        }
    }
}
