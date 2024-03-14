using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace bee
{
    class Models
    {
        MySqlConnection conn;
        string sql_ip = "", sql_port = "", sql_user = "", sql_pw = "", sql_name = "";
        public int rm = 0;
        public int runMode
        {
            get
            {
                return rm;
            }
            set
            {
                rm = value;
            }
           
        }
        
        private void load()
        {
            if (runMode == 0) {
                sql_ip = "127.0.0.1";  //IP
                sql_port = "3306"; //端口号
                sql_user = "root";  //用户名  
                sql_pw = "1234";  //密码
                sql_name = "whatsapp"; //数据库名
            }
            if (runMode == 1)
            {
                sql_ip = "192.168.10.152";  //IP
                sql_port = "5050"; //端口号
                sql_user = "root";  //用户名  
                sql_pw = "kbl1234";  //密码
                sql_name = "whatsapp1"; //数据库名
            }
            if (runMode == 2)
            {
                sql_ip = "81.71.13.163";  //IP
                sql_port = "5050"; //端口号
                sql_user = "root";  //用户名  
                sql_pw = "QAZwsx1987!";  //密码
                sql_name = "whatsapp"; //数据库名
            }
            if (sql_ip != "")
            {
                string ConnectionString = $"server={sql_ip};user={sql_user};password ={sql_pw};database={sql_name}; port={sql_port};persistsecurityinfo = True;SslMode=None ;Charset=utf8mb4;";
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
            }
            
        }
        private void close()
        {
            conn.Close();
        }
        public List<Hashtable> QueryDB(string sql, string form)
        {
            load();
            List<Hashtable> res = new List<Hashtable>();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // 执行命令并获取读取器
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hashtable d = new Hashtable();
                if (form == "account")
                {
                    d.Add("account", reader.GetString("account"));
                    d.Add("password", reader.GetString("password"));
                    d.Add("team", reader.GetString("team"));
                }
                if (form == "customer")
                {
                    d.Add("id", reader.GetString("id"));
                    d.Add("phone", reader.GetString("phone"));
                    d.Add("customername", reader.GetString("customername"));
                    d.Add("labels1", reader.GetString("labels1"));
                    d.Add("labels2", reader.GetString("labels2"));
                    d.Add("labels3", reader.GetString("labels3"));
                    d.Add("labels4", reader.GetString("labels4"));
                    d.Add("labels5", reader.GetString("labels5"));
                    d.Add("status", reader.GetString("status"));
                    d.Add("interval", reader.GetString("interval"));
                }
                if (form == "action")
                {
                    d.Add("action", reader.GetString("action"));
                }
                if (form == "record")
                {
                    d.Add("id", reader.GetString("id"));
                }
                if (form == "label")
                {
                    d.Add("content", reader.GetString("content"));
                }
                res.Add(d);
            }
            close();
            return res;
        }
        public void ExecuteDB(string sql)
        {
            load();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            close();
        }

    }
}
