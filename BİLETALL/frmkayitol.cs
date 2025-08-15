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
    public partial class frmkayitol : Form
    {
        public frmkayitol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
        private void btnKAYITOL_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string tc = txtTC.Text;
            string ad = txtAD.Text;
            string soyad = txtSOYAD.Text;
            string telefon = txtTEL.Text;
            string parola = txtPAROLA.Text;

            // Parametreli sorgu kullandımmm -->

            SqlCommand ekle = new SqlCommand("INSERT INTO MUSTERİLER(TC, AD, SOYAD, TELEFON, PAROLA) VALUES(@tc, @ad, @soyad, @telefon, @parola)", baglanti);
            ekle.Parameters.AddWithValue("@tc", tc);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@soyad", soyad);
            ekle.Parameters.AddWithValue("@telefon", telefon);
            ekle.Parameters.AddWithValue("@parola", parola);
           
            int rowsAffected = ekle.ExecuteNonQuery();

            MessageBox.Show("Kayıt Oldunuz");
            baglanti.Close();
            txtTC.Clear();
            txtAD.Clear();
            txtSOYAD.Clear();
            txtTEL.Clear();
            txtPAROLA.Clear();

           
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
