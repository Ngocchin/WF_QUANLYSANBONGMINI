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
    public class LoaiSanBLL
    {
        LoaiSanDAL dal = new LoaiSanDAL();
        public DataTable HienThiDuLieuLoaiSan()
        {
            return dal.HienThiDuLieuLoaiSan();
        }
        public DataTable HienThiDuLieuCbox()
        {
            return dal.LoadLoaiSanCombobox();
        }
        public bool ThemDuLieuLoaiSan(string loaisan, string tenloaisan, string gialoaisan)
        {
            return dal.ThemLoaiSan(loaisan, tenloaisan, gialoaisan);
        }
        public bool KiemTraDuLieuLoaiSan(string loaiSan)
        {
            return dal.kiemTraTonTaiLoaiSan(loaiSan);
        }
        public bool XoaDuLieuLoaiSan(string loaiSan)
        {
            return dal.XoaLoaiSan(loaiSan);
        }
        public bool SuaDuLieuLoaiSan(string loaisan, string tenloaisan, string gialoaisan)
        {
            return dal.SuaLoaiSan(loaisan, tenloaisan, gialoaisan);
        }
        public bool KiemTraDuLieuLoaiSan_SAN(string loaisan)
        {
            return dal.kiemTraTonTaiLoaiSan_San(loaisan);
        }
    }
}
