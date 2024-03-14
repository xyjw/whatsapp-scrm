using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace bee
{
    public partial class Main : Form
    {
        EdgeDriver drivers;
        Queue queue = new Queue();
        Models m = new Models();
        bool sendState = false;
        bool getUserState = false;
        Dictionary<string, object> actionDict;
        string materialFilePath;
        public Main()
        {
            // 初始化
            m.runMode = Login.runMode;
            Environment.SetEnvironmentVariable("WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS", "--remote-debugging-port=8080");
            InitializeComponent();
            // 设置后台地址
            if (m.runMode == 0)
            {
                this.manageWebView.Source = new System.Uri("http://127.0.0.1:8000/", System.UriKind.Absolute);
            }
            if (m.runMode == 1)
            {
                this.manageWebView.Source = new System.Uri("http://192.168.10.152:8001/", System.UriKind.Absolute);
            }
            if (m.runMode == 2)
            {
                this.manageWebView.Source = new System.Uri("http://81.71.13.163:8002/", System.UriKind.Absolute);
            }
            EdgeOptions options = new EdgeOptions();
            options.UseWebView = true;
            options.DebuggerAddress = "localhost:8080";
            // 读取txt文件
            var driverPath = "";
            try
            {
                StreamReader readstring = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt"), Encoding.UTF8);
                driverPath = readstring.ReadToEnd();
                readstring.Close();
                var service = EdgeDriverService.CreateDefaultService(driverPath);
                // 隐藏msedgedriver.exe的运行窗口
                service.HideCommandPromptWindow = true;
                drivers = new EdgeDriver(service, options);
            }catch (Exception e)
            {
                MessageBox.Show("请先初始化再登录系统", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StreamWriter sw = new StreamWriter("error.txt");
                sw.WriteLine(e.ToString());
                sw.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "driver.txt"));
                sw.WriteLine(driverPath);
                sw.Close();
                System.Environment.Exit(0);
            }
            // 读取数据库的自动化配置
            var sql = $"select * from action where `status` = 1 ORDER BY id DESC LIMIT 1";
            List<Hashtable> res = m.QueryDB(sql, "action");
            string jsonText = (string)res[0]["action"];
            actionDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonText);
            getUserInfo();
            Thread t = new Thread(autoActions);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void setControl()
        {
            this.phoneTextBox.Text = "";
            this.customernameTextBox.Text = "";
            this.Label1comboBox.Text = "";
            this.Label2comboBox.Text = "";
            this.Label3comboBox.Text = "";
            this.Label4comboBox.Text = "";
            this.Label5comboBox.Text = "";
            this.statusComboBox.Text = "";
        }

        private void setClipboardData(string filePath)
        {
            if (filePath.ToLower().Contains(".txt"))
            {
                // 读取文件
                StreamReader readstring = new StreamReader(filePath, System.Text.Encoding.UTF8);
                var text = readstring.ReadToEnd();
                Clipboard.SetDataObject(text);
                readstring.Close();
            }
            else
            {
                // 复制文件
                System.Collections.Specialized.StringCollection strcoll = new System.Collections.Specialized.StringCollection();
                strcoll.Add(filePath);
                for (var i = 0; i < 10; i++)
                {
                    try
                    {
                        Clipboard.SetFileDropList(strcoll);
                        Thread.Sleep(2000);
                        break;
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void autoActions()
        {
            var send_textbox = (string)actionDict["send_textbox"];
            var send_status = (string)actionDict["send_status"];
            var send_button = (Newtonsoft.Json.Linq.JArray)actionDict["send_button"];
            var open_chat = (Newtonsoft.Json.Linq.JArray)actionDict["open_chat"];
            var username = (Newtonsoft.Json.Linq.JArray)actionDict["username"];
            string sql;
            while (true){
                if (queue.Count > 0)
                {
                    try {
                        var t = (Hashtable)queue.Dequeue();
                        // id等于0代表单次发送，大于0代表群发
                        var id = (string)t["id"];
                        // phone等于空代表在素材管理执行单次发送
                        var phone = (string)t["phone"];
                        var occurrence = (Int64)t["occurrence"];
                        var materials = (List<string>)t["materials"];
                        // 判断当前数据是否已完成群发
                        if (id != "0")
                        {
                            List<Hashtable> check = m.QueryDB($"select * from customer where id = {id} and `status` = 0", "customer");
                            if (check.Count < 1)
                            {
                                continue;
                            }
                        }
                        // 判断是否定时，如果定时则重新放入队列
                        Int64 nowTime = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMinutes);
                        if (nowTime < occurrence)
                        {
                            queue.Enqueue(t);
                            continue;
                        }
                        // 自动化操作
                        // 在素材管理执行单次发送不需要重新打开聊天框
                        var sendStyle = false;
                        var index = -1;
                        if (phone != "")
                        {
                            drivers.Navigate().GoToUrl($"https://web.whatsapp.com/send?phone={phone}");
                            drivers.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                            // 打开用户聊天框
                            for (var i=0; i<60; i++)
                            {
                                Thread.Sleep(1000);
                                index = -1;
                                foreach (var o in open_chat)
                                {
                                    ++index;
                                    if (drivers.PageSource.Contains(o.ToString()))
                                    {
                                        sendStyle = true;
                                    }
                                }
                                if (sendStyle)
                                {
                                    break;
                                }
                                // 电话不存在则删除数据
                                if (drivers.PageSource.Contains("url is invalid.") || drivers.PageSource.Contains("电话号码无效"))
                                {
                                    sql = $"DELETE FROM customer WHERE id={id}";
                                    m.ExecuteDB(sql);
                                    Thread.Sleep(1000);
                                    break;
                                }
                            }
                        }
                        // 单次发送直接判断聊天框有没有打开
                        else
                        {
                            foreach (var o in open_chat)
                            {
                                ++index;
                                if (drivers.PageSource.Contains(o.ToString()))
                                {
                                    sendStyle = true;
                                }
                            }
                        }
                        // 发送消息
                        if (sendStyle)
                        {
                            var customername = "";
                            if (index > -1)
                            {
                                customername = drivers.FindElement(By.CssSelector(username[index].ToString())).Text;
                                // 循环素材文件依次发送
                                foreach (string mm in materials)
                                {
                                    setClipboardData(mm);
                                    drivers.FindElements(By.CssSelector(send_textbox)).Last().Click();
                                    Thread.Sleep(1000);
                                    drivers.FindElements(By.CssSelector(send_textbox)).Last().SendKeys(Keys.Control + "v");
                                    Thread.Sleep(1000);
                                    // 点击发送按钮
                                    foreach (var sb in send_button)
                                    {
                                        if (drivers.PageSource.Contains(sb.ToString())) {
                                            drivers.FindElement(By.CssSelector($"[{sb}]")).Click();
                                        }
                                        Thread.Sleep(1000);
                                    }
                                    // 等待发送完成
                                    for (var i = 0; i < 60; i++)
                                    {
                                        Thread.Sleep(1000);
                                        if (!drivers.PageSource.Contains(send_status))
                                        {
                                            break;
                                        }
                                    }
                                }
                                // 关闭聊天框，防止重复发送信息
                                if (phone != "")
                                {
                                    new Actions(drivers).SendKeys(Keys.Escape).Perform();
                                    Thread.Sleep(1000);
                                }
                                // 更新数据库
                                if (phone != "" && id != "0") {
                                    sql = $"UPDATE customer SET `status`=1, customername='{customername}', updated='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE id={id}";
                                    m.ExecuteDB(sql);
                                }
                                sql = $"select * from record where account='{Login.username}' and team='{Login.team}'";
                                List<Hashtable> res1 = m.QueryDB(sql, "record");
                                if (res1.Count > 0)
                                {
                                    sql = $"UPDATE record SET message=message+1, updated='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where id={res1[0]["id"]}";
                                }
                                else
                                {
                                    sql = $"INSERT INTO record (account,team,message,updated,created) VALUES ('{Login.username}', '{Login.team}', '1', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
                                }
                                m.ExecuteDB(sql);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("有问题记得找我！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StreamWriter sw = new StreamWriter("error.txt");
                        sw.WriteLine(e.ToString());
                        sw.Close();
                        queue.Clear();
                    }
                    finally
                    {
                        if (queue.Count == 0)
                        {
                            sendState = false;
                            MessageBox.Show("自动发送已完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                Thread.Sleep(1000);
            }
            
        }

        private void getUserInfo()
        {
            Task task = new Task(() =>
            {
                string sql;
                var chat_content = (string)actionDict["chat_content"];
                var chat_message = (string)actionDict["chat_message"];
                var chat_message_att = (string)actionDict["chat_message_att"];
                while (true)
                {
                    if (!sendState && getUserState)
                    {
                        try
                        {
                            if (drivers.PageSource.Contains(chat_content))
                            {
                                var dataId = drivers.FindElement(By.CssSelector($"[{chat_content}]")).FindElement(By.CssSelector(chat_message)).GetAttribute(chat_message_att).Split('@')[0];
                                var phone = System.Text.RegularExpressions.Regex.Replace(dataId, @"[^0-9]+", "");
                                if (phone != this.phoneTextBox.Text)
                                {
                                    // 查询数据库
                                    sql = $"select * from customer where phone = '{phone}' and account = '{Login.username}' and team = '{Login.team}'";
                                    var res = m.QueryDB(sql, "customer");
                                    if (res.Count > 0 )
                                    {
                                        this.phoneTextBox.Text = phone;
                                        this.customernameTextBox.Text = res[0]["customername"].ToString();
                                        this.Label1comboBox.Text = res[0]["labels1"].ToString();
                                        this.Label2comboBox.Text = res[0]["labels2"].ToString();
                                        this.Label3comboBox.Text = res[0]["labels3"].ToString();
                                        this.Label4comboBox.Text = res[0]["labels4"].ToString();
                                        this.Label5comboBox.Text = res[0]["labels5"].ToString();
                                        var status = "待发送";
                                        if (res[0]["status"].ToString() == "1")
                                        {
                                            status = "已发送";
                                        }
                                        this.statusComboBox.Text = status;
                                    }
                                    else
                                    {
                                        setControl();
                                        this.phoneTextBox.Text = phone;
                                    }
                                }
                            }
                            else
                            {
                                setControl();
                            }
                            Thread.Sleep(2000);
                        }
                        catch (Exception e)
                        {
                            StreamWriter sw = new StreamWriter("error.txt");
                            sw.WriteLine(e.ToString());
                            sw.Close();
                        }
                    }
                }
            });
            task.Start();
        }

        private void fileData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.ColumnIndex == 0 || e.ColumnIndex == 2)
                {
                    var row = this.fileData.Rows[e.RowIndex];
                    if (row.Cells[0].Value == null) return;
                    var url = Path.Combine(materialFilePath, row.Cells[0].Value.ToString());
                    if (!File.Exists(url)) {
                        MessageBox.Show("文件路径有误，请检测路径是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (e.ColumnIndex == 0)
                    {
                        Process.Start(url);
                    }
                    if (e.ColumnIndex == 2)
                    {
                        if (sendState)
                        {
                            MessageBox.Show("自动发送中，请稍后再试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        List<string> materials = new List<string>();
                        materials.Add(url);
                        Hashtable res = new Hashtable();
                        res["materials"] = materials;
                        res["id"] = "0";
                        res["occurrence"] = (Int64)0;
                        res["phone"] = "";
                        queue.Enqueue(res);
                        sendState = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("有问题记得找我！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void customData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    if (sendState)
                    {
                        MessageBox.Show("自动发送中，请稍后再试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var row = this.customData.Rows[e.RowIndex];
                    if (row.Cells[0].Value == null) return;
                    var phone = row.Cells[0].Value.ToString();
                    this.webView.Source = new System.Uri($"https://web.whatsapp.com/send?phone={phone}", System.UriKind.Absolute);
                }
            }
            catch
            {
                MessageBox.Show("有问题记得找我！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath.Trim();
                DirectoryInfo theFolder = new DirectoryInfo(folderPath);
                if (theFolder.Exists)
                {
                    this.fileData.ClearRows();
                    materialFilePath = "";
                    string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        this.fileData.Rows.Add(Path.GetFileName(file), 1, "发送");
                        if (materialFilePath == "")
                        {
                            materialFilePath = Path.GetDirectoryName(file);
                        }
                    }
                }
                MessageBox.Show("素材导入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var index = 0;
                string file = dialog.FileName;
                // 读取CSV文件
                var records = new List<Hashtable>();
                var reader = new StreamReader(file, Encoding.GetEncoding("gb2312"));
                {
                    this.customData.ClearRows();
                    while (!reader.EndOfStream)
                    {
                        try { 
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            if (index == 0)
                            {
                                index = 1;
                                continue;
                            }
                            var record = new Hashtable();
                            var phone = System.Text.RegularExpressions.Regex.Replace(values[0], @"[^0-9]+", "");
                            record.Add("phone", phone);
                            record.Add("labels1", values[1]);
                            record.Add("labels2", values[2]);
                            record.Add("labels3", values[3]);
                            record.Add("labels4", values[4]);
                            record.Add("labels5", values[5]);
                            record.Add("account", Login.username);
                            record.Add("interval", "0");
                            record.Add("status", "0");
                            record.Add("team", Login.team);
                            records.Add(record);
                            this.customData.Rows.Add(phone, "打开");
                        }
                        catch { }
                    }
                }
                // 写入数据库
                index = 0;
                foreach (var r in records)
                {
                    try
                    {
                        var sql = $"INSERT INTO customer (phone,customername,labels1,labels2,labels3,labels4,labels5,account,team,`status`,`interval`,updated,created) VALUES ('{r["phone"]}', '', '{r["labels1"]}', '{r["labels2"]}', '{r["labels3"]}', '{r["labels4"]}','{r["labels5"]}','{r["account"]}', '{r["team"]}', '{r["status"]}', '{r["interval"]}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
                        m.ExecuteDB(sql);
                        ++index;
                    }
                    catch { }
                }
                MessageBox.Show($"{index}条数据导入成功，{records.Count()-index}条数据导入失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // 素材写入数组
            List<string> materials = new List<string>();
            foreach (DataGridViewRow row in this.fileData.Rows)
            {
                if (row.Cells[1].Value == null) {
                    continue;
                }
                if (row.Cells[1].Value.ToString() == "1")
                {
                    materials.Add(Path.Combine(materialFilePath, row.Cells[0].Value.ToString()));
                }
            }
            if (materials.Count == 0)
            {
                MessageBox.Show("请选择素材", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // 数据库获取群发客户信息
            var sql = $"select * from customer where `status` = 0 and account = '{Login.username}' and team = '{Login.team}'";
            List<Hashtable> res = m.QueryDB(sql, "customer");
            if (res.Count > 0)
            {
                foreach (var t in res)
                {
                    t["materials"] = materials;
                    Int64 interval = Convert.ToInt64(t["interval"]);
                    t["occurrence"] = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMinutes) + interval * 60;
                    queue.Enqueue(t);
                }
                sendState = true;
            }
            else
            {
                MessageBox.Show("请设置群发用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.phoneTextBox.Text != "")
            {
                var sql = $"select * from customer where phone = '{this.phoneTextBox.Text}' and account = '{Login.username}' and team = '{Login.team}'";
                List<Hashtable> res = m.QueryDB(sql, "customer");
                var status = 0;
                if (this.statusComboBox.Text == "已发送")
                {
                    status = 1;
                }
                if (res.Count > 0)
                {
                    var chatID = res[0]["id"].ToString();
                    
                    sql = $"UPDATE customer SET customername='{this.customernameTextBox.Text}', labels1='{this.Label1comboBox.Text}', labels2='{this.Label2comboBox.Text}',labels3='{this.Label3comboBox.Text}',labels4='{this.Label4comboBox.Text}',labels5='{this.Label5comboBox.Text}', `status`='{status}', updated='{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' where id={chatID}";
                    m.ExecuteDB(sql);
                }
                else
                {
                    sql = $"INSERT INTO customer (phone, customername, labels1, labels2, labels3, labels4, labels5,account,team, `status`,`interval`,updated,created) VALUES ('{this.phoneTextBox.Text}', '{this.customernameTextBox.Text}', '{this.Label1comboBox.Text}', '{this.Label2comboBox.Text}','{this.Label3comboBox.Text}','{this.Label4comboBox.Text}','{this.Label5comboBox.Text}', '{Login.username}','{Login.team}','{status}', '0', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
                    m.ExecuteDB(sql);
                }
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void changeTableIndex(object sender, EventArgs e)
        {
            if (this.actionTabControl.SelectedIndex == 0)
            {
                getUserState = false;
            }
            else
            {
                getUserState = true;
                var sql = $"select * from labels where team = '{Login.team}' and (account = '{Login.username}' or level=1)";
                List<Hashtable> res = m.QueryDB(sql, "label");
                foreach (var t in res)
                {
                    this.Label1comboBox.Items.Add(t["content"]);
                    this.Label2comboBox.Items.Add(t["content"]);
                    this.Label3comboBox.Items.Add(t["content"]);
                    this.Label4comboBox.Items.Add(t["content"]);
                    this.Label5comboBox.Items.Add(t["content"]);
                }
            }
        }

    }
}
