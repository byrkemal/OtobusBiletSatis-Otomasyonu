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
    public partial class frmseferarama : Form
    {
        private string oturum;
        public frmseferarama(string oturum)
        {
            InitializeComponent();
            this.oturum = oturum;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnARA_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // Kullanıcının seçtiği kalkış ve varış yerlerini aldım
            string kalkis = cmbKALKIS.SelectedItem.ToString();
            string varis = cmbVARIS.SelectedItem.ToString();

            // SQL sorgusunu oluşturduk
            string query = "SELECT * FROM SEFERLER WHERE KALKIS = @kalkis AND VARIS = @varis";

            // SqlCommand oluştur ve parametreleri ekledimm
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.Parameters.AddWithValue("@kalkis", kalkis);
            cmd.Parameters.AddWithValue("@varis", varis);

            // SqlDataAdapter ve DataTable kullanarak sonuçları al
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Sonuçları bir DataGridView içinde göster
            dataGridView1.DataSource = dt;




            // Devam butonunu başlangıçta pasif hale getirme
            btnDEVAM.Enabled = false;
            baglanti.Close();
        }
        private void btnDEVAM_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;

            frmkoltuksecimi koltuksecimi = new frmkoltuksecimi(oturum, satır.Cells[1].Value.ToString(), satır.Cells[2].Value.ToString(), Convert.ToInt32(satır.Cells[0].Value));
            koltuksecimi.ShowDialog();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDEVAM.Enabled = true; // Devam butonunu aktif hale getir
            }
        }
        private void frmseferarama_Load(object sender, EventArgs e)
        {
            btnDEVAM.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
