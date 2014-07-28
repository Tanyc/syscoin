using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.MySQLClient;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQLConnection m_objCon = new MySQLConnection();
            MySQLDataAdapter m_objDA = new MySQLDataAdapter();
            try
            {
                m_objCon.ConnectionString = "Location=localhost;User ID=root;Password=;Data Source=bieggs";
                m_objCon.Open();

                //以下用例测试通过
                string query = "insert into bi_tiyan values(14, '测试name', '2000', 'test.jpg','1')";
                /*m_objDA.SelectCommand = new MySQLCommand(query, m_objCon);
                m_objDS = new DataSet();
                m_objDA.Fill(m_objDS, "id");*/
                /********************************************/
                MySQLCommand cmd = new MySQLCommand(query, m_objCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                //m_objCon.Close();
            }
        }
    }
}
