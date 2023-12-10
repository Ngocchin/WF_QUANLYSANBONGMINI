using QUANLYSANBONGMINI.DAL;
using QUANLYSANBONGMINI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSANBONGMINI
{
    public partial class frm_DangNhap : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection con;
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con = kn.conDB();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Account where UserName='" + txtUserName.Text + "'and Password='" + txtPassWord.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (check_DangNhap.Checked)
            {
                string[] names = new string[] { txtUserName.Text, txtPassWord.Text };

                using (StreamWriter sw = new StreamWriter("file.txt"))
                {
                    foreach (string s in names)
                    {

                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
            else
            {
                string[] names = new string[] { "", "" };

                using (StreamWriter sw = new StreamWriter("file.txt"))
                {
                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
            try
            {
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frm_TrangChu ftrangchu = new frm_TrangChu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    ftrangchu.Show();
                    MessageBox.Show("Xin chào " + txtUserName.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //this.TB("Xin chào " + txtUserName.Text + "", frm_ThongBao.enmType.Success);

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            string cd = "";
            string name = "";
            string line = "";
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    cd = line;
                    line = sr.ReadLine();
                    name = line;
                }
                txtUserName.Text = cd.ToString();
                txtPassWord.Text = name.ToString();
                sr.Close();
            }
        }
    }
}
