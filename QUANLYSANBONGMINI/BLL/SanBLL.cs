using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANBONGMINI.DAL;

namespace QUANLYSANBONGMINI.BLL
{
    public class SanBLL
    {
        SanDAL dal = new SanDAL();        
        public DataTable HienThiDuLieuSan()
        {
            return dal.HienThiDuLieuSan();
        }
        public DataTable HienThiDuLieuCbox()
        {
            return dal.LoadLoaiSanCombobox();
        }
        public bool ThemDuLieuSan(string masan, string loaisan, string tensan)
        {
            return dal.ThemSan(masan, loaisan, tensan);
        }
        public bool KiemTraDuLieuSan(string maSan)
        {
            return dal.kiemTraTonTaiMaSan(maSan);
        }
        public bool XoaDuLieuSan(string maSan)
        {
            return dal.XoaSan(maSan);
        }
        public bool SuaDuLieuSan(string masan, string loaisan, string tensan)
        {
            return dal.SuaSan(masan, loaisan, tensan);
        }
        public DataTable HienThiDuLieuTimKiem(string maSan)
        {
            return dal.HienThiDuLieuTimKiem(maSan);
        }
    }
}
