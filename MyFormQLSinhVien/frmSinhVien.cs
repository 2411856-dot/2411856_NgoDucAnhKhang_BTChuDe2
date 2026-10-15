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
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv = new QuanLySinhVien();
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem livtem = new ListViewItem(sv.MaSo);
            livtem.SubItems.Add(sv.HoTen);
            livtem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            livtem.SubItems.Add(sv.DiaChi);
            livtem.SubItems.Add(sv.Lop);

            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";

            livtem.SubItems.Add(gt);

            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";

            cn = cn.Substring(0, cn.Length - 1);

            livtem.SubItems.Add(cn);
            livtem.SubItems.Add(sv.Hinh);

            this.lvSinhVien.Items.Add(livtem);
        }

        private void LoadListView()
        {

            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();

            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = this.txtHinh.Text;

            if (rdNu.Checked)
                gt = false;

            sv.GioiTinh = gt;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            }

            sv.ChuyenNganh = cn;

            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();

            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;

            sv.GioiTinh = false;

            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;

            List<string> cn = new List<string>();

            string[] s = lvitem.SubItems[6].Text.Split(',');

            foreach (string t in s)
                cn.Add(t);

            sv.ChuyenNganh = cn;

            sv.Hinh = lvitem.SubItems[7].Text;

            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;

            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }

            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
                }
            }
        }

        private void groupboxTTSV_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
            CapNhatTongSinhVien();
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboLop.Text = this.cboLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for(i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Selected)
                {
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
                    
                }

            }
            this.LoadListView();
            CapNhatTongSinhVien();
            this.btnMacDinh.PerformClick();
        }
        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MaSo.CompareTo(sv1);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialogHinh.Filter =
       "Image File (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            if (OpenFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = OpenFileDialogHinh.FileName;
                pbHinh.ImageLocation = OpenFileDialogHinh.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            qlsv.Them(sv);
            LoadListView();
            CapNhatTongSinhVien();
            MessageBox.Show("Thêm sinh viên thành công!");
        }
        private void CapNhatTongSinhVien()
        {
            lblTongSinhVien.Text = "Tổng Sinh Viên: " + qlsv.dsSinhVien.Count;
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {

        }

        private void mnuMoFile_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuThem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = lvSinhVien.Font;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.Font = fd.Font;
            }
        }

        private void mnuMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = lvSinhVien.ForeColor;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.ForeColor = cd.Color;
            }
        }

        private void mnuContextFont_Click(object sender, EventArgs e)
        {
            mnuFont.PerformClick();
        }

        private void mnuContextMauChu_Click(object sender, EventArgs e)
        {
            mnuMauChu.PerformClick();
        }
        private void TimKiem()
        {
            frmTuyChon frm = new frmTuyChon(qlsv,this.lvSinhVien);
            frm.ShowDialog();   
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(qlsv, this.lvSinhVien);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadListView();
            }
        }

        private void mnuContextTimKiem_Click(object sender, EventArgs e)
        {
            mnuTimKiem.PerformClick();
        }

        private void mnuSapXep_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(qlsv,this.lvSinhVien);
            frm.ShowDialog();
        }

        private void mnuContextSapXep_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(qlsv,this.lvSinhVien);
            frm.ShowDialog();
        }
    }
}
