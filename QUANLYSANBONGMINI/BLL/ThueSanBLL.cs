using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANBONGMINI.DAL;
using static QUANLYSANBONGMINI.DAL.QuanLySanBong;

namespace QUANLYSANBONGMINI.BLL
{
    public class ThueSanBLL
    {
        ThueSanDAL thueSan = new ThueSanDAL();
        public DataTable HienThiDuLieu()
        {
            return thueSan.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuCbox()
        {
            return thueSan.LoadMaSanCombobox();
        }
        public DataTable HienThiDuLieuCboxKH()
        {
            return thueSan.LoadMaKHCombobox();
        }
        public bool KiemTraDuLieuSAN1()
        {
            return thueSan.kiemTraSan1();
        }
        public bool ThemDuLieuThueSan(string masan, string makh, string ngaythuesan, string gioBD, string gioKT)
        {
            return thueSan.ThemThueSan(masan, makh, ngaythuesan, gioBD, gioKT);
        }
        public bool KiemTraDuLieuThueSan(string maThuesan)
        {
            return thueSan.kiemTraTonTai(maThuesan);
        }
        public bool KetQuaTruyVan { get; set; }
        public string ThongBaoTruyVan { get; set; }
        public DataTable CheckSuDung(string Ma_San, DateTime thoiGianBatDau)
        {
            KetQuaTruyVan = thueSan.KetQuaTruyVan;
            ThongBaoTruyVan = thueSan.ThongBaoTruyVan;
            return thueSan.CheckSuDung(Ma_San, thoiGianBatDau);
        }
        public bool ThueSanTrucTiep(string masan, string makh, string loaithue, int dongia)
        {
            KetQuaTruyVan = thueSan.ThueSanTrucTiep(masan, makh, loaithue, dongia);
            ThongBaoTruyVan = thueSan.ThongBaoTruyVan;
            return KetQuaTruyVan;
        }
        public bool DatSan(string masan, string makh, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string loaiThue, int donGia, int thanhTien)
        {
            KetQuaTruyVan = thueSan.DatSan(masan, makh, thoiGianBatDau, thoiGianKetThuc, loaiThue, donGia, thanhTien);
            ThongBaoTruyVan = thueSan.ThongBaoTruyVan;
            return KetQuaTruyVan;
        }
        public bool TraSan(int Ma_ThueSan, DateTime thoiGianKetThuc, int donGia, int thanhTien)
        {
            KetQuaTruyVan = thueSan.TraSan(Ma_ThueSan, thoiGianKetThuc, donGia, thanhTien);
            ThongBaoTruyVan = thueSan.ThongBaoTruyVan;
            return KetQuaTruyVan;
        }
        public bool Xoa(int Ma_ThueSan)
        {
            KetQuaTruyVan = thueSan.Xoa(Ma_ThueSan);
            ThongBaoTruyVan = thueSan.ThongBaoTruyVan;
            return KetQuaTruyVan;
        }
    }
}
