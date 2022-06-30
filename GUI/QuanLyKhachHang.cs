﻿using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        KhachHang_DTO KH = new KhachHang_DTO();
        KhachHang_BUS kh = new KhachHang_BUS();
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                //Load KhachHang
                dgvQuanLyKhachHang.DataSource = kh.ShowKhachHang();
            }
            catch
            { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KH.MaKhachHang = Int32.Parse(txtMaKhachHang.Text);
                KH.TenKhachHang = txtTenKhachHang.Text;
                KH.SoDienThoai = txtSoDienThoai.Text;
                kh.UpdateKhachHang(KH.MaKhachHang, KH.TenKhachHang, KH.SoDienThoai);
                MessageBox.Show("Sua khach hang thanh cong", "Thong bao");
                dgvQuanLyKhachHang.DataSource = kh.ShowKhachHang();
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    KH.MaKhachHang = Int32.Parse(txtMaKhachHang.Text);
                    kh.DeleteKhachHang(KH.MaKhachHang);
                    MessageBox.Show("Xoa khach hang thanh cong", "Thong bao");
                    dgvQuanLyKhachHang.DataSource = kh.ShowKhachHang();
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanLyKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaKhachHang.Text = dgvQuanLyKhachHang.Rows[dong].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvQuanLyKhachHang.Rows[dong].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvQuanLyKhachHang.Rows[dong].Cells[2].Value.ToString();
            }
            catch
            { }
        }
    }
}