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
            MySQLConnection m_objCon = null;
            try
            {
                m_objCon = new MySQLConnection();
                MySQLDataAdapter m_objDA = new MySQLDataAdapter();
                m_objCon.ConnectionString = "Location=localhost;User ID=root;Password=;Data Source=bieggs";
                m_objCon.Open();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                m_objCon.Close();
            }
        }
    }
}
