namespace GoFitness
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.GroupUser = new System.Windows.Forms.GroupBox();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnPersonalDetails = new System.Windows.Forms.Button();
            this.GroupUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupUser
            // 
            this.GroupUser.BackgroundImage = global::GoFitness.Properties.Resources.user1;
            this.GroupUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupUser.Controls.Add(this.btnShop);
            this.GroupUser.Controls.Add(this.btnCourses);
            this.GroupUser.Controls.Add(this.btnPersonalDetails);
            this.GroupUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupUser.Location = new System.Drawing.Point(12, 24);
            this.GroupUser.Name = "GroupUser";
            this.GroupUser.Size = new System.Drawing.Size(779, 548);
            this.GroupUser.TabIndex = 0;
            this.GroupUser.TabStop = false;
            this.GroupUser.Text = "User";
            // 
            // btnShop
            // 
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Image = global::GoFitness.Properties.Resources._1427825384_1755301;
            this.btnShop.Location = new System.Drawing.Point(6, 417);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(185, 128);
            this.btnShop.TabIndex = 5;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCourses.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Image = global::GoFitness.Properties.Resources._1427829477_309036_1287;
            this.btnCourses.Location = new System.Drawing.Point(588, 417);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(185, 128);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnPersonalDetails
            // 
            this.btnPersonalDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonalDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonalDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonalDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalDetails.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalDetails.Image = global::GoFitness.Properties.Resources._1427824452_175005;
            this.btnPersonalDetails.Location = new System.Drawing.Point(293, 19);
            this.btnPersonalDetails.Name = "btnPersonalDetails";
            this.btnPersonalDetails.Size = new System.Drawing.Size(185, 128);
            this.btnPersonalDetails.TabIndex = 3;
            this.btnPersonalDetails.Text = "Personal Details";
            this.btnPersonalDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonalDetails.UseVisualStyleBackColor = true;
            this.btnPersonalDetails.Click += new System.EventHandler(this.btnPersonalDetails_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.GroupUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupUser;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnPersonalDetails;
    }
}