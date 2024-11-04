using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private List<DichVu> danhSachDichVu = new List<DichVu>();
        private int maKhachHangTuTang = 1;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            danhSachDichVu.Add(new DichVu { MaDichVu = 1, TenDichVu = "Dịch vụ A", GiaTien = 100 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 2, TenDichVu = "Dịch vụ B", GiaTien = 200 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 3, TenDichVu = "Dịch vụ C", GiaTien = 300 });

            UpdateServiceGrid();
        }

        private void UpdateCustomerGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachKhachHang;
        }

        private void UpdateServiceGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = danhSachDichVu;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return;
            }

            var khachHangMoi = new KhachHang
            {
                MaKhachHang = maKhachHangTuTang++,
                Ten = txtTen.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text
            };

            danhSachKhachHang.Add(khachHangMoi);
            UpdateCustomerGrid();
            ClearCustomerInputFields();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.CurrentRow != null)
            {
                var khachHang = (KhachHang)dataGridView1.CurrentRow.DataBoundItem;
                khachHang.Ten = txtTen.Text;
                khachHang.SoDienThoai = txtSoDienThoai.Text;
                khachHang.DiaChi = txtDiaChi.Text;
                UpdateCustomerGrid();
                ClearCustomerInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để chỉnh sửa.");
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.CurrentRow != null)
            {
                var khachHang = (KhachHang)dataGridView1.CurrentRow.DataBoundItem;
                danhSachKhachHang.Remove(khachHang);
                UpdateCustomerGrid();
                ClearCustomerInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
            }
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.CurrentRow != null && dataGridView2.CurrentRow != null)
            {
                var khachHang = (KhachHang)dataGridView1.CurrentRow.DataBoundItem;
                var dichVu = (DichVu)dataGridView2.CurrentRow.DataBoundItem;

                var maHoaDon = new Random().Next(1000, 9999); 
                var tongTien = dichVu.GiaTien; 

                string chiTietHoaDon = $"Hóa đơn #{maHoaDon}\nKhách hàng: {khachHang.Ten}\nDịch vụ: {dichVu.TenDichVu}\nTổng tiền: {tongTien} VNĐ";
                MessageBox.Show(chiTietHoaDon);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng và dịch vụ.");
            }
        }

        private void ClearCustomerInputFields()
        {
            txtTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var khachHang = (KhachHang)dataGridView1.CurrentRow.DataBoundItem;
                txtTen.Text = khachHang.Ten;
                txtSoDienThoai.Text = khachHang.SoDienThoai;
                txtDiaChi.Text = khachHang.DiaChi;
            }
        }
    }

    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
    }

    public class DichVu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal GiaTien { get; set; }
    }
}
