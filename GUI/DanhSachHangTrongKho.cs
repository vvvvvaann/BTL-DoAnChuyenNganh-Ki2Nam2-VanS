using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class DanhSachHangTrongKho : Form
    {
        public DanhSachHangTrongKho()
        {
            InitializeComponent();
        }
        HangHoa_DTO HH = new HangHoa_DTO();
        HangHoa_BUS hh = new HangHoa_BUS();
        private void DanhSachHangTrongKho_Load(object sender, EventArgs e)
        {
            try
            {
                //Load KichThuoc
                Data da = new Data();
                string sql = "select * from KichThuoc";
                cbKichThuoc.DataSource = da.GetTable(sql);
                cbKichThuoc.DisplayMember = "KichThuoc";
                cbKichThuoc.ValueMember = "KichThuoc";
                //Load MaLoaiHangHoa
                Data da2 = new Data();
                string sql2 = "select * from LoaiHangHoa";
                cbMaLoaiHangHoa.DataSource = da2.GetTable(sql2);
                cbMaLoaiHangHoa.DisplayMember = "TenHangHoa";
                cbMaLoaiHangHoa.ValueMember = "MaLoaiHangHoa";
                //Load HangHoa
                dgvDanhSachHangTrongKho.DataSource = hh.ShowHangHoa();
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
                    HH.TenHangHoa = txtTimKiem.Text;
                    dgvDanhSachHangTrongKho.DataSource = hh.TimHangHoa(HH.TenHangHoa);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachHangTrongKho_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKichThuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                HH.KichThuoc = Int32.Parse(cbKichThuoc.Text);
                dgvDanhSachHangTrongKho.DataSource = hh.PhanLoaiHangHoaKichThuoc(HH.KichThuoc);
            }
            catch
            { }
        }

        private void cbMaLoaiHangHoa_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                HH.MaLoaiHangHoa = cbMaLoaiHangHoa.Text;
                dgvDanhSachHangTrongKho.DataSource = hh.PhanLoaiHangHoaMaLoai(HH.MaLoaiHangHoa);
            }
            catch
            { }
        }
    }
}
