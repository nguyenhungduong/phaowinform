using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDichvu
{
    internal class Class_khachhang
    {
        private String makh, tenkh, diachi;
        public Class_khachhang() { }
        public Class_khachhang(string makh, string tenkh, string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
        }
        connect ob = new connect();
        
        public DataTable Load_kh()
        {
            string sql = "select * from kh ";
            return ob.Load(sql);
        }
        
        public void insert_kh(Class_khachhang ob1)
        {
            try
            {
                string sql = "insert kh values('" + ob1.makh + "','" + ob1.tenkh + "','" + ob1.diachi + "')";
                ob.Execute(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("trùng khóa chính");
            }
        }
        public void update_kh(Class_khachhang ob2)
        {
            string sql = "update kh set Htkh='"+ob2.tenkh+"',Diachi='"+ob2.diachi+"' where Makh='"+ob2.makh+"'";
            ob.Execute(sql);
        }

        public void delete_kh(string makh)
        {
            string sql = "delete from kh where Makh='" + makh + "'";
            ob.Execute(sql);
        }
    }
}
