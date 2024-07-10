using MySql.Data.MySqlClient; // 引入MySql数据访问命名空间

namespace WindowsProject.implement // 定义命名空间
{
    internal class Connector // 定义Connector类
    {
        public static MySqlConnection connection; // 定义一个静态的MySqlConnection对象

        // 静态构造函数，当Connector类被加载时自动执行
        static Connector()
        {
            // 定义数据库连接字符串
            string connStr = "Server=192.168.87.137;Database=windows;port=3306;" +
                             "uid=testuser;Password=Kelvin12138!;SslMode=none;";

            // 初始化connection静态成员变量
            connection = new MySqlConnection(connStr);

            try
            {
                // 尝试打开数据库连接
                connection.Open();
            }
            catch (MySqlException exe) // 捕获MySql异常
            {
                // 如果连接失败，显示错误信息
                MessageBox.Show(exe.Message);
            }
            finally
            {
                // 无论是否成功连接，都尝试关闭连接
                connection.Close();
            }
        }
    }
}