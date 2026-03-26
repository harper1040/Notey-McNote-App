namespace NoteyMcNotes
{
    partial class userLogin
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
            groupBoxLog = new GroupBox();
            labelLogPass = new Label();
            labelLogUser = new Label();
            buttonLoginLog = new Button();
            textPassLog = new TextBox();
            textUserLog = new TextBox();
            buttonCreateLog = new Button();
            groupBoxCreate = new GroupBox();
            label1 = new Label();
            textPassVerify = new TextBox();
            labelCreatePass = new Label();
            labelCreateName = new Label();
            buttonCreate = new Button();
            textPassCreate = new TextBox();
            textUserCreate = new TextBox();
            buttonLogin = new Button();
            groupBoxLog.SuspendLayout();
            groupBoxCreate.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLog
            // 
            groupBoxLog.Controls.Add(labelLogPass);
            groupBoxLog.Controls.Add(labelLogUser);
            groupBoxLog.Controls.Add(buttonLoginLog);
            groupBoxLog.Controls.Add(textPassLog);
            groupBoxLog.Controls.Add(textUserLog);
            groupBoxLog.Controls.Add(buttonCreateLog);
            groupBoxLog.Location = new Point(149, 27);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Size = new Size(277, 391);
            groupBoxLog.TabIndex = 0;
            groupBoxLog.TabStop = false;
            groupBoxLog.Text = "Login";
            // 
            // labelLogPass
            // 
            labelLogPass.AutoSize = true;
            labelLogPass.Location = new Point(38, 100);
            labelLogPass.Name = "labelLogPass";
            labelLogPass.Size = new Size(70, 20);
            labelLogPass.TabIndex = 4;
            labelLogPass.Text = "Password";
            // 
            // labelLogUser
            // 
            labelLogUser.AutoSize = true;
            labelLogUser.Location = new Point(38, 29);
            labelLogUser.Name = "labelLogUser";
            labelLogUser.Size = new Size(78, 20);
            labelLogUser.TabIndex = 1;
            labelLogUser.Text = "UserName";
            // 
            // buttonLoginLog
            // 
            buttonLoginLog.Location = new Point(57, 221);
            buttonLoginLog.Name = "buttonLoginLog";
            buttonLoginLog.Size = new Size(163, 59);
            buttonLoginLog.TabIndex = 3;
            buttonLoginLog.Text = "Login";
            buttonLoginLog.UseVisualStyleBackColor = true;
            buttonLoginLog.Click += buttonLoginLog_Click;
            // 
            // textPassLog
            // 
            textPassLog.Location = new Point(38, 123);
            textPassLog.Name = "textPassLog";
            textPassLog.PasswordChar = '#';
            textPassLog.Size = new Size(205, 27);
            textPassLog.TabIndex = 2;
            // 
            // textUserLog
            // 
            textUserLog.Location = new Point(38, 52);
            textUserLog.Name = "textUserLog";
            textUserLog.Size = new Size(205, 27);
            textUserLog.TabIndex = 1;
            // 
            // buttonCreateLog
            // 
            buttonCreateLog.Location = new Point(57, 299);
            buttonCreateLog.Name = "buttonCreateLog";
            buttonCreateLog.Size = new Size(163, 59);
            buttonCreateLog.TabIndex = 4;
            buttonCreateLog.Text = "Create Account";
            buttonCreateLog.UseVisualStyleBackColor = true;
            buttonCreateLog.Click += buttonCreateLog_Click;
            // 
            // groupBoxCreate
            // 
            groupBoxCreate.Controls.Add(label1);
            groupBoxCreate.Controls.Add(textPassVerify);
            groupBoxCreate.Controls.Add(labelCreatePass);
            groupBoxCreate.Controls.Add(labelCreateName);
            groupBoxCreate.Controls.Add(buttonCreate);
            groupBoxCreate.Controls.Add(textPassCreate);
            groupBoxCreate.Controls.Add(textUserCreate);
            groupBoxCreate.Controls.Add(buttonLogin);
            groupBoxCreate.Location = new Point(149, 27);
            groupBoxCreate.Name = "groupBoxCreate";
            groupBoxCreate.Size = new Size(286, 391);
            groupBoxCreate.TabIndex = 5;
            groupBoxCreate.TabStop = false;
            groupBoxCreate.Text = "Create Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 160);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 6;
            label1.Text = "Verify Password";
            // 
            // textPassVerify
            // 
            textPassVerify.Location = new Point(38, 183);
            textPassVerify.Name = "textPassVerify";
            textPassVerify.PasswordChar = '#';
            textPassVerify.Size = new Size(205, 27);
            textPassVerify.TabIndex = 3;
            // 
            // labelCreatePass
            // 
            labelCreatePass.AutoSize = true;
            labelCreatePass.Location = new Point(38, 95);
            labelCreatePass.Name = "labelCreatePass";
            labelCreatePass.Size = new Size(70, 20);
            labelCreatePass.TabIndex = 4;
            labelCreatePass.Text = "Password";
            // 
            // labelCreateName
            // 
            labelCreateName.AutoSize = true;
            labelCreateName.Location = new Point(38, 29);
            labelCreateName.Name = "labelCreateName";
            labelCreateName.Size = new Size(78, 20);
            labelCreateName.TabIndex = 1;
            labelCreateName.Text = "UserName";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(57, 234);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(163, 59);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create Account";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textPassCreate
            // 
            textPassCreate.Location = new Point(38, 118);
            textPassCreate.Name = "textPassCreate";
            textPassCreate.PasswordChar = '#';
            textPassCreate.Size = new Size(205, 27);
            textPassCreate.TabIndex = 2;
            // 
            // textUserCreate
            // 
            textUserCreate.Location = new Point(38, 52);
            textUserCreate.Name = "textUserCreate";
            textUserCreate.Size = new Size(205, 27);
            textUserCreate.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(57, 312);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(163, 59);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(groupBoxCreate);
            Controls.Add(groupBoxLog);
            Name = "user";
            StartPosition = FormStartPosition.CenterParent;
            Text = "user";
            groupBoxLog.ResumeLayout(false);
            groupBoxLog.PerformLayout();
            groupBoxCreate.ResumeLayout(false);
            groupBoxCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLog;
        private TextBox textUserLog;
        private Button buttonCreateLog;
        private Label labelLogPass;
        private Label labelLogUser;
        private Button buttonLoginLog;
        private TextBox textPassLog;
        private GroupBox groupBoxCreate;
        private Label labelCreatePass;
        private Label labelCreateName;
        private Button buttonCreate;
        private TextBox textPassCreate;
        private TextBox textUserCreate;
        private Button buttonLogin;
        private Label label1;
        private TextBox textPassVerify;
    }
}