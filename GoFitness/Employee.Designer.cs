namespace GoFitness
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.GroupEmployee = new System.Windows.Forms.GroupBox();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnSwimmingMemberList = new System.Windows.Forms.Button();
            this.btnDancingMemberList = new System.Windows.Forms.Button();
            this.btnGymMemberList = new System.Windows.Forms.Button();
            this.GroupEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupEmployee
            // 
            this.GroupEmployee.BackColor = System.Drawing.Color.White;
            this.GroupEmployee.BackgroundImage = global::GoFitness.Properties.Resources.worker;
            this.GroupEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupEmployee.Controls.Add(this.btnMemberList);
            this.GroupEmployee.Controls.Add(this.btnSwimmingMemberList);
            this.GroupEmployee.Controls.Add(this.btnDancingMemberList);
            this.GroupEmployee.Controls.Add(this.btnGymMemberList);
            this.GroupEmployee.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEmployee.ForeColor = System.Drawing.Color.Black;
            this.GroupEmployee.Location = new System.Drawing.Point(12, 31);
            this.GroupEmployee.Name = "GroupEmployee";
            this.GroupEmployee.Size = new System.Drawing.Size(768, 530);
            this.GroupEmployee.TabIndex = 1;
            this.GroupEmployee.TabStop = false;
            this.GroupEmployee.Text = "Emloyee";
            // 
            // btnMemberList
            // 
            this.btnMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberList.Image = global::GoFitness.Properties.Resources._1427824441_175724;
            this.btnMemberList.Location = new System.Drawing.Point(6, 405);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(215, 138);
            this.btnMemberList.TabIndex = 3;
            this.btnMemberList.Text = "MemberList";
            this.btnMemberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMemberList.UseVisualStyleBackColor = true;
            this.btnMemberList.Click += new System.EventHandler(this.btnMemberList_Click);
            // 
            // btnSwimmingMemberList
            // 
            this.btnSwimmingMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSwimmingMemberList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwimmingMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwimmingMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwimmingMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwimmingMemberList.Image = global::GoFitness.Properties.Resources._1427828510_174794_128;
            this.btnSwimmingMemberList.Location = new System.Drawing.Point(547, 405);
            this.btnSwimmingMemberList.Name = "btnSwimmingMemberList";
            this.btnSwimmingMemberList.Size = new System.Drawing.Size(215, 138);
            this.btnSwimmingMemberList.TabIndex = 2;
            this.btnSwimmingMemberList.Text = "Swimming Member\'s List";
            this.btnSwimmingMemberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSwimmingMemberList.UseVisualStyleBackColor = true;
            this.btnSwimmingMemberList.Click += new System.EventHandler(this.btnSwimmingMemberList_Click);
            // 
            // btnDancingMemberList
            // 
            this.btnDancingMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDancingMemberList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDancingMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDancingMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDancingMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDancingMemberList.Image = global::GoFitness.Properties.Resources._1427828561_175106_128;
            this.btnDancingMemberList.Location = new System.Drawing.Point(547, 29);
            this.btnDancingMemberList.Name = "btnDancingMemberList";
            this.btnDancingMemberList.Size = new System.Drawing.Size(215, 138);
            this.btnDancingMemberList.TabIndex = 1;
            this.btnDancingMemberList.Text = "Dancing Member\'s List";
            this.btnDancingMemberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDancingMemberList.UseVisualStyleBackColor = true;
            this.btnDancingMemberList.Click += new System.EventHandler(this.btnDancingMemberList_Click);
            // 
            // btnGymMemberList
            // 
            this.btnGymMemberList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGymMemberList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGymMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGymMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGymMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGymMemberList.Image = global::GoFitness.Properties.Resources._11;
            this.btnGymMemberList.Location = new System.Drawing.Point(6, 29);
            this.btnGymMemberList.Name = "btnGymMemberList";
            this.btnGymMemberList.Size = new System.Drawing.Size(215, 138);
            this.btnGymMemberList.TabIndex = 0;
            this.btnGymMemberList.Text = "Gym Member\'s List";
            this.btnGymMemberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGymMemberList.UseVisualStyleBackColor = true;
            this.btnGymMemberList.Click += new System.EventHandler(this.btnGymMemberList_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.GroupEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupEmployee;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnSwimmingMemberList;
        private System.Windows.Forms.Button btnDancingMemberList;
        private System.Windows.Forms.Button btnGymMemberList;
    }
}