using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyQQ
{
    // ���ݿ�����࣬ά�����ݿ������ַ��������ݿ����Ӷ���
    class DBHelper
    {
        private static string connString = "Data Source=PC201401280007;Initial Catalog=MyQQ;User ID=sa;Pwd=123456";
        public static SqlConnection connection = new SqlConnection(connString);
    }
}
