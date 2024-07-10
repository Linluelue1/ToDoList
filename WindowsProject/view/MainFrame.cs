using WindowsProject.implement; // 引入项目实现命名空间

namespace WindowsProject.view // 定义命名空间
{
    public partial class MainFrame : Form // 定义MainFrame类，继承自Form
    {
        public MainFrame() // MainFrame类的构造函数
        {
            InitializeComponent(); // 初始化组件
            Login login = new Login(); // 创建Login类实例

            // 显示新的窗体
            login.ShowDialog();
        }

        // 面板绘制事件，设置边框样式
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // 添加按钮点击事件
        private void AddBotton_Click(object sender, EventArgs e)
        {
            // 创建并显示添加窗体
            Adding addingForm = new Adding();
            addingForm.Show();
        }

        // MainForm加载事件
        private void Index1_Load(object sender, EventArgs e)
        {
            ToDoListFunc.showList(ToDoList); // 显示待办事项列表
            ToDoList.ReadOnly = true; // 设置待办事项列表为只读
        }

        // 排名框选中事件，实现排序功能
        private void RankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxFunc.Rank(RankBox, ToDoList);
        }

        // 编辑按钮点击事件
        private void editBotton_Click(object sender, EventArgs e)
        {
            ToDoList.ReadOnly = false; // 取消待办事项列表的只读状态
        }

        // 待办事项列表单元格编辑结束事件
        private void ToDoList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = ToDoList.CurrentCell; // 获取当前单元格
            if (cell != null)
            {
                switch (cell.ColumnIndex) // 根据列索引进行不同操作
                {
                    case 0:
                        MessageBox.Show("该列不可被修改！");
                        cell.Value = EditButtonFunc.refreshData(cell).Value; // 刷新数据
                        break;
                    default:
                        ToDoListFunc.updateDatabase(cell); // 更新数据库
                        break;
                }
            }
        }

        // 删除按钮点击事件
        private void DeleteBotton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = ToDoList.SelectedCells[0]; // 获取选中的单元格
            bool delete = ToDoListFunc.deleteDatabase(cell); // 调用删除数据库功能
            if (delete)
            {
                ToDoList.Rows.Clear(); // 清空待办事项列表行
                ToDoListFunc.showList(ToDoList); // 重新显示待办事项列表
            }
        }

        // 绘制环形进度条的方法
        private void DrawRingProgressBar(Graphics g, int total, int finished)
        {
            ToDoListFunc.drawProgressBar(g, total, finished, pictureBox1);
        }

        // 图片框绘制事件，用于绘制环形进度条
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int[] counts = ToDoListFunc.todayCount(); // 获取今日统计数据
            DrawRingProgressBar(e.Graphics, counts[0], counts[1]); // 绘制环形进度条
        }

        // MainForm显示事件
        private void MainFrame_Shown(object sender, EventArgs e)
        {
            // 此事件可以用于执行窗体显示时的初始化操作
        }

        private void reFreshButton_Click(object sender, EventArgs e)
        {
            ToDoList.Rows.Clear(); // 清空待办事项列表行
            ToDoListFunc.showList(ToDoList); // 重新显示待办事项列表
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            EmailBox box = new EmailBox();
            box.ShowDialog();
        }
    }
}