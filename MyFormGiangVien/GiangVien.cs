using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MyFormGiangVien
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }

    // 2. Delegate So Sánh
    public delegate int SoSanh(object a, object b);
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhSachHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;

        public GiangVien()
        {
            dsHocPhan = new DanhSachHocPhan();
            NgoaiNgu = new string[20];
        }
        public GiangVien(string maso, string sdt, string mail, string hoten, DateTime ngaysinh, DanhSachHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
            this.GioiTinh = gt;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                + "Họ tên:" + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh + "\n"
                + "Giới tính: " + GioiTinh + "\n"
                + "Số ĐT:" + SoDT + "\n"
                + "Mail: " + Mail + "\n";
            string snngoaingu = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
            {
                snngoaingu += t + ";";
            }
                string monDay = " Danh sách môn dạy: ";
                foreach (HocPhan hp in dsHocPhan.ds)
                {
                    monDay += hp + ";";
                }
                    s += "\n" + snngoaingu + "\n" + monDay;

            return s;
        }

    }
}
