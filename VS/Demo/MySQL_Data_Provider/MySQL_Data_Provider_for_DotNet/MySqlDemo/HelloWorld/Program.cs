using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySQLDriverCS;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            MySQLConnection conn = null;
            try
            {
                /********************法1***********************/
                /*conn = new MySQLConnection(new MySQLConnectionString("localhost", "bieggs", "root", "").AsString);
                conn.Open();
                MySQLCommand commn = new MySQLCommand("set names gb2312", conn);
                commn.ExecuteNonQuery();
                string sql = "select * from bi_tiyan";
                MySQLDataAdapter mda = new MySQLDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "name");
                conn.Close();*/
                /********************法2***********************/
                string connstr = "Data Source=bieggs;Password=;User ID=root;Location=localhost";
                conn = new MySQLConnection(connstr);
                conn.Open();
                string query = "insert into bi_tiyan values(14, '测试name', '2000', 'test.jpg','1')";
                string tmp = null;
                MySQLCommand cmd = new MySQLCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
