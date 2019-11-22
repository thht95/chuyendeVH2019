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
    public partial class fChitiethoadon : Form
    {
        MGBKEntities context = new MGBKEntities();
        public static int maHD = 0;
        public fChitiethoadon()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            reloadDgv();
            if (maHD != 0)
                cbbHoadon.SelectedItem = maHD;
        }

        public void reloadDgv()
        {
            context.SaveChanges();
            if (maHD == 0)
                dataGridView1.DataSource = context.ChitiethoadonHPs.ToList();
            else
                dataGridView1.DataSource = context.ChitiethoadonHPs.Where(x => x.HoadonHP_ID == maHD).ToList();

            reloadCbb();
        }

        public void reloadCbb()
        {
            cbbHoadon.DataSource = context.Hoadonhocphis.Select(x => x.HoadonHP_ID).ToList();
            cbbLopCLB.DataSource = context.LopCLBs.ToList();
            cbbLopCLB.DisplayMember = "TenLopCLB";
            cbbLopCLB.ValueMember = "LopCLB_ID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = new ChitiethoadonHP();
            obj.LopCLB_ID = Convert.ToInt32(cbbLopCLB.SelectedValue);
            obj.HoadonHP_ID = Convert.ToInt32(cbbHoadon.SelectedValue);
            obj.Hocphi = (int)context.LopCLBs.Where(x => x.LopCLB_ID == x.LopCLB_ID).FirstOrDefault().Hocphi;

            context.ChitiethoadonHPs.Add(obj);

            reloadDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var obj = context.ChitiethoadonHPs.Find(Convert.ToInt32(txtId.Text));

            obj.LopCLB_ID = Convert.ToInt32(cbbLopCLB.SelectedValue);
            obj.HoadonHP_ID = Convert.ToInt32(cbbHoadon.SelectedValue);
            obj.Hocphi = (int)context.LopCLBs.Where(x => x.LopCLB_ID == x.LopCLB_ID).FirstOrDefault().Hocphi;

            reloadDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(txtId.Text);
                var obj = context.ChitiethoadonHPs.Where(x => x.ChitiethoadonHP_ID == id).FirstOrDefault();
                context.ChitiethoadonHPs.Remove(obj);

                reloadDgv();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1[0, row].Value.ToString();
                cbbHoadon.SelectedItem = dataGridView1[1, row].Value;
                cbbLopCLB.SelectedValue = dataGridView1[2, row].Value;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var col = e.ColumnIndex;
            
            if (col == 2)
            {
                e.Value = getName((int)e.Value);
            }
        }

        private string getName(int maCLB)
        {
            return context.LopCLBs.Find(maCLB).TenLopCLB;
        }

        private bool checkData()
        {
            return true;
        }

        private void fChitiethoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void fChitiethoadon_Leave(object sender, EventArgs e)
        {
            var sotientrenhoadon = context.Hoadonhocphis.Find(fChitiethoadon.maHD).Sotien;
            var sotienchitiethoadon = context.ChitiethoadonHPs.Where(x => x.HoadonHP_ID == fChitiethoadon.maHD).Sum(x => x.Hocphi);

            if (sotienchitiethoadon > sotientrenhoadon)
            {
                MessageBox.Show("Hóa đơn " + fChitiethoadon.maHD.ToString() + " còn thiếu nợ");
            }
            
        }
    }
}
