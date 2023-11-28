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
    public partial class frm_QuanLyKinhDoanh : Form
    {
        KhachHangBLL kh_bll = new KhachHangBLL();
        HoaDonBLL hd_bll = new HoaDonBLL();
        public frm_QuanLyKinhDoanh()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
        }
        public void LoadKH()
        {
            try
            {
                dtgvTTKH_Show.AutoGenerateColumns = false;
                DataTable dtKH = new DataTable();
                dtKH = kh_bll.HienThiDuLieu();
                dtgvTTKH_Show.DataSource = dtKH;
                dtgvTTKH_Show.Columns[0].DataPropertyName = "Ma_KhachHang";
                dtgvTTKH_Show.Columns[1].DataPropertyName = "Ten_KhachHang";
                dtgvTTKH_Show.Columns[2].DataPropertyName = "DiaChi_KhachHang";
                dtgvTTKH_Show.Columns[3].DataPropertyName = "Sdt_KhachHang";

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        

        private void frm_QuanLyKinhDoanh_Load(object sender, EventArgs e)
        {
            LoadKH();
            LoadHoaDon();
            cmbKH.DataSource = hd_bll.HienThiDuLieuCboxKH();
            cmbKH.DisplayMember = "Ma_KhachHang";
            cmbKH.ValueMember = "Ma_KhachHang";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvTTKH_Show.AutoGenerateColumns = false;
                DataTable dtKH = new DataTable();
                dtKH = kh_bll.HienThiDuLieuTimKiem(txtSearchKH.Text);
                dtgvTTKH_Show.DataSource = dtKH;
                dtgvTTKH_Show.Columns[0].DataPropertyName = "Ma_KhachHang";
                dtgvTTKH_Show.Columns[1].DataPropertyName = "Ten_KhachHang";
                dtgvTTKH_Show.Columns[2].DataPropertyName = "DiaChi_KhachHang";
                dtgvTTKH_Show.Columns[3].DataPropertyName = "Sdt_KhachHang";

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.TextLength > 0)
            {
                if (!char.IsDigit(txtSoDienThoai.Text[txtSoDienThoai.TextLength - 1]))
                {
                    this.errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số lớn hơn 0");
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
            if (e.KeyChar == '-')
            {
                int k = 0;
                for (int i = 0; i < txtSoDienThoai.Text.Length; i++)
                {
                    if (txtSoDienThoai.Text[i] == '-')
                        k++;
                }
                if (k == 0)
                    e.Handled = false;
                if (k == 1)
                    e.Handled = true;
            }
        }
        private bool KTNhap()
        {
            if (txtMaKhachHang.TextLength == 0)
            {
                txtMaKhachHang.Focus();
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenKhachHang.TextLength == 0)
            {
                txtTenKhachHang.Focus();
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiaChi.TextLength == 0)
            {
                txtDiaChi.Focus();
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }

            if (kh_bll.KiemTraDuLieuKH(txtMaKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    kh_bll.ThemDuLieuKH(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                    MessageBox.Show("Thành công!");
                    LoadKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (kh_bll.KiemTraDuLieuKH(txtMaKhachHang.Text))
            {
                try
                {
                    kh_bll.XoaDuLieuKH(txtMaKhachHang.Text);
                    MessageBox.Show("Xoá khách hàng " + txtMaKhachHang.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá " + txtMaKhachHang.Text + " chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (kh_bll.KiemTraDuLieuKH(txtMaKhachHang.Text))
                {
                    try
                    {
                        kh_bll.SuaDuLieuKH(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                        MessageBox.Show("Thành công!");
                        LoadKH();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tên khách hàng chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtMaKhachHang.Focus();
            LoadKH();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        public void LoadHoaDon()
        {
            try
            {
                dgrvHD_Show.AutoGenerateColumns = false;
                DataTable dtHD = new DataTable();
                dtHD = hd_bll.HienThiDuLieu();
                dgrvHD_Show.DataSource = dtHD;
                dgrvHD_Show.Columns[0].DataPropertyName = "Ma_HD";
                dgrvHD_Show.Columns[1].DataPropertyName = "Ma_KhachHang";
                dgrvHD_Show.Columns[2].DataPropertyName = "Ma_San";
                dgrvHD_Show.Columns[3].DataPropertyName = "NgayLap_HD";
                dgrvHD_Show.Columns[4].DataPropertyName = "TongPhut_Da";
                dgrvHD_Show.Columns[5].DataPropertyName = "DonGia";
                dgrvHD_Show.Columns[6].DataPropertyName = "TongTien_HD";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private bool KTNhapHD()
        {
            if (txtMasan.TextLength == 0)
            {
                txtMasan.Focus();
                MessageBox.Show("Bạn chưa mã sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTongphutda.TextLength == 0)
            {
                txtTongphutda.Focus();
                MessageBox.Show("Bạn chưa nhập số phút đá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDonGia.TextLength == 0)
            {
                txtDonGia.Focus();
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTongTien.TextLength == 0)
            {
                txtTongTien.Focus();
                MessageBox.Show("Bạn chưa nhập tổng tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void tong()
        {
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            label30.Text = "Tổng doanh thu: " + thanhtien.ToString() + " VNĐ";
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtHD = new DataTable();
                dtHD = hd_bll.HienThiDuLieuTheoThang(cboThang.Text, cboNam.Text);
                dataGridView1.DataSource = dtHD;
                dataGridView1.Columns[0].DataPropertyName = "Ma_KhachHang";
                dataGridView1.Columns[1].DataPropertyName = "Ma_San";
                dataGridView1.Columns[2].DataPropertyName = "NgayLap_HD";
                dataGridView1.Columns[3].DataPropertyName = "TongPhut_Da";
                dataGridView1.Columns[4].DataPropertyName = "DonGia";
                dataGridView1.Columns[5].DataPropertyName = "TongTien_HD";
            }
            catch
            {

            }
            tong();
        }
        private void btn_ThongKeNam_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtHD = new DataTable();
                dtHD = hd_bll.HienThiDuLieuTheoNam(comboBox1.Text);
                dataGridView1.DataSource = dtHD;
                dataGridView1.Columns[0].DataPropertyName = "Ma_KhachHang";
                dataGridView1.Columns[1].DataPropertyName = "Ma_San";
                dataGridView1.Columns[2].DataPropertyName = "NgayLap_HD";
                dataGridView1.Columns[3].DataPropertyName = "TongPhut_Da";
                dataGridView1.Columns[4].DataPropertyName = "DonGia";
                dataGridView1.Columns[5].DataPropertyName = "TongTien_HD";
            }
            catch
            {

            }
            tong();
        }

        private void dgrvHD_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                cmbKH.Text = dgrvHD_Show.Rows[numrow].Cells[1].Value.ToString();
                txtMasan.Text = dgrvHD_Show.Rows[numrow].Cells[2].Value.ToString();
                dtNgayLap.Text = dgrvHD_Show.Rows[numrow].Cells[3].Value.ToString();
                txtTongphutda.Text = dgrvHD_Show.Rows[numrow].Cells[4].Value.ToString();
                txtDonGia.Text = dgrvHD_Show.Rows[numrow].Cells[5].Value.ToString();
                txtTongTien.Text = dgrvHD_Show.Rows[numrow].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = null;
            if (dgrvHD_Show.CurrentRow != null)
            {
                maHD = dgrvHD_Show.CurrentRow.Cells[0].Value.ToString();
            }
            if (maHD == null)
                return;
            if (hd_bll.KiemTraDuLieuHD(maHD))
            {
                try
                {
                    hd_bll.XoaDuLieuHD(maHD);
                    LoadHoaDon();
                    MessageBox.Show("Xoá hóa đơn " + maHD + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Không thể xoá hóa đơn " + maHD + " chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KTNhapHD())
            {
                return;
            }

            string maHD = null;
            if (dgrvHD_Show.CurrentRow != null)
            {
                maHD = dgrvHD_Show.CurrentRow.Cells[0].Value.ToString();
            }
            if (maHD == null)
                return;

            if (hd_bll.KiemTraDuLieuHD(maHD))
            {
                try
                {
                    hd_bll.SuaDuLieuHD(maHD, cmbKH.Text, txtMasan.Text, dtNgayLap.Text, txtTongphutda.Text, txtDonGia.Text, txtTongTien.Text);
                    MessageBox.Show("Thành công!");
                    LoadHoaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTongphutda_TextChanged(object sender, EventArgs e)
        {
            if (txtTongphutda.TextLength > 0)
            {
                if (!char.IsDigit(txtTongphutda.Text[txtTongphutda.TextLength - 1]))
                {
                    this.errorProvider1.SetError(txtTongphutda, "Bạn phải nhập số lớn hơn 0");
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtTongphutda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
            if (e.KeyChar == '-')
            {
                int k = 0;
                for (int i = 0; i < txtTongphutda.Text.Length; i++)
                {
                    if (txtTongphutda.Text[i] == '-')
                        k++;
                }
                if (k == 0)
                    e.Handled = false;
                if (k == 1)
                    e.Handled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.TextLength > 0)
            {
                if (!char.IsDigit(txtDonGia.Text[txtDonGia.TextLength - 1]))
                {
                    this.errorProvider1.SetError(txtDonGia, "Bạn phải nhập số lớn hơn 0");
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
            if (e.KeyChar == '-')
            {
                int k = 0;
                for (int i = 0; i < txtDonGia.Text.Length; i++)
                {
                    if (txtDonGia.Text[i] == '-')
                        k++;
                }
                if (k == 0)
                    e.Handled = false;
                if (k == 1)
                    e.Handled = true;
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.TextLength > 0)
            {
                if (!char.IsDigit(txtTongTien.Text[txtTongTien.TextLength - 1]))
                {
                    this.errorProvider1.SetError(txtTongTien, "Bạn phải nhập số lớn hơn 0");
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
            if (e.KeyChar == '-')
            {
                int k = 0;
                for (int i = 0; i < txtTongTien.Text.Length; i++)
                {
                    if (txtTongTien.Text[i] == '-')
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
