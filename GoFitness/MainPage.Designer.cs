namespace GoFitness
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.GroupLogIn = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.btnGuset = new System.Windows.Forms.Button();
            this.btnRegisterNewCustomer = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.GroupLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupLogIn
            // 
            this.GroupLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupLogIn.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogIn.BackgroundImage = global::GoFitness.Properties.Resources.main_page;
            this.GroupLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupLogIn.Controls.Add(this.loginButton);
            this.GroupLogIn.Controls.Add(this.btnGuset);
            this.GroupLogIn.Controls.Add(this.btnRegisterNewCustomer);
            this.GroupLogIn.Controls.Add(this.txtPassword);
            this.GroupLogIn.Controls.Add(this.txtUserName);
            this.GroupLogIn.Controls.Add(this.lblPassword);
            this.GroupLogIn.Controls.Add(this.lblUsername);
            this.GroupLogIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupLogIn.Location = new System.Drawing.Point(12, 12);
            this.GroupLogIn.Name = "GroupLogIn";
            this.GroupLogIn.Size = new System.Drawing.Size(768, 549);
            this.GroupLogIn.TabIndex = 0;
            this.GroupLogIn.TabStop = false;
            this.GroupLogIn.Text = "LogIn";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.Location = new System.Drawing.Point(425, 482);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 47);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // btnGuset
            // 
            this.btnGuset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuset.BackColor = System.Drawing.Color.Transparent;
            this.btnGuset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuset.Image = global::GoFitness.Properties.Resources.about;
            this.btnGuset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuset.Location = new System.Drawing.Point(647, 479);
            this.btnGuset.Name = "btnGuset";
            this.btnGuset.Size = new System.Drawing.Size(108, 50);
            this.btnGuset.TabIndex = 16;
            this.btnGuset.Text = "Guest";
            this.btnGuset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuset.UseVisualStyleBackColor = false;
            this.btnGuset.Click += new System.EventHandler(this.btnGuset_Click);
            // 
            // btnRegisterNewCustomer
            // 
            this.btnRegisterNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterNewCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegisterNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegisterNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewCustomer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnRegisterNewCustomer.Image = global::GoFitness.Properties.Resources.rigster1;
            this.btnRegisterNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterNewCustomer.Location = new System.Drawing.Point(523, 479);
            this.btnRegisterNewCustomer.Name = "btnRegisterNewCustomer";
            this.btnRegisterNewCustomer.Size = new System.Drawing.Size(118, 50);
            this.btnRegisterNewCustomer.TabIndex = 15;
            this.btnRegisterNewCustomer.Text = "Register";
            this.btnRegisterNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterNewCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterNewCustomer.Click += new System.EventHandler(this.btnRegisterNewCustomer_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(165, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 24);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Location = new System.Drawing.Point(165, 95);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 24);
            this.txtUserName.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Image = global::GoFitness.Properties.Resources._1418914146_309058;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPassword.Location = new System.Drawing.Point(17, 139);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 29);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Image = global::GoFitness.Properties.Resources.username11;
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsername.Location = new System.Drawing.Point(17, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "UserName";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupLogIn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.GroupLogIn.ResumeLayout(false);
            this.GroupLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupLogIn;
        private System.Windows.Forms.Button btnGuset;
        private System.Windows.Forms.Button btnRegisterNewCustomer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button loginButton;

    }
}

