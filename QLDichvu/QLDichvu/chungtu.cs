using Microsoft.Reporting.WinForms;
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
    public partial class chungtu : Form
    {
        public chungtu()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            mct.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            sl.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void chungtu_Load(object sender, EventArgs e)
        {
            class_chungtu ob = new class_chungtu();
            dataGridView1.DataSource = ob.Load_ct();
            mct.Clear();sl.Clear();

            Class_khachhang ob1= new Class_khachhang();
            mkh.DataSource = ob1.Load_kh();//lay su lieu cua maxb tu form xb
            mkh.DisplayMember = "makh";
            mkh.ValueMember = "makh";

            class_dichvu ob2= new class_dichvu();
            mdv.DataSource = ob2.Load_dv();
            mdv.DisplayMember = "makh";
            mdv.ValueMember = "madv";
        }

        private void them_Click(object sender, EventArgs e)
        {
            class_chungtu ob = new class_chungtu(time.Value,mct.Text,mkh.Text,mdv.Text,int.Parse(sl.Text));
            ob.insert_ct(ob);
            chungtu_Load(sender, e);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            class_chungtu ob = new class_chungtu(time.Value, mct.Text, mkh.Text, mdv.Text, int.Parse(sl.Text));
            ob.update_ct(ob);
            chungtu_Load(sender, e);
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            class_chungtu ob = new class_chungtu();
            ob.delete_ct(mct.Text);
            chungtu_Load(sender, e);
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inkh_Click(object sender, EventArgs e)
        {
           
        }
    }
}
