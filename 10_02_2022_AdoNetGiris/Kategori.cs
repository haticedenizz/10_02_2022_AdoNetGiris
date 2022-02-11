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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection
        ("Server=.;Database=KuzeyYeli; Integrated Security=true");
        private void Kategori_Load(object sender, EventArgs e)
        {
            Kategorilistesi();

        }

        private void Kategorilistesi()
        {
            //Disconnected Mimari---
            SqlDataAdapter adp = new SqlDataAdapter("select*from Kategoriler", baglanti);

            DataTable dt = new DataTable();
            adp.Fill(dt);//fill veri doldurma
            dgwkategori.DataSource = dt;
            dgwkategori.Columns["KategoriID"].Visible = false;
        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format(
            "insert into Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')", txt_kategoriadi.Text
            , txt_tanimi.Text);
            komut.Connection = baglanti;
            baglanti.Open();
            int sonuc;
            try
            {
                sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Basarılı Bir Sekilde Eklendi");
                
                else
                    MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }

            Kategorilistesi();

        }

       

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwkategori.CurrentRow!=null)
            {
                SqlCommand komut = new SqlCommand("KategoriSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@katid", dgwkategori.CurrentRow.Cells["KategoriID"].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Kategorilistesi();

            }
            
        }

        private void dgwkategori_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("KategoriGuncelle",baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", 
            dgwkategori.CurrentRow.Cells["KategoriID"].Value);
            komut.Parameters.AddWithValue( "@ad", 
            dgwkategori.CurrentRow.Cells["KategoriAdi"].Value);
            komut.Parameters.AddWithValue("@tanim",
            dgwkategori.CurrentRow.Cells["Tanimi"].Value);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kategorilistesi();
        }
    }
}
