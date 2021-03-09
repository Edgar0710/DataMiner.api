using System;
using System.Data;
using System.Data.SqlClient;

namespace dataMiner.Data
{
    public class DataRepository : IDisposable
    {
        protected IDbConnection conn;
        
        public DataRepository()
        {
           string strConnection = @"Data Source=45.63.18.178\LETS;Initial Catalog=dACTMON; Persist Security Info=True;User ID=sa;Password=Lets_2020; Pooling=true; Max Pool Size=200; MultipleActiveResultSets=True;";
          conn = new SqlConnection(strConnection);
        }
        public void Dispose()
        {
            conn.Close();  
        }
    }
}
