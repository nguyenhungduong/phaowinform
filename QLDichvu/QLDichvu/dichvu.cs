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
    public partial class dichvu : Form
    {
        public dichvu()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            class_dichvu ob = new class_dichvu(mdv.Text, tdv.Text, int.Parse( dg.Text));
            ob.insert_dv(ob);
            dichvu_Load(sender, e);
        }

        private void dichvu_Load(object sender, EventArgs e)
        {
            class_dichvu ob = new class_dichvu();
            dataGridView1.DataSource = ob.Load_dv();
            mdv.Clear(); tdv.Clear(); dg.Clear();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            mdv.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            tdv.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dg.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

        }

        private void sua_Click(object sender, EventArgs e)
        {
            class_dichvu ob = new class_dichvu(mdv.Text, tdv.Text, int.Parse(dg.Text));
            ob.update_dv(ob);
            dichvu_Load(sender, e);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            class_dichvu ob = new class_dichvu();
            ob.delete_dv(mdv.Text);
            dichvu_Load(sender, e);
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
