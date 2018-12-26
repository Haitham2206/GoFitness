namespace GoFitness
{
    partial class CourseUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseUser));
            this.btnBack = new System.Windows.Forms.Button();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnRegisterToCourse = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.dataGridCourseList = new System.Windows.Forms.DataGridView();
            this.GroupCoursetList = new System.Windows.Forms.GroupBox();
            this.GroupOperation.SuspendLayout();
            this.GroupnaNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourseList)).BeginInit();
            this.GroupCoursetList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_216436;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(445, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 51);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "  Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.Controls.Add(this.btnRegisterToCourse);
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.ForeColor = System.Drawing.Color.Black;
            this.GroupOperation.Location = new System.Drawing.Point(12, 345);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(782, 100);
            this.GroupOperation.TabIndex = 29;
            this.GroupOperation.TabStop = false;
            this.GroupOperation.Text = "Operation";
            // 
            // btnRegisterToCourse
            // 
            this.btnRegisterToCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterToCourse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegisterToCourse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterToCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterToCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegisterToCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterToCourse.Image = global::GoFitness.Properties.Resources._1427824375_175285;
            this.btnRegisterToCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterToCourse.Location = new System.Drawing.Point(134, 29);
            this.btnRegisterToCourse.Name = "btnRegisterToCourse";
            this.btnRegisterToCourse.Size = new System.Drawing.Size(234, 51);
            this.btnRegisterToCourse.TabIndex = 5;
            this.btnRegisterToCourse.Text = "Register To Course";
            this.btnRegisterToCourse.UseVisualStyleBackColor = true;
            this.btnRegisterToCourse.Click += new System.EventHandler(this.btnSubscribeToCourse_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(454, 35);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(123, 53);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(178, 35);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(123, 53);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // GroupnaNavigator
            // 
            this.GroupnaNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupnaNavigator.Controls.Add(this.btnForward);
            this.GroupnaNavigator.Controls.Add(this.btnPrevious);
            this.GroupnaNavigator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupnaNavigator.ForeColor = System.Drawing.Color.Black;
            this.GroupnaNavigator.Location = new System.Drawing.Point(12, 461);
            this.GroupnaNavigator.Name = "GroupnaNavigator";
            this.GroupnaNavigator.Size = new System.Drawing.Size(782, 100);
            this.GroupnaNavigator.TabIndex = 30;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // dataGridCourseList
            // 
            this.dataGridCourseList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridCourseList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourseList.Location = new System.Drawing.Point(17, 30);
            this.dataGridCourseList.Name = "dataGridCourseList";
            this.dataGridCourseList.Size = new System.Drawing.Size(751, 278);
            this.dataGridCourseList.TabIndex = 0;
            this.dataGridCourseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCourseList_CellContentClick);
            // 
            // GroupCoursetList
            // 
            this.GroupCoursetList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupCoursetList.Controls.Add(this.dataGridCourseList);
            this.GroupCoursetList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCoursetList.ForeColor = System.Drawing.Color.Black;
            this.GroupCoursetList.Location = new System.Drawing.Point(8, 12);
            this.GroupCoursetList.Name = "GroupCoursetList";
            this.GroupCoursetList.Size = new System.Drawing.Size(782, 327);
            this.GroupCoursetList.TabIndex = 28;
            this.GroupCoursetList.TabStop = false;
            this.GroupCoursetList.Text = "CourseList";
            // 
            // CourseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupOperation);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupCoursetList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.Load += new System.EventHandler(this.CourseUser_Load);
            this.GroupOperation.ResumeLayout(false);
            this.GroupnaNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourseList)).EndInit();
            this.GroupCoursetList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.DataGridView dataGridCourseList;
        private System.Windows.Forms.GroupBox GroupCoursetList;
        private System.Windows.Forms.Button btnRegisterToCourse;
    }
}