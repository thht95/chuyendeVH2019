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
    public partial class fThoikhoabieu : Form
    {
        public static bool byStudent = false;
        MGBKEntities context = new MGBKEntities();

        public fThoikhoabieu()
        {
            InitializeComponent();
            if (!byStudent)
            {
                lblHocsinh.Hide();
                txtHocsinh.Hide();
                loadData("");
            }

        }

        private void loadData(string mahs)
        {
            if (mahs == "")
            {
                var allClass = context.LopCLBs.Where(x => x.Trangthai == true);
                foreach(LopCLB lop in allClass)
                {
                    if (lop.Lichhoc == "Chiều tối thứ 2")
                    {
                        if (txt2.Text == "")
                            txt2.Text = lop.TenLopCLB;
                        else if (txt2_2.Text == "")
                            txt2_2.Text = lop.TenLopCLB;
                        else if (txt2_3.Text == "")
                            txt2_3.Text = lop.TenLopCLB;
                    }

                    if (lop.Lichhoc == "Chiều tối thứ 3")
                    {
                        if (txt3.Text == "")
                            txt3.Text = lop.TenLopCLB;
                        else if (txt3_2.Text == "")
                            txt3_2.Text = lop.TenLopCLB;
                        else if (txt3_3.Text == "")
                            txt3_3.Text = lop.TenLopCLB;
                    }
                    if (lop.Lichhoc == "Chiều tối thứ 4")
                        txt4.Text = lop.TenLopCLB;
                    if (lop.Lichhoc == "Chiều tối thứ 5")
                        txt5.Text = lop.TenLopCLB;
                    if (lop.Lichhoc == "Chiều tối thứ 6")
                        txt6.Text = lop.TenLopCLB;
                }
            }
            else
            {
                //var allClass = context.Hoadonhocphis.Where(x => x.Hocsinh_ID == mahs).FirstOrDefault();
                //allClass.ChitiethoadonHPs.FirstOrDefault().
                //foreach (LopCLB lop in allClass)
                //{
                //    if (lop.Lichhoc == "T2")
                //        txt2.Text = lop.TenLopCLB;
                //    if (lop.Lichhoc == "T3")
                //        txt3.Text = lop.TenLopCLB;
                //    if (lop.Lichhoc == "T4")
                //        txt4.Text = lop.TenLopCLB;
                //    if (lop.Lichhoc == "T5")
                //        txt5.Text = lop.TenLopCLB;
                //    if (lop.Lichhoc == "T6")
                //        txt6.Text = lop.TenLopCLB;
                //}
            }
        }

        private void txtHocsinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtHocsinh.Text);
                loadData(txtHocsinh.Text);
            }
        }
    }
}
