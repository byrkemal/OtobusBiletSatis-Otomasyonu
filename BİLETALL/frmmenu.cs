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
    public partial class frmmenu : Form
    {
        private string oturum;
        public frmmenu(string oturum)
        {
            InitializeComponent();
            this.oturum = oturum;
        }
        private void btnBİLETAL_Click(object sender, EventArgs e)
        {
            frmseferarama frmseferarama = new frmseferarama(oturum);
            frmseferarama.ShowDialog();
        }
        private void btnBİLETLERİM_Click(object sender, EventArgs e)
        {
            frmbiletlerim biletlerim = new frmbiletlerim(oturum);
            biletlerim.ShowDialog();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
