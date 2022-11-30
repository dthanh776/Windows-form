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
     public class dal_tbl_sanpham
    {
        //connect
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FAJNC15\SQLEXPRESS;Initial Catalog=QUANLYSANPHAM;Integrated Security=True");
        SqlCommand cmdsanpham;
        SqlDataAdapter dasanpham;
        DataTable dtsanpham;

        //method
        public DataTable LayDSSanPham()
        {
            try
            {
                connect.Open();
                cmdsanpham = new SqlCommand();
                string sql = "select * from tbl_sanpham";
                cmdsanpham.CommandText = sql;
                cmdsanpham.CommandType = CommandType.Text;
                cmdsanpham.Connection = connect;

                dasanpham = new SqlDataAdapter(cmdsanpham);
                dtsanpham = new DataTable();
                dasanpham.Fill(dtsanpham);
            }catch(SqlException )
            {
                
            }
            finally
            {
                connect.Close();
            }
            return dtsanpham;
        }
        public DataTable LayTenSanPham(string et)
        {
            try
            {
                connect.Open();
                cmdsanpham = new SqlCommand("sp_TimSanPham", connect);
                cmdsanpham.CommandType = CommandType.StoredProcedure;
                cmdsanpham.Parameters.Add(new SqlParameter("@msNCC", et));
                dasanpham = new SqlDataAdapter(cmdsanpham);
                dtsanpham = new DataTable();
                dasanpham.Fill(dtsanpham);
            }
            catch (SqlException)
            {

            }
            finally
            {
                connect.Close();
            }
            return dtsanpham;
        }
        public bool ThemSanPham(ET_sanpham et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdsanpham = new SqlCommand();
                cmdsanpham.CommandType = CommandType.StoredProcedure;
                cmdsanpham.CommandText = "sp_ThemSanPham";
                cmdsanpham.Connection = connect;
                //them tham so
                cmdsanpham.Parameters.Add(new SqlParameter("@maSP", et.MaSP));
                cmdsanpham.Parameters.Add(new SqlParameter("@tenSP", et.TenSP));
                cmdsanpham.Parameters.Add(new SqlParameter("@msNCC", et.MsNCC));
                cmdsanpham.Parameters.Add(new SqlParameter("@dacTa", et.DacTa));
                cmdsanpham.Parameters.Add(new SqlParameter("@giaDC", et.GiaDC));
                if (cmdsanpham.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException )
            {
            }
            finally
            {
                connect.Close();
            }
            return flag;
        }
        public bool SuaSanPham(ET_sanpham et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdsanpham = new SqlCommand();
                cmdsanpham.CommandType = CommandType.StoredProcedure;
                cmdsanpham.CommandText = "sp_SuaSanPham";
                cmdsanpham.Connection = connect;
                //them tham so
                cmdsanpham.Parameters.Add(new SqlParameter("@maSP", et.MaSP));
                cmdsanpham.Parameters.Add(new SqlParameter("@tenSP", et.TenSP));
                cmdsanpham.Parameters.Add(new SqlParameter("@msNCC", et.MsNCC));
                cmdsanpham.Parameters.Add(new SqlParameter("@dacTa", et.DacTa));
                cmdsanpham.Parameters.Add(new SqlParameter("@giaDC", et.GiaDC));
                if (cmdsanpham.ExecuteNonQuery() > 0)
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

        public bool XoaSanPham(string et)
        {
            bool flag = false;
            try
            {
                connect.Open();
                cmdsanpham = new SqlCommand();
                cmdsanpham.CommandType = CommandType.StoredProcedure;
                cmdsanpham.CommandText = "sp_XoaSanPham";
                cmdsanpham.Connection = connect;
                //them tham so
                cmdsanpham.Parameters.Add(new SqlParameter("@maSP", et));
                if (cmdsanpham.ExecuteNonQuery() > 0)
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
