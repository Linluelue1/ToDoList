using MySql.Data.MySqlClient; // 引入MySql数据访问命名空间
using System.Data; // 引入数据命名空间
using System.Drawing.Drawing2D; // 引入2D绘图命名空间

namespace WindowsProject.implement // 定义命名空间
{
    internal class ToDoListFunc // 定义ToDoListFunc类
    {
        public static DataTable dataTable = new DataTable(); // 定义一个DataTable用于存储待办事项数据
        public static string account; // 定义一个静态字符串用于存储账户信息

        // 从数据库中读取数据
        public static DataTable getData()
        {
            dataTable.Clear();
            string query = "SELECT * FROM ToDoList WHERE userAccount = @account;"; // SQL查询语句
            MySqlCommand cmd = new MySqlCommand(query, Connector.connection); // 创建SQL命令对象
            cmd.Parameters.AddWithValue("@account", account); // 添加参数
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd); // 创建数据适配器
            dataAdapter.Fill(dataTable); // 使用适配器填充DataTable

            return dataTable; // 返回DataTable
        }

        // 更新数据库信息
        public static void updateDatabase(DataGridViewCell cell)
        {
            MySqlConnection conn = Connector.connection; // 获取数据库连接
            // 构建更新数据库的SQL语句
            string columnName = dataTable.Columns[cell.ColumnIndex].ColumnName;
            string query = $"UPDATE ToDoList SET {columnName} = @cellValue WHERE listID = @listID AND userAccount = @account;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) // 创建SQL命令对象
            {
                // 根据单元格值的类型添加参数
                if (cell.Value is DateTime)
                {
                    cmd.Parameters.AddWithValue("@cellValue", (DateTime)cell.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cellValue", cell.Value.ToString());
                }
                cmd.Parameters.AddWithValue("@listID", dataTable.Rows[cell.RowIndex][0]);
                cmd.Parameters.AddWithValue("@account", account);

                try
                {
                    conn.Open(); // 打开数据库连接
                    int rowsAffected = cmd.ExecuteNonQuery(); // 执行SQL命令
                    MessageBox.Show("成功更新 " + rowsAffected + " 行数据。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新数据库时出现错误：" + ex.Message);
                }
                finally
                {
                    conn.Close(); // 关闭数据库连接
                }
            }
        }

        // 删除数据库信息
        public static bool deleteDatabase(DataGridViewCell cell)
        {
            bool delete = false;
            MySqlConnection conn = Connector.connection; // 获取数据库连接
            string query = "DELETE FROM ToDoList WHERE listID = @listID AND userAccount = @account;";
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) // 创建SQL命令对象
            {
                cmd.Parameters.AddWithValue("@listID", dataTable.Rows[cell.RowIndex][0]);
                cmd.Parameters.AddWithValue("@account", account);

                try
                {
                    conn.Open(); // 打开数据库连接
                    int rowsAffected = cmd.ExecuteNonQuery(); // 执行SQL命令
                    MessageBox.Show("成功删除 " + rowsAffected + " 行数据。");
                    delete = true;
                    dataTable.Rows.RemoveAt(cell.RowIndex); // 从DataTable中移除行
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除数据库行数据时出现错误：" + ex.Message);
                    return delete;
                }
                finally
                {
                    conn.Close(); // 关闭数据库连接
                }
            }
            return delete;
        }

