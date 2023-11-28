using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSANBONGMINI.BLL;
using QUANLYSANBONGMINI.GUI;

namespace QUANLYSANBONGMINI
{
    public partial class frm_HeThong : Form
    {
        AccountBLL bll = new AccountBLL();
        public frm_HeThong()
        {
            InitializeComponent();
            LoadAcc();
        }
        public void LoadAcc()
        {
            try
            {
                dgv_TK.AutoGenerateColumns = false;
                DataTable dtAc = new DataTable();
                dtAc = bll.HienThiDuLieu();
                dgv_TK.DataSource = dtAc;
                dgv_TK.Columns[0].DataPropertyName = "UserName";
                dgv_TK.Columns[1].DataPropertyName = "DisplayName";
                dgv_TK.Columns[2].DataPropertyName = "PassWord";
                dgv_TK.Columns[3].DataPropertyName = "Quyen";

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dgv_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txt_username.Text = dgv_TK.Rows[numrow].Cells[0].Value.ToString();
                txt_displayname.Text = dgv_TK.Rows[numrow].Cells[1].Value.ToString();
                txt_pass.Text = dgv_TK.Rows[numrow].Cells[2].Value.ToString();
                cbo_quyen.Text = dgv_TK.Rows[numrow].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool KTNhap()
        {
            if (txt_username.TextLength == 0)
            {
                txt_username.Focus();
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_displayname.TextLength == 0)
            {
                txt_displayname.Focus();
                MessageBox.Show("Bạn chưa nhập DisplayName!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_pass.TextLength == 0)
            {
                txt_pass.Focus();
                MessageBox.Show("Bạn chưa nhập Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_TK.AutoGenerateColumns = false;
                DataTable dtAc = new DataTable();
                dtAc = bll.HienThiDuLieuTimKiem(txt_search.Text);
                dgv_TK.DataSource = dtAc;
                dgv_TK.Columns[0].DataPropertyName = "UserName";
                dgv_TK.Columns[1].DataPropertyName = "DisplayName";
                dgv_TK.Columns[2].DataPropertyName = "PassWord";
                dgv_TK.Columns[3].DataPropertyName = "Quyen";

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }

            if (bll.KiemTraDuLieuAccount(txt_username.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bll.ThemDuLieuAccount(txt_username.Text, txt_displayname.Text, txt_pass.Text, cbo_quyen.Text);
                    MessageBox.Show("Thành công!");
                    LoadAcc();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (bll.KiemTraDuLieuAccount(txt_username.Text))
            {
                try
                {
                    bll.XoaDuLieuAccount(txt_username.Text);
                    LoadAcc();
                    MessageBox.Show("Xoá tài khoản " + txt_username.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá tài khoản " + txt_username.Text + " chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }
            else
            {
                if (bll.KiemTraDuLieuAccount(txt_username.Text))
                {
                    try
                    {
                        bll.SuaDuLieuAccount(txt_username.Text, txt_displayname.Text, txt_pass.Text, cbo_quyen.Text);
                        MessageBox.Show("Thành công!");
                        LoadAcc();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_username.Text = "";
            txt_pass.Text = "";
            txt_displayname.Text = "";
            txt_username.Focus();
            LoadAcc();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
                
        }
    }
}
