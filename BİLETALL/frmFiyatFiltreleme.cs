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
    public partial class frmFiyatFiltreleme : Form
    {
        public frmFiyatFiltreleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter adtr;
        private void frmFiyatFiltreleme_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=monster\SQLEXPRESS;Initial Catalog=BiletAl;Integrated Security=True");
            baglanti.Open();
            adtr = new SqlDataAdapter("EXECUTE  FIYATFİLTRELE ", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
