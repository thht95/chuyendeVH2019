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
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.Column5,
            this.Column7});
            this.dgvHoadonHocphi.Location = new System.Drawing.Point(373, 154);
            this.dgvHoadonHocphi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoadonHocphi.Name = "dgvHoadonHocphi";
            this.dgvHoadonHocphi.ReadOnly = true;
            this.dgvHoadonHocphi.Size = new System.Drawing.Size(741, 355);
            this.dgvHoadonHocphi.TabIndex = 0;
            this.dgvHoadonHocphi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadonHocphi_CellClick);
            this.dgvHoadonHocphi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoadonHocphi_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoadonHP_ID";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 3;
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
            this.Column2.Width = 150;
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
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Chi tiết";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(442, 546);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(679, 546);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(876, 546);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 47);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(917, 92);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(88, 47);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 154);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 23);
            this.txtID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn học phí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số tiền:";
            // 
            // txtSotien
            // 
            this.txtSotien.Location = new System.Drawing.Point(148, 223);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(189, 23);
            this.txtSotien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Học sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Người đóng:";
            // 
            // txtNguoidong
            // 
            this.txtNguoidong.Location = new System.Drawing.Point(148, 417);
            this.txtNguoidong.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguoidong.Name = "txtNguoidong";
            this.txtNguoidong.Size = new System.Drawing.Size(189, 23);
            this.txtNguoidong.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trạng thái:";
            // 
            // cbbHocsinh
            // 
            this.cbbHocsinh.FormattingEnabled = true;
            this.cbbHocsinh.Location = new System.Drawing.Point(148, 286);
            this.cbbHocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHocsinh.Name = "cbbHocsinh";
            this.cbbHocsinh.Size = new System.Drawing.Size(189, 24);
            this.cbbHocsinh.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày đóng:";
            // 
            // dtpNgaydong
            // 
            this.dtpNgaydong.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaydong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaydong.Location = new System.Drawing.Point(148, 353);
            this.dtpNgaydong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaydong.Name = "dtpNgaydong";
            this.dtpNgaydong.Size = new System.Drawing.Size(189, 23);
            this.dtpNgaydong.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnChuadong);
            this.panel1.Controls.Add(this.rbtnDadong);
            this.panel1.Location = new System.Drawing.Point(148, 461);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 48);
            this.panel1.TabIndex = 18;
            // 
            // rbtnChuadong
            // 
            this.rbtnChuadong.AutoSize = true;
            this.rbtnChuadong.Location = new System.Drawing.Point(90, 15);
            this.rbtnChuadong.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnChuadong.Name = "rbtnChuadong";
            this.rbtnChuadong.Size = new System.Drawing.Size(88, 20);
            this.rbtnChuadong.TabIndex = 1;
            this.rbtnChuadong.TabStop = true;
            this.rbtnChuadong.Text = "Chưa đóng";
            this.rbtnChuadong.UseVisualStyleBackColor = true;
            // 
            // rbtnDadong
            // 
            this.rbtnDadong.AutoSize = true;
            this.rbtnDadong.Checked = true;
            this.rbtnDadong.Location = new System.Drawing.Point(4, 15);
            this.rbtnDadong.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnDadong.Name = "rbtnDadong";
            this.rbtnDadong.Size = new System.Drawing.Size(74, 20);
            this.rbtnDadong.TabIndex = 0;
            this.rbtnDadong.TabStop = true;
            this.rbtnDadong.Text = "Đã đóng";
            this.rbtnDadong.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(568, 104);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(304, 23);
            this.txtTimkiem.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhập từ khóa tìm kiếm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "QUẢN LÝ HÓA ĐƠN HỌC PHÍ";
            // 
            // fHoadonHocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1114, 631);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Label label8;
    }
}