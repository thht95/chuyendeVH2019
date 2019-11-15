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
            reloadCbb();
        }

        public void reloadCbb()
        {
            cbbLop.DataSource = context.LopHanhchinhs.ToList();
            cbbLop.DisplayMember = "TenLopHC";
            cbbLop.ValueMember = "LopHC_ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hocsinh hocsinh = new Hocsinh();
            hocsinh.Diachi = txtDiachi.Text;
            hocsinh.Gioitinh = rbtnNam.Checked;
            hocsinh.HoTen = txtHoten.Text;
            hocsinh.Ngaysinh = dtpNgaysinh.Value;
            hocsinh.LopHC_ID = (int) cbbLop.SelectedValue;

            context.Hocsinhs.Add(hocsinh);

            reloadDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var id = Convert.ToInt32(txtID.Text);

                var hocsinh = context.Hocsinhs.Where(x => x.Hocsinh_ID == id).FirstOrDefault();
                hocsinh.Diachi = txtDiachi.Text;
                hocsinh.HoTen = txtHoten.Text;
                hocsinh.Ngaysinh = dtpNgaysinh.Value;
                hocsinh.Gioitinh = rbtnNam.Checked;
                hocsinh.LopHC_ID = (int) cbbLop.SelectedValue;

                reloadDgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(txtID.Text);
                var hocsinh = context.Hocsinhs.Where(x => x.Hocsinh_ID == id).FirstOrDefault();
                context.Hocsinhs.Remove(hocsinh);

                reloadDgv();
            }
        }

        private bool checkData()
        {
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

            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvHocsinh[0, row].Value.ToString();
                txtHoten.Text = dgvHocsinh[1, row].Value.ToString();
                dtpNgaysinh.Value = Convert.ToDateTime(dgvHocsinh[2, row].Value);
                txtDiachi.Text = dgvHocsinh[4, row].Value.ToString();
                if (Convert.ToBoolean(dgvHocsinh[3, row].Value))
                    rbtnNam.Checked = true;
                else
                    rbtnNu.Checked = true;

                cbbLop.SelectedValue = dgvHocsinh[5, row].Value;
            }
        }

        private void dgvHocsinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var col = e.ColumnIndex;

            if (col == 3)
            {
                if (Convert.ToBoolean(e.Value))
                    e.Value = "Nam";
                else
                    e.Value = "Nữ";
            }

            if (col == 5)
            {
                e.Value = getTenLop((int) e.Value);
            }

            if (col == 2) 
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
            }
        }

        private string getTenLop(int malop)
        {
            var lophanhchinh = context.LopHanhchinhs.Find(malop);
            return lophanhchinh.TenLopHC;
        }
    }
}
