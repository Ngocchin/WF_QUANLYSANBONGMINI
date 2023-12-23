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

namespace QUANLYSANBONGMINI.GUI
{
    public partial class frm_InHDKH : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtSanBong = new DataTable("KhachHang");
        public frm_InHDKH()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.QuanLySanBongConnectionString;
            ketnoi.Open();
            cmd.Connection = ketnoi;
        }
        void LoadcboKH()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select  Ma_KhachHang From KhachHang";
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Ma_KhachHang";
            comboBox1.DisplayMember = "Ma_KhachHang";
        }   

        private void btn_inkh_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDSKH";
            cmd.Parameters.Clear();
            if (comboBox1.SelectedIndex != -1)
            {
                cmd.Parameters.AddWithValue("@Ma_KhachHang", comboBox1.SelectedValue.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("@Ma_KhachHang", DBNull.Value);
            }

            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void frm_InHDKH_Load(object sender, EventArgs e)
        {
            LoadcboKH();
        }
    }
}
