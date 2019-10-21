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
    }
}
