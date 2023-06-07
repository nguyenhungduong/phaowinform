using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDichvu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang n = new khachhang();
            n.Show();
        }

        private void dịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dichvu = new dichvu();
            dichvu.Show();
        }

        private void chứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chungtu ob=new chungtu();
            ob.Show();
        }

        private void inKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_in ob=new form_in();
            ob.Show();
        }
    }
}
