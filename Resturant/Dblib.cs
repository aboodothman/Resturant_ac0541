using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmDBProject
{
    internal class Dblib
    {
        /*private const string connString = "data source=ABOOD\\MSSQLSERVER01; initial catalog = architecture; persist security info = True; Integrated Security = SSPI;";
        private static SqlConnection conn = new SqlConnection(connString);
        private static SqlCommand cmd=new SqlCommand();
        private static SqlDataReader reader=null;*/

        public static bool verifyUserNamePassword(string Username,string Password)
        {
            if(Username == "Abood1" && Password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public static bool excuteNonQuery(string Sql)//تنفيذ العملياتexcuteNonQuery (حذف واضافة uppdat ,insarte..etc
        {
            bool result = false;
            conn.Open();
            cmd.CommandText = Sql;
            result = (cmd.ExecuteNonQuery() != -1);
            conn.Close();
            return result;
        }*/
    }
}
