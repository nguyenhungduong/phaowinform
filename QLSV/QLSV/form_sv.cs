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
    public partial class form_sv : Form
    {
        public form_sv()
        {
            InitializeComponent();
        }

        private void form_sv_Load(object sender, EventArgs e)
        {
            sv ob= new sv();
            dataGridView1.DataSource= ob.Load_sv();
            msv.Clear();tensv.Clear(); 
            ma.DataSource= ob.Load_lop();//lay su lieu cua ma lop tu form lop
            ma.DisplayMember = "tenlop";
            ma.ValueMember = "malop";

        }

        private void them_Click(object sender, EventArgs e)
        {
            sv ob1= new sv(msv.Text,tensv.Text,dateTimePicker1.Value,ma.SelectedValue.ToString());
            ob1.insert_sv(ob1);
            form_sv_Load(sender, e);
            msv.Enabled = false;//k nhap vao msv
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            msv.Enabled=true;
        }

        private void chon_sk(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            msv.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            tensv.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            ma.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            msv.Enabled=false;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            sv ob1 = new sv(msv.Text, tensv.Text, dateTimePicker1.Value, ma.Text);
            ob1.update_sv(ob1);
            form_sv_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            sv ob1 = new sv();
            ob1.delete_sv(msv.Text);
            form_sv_Load(sender, e);
        }

        private void trave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