        // 插入数据库信息
        public static bool insertDatabase(DateTimePicker newDDL, string newContent, string newGrade)
        {
            MySqlConnection conn = Connector.connection; // 获取数据库连接
            string query = "INSERT INTO ToDoList(listDDL, listContent, listGrade, finish, userAccount) " +
                           "VALUES(@newDDL, @newContent, @newGrade, '否', @account);";
            using (MySqlCommand cmd = new MySqlCommand(query, conn)) // 创建SQL命令对象
            {
                try
                {
                    // 格式化DateTimePicker的值
                    string formattedDate = newDDL.Value.ToString("yyyy-MM-dd 00:00:00");
                    cmd.Parameters.AddWithValue("@newDDL", formattedDate);
                    cmd.Parameters.AddWithValue("@newContent", newContent);
                    cmd.Parameters.AddWithValue("@newGrade", newGrade);
                    cmd.Parameters.AddWithValue("@account", account);

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

        // 显示待办事项列表到DataGridView
        public static void showList(DataGridView todolist)
        {
            getData();
            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex = todolist.Rows.Add();
                // 假设DataGridView列名与DataTable列名一致，根据实际情况调整列名
                todolist.Rows[rowIndex].Cells["id"].Value = row["listID"].ToString();
                todolist.Rows[rowIndex].Cells["DDL1"].Value = row["listDDL"].ToString();
                todolist.Rows[rowIndex].Cells["Content"].Value = row["listContent"].ToString();
                todolist.Rows[rowIndex].Cells["grade"].Value = row["listGrade"].ToString();
                todolist.Rows[rowIndex].Cells["finish"].Value = row["finish"].ToString();
            }
        }

        public static void drawProgressBar(Graphics g, int total, int finished,PictureBox pictureBox1)
        {
            int centerX = ((pictureBox1.Width-20) / 2);
            int centerY = ((pictureBox1.Height-20) / 2);
            int radius = 80; // 调整半径以适应描边和中心图标

            // 启用抗锯齿
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 创建渐变色环的路径
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2), 0, 360);

            Color[] colors = { Color.FromArgb(255, 95, 206, 155), Color.FromArgb(255, 244, 119, 56), Color.FromArgb(255, 255, 217, 61) };
            float[] positions = { 0.0f, 0.5f, 1.0f }; // 确保位置值在0.0到1.0之间

            // 确保颜色和位置数组长度相同
            if (colors.Length != positions.Length)
            {
                throw new ArgumentException("颜色和位置数组长度必须相同。");
            }

            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterColor = colors[1];
            brush.SurroundColors = colors;
            brush.InterpolationColors = new ColorBlend { Colors = colors, Positions = positions };

            // 计算完成的百分比
            float percentage = (float)finished / total * 100f;

            // 绘制渐变色环
            g.FillPath(brush, path);

            // 创建描边的画笔
            Pen strokePen = new Pen(Color.White, 5); // 描边颜色和宽度可以根据需要调整
                                                     // 绘制描边
            g.DrawPath(strokePen, path);

            // 绘制中心图标或文本
            // 例如，这里绘制一个简单的白色圆形作为中心图标
            g.FillEllipse(Brushes.White, new Rectangle(centerX - radius / 4, centerY - radius / 4, radius / 2, radius / 2));

            // 绘制进度百分比文本
            StringFormat stringFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString($"{percentage:0.#}%", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(centerX, centerY), stringFormat);

            // 清理资源
            path.Dispose();
            brush.Dispose();
            strokePen.Dispose();
        }

        public static int[] todayCount()
        {
            int totalCount = 0; // 初始化总计数器
            int finishCount = 0;//初始化完成计数器
            DateTime today = DateTime.Today; // 获取今天的日期（没有时间部分）

            foreach (DataRow row in dataTable.Rows)
            {
                // 确保第二列的数据类型是DateTime
                if (dataTable.Columns[1].DataType == typeof(DateTime))
                {
                    // 读取第二列的DateTime值
                    DateTime dateValue = (DateTime)row[1];

                    // 检查dateValue是否在今天之内
                    if (dateValue.Date == today)
                    {
                        totalCount++; // 如果是，计数器加1
                        if (row[4].ToString() == "是")
                        {
                            finishCount++; // 如果是"是"，则计数器加1
                        }
                    }
                }
            }
            int[] count = new int[2];
            count[0] = totalCount;
            count[1] = finishCount;
            return count ;
        }
    }
}
