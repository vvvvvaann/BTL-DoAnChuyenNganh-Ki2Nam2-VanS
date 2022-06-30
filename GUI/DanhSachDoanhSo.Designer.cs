
namespace GUI
{
    partial class DanhSachDoanhSo
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachDoanhSo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachGiaoDich = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonBanDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoanhSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1040, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSachDoanhSo
            // 
            this.dgvDanhSachDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoDich,
            this.VonBanDau,
            this.VonHienTai,
            this.DoanhSo});
            this.dgvDanhSachDoanhSo.Location = new System.Drawing.Point(140, 260);
            this.dgvDanhSachDoanhSo.Name = "dgvDanhSachDoanhSo";
            this.dgvDanhSachDoanhSo.RowHeadersWidth = 51;
            this.dgvDanhSachDoanhSo.RowTemplate.Height = 29;
            this.dgvDanhSachDoanhSo.Size = new System.Drawing.Size(500, 400);
            this.dgvDanhSachDoanhSo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SACH DOANH SO";
            // 
            // dgvDanhSachGiaoDich
            // 
            this.dgvDanhSachGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SoTien,
            this.NoiDung});
            this.dgvDanhSachGiaoDich.Location = new System.Drawing.Point(640, 260);
            this.dgvDanhSachGiaoDich.Name = "dgvDanhSachGiaoDich";
            this.dgvDanhSachGiaoDich.RowHeadersWidth = 51;
            this.dgvDanhSachGiaoDich.RowTemplate.Height = 29;
            this.dgvDanhSachGiaoDich.Size = new System.Drawing.Size(500, 400);
            this.dgvDanhSachGiaoDich.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doanh so : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(640, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giao dich : ";
            // 
            // MaGiaoDich
            // 
            this.MaGiaoDich.DataPropertyName = "MaGiaoDich";
            this.MaGiaoDich.HeaderText = "Ma giao dich";
            this.MaGiaoDich.MinimumWidth = 6;
            this.MaGiaoDich.Name = "MaGiaoDich";
            this.MaGiaoDich.Width = 80;
            // 
            // VonBanDau
            // 
            this.VonBanDau.DataPropertyName = "VonBanDau";
            this.VonBanDau.HeaderText = "Von ban dau";
            this.VonBanDau.MinimumWidth = 6;
            this.VonBanDau.Name = "VonBanDau";
            this.VonBanDau.Width = 120;
            // 
            // VonHienTai
            // 
            this.VonHienTai.DataPropertyName = "VonHienTai";
            this.VonHienTai.HeaderText = "Von hien tai";
            this.VonHienTai.MinimumWidth = 6;
            this.VonHienTai.Name = "VonHienTai";
            this.VonHienTai.Width = 120;
            // 
            // DoanhSo
            // 
            this.DoanhSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoanhSo.DataPropertyName = "DoanhSo";
            this.DoanhSo.HeaderText = "Doanh so";
            this.DoanhSo.MinimumWidth = 6;
            this.DoanhSo.Name = "DoanhSo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaGiaoDich";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ma               giao dich                     ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "So tien";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 120;
            // 
            // NoiDung
            // 
            this.NoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Noi dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            // 
            // DanhSachDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDanhSachGiaoDich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachDoanhSo);
            this.Controls.Add(this.btnThoat);
            this.Name = "DanhSachDoanhSo";
            this.Text = "Danh Sach Doanh So";
            this.Load += new System.EventHandler(this.DanhSachDoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoanhSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachDoanhSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaoDich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonBanDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}