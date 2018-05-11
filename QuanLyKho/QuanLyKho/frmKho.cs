using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKho
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }
        DataConections con = new DataConections();

        #region Load Data
        public void ShowKho()
        {
            btnSuaKho.Enabled = false;
            btnXoaKho.Enabled = false;
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KHO";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                lvKho.Items.Add(liv);
            }
            reader.Close();
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            this.ShowKho();
        }

        #endregion
        #region button

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            bool check = true;
            if ((txbMK.Text != "") && (txbTenK.Text != ""))
            {
                foreach (string us in list)
                {
                    if (us.Contains(txbMK.Text))
                    {
                        MessageBox.Show("Mã kho đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {

                    ListViewItem liv = new ListViewItem(txbMK.Text);
                    liv.SubItems.Add(txbTenK.Text);
                    lvKho.Items.Add(liv);
                    ThemKho();

                }
            }
            else

            {
                MessageBox.Show("Chưa nhập mã kho hoặc tên kho!", "Thông báo");
            }
            
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            btnThemKho.Enabled = true;
            if (lvKho.SelectedItems.Count == 0) return;
            ListViewItem liv = lvKho.SelectedItems[0];
            liv.SubItems[0].Text = txbMK.Text;
            liv.SubItems[1].Text = txbTenK.Text;
            SuaKho();
            MessageBox.Show("Đã sửa thành công!", "Sửa");
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            if (lvKho.SelectedItems != null)
            {
                for (int i = 0; i < lvKho.Items.Count; i++)
                {
                    if (lvKho.Items[i].Selected)
                    {
                        lvKho.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaKho();
            MessageBox.Show("Đã xoá thành công!", "Xoá");
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThemKho.Enabled = true;
            btnSuaKho.Enabled = false;
            btnXoaKho.Enabled = false;
            txbMK.Enabled = true;

            txbMK.ResetText();
            txbTenK.ResetText();
        }
        #endregion
        #region database
        private void ThemKho()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm Kho không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADD_KHO";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txbMK.Text;
                cmd.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = txbTenK.Text;

                int ret = cmd.ExecuteNonQuery();
                lvKho.Items.Clear();
                if (ret > 0)
                    ShowKho();

                MessageBox.Show("Đã thêm thành công", "Thêm");

                txbMK.ResetText();
                txbTenK.ResetText();
            }
            else
            {
                lvKho.Items.Clear();
                ShowKho();
            }
        }

        private void SuaKho()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ALTER_KHO";
            cmd.Connection = con.conn;
            cmd.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txbMK.Text;
            cmd.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = txbTenK.Text;

            int ret = cmd.ExecuteNonQuery();
            lvKho.Items.Clear();
            if (ret > 0)
                ShowKho();

        }

        public void XoaKho()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "D_KHO";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txbMK.Text;
            int ret = cmd.ExecuteNonQuery();
            lvKho.Items.Clear();
            if (ret > 0)
                ShowKho();
        }


        #endregion
        List<string> list = new List<string>();
        #region listview
        private void lvKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbMK.Enabled = false;
            btnThemKho.Enabled = false;
            btnSuaKho.Enabled = true;
            btnXoaKho.Enabled = true;
            if (lvKho.SelectedItems.Count == 0) return;
            ListViewItem liv = lvKho.SelectedItems[0];
            txbMK.Text = liv.SubItems[0].Text;
            txbTenK.Text = liv.SubItems[1].Text;
        }
        #endregion
    }
}

