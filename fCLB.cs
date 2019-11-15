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
    public partial class fCLB : Form
    {

        MGBKEntities context = new MGBKEntities();

        public fCLB()
        {
            InitializeComponent();
            dgvCLB.AutoGenerateColumns = false;

            reloadDgv();
        }

        public void reloadDgv()
        {
            context.SaveChanges();
            dgvCLB.DataSource = context.CLBs.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                CLB clb = new CLB();
                clb.TenCLB = txtTen.Text;

                context.CLBs.Add(clb);

                reloadDgv();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var id = Convert.ToInt32(txtID.Text);
                var clb = context.CLBs.Where(x => x.CLB_ID == id).FirstOrDefault();
                clb.TenCLB = txtTen.Text;

                reloadDgv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(txtID.Text);
                var clb = context.CLBs.Where(x => x.CLB_ID == id).FirstOrDefault();
                context.CLBs.Remove(clb);

                reloadDgv();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text;

            if (timkiem.Trim() == "")
                reloadDgv();
            else
            {
                Timkiem(txtTimkiem.Text);
            }
        }

        public void Timkiem(string timkiem)
        {
            var id = Convert.ToInt32(timkiem);
            var list = context.CLBs.Where(x => x.CLB_ID == id || x.TenCLB.Contains(timkiem)).ToList();
            dgvCLB.DataSource = list;
            if (list.Count == 0)
                MessageBox.Show("Không có kết quả nào cả");
        }

        private bool checkData()
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("khóa học không đc để trống");
                return false;
            }
            return true;
        }

        private void dgvCLB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvCLB[0, row].Value.ToString();
                txtTen.Text = dgvCLB[1, row].Value.ToString();
            }
        }
    }
}
