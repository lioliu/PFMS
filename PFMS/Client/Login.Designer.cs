namespace Client
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.BTNRegister = new System.Windows.Forms.Button();
            this.TBXUserName = new System.Windows.Forms.TextBox();
            this.TBXPassword = new System.Windows.Forms.TextBox();
            this.TBXIdentify = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNForgot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "理财小狗 个人财务管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "验证码";
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(46, 220);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(75, 23);
            this.BTNLogin.TabIndex = 5;
            this.BTNLogin.Text = "登录";
            this.BTNLogin.UseVisualStyleBackColor = true;
            // 
            // BTNRegister
            // 
            this.BTNRegister.Location = new System.Drawing.Point(130, 220);
            this.BTNRegister.Name = "BTNRegister";
            this.BTNRegister.Size = new System.Drawing.Size(75, 23);
            this.BTNRegister.TabIndex = 6;
            this.BTNRegister.Text = "注册";
            this.BTNRegister.UseVisualStyleBackColor = true;
            // 
            // TBXUserName
            // 
            this.TBXUserName.Location = new System.Drawing.Point(60, 14);
            this.TBXUserName.Name = "TBXUserName";
            this.TBXUserName.Size = new System.Drawing.Size(170, 21);
            this.TBXUserName.TabIndex = 7;
            // 
            // TBXPassword
            // 
            this.TBXPassword.Location = new System.Drawing.Point(60, 45);
            this.TBXPassword.Name = "TBXPassword";
            this.TBXPassword.PasswordChar = '*';
            this.TBXPassword.Size = new System.Drawing.Size(170, 21);
            this.TBXPassword.TabIndex = 8;
            // 
            // TBXIdentify
            // 
            this.TBXIdentify.Location = new System.Drawing.Point(60, 72);
            this.TBXIdentify.Name = "TBXIdentify";
            this.TBXIdentify.Size = new System.Drawing.Size(64, 21);
            this.TBXIdentify.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(130, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 28);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BTNForgot
            // 
            this.BTNForgot.Location = new System.Drawing.Point(211, 220);
            this.BTNForgot.Name = "BTNForgot";
            this.BTNForgot.Size = new System.Drawing.Size(75, 23);
            this.BTNForgot.TabIndex = 11;
            this.BTNForgot.Text = "忘记密码";
            this.BTNForgot.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBXIdentify);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBXPassword);
            this.groupBox1.Controls.Add(this.TBXUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNForgot);
            this.Controls.Add(this.BTNRegister);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "理财小狗";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Button BTNRegister;
        private System.Windows.Forms.TextBox TBXUserName;
        private System.Windows.Forms.TextBox TBXPassword;
        private System.Windows.Forms.TextBox TBXIdentify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNForgot;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

