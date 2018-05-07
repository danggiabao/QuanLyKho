namespace QuanLyKho
{
    partial class frmTrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVT = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnVT);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 613);
            this.panel1.TabIndex = 0;
            // 
            // btnVT
            // 
            this.btnVT.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVT.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVT.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVT.Image = global::QuanLyKho.Properties.Resources.icons8_commodity_100;
            this.btnVT.Location = new System.Drawing.Point(535, 133);
            this.btnVT.Name = "btnVT";
            this.btnVT.Size = new System.Drawing.Size(286, 173);
            this.btnVT.TabIndex = 9;
            this.btnVT.Text = "Quản lý vật tư";
            this.btnVT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVT.UseVisualStyleBackColor = false;
            this.btnVT.Click += new System.EventHandler(this.btnVT_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNhap.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNhap.Image = global::QuanLyKho.Properties.Resources.icons8_important_property_100;
            this.btnNhap.Location = new System.Drawing.Point(241, 312);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(288, 173);
            this.btnNhap.TabIndex = 8;
            this.btnNhap.Text = "Quản lý Nhập kho";
            this.btnNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuat.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXuat.Image = global::QuanLyKho.Properties.Resources.icons8_purchase_order_100;
            this.btnXuat.Location = new System.Drawing.Point(535, 312);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(286, 173);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Quản lý xuất kho";
            this.btnXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lựa chọn chức năng";
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKho.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKho.Image = global::QuanLyKho.Properties.Resources.icons8_warehouse_100;
            this.btnKho.Location = new System.Drawing.Point(241, 133);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(288, 173);
            this.btnKho.TabIndex = 0;
            this.btnKho.Text = "Quản lý kho";
            this.btnKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 613);
            this.Controls.Add(this.panel1);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnVT;
    }
}