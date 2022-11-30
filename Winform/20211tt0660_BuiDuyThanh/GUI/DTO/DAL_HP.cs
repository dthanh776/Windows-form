using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET;


namespace DAL
{
    public class DAL_HP
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FAJNC15\SQLEXPRESS;Initial Catalog=QuanLyHocPhan;Integrated Security=True");
        SqlCommand cmdHP;
        SqlDataAdapter sdaHP;
        DataTable dtHP;

        public DataTable LayDSHP()
        {
            try
            {
                connect.Open();
                string sql = " Select * from HocPhan";
                cmdHP = new SqlCommand();
                cmdHP.CommandText = sql;
                cmdHP.CommandType = CommandType.Text;
                cmdHP.Connection = connect;

                sdaHP = new SqlDataAdapter(cmdHP);
                dtHP = new DataTable();
                sdaHP.Fill(dtHP);
            }
            catch (SqlException)
            {

            }
            finally
            {
                connect.Close();
            }
            return dtHP;
        }

        public bool ThemHP(HocPhan et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdHP = new SqlCommand();
                cmdHP.CommandType = CommandType.StoredProcedure;
                cmdHP.CommandText = "ThemHocPhan";
                cmdHP.Connection = connect;
                //them tham so
                cmdHP.Parameters.Add(new SqlParameter("@MaHP", et.MaHP));
                cmdHP.Parameters.Add(new SqlParameter("@TenHP", et.TenHP));
                cmdHP.Parameters.Add(new SqlParameter("@SoTC", et.SoTC));
                cmdHP.Parameters.Add(new SqlParameter("@SoTietLT", et.SoTietLT));
                cmdHP.Parameters.Add(new SqlParameter("@SoTietTH", et.SoTietTH));
                if (cmdHP.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                connect.Close();
            }
            return flag;
        }

        public bool SuaHP(HocPhan et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdHP = new SqlCommand();
                cmdHP.CommandType = CommandType.StoredProcedure;
                cmdHP.CommandText = "SuaHocPhan";
                cmdHP.Connection = connect;
                //them tham so
                cmdHP.Parameters.Add(new SqlParameter("@MaHP", et.MaHP));
                cmdHP.Parameters.Add(new SqlParameter("@TenHP", et.TenHP));
                cmdHP.Parameters.Add(new SqlParameter("@SoTC", et.SoTC));
                cmdHP.Parameters.Add(new SqlParameter("@SoTietLT", et.SoTietLT));
                cmdHP.Parameters.Add(new SqlParameter("@SoTietTH", et.SoTietTH));
                if (cmdHP.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                connect.Close();
            }
            return flag;
        }

        public bool XoaHP(string et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdHP = new SqlCommand();
                cmdHP.CommandType = CommandType.StoredProcedure;
                cmdHP.CommandText = "XoaHocPhan";
                cmdHP.Connection = connect;
                //them tham so
                cmdHP.Parameters.Add(new SqlParameter("@MaHP", et));
                if (cmdHP.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                connect.Close();
            }
            return flag;
        }
    }
}
