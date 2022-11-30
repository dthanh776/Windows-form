using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_HoaDon
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FAJNC15\SQLEXPRESS;Initial Catalog=QLHoadon;Integrated Security=True");
        SqlCommand cmdHD;
        SqlDataAdapter sdaHD;
        DataTable dtHD;

        public DataTable LayHoaDon()
        {
            try
            {
                conn.Open();
                string sql = " Select * from HoaDon";
                cmdHD = new SqlCommand();
                cmdHD.CommandText = sql;
                cmdHD.CommandType = CommandType.Text;
                cmdHD.Connection = conn;

                sdaHD = new SqlDataAdapter(cmdHD);
                dtHD = new DataTable();
                sdaHD.Fill(dtHD);

            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtHD;
        }

        public bool ThemHoaDon(DTO_HoaDon dto)
        {
            bool flag = false;
            try
            {
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.CommandText = "ThemHoaDon";
                cmdHD.Connection = conn;

                cmdHD.Parameters.Add(new SqlParameter("@MaHD", dto.MaHoaDon));
                cmdHD.Parameters.Add(new SqlParameter("@TenKH", dto.TenKH));
                cmdHD.Parameters.Add(new SqlParameter("@SoDienthoaiKH", dto.SoDienThoai));
                cmdHD.Parameters.Add(new SqlParameter("@TenHang", dto.TenHang));
                cmdHD.Parameters.Add(new SqlParameter("@Ngaymua", dto.NgayMua));
                cmdHD.Parameters.Add(new SqlParameter("@SoLuong", dto.SoLuong));
                cmdHD.Parameters.Add(new SqlParameter("@DonGia", dto.DonGia));
                cmdHD.Parameters.Add(new SqlParameter("@Thanhtien", dto.ThanhTien));
                if (cmdHD.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public bool SuaHoaDon(DTO_HoaDon dto)
        {
            bool flag = false;
            try
            {
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.CommandText = "SuaHoaDon";
                cmdHD.Connection = conn;

                cmdHD.Parameters.Add(new SqlParameter("@MaHD", dto.MaHoaDon));
                cmdHD.Parameters.Add(new SqlParameter("@TenKH", dto.TenKH));
                cmdHD.Parameters.Add(new SqlParameter("@SoDienthoaiKH", dto.SoDienThoai));
                cmdHD.Parameters.Add(new SqlParameter("@TenHang", dto.TenHang));
                cmdHD.Parameters.Add(new SqlParameter("@Ngaymua", dto.NgayMua));
                cmdHD.Parameters.Add(new SqlParameter("@SoLuong", dto.SoLuong));
                cmdHD.Parameters.Add(new SqlParameter("@DonGia", dto.DonGia));
                cmdHD.Parameters.Add(new SqlParameter("@Thanhtien", dto.ThanhTien));
                if (cmdHD.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public bool XoaHoaDon(string dto)
        {
            bool flag = false;
            try
            {
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.CommandText = "XoaHoaDon";
                cmdHD.Connection = conn;


                cmdHD.Parameters.Add(new SqlParameter("@MaHD", dto));

                if (cmdHD.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

        public DataTable TimHoaDon(string dto)
        {
            bool flag = false;
            try
            {
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.CommandText = "TimHoaDon";
                cmdHD.Connection = conn;

                cmdHD.Parameters.Add(new SqlParameter("@MaHD", dto));
                if (cmdHD.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
