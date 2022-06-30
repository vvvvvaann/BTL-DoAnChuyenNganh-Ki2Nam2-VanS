using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class DanhSachLuongNhanVien : Form
    {
        public DanhSachLuongNhanVien()
        {
            InitializeComponent();
        }
        LuongNhanVien_DTO LNV = new LuongNhanVien_DTO();
        LuongNhanVien_BUS lnv = new LuongNhanVien_BUS();
        private void DanhSachLuongNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load ThoiGian
                Data da = new Data();
                string sql = "select DISTINCT ThoiGian from LuongNhanVien";
                cbThoiGian.DataSource = da.GetTable(sql);
                cbThoiGian.DisplayMember = "ThoiGian";
                cbThoiGian.ValueMember = "ThoiGian";
                //Load LuongNhanVien
                dgvDanhSachLuongNhanVien.DataSource = lnv.HienThiLuongNhanVien();
            }
            catch
            { }
        }

        private void cbThoiGian_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                LNV.ThoiGian = DateTime.Parse(cbThoiGian.Text);
                dgvDanhSachLuongNhanVien.DataSource = lnv.PhanLoaiLuongNhanVien(LNV.ThoiGian);
            }
            catch
            { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap tu khoa", "Thong bao");
            }
            else
            {
                try
                {
                    LNV.MaNhanVien = txtTimKiem.Text;
                    dgvDanhSachLuongNhanVien.DataSource = lnv.TimKiemLuongNhanVien(LNV.MaNhanVien);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachLuongNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
