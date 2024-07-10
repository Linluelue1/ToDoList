using WindowsProject.implement; // 引入项目实现命名空间

namespace WindowsProject.view // 定义命名空间
{
    public partial class Login : Form // 定义Login类，继承自Form
    {
        // 用于标记账号密码验证是否成功
        bool valid = false;

        public Login() // Login类的构造函数
        {
            InitializeComponent(); // 初始化组件
        }

        // 重写Form的OnClosed事件，用于处理窗体关闭时的逻辑
        protected override void OnClosed(EventArgs e)
        {
            if (!valid) // 如果账号密码验证失败
            {
                Application.Exit(); // 退出应用程序
            }
        }

        // 登录按钮点击事件
        private void LoginBotton_Click(object sender, EventArgs e)
        {
            // 调用LoginFunc的validAccount方法验证账号密码
            valid = LoginFunc.validAccount(AccountInputBox.Text, passwordInputBox.Text);
            if (valid) // 如果验证成功
            {
                MessageBox.Show("登录成功"); // 显示登录成功消息
                ToDoListFunc.account = AccountInputBox.Text; // 设置ToDoListFunc的account属性
                // 关闭当前登录窗口
                this.Close();
            }
            else // 如果验证失败
            {
                MessageBox.Show("登录失败，用户不存在或密码错误"); // 显示登录失败消息
            }
        }

        // 注册按钮点击事件
        private void registerBotton_Click(object sender, EventArgs e)
        {
            Register register = new Register(); // 创建Register类实例
            register.Show(); // 显示注册窗口
        }
    }
}