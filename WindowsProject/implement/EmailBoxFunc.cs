using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Timers;

namespace WindowsProject.implement
{
    internal class EmailBoxFunc
    {
        public static DataTable dataTable = ToDoListFunc.dataTable;
        public static string DDL;
        public static string content;
        //验证ID是否存在，账户密码是否正确，ID是否属于该账号
        public static bool vaildID(string listID,string userAccount)
        {
            DataRow foundRow = null;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["listID"].ToString() == listID)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow != null)
            {
                string userAccountInRow = foundRow["userAccount"].ToString();
                string inputAccount = userAccount;

                if (userAccountInRow == inputAccount)
                {
                    // listID和userAccount都对应
                    return true;
                }
            }
            else
            {
                // 没有找到对应的listID
                MessageBox.Show("未找到与输入ID对应的数据，请重试");
                return false;
            }
            return false;
        }

        //验证邮箱格式是否正确
        public static bool vaildEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
           bool vaild = Regex.IsMatch(email, pattern);
            if (vaild)
            {
                return true;
            }else
            {
                MessageBox.Show("邮件格式有误，请重试");
                return false;
            }
        }

        //插入数据库数据
        public static bool insertData(string listID, string emailAddr) {
            MySqlConnection conn = Connector.connection; // 获取数据库连接
            string query = "INSERT INTO emailToSend(emailAddr,listID)" +
                           "VALUES(@emailAddr,@listID);";
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) // 创建SQL命令对象
            {
                try
                {
                    //防止sql注入
                    cmd.Parameters.AddWithValue("@emailAddr", emailAddr);
                    cmd.Parameters.AddWithValue("@listID",listID);

                    // 打开数据库连接并执行插入操作
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("成功加入 " + rowsAffected + " 行数据。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加入数据库行数据时出现错误：" + ex.Message);
                }
                finally
                {
                    conn.Close(); // 关闭数据库连接
                }
            }
            return true;
        }

        //发送邮件
        public static bool sendEmail(string listID, string email)
        {
            DateTime currentTime = DateTime.Now;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["listID"].ToString() == listID.ToString()) // 检查 ID 是否匹配
                {
                    // 假设您想获取名为 'ContentColumn' 的列的值
                    DDL = row["listDDL"].ToString();
                    content = row["listContent"].ToString();
                    // 如果只需要找到第一个匹配项，可以中断循环
                    break;
                }
            }
            //这里本意是想设置DDL前一个小时发送邮件，但是C#和qq的SMTP协议都没有这个功能，只能模拟一下这个功能
            //假设当前时间-DDL为1个小时，则系统会发送邮件到输入的邮箱地址提示用户待完成事项内容
            DateTime DDLTime = DateTime.Parse(DDL);

            TimeSpan timeDifference = currentTime - DDLTime;
            bool isLessThanOneHour = timeDifference < TimeSpan.FromHours(1);
            if (isLessThanOneHour)
            {
                try
                {
                    // 设置发送者的电子邮件地址和密码
                    string senderEmail = "907018526@qq.com";
                    string senderPassword = "fnkbsodcpthcbebh";

                    // 设置收件人的电子邮件地址
                    string receiverEmail = email;
                    MessageBox.Show(receiverEmail);

                    // 创建邮件对象
                    MailMessage mail = new MailMessage(senderEmail, receiverEmail);
                    mail.Subject = "ToDoList事项提醒！";
                    mail.Body = "您的\"" + content + "\"待完成，距离截止时间还有一个小时！请及时完成，若已完成请忽略此邮件，谢谢！";

                    // 创建SMTP客户端
                    SmtpClient smtpClient = new SmtpClient("smtp.qq.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;

                    // 发送邮件
                    smtpClient.Send(mail);

                    MessageBox.Show("邮件发送成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("邮件发送失败：" + ex.Message);
                }
                return true;
            }
            else { return false; }
        }
    }
 }

