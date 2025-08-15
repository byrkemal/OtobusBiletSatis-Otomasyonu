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
    public partial class frmgirisyap : Form
    {
        private string oturum = "";
        public frmgirisyap()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string tc = txtTC.Text;
            string parola = txtPAROLA.Text;

            // Admin girişi kontrolü
            if (tc == "100" && parola == "100")
            {
                MessageBox.Show("Admin olarak giriş yaptınız.");
                frmadminpanel adminPanel = new frmadminpanel();
                adminPanel.Show();
                return;
                // Admin girişi yapıldığında diğer işlemlere gerek yok, bu yüzden fonksiyondan çıkıyoruz.
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM  MUSTERİLER where TC = '" + tc + "' and PAROLA='" + parola + "'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                oturum = tc;
                MessageBox.Show("Hoşgeldiniz :) ");
                frmmenu menu = new frmmenu(oturum);
                menu.Show(this);
            }
            else
            {
                MessageBox.Show("Hatalı TC veya PAROLA girdiniz !!!");
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHakkında hakkinda =new frmHakkında();
            hakkinda.Show();
        }
    }
}
