using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormGiangVien
{

    public partial class frmTimKiem : Form
    {

        private QuanLyGiangVien qlgv;
        public frmTimKiem(QuanLyGiangVien qlgv)
        {
            InitializeComponent();
            this.qlgv = qlgv;
        }

        private void rdTimMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTimMaGV.Checked) lblTimKiem.Text = "Mã GV";
        }

        private void rdTimHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTimHoTen.Checked) lblTimKiem.Text = "Họ Tên";
        }

        private void rdTimSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTimSDT.Checked) lblTimKiem.Text = "Số điện thoại";
                    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập thông tin cần tìm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            GiangVien gv = null;

            // Tìm theo Mã GV
            if (rdTimMaGV.Checked)
            {
                gv = qlgv.dsGiangVien.FirstOrDefault(
                    x => x.MaSo.Equals(tuKhoa, StringComparison.OrdinalIgnoreCase));
            }

            // Tìm theo Họ tên
            else if (rdTimHoTen.Checked)
            {
                gv = qlgv.dsGiangVien.FirstOrDefault(
                    x => x.HoTen.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Tìm theo Số điện thoại
            else if (rdTimSDT.Checked)
            {
                gv = qlgv.dsGiangVien.FirstOrDefault(
                    x => x.SoDT.Contains(tuKhoa));
            }

            // Nếu tìm thấy
            if (gv != null)
            {
                frmTBGiangVien frm = new frmTBGiangVien();

                frm.SetText(gv.ToString());

                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Không tìm thấy thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        }
    }
    
    

