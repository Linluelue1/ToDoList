namespace WindowsProject.view
{
    partial class Login
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
            AccountInputBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            passwordInputBox = new TextBox();
            LoginBotton = new Button();
            loginLabel = new Label();
            passwordLabel = new Label();
            registerBotton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ToDoLogo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(104, 66);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 117);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AccountInputBox
            // 
            AccountInputBox.BackColor = Color.White;
            AccountInputBox.BorderStyle = BorderStyle.None;
            AccountInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AccountInputBox.Location = new Point(89, 251);
            AccountInputBox.Margin = new Padding(2, 2, 2, 2);
            AccountInputBox.Name = "AccountInputBox";
            AccountInputBox.Size = new Size(191, 16);
            AccountInputBox.TabIndex = 2;
            AccountInputBox.Text = "admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(89, 273);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(89, 332);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 1);
            panel2.TabIndex = 6;
            // 
            // passwordInputBox
            // 
            passwordInputBox.BackColor = Color.White;
            passwordInputBox.BorderStyle = BorderStyle.None;
            passwordInputBox.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordInputBox.Location = new Point(89, 311);
            passwordInputBox.Margin = new Padding(2, 2, 2, 2);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.PasswordChar = '*';
            passwordInputBox.Size = new Size(191, 16);
            passwordInputBox.TabIndex = 5;
            // 
            // LoginBotton
            // 
            LoginBotton.BackColor = Color.Transparent;
            LoginBotton.BackgroundImage = Properties.Resources.panelBG;
            LoginBotton.Cursor = Cursors.Hand;
            LoginBotton.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LoginBotton.Location = new Point(209, 356);
            LoginBotton.Margin = new Padding(2, 2, 2, 2);
            LoginBotton.Name = "LoginBotton";
            LoginBotton.Size = new Size(71, 24);
            LoginBotton.TabIndex = 7;
            LoginBotton.Text = "登录";
            LoginBotton.UseVisualStyleBackColor = false;
            LoginBotton.Click += LoginBotton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            loginLabel.Location = new Point(89, 232);
            loginLabel.Margin = new Padding(2, 0, 2, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(32, 17);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "账户";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            passwordLabel.Location = new Point(89, 291);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(32, 17);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "密码";
            // 
            // registerBotton
            // 
            registerBotton.BackColor = Color.Transparent;
            registerBotton.BackgroundImage = Properties.Resources.panelBG;
            registerBotton.Cursor = Cursors.Hand;
            registerBotton.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            registerBotton.Location = new Point(89, 356);
            registerBotton.Margin = new Padding(2, 2, 2, 2);
            registerBotton.Name = "registerBotton";
            registerBotton.Size = new Size(71, 24);
            registerBotton.TabIndex = 8;
            registerBotton.Text = "注册";
            registerBotton.UseVisualStyleBackColor = false;
            registerBotton.Click += registerBotton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.panelBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 527);
            Controls.Add(registerBotton);
            Controls.Add(LoginBotton);
            Controls.Add(panel2);
            Controls.Add(passwordInputBox);
            Controls.Add(panel1);
            Controls.Add(passwordLabel);
            Controls.Add(AccountInputBox);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox AccountInputBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox passwordInputBox;
        private Button LoginBotton;
        private Label loginLabel;
        private Label passwordLabel;
        private Button registerBotton;
    }
}