using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGBK3
{
    public partial class fLop : Form
    {
        MGBKEntities context = new MGBKEntities();
        public fLop()
        {
            InitializeComponent();
            reloadDgv();
        }

        public void reloadDgv()
        {
            dgvLop.DataSource = context.LopHanhchinhs.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LopHanhchinh lopHanhchinh = new LopHanhchinh();
            lopHanhchinh.TenLopHC = "1A";
            lopHanhchinh.Namhoc = 2019;
            lopHanhchinh.LopHC_ID =     DateTime.Now.Ticks.ToString();

            context.LopHanhchinhs.Add(lopHanhchinh);
            context.SaveChanges();

            reloadDgv();
        }
    }
}
