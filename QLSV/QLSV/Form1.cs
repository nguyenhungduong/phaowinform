using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhapDuLieuBangLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_lop n=new form_lop();
            n.Show();
        }

        private void nhapDuLieuBangSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_sv a=new form_sv();
            a.Show();
        }
    }
}
