using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private static string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public static string ConnectionString
        {
            get { return connectionString; }
        }
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
