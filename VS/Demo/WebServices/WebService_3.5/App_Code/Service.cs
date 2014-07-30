using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySQLDriverCS;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //如果使用设计的组件，请取消注释以下行
        //InitializeComponent(); 
    }

    [WebMethod(Description="this is my first test")]
    public string HelloWorld() {
        Console.Write("this s s s s s");
        return "this is a test";
    }

    [WebMethod(Description = "insert data to my db")]
    public string HelloWorld2()
    {
        MySQLConnection conn = null;
        try
        {
            string connstr = "Data Source=bieggs;Password=;User ID=root;Location=localhost";
            conn = new MySQLConnection(connstr);
            conn.Open();
            string query = "insert into bi_tiyan values(14, 'testname', '2000', 'test.jpg','1')";
            MySQLCommand cmd = new MySQLCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
        }
        return "this is a test2";
    }
    
}