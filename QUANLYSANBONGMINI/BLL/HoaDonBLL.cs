using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANBONGMINI.DAL;
namespace QUANLYSANBONGMINI.BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();
        public bool KetQuaTruyVan { get; set; }
        public string ThongBaoTruyVan { get; set; }
        public DataTable HienThiDuLieu()
        {
            return dal.HienThiDuLieu();
        }
        public bool ThemDuLieuHoaDon(string makh, string masan, DateTime ngaylaphd, double tongphutda, float dongia, float thanhtien)
        {
            return dal.ThemHoaDon(makh, masan, ngaylaphd, tongphutda, dongia, thanhtien);
        }
        public bool ThemHoaDon(string masan, string makh, DateTime thoiGianBatDau, double tongphutda, int donGia, int thanhTien)
        {
            KetQuaTruyVan = dal.ThemHD(masan, makh, thoiGianBatDau, tongphutda, donGia, thanhTien);
            ThongBaoTruyVan = dal.ThongBaoTruyVan;
            return KetQuaTruyVan;
        }
        public DataTable HienThiDuLieuTheoNam(string nam)
        {
            return dal.HienThiThongKeNam(nam);
        }
        public DataTable HienThiDuLieuTheoThang(string thang, string nam)
        {
            return dal.HienThiThongKeThang(thang, nam);
        }
        public bool KiemTraDuLieuHD(string maHD)
        {
            return dal.kiemTraTonTai(maHD);
        }
        public bool XoaDuLieuHD(string maHD)
        {
            return dal.XoaHD(maHD);
        }
        public bool SuaDuLieuHD(string maHD, string makh, string masan, string date, string tongphutda, string dongia, string tongtien)
        {
            return dal.SuaHD(maHD, makh, masan, date, tongphutda, dongia, tongtien);
        }
        public DataTable HienThiDuLieuCboxKH()
        {
            return dal.LoadMaKHCombobox();
        }
    }
}
