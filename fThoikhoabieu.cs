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
            else
            {
                lbl.Text = "THỜI KHÓA BIỂU THEO HỌC SINH";
                
            }
        }

        private void loadData(string mahs)
        {
            var allClass = new List<LopCLB>();
            if (mahs == "")
            {
                allClass = context.LopCLBs.Where(x => x.Trangthai == true).ToList();  
            }
            else
            {
                var hs_id = Convert.ToInt32(mahs);
                var list_hp_id = context.Hoadonhocphis.Where(x => x.Hocsinh_ID == hs_id).Select(x => x.HoadonHP_ID);
                var listCthd = new List<ChitiethoadonHP>();

                foreach (int id in list_hp_id)
                {
                    listCthd.AddRange(context.ChitiethoadonHPs.Where(x => x.HoadonHP_ID == id).ToList());
                }

                var listLopClbID = listCthd.Select(x => x.LopCLB_ID);

                allClass = context.LopCLBs.Where(x => x.Trangthai == true && listLopClbID.Contains(x.LopCLB_ID)).ToList();
            }

            foreach (LopCLB lop in allClass)
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
                {
                    if (txt4.Text == "")
                        txt4.Text = lop.TenLopCLB;
                    else if (txt4_2.Text == "")
                        txt4_2.Text = lop.TenLopCLB;
                    else if (txt4_3.Text == "")
                        txt4_3.Text = lop.TenLopCLB;
                }
                    
                if (lop.Lichhoc == "Chiều tối thứ 5")
                {
                    if (txt5.Text == "")
                        txt5.Text = lop.TenLopCLB;
                    else if (txt5_2.Text == "")
                        txt5_2.Text = lop.TenLopCLB;
                    else if (txt5_3.Text == "")
                        txt5_3.Text = lop.TenLopCLB;
                }
                   
                if (lop.Lichhoc == "Chiều tối thứ 6")
                {
                    if (txt6.Text == "")
                        txt6.Text = lop.TenLopCLB;
                    else if (txt6_2.Text == "")
                        txt6_2.Text = lop.TenLopCLB;
                    else if (txt6_3.Text == "")
                        txt6_3.Text = lop.TenLopCLB;
                }
            }
        }

        private void txtHocsinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clearAll();
                loadData(txtHocsinh.Text);
            }
        }

        private void clearAll()
        {
            txt2.Text = "";
            txt2_2.Text = "";
            txt2_3.Text = "";
            txt3.Text = "";
            txt3_2.Text = "";
            txt3_3.Text = "";

            txt4.Text = "";
            txt4_2.Text = "";
            txt4_3.Text = "";
            txt5.Text = "";
            txt5_2.Text = "";
            txt5_3.Text = "";
            txt6.Text = "";
            txt6_2.Text = "";
            txt6_3.Text = "";
        }
    }
}
