using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_WorkFlow
{
    public class DaoConnection
    {
        public static SqlConnection GetConexao()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=movtech;Integrated Security=True;MultipleActiveResultSets=true;");
            connection.Open();
            return connection;
        }
    }
}
