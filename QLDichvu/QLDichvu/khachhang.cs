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
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            mkh.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            tenkh.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dc.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            Class_khachhang ob = new Class_khachhang();
            dataGridView1.DataSource = ob.Load_kh();
            mkh.Clear(); tenkh.Clear();dc.Clear();
        }

        private void mkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            Class_khachhang ob = new Class_khachhang(mkh.Text, tenkh.Text, dc.Text);
            ob.insert_kh(ob);
            khachhang_Load(sender, e);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            Class_khachhang ob = new Class_khachhang(mkh.Text, tenkh.Text, dc.Text);
            ob.update_kh(ob);
            khachhang_Load(sender, e);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            Class_khachhang ob = new Class_khachhang();
            ob.delete_kh(mkh.Text);
            khachhang_Load(sender, e);
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
