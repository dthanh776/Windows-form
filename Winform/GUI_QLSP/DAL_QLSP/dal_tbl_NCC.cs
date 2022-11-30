using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET_QLSP;
namespace DAL_QLSP
{
    public class dal_tbl_NCC
    {
        //connect
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FAJNC15\SQLEXPRESS;Initial Catalog=QUANLYSANPHAM;Integrated Security=True");
        SqlCommand cmdNCC;
        SqlDataAdapter daNCC;
        DataTable dtNCC;

        //method
        public DataTable LayDSNCC()
        {
            try
            {
                connect.Open();
                string sql = " Select * from tbl_NCC";
                cmdNCC = new SqlCommand();
                cmdNCC.CommandText = sql;
                cmdNCC.CommandType = CommandType.Text;
                cmdNCC.Connection = connect;

                daNCC = new SqlDataAdapter(cmdNCC);
                dtNCC = new DataTable();
                daNCC.Fill(dtNCC);
            }
            catch (SqlException)
            {

            }
            finally
            {
                connect.Close();
            }
            return dtNCC;
        }
        public DataTable LayTenNCC()
        {
            try
            {
                connect.Open();
                string sql = " Select tenNCC,msNCC from tbl_NCC";
                cmdNCC = new SqlCommand();
                cmdNCC.CommandText = sql;
                cmdNCC.CommandType = CommandType.Text;
                cmdNCC.Connection = connect;

                daNCC = new SqlDataAdapter(cmdNCC);
                dtNCC = new DataTable();
                daNCC.Fill(dtNCC);
            }
            catch (SqlException)
            {

            }
            finally
            {
                connect.Close();
            }
            return dtNCC;
        }
        public bool ThemNCC(ET_NCC et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdNCC = new SqlCommand();
                cmdNCC.CommandType = CommandType.StoredProcedure;
                cmdNCC.CommandText = "sp_ThemNCC";
                cmdNCC.Connection = connect;
                //them tham so
                cmdNCC.Parameters.Add(new SqlParameter("@MsNCC", et.MsNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@TenNCC", et.TenNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@DiaChi", et.DiachiNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@SDTNCC", et.SoDTNCC));
                if (cmdNCC.ExecuteNonQuery() > 0)
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

        public bool SuaNCC(ET_NCC et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdNCC = new SqlCommand();
                cmdNCC.CommandType = CommandType.StoredProcedure;
                cmdNCC.CommandText = "sp_SuaNCC";
                cmdNCC.Connection = connect;
                //them tham so
                cmdNCC.Parameters.Add(new SqlParameter("@MsNCC", et.MsNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@TenNCC", et.TenNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@DiaChi", et.DiachiNCC));
                cmdNCC.Parameters.Add(new SqlParameter("@SDTNCC", et.SoDTNCC));
                if (cmdNCC.ExecuteNonQuery() > 0)
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

        public bool XoaNCC(String et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdNCC = new SqlCommand();
                cmdNCC.CommandType = CommandType.StoredProcedure;
                cmdNCC.CommandText = "sp_XoaNCC";
                cmdNCC.Connection = connect;
                //them tham so
                cmdNCC.Parameters.Add(new SqlParameter("@MsNCC", et));
                if (cmdNCC.ExecuteNonQuery() > 0)
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
