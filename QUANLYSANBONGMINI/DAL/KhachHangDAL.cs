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
    public class KhachHangDAL
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoi kn = new KetNoi();
       
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable HienThiDuLieuTimKiem(string maKH) //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM KhachHang where Ma_KhachHang LIKE '%" + maKH + "%' OR Ten_KhachHang LIKE'%" + maKH + "%' OR Sdt_KhachHang LIKE'%" + maKH + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }        
        public bool ThemKH(string makh, string tenkh, string diachi, string sdt)
        {
            string sqlThem = "INSERT INTO [KhachHang] ([Ma_KhachHang], [Ten_KhachHang],[DiaChi_KhachHang], [Sdt_KhachHang]) VALUES ('" + makh + "',N'" + tenkh + "', N'" + diachi + "','" + sdt + "')";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maKH)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Ma_KhachHang FROM KhachHang where Ma_KhachHang='" + maKH + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maKH == dr.GetString(0))
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
        public bool XoaKH(string maKH)
        {
            string sqlXoa = "DELETE FROM KhachHang WHERE Ma_KhachHang= '" + maKH + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaKH(string makh, string tenkh, string diachi, string sdt)
        {
            string sqlSua = "UPDATE KhachHang set Ten_KhachHang= N'" + tenkh + "', DiaChi_KhachHang= N'" + diachi + "',Sdt_KhachHang = '" + sdt + "' where Ma_KhachHang= '" + makh + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
               
    }
}
