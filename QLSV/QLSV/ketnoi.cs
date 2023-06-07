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
    internal class ketnoi
    {
       public SqlConnection conn=new SqlConnection("Data Source=DESKTOP-IPK4QAE;Initial Catalog=QLSV;Integrated Security=True");
       public void Execute(string sql)
        {
            conn.Open();
            SqlCommand cmd=new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
        }
    }
}
