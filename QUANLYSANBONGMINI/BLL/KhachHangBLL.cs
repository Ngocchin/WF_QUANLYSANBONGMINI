using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANBONGMINI.DAL;

namespace QUANLYSANBONGMINI.BLL
{
    public class KhachHangBLL
    {
       KhachHangDAL dal = new KhachHangDAL();
        public DataTable HienThiDuLieu()
        {
            return dal.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTimKiem(string maKH)
        {
            return dal.HienThiDuLieuTimKiem(maKH);
        }
        public bool ThemDuLieuKH(string makh, string tenkh, string diachi, string sdt)
        {
            return dal.ThemKH(makh, tenkh, diachi, sdt);
        }
        public bool KiemTraDuLieuKH(string makh)
        {
            return dal.kiemTraTonTai(makh);
        }
        public bool XoaDuLieuKH(string makh)
        {
            return dal.XoaKH(makh);
        }
        public bool SuaDuLieuKH(string makh, string tenkh, string diachi, string sdt)
        {
            return dal.SuaKH(makh, tenkh, diachi, sdt);
        }
    }
}
