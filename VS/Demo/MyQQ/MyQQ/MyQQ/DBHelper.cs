using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyQQ
{
    // 数据库帮助类，维护数据库连接字符串和数据库连接对象
    class DBHelper
    {
        private static string connString = "Data Source=PC201401280007;Initial Catalog=MyQQ;User ID=sa;Pwd=123456";
        public static SqlConnection connection = new SqlConnection(connString);
    }
}
