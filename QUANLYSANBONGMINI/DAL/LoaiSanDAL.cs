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
    public class LoaiSanDAL
    {
        SqlConnection conn;
        KetNoi kn = new KetNoi();
        //đóng mở kết nối csdl
        DataSet ds_San = new DataSet();
        SqlDataAdapter loaisan;

        public DataTable HienThiDuLieuLoaiSan() //trả về 1 bảng
        {
            conn = kn.conDB();
            conn.Open();
            string sql = "SELECT * FROM LoaiSan";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable LoadLoaiSanCombobox()
        {
            conn = kn.conDB();
            conn.Open();
            loaisan = new SqlDataAdapter("select * from LoaiSan", conn);
            loaisan.Fill(ds_San, "Ten_Loai");
            conn.Close();
            return ds_San.Tables["Ten_Loai"];
        }        
        public bool kiemTraTonTaiLoaiSan(string loaiSan)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Loai_San FROM LoaiSan where Loai_San='" + loaiSan + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (loaiSan == dr.GetString(0))
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
        public bool kiemTraTonTaiLoaiSan_San(string loaiSan)
        {
            conn = kn.conDB();
            conn.Open();
            bool tatkt = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Loai_San FROM San where Loai_San='" + loaiSan + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (loaiSan == dr.GetString(0))
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
        public bool ThemLoaiSan(string loaisan, string tenloaisan, string gialoaisan)
        {
            string sqlThem = "INSERT INTO [LoaiSan] ([Loai_San], [Ten_Loai],[GiaLoai_San]) VALUES ('" + loaisan + "','" + tenloaisan + "', N'" + gialoaisan + "')";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }

        public bool XoaLoaiSan(string maLoaiSan)
        {
            string sqlXoa = "DELETE FROM LoaiSan WHERE Loai_San= '" + maLoaiSan + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaLoaiSan(string loaisan, string tenloaisan, string gialoaisan)
        {
            string sqlSua = "UPDATE LoaiSan set Ten_Loai= '" + tenloaisan + "', GiaLoai_San= N'" + gialoaisan + "' where Loai_San= '" + loaisan + "'";
            bool kt = false;
            if (kn.ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
