using WindowsProject.implement; // 引入项目实现命名空间

namespace WindowsProject.view // 定义命名空间
{
    public partial class Register : Form // 定义Register类，继承自Form
    {
        public Register() // Register类的构造函数
        {
            InitializeComponent(); // 初始化组件
        }

        // 注册按钮点击事件
        private void registerBotton_Click(object sender, EventArgs e)
        {
            // 检查两次输入的密码是否一致
            if (passwordInputBox.Text != confirmPasswordInputBox.Text)
            {
                MessageBox.Show("密码不一致");
            }
            else // 如果密码一致，则尝试注册新账户
            {
                // 调用LoginFunc的registerNewAccount方法注册账户
                if (LoginFunc.registerNewAccount(AccountInputBox.Text, passwordInputBox.Text))
                {
                    MessageBox.Show("注册成功");
                    this.Hide(); // 注册成功后隐藏当前窗体
                }
                else
                {
                    MessageBox.Show("账号已存在，注册失败");
                }
            }
        }

        // 返回标签链接点击事件
        private void returnLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // 关闭当前注册窗体
        }
    }
}