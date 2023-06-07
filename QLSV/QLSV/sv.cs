using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV
{
    internal class sv
    {
        private string masv,hoten,malop;
        DateTime ngs;
        public sv() { }
        public sv(string masv, string hoten, DateTime ngs, string malop)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ngs = ngs;
            this.malop = malop;
        }
        kn_disconn ob=new kn_disconn();
        public DataTable Load_sv()
        {
            string sql = "select * from sv";
            return ob.Load(sql);
        }
        public DataTable Load_lop()
        {
            string sql = "select * from lop";
            return ob.Load(sql);
        }
        public void insert_sv(sv ob1) {
            string sql = "Insert sv values('" + ob1.masv + "','" + ob1.hoten + "','" + ob1.ngs + "','" + ob1.malop + "')";
            ob.Execute(sql);
        }
        public void update_sv(sv ob2)
        {
            string sql = "update sv set sv.hoten='" + ob2.hoten + "',sv.ns ='" + ob2.ngs + "',sv.Malop='" + ob2.malop + "' where sv.Masv='" + ob2.masv + "'";
            ob.Execute(sql);
        }

        public void delete_sv(string masv)
        {
            string sql = "delete from sv where masv='" + masv + "'";
            ob.Execute(sql);
        }
    }
}
