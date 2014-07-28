using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace quickey
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isRun;
            System.Threading.Mutex mu = new System.Threading.Mutex(true, "OnlyRunOneInstance", out isRun);
            if (isRun)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mu.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序已经运行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
