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
    public partial class form_lop : Form
    {
        public form_lop()
        {
            InitializeComponent();
        }

        private void form_lop_Load(object sender, EventArgs e)
        {
            lop lop1=new lop();
            lop1.hienthi(listView1);
        }

        private void them_Click(object sender, EventArgs e)
        {
            lop lop1= new lop(ma.Text,ten.Text);
            lop1.insert(lop1);
            form_lop_Load(sender, e);
        }

        private void chon_lop(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var t = e.Item;
            ma.Text = t.SubItems[1].Text;
            ten.Text = t.SubItems[2].Text;
            ma.Enabled = false;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            lop lop1 = new lop(ma.Text, ten.Text);
            lop1.update(lop1);
            form_lop_Load(sender, e);
            ten.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {

            lop lop1 = new lop(ma.Text, ten.Text);
            lop1.delete(lop1);
            form_lop_Load(sender, e);
        }

        private void ht_Click(object sender, EventArgs e)
        {

        }

        private void trovemenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
