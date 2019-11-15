namespace MGBK3
{
    partial class fHoadonHocphi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHoadonHocphi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguoidong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbHocsinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaydong = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnChuadong = new System.Windows.Forms.RadioButton();
            this.rbtnDadong = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonHocphi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoadonHocphi
            // 
            this.dgvHoadonHocphi.AllowUserToAddRows = false;
            this.dgvHoadonHocphi.AllowUserToDeleteRows = false;
            this.dgvHoadonHocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadonHocphi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHoadonHocphi.Location = new System.Drawing.Point(0, 301);
            this.dgvHoadonHocphi.Name = "dgvHoadonHocphi";
            this.dgvHoadonHocphi.ReadOnly = true;
            this.dgvHoadonHocphi.Size = new System.Drawing.Size(799, 150);
            this.dgvHoadonHocphi.TabIndex = 0;
            this.dgvHoadonHocphi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadonHocphi_CellClick);
            this.dgvHoadonHocphi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoadonHocphi_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoadonHP_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sotien";
            this.Column6.HeaderText = "Số tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Hocsinh_ID";
            this.Column2.HeaderText = "Học sinh";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nguoidong";
            this.Column3.HeaderText = "Người đóng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Thoigiandong";
            this.Column4.HeaderText = "Thời gian đóng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Trangthai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(680, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(680, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(680, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(680, 231);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 38);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số tiền";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(113, 95);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(120, 20);
            this.txtSotien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Người đóng";
            // 
            // txtNguoidong
            // 
            this.txtNguoidong.Location = new System.Drawing.Point(446, 39);
            this.txtNguoidong.Name = "txtNguoidong";
            this.txtNguoidong.Size = new System.Drawing.Size(121, 20);
            this.txtNguoidong.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trạng thái";
            // 
            // cbbHocsinh
            // 
            this.cbbHocsinh.FormattingEnabled = true;
            this.cbbHocsinh.Location = new System.Drawing.Point(113, 146);
            this.cbbHocsinh.Name = "cbbHocsinh";
            this.cbbHocsinh.Size = new System.Drawing.Size(120, 21);
            this.cbbHocsinh.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày đóng";
            // 
            // dtpNgaydong
            // 
            this.dtpNgaydong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaydong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaydong.Location = new System.Drawing.Point(446, 95);
            this.dtpNgaydong.Name = "dtpNgaydong";
            this.dtpNgaydong.Size = new System.Drawing.Size(121, 20);
            this.dtpNgaydong.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnChuadong);
            this.panel1.Controls.Add(this.rbtnDadong);
            this.panel1.Location = new System.Drawing.Point(446, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 39);
            this.panel1.TabIndex = 18;
            // 
            // rbtnChuadong
            // 
            this.rbtnChuadong.AutoSize = true;
            this.rbtnChuadong.Location = new System.Drawing.Point(84, 12);
            this.rbtnChuadong.Name = "rbtnChuadong";
            this.rbtnChuadong.Size = new System.Drawing.Size(78, 17);
            this.rbtnChuadong.TabIndex = 1;
            this.rbtnChuadong.TabStop = true;
            this.rbtnChuadong.Text = "Chưa đóng";
            this.rbtnChuadong.UseVisualStyleBackColor = true;
            // 
            // rbtnDadong
            // 
            this.rbtnDadong.AutoSize = true;
            this.rbtnDadong.Checked = true;
            this.rbtnDadong.Location = new System.Drawing.Point(4, 12);
            this.rbtnDadong.Name = "rbtnDadong";
            this.rbtnDadong.Size = new System.Drawing.Size(67, 17);
            this.rbtnDadong.TabIndex = 0;
            this.rbtnDadong.TabStop = true;
            this.rbtnDadong.Text = "Đã đóng";
            this.rbtnDadong.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(53, 241);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(555, 20);
            this.txtTimkiem.TabIndex = 19;
            // 
            // fHoadonHocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpNgaydong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbHocsinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNguoidong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvHoadonHocphi);
            this.Name = "fHoadonHocphi";
            this.Text = "Danh sách hóa đơn học phí";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonHocphi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoadonHocphi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoidong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbHocsinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaydong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnChuadong;
        private System.Windows.Forms.RadioButton rbtnDadong;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}