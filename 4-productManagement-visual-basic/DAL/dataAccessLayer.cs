
using System.Data.SqlClient;
using System.Data;
namespace productManagement.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection;
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection(@"Server=AYAATEF1;Database=product_db;Integrated Security=true");
        }
        public void Open()
        {
            if(sqlConnection.State !=ConnectionState. Open) {
            sqlConnection.Open();
            }
        }
        public void Close()
        {
            if(sqlConnection.State !=ConnectionState.Closed) { 
                sqlConnection.Close(); 
            }

        }
        public DataTable selectData(string stored_procedure, SqlParameter[]param)
        {
            SqlCommand sqlcmd=new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if(param != null )
            {
                for(int i=0;i<param.Length;i++)
                {
                    sqlcmd.Parameters.Add(param[i]); 
                }
            }
            SqlDataAdapter da =new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return dt;
        }
        public void ExecuteCommand(string stored_procedure, SqlParameter[]param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType= CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if(param != null )
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
