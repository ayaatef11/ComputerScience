using System.Data.SqlClient;
using System.Data;
namespace productManagement.BL
{
     class cls_login
    {
        public DataTable login(string id,string pwd)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;
            DataTable dt = new DataTable();
            dt = DAL.selectData("sp_login", param);
            DAL.Close();
            return dt;
        }
    }
}
