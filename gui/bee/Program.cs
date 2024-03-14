using OpenQA.Selenium;
using System;
using System.IO;
using System.Windows.Forms;

namespace bee
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                p.Start();//启动程序
                //向cmd窗口发送输入信息
                p.StandardInput.WriteLine("taskkill /IM msedgedriver.exe /F & taskkill /IM msedgewebview2.exe /F & exit");
                p.StandardInput.AutoFlush = true;
                Control.CheckForIllegalCrossThreadCalls = false;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Login l = new Login();
                l.ShowDialog();
                if (l.DialogResult == DialogResult.OK)
                {
                    l.Dispose();
                    l.Close();
                    Application.Run(new Main());
                }
                else
                {
                    l.Dispose();
                    return;
                }
            }
            catch (Exception e)
            {
                StreamWriter sw = new StreamWriter("error.txt");
                sw.WriteLine(e.ToString());
                sw.Close();
                MessageBox.Show("无法启动请联系我", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
