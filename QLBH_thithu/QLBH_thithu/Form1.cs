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

namespace QLBH_thithu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hoadon ob = new hoadon();
            dataGridView1.DataSource = ob.Load_hd();
            soluong.Clear(); dongia.Clear();

            mkh.DataSource = ob.Load_kh();//lay su lieu cua maxb tu form xb
            mkh.DisplayMember = "makh";
            mkh.ValueMember = "makh";

            msp.DataSource = ob.Load_sp();
            msp.DisplayMember = "masp";
            msp.ValueMember = "masp";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            soluong.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            dongia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            mhd.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon(mhd.Text, mkh.Text,msp.Text, int.Parse(soluong.Text), int.Parse(dongia.Text));
            ob.insert_kh(ob);
            Form1_Load(sender, e);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon();
            ob.delete_kh(mhd.Text);
            Form1_Load(sender, e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            hoadon ob = new hoadon(mhd.Text, mkh.Text, msp.Text, int.Parse(soluong.Text), int.Parse(dongia.Text));
            ob.update_kh(ob);
            Form1_Load(sender, e);
        }

        private void inhd_Click(object sender, EventArgs e)
        {
            ketnoi ob = new ketnoi();
            string sql = "select mahd,hoten,diachi,tensp,sl,dg,(sl*dg) as thanhtien from hoadon,khachhang,sanpham where hoadon.masp=sanpham.masp and hoadon.makh=khachhang.makh and mahd= '"+mhd.Text+"'";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"G:\source\SQL\QLBH_thithu\QLBH_thithu\Report.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
