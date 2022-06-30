using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class QuanLyLuongNhanVien : Form
    {
        public QuanLyLuongNhanVien()
        {
            InitializeComponent();
        }
        LuongNhanVien_DTO LNV = new LuongNhanVien_DTO();
        LuongNhanVien_BUS lnv = new LuongNhanVien_BUS();
        NhanVien_DTO NV = new NhanVien_DTO();
        NhanVien_BUS nv = new NhanVien_BUS();
        GiaoDich_DTO GD = new GiaoDich_DTO();
        GiaoDich_BUS gd = new GiaoDich_BUS();
        DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load MaNhanVien
                Data da = new Data();
                string sql = "select MaNhanVien from NhanVien";
                cbMaNhanVien.DataSource = da.GetTable(sql);
                cbMaNhanVien.DisplayMember = "MaNhanVien";
                cbMaNhanVien.ValueMember = "MaNhanVien";
            }
            catch
            { }
        }

        private void cbMaNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Load TenNhanVien
                NV.MaNhanVien = cbMaNhanVien.Text;
            }
            catch
            { }
            try
            {
                txtTenNhanVien.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["TenNhanVien"].ToString();
            }
            catch
            { }   
        }

        private void btnTinhTienLuong_Click(object sender, EventArgs e)
        {
            try
            {
                //Load ThoiGian
                DateTime tg = DateTime.Today;
                txtThoiGian.Text = tg.ToString("MM/dd/yyyy");
                LNV.ThoiGian = DateTime.Parse(txtThoiGian.Text);
                //DoanhSo
                try
                {
                    LNV.DoanhSo = lnv.TinhLuongNhanVien(cbMaNhanVien.Text);
                }
                catch
                {
                    MessageBox.Show("Nhan vien nay chua co doanh so");
                    LNV.DoanhSo = 0;
                }
                txtDoanhSo.Text = string.Format("{0:0,0}", decimal.Parse(LNV.DoanhSo.ToString()));
                //Load TongLuong
                LNV.LuongCoBan = float.Parse(txtLuongCoBan.Text);
                LNV.TongLuong = LNV.LuongCoBan + (LNV.DoanhSo * 10 / 100);
                txtTongLuong.Text = string.Format("{0:0,0}", decimal.Parse(LNV.TongLuong.ToString()));
            }
            catch
            { }
        }

        private void btnThanhToanLuongNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Sau khi thanh toan luong nhan vien se khong the sua!", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    LNV.MaNhanVien = cbMaNhanVien.Text;
                    LNV.ThoiGian = DateTime.Parse(txtThoiGian.Text);
                    GD.MaGiaoDich = gd.InsertGiaoDich();
                    LNV.LuongCoBan = float.Parse(txtLuongCoBan.Text);
                    LNV.DoanhSo = float.Parse(txtDoanhSo.Text);
                    LNV.TongLuong = float.Parse(txtTongLuong.Text);
                    lnv.ThemLuongNhanVien(LNV.MaNhanVien, LNV.ThoiGian, GD.MaGiaoDich, LNV.LuongCoBan, LNV.DoanhSo, LNV.TongLuong);
                    string noiDung = "Thanh toan luong nhan vien";
                    float stt = 0;
                    gd.UpdateGiaoDich(GD.MaGiaoDich, LNV.TongLuong, noiDung);
                    ds.ThemDoanhSo(GD.MaGiaoDich, stt, LNV.TongLuong);
                    MessageBox.Show("Thanh toan luong nhan vien thanh cong", "Thong bao");
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
    }
}
