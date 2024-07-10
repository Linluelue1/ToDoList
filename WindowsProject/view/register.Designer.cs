namespace WindowsProject.view
{
    partial class Register
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
            registerBotton = new Button();
            panel2 = new Panel();
            passwordInputBox = new TextBox();
            panel1 = new Panel();
            passwordLabel = new Label();
            AccountInputBox = new TextBox();
            loginLabel = new Label();
            panel3 = new Panel();
            confirmPasswordInputBox = new TextBox();
            confirmPasswordLabel = new Label();
            returnLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ToDoLogo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(163, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 165);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // registerBotton
            // 
            registerBotton.BackColor = Color.Transparent;
            registerBotton.BackgroundImage = Properties.Resources.panelBG;
            registerBotton.Cursor = Cursors.Hand;
            registerBotton.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            registerBotton.Location = new Point(234, 583);
            registerBotton.Name = "registerBotton";
            registerBotton.Size = new Size(112, 34);
            registerBotton.TabIndex = 15;
            registerBotton.Text = "注册";
            registerBotton.UseVisualStyleBackColor = false;
            registerBotton.Click += registerBotton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(140, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 14;
            // 
            // passwordInputBox
            // 
            passwordInputBox.BackColor = Color.White;
            passwordInputBox.BorderStyle = BorderStyle.None;
            passwordInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordInputBox.Location = new Point(140, 439);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.PasswordChar = '*';
            passwordInputBox.Size = new Size(300, 24);
            passwordInputBox.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(140, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordLabel.Location = new Point(140, 411);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 25);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "输入密码";
            // 
            // AccountInputBox
            // 
            AccountInputBox.BackColor = Color.White;
            AccountInputBox.BorderStyle = BorderStyle.None;
            AccountInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AccountInputBox.Location = new Point(140, 356);
            AccountInputBox.Name = "AccountInputBox";
            AccountInputBox.Size = new Size(300, 24);
            AccountInputBox.TabIndex = 10;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            loginLabel.Location = new Point(140, 329);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(66, 25);
            loginLabel.TabIndex = 9;
            loginLabel.Text = "新账户";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(140, 546);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 17;
            // 
            // confirmPasswordInputBox
            // 
            confirmPasswordInputBox.BackColor = Color.White;
            confirmPasswordInputBox.BorderStyle = BorderStyle.None;
            confirmPasswordInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            confirmPasswordInputBox.Location = new Point(140, 517);
            confirmPasswordInputBox.Name = "confirmPasswordInputBox";
            confirmPasswordInputBox.PasswordChar = '*';
            confirmPasswordInputBox.Size = new Size(300, 24);
            confirmPasswordInputBox.TabIndex = 16;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.Transparent;
            confirmPasswordLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            confirmPasswordLabel.Location = new Point(140, 488);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(84, 25);
            confirmPasswordLabel.TabIndex = 15;
            confirmPasswordLabel.Text = "确认密码";
            // 
            // returnLabel
            // 
            returnLabel.AutoSize = true;
            returnLabel.BackColor = Color.Transparent;
            returnLabel.LinkColor = Color.Black;
            returnLabel.Location = new Point(471, 13);
            returnLabel.Margin = new Padding(5, 0, 5, 0);
            returnLabel.Name = "returnLabel";
            returnLabel.Size = new Size(82, 24);
            returnLabel.TabIndex = 18;
            returnLabel.TabStop = true;
            returnLabel.Text = "返回登录";
            returnLabel.LinkClicked += returnLabel_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.panelBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(578, 744);
            Controls.Add(returnLabel);
            Controls.Add(panel3);
            Controls.Add(confirmPasswordInputBox);
            Controls.Add(registerBotton);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(panel2);
            Controls.Add(passwordInputBox);
            Controls.Add(panel1);
            Controls.Add(passwordLabel);
            Controls.Add(AccountInputBox);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button registerBotton;
        private Panel panel2;
        private TextBox passwordInputBox;
        private Panel panel1;
        private Label passwordLabel;
        private TextBox AccountInputBox;
        private Label loginLabel;
        private Panel panel3;
        private TextBox confirmPasswordInputBox;
        private Label confirmPasswordLabel;
        private LinkLabel returnLabel;
    }
}