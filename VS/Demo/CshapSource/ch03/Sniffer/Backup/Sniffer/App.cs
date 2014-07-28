using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sniffer
{
    public class App
    {
        // 
        // TODO: 在此处添加构造函数逻辑 
        // 
        [STAThread]
        public static void Main()
        {
            try
            {
                MainForm mainWindow = new MainForm();
                Application.Run(mainWindow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
