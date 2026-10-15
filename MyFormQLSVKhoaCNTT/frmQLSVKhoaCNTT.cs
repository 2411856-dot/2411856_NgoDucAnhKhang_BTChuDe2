using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormQLSVKhoaCNTT
{
    public partial class frmQLSVKhoaCNTT : Form
    {
        ArrayList dsSinhVien = new ArrayList();
        bool daThayDoi = false;


        public frmQLSVKhoaCNTT()
        {
            InitializeComponent();

           
        }
        


        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openfileDialogHinh.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if(openfileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openfileDialogHinh.FileName;
                pbHinh.Image = Image.FromFile(txtHinh.Text);
            }
                
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.dtpNgaySinh.Value = new DateTime(2021, 1, 21);
            this.rdNam.Checked = true;
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.mtxtSoDienThoai.Text = "";
            pbHinh.Image = null;
            pbHinh.ImageLocation = null;
            this.txtHinh.Text = "";


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private int TimSinhVienTheoMSSV(string mssv)
        {
           for(int i = 0; i< dsSinhVien.Count; i++)
            {
                SInhVien sv = dsSinhVien[i] as SInhVien;
                if(sv.MSSV == mssv)
                {
                    return i;
                }
            }
           return -1;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SInhVien sv = GetSinhVien();

            if (string.IsNullOrWhiteSpace(sv.MSSV))
            {
                MessageBox.Show("Vui lòng nhập MSSV!");
                mtxtMSSV.Focus();
                return;
            }


            int viTri = TimSinhVienTheoMSSV(sv.MSSV);

            if (viTri == -1)
            {
                // Không tìm thấy → thêm mới
                dsSinhVien.Add(sv);

                MessageBox.Show("Thêm sinh viên thành công!");
            }
            else
            {
                // Tìm thấy → cập nhật
                dsSinhVien[viTri] = sv;

                MessageBox.Show("Cập nhật sinh viên thành công!");
            }
            daThayDoi = true;

            LoadListView();

        }
        private SInhVien GetSinhVien()
        {
            SInhVien sv = new SInhVien();
            sv.MSSV = mtxtMSSV.Text.Trim();
            sv.HoTen = txtHoTen.Text.Trim();
            if(rdNam.Checked)
                sv.Phai = true;
            else
                sv.Phai = false;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = cboLop.Text;
            sv.SoDienThoai = mtxtSoDienThoai.Text;
            sv.Email = txtEmail.Text.Trim();
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.Hinh = txtHinh.Text.Trim();
            return sv;
        }
        private void ThemSV(SInhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MSSV);
            item.SubItems.Add(sv.HoTen);
            string phai = "Nữ";
            if (sv.Phai)
                phai = "Nam";
            item.SubItems.Add(phai);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.SoDienThoai);
            item.SubItems.Add(sv.Email);
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Hinh);

            lvSinhVien.Items.Add(item);

        }
        private void LoadListView()
        {
            lvSinhVien.Items.Clear();
            foreach(SInhVien sv in dsSinhVien)
            {
                ThemSV(sv);
            }
        }
        private SInhVien GetSinhVienFromListView(ListViewItem item)
        {
            SInhVien sv = new SInhVien();
            sv.MSSV = item.SubItems[0].Text;
            sv.HoTen = item.SubItems[1].Text;
            if (item.SubItems[2].Text == "Nam")
                sv.Phai = true;
            else
                sv.Phai = false;
            sv.NgaySinh = DateTime.ParseExact(item.SubItems[3].Text,"dd/MM/yyyy", null);
            sv.Lop = item.SubItems[4].Text;
            sv.SoDienThoai = item.SubItems[5].Text;
            sv.Email = item.SubItems[6].Text;
            sv.DiaChi = item.SubItems[7].Text;
            sv.Hinh = item.SubItems[8].Text;
            return sv;

        }
        private void HienThiSinhVien(SInhVien sv)
        {
            mtxtMSSV.Text = sv.MSSV;
            txtHoTen.Text = sv.HoTen;
            if (sv.Phai)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboLop.Text = sv.Lop;
            mtxtSoDienThoai.Text = sv.SoDienThoai;
            txtEmail.Text = sv.Email;
            txtDiaChi.Text = sv.DiaChi;
            txtHinh.Text = sv.Hinh;
            if (!string.IsNullOrWhiteSpace(sv.Hinh)&& File.Exists(sv.Hinh))
            {
                pbHinh.ImageLocation = sv.Hinh;
            }
            else
            {
                pbHinh.Image = null;
            }

           


        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                SInhVien sv = GetSinhVienFromListView(item);
                HienThiSinhVien(sv);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                // Xóa từ cuối về đầu để tránh lỗi vị trí
                for (int i = lvSinhVien.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = lvSinhVien.SelectedItems[i];

                    string mssv = item.SubItems[0].Text;

                    int viTri = TimSinhVienTheoMSSV(mssv);

                    if (viTri != -1)
                    {
                        dsSinhVien.RemoveAt(viTri);
                    }
                }
                daThayDoi = true;

                LoadListView();

                btnMacDinh.PerformClick();

                MessageBox.Show("Xóa sinh viên thành công!");
            }

        }
        private void DocFile()
        {
            dsSinhVien.Clear();

            string fileName = "DSNV.txt";

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy tập tin DSNV.txt!");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split('|');

                if (data.Length < 9)
                    continue;

                SInhVien sv = new SInhVien();

                sv.MSSV = data[0];
                sv.HoTen = data[1];

                if (data[2] == "Nam")
                    sv.Phai = true;
                else
                    sv.Phai = false;

                sv.NgaySinh = DateTime.ParseExact(
                    data[3],
                    "dd/MM/yyyy",
                    null);

                sv.Lop = data[4];
                sv.SoDienThoai = data[5];
                sv.Email = data[6];
                sv.DiaChi = data[7];
                sv.Hinh = data[8];

                dsSinhVien.Add(sv);
            }

            LoadListView();

        }

        private void frmQLSVKhoaCNTT_Load(object sender, EventArgs e)
        {
            DocFile();
        }

        private void mnuTaiLai_Click(object sender, EventArgs e)
        {
            DocFile();

            MessageBox.Show(
                "Đã tải lại danh sách sinh viên!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void LuuFile()
        {
            List<string> lines = new List<string>();

            foreach (SInhVien sv in dsSinhVien)
            {
                string phai = sv.Phai ? "Nam" : "Nữ";

                string line =
                    sv.MSSV + "|" +
                    sv.HoTen + "|" +
                    phai + "|" +
                    sv.NgaySinh.ToString("dd/MM/yyyy") + "|" +
                    sv.Lop + "|" +
                    sv.SoDienThoai + "|" +
                    sv.Email + "|" +
                    sv.DiaChi + "|" +
                    sv.Hinh;

                lines.Add(line);
            }

            File.WriteAllLines("DSNV.txt", lines);
        }

        private void frmQLSVKhoaCNTT_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmQLSVKhoaCNTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (daThayDoi)
            {
                DialogResult kq = MessageBox.Show(
                    "Danh sách sinh viên đã được thay đổi.\n" +
                    "Bạn có muốn lưu lại không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    LuuFile();
                }
                else if (kq == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }

}
