namespace WindowsProject.view
{
    partial class Adding
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
            LogoLabel = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            DDLLabel = new Label();
            DDLpicker = new DateTimePicker();
            label1 = new Label();
            returnBotton = new Button();
            cleanBotton = new Button();
            confirmBotton = new Button();
            gradeComboBox = new ComboBox();
            gradeLable = new Label();
            contentTextBox = new TextBox();
            Line = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LogoLabel
            // 
            LogoLabel.Font = new Font("微软雅黑", 36F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LogoLabel.Location = new Point(16, 54);
            LogoLabel.Margin = new Padding(5, 0, 5, 0);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(383, 83);
            LogoLabel.TabIndex = 2;
            LogoLabel.Text = "ToDoList";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.panelBG;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(DDLLabel);
            panel1.Controls.Add(DDLpicker);
            panel1.Controls.Add(returnBotton);
            panel1.Controls.Add(cleanBotton);
            panel1.Controls.Add(confirmBotton);
            panel1.Controls.Add(gradeComboBox);
            panel1.Controls.Add(gradeLable);
            panel1.Controls.Add(contentTextBox);
            panel1.Controls.Add(Line);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 847);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ToDoLogo1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(16, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(386, 84);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // DDLLabel
            // 
            DDLLabel.AutoSize = true;
            DDLLabel.BackColor = Color.Transparent;
            DDLLabel.Font = new Font("微软雅黑", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            DDLLabel.Location = new Point(68, 140);
            DDLLabel.Margin = new Padding(3);
            DDLLabel.Name = "DDLLabel";
            DDLLabel.Size = new Size(70, 31);
            DDLLabel.TabIndex = 11;
            DDLLabel.Text = "DDL:";
            // 
            // DDLpicker
            // 
            DDLpicker.Location = new Point(146, 140);
            DDLpicker.Margin = new Padding(5, 4, 5, 4);
            DDLpicker.MinDate = new DateTime(2024, 5, 5, 0, 0, 0, 0);
            DDLpicker.Name = "DDLpicker";
            DDLpicker.Size = new Size(312, 30);
            DDLpicker.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("楷体", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(354, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 33);
            label1.TabIndex = 9;
            label1.Text = "- adding page";
            label1.Click += label1_Click;
            // 
            // returnBotton
            // 
            returnBotton.Location = new Point(1010, 520);
            returnBotton.Margin = new Padding(5, 4, 5, 4);
            returnBotton.Name = "returnBotton";
            returnBotton.Size = new Size(173, 65);
            returnBotton.TabIndex = 8;
            returnBotton.Text = "返回";
            returnBotton.UseVisualStyleBackColor = true;
            returnBotton.Click += returnBotton_Click;
            // 
            // cleanBotton
            // 
            cleanBotton.Location = new Point(1010, 364);
            cleanBotton.Margin = new Padding(5, 4, 5, 4);
            cleanBotton.Name = "cleanBotton";
            cleanBotton.Size = new Size(173, 65);
            cleanBotton.TabIndex = 7;
            cleanBotton.Text = "清除";
            cleanBotton.UseVisualStyleBackColor = true;
            cleanBotton.Click += cleanBotton_Click;
            // 
            // confirmBotton
            // 
            confirmBotton.Location = new Point(1010, 212);
            confirmBotton.Margin = new Padding(5, 4, 5, 4);
            confirmBotton.Name = "confirmBotton";
            confirmBotton.Size = new Size(173, 65);
            confirmBotton.TabIndex = 6;
            confirmBotton.Text = "确认";
            confirmBotton.UseVisualStyleBackColor = true;
            confirmBotton.Click += confirmBotton_Click;
            // 
            // gradeComboBox
            // 
            gradeComboBox.DisplayMember = "1";
            gradeComboBox.FormattingEnabled = true;
            gradeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            gradeComboBox.Location = new Point(622, 140);
            gradeComboBox.Margin = new Padding(5, 4, 5, 4);
            gradeComboBox.Name = "gradeComboBox";
            gradeComboBox.Size = new Size(188, 32);
            gradeComboBox.TabIndex = 5;
            // 
            // gradeLable
            // 
            gradeLable.AutoSize = true;
            gradeLable.BackColor = Color.Transparent;
            gradeLable.Font = new Font("微软雅黑", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            gradeLable.Location = new Point(506, 143);
            gradeLable.Margin = new Padding(3);
            gradeLable.Name = "gradeLable";
            gradeLable.Size = new Size(106, 31);
            gradeLable.TabIndex = 4;
            gradeLable.Text = "优先级：";
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(16, 212);
            contentTextBox.Margin = new Padding(5, 4, 5, 4);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(848, 371);
            contentTextBox.TabIndex = 3;
            // 
            // Line
            // 
            Line.BackColor = SystemColors.ActiveCaptionText;
            Line.Location = new Point(0, 102);
            Line.Margin = new Padding(5, 4, 5, 4);
            Line.Name = "Line";
            Line.Size = new Size(1257, 1);
            Line.TabIndex = 0;
            // 
            // Adding
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 843);
            Controls.Add(panel1);
            Controls.Add(LogoLabel);
            Name = "Adding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adding";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LogoLabel;
        private Panel panel1;
        private Panel Line;
        private Label gradeLable;
        private TextBox contentTextBox;
        private ComboBox gradeComboBox;
        private Button returnBotton;
        private Button cleanBotton;
        private Button confirmBotton;
        private DateTimePicker DDLpicker;
        private Label DDLLabel;
        private PictureBox pictureBox2;
        private Label label1;
    }
}