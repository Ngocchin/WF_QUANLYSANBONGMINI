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
    }
}
