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
    public partial class frmkoltuksecimi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
        private string kalkis;
        private string varis;
        private int seferId;
        private string oturum;
        public frmkoltuksecimi(string oturum, string kalkis, string varis, int seferId)
        {
            InitializeComponent();
            this.kalkis = kalkis;
            this.varis = varis;
            this.seferId = seferId;
            this.oturum = oturum;
        }

        private void btnkoltuk1_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "1";
        }
        private void btnkoltuk2_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "2";
        }
        private void btnkoltuk3_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "3";
        }
        private void btnkoltuk4_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "4";
        }
        private void btnkoltuk5_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "5";
        }
        private void btnkoltuk6_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "6";
        }
        private void btnkoltuk7_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "7";
        }
        private void btnkoltuk8_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "8";
        }
        private void btnkoltuk9_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "9";
        }
        private void btnkoltuk10_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "10";
        }
        private void btnkoltuk11_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "11";
        }
        private void btnkoltuk12_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "12";
        }
        private void btnkoltuk13_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "13";
        }
        private void btnkoltuk14_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "14";
        }
        private void btnkoltuk15_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "15";
        }
        private void btnkoltuk16_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "16";
        }
        private void btnkoltuk17_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "17";
        }
        private void btnkoltuk18_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "18";
        }
        private void btnkoltuk19_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "19";
        }
        private void btnkoltuk20_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "20";
        }
        private void btnkoltuk21_Click(object sender, EventArgs e)
        {
            txtKOLTUKNUMARASI.Text = "21";
        }
        private void btnSATINAL_Click(object sender, EventArgs e)
        {
            int koltukNumarasi = Convert.ToInt16(txtKOLTUKNUMARASI.Text);
            
            baglanti.Open();
          
            string query_ekleme = "INSERT INTO BILETLER (SEFERNO, TC, KOLTUKNO) VALUES (@seferId, '" + @oturum + "', @koltukNumarasi)",
                   sorgu_guncelle = "UPDATE SEFERKOLTUKBİLGİSİ SET DURUM = 1 WHERE SEFERNO = " + seferId + " AND KOLTUKNO = " + @koltukNumarasi;

            
            SqlCommand cmd = new SqlCommand(query_ekleme, baglanti);
            SqlCommand kmt = new SqlCommand(sorgu_guncelle, baglanti);
            cmd.Parameters.AddWithValue("@seferId", seferId);
            cmd.Parameters.AddWithValue("@oturum", oturum);
            cmd.Parameters.AddWithValue("@koltukNumarasi", koltukNumarasi);

            // Sorguyu çalıştır
            cmd.ExecuteNonQuery();
            kmt.ExecuteNonQuery();
       
            baglanti.Close();

            MessageBox.Show("Biletiniz Başarılı Bir Şekilde Oluşturuldu ");
            frmbiletlerim biletlerim = new frmbiletlerim(oturum);
            biletlerim.Show();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmkoltuksecimi_Load(object sender, EventArgs e)
        {
            List<Button> düğmeler = new List<Button>();

            düğmeler.Add(btnkoltuk1);
            düğmeler.Add(btnkoltuk2);
            düğmeler.Add(btnkoltuk3);
            düğmeler.Add(btnkoltuk4);
            düğmeler.Add(btnkoltuk5);
            düğmeler.Add(btnkoltuk6);
            düğmeler.Add(btnkoltuk7);
            düğmeler.Add(btnkoltuk8);
            düğmeler.Add(btnkoltuk9);
            düğmeler.Add(btnkoltuk10);
            düğmeler.Add(btnkoltuk11);
            düğmeler.Add(btnkoltuk12);
            düğmeler.Add(btnkoltuk13);
            düğmeler.Add(btnkoltuk14);
            düğmeler.Add(btnkoltuk15);
            düğmeler.Add(btnkoltuk16);
            düğmeler.Add(btnkoltuk17);
            düğmeler.Add(btnkoltuk18);
            düğmeler.Add(btnkoltuk19);
            düğmeler.Add(btnkoltuk20);
            düğmeler.Add(btnkoltuk21);

            SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
            baglanti.Open();

            int i = 1;

            foreach (Button düğme in düğmeler)
            {
                string sql_sorgu = "SELECT DURUM FROM SEFERKOLTUKBİLGİSİ WHERE SEFERNO = " + seferId + " AND KOLTUKNO = " + i;
                using (SqlCommand komut = new SqlCommand(sql_sorgu, baglanti))
                {
                    bool dolu = Convert.ToBoolean(komut.ExecuteScalar());

                    if (dolu == true)
                        düğme.BackColor = Color.Red;
                    else
                        düğme.BackColor = Color.YellowGreen;
                }
                i = (i == 21) ? 1 : (i + 1);
            }
            baglanti.Close();
        }
    }
}
