using System.Data.SqlClient;
using System.Data;

namespace productManagement.BL
{
    internal class clsProducts
    {
        public DataTable getAllCategories()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllCategories", null);
            DAL.Close();
            return dt;
        }
        public void addProducts(string id_product, string label_product, int qte_in_stock, string price, byte[] img, int id_cat)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;
            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar,30);
            param[1].Value = id_product;
            param[2] = new SqlParameter("@label", SqlDbType.VarChar,30);
            param[2].Value = label_product;
            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte_in_stock;
            param[4] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[4].Value = id_cat;
            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;
            DAL.ExecuteCommand("add_product", param);
            DAL.Close();
        }

        public DataTable verifyProductId(string id)
        {
           
            
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                //DAL.Open();
                DataTable dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
                param[0].Value = id;
                dt = DAL.selectData("verifyProductId", param);
                DAL.Close();
            
                return dt;
            
        }
        public DataTable getAllProducts()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllproducts", null);
            DAL.Close();
            return dt;
        }
        public DataTable searchProduct(string word)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@word", SqlDbType.VarChar, 50);
            param[0].Value = word;
            dt = DAL.selectData("searchProduct", param);
            DAL.Close();
            return dt;
        }
        public DataTable getImageProduct(string word)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = word;
            dt = DAL.selectData("getImageProduct", param);
            DAL.Close();
            return dt;
        }
        public void deleteProduct(string id)  {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
           
            DAL.ExecuteCommand("deleteProduct", param);
            DAL.Close();
        }
        public void update_products(string id_product, string label_product, int qte_in_stock, string price, byte[] img, int id_cat)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;
            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[1].Value = id_product;
            param[2] = new SqlParameter("@label", SqlDbType.VarChar, 30);
            param[2].Value = label_product;
            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte_in_stock;
            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[4].Value = id_cat;
            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;
            DAL.ExecuteCommand("update_products", param);
            DAL.Close();
        }

    }
}
