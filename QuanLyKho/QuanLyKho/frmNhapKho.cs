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
		#region Phiếu Nhập Kho
		private void frmNhapKho_Load(object sender, EventArgs e)
        {
			btnThemPN.Enabled = true;
			btnSuaPN.Enabled = false;
			btnXoaPN.Enabled = false;


			btnThemCT.Enabled = true;
			btnSuaCT.Enabled = false;
			btnXoaCT.Enabled = false;

			//  phieu nhap
			ShowData();
			ShowMaKho();

			// chi tiet phieu truc
			ShowDataCTPN();
			ShowMaVT();
			ShowMaPN();
		}
		DataConections db = new DataConections();
		SqlCommand cmd = new SqlCommand();
		List<string> lstSoPhieu = new List<string>();
		string MaKho = "";
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
		#region Controller
		private void cbMaKho_SelectedIndexChanged(object sender, EventArgs e)
		{
			string value = cbMaKho.SelectedItem.ToString();
			string[] arr = value.Split('-');
			MaKho = arr[0];
		}
		private void btnThemPN_Click(object sender, EventArgs e)
		{
 			bool check = true;
			int i = 0;

			if (i < 10) { txtSoPhieu.Text = "Phieu 0" + i; }
			if (i > 10) { txtSoPhieu.Text = "Phieu " + i; }
			foreach (string x in lstSoPhieu)
			{
				if (x.Contains(txtSoPhieu.Text))
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
				item.SubItems.Add(dtNgayLap.Text);
				lvPN.Items.Add(item);
				ThemPN_Database();
				MessageBox.Show("Thêm thành công!");
			}
		}

		private void btnSuaPN_Click(object sender, EventArgs e)
		{
			btnThemPN.Enabled = true;
			if (lvPN.SelectedItems.Count == 0) return;
			ListViewItem liv = lvPN.SelectedItems[0];
			liv.SubItems[0].Text = txtSoPhieu.Text;
			liv.SubItems[1].Text = cbMaKho.Text;
			liv.SubItems[2].Text = dtNgayLap.Text;

			lvPN.Items.Add(liv);
			SuaPN_Database();
			MessageBox.Show("Sửa thành công!");
		}

		private void btnXoaPN_Click(object sender, EventArgs e)
		{
			if (lvPN.SelectedItems != null)
			{
				for (int i = 0; i < lvPN.Items.Count; i++)
				{
					if (lvPN.Items[i].Selected)
					{
						lvPN.Items[i].Remove();
						i--;
					}
				}
				XoaPN_Database();
				MessageBox.Show("Xóa thành công!");
			}
		}
		private void btnRs_Click(object sender, EventArgs e)
		{
			btnThemPN.Enabled = true;
			btnSuaPN.Enabled = false;
			btnXoaPN.Enabled = false;
			txtSoPhieu.ResetText();
			cbMaKho.ResetText();
			dtNgayLap.ResetText();
		}
		#endregion
		#region Database
		public void ThemPN_Database()
		{
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemPhieuNhap";
			cmd.Connection = db.conn;
			db.OpenConnection();
			//( SOPHIEU, NGAYLAP, MAKHO )
			cmd.Parameters.Add("@SOPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
			cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = dtNgayLap.Text;
			cmd.Parameters.Add("@MAKHO", SqlDbType.NVarChar).Value = cbMaKho.Text;
			cmd.ExecuteNonQuery();
			db.CloseConnection();
		}
		public void SuaPN_Database()
		{
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaPhieuNhap";
			cmd.Connection = db.conn;
			db.OpenConnection();
			//( SOPHIEU, NGAYLAP, MAKHO )
			cmd.Parameters.Add("@SOPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
			cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = dtNgayLap.Text;
			cmd.Parameters.Add("@MAKHO", SqlDbType.NVarChar).Value = cbMaKho.Text;
			cmd.ExecuteNonQuery();
			db.CloseConnection();
		}
		public void XoaPN_Database()
		{
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaPhieuNhap";
			cmd.Connection = db.conn;
			db.OpenConnection();
			//( SOPHIEU, NGAYLAP, MAKHO )
			cmd.Parameters.Add("@SOPHIEU", SqlDbType.NVarChar).Value = txtSoPhieu.Text;
			cmd.ExecuteNonQuery();
			db.CloseConnection();
		}

		//	public void
		#endregion
		private void lvPN_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnThemPN.Enabled = false;
			btnSuaPN.Enabled = true;
			btnXoaPN.Enabled = true;
			if (lvPN.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvPN.SelectedItems[0];
			txtSoPhieu.Text = liv.SubItems[0].Text;
			cbMaKho.Text = liv.SubItems[1].Text;

			string[] date = liv.SubItems[3].Text.Split('/');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtNgayLap.Value = dt;
		}
		#endregion

		/// <summary>
		/// ////////////////////////////////
		/// </summary>
 		#region Chi Tiết Phiếu Nhập
		List<string> lstCTPN = new List<string>();
		List<string> lstMaVT = new List<string>();
		string MaPhieu = "";
		string MaVT = "";
		#region Show Data
		// xuat du lieu len list view
		public void ShowDataCTPN()
		{
			db.OpenConnection();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from CHITIETPHIEUNHAP";
			cmd.Connection = db.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			lvPN.Items.Clear();

			while (reader.Read())
			{
				ListViewItem item = new ListViewItem(reader.GetString(0));
				item.SubItems.Add(reader.GetString(1));
				item.SubItems.Add(reader.GetString(2));
				item.SubItems.Add(reader.GetString(3));

				lstCTPN.Add(reader.GetString(0));
				lstMaVT.Add(reader.GetString(1));
				lvPN.Items.Add(item);
			}
			reader.Close();
		}
		// xuat du lieu vao combobox
		public void ShowMaPN()
		{
			db.OpenConnection();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from KHO";
			cmd.Connection = db.conn;

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
			db.OpenConnection();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from VATTU";
			cmd.Connection = db.conn;

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

		#endregion
		#region Controller
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

		private void btnThemCT_Click(object sender, EventArgs e)
		{
			bool check = true;
			bool check1 = true;
			foreach (string x in lstCTPN)
			{
				if (x.Contains(MaPhieu))
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

				lvPN.Items.Add(item);
 				MessageBox.Show("Thêm thành công!");
			}
			
		}

		private void btnSuaCT_Click(object sender, EventArgs e)
		{
			btnThemCT.Enabled = true;
			if (lvCTPN.SelectedItems.Count == 0) return;
			ListViewItem liv = lvCTPN.SelectedItems[0];
			liv.SubItems[0].Text = cbMaKho.Text;
			liv.SubItems[1].Text = cbMaVT.Text;
			liv.SubItems[2].Text = txtdonvi.Text;
			liv.SubItems[2].Text = txtsoluong.Text;

			lvPN.Items.Add(liv);
 			MessageBox.Show("Sửa thành công!");
		}

		private void btnXoaCT_Click(object sender, EventArgs e)
		{
			if (lvCTPN.SelectedItems != null)
			{
				for (int i = 0; i < lvCTPN.Items.Count; i++)
				{
					if (lvCTPN.Items[i].Selected)
					{
						lvPN.Items[i].Remove();
						i--;
					}
				}
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
		private void lvCTPN_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnThemCT.Enabled = false;
			btnSuaCT.Enabled = true;
			btnXoaCT.Enabled = true;
			if (lvCTPN.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvCTPN.SelectedItems[0];
			cbMaPhieu.Text = liv.SubItems[0].Text;
			cbMaVT.Text = liv.SubItems[1].Text;
			txtdonvi.Text = liv.SubItems[2].Text;
			txtsoluong.Text = liv.SubItems[3].Text;
		}

		#endregion
		#endregion
 

	}
}
