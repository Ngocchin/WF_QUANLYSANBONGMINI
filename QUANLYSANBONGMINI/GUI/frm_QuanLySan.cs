using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSANBONGMINI.BLL;

namespace QUANLYSANBONGMINI.GUI
{
    public partial class frm_QuanLySan : Form
    {
        SanBLL san_bll = new SanBLL();
        LoaiSanBLL loai_bll = new LoaiSanBLL();
        public frm_QuanLySan()
        {
            InitializeComponent();
        }
        public void LoadSan()
        {
            try
            {
                đgv_san.AutoGenerateColumns = false;
                DataTable dtSan = new DataTable();
                dtSan = san_bll.HienThiDuLieuSan();
                đgv_san.DataSource = dtSan;
                đgv_san.Columns[0].DataPropertyName = "Ma_San";
                đgv_san.Columns[1].DataPropertyName = "Loai_San";
                đgv_san.Columns[2].DataPropertyName = "Ten_San";
            }
            catch
            {
                //MessageBox.Show("Lỗi");
            }
        }
        public void LoadLoaiSan()
        {
            try
            {
                dgv_loaisan.AutoGenerateColumns = false;
                DataTable dtloaiSan = new DataTable();
                dtloaiSan = loai_bll.HienThiDuLieuLoaiSan();
                dgv_loaisan.DataSource = dtloaiSan;
                dgv_loaisan.Columns[0].DataPropertyName = "Loai_San";
                dgv_loaisan.Columns[1].DataPropertyName = "Ten_Loai";
                dgv_loaisan.Columns[2].DataPropertyName = "GiaLoai_San";
            }
            catch
            {
                //MessageBox.Show("Lỗi");
            }
        }

        private void frm_QuanLySan_Load(object sender, EventArgs e)
        {
            LoadSan();
            LoadLoaiSan();
            cbo_loaisan.DataSource = san_bll.HienThiDuLieuCbox();
            cbo_loaisan.DisplayMember = "Loai_San";
            cbo_loaisan.ValueMember = "Loai_San";
        }

        private void txtmasan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void đgv_san_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txt_masan.Text = đgv_san.Rows[numrow].Cells[0].Value.ToString();
                cbo_loaisan.Text = đgv_san.Rows[numrow].Cells[1].Value.ToString();
                txt_tensan.Text = đgv_san.Rows[numrow].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvQLLS_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txt_loaisan.Text = dgv_loaisan.Rows[numrow].Cells[0].Value.ToString();
                txt_TenLoaiSan.Text = dgv_loaisan.Rows[numrow].Cells[1].Value.ToString();
                txt_gialoaisan.Text = dgv_loaisan.Rows[numrow].Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
        private bool KTNhap()
        {
            if (txt_masan.TextLength == 0)
            {
                txt_masan.Focus();
                MessageBox.Show("Bạn chưa nhập mã sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_tensan.TextLength == 0)
            {
                txt_tensan.Focus();
                MessageBox.Show("Bạn chưa nhập tên sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KTNhapLS()
        {
            if (txt_loaisan.TextLength == 0)
            {
                txt_loaisan.Focus();
                MessageBox.Show("Bạn chưa nhập tên loại sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_gialoaisan.TextLength == 0)
            {
                txt_gialoaisan.Focus();
                MessageBox.Show("Bạn chưa nhập giá loại sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_themsan_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }

            if (san_bll.KiemTraDuLieuSan(txt_masan.Text))
            {
                MessageBox.Show("Mã sân đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    san_bll.ThemDuLieuSan(txt_masan.Text, cbo_loaisan.Text, txt_tensan.Text);
                    MessageBox.Show("Thành công!");
                    LoadSan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void btn_xoasan_Click(object sender, EventArgs e)
        {
            if (san_bll.KiemTraDuLieuSan(txt_masan.Text))
            {
                try
                {
                    san_bll.XoaDuLieuSan(txt_masan.Text);
                    LoadSan();
                    MessageBox.Show("Xoá " + txt_tensan.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá " + txt_tensan.Text + " chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }
            else
            {
                if (san_bll.KiemTraDuLieuSan(txt_masan.Text))
                {
                    try
                    {
                        san_bll.SuaDuLieuSan(txt_masan.Text, txt_masan.Text, txt_masan.Text);
                        MessageBox.Show("Thành công!");
                        LoadSan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Mã sân chưa tồn tại chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_masan.Text = "";
            cbo_loaisan.Text = "";
            txt_tensan.Text = "";
            txt_masan.Focus();
            LoadSan();
        }

        private void btn_Themloaisan_Click(object sender, EventArgs e)
        {
            if (!KTNhapLS())
            {
                return;
            }

            if (loai_bll.KiemTraDuLieuLoaiSan(txt_loaisan.Text))
            {
                MessageBox.Show("Loại sân đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    loai_bll.ThemDuLieuLoaiSan(txt_loaisan.Text, txt_TenLoaiSan.Text, txt_gialoaisan.Text);
                    MessageBox.Show("Thành công!");
                    LoadLoaiSan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void btn_XoaLoaiSan_Click(object sender, EventArgs e)
        {
            if (loai_bll.KiemTraDuLieuLoaiSan(txt_loaisan.Text))
            {
                if (loai_bll.KiemTraDuLieuLoaiSan_SAN(txt_loaisan.Text))
                {
                    MessageBox.Show("Không thể xoá " + txt_loaisan.Text + " vì đã tồn tại trong bảng Sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        loai_bll.XoaDuLieuLoaiSan(txt_loaisan.Text);
                        LoadLoaiSan();
                        MessageBox.Show("Xoá " + txt_loaisan.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá " + txt_loaisan.Text + " chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SuaLoaiSan_Click(object sender, EventArgs e)
        {
            if (!KTNhapLS())
            {
                return;
            }
            else
            {
                if (loai_bll.KiemTraDuLieuLoaiSan(txt_loaisan.Text))
                {
                    try
                    {
                        loai_bll.SuaDuLieuLoaiSan(txt_loaisan.Text, txt_TenLoaiSan.Text, txt_gialoaisan.Text);
                        MessageBox.Show("Thành công!");
                        LoadLoaiSan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Loại sân chưa tồn tại chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_ResetLoaiSan_Click(object sender, EventArgs e)
        {
            txt_loaisan.Text = "";
            txt_TenLoaiSan.Text = "";
            txt_gialoaisan.Text = "";
            txt_loaisan.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void txtgialoaisan_TextChanged(object sender, EventArgs e)
        {
            if (txt_gialoaisan.TextLength > 0)
            {
                if (!char.IsDigit(txt_gialoaisan.Text[txt_gialoaisan.TextLength - 1]))
                {
                    this.errorProvider1.SetError(txt_gialoaisan, "Bạn phải nhập số lớn hơn 0");
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtgialoaisan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
            if (e.KeyChar == '-')
            {
                int k = 0;
                for (int i = 0; i < txt_gialoaisan.Text.Length; i++)
                {
                    if (txt_gialoaisan.Text[i] == '-')
                        k++;
                }
                if (k == 0)
                    e.Handled = false;
                if (k == 1)
                    e.Handled = true;
            }
        }
    }
}
