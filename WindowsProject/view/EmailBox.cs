using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.implement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsProject.view
{
    public partial class EmailBox : Form
    {
        public EmailBox()
        {
            InitializeComponent();
        }

        private void remindBotton_Click(object sender, EventArgs e)
        {
            //验证如果账号存在
            if (LoginFunc.validAccount(AccountInputBox.Text, passwordInputBox.Text))
            {
                //验证ID是否属于该账号
                if(EmailBoxFunc.vaildID(listID.Text, AccountInputBox.Text)&&EmailBoxFunc.vaildEmail(emailAddr.Text))
                {
                    MessageBox.Show("验证成功，内容将会在DDL前1个小时以邮件形式发送，请注意查收！");
                    EmailBoxFunc.insertData(listID.Text, emailAddr.Text);
                    EmailBoxFunc.sendEmail(listID.Text, emailAddr.Text);
                }
             }
            else
            {
                MessageBox.Show("账号或密码输入有误，请重试！");
            }

        }
    }
}
