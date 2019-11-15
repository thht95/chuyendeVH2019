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
    public partial class fLopCLB : Form
    {
        MGBKEntities context = new MGBKEntities();
        public fLopCLB()
        {
            InitializeComponent();
            dgvLopCLB.AutoGenerateColumns = false;
            reloadDgv();
        }

        public void reloadDgv()
        {
            context.SaveChanges();
            dgvLopCLB.DataSource = context.LopCLBs.ToList();
            reloadCbb();
        }

        public void reloadCbb()
        {
            cbbCLB.DataSource = context.CLBs.ToList();
            cbbCLB.DisplayMember = "TenCLB";
            cbbCLB.ValueMember = "CLB_ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                LopCLB lopCLB = new LopCLB();
                lopCLB.Lichhoc = txtLichhoc.Text;
                lopCLB.Hocphi = Convert.ToInt32(txtHocphi.Text);
                lopCLB.TenLopCLB = txtTen.Text;
                lopCLB.CLB_ID = (int) cbbCLB.SelectedValue;
                lopCLB.Trangthai = rbtnActive.Checked;

                context.LopCLBs.Add(lopCLB);

                reloadDgv();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var id = Convert.ToInt32(txtID.Text);
                var lopCLB = context.LopCLBs.Where(x => x.LopCLB_ID == id).FirstOrDefault();
                lopCLB.Lichhoc = txtLichhoc.Text;
                lopCLB.Hocphi = Convert.ToInt32(txtHocphi.Text);
                lopCLB.TenLopCLB = txtTen.Text;
                lopCLB.CLB_ID = (int)cbbCLB.SelectedValue;
                lopCLB.Trangthai = rbtnActive.Checked;

                reloadDgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(txtID.Text);
                var obj = context.LopCLBs.Where(x => x.LopCLB_ID == id).FirstOrDefault();
                context.LopCLBs.Remove(obj);

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

        private bool checkData()
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không đc để trống");
                return false;
            }
            return true;
        }

        public void Timkiem(string timkiem)
        {
            var list = context.LopCLBs.Where(x => x.TenLopCLB.Contains(timkiem) || x.Lichhoc.Contains(timkiem)).ToList();
            dgvLopCLB.DataSource = list;
            if (list.Count == 0)
                MessageBox.Show("Không có kết quả nào cả");
        }

        private void dgvLopCLB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvLopCLB[0, row].Value.ToString();
                txtTen.Text = dgvLopCLB[1, row].Value.ToString();
                txtHocphi.Text = dgvLopCLB[2, row].Value.ToString();
                txtLichhoc.Text = dgvLopCLB[3, row].Value.ToString();
                cbbCLB.SelectedValue = dgvLopCLB[4, row].Value;
                rbtnActive.Checked = Convert.ToBoolean(dgvLopCLB[5, row].Value);
                rbtnDeactive.Checked = !Convert.ToBoolean(dgvLopCLB[5, row].Value);
            }
        }

        private void dgvLopCLB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var col = e.ColumnIndex;
            if (col == 4)
            {
                e.Value = getTenCLB((int) e.Value);
            }

            if (col == 5)
            {
                if (Convert.ToBoolean(e.Value))
                    e.Value = "Hoạt động";
                else
                    e.Value = "Nghỉ";
            }
        }

        private string getTenCLB(int maCLB)
        {
            return context.CLBs.Find(maCLB).TenCLB;
        }
    }
}
