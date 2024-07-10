using System.Windows.Forms;
using WindowsProject.implement;

namespace WindowsProject.view
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            reFreshButton = new Button();
            pictureBox2 = new PictureBox();
            todayNeedToFinishLabel = new Label();
            pictureBox1 = new PictureBox();
            ToDoList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DDL1 = new DataGridViewDateTimePickerColumn();
            Content = new DataGridViewTextBoxColumn();
            grade = new DataGridViewComboBoxColumn();
            finish = new DataGridViewComboBoxColumn();
            editBotton = new Button();
            RankBox = new ComboBox();
            DeleteBotton = new Button();
            AddBotton = new Button();
            Line = new Panel();
            colorDialog1 = new ColorDialog();
            emailButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToDoList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.panelBG;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(emailButton);
            panel1.Controls.Add(reFreshButton);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(todayNeedToFinishLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ToDoList);
            panel1.Controls.Add(editBotton);
            panel1.Controls.Add(RankBox);
            panel1.Controls.Add(DeleteBotton);
            panel1.Controls.Add(AddBotton);
            panel1.Controls.Add(Line);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 720);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // reFreshButton
            // 
            reFreshButton.BackColor = Color.RoyalBlue;
            reFreshButton.Cursor = Cursors.Hand;
            reFreshButton.Font = new Font("幼圆", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            reFreshButton.Location = new Point(420, 66);
            reFreshButton.Name = "reFreshButton";
            reFreshButton.Size = new Size(81, 32);
            reFreshButton.TabIndex = 13;
            reFreshButton.Text = "刷新";
            reFreshButton.UseVisualStyleBackColor = false;
            reFreshButton.Click += reFreshButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ToDoLogo1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(23, 8);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 73);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // todayNeedToFinishLabel
            // 
            todayNeedToFinishLabel.AutoSize = true;
            todayNeedToFinishLabel.BackColor = Color.Transparent;
            todayNeedToFinishLabel.Location = new Point(781, 138);
            todayNeedToFinishLabel.Name = "todayNeedToFinishLabel";
            todayNeedToFinishLabel.Size = new Size(80, 17);
            todayNeedToFinishLabel.TabIndex = 11;
            todayNeedToFinishLabel.Text = "今日已完成：";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(742, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // ToDoList
            // 
            ToDoList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            ToDoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ToDoList.BackgroundColor = SystemColors.Info;
            ToDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoList.Columns.AddRange(new DataGridViewColumn[] { ID, DDL1, Content, grade, finish });
            ToDoList.Cursor = Cursors.Hand;
            ToDoList.GridColor = SystemColors.WindowText;
            ToDoList.Location = new Point(0, 100);
            ToDoList.Margin = new Padding(2);
            ToDoList.Name = "ToDoList";
            ToDoList.RowHeadersVisible = false;
            ToDoList.RowHeadersWidth = 62;
            ToDoList.Size = new Size(737, 620);
            ToDoList.TabIndex = 9;
            ToDoList.CellEndEdit += ToDoList_CellEndEdit;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 46;
            // 
            // DDL1
            // 
            DDL1.HeaderText = "DDL";
            DDL1.MinimumWidth = 125;
            DDL1.Name = "DDL1";
            DDL1.Width = 125;
            // 
            // Content
            // 
            Content.HeaderText = "内容";
            Content.MinimumWidth = 400;
            Content.Name = "Content";
            Content.Width = 412;
            // 
            // grade
            // 
            grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grade.HeaderText = "优先级";
            grade.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            grade.MinimumWidth = 70;
            grade.Name = "grade";
            grade.Resizable = DataGridViewTriState.True;
            grade.SortMode = DataGridViewColumnSortMode.Automatic;
            grade.Width = 70;
            // 
            // finish
            // 
            finish.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            finish.HeaderText = "是否完成";
            finish.Items.AddRange(new object[] { "是", "否" });
            finish.MinimumWidth = 80;
            finish.Name = "finish";
            finish.Resizable = DataGridViewTriState.True;
            finish.SortMode = DataGridViewColumnSortMode.Automatic;
            finish.Width = 81;
            // 
            // editBotton
            // 
            editBotton.BackColor = Color.SpringGreen;
            editBotton.Cursor = Cursors.Hand;
            editBotton.Font = new Font("幼圆", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            editBotton.Location = new Point(720, 66);
            editBotton.Name = "editBotton";
            editBotton.Size = new Size(81, 32);
            editBotton.TabIndex = 7;
            editBotton.Text = "修改";
            editBotton.UseVisualStyleBackColor = false;
            editBotton.Click += editBotton_Click;
            // 
            // RankBox
            // 
            RankBox.BackColor = Color.MediumAquamarine;
            RankBox.Cursor = Cursors.Hand;
            RankBox.DisplayMember = "综合排序";
            RankBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RankBox.ForeColor = SystemColors.WindowText;
            RankBox.FormattingEnabled = true;
            RankBox.Items.AddRange(new object[] { "综合排序", "按DDL排序", "按优先级排序" });
            RankBox.Location = new Point(825, 70);
            RankBox.Name = "RankBox";
            RankBox.Size = new Size(121, 25);
            RankBox.TabIndex = 5;
            RankBox.SelectedIndexChanged += RankBox_SelectedIndexChanged;
            // 
            // DeleteBotton
            // 
            DeleteBotton.BackColor = Color.DarkTurquoise;
            DeleteBotton.Cursor = Cursors.Hand;
            DeleteBotton.Font = new Font("幼圆", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            DeleteBotton.Location = new Point(620, 66);
            DeleteBotton.Name = "DeleteBotton";
            DeleteBotton.Size = new Size(81, 32);
            DeleteBotton.TabIndex = 3;
            DeleteBotton.Text = "删除";
            DeleteBotton.UseVisualStyleBackColor = false;
            DeleteBotton.Click += DeleteBotton_Click;
            // 
            // AddBotton
            // 
            AddBotton.BackColor = Color.Aqua;
            AddBotton.Cursor = Cursors.Hand;
            AddBotton.Font = new Font("幼圆", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            AddBotton.Location = new Point(520, 66);
            AddBotton.Name = "AddBotton";
            AddBotton.Size = new Size(81, 32);
            AddBotton.TabIndex = 2;
            AddBotton.Text = "添加";
            AddBotton.UseVisualStyleBackColor = false;
            AddBotton.Click += AddBotton_Click;
            // 
            // Line
            // 
            Line.BackColor = Color.Black;
            Line.Location = new Point(1, 100);
            Line.Name = "Line";
            Line.Size = new Size(960, 1);
            Line.TabIndex = 0;
            // 
            // emailButton
            // 
            emailButton.BackColor = Color.LightCoral;
            emailButton.Cursor = Cursors.Hand;
            emailButton.Font = new Font("幼圆", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            emailButton.Location = new Point(825, 448);
            emailButton.Name = "emailButton";
            emailButton.Size = new Size(70, 70);
            emailButton.TabIndex = 14;
            emailButton.Text = "提醒我";
            emailButton.UseVisualStyleBackColor = false;
            emailButton.Click += emailButton_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 720);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Index";
            Load += Index1_Load;
            Shown += MainFrame_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToDoList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel Line;
        private Button AddBotton;
        private Button DeleteBotton;
        private ComboBox RankBox;
        private Button editBotton;
        private DataGridViewDateTimePickerColumn DDL;
        private Label todayNeedToFinishLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ColorDialog colorDialog1;
        private Button reFreshButton;
        private DataGridView ToDoList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewDateTimePickerColumn DDL1;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewComboBoxColumn grade;
        private DataGridViewComboBoxColumn finish;
        private Button emailButton;
    }
}