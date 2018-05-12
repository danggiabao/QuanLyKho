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
		int idx = 0;
		#region Controller
		private void btnThemPN_Click(object sender, EventArgs e)
		{
			idx = 1;
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
				item.SubItems.Add(cbMaKho.Text);
				item.SubItems.Add(dtNgayLap.Text);
				lvPN.Items.Add(item);
			}
		}

		private void btnSuaPN_Click(object sender, EventArgs e)
		{
			idx = 2;
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
			}
		}

		private void btnXoaPN_Click(object sender, EventArgs e)
		{
			idx = 3;
			btnThemPN.Enabled = true;
			if (lvPN.SelectedItems.Count == 0) return;
			ListViewItem liv = lvPN.SelectedItems[0];
			liv.SubItems[0].Text = txtSoPhieu.Text;
			liv.SubItems[1].Text = cbMaKho.Text;
			liv.SubItems[2].Text = dtNgayLap.Text;

			lvPN.Items.Add(liv);
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


	}
}
