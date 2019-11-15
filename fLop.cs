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
            dgvLop.AutoGenerateColumns = false;
            reloadDgv();

        }

        public void Timkiem(string timkiem)
        {
            var list = context.LopHanhchinhs.Where(x => x.TenLopHC.Contains(timkiem) || x.Khoahoc.Contains(timkiem)).ToList();
            dgvLop.DataSource = list;
            if (list.Count == 0)
                MessageBox.Show("Không có kết quả nào cả");
        }

        public void reloadDgv()
        {
            dgvLop.DataSource = context.LopHanhchinhs.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                LopHanhchinh lopHanhchinh = new LopHanhchinh();
                lopHanhchinh.TenLopHC = txtTenLop.Text;
                lopHanhchinh.Namhoc = Convert.ToInt32(txtNamhoc.Text);
                lopHanhchinh.Khoahoc = txtKhoahoc.Text;

                context.LopHanhchinhs.Add(lopHanhchinh);
                context.SaveChanges();

                reloadDgv();
            }
        }

        private bool checkData()
        {
            if (txtKhoahoc.Text.Trim() == "")
            {
                MessageBox.Show("khóa học không đc để trống");
                return false;
            }
            if (txtNamhoc.Text.Trim() == "")
            {
                MessageBox.Show("Năm học không đc để trống");
                return false;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không đc để trống");
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var id = Convert.ToInt32(txtId.Text);

                LopHanhchinh lopHanhchinh = context.LopHanhchinhs.Where(x => x.LopHC_ID == id).FirstOrDefault();
                lopHanhchinh.TenLopHC = txtTenLop.Text;
                lopHanhchinh.Namhoc = Convert.ToInt32(txtNamhoc.Text);
                lopHanhchinh.Khoahoc = txtKhoahoc.Text;

                context.SaveChanges();

                reloadDgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(txtId.Text);

                LopHanhchinh lopHanhchinh = context.LopHanhchinhs.Where(x => x.LopHC_ID == id).FirstOrDefault();
                context.LopHanhchinhs.Remove(lopHanhchinh);
                context.SaveChanges();

                reloadDgv();
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvLop[0, row].Value.ToString();
                txtTenLop.Text = dgvLop[1, row].Value.ToString();
                txtKhoahoc.Text = dgvLop[2, row].Value.ToString();
                txtNamhoc.Text = dgvLop[3, row].Value.ToString();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text;

            if (timkiem.Trim() == "")
                reloadDgv();
            else
            {
                Timkiem(txtTimkiem.Text);
            } 
        }
    }
}
