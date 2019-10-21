using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Data.SqlClient;
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
            dgvHocsinh.AutoGenerateColumns = false;
            reloadDgv();
        }

        public void reloadDgv()
        {
            context.SaveChanges();
            dgvHocsinh.DataSource = context.Hocsinhs.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hocsinh hocsinh = new Hocsinh();
            hocsinh.Diachi = txtDiachi.Text;
            hocsinh.Hocsinh_ID = txtID.Text;
            hocsinh.HoTen = txtHoten.Text;
            hocsinh.Ngaysinh = DateTime.Now;
            hocsinh.LopHC_ID = "1";
            //hocsinh.LopHC_ID = cbbLop.SelectedValue.ToString();

            context.Hocsinhs.Add(hocsinh);

            reloadDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var hocsinh = context.Hocsinhs.Where(x => x.Hocsinh_ID == txtID.Text).FirstOrDefault();
                hocsinh.Diachi = txtDiachi.Text;
                hocsinh.HoTen = txtHoten.Text;
                hocsinh.Ngaysinh = DateTime.Now;
                hocsinh.LopHC_ID = "1";
                
                reloadDgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var hocsinh = context.Hocsinhs.Where(x => x.Hocsinh_ID == txtID.Text).FirstOrDefault();
                context.Hocsinhs.Remove(hocsinh);

                reloadDgv();
            }
        }

        private bool checkData()
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Id không đc để trống");
                return false;
            }
            if (txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không đc để trống");
                return false;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không đc để trống");
                return false;
            }
            if (txtGioitinh.Text.Trim() == "")
            {
                MessageBox.Show("Giới tính không đc để trống");
                return false;
            }
            return true;
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
        public void Timkiem(string timkiem)
        {
            var list = context.Hocsinhs.Where(x => x.HoTen == timkiem || x.Diachi.Contains(timkiem)).ToList();
            dgvHocsinh.DataSource = list;
            if (list.Count == 0)
                MessageBox.Show("Không có kết quả nào cả");
        }

        private void dgvHocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvHocsinh[0, row].Value.ToString();
                txtHoten.Text = dgvHocsinh[1, row].Value.ToString();
                txtNgaysinh.Text = dgvHocsinh[2, row].Value.ToString();
                //txtGioitinh.Text = dgvHocsinh[3, row].Value.ToString();
                txtDiachi.Text = dgvHocsinh[4, row].Value.ToString();
            }
        }
    }
}
