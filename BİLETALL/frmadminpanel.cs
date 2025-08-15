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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BİLETALL
{
    public partial class frmadminpanel : Form
    {
        
        public frmadminpanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Musteri_Guncelle", baglanti);
            komut2.CommandType = CommandType.StoredProcedure;
            komut2.Parameters.AddWithValue("@AD", txtAD.Text);
            komut2.Parameters.AddWithValue("@SOYAD", txtSOYAD.Text);
            komut2.Parameters.AddWithValue("@TELEFON", txtTELEFON.Text);
            komut2.Parameters.AddWithValue("@PAROLA", txtPAROLA.Text);
            komut2.Parameters.AddWithValue("@TC", txtTC.Text);
            komut2.ExecuteNonQuery();
            verilerigoster("SELECT * FROM MUSTERİLER");
            MessageBox.Show("Müşteri Bilgileri Güncellendi");
            baglanti.Close();
            txtTC.Clear();
            txtAD.Clear();
            txtSOYAD.Clear();
            txtTELEFON.Clear();
            txtPAROLA.Clear();
        }

        private void btnARA_Click(object sender, EventArgs e)
        {
           
        }

        private void frmadminpanel_Load(object sender, EventArgs e)
        {

        }

        private void btnMUSTERİLER_Click(object sender, EventArgs e)
        {
            verilerigoster("select * from MUSTERİLER");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string TC = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string AD = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string SOYAD = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string TELEFON = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string PAROLA = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            txtTC.Text = TC;
            txtAD.Text = AD;
            txtSOYAD.Text = SOYAD;
            txtTELEFON.Text = TELEFON;
            txtPAROLA.Text = PAROLA;
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Musteri_Sil", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", txtTC.Text);
            cmd.ExecuteNonQuery();
            verilerigoster("SELECT * FROM MUSTERİLER");
            baglanti.Close();

            txtTC.Clear();
            txtAD.Clear();
            txtSOYAD.Clear();
            txtTELEFON.Clear();
            txtPAROLA.Clear();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTCARA_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Musteri_Ara", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TC", txtTCARA.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
