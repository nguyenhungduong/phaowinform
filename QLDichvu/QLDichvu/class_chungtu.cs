using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDichvu
{
    internal class class_chungtu
    {
        private DateTime ngay;
        private String mct, mkh, mdv;
        private int soluong;
        public class_chungtu(DateTime ngay, string mct, string mkh, string mdv, int soluong)
        {
            this.ngay = ngay;
            this.mct = mct;
            this.mkh = mkh;
            this.mdv = mdv;
            this.soluong = soluong;
        }
        public class_chungtu() { 
        }
        connect ob=new connect();
        public DataTable Load_ct()
        {
            string sql = "select * from chungtu ";
            return ob.Load(sql);
        }

        public void insert_ct(class_chungtu ob1)
        {
            try
            {
                string sql = "insert chungtu values('" + ob1.mct + "','" + ob1.ngay + "','" + ob1.mkh + "','" + ob1.mdv + "'," + ob1.soluong + ")";
                ob.Execute(sql);
            }catch (Exception ex)
            {
                MessageBox.Show("trùng khóa chính");
            }
        }
        public void update_ct(class_chungtu ob2)
        {
            string sql = "update chungtu set Ngay='"+ob2.ngay+"',Makh='"+ob2.mkh+"',Madv='"+ob2.mdv+"',Soluong= "+ob2.soluong+" where Mact='"+ob2.mct+"'";
            ob.Execute(sql);
        }

        public void delete_ct(string mact)
        {
            string sql = "delete from chungtu where Mact='" + mact + "'";
            ob.Execute(sql);
        }
    }
}
