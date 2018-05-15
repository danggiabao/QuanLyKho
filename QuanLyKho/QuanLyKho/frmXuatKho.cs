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

namespace QuanLyKho
{
    public partial class frmXuatKho : Form
    {
        public frmXuatKho()
        {
            InitializeComponent();
        }
        DataConections dt = new DataConections();
        SqlCommand cmd = new SqlCommand();
        List<string> lst = new List<string>();
        
        #region Listview - Data - Combobox
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            ShowData();
            cbbMaKho();
            ShowDataCTPX();
            ShowMaPX();
            ShowMaVT();
        }
        private void lvPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtSoPhieu.Enabled = false;
            if (lvPX.SelectedIndices.Count == 0) return;
            ListViewItem liv = lvPX.SelectedItems[0];
            txtSoPhieu.Text = liv.SubItems[0].Text;
            cbMaKho.Text = liv.SubItems[1].Text;
            dtNgayXuat.Text = liv.SubItems[2].Text;
            
        }
        public void ShowData()
        {
            dt.OpenConnection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PHIEUXUAT";
            cmd.Connection = dt.conn;           
            SqlDataReader reader = cmd.ExecuteReader();            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDateTime(1).ToString("dd/MM/yyyy"));

                lst.Add(reader.GetString(0));
                lvPX.Items.Add(item);
            }
            reader.Close();
        }

        
        public void cbbMaKho()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KHO";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbMaKho.Items.Clear();
            List<string> lst = new List<string>();
            while (reader.Read())
            {
                string MaKho = reader.GetString(0);
                
                cbMaKho.Items.Add(MaKho);
            }
            reader.Close();
        }
        string MaKho = "";
        private void cbMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbMaKho.SelectedItem.ToString();
            string[] arr = value.Split('-');
            MaKho = arr[0];
        }
        #endregion
        #region Button
        private void btnThemPN_Click(object sender, EventArgs e)
        {
            bool check = true;
            
            foreach (string x in lst)
            {
                if ((x.Contains(txtSoPhieu.Text)) && (txtSoPhieu.Text.Contains(x)))
                {
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                ListViewItem item = new ListViewItem(txtSoPhieu.Text);
                item.SubItems.Add(MaKho);
                item.SubItems.Add(dtNgayXuat.Text);
                lvPX.Items.Add(item);
                ThemPX_Database();
                MessageBox.Show("Thêm thành công!");
                
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (lvPX.SelectedItems.Count == 0) return;
            ListViewItem liv = lvPX.SelectedItems[0];
            liv.SubItems[0].Text = txtSoPhieu.Text;
            liv.SubItems[1].Text = cbMaKho.Text;
            liv.SubItems[2].Text = dtNgayXuat.Text;

            
            SuaPX_Database();
            MessageBox.Show("Sửa thành công!");
            
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (lvPX.SelectedItems != null)
            {
                for (int i = 0; i < lvPX.Items.Count; i++)
                {
                    if (lvPX.Items[i].Selected)
                    {
                        lvPX.Items[i].Remove();
                        i--;
                    }
                }
                XoaPX_Database();
                MessageBox.Show("Xóa thành công!");
                
            }
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSoPhieu.Enabled = true;
            txtSoPhieu.ResetText();
            cbMaKho.ResetText();
            dtNgayXuat.ResetText();
            
        }
        #endregion
        #region Database
        public void ThemPX_Database()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemPX";
            cmd.Connection = dt.conn;
            
            
            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
            cmd.Parameters.Add("@NGAYXUAT", SqlDbType.Date).Value = dtNgayXuat.Text;
            cmd.Parameters.Add("@MAKHO", SqlDbType.NVarChar).Value = cbMaKho.Text;
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
        }
        public void SuaPX_Database()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuaPX";
            cmd.Connection = dt.conn;
            
            
            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
            cmd.Parameters.Add("@NGAYXUAT", SqlDbType.Date).Value = dtNgayXuat.Text;
            cmd.Parameters.Add("@MAKHO", SqlDbType.NVarChar).Value = cbMaKho.Text;
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
            /*int ret = cmd.ExecuteNonQuery();
            lvPX.Items.Clear();
            if (ret > 0)
                ShowData();*/
        }
        public void XoaPX_Database()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XoaPX";
            cmd.Connection = dt.conn;
            
            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
            /*int ret = cmd.ExecuteNonQuery();
            lvPX.Items.Clear();
            if (ret > 0)
                ShowData();*/
        }
        #endregion
        /// <summary>
        /// /////////////////////// CHI TIẾT PHIẾU XUẤT
        /// </summary>
        List<string> lstCT = new List<string>();
        List<string> lstMaVT = new List<string>();
        string MaPhieu = "";
        string MaVT = "";

        #region Listview - Data - Combobox
        private void lvCTPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThemCT.Enabled = false;
            btnSuaCT.Enabled = true;
            btnXoaCT.Enabled = true;
            
            if (lvCTPX.SelectedIndices.Count == 0) return;
            ListViewItem liv = lvCTPX.SelectedItems[0];
            cbMaPhieu.Text = liv.SubItems[0].Text;
            cbMaVT.Text = liv.SubItems[1].Text;
            txtdonvi.Text = liv.SubItems[2].Text;
            txtsoluong.Text = liv.SubItems[3].Text;
        }
        public void ShowDataCTPX()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CHITIETPHIEUXUAT";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            lvPX.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));

                lstCT.Add(reader.GetString(0));
                lstMaVT.Add(reader.GetString(1));
                lvPX.Items.Add(item);
            }
            reader.Close();
        }

        public void ShowMaPX()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KHO";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbMaPhieu.Items.Clear();
            List<string> lstSoPhieu = new List<string>();
            while (reader.Read())
            {
                string MaKho = reader.GetString(0);
                string TenKho = reader.GetString(1);
                cbMaPhieu.Items.Add(MaKho + "-" + TenKho);
            }
            reader.Close();
        }

        public void ShowMaVT()
        {
            dt.OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbMaVT.Items.Clear();
            List<string> lstSoPhieu = new List<string>();
            while (reader.Read())
            {
                string MaVT = reader.GetString(0);
                string TenVT = reader.GetString(1);
                cbMaVT.Items.Add(MaVT + "-" + TenVT);
            }
            reader.Close();
        }
        private void cbMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbMaPhieu.SelectedItem.ToString();
            string[] arr = value.Split('-');
            MaPhieu = arr[0];
        }

        private void cbMaVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cbMaVT.SelectedItem.ToString();
            string[] arr = value.Split('-');
            MaVT = arr[0];
        }
        #endregion
        #region DatabaseCTPX
        public void ThemCTPX_Database()
        {
            //( SOPHIEU, MAVT, DONVITINH, SOLUONG )
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemCTPX";
            cmd.Connection = dt.conn;
            dt.OpenConnection();

            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = cbMaPhieu.Text;
            cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar).Value = cbMaVT.Text;
            cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = txtdonvi.Text;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = int.Parse(txtsoluong.Text);
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
        }
        public void SuaCTPX_Database()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuaCTPX";
            cmd.Connection = dt.conn;
            dt.OpenConnection();

            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = cbMaPhieu.Text;
            cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar).Value = cbMaVT.Text;
            cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = txtdonvi.Text;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = int.Parse(txtsoluong.Text);
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
        }
        public void XoaCTPX_Database()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XoaCTPX";
            cmd.Connection = dt.conn;
            dt.OpenConnection();
            cmd.Parameters.Add("@MAPHIEU", SqlDbType.NVarChar).Value = cbMaPhieu.Text;
            cmd.ExecuteNonQuery();
            dt.CloseConnection();
        }
        #endregion
        #region Button
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            bool check = true;
            bool check1 = true;
            foreach (string x in lstCT)
            {
                if ((x.Contains(MaPhieu)) && (x.Contains(MaPhieu)))
                {
                    check = false;
                    break;
                }
                check = true;
            }
            foreach (string y in lstMaVT)
            {
                if (y.Contains(MaVT))
                {
                    check1 = false;
                    break;
                }
                check1 = true;
            }
            if (check == true && check1 == true)
            {
                ListViewItem item = new ListViewItem(MaPhieu);
                item.SubItems.Add(MaVT);
                item.SubItems.Add(txtdonvi.Text);
                item.SubItems.Add(txtsoluong.Text);

                lvPX.Items.Add(item);
                ThemCTPX_Database();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            btnThemCT.Enabled = true;
            if (lvCTPX.SelectedItems.Count == 0) return;
            ListViewItem liv = lvCTPX.SelectedItems[0];
            liv.SubItems[0].Text = cbMaKho.Text;
            liv.SubItems[1].Text = cbMaVT.Text;
            liv.SubItems[2].Text = txtdonvi.Text;
            liv.SubItems[2].Text = txtsoluong.Text;

            lvPX.Items.Add(liv);
            SuaCTPX_Database();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (lvCTPX.SelectedItems != null)
            {
                for (int i = 0; i < lvCTPX.Items.Count; i++)
                {
                    if (lvCTPX.Items[i].Selected)
                    {
                        lvPX.Items[i].Remove();
                        i--;
                    }
                }
                XoaCTPX_Database();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnRsCT_Click(object sender, EventArgs e)
        {
            btnThemCT.Enabled = true;
            btnSuaCT.Enabled = false;
            btnXoaCT.Enabled = false;
            cbMaVT.ResetText();
            cbMaPhieu.ResetText();
            txtsoluong.ResetText();
            txtSoPhieu.ResetText();
        }


        #endregion

        
    }
}
