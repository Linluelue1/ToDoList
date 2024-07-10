using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProject.implement
{
    internal class LoginFunc
    {
        public static bool validAccount(string account, string password)
        {
            MySqlConnection conn = Connector.connection;

            string query = "SELECT COUNT(*) FROM userInfo WHERE Account = @account AND Password = @password";

            // 使用参数化查询来防止SQL注入
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                // 打开数据库连接
                conn.Open();

                // 执行查询
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // 如果查询结果大于0，则表示账号密码匹配
                return count > 0;
            }
            catch (Exception ex)
            {
                // 处理异常，例如打印错误信息
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                // 确保数据库连接被关闭
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static bool registerNewAccount(string account, string password) 
        {
            bool createSussces = false;
            // 确保传入的账号和密码不为空
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            // 获取数据库连接
            MySqlConnection conn = Connector.connection;

            // 首先检查账号是否已存在
            string checkQuery = "SELECT COUNT(*) FROM userInfo WHERE Account = @account";
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@account", account);

            try
            {
                // 打开数据库连接
                conn.Open();

                // 执行查询
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                // 如果账号已存在，则返回false
                if (count > 0)
                {
                    return false;
                }

                // 账号不存在，可以注册新账号
                string insertQuery = "INSERT INTO userInfo (Account, Password) VALUES (@account, @password)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@account", account);
                insertCmd.Parameters.AddWithValue("@password", password); // 注意：实际应用中密码应该加密存储

                // 执行插入操作
                int result = insertCmd.ExecuteNonQuery();

                // 返回插入操作是否成功
                return result > 0;
            }
            catch (Exception ex)
            {
                // 处理异常，例如打印错误信息
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                // 确保数据库连接被关闭
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return createSussces;
        }
    }
}
