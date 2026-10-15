using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormQLSinhVien
{
    public partial class frmTuyChon : Form
    {
        public int LoaiTimKiem = 0;

        public string ThongTinTim
        {
            get
            {
                return txtNhap.Text.Trim();
            }
        }

        private QuanLySinhVien qlsv;
        private ListView lvSinhVien;

        public frmTuyChon(QuanLySinhVien qlsv, ListView lvSinhVien)
        {
            InitializeComponent();

            this.qlsv = qlsv;
            this.lvSinhVien = lvSinhVien;

            rdMaSV.Checked = true;
        }



        private void rdMaSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaSV.Checked)
            {
                LoaiTimKiem = 0;
            }
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
            {
                LoaiTimKiem = 1;
            }
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgaySinh.Checked)
            {
                LoaiTimKiem = 2;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string thongTin = txtNhap.Text.Trim();

            if (thongTin == "")
            {
                MessageBox.Show(
                    "Hãy nhập thông tin tìm!",
                    "Lỗi nhập thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            List<SinhVien> ketQua = new List<SinhVien>();

            // Duyệt danh sách sinh viên gốc
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                bool timThay = false;

                // Tìm theo mã sinh viên
                if (rdMaSV.Checked)
                {
                    if (sv.MaSo.Equals(
                        thongTin,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        timThay = true;
                    }
                }

                // Tìm theo họ tên
                else if (rdHoTen.Checked)
                {
                    if (sv.HoTen.IndexOf(
                        thongTin,
                        StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        timThay = true;
                    }
                }

                // Tìm theo ngày sinh
                else if (rdNgaySinh.Checked)
                {
                    if (sv.NgaySinh.ToShortDateString().Contains(thongTin))
                    {
                        timThay = true;
                    }
                }

                if (timThay)
                {
                    ketQua.Add(sv);
                }
            }

            // KHÔNG TÌM THẤY
            if (ketQua.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Xóa ListView
            lvSinhVien.Items.Clear();

            // Hiển thị những sinh viên tìm được
            foreach (SinhVien sv in ketQua)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);

                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);

                string gt = "Nữ";
                if (sv.GioiTinh)
                    gt = "Nam";

                item.SubItems.Add(gt);

                string cn = "";

                foreach (string s in sv.ChuyenNganh)
                {
                    cn += s + ",";
                }

                if (cn.Length > 0)
                    cn = cn.Substring(0, cn.Length - 1);

                item.SubItems.Add(cn);
                item.SubItems.Add(sv.Hinh);

                lvSinhVien.Items.Add(item);
            }

            // Chọn dòng đầu tiên
            lvSinhVien.Items[0].Selected = true;
            lvSinhVien.Items[0].Focused = true;
            lvSinhVien.Items[0].EnsureVisible();

            // THÔNG BÁO SỐ LƯỢNG
            MessageBox.Show(
    "Số sinh viên tìm thấy: " + ketQua.Count,
    "Kết quả tìm kiếm",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private class ListViewItemComparer : System.Collections.IComparer
        {
            private int column;

            public ListViewItemComparer(int column)
            {
                this.column = column;
            }

            public int Compare(object x, object y)
            {
                ListViewItem item1 = x as ListViewItem;
                ListViewItem item2 = y as ListViewItem;

                string value1 = item1.SubItems[column].Text;
                string value2 = item2.SubItems[column].Text;

                if (column == 2)
                {
                    DateTime d1, d2;

                    if (DateTime.TryParse(value1, out d1) &&
                        DateTime.TryParse(value2, out d2))
                    {
                        return DateTime.Compare(d1, d2);
                    }
                }

                return String.Compare(
                    value1,
                    value2,
                    StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            int column = 0;

            if (rdMaSV.Checked)
                column = 0;
            else if (rdHoTen.Checked)
                column = 1;
            else if (rdNgaySinh.Checked)
                column = 2;

            lvSinhVien.ListViewItemSorter =
                new ListViewItemComparer(column);

            lvSinhVien.Sort();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
