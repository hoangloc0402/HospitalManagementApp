using Infragistics.Win.UltraWinToolbars;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HospitalManagementApp
{
    class DatabaseHelper
    {
        OracleConnection conn;
        public DatabaseHelper(OracleConnection conn) {
            this.conn = conn;
        }
        public DataTableCollection TimBN(String maBN,out String ten) {
            OracleCommand cmd = new OracleCommand("TIMBN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MABN", OracleDbType.Varchar2).Value = maBN;
            cmd.Parameters.Add("P_TENBN", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_SDT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_DOTDIEUTRI", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_LANKHAMBENH", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ten = cmd.Parameters["P_TENBN"].Value.ToString();
            DataSet ds = new DataSet();
            da.Fill(ds, "A");
            return ds.Tables;
        }
        public void ThemBN(String mabn, String ten,String diachi,String loai) {
            OracleCommand cmd = new OracleCommand("THEMBN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MABN", OracleDbType.Varchar2).Value = mabn;
            cmd.Parameters.Add("P_TENBN", OracleDbType.Varchar2).Value = ten;
            cmd.Parameters.Add("P_DIACHI", OracleDbType.Varchar2).Value = diachi;
            cmd.Parameters.Add("P_LOAI", OracleDbType.Varchar2).Value = loai;
            //cmd.Parameters.Add("P_MANV", OracleDbType.Varchar2).Value = manv;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public DataTableCollection TaoBaoCao(String mabn, out String ten,out String tongtien)
        {
            OracleCommand cmd = new OracleCommand("TAOBAOCAO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_MABN", OracleDbType.Varchar2).Value = mabn;
            cmd.Parameters.Add("P_TENBN", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_BENHAN", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_CAPHAUTHUAT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_DOTDIEUTRI", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_THUOC", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_DUNGCU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_TONGTIEN", OracleDbType.Int32).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            ten = cmd.Parameters["P_TENBN"].Value.ToString();
            tongtien = cmd.Parameters["P_TONGTIEN"].Value.ToString();
            DataSet ds = new DataSet();
            da.Fill(ds, "A");
            return ds.Tables;
        }
    }
}
