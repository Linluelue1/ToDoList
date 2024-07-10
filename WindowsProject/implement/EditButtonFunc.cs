using System.Data;

namespace WindowsProject.implement
{
    internal class EditButtonFunc
    {
        public static DataGridViewCell refreshData(DataGridViewCell cell) {
            DataTable temp = ToDoListFunc.getData();
            cell.Value = temp.Rows[cell.RowIndex][cell.ColumnIndex];
            return cell;
        }
    }
}
