using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add 3 thu vien de ket noi winfom voi sql
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV
{
    internal class lop
    {
        string malop, tenlop;
        public lop() { }
        public lop(string malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
        //khai bao doi tuong ket noi
        ketnoi kn=new ketnoi();
        public void insert(lop lop1)
        {
            string sql = "insert into lop values ('" + lop1.malop + "','" + lop1.tenlop + "')";
            kn.Execute(sql);
        }
        public void update(lop lop1)
        {
            string sql = "update lop set tenlop='" + lop1.tenlop + "' where malop='" + lop1.malop + "'";
            kn.Execute(sql);
        }
        public void delete(lop lop1)
        {
            string sql = "delete from lop "+" where malop='" + lop1.malop + "'";
            kn.Execute(sql);
        }
        public void hienthi(ListView lv)
        {
            int i = 0;
            string sql = "select * from lop";
            kn.conn.Open();
            SqlCommand cmd=new SqlCommand(sql,kn.conn);
            SqlDataReader doc=cmd.ExecuteReader();
            lv.Items.Clear();
            while(doc.Read())
            {
                lv.Items.Add((i+1).ToString());
                lv.Items[i].SubItems.Add(doc[0].ToString());
                lv.Items[i].SubItems.Add(doc[1].ToString());
                i++;
            }
            kn.conn.Close();
        }
    }
}
