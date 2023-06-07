using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDichvu
{
    internal class class_dichvu
    {
        private String madv, tendv;
        private int dongia;
        public class_dichvu() { }
        public class_dichvu(string madv, string tendv, int dongia)
        {
            this.madv = madv;
            this.tendv = tendv;
            this.dongia = dongia;
        }

        connect ob= new connect();
        public DataTable Load_dv()
        {
            string sql = "select * from dichvu ";
            return ob.Load(sql);
        }

        public void insert_dv(class_dichvu ob1)
        {
            
            try
            {
                string sql = "insert dichvu values('" + ob1.madv + "','" + ob1.tendv + "'," + ob1.dongia + ")";
                ob.Execute(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("trùng khóa chính");
            }
        }
        public void update_dv(class_dichvu ob2)
        {
            string sql = "update dichvu set Tendv='" + ob2.tendv + "',Dongia='" + ob2.dongia + "' where Madv='" + ob2.madv + "'";
            ob.Execute(sql);
        }

        public void delete_dv(string madv)
        {
            string sql = "delete from dichvu where Madv='" + madv + "'";
            ob.Execute(sql);
        }
    }
}
