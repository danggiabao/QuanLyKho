using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        } 

        private void btnNhap_Click(object sender, EventArgs e)
        {
           frmNhapKho frmhd = new frmNhapKho();
           this.Hide();
           frmhd.ShowDialog();
           this.Show();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frmXuatKho frmpb = new frmXuatKho();
            this.Hide();
            frmpb.ShowDialog();
            this.Show();
        }

        private void btnVT_Click(object sender, EventArgs e)
        {
            frmVatTu frmpb = new frmVatTu();
            this.Hide();
            frmpb.ShowDialog();
            this.Show();
        }
    }
}
