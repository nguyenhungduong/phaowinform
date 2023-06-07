using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDichvu
{
    //Data Source=DESKTOP-IPK4QAE;Initial Catalog=QLDichvu;Integrated Security=True
    internal class connect
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IPK4QAE;Initial Catalog=QLDichvu;Integrated Security=True");
        public void Execute(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
          
            ad.Fill(dt);//do du lieu tu database vao datatable
           
            ad.Update(dt);//update lai database tu datatable
            dt.AcceptChanges();//co chap nhan update k ?
        }
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();//ham tao
            SqlCommand comSelect = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = comSelect;
            ad.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }
    }
}
