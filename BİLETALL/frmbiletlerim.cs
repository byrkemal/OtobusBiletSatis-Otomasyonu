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

namespace BİLETALL
{
    public partial class frmbiletlerim : Form
    {
        private string oturum;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adtr;
        public frmbiletlerim(string oturum)
        {
            InitializeComponent();
            this.oturum = oturum;
        }
        void BiletlerimGetir()
        {
            baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
            baglanti.Open();
            adtr = new SqlDataAdapter("select *from SatilanBiletler", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMENÜ_Click(object sender, EventArgs e)
        {
            frmmenu menü = new frmmenu(oturum);
            menü.Show(this);
        }
        private void frmbiletlerim_Load(object sender, EventArgs e)
        {
            BiletlerimGetir();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            frmFiyatFiltreleme fitreleme = new frmFiyatFiltreleme();
            fitreleme.Show(this);
        }
        private void btnTOPLAMBILET_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
            baglanti.Open();
            adtr = new SqlDataAdapter("SELECT * FROM TOPLAMBILET ", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        private void btnSİL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("biletlerim_sil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@BILETNO", textBox1.Text);
            komut.ExecuteNonQuery();
            BiletlerimGetir();
            baglanti.Close();
            textBox1.Clear();
        }
    }
}
