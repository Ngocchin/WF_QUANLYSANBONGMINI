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
    public partial class frm_InHoaDon : Form
    {

        public frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection("Data Source=chin-pc;Initial Catalog=QuanLySanBong;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HoaDon", connection))
                    {
                        adapter.Fill(ds, "HoaDon");
                    }
                }

                CrystalReport1 rpt = new CrystalReport1();
                rpt.SetDataSource(ds.Tables["HoaDon"]);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
