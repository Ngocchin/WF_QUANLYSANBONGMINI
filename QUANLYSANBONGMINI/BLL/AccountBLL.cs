using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSANBONGMINI.DAL;

namespace QUANLYSANBONGMINI.BLL
{
    public class AccountBLL
    {
        AccountDAL dal = new AccountDAL();
        public DataTable HienThiDuLieu()
        {
            return dal.HienThiDuLieu();
        }
        public bool ThemDuLieuAccount(string username, string display, string password, string quyen)
        {
            return dal.ThemAccount(username, display, password, quyen);
        }
        public bool KiemTraDuLieuAccount(string username)
        {
            return dal.kiemTraTonTai(username);
        }
        public bool XoaDuLieuAccount(string username)
        {
            return dal.XoaAccount(username);
        }
        public bool SuaDuLieuAccount(string username, string display, string password, string quyen)
        {
            return dal.SuaAccount(username, display, password, quyen);
        }
        public DataTable HienThiDuLieuTimKiem(string maAcc)
        {
            return dal.HienThiDuLieuTimKiem(maAcc);
        }
    }
}
