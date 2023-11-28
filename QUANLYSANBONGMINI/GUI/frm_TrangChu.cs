using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSANBONGMINI.GUI
{
    public partial class frm_TrangChu : Form
    {
        string username1 = "", display1 = "", pass1 = "", quyen1 = "";
        public frm_TrangChu(string username1, string display1, string pass1, string quyen1)
        {
            InitializeComponent();
            this.username1 = username1; 
            this.display1 = display1;
            this.pass1 = pass1;
            this.quyen1 = quyen1;
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            lblTitle.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Visible = false;
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.Show();
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            frm_HeThong f = new frm_HeThong();            
            openChildForm(f);            
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            frm_DatSan f = new frm_DatSan();
            openChildForm(f);
        }

        private void btnQuanLySan_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            frm_QuanLySan f = new frm_QuanLySan();
            openChildForm(f);
        }

        private void btnQuanLyKinhDoanh_Click(object sender, EventArgs e)
        {
            panelDesktopPane.Controls.Clear();
            frm_QuanLyKinhDoanh f = new frm_QuanLyKinhDoanh();
            openChildForm(f);
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            lblxinchao.Text = "Xin chào " + display1 + "";
            if (quyen1 == "Admin")
            {
                btnHeThong.Visible = true;

            }
            else if (quyen1 == "User")
            {
                btnHeThong.Visible = false;
            }
        }
    }
}
