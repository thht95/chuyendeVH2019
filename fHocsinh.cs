using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGBK3
{
    public partial class fHocsinh : Form
    {
        MGBKEntities context = new MGBKEntities();
        public fHocsinh()
        {
            InitializeComponent();
            reloadDgv();
            
        }

        public void reloadDgv()
        {
            dataGridView1.DataSource = context.Hocsinhs.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hocsinh hocsinh = new Hocsinh();
            hocsinh.Diachi = "V";
            hocsinh.Hocsinh_ID = "1";
            hocsinh.HoTen = "K";
            hocsinh.Ngaysinh = DateTime.Now;
            hocsinh.LopHC_ID = "637066979577183981";
            //hocsinh.LopHC_ID = context.LopHanhchinhs.Select(x => x.LopHC_ID).OrderBy(x => SqlFunctions.Rand()).FirstOrDefault();

            context.Hocsinhs.Add(hocsinh);
            context.SaveChanges();

            reloadDgv();
        }
    }
}
