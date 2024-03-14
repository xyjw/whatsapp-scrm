using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace bee
{
    public partial class Login : Form
    {
        public static string username;
        public static string team;
        // 设置运行模式
        public static int runMode = 0;
        Models m = new Models();
        public Login()
        {
            InitializeComponent();
            Hashtable res = sendConfig("read");
            this.usernameText.Text = res["userName"].ToString();
            this.passwordText.Text = res["passWord"].ToString();
            m.runMode = runMode;
            // 设置按钮状态
            if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt")))
            {
                this.loginButton.Enabled = false;
                this.clearButton.Enabled = false;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            username = this.usernameText.Text;
            string password = this.passwordText.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("请输入账号密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // 数据查询验证用户信息
            string sql = $"select * from account where account='{username}' and password='{password}'";
            List<Hashtable> res = m.QueryDB(sql, "account");
            if (res.Count > 0)
            {
                team = res[0]["team"].ToString();
                sendConfig("modify", username, password);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.tips.Text = "账号密码异常";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.usernameText.Text = "";
            this.passwordText.Text = "";
            this.tips.Text = "";
            sendConfig("clear");
        }

        private Hashtable sendConfig(string mode, string userName="", string passWord="")
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configuration.AppSettings.Settings;
            Hashtable res = new Hashtable();
            res["userName"] = "";
            res["passWord"] = "";
            if (mode == "read")
            {
                if (settings["userName"] != null)
                {
                    res["userName"] = settings["userName"].Value;
                    res["passWord"] = settings["passWord"].Value;
                }
            }
            else
            {
                if (settings["userName"] != null)
                {
                    settings["userName"].Value = userName;
                    settings["passWord"].Value = passWord;
                }
                else
                {
                    settings.Add("userName", userName);
                    settings.Add("passWord", passWord);
                }
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
            }
            return res;
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            this.initializeButton.Enabled = false;
            this.loginButton.Enabled = false;
            this.clearButton.Enabled = false;
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt")))
            {
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt"));
            }
            System.Diagnostics.Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "getDriver.exe"));
            Task task = new Task(() =>
            {
                while (true)
                {
                    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt")))
                    {
                        this.loginButton.Enabled = true;
                        this.clearButton.Enabled = true;
                        this.initializeButton.Enabled = true;
                        break;
                    }
                    Thread.Sleep(5000);
                }
            });
            task.Start();
        }

    }
}
