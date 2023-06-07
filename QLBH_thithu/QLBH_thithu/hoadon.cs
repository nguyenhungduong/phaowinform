using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_thithu
{
    internal class hoadon
    {
        private string mahd, makh, masp;
        private int sl, dg;
        public hoadon() { }
        public hoadon(string mahd, string makh, string masp, int sl, int dg)
        {
            this.mahd = mahd;
            this.makh = makh;
            this.masp = masp;
            this.sl = sl;
            this.dg = dg;
        }

        ketnoi ob=new ketnoi();
        public DataTable Load_hd()
        {
            string sql = "select * from hoadon ";
            return ob.Load(sql);
        }
        public DataTable Load_kh()
        {
            string sql = "select * from khachhang ";
            return ob.Load(sql);
        }
        public DataTable Load_sp()
        {
            string sql = "select * from sanpham ";
            return ob.Load(sql);
        }
        public void insert_kh(hoadon ob1)
        {
            string sql = "insert hoadon values('" + ob1.mahd + "','" + ob1.masp + "','" + ob1.makh + "',"+ob1.sl+","+ob1.dg+")";
            ob.Execute(sql);
        }
        public void update_kh(hoadon ob2)
        {
            string sql = "update hoadon set masp='" + ob2.masp + "',makh='" + ob2.makh + "',sl="+ob2.sl+",dg="+ob2.dg+" where mahd='" + ob2.mahd + "'";
            ob.Execute(sql);
        }

        public void delete_kh(string mas)
        {
            string sql = "delete from hoadon where mahd='" + mas + "'";
            ob.Execute(sql);
        }
    }
}
