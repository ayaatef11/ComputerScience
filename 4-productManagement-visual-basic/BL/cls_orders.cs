
using System.Data;
namespace productManagement.BL
{
    internal class cls_orders
    {
        public DataTable get_last_order()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("get_last_order", null);
            DAL.Close();
            return dt;
        }
    }
}
