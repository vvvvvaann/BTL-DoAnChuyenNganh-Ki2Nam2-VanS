using System;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class DanhSachDoanhSo : Form
    {
        public DanhSachDoanhSo()
        {
            InitializeComponent();
        }
        DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        GiaoDich_DTO GD = new GiaoDich_DTO();
        GiaoDich_BUS gd = new GiaoDich_BUS();
        private void DanhSachDoanhSo_Load(object sender, EventArgs e)
        {
            try
            {
                //Load DoanhSo
                dgvDanhSachDoanhSo.DataSource = ds.ShowDoanhSo();
                //Load GiaoDich
                dgvDanhSachGiaoDich.DataSource = gd.ShowGiaoDich();
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
