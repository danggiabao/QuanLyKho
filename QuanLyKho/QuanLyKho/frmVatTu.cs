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
    public partial class frmVatTu : Form
    {
        public frmVatTu()
        {
            InitializeComponent();
        }
        DataConections connect = new DataConections();
        List<string> list = new List<string>();
        #region LoadData_in_database
        public void ShowVT()
        {
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            connect.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU";
            cmd.Connection = connect.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listview = new ListViewItem(reader.GetString(0));
                listview.SubItems.Add(reader.GetString(1));
                listview.SubItems.Add(reader.GetString(2));
                list.Add(reader.GetString(0));
                lvVT.Items.Add(listview);
            }
            reader.Close();
        }
        private void frmVatTu_Load(object sender, EventArgs e)
        {
            ShowVT();
        }
        #endregion

        #region event_click_listview
        private void lvVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbMaVT.Enabled = false;
            btnThemVT.Enabled = false;
            btnSuaVT.Enabled = true;
            btnXoaVT.Enabled = true;
            if (lvVT.SelectedItems.Count == 0) return;
            ListViewItem listview = lvVT.SelectedItems[0];
            txbMaVT.Text = listview.SubItems[0].Text;
            txbTenVT.Text = listview.SubItems[1].Text;
            txbXX.Text = listview.SubItems[2].Text;
        }

        #endregion

        #region event_buttons_click
        private void btnThemVT_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txbMaVT.Text != "")
            {
                foreach (string us in list)
                {
                    if (us.Contains(txbMaVT.Text))
                    {
                        MessageBox.Show("Mã kho đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem lv = new ListViewItem(txbMaVT.Text);
                    lv.SubItems.Add(txbTenVT.Text);
                    lv.SubItems.Add(txbXX.Text);
                    lvVT.Items.Add(lv);
                    ThemVT();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã vật tư!", "Thông báo");
            }
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            btnThemVT.Enabled = true;
            if (lvVT.SelectedItems.Count == 0) return;
            ListViewItem lv = lvVT.SelectedItems[0];
            lv.SubItems[0].Text = txbMaVT.Text;
            lv.SubItems[1].Text = txbTenVT.Text;
            lv.SubItems[2].Text = txbXX.Text;
            SuaVT();
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (lvVT.SelectedItems != null)
            {
                for (int i = 0; i < lvVT.Items.Count; i++)
                {
                    if (lvVT.Items[i].Selected)
                    {
                        lvVT.Items[i].Remove();
                        i--;
                    }
                }
                XoaVT();
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            btnThemVT.Enabled = true;
            btnSuaVT.Enabled = false;
            btnXoaVT.Enabled = false;
            txbMaVT.Enabled = true;
            txbMaVT.ResetText();
            txbTenVT.ResetText();
            txbXX.ResetText();
        }
        #endregion

        #region Database
        private void ThemVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemVT";
                cmd.Connection = connect.conn;
                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txbMaVT.Text;
                cmd.Parameters.Add("@TENVT", SqlDbType.NVarChar).Value = txbTenVT.Text;
                cmd.Parameters.Add("@XUATXU", SqlDbType.NVarChar).Value = txbXX.Text;
                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowVT();

                MessageBox.Show("Đã thêm thành công", "Thêm");

                txbMaVT.ResetText();
                txbTenVT.ResetText();
                txbXX.ResetText();
            }
            else
            {
                lvVT.Items.Clear();
                ShowVT();
            }
        }
        private void SuaVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaVT";
                cmd.Connection = connect.conn;
                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txbMaVT.Text;
                cmd.Parameters.Add("@TENVT", SqlDbType.NVarChar).Value = txbTenVT.Text;
                cmd.Parameters.Add("@XUATXU", SqlDbType.NVarChar).Value = txbXX.Text;

                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowVT();
                MessageBox.Show("Đã sửa thành công", "Sửa");
            }
            else
            {
                lvVT.Items.Clear();
                ShowVT();
            }

        }
        public void XoaVT()
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                connect.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaVT";
                cmd.Connection = connect.conn;

                cmd.Parameters.Add("@MAVT", SqlDbType.VarChar).Value = txbMaVT.Text;
                int ret = cmd.ExecuteNonQuery();
                lvVT.Items.Clear();
                if (ret > 0)
                    ShowVT();
                MessageBox.Show("Đã xóa thành công", "Xóa");
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = false;
                btnXoaVT.Enabled = false;
                txbMaVT.Enabled = true;
                txbMaVT.ResetText();
                txbTenVT.ResetText();
                txbXX.ResetText();
            }
            else
            {
                btnThemVT.Enabled = true;
                btnSuaVT.Enabled = false;
                btnXoaVT.Enabled = false;
                txbMaVT.Enabled = true;
                txbMaVT.ResetText();
                txbTenVT.ResetText();
                txbXX.ResetText();
                lvVT.Items.Clear();
                ShowVT();
            }
        }
        #endregion
    }
}
