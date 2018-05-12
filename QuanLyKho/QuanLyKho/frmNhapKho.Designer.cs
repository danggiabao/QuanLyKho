namespace QuanLyKho
{
    partial class frmNhapKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
			this.txtSoPhieu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbMaKho = new System.Windows.Forms.ComboBox();
			this.btnRs = new System.Windows.Forms.Button();
			this.btnSuaPN = new System.Windows.Forms.Button();
			this.btnXoaPN = new System.Windows.Forms.Button();
			this.btnThemPN = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvPN = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnRsCT = new System.Windows.Forms.Button();
			this.btnXoaCT = new System.Windows.Forms.Button();
			this.btnSuaCT = new System.Windows.Forms.Button();
			this.btnThemCT = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(748, 460);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.dtNgayLap);
			this.tabPage1.Controls.Add(this.txtSoPhieu);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.cbMaKho);
			this.tabPage1.Controls.Add(this.btnRs);
			this.tabPage1.Controls.Add(this.btnSuaPN);
			this.tabPage1.Controls.Add(this.btnXoaPN);
			this.tabPage1.Controls.Add(this.btnThemPN);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(740, 432);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Phiếu nhập";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 381);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 15);
			this.label3.TabIndex = 21;
			this.label3.Text = "Ngày Lập : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 349);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Mã Kho : ";
			// 
			// dtNgayLap
			// 
			this.dtNgayLap.Location = new System.Drawing.Point(126, 376);
			this.dtNgayLap.Name = "dtNgayLap";
			this.dtNgayLap.Size = new System.Drawing.Size(200, 21);
			this.dtNgayLap.TabIndex = 19;
			// 
			// txtSoPhieu
			// 
			this.txtSoPhieu.Location = new System.Drawing.Point(126, 310);
			this.txtSoPhieu.Name = "txtSoPhieu";
			this.txtSoPhieu.ReadOnly = true;
			this.txtSoPhieu.Size = new System.Drawing.Size(121, 21);
			this.txtSoPhieu.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 310);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "Số Phiếu : ";
			// 
			// cbMaKho
			// 
			this.cbMaKho.FormattingEnabled = true;
			this.cbMaKho.Location = new System.Drawing.Point(126, 341);
			this.cbMaKho.Name = "cbMaKho";
			this.cbMaKho.Size = new System.Drawing.Size(121, 23);
			this.cbMaKho.TabIndex = 16;
			// 
			// btnRs
			// 
			this.btnRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRs.Location = new System.Drawing.Point(652, 376);
			this.btnRs.Margin = new System.Windows.Forms.Padding(2);
			this.btnRs.Name = "btnRs";
			this.btnRs.Size = new System.Drawing.Size(76, 36);
			this.btnRs.TabIndex = 9;
			this.btnRs.Text = "Reset";
			this.btnRs.UseVisualStyleBackColor = true;
			this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
			// 
			// btnSuaPN
			// 
			this.btnSuaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuaPN.Location = new System.Drawing.Point(652, 323);
			this.btnSuaPN.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaPN.Name = "btnSuaPN";
			this.btnSuaPN.Size = new System.Drawing.Size(76, 36);
			this.btnSuaPN.TabIndex = 8;
			this.btnSuaPN.Text = "Sửa";
			this.btnSuaPN.UseVisualStyleBackColor = true;
			this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
			// 
			// btnXoaPN
			// 
			this.btnXoaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaPN.Location = new System.Drawing.Point(563, 376);
			this.btnXoaPN.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoaPN.Name = "btnXoaPN";
			this.btnXoaPN.Size = new System.Drawing.Size(76, 36);
			this.btnXoaPN.TabIndex = 7;
			this.btnXoaPN.Text = "Xóa";
			this.btnXoaPN.UseVisualStyleBackColor = true;
			this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
			// 
			// btnThemPN
			// 
			this.btnThemPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemPN.Location = new System.Drawing.Point(563, 323);
			this.btnThemPN.Margin = new System.Windows.Forms.Padding(2);
			this.btnThemPN.Name = "btnThemPN";
			this.btnThemPN.Size = new System.Drawing.Size(76, 36);
			this.btnThemPN.TabIndex = 6;
			this.btnThemPN.Text = "Thêm";
			this.btnThemPN.UseVisualStyleBackColor = true;
			this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvPN);
			this.groupBox1.Location = new System.Drawing.Point(0, 5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(742, 282);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin phiếu nhập";
			// 
			// lvPN
			// 
			this.lvPN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvPN.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPN.FullRowSelect = true;
			this.lvPN.GridLines = true;
			this.lvPN.Location = new System.Drawing.Point(2, 16);
			this.lvPN.Margin = new System.Windows.Forms.Padding(2);
			this.lvPN.Name = "lvPN";
			this.lvPN.Size = new System.Drawing.Size(738, 264);
			this.lvPN.TabIndex = 1;
			this.lvPN.UseCompatibleStateImageBehavior = false;
			this.lvPN.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Số Phiếu";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Kho";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày Lập";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 150;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.tabPage2.Controls.Add(this.btnRsCT);
			this.tabPage2.Controls.Add(this.btnXoaCT);
			this.tabPage2.Controls.Add(this.btnSuaCT);
			this.tabPage2.Controls.Add(this.btnThemCT);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(740, 432);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chi tiết phiếu nhập";
			// 
			// btnRsCT
			// 
			this.btnRsCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRsCT.Location = new System.Drawing.Point(650, 370);
			this.btnRsCT.Margin = new System.Windows.Forms.Padding(2);
			this.btnRsCT.Name = "btnRsCT";
			this.btnRsCT.Size = new System.Drawing.Size(76, 36);
			this.btnRsCT.TabIndex = 11;
			this.btnRsCT.Text = "Reset";
			this.btnRsCT.UseVisualStyleBackColor = true;
			// 
			// btnXoaCT
			// 
			this.btnXoaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaCT.Location = new System.Drawing.Point(553, 370);
			this.btnXoaCT.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoaCT.Name = "btnXoaCT";
			this.btnXoaCT.Size = new System.Drawing.Size(76, 36);
			this.btnXoaCT.TabIndex = 10;
			this.btnXoaCT.Text = "Xóa";
			this.btnXoaCT.UseVisualStyleBackColor = true;
			// 
			// btnSuaCT
			// 
			this.btnSuaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuaCT.Location = new System.Drawing.Point(650, 322);
			this.btnSuaCT.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaCT.Name = "btnSuaCT";
			this.btnSuaCT.Size = new System.Drawing.Size(76, 36);
			this.btnSuaCT.TabIndex = 9;
			this.btnSuaCT.Text = "Sửa";
			this.btnSuaCT.UseVisualStyleBackColor = true;
			// 
			// btnThemCT
			// 
			this.btnThemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemCT.Location = new System.Drawing.Point(553, 322);
			this.btnThemCT.Margin = new System.Windows.Forms.Padding(2);
			this.btnThemCT.Name = "btnThemCT";
			this.btnThemCT.Size = new System.Drawing.Size(76, 36);
			this.btnThemCT.TabIndex = 7;
			this.btnThemCT.Text = "Thêm";
			this.btnThemCT.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView1);
			this.groupBox2.Location = new System.Drawing.Point(4, 2);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(733, 291);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin chi tiết phiếu nhập";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(2, 16);
			this.listView1.Margin = new System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(729, 273);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// frmNhapKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(748, 460);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmNhapKho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập kho";
			this.Load += new System.EventHandler(this.frmNhapKho_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnRsCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtNgayLap;
		private System.Windows.Forms.TextBox txtSoPhieu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbMaKho;
		private System.Windows.Forms.Button btnRs;
		private System.Windows.Forms.Button btnSuaPN;
		private System.Windows.Forms.Button btnXoaPN;
		private System.Windows.Forms.Button btnThemPN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvPN;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}