using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSANBONGMINI.DAL
{
    public class KetNoi
    {
        public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=chin-pc;Initial Catalog=QuanLySanBong;Integrated Security=True");
            return con;
        }
        public int ExecuteNonQuery(string sql)
        {
            SqlConnection conn;
            int dung = 0;
            try
            {
                conn = conDB();
                conn.Open(); 
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }

    }
}
