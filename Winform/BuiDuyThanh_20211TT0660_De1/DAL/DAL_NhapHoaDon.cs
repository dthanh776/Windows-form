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
    public class DAL_NhapHoaDon
    {
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        clsDataBase clData = new clsDataBase();

        public DataTable hienThiHoaDon(string tenStore)
        {
            dt = null;
            try
            {
                cmd = new SqlCommand(tenStore, clData.sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        public int LuuHoaDon (DTO_NhapHoaDon hoaDon)
        {
            int ketQua;
            SqlCommand sqlCmd = new SqlCommand("LuuHoaDon", clData.sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@MaHD", hoaDon.MaHoaDon);
            sqlCmd.Parameters.AddWithValue("@Ngayban", hoaDon.NgayBan);
            sqlCmd.Parameters.AddWithValue("@TenHieuThuoc", hoaDon.TenHieuThuoc);
            sqlCmd.Parameters.AddWithValue("@DiaChi", hoaDon.DiaChi);
            ketQua = sqlCmd.ExecuteNonQuery();

            return ketQua;
        }
        public int SuaHoaDon(DTO_NhapHoaDon hoaDon)
        {
            int ketQua;
            SqlCommand sqlCmd = new SqlCommand("SuaHoaDon", clData.sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@MaHD", hoaDon.MaHoaDon);
            sqlCmd.Parameters.AddWithValue("@Ngayban", hoaDon.NgayBan);
            sqlCmd.Parameters.AddWithValue("@TenHieuThuoc", hoaDon.TenHieuThuoc);
            sqlCmd.Parameters.AddWithValue("@DiaChi", hoaDon.DiaChi);
            ketQua = sqlCmd.ExecuteNonQuery();

            return ketQua;
        }
        public bool XoaHoaDon(string ma)
        {
            bool flag = false;
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHoaDon";
                cmd.Connection = clData.sqlConn;
                cmd.Parameters.Add(new SqlParameter("@MaHD", ma));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return flag;
        }
        public bool CheckTonTai(DTO_NhapHoaDon hoaDon)
        {
            dt = null;
            try
            {

                cmd = new SqlCommand("checkTonTaiHoaDon", clData.sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", hoaDon.MaHoaDon);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return false;
        }
        public DataTable TimHoaDon(string a, string maHoaDon)
        {
            dt = null;
            try
            {
                cmd = new SqlCommand(a, clData.sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHoaDon));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return dt;
        }
        public DataTable TimMaThuoc(string a, string maThuoc)
        {
            dt = null;
            try
            {
                cmd = new SqlCommand(a, clData.sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaThuoc", maThuoc));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return dt;
        }
    }
}
