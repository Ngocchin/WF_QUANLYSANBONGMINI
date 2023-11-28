using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSANBONGMINI.DAL
{
    public class AccountDAL
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoi kn = new KetNoi();
       
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM Account";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool ThemAccount(string username, string display, string password, string quyen)
        {
            string sqlThem = "INSERT INTO [Account] ([UserName], [DisplayName],[PassWord], [Quyen]) VALUES ('" + username + "',N'" + display + "', '" + password + "',N'" + quyen + "')";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maAcc)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT UserName FROM Account where UserName='" + maAcc + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maAcc == dr.GetString(0))
                    {
                        tatkt = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }
        public bool XoaAccount(string maAcc)
        {
            string sqlXoa = "DELETE FROM Account WHERE UserName= '" + maAcc + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaAccount(string username, string display, string password, string quyen)
        {
            string sqlSua = "UPDATE Account set DisplayName= N'" + display + "', PassWord= '" + password + "',Quyen = N'" + quyen + "' where UserName= '" + username + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public DataTable HienThiDuLieuTimKiem(string maAcc) //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM Account where UserName LIKE '%" + maAcc + "%' OR DisplayName LIKE'%" + maAcc + "%' OR Quyen LIKE'%" + maAcc + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
