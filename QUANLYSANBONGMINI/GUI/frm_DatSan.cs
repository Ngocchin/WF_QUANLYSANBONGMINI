using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSANBONGMINI.BLL;
using QUANLYSANBONGMINI.DAL;

namespace QUANLYSANBONGMINI.GUI
{
    public partial class frm_DatSan : Form
    {
        ThueSanBLL ts_bLL = new ThueSanBLL();
        HoaDonBLL hd_bll = new HoaDonBLL();
        DataTable dtthuesan = new DataTable();
        KetNoi kn = new KetNoi();
        SqlConnection con;
        SqlCommand cm;
        public frm_DatSan()
        {
            InitializeComponent();
            dgv_datsan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dgv_datsan.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            cbbLoaiThue.SelectedIndex = 0;
            dateBD.Value = DateTime.Now;
            dateKT.Value = DateTime.Now;
            dtGioBatDau.Value = DateTime.Now;
            dtGioKetThuc.Value = DateTime.Now.AddHours(1);
        }
        public void LoadThuesan()
        {
            try
            {
                dgv_datsan.AutoGenerateColumns = false;
                dtthuesan = ts_bLL.HienThiDuLieu();
                dgv_datsan.DataSource = dtthuesan;
                dgv_datsan.Columns[0].DataPropertyName = "Ma_ThueSan";
                dgv_datsan.Columns[1].DataPropertyName = "Ma_San";
                dgv_datsan.Columns[2].DataPropertyName = "Ma_KhachHang";
                dgv_datsan.Columns[3].DataPropertyName = "ThoiGianBatDau";
                dgv_datsan.Columns[4].DataPropertyName = "ThoiGianKetThuc";
                dgv_datsan.Columns[5].DataPropertyName = "LoaiThue";
                dgv_datsan.Columns[6].DataPropertyName = "DonGia";
                dgv_datsan.Columns[7].DataPropertyName = "ThanhTien";
            }
            catch
            {
                //MessageBox.Show("Lỗi");
            }
        }
        private void frm_DatSan_Load(object sender, EventArgs e)
        {
            //this.ThueSanTableAdapter.Fill(this.quanLySanBongDataSet1.ThueSan);
            LoadThuesan();
            cbbsan.DataSource = ts_bLL.HienThiDuLieuCbox();
            cbbsan.DisplayMember = "Ten_San";
            cbbsan.ValueMember = "Ma_San";
            cbbsan.SelectedValue = "Ma_San";

            cbbmakh.DataSource = ts_bLL.HienThiDuLieuCboxKH();
            cbbmakh.DisplayMember = "Ten_KhachHang";
            cbbmakh.ValueMember = "Ma_KhachHang";

            cbbsan.SelectedIndex = 0;
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            //Thuê sân
            if (cbbLoaiThue.SelectedIndex == 0)
            {
                //Check xem sân có đang trống trong khoảng thời gian đặt không
                if (ts_bLL.CheckSuDung(cbbsan.SelectedValue.ToString(), DateTime.Now).Rows.Count > 0)
                {
                    MessageBox.Show("Sân đã được đặt trước trong khoảng thời gian này");
                    return;
                }

                bool ketQua = ts_bLL.ThueSanTrucTiep(cbbsan.SelectedValue.ToString(), cbbmakh.SelectedValue.ToString(), cbbLoaiThue.Text, Convert.ToInt32(nbDonGia.Value));
                if (ketQua)
                {

                    MessageBox.Show("Thuê sân thành công");
                    LoadThuesan();

                }
                else
                {
                    MessageBox.Show(ts_bLL.ThongBaoTruyVan);
                }
            }
            //Đặt sân
            else
            {
                DateTime ngayBatDau = dateBD.Value.Date + dtGioBatDau.Value.TimeOfDay;
                DateTime ngayKetThuc = dateKT.Value.Date + dtGioKetThuc.Value.TimeOfDay;

                //Check xem sân có đang trống trong khoảng thời gian đặt không
                if (ts_bLL.CheckSuDung(cbbsan.SelectedValue.ToString(), ngayBatDau).Rows.Count > 0)
                {
                    MessageBox.Show("Sân đã được đặt trước trong khoảng thời gian này");
                    return;
                }

                double tongSoPhut = Math.Round(ngayKetThuc.Subtract(ngayBatDau).TotalMinutes / 15.0) / 4;
                double soGio = Math.Floor(tongSoPhut);

                double soPhut = (tongSoPhut - soGio) * 60.0;
                int thanhTien = Convert.ToInt32(((double)nbDonGia.Value * soGio) + (soPhut * (double)nbDonGia.Value / 60));
                var xacNhan = MessageBox.Show("Tổng thời gian thuê: " + soGio + " tiếng " + soPhut + "phút." + Environment.NewLine + "Thành tiền: " + thanhTien.ToString("N0"), "Xác nhận", MessageBoxButtons.YesNo);
                if (xacNhan == DialogResult.Yes)
                {
                    bool ketQua = ts_bLL.DatSan(cbbsan.SelectedValue.ToString(), cbbmakh.SelectedValue.ToString(), ngayBatDau, ngayKetThuc, cbbLoaiThue.Text, Convert.ToInt32(nbDonGia.Value), thanhTien);
                    if (ketQua)
                    {
                        MessageBox.Show("Đặt sân thành công");
                        LoadThuesan();
                        try
                        {
                            if (hd_bll.ThemHoaDon(cbbmakh.SelectedValue.ToString(), cbbsan.SelectedValue.ToString(), ngayKetThuc, soGio, Convert.ToInt32(nbDonGia.Value), thanhTien))
                            {
                                //MessageBox.Show("Thành công");
                            }
                            else
                            {
                                MessageBox.Show(hd_bll.ThongBaoTruyVan);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đã xảy ra lỗi ở bảng HĐ");
                        }
                    }
                    else
                    {
                        MessageBox.Show(ts_bLL.ThongBaoTruyVan);
                    }
                }
            }
        }

        private void cbbsan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = kn.conDB();
                con.Open();
                cm = new SqlCommand("SELECT GiaLoai_San FROM San, LoaiSan WHERE San.Loai_San = LoaiSan.Loai_San and San.Ma_San ='" + cbbsan.SelectedValue + "'", con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string b = reader.GetDouble(0).ToString();
                    nbDonGia.Text = b.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        private void cbbLoaiThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiThue.SelectedIndex == 1)
            {
                dateBD.Enabled = true;
                dateKT.Enabled = true;
                dtGioBatDau.Enabled = true;
                dtGioKetThuc.Enabled = true;
            }
            else
            {
                dateBD.Enabled = false;
                dateKT.Enabled = false;
                dtGioBatDau.Enabled = false;
                dtGioKetThuc.Enabled = false;
            }
        }

