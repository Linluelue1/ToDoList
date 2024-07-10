using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProject.implement
{
    // 自定义 DataGridView 列，用于日期时间选择器
    public class DataGridViewDateTimePickerColumn : DataGridViewColumn
    {
        public DataGridViewDateTimePickerColumn() : base(new DataGridViewDateTimePickerCell())
        {
        }

        // 重写 CellTemplate 属性，确保单元格模板是 DataGridViewDateTimePickerCell 类型
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewDateTimePickerCell)))
                {
                    throw new InvalidCastException("单元格模板必须是 DataGridViewDateTimePickerCell 类型");
                }
                base.CellTemplate = value;
            }
        }
    }

    // 自定义 DataGridView 单元格，用于编辑日期和时间
    public class DataGridViewDateTimePickerCell : DataGridViewTextBoxCell
    {
        public DataGridViewDateTimePickerCell()
            : base()
        {
            // 设置单元格的日期时间格式
            this.Style.Format = "yyyy/MM/dd hh:mm:ss";
        }

        // 重写 InitializeEditingControl 方法，初始化编辑控件
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewDateTimePickerEditingControl ctl = DataGridView.EditingControl as DataGridViewDateTimePickerEditingControl;

            // 根据当前单元格的值设置编辑控件的值
            if (this.Value == null)
            {
                ctl.Value = (DateTime)this.DefaultNewRowValue;
            }
            else if (this.Value is DateTime)
            {
                ctl.Value = (DateTime)this.Value;
            }
            else if (this.Value is string)
            {
                DateTime dt;
                if (DateTime.TryParseExact((string)this.Value, "yyyy/MM/dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dt))
                {
                    ctl.Value = dt;
                }
                // else throw new InvalidCastException("无法将 Value 转换为 DateTime。");
            }
            else
            {
                throw new InvalidCastException("值不是有效的 DateTime 或字符串。");
            }
        }

        // 重写 EditType 属性，指定编辑控件的类型
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewDateTimePickerEditingControl);
            }
        }

        // 重写 ValueType 属性，指定单元格包含的值的类型
        public override Type ValueType
        {
            get
            {
                return typeof(DateTime);
            }
        }

        // 重写 DefaultNewRowValue 属性，指定新行的默认值
        public override object DefaultNewRowValue
        {
            get
            {
                return DateTime.Now;
            }
        }
    }

    // 自定义日期时间选择器编辑控件，实现 IDataGridViewEditingControl 接口
    public class DataGridViewDateTimePickerEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public DataGridViewDateTimePickerEditingControl()
        {
            // 设置日期时间选择器的格式
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "yyyy/MM/dd hh:mm:ss";
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingControlFormattedValue 属性
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToString("yyyy/MM/dd hh:mm:ss");
            }
            set
            {
                if (value is String)
                {
                    this.Value = DateTime.Parse((String)value);
                }
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 GetEditingControlFormattedValue 方法
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        // 实现 IDataGridViewEditingControl 接口的 ApplyCellStyleToEditingControl 方法
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingControlRowIndex 属性
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingControlWantsInputKey 方法
        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            // 允许日期时间选择器处理特定的按键
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 PrepareEditingControlForEdit 方法
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // 无需特殊准备
        }

        // 实现 IDataGridViewEditingControl 接口的 RepositionEditingControlOnValueChange 属性
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingControlDataGridView 属性
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingControlValueChanged 属性
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        // 实现 IDataGridViewEditingControl 接口的 EditingPanelCursor 属性
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }

        // 重写 OnValueChanged 事件，通知 DataGridView 单元格内容已更改
        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}