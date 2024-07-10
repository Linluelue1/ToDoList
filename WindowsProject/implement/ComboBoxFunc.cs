namespace WindowsProject.implement
{
    internal class ComboBoxFunc
    {
        //下拉选单功能
        public static void Rank(ComboBox rankbox, DataGridView todolist)
        {
            // 获取用户从 ComboBox 中选择的项目
            string selected_item = rankbox.SelectedItem.ToString();
            
            // 根据选择的项目对数据进行排序
            switch (selected_item)
            {
                case "综合排序":
                    // 按照 ID 排序
                    todolist.Sort(todolist.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case "按DDL排序":
                    // 假设 "DDL1" 列包含可以转换为整数的字符串
                    todolist.Columns["DDL1"].SortMode = DataGridViewColumnSortMode.Automatic;
                    todolist.Sort(todolist.Columns["DDL1"], System.ComponentModel.ListSortDirection.Ascending);
                    break;
                case "按优先级排序":
                    // 按照 grade 排序
                    todolist.Sort(todolist.Columns["grade"], System.ComponentModel.ListSortDirection.Descending);
                    break;
                default:
                    // 默认排序（可根据需求修改）
                    break;
            }
        }
    }
}
