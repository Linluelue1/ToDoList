namespace WindowsProject.view
{
    partial class EmailBox
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            listID = new TextBox();
            loginLabel = new Label();
            panel2 = new Panel();
            emailAddr = new TextBox();
            passwordLabel = new Label();
            remindBotton = new Button();
            panel3 = new Panel();
            passwordInputBox = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            AccountInputBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ToDoLogo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(104, 66);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 117);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(89, 367);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 1);
            panel1.TabIndex = 6;
            // 
            // listID
            // 
            listID.BackColor = Color.White;
            listID.BorderStyle = BorderStyle.None;
            listID.Cursor = Cursors.Hand;
            listID.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listID.Location = new Point(89, 345);
            listID.Margin = new Padding(2);
            listID.Name = "listID";
            listID.Size = new Size(191, 16);
            listID.TabIndex = 5;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            loginLabel.Location = new Point(89, 326);
            loginLabel.Margin = new Padding(2, 0, 2, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(118, 17);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "输入需提醒的事项ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(89, 424);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 1);
            panel2.TabIndex = 9;
            // 
            // emailAddr
            // 
            emailAddr.BackColor = Color.White;
            emailAddr.BorderStyle = BorderStyle.None;
            emailAddr.Cursor = Cursors.Hand;
            emailAddr.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            emailAddr.Location = new Point(89, 403);
            emailAddr.Margin = new Padding(2);
            emailAddr.Name = "emailAddr";
            emailAddr.Size = new Size(191, 16);
            emailAddr.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Cursor = Cursors.Hand;
            passwordLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordLabel.Location = new Point(89, 383);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(104, 17);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "输入发送邮箱地址";
            // 
            // remindBotton
            // 
            remindBotton.BackColor = Color.Transparent;
            remindBotton.BackgroundImage = Properties.Resources.panelBG;
            remindBotton.Cursor = Cursors.Hand;
            remindBotton.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            remindBotton.Location = new Point(149, 452);
            remindBotton.Margin = new Padding(2);
            remindBotton.Name = "remindBotton";
            remindBotton.Size = new Size(71, 24);
            remindBotton.TabIndex = 10;
            remindBotton.Text = "提醒我！";
            remindBotton.UseVisualStyleBackColor = false;
            remindBotton.Click += remindBotton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(89, 314);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 1);
            panel3.TabIndex = 16;
            // 
            // passwordInputBox
            // 
            passwordInputBox.BackColor = Color.White;
            passwordInputBox.BorderStyle = BorderStyle.None;
            passwordInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordInputBox.Location = new Point(89, 293);
            passwordInputBox.Margin = new Padding(2);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.PasswordChar = '*';
            passwordInputBox.Size = new Size(191, 16);
            passwordInputBox.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(89, 265);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 1);
            panel4.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(89, 273);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 14;
            label1.Text = "密码";
            // 
            // AccountInputBox
            // 
            AccountInputBox.BackColor = Color.White;
            AccountInputBox.BorderStyle = BorderStyle.None;
            AccountInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AccountInputBox.Location = new Point(89, 243);
            AccountInputBox.Margin = new Padding(2);
            AccountInputBox.Name = "AccountInputBox";
            AccountInputBox.Size = new Size(191, 16);
            AccountInputBox.TabIndex = 12;
            AccountInputBox.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(89, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 11;
            label2.Text = "账户";
            // 
            // EmailBox
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.panelBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 527);
            Controls.Add(panel3);
            Controls.Add(passwordInputBox);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(AccountInputBox);
            Controls.Add(label2);
            Controls.Add(remindBotton);
            Controls.Add(panel2);
            Controls.Add(emailAddr);
            Controls.Add(passwordLabel);
            Controls.Add(panel1);
            Controls.Add(listID);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "EmailBox";
            Text = "EmailBox";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox listID;
        private Label loginLabel;
        private Panel panel2;
        private TextBox emailAddr;
        private Label passwordLabel;
        private Button remindBotton;
        private Panel panel3;
        private TextBox passwordInputBox;
        private Panel panel4;
        private Label label1;
        private TextBox AccountInputBox;
        private Label label2;
    }
}