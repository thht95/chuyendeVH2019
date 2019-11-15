using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGBK3
{
    public partial class fHoadonHocphi : Form
    {
        MGBKEntities context = new MGBKEntities();

        public fHoadonHocphi()
        {
            InitializeComponent();
            dgvHoadonHocphi.AutoGenerateColumns = false;
            reloadDgv();
        }

        public void reloadDgv()
        {
            context.SaveChanges();
            dgvHoadonHocphi.DataSource = context.Hoadonhocphis.ToList();
            reloadCbb();
        }

        public void reloadCbb()
        {
            cbbHocsinh.DataSource = context.spHocsinhDetail().ToList();
            cbbHocsinh.DisplayMember = "HoTen";
            cbbHocsinh.ValueMember = "Hocsinh_ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Hoadonhocphi hoadon = new Hoadonhocphi();
                hoadon.Nguoidong = txtNguoidong.Text;
                hoadon.Sotien = Convert.ToInt32(txtSotien.Text);
                hoadon.Thoigiandong = dtpNgaydong.Value;
                hoadon.Trangthai = rbtnDadong.Checked;
                hoadon.Hocsinh_ID = Convert.ToInt32(cbbHocsinh.SelectedValue);

                context.Hoadonhocphis.Add(hoadon);

                reloadDgv();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var id = Convert.ToInt32(txtID.Text);
                var hoadon = context.Hoadonhocphis.Where(x => x.HoadonHP_ID == id).FirstOrDefault();

                hoadon.Nguoidong = txtNguoidong.Text;
                hoadon.Sotien = Convert.ToInt32(txtSotien.Text);
                hoadon.Thoigiandong = dtpNgaydong.Value;
                hoadon.Trangthai = rbtnDadong.Checked;
                hoadon.Hocsinh_ID = Convert.ToInt32(cbbHocsinh.SelectedValue);

                reloadDgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var obj = context.Hoadonhocphis.Where(x => x.HoadonHP_ID.ToString() == txtID.Text).FirstOrDefault();
                context.Hoadonhocphis.Remove(obj);

                reloadDgv();
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

        public void Timkiem(string timkiem)
        {
            var list = context.Hoadonhocphis.Where(x => x.Nguoidong.Contains(timkiem)).ToList();
            dgvHoadonHocphi.DataSource = list;
            if (list.Count == 0)
                MessageBox.Show("Không có kết quả nào cả");
        }

        private bool checkData()
        {
            if (txtNguoidong.Text.Trim() == "")
            {
                MessageBox.Show("Người đóng không đc để trống");
                return false;
            }
            if (txtSotien.Text.Trim() == "")
            {
                MessageBox.Show("Số tiền không đc để trống");
                return false;
            }
            if (cbbHocsinh.SelectedValue.ToString().Trim() == "")
            {
                MessageBox.Show("Số tiền không đc để trống");
                return false;
            }
            return true;
        }

        private void dgvHoadonHocphi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvHoadonHocphi[0, row].Value.ToString();
                txtSotien.Text = dgvHoadonHocphi[1, row].Value.ToString();
                cbbHocsinh.SelectedValue = dgvHoadonHocphi[2, row].Value;
                txtNguoidong.Text = dgvHoadonHocphi[3, row].Value.ToString();
                dtpNgaydong.Value = Convert.ToDateTime(dgvHoadonHocphi[4, row].Value);

                if (Convert.ToBoolean(dgvHoadonHocphi[5, row].Value))
                    rbtnDadong.Checked = true;
                else
                    rbtnChuadong.Checked = true;
            }
        }

        private void dgvHoadonHocphi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int col = e.ColumnIndex;

            if (col == 5)
            {
                if (Convert.ToBoolean(e.Value))
                    e.Value = "Đã đóng";
                else
                    e.Value = "Chưa đóng";
            }

            if (col == 2)
            {
                e.Value = context.spHocsinhDetail().Where(x => x.Hocsinh_id == (int) e.Value).FirstOrDefault().HoTen;
            }

            if (col == 4)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
            }
        }
    }
}
