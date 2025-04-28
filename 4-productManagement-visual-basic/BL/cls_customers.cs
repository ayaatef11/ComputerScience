using System.Data;
using System.Data.SqlClient;

namespace productManagement.BL
{
    internal class cls_customers
    {
        public void addCustomers(string first_name, string last_name, string tel,string  email,byte[] image_customer=null)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar,25);
            param[0].Value = first_name;
            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;
            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;
            param[3] = new SqlParameter("@email", SqlDbType.VarChar,25);
            param[3].Value = email;
            param[4] = new SqlParameter("@picture", SqlDbType.Image);
            param[4].Value = image_customer;
            DAL.ExecuteCommand("add_customer", param);
            DAL.Close();
        }
        public DataTable getAllCustomers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllCustomers", null);
            DAL.Close();
            return dt;
        }
        public void EditCustomers(string first_name, string last_name, string tel, string email, byte[] image_customer = null)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;
            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;
            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;
            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;
            param[4] = new SqlParameter("@picture", SqlDbType.Image);
            param[4].Value = image_customer;
            DAL.ExecuteCommand("edit_customer", param);
            DAL.Close();
        }
    }
}
