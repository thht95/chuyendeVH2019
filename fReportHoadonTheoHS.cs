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
    public partial class fReportHoadonTheoHS : Form
    {
        MGBKEntities context = new MGBKEntities();
        private string constr = ConfigurationManager.ConnectionStrings["MGBK"].ConnectionString;
        public fReportHoadonTheoHS()
        {
            InitializeComponent();
            loadCbb();
        }

        private void loadCbb()
        {
            comboBox1.DataSource = context.Hocsinhs.ToList();
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "Hocsinh_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand("spSelectHoadonByHsId", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@hsId", Convert.ToInt32(comboBox1.SelectedValue));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    rpHoadonHPtheoHS rp = new rpHoadonHPtheoHS();
                    rp.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rp;
                }
            }
        }
    }
}
