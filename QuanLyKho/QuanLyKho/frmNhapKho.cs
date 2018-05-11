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
    public partial class frmNhapKho : Form
    {
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
			btnThemPN.Enabled = true;
			btnSuaPN.Enabled = false;
			btnXoaCT.Enabled = false;

			ShowData();
			ShowMaKho();
		}
		DataConections db = new DataConections();
		List<string> lstSoPhieu = new List<string>();
		SqlCommand cmd = new SqlCommand();
		#region Show Data
		// xuat du lieu len list view
		public void ShowData()
		{
			db.OpenConnection();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from PHIEUNHAP";
			cmd.Connection = db.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			lvPN.Items.Clear();

			while (reader.Read())
			{
				ListViewItem item = new ListViewItem(reader.GetString(0));
				item.SubItems.Add(reader.GetString(2));
				item.SubItems.Add(reader.GetDateTime(1).ToString("dd/MM/yyyy"));

				lstSoPhieu.Add(reader.GetString(0));
				lvPN.Items.Add(item);
			}
			reader.Close();
		}
		// xuat du lieu vao combobox
		public void ShowMaKho()
		{
			db.OpenConnection();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from KHO";
			cmd.Connection = db.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			cbMaKho.Items.Clear();
			List<string> lstSoPhieu = new List<string>();
			while (reader.Read())
			{
				string MaKho = reader.GetString(0);
				string TenKho = reader.GetString(1);
				cbMaKho.Items.Add(MaKho + "-" + TenKho);
			}
			reader.Close();
		}
		#endregion

	}
}
