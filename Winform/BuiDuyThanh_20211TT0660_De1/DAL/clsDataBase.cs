using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class clsDataBase
    {
        public SqlConnection sqlConn = new SqlConnection();
        string sConnection = @"Data Source=DESKTOP-FAJNC15\SQLEXPRESS;Initial Catalog=QuanLyBanThuoc;Integrated Security=True";
        public clsDataBase()
        {
            try
            {
                sqlConn.ConnectionString = sConnection;
                sqlConn.Open();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
