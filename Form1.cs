﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGBK3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thôngTinLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fLop fLop = new fLop();
            fLop.MdiParent = this;
            fLop.Show();
        }

        private void thôngTinHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fHocsinh fHocsinh = new fHocsinh();
            fHocsinh.MdiParent = this;
            fHocsinh.Show();
        }

        private void closeAllOpenWindow()
        {
            Form[] allChildren = this.MdiChildren;
            foreach (var child in allChildren)
            {
                child.Close();
            }
              
        }

        private void thôngTinClbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fCLB fCLB = new fCLB();
            fCLB.MdiParent = this;
            fCLB.Show();
        }

        private void thôngTinLớpCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fLopCLB fCLB = new fLopCLB();
            fCLB.MdiParent = this;
            fCLB.Show();
        }

        private void thôngTinHóaĐơnHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fHoadonHocphi fHoadon = new fHoadonHocphi();
            fHoadon.MdiParent = this;
            fHoadon.Show();
        }

        private void theoHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fThoikhoabieu.byStudent = true;
            fThoikhoabieu form = new fThoikhoabieu();
            form.MdiParent = this;
            form.Show();
        }

        private void toànBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fThoikhoabieu.byStudent = false;
            fThoikhoabieu form = new fThoikhoabieu();
            form.MdiParent = this;
            form.Show();
        }

        private void họcPhíTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void họcSinhTheoLớpCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fHocsinhTheoLopCLB form = new fHocsinhTheoLopCLB();
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                closeAllOpenWindow();
                fChitiethoadon form = new fChitiethoadon();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void họcPhíTheoHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllOpenWindow();
            fReportHoadonTheoHS form = new fReportHoadonTheoHS();
            form.MdiParent = this;
            form.Show();
        }
    }
}