        private void dgv_datsan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                btn_TraSan.Enabled = true;
                dateBD.Enabled = true;
                dateKT.Enabled = true;
                dtGioBatDau.Enabled = true;
                dtGioKetThuc.Enabled = true;
                numrow = e.RowIndex;
                label4.Text = dgv_datsan.Rows[numrow].Cells[0].Value.ToString();
                cbbsan.SelectedValue = dgv_datsan.Rows[numrow].Cells[1].Value.ToString();
                cbbmakh.SelectedValue = dgv_datsan.Rows[numrow].Cells[2].Value.ToString();
                dateBD.Text = dgv_datsan.Rows[numrow].Cells[3].Value.ToString();
                dtGioBatDau.Text = dgv_datsan.Rows[numrow].Cells[3].Value.ToString();
                dateKT.Text = dgv_datsan.Rows[numrow].Cells[4].Value.ToString();
                dtGioKetThuc.Text = dgv_datsan.Rows[numrow].Cells[4].Value.ToString();
                cbbLoaiThue.Text = dgv_datsan.Rows[numrow].Cells[5].Value.ToString();
                nbDonGia.Text = dgv_datsan.Rows[numrow].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_TraSan_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateBD.Value.Date + dtGioBatDau.Value.TimeOfDay;
            DateTime ngayKetThuc = dateKT.Value.Date + dtGioKetThuc.Value.TimeOfDay;
            double tongSoPhut = Math.Round(ngayKetThuc.Subtract(ngayBatDau).TotalMinutes / 15.0) / 4;
            double soGio = Math.Floor(tongSoPhut);
            double soPhut = (tongSoPhut - soGio) * 60.0;
            int thanhTien = Convert.ToInt32(((double)nbDonGia.Value * soGio) + (soPhut * (double)nbDonGia.Value / 60));
            var xacNhan = MessageBox.Show("Tổng thời gian thuê: " + soGio + " tiếng " + soPhut + "phút." + Environment.NewLine + "Thành tiền: " + thanhTien.ToString("N0"), "Xác nhận", MessageBoxButtons.YesNo);
            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    bool ketQua = ts_bLL.TraSan(Convert.ToInt32(label4.Text), ngayKetThuc, Convert.ToInt32(nbDonGia.Value), thanhTien);
                    if (ketQua)
                    {
                        MessageBox.Show("Trả sân thành công");
                        LoadThuesan();
                        try
                        {
                            if (hd_bll.ThemHoaDon(cbbmakh.SelectedValue.ToString(), cbbsan.SelectedValue.ToString(), ngayKetThuc, soGio, Convert.ToInt32(nbDonGia.Value), thanhTien))
                            {
                                MessageBox.Show("Thành công");
                            }
                            else
                            {
                                MessageBox.Show(hd_bll.ThongBaoTruyVan);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đã xảy ra lỗi ở bảng HĐ");
                        }
                    }
                    else
                    {
                        MessageBox.Show(ts_bLL.ThongBaoTruyVan);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ts_bLL.ThongBaoTruyVan + " " + ex);
                }
            }
        }

        private void btn_Xoasan_Click(object sender, EventArgs e)
        {
            if (label4.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn Sân để xoá!!");
            }
            else
            {
                try
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xoá STT " + label4.Text + " không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                    if (dlr == DialogResult.Yes)
                    {
                        ts_bLL.Xoa(Convert.ToInt32(label4.Text));
                        LoadThuesan();
                        MessageBox.Show("Đã xoá thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }
    }
}
