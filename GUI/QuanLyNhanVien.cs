using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        NhanVien_DTO NV = new NhanVien_DTO();
        NhanVien_BUS nv = new NhanVien_BUS();

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load GioiTinh
                Data da = new Data();
                string sql = "select * from GioiTinh";
                cbGioiTinh.DataSource = da.GetTable(sql);
                cbGioiTinh.DisplayMember = "GioiTinh";
                cbGioiTinh.ValueMember = "GioiTinh";
                //Load MaChucVu
                Data da2 = new Data();
                string sql2 = "select * from ChucVu";
                cbMaChucVu.DataSource = da2.GetTable(sql2);
                cbMaChucVu.DisplayMember = "MaChucVu";
                cbMaChucVu.ValueMember = "MaChucVu";
                //Load dgv
                dgvQuanLyNhanVien.DataSource = nv.ShowNhanVien();
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NV.MaNhanVien = txtMaNhanVien.Text;
                NV.TenNhanVien = txtTenNhanVien.Text;
                NV.SoDienThoai = txtSoDienThoai.Text;
                NV.NamSinh = Int32.Parse(txtNamSinh.Text);
                try
                {
                    NV.GioiTinh = cbGioiTinh.SelectedValue.ToString();
                }
                catch
                {
                    NV.GioiTinh = cbGioiTinh.Text;
                }
                NV.DiaChi = txtDiaChi.Text;
                try
                {
                    NV.MaChucVu = cbMaChucVu.SelectedValue.ToString();
                }
                catch
                {
                    NV.MaChucVu = cbMaChucVu.Text;
                }
                nv.InsertNhanVien(NV.MaNhanVien, NV.TenNhanVien, NV.SoDienThoai, NV.NamSinh, NV.GioiTinh, NV.DiaChi, NV.MaChucVu);
                MessageBox.Show("Them nhan vien thanh cong!", "Thong bao");
                dgvQuanLyNhanVien.DataSource = nv.ShowNhanVien();
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NV.MaNhanVien = txtMaNhanVien.Text;
                NV.TenNhanVien = txtTenNhanVien.Text;
                NV.SoDienThoai = txtSoDienThoai.Text;
                NV.NamSinh = Int32.Parse(txtNamSinh.Text);
                try
                {
                    NV.GioiTinh = cbGioiTinh.SelectedValue.ToString();
                }
                catch
                {
                    NV.GioiTinh = cbGioiTinh.Text;
                }
                NV.DiaChi = txtDiaChi.Text;
                try
                {
                    NV.MaChucVu = cbMaChucVu.SelectedValue.ToString();
                }
                catch
                {
                    NV.MaChucVu = cbMaChucVu.Text;
                }
                nv.UpdateNhanVien(NV.MaNhanVien, NV.TenNhanVien, NV.SoDienThoai, NV.NamSinh, NV.GioiTinh, NV.DiaChi, NV.MaChucVu);
                MessageBox.Show("Sua nhan vien thanh cong!", "Thong bao");
                dgvQuanLyNhanVien.DataSource = nv.ShowNhanVien(); 
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NV.MaNhanVien = txtMaNhanVien.Text;
                nv.DeleteNhanVien(NV.MaNhanVien);
                MessageBox.Show("Xoa nhan vien thanh cong!", "Thong bao");
                dgvQuanLyNhanVien.DataSource = nv.ShowNhanVien(); 
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanLyNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaNhanVien.Text = dgvQuanLyNhanVien.Rows[dong].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvQuanLyNhanVien.Rows[dong].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvQuanLyNhanVien.Rows[dong].Cells[2].Value.ToString();
                txtNamSinh.Text = dgvQuanLyNhanVien.Rows[dong].Cells[3].Value.ToString();
                cbGioiTinh.SelectedValue = dgvQuanLyNhanVien.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvQuanLyNhanVien.Rows[dong].Cells[5].Value.ToString();
                cbMaChucVu.SelectedValue = dgvQuanLyNhanVien.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            { }
        }
    }
}
