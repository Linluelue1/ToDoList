using WindowsProject.implement;

namespace WindowsProject.view 
{
    public partial class Adding : Form 
    {
        public Adding() 
        {
            InitializeComponent(); 
        }

        // 确定按钮点击事件
        private void confirmBotton_Click(object sender, EventArgs e)
        {
            try 
            {
                // 从控件中获取新的任务截止日期、等级和内容
                DateTimePicker newDDL = DDLpicker;
                string newGrade = gradeComboBox.SelectedItem.ToString();
                string newContent = contentTextBox.Text;

                // 调用ToDoListFunc的insertDatabase方法插入数据库
                ToDoListFunc.insertDatabase(newDDL, newContent, newGrade);
            }
            catch (Exception ex) // 如果发生异常
            {
                MessageBox.Show(ex.Message); // 显示异常信息
            }
        }

        // 清空按钮点击事件
        private void cleanBotton_Click(object sender, EventArgs e)
        {
            // 设置截止日期选择器为当前日期
            DateTime now = DateTime.Now;
            DDLpicker.Text = now.ToString();

            // 清空内容文本框和设置等级下拉框为默认值
            contentTextBox.Text = null;
            gradeComboBox.Text = "1";
        }

        // 返回按钮点击事件
        private void returnBotton_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭当前添加窗口
        }

        // 标签1点击事件（此事件未实现具体功能）
        private void label1_Click(object sender, EventArgs e)
        {
            // 此方法目前为空，可以根据需要添加功能
        }
    }
}