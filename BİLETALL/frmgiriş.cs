using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLETALL
{
    public partial class frmgiriş : Form
    {
        private string oturum = "";
        public frmgiriş()
        {
            InitializeComponent();        
        }
        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGİRİŞ_Click(object sender, EventArgs e)
        {
            frmgirisyap girisyap = new frmgirisyap();
            girisyap.ShowDialog();
        }
        private void btnKAYITOL_Click(object sender, EventArgs e)
        {
            frmkayitol kayitol = new frmkayitol();
            kayitol.ShowDialog();
        }
        private void frmgiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
