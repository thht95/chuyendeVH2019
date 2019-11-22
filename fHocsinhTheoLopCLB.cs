using MGBK3.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGBK3
{
    public partial class fHocsinhTheoLopCLB : Form
    {
        MGBKEntities context = new MGBKEntities();
        private string constr = ConfigurationManager.ConnectionStrings["MGBK"].ConnectionString;
        public fHocsinhTheoLopCLB()
        {
            InitializeComponent();
            loadCbb();
        }

        private void fHocsinhTheoLopCLB_Load(object sender, EventArgs e)
        {

        }

        private void loadCbb()
        {
            comboBox1.DataSource = context.LopCLBs.ToList();
            comboBox1.DisplayMember = "TenLopCLB";
            comboBox1.ValueMember = "LopCLB_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand("spSelectHSByLopCLBID", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@clbid", Convert.ToInt32(comboBox1.SelectedValue));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    rpHsByLopCLBGROUPBY rp = new rpHsByLopCLBGROUPBY();
                    rp.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rp;
                }
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
