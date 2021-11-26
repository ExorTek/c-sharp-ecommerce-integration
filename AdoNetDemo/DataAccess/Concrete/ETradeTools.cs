using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccess.Concrete
{
    public class ETradeTools
    {
        public SqlConnection ETradeConnection()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Data Source = MEMET; Initial Catalog = ETRADE; Integrated Security = True");
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            return sqlConnection;
            
            //using (SqlConnection sqlConnection = new SqlConnection())
            //{
            //    sqlConnection.ConnectionString =
            //        "Data Source = MEMET; Initial Catalog = ETRADE; Integrated Security = True";
            //    if (sqlConnection.State != ConnectionState.Open)
            //    {
            //        sqlConnection.Open();
            //    }

            //    return sqlConnection;
            //}
        }

        //public void ETradeConnection()
        //{
        //    using (SqlConnection sqlConnection = new SqlConnection("Data Source = MEMET; Initial Catalog = ETRADE; Integrated Security = True"))
        //    {
        //        if (sqlConnection.State != ConnectionState.Open)
        //        {
        //            sqlConnection.Open();
        //        }
        //        return sqlConnection;
        //    }
        //}

    }
}