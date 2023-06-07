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
    public partial class form_in : Form
    {
        public form_in()
        {
            InitializeComponent();
        }

        private void form_in_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect ob = new connect();
            string sql = "select kh.Makh,Htkh,Diachi,Dongia,Tendv from dichvu,kh,chungtu where chungtu.Makh=kh.Makh and chungtu.Madv=dichvu.Madv and Dongia<100";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"G:\source\SQL\QLDichvu\QLDichvu\Report.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
