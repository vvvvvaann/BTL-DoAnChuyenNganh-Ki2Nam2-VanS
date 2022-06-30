using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLyGioiTinh : Form
    {
        public QuanLyGioiTinh()
        {
            InitializeComponent();
        }
        GioiTinh_DTO GT = new GioiTinh_DTO();
        GioiTinh_BUS gt = new GioiTinh_BUS();

        private void QuanLyGioiTinh_Load(object sender, EventArgs e)
        {
            try
            {
                //Load GioiTinh
                dgvQuanLyGioiTinh.DataSource = gt.ShowGioiTinh();
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GT.GioiTinh = txtGioiTinh.Text;
                gt.InsertGioiTinh(GT.GioiTinh);
                MessageBox.Show("Them gioi tinh thanh cong", "Thong bao");
                dgvQuanLyGioiTinh.DataSource = gt.ShowGioiTinh();
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                GT.GioiTinh = txtGioiTinh.Text;
                gt.DeleteGioiTinh(GT.GioiTinh);
                MessageBox.Show("Xoa gioi tinh thanh cong", "Thong bao");
                dgvQuanLyGioiTinh.DataSource = gt.ShowGioiTinh();
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanLyGioiTinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtGioiTinh.Text = dgvQuanLyGioiTinh.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            { }
        }
    }
}
