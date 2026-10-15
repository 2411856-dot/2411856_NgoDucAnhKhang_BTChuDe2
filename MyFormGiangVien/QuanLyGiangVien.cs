using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormGiangVien
{
    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien;

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        // Indexer cho phép truy cập qlgv[i]
        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }
            set { dsGiangVien[index] = value; }
        }

        // Tìm giảng viên theo điều kiện truyền từ Delegate
        public GiangVien Tim(object temp, SoSanh ss)
        {
            foreach (GiangVien gv in dsGiangVien)
            {
                if (ss(temp, gv) == 0)
                    return gv;
            }
            return null;
        }

        // Thêm giảng viên (trả về false nếu trùng mã)
        public bool Them(GiangVien gv)
        {
            // Kiểm tra xem mã đã tồn tại hay chưa
            bool tonTai = dsGiangVien.Exists(x => x.MaSo == gv.MaSo);
            if (tonTai)
                return false;

            dsGiangVien.Add(gv);
            return true;
        }

        // Sắp xếp
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < dsGiangVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsGiangVien.Count; j++)
                {
                    if (ss(dsGiangVien[i], dsGiangVien[j]) > 0)
                    {
                        GiangVien temp = dsGiangVien[i];
                        dsGiangVien[i] = dsGiangVien[j];
                        dsGiangVien[j] = temp;
                    }
                }
            }
        }

        // Xóa giảng viên
        public GiangVien Xoa(object temp, SoSanh ss)
        {
            for (int i = dsGiangVien.Count - 1; i >= 0; i--)
            {
                if (ss(temp, dsGiangVien[i]) == 0)
                {
                    GiangVien gvDaXoa = dsGiangVien[i];
                    dsGiangVien.RemoveAt(i);
                    return gvDaXoa;
                }
            }
            return null;
        }
    }
}
