using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class DanhSachKhachHang : Form
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }
        KhachHang_DTO KH = new KhachHang_DTO();
        KhachHang_BUS kh = new KhachHang_BUS();
        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                //Load KhachHang
                dgvDanhSachKhachHang.DataSource = kh.ShowKhachHang();
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
                    KH.TenKhachHang = txtTimKiem.Text;
                    dgvDanhSachKhachHang.DataSource = kh.SearchKhachHang(KH.TenKhachHang);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
