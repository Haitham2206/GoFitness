namespace GoFitness
{
    partial class SwimmingMemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwimmingMemberList));
            this.dataGridSwimmingMemberList = new System.Windows.Forms.DataGridView();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GroupSwimmingMemberList = new System.Windows.Forms.GroupBox();
            this.groupMember = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSwimmingMemberList)).BeginInit();
            this.GroupnaNavigator.SuspendLayout();
            this.GroupOperation.SuspendLayout();
            this.GroupSwimmingMemberList.SuspendLayout();
            this.groupMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSwimmingMemberList
            // 
            this.dataGridSwimmingMemberList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridSwimmingMemberList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSwimmingMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSwimmingMemberList.Location = new System.Drawing.Point(6, 33);
            this.dataGridSwimmingMemberList.Name = "dataGridSwimmingMemberList";
            this.dataGridSwimmingMemberList.Size = new System.Drawing.Size(362, 278);
            this.dataGridSwimmingMemberList.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(400, 29);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(134, 45);
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
            this.btnPrevious.Location = new System.Drawing.Point(202, 29);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(134, 45);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // GroupnaNavigator
            // 
            this.GroupnaNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupnaNavigator.BackColor = System.Drawing.Color.Transparent;
            this.GroupnaNavigator.Controls.Add(this.btnForward);
            this.GroupnaNavigator.Controls.Add(this.btnPrevious);
            this.GroupnaNavigator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupnaNavigator.Location = new System.Drawing.Point(14, 461);
            this.GroupnaNavigator.Name = "GroupnaNavigator";
            this.GroupnaNavigator.Size = new System.Drawing.Size(768, 100);
            this.GroupnaNavigator.TabIndex = 22;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.BackColor = System.Drawing.Color.Transparent;
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Controls.Add(this.btnPrint);
            this.GroupOperation.Controls.Add(this.btnDelete);
            this.GroupOperation.Controls.Add(this.btnUpdate);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.Location = new System.Drawing.Point(14, 352);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(768, 103);
            this.GroupOperation.TabIndex = 21;
            this.GroupOperation.TabStop = false;
            this.GroupOperation.Text = "Operation";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_2164369;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(593, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::GoFitness.Properties.Resources._1427824235_591917;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(400, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 45);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GoFitness.Properties.Resources._1427824973_1752945;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(202, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = global::GoFitness.Properties.Resources.update5;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(24, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // GroupSwimmingMemberList
            // 
            this.GroupSwimmingMemberList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupSwimmingMemberList.BackColor = System.Drawing.Color.Transparent;
            this.GroupSwimmingMemberList.Controls.Add(this.dataGridSwimmingMemberList);
            this.GroupSwimmingMemberList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSwimmingMemberList.Location = new System.Drawing.Point(408, 12);
            this.GroupSwimmingMemberList.Name = "GroupSwimmingMemberList";
            this.GroupSwimmingMemberList.Size = new System.Drawing.Size(374, 334);
            this.GroupSwimmingMemberList.TabIndex = 20;
            this.GroupSwimmingMemberList.TabStop = false;
            this.GroupSwimmingMemberList.Text = "SwimmingMemberList";
            // 
            // groupMember
            // 
            this.groupMember.BackColor = System.Drawing.Color.Transparent;
            this.groupMember.Controls.Add(this.txtWeight);
            this.groupMember.Controls.Add(this.txtId);
            this.groupMember.Controls.Add(this.txtEmail);
            this.groupMember.Controls.Add(this.txtPhoneNumber);
            this.groupMember.Controls.Add(this.txtCourse);
            this.groupMember.Controls.Add(this.txtAge);
            this.groupMember.Controls.Add(this.txtLastName);
            this.groupMember.Controls.Add(this.txtFirstName);
            this.groupMember.Controls.Add(this.label8);
            this.groupMember.Controls.Add(this.lblId);
            this.groupMember.Controls.Add(this.lblEmail);
            this.groupMember.Controls.Add(this.lblPhoneNumber);
            this.groupMember.Controls.Add(this.lblCourse);
            this.groupMember.Controls.Add(this.lblAge);
            this.groupMember.Controls.Add(this.lblLastName);
            this.groupMember.Controls.Add(this.lblFirstName);
            this.groupMember.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMember.Location = new System.Drawing.Point(12, 12);
            this.groupMember.Name = "groupMember";
            this.groupMember.Size = new System.Drawing.Size(390, 334);
            this.groupMember.TabIndex = 24;
            this.groupMember.TabStop = false;
            this.groupMember.Text = "Member";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(210, 297);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(174, 30);
            this.txtWeight.TabIndex = 54;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(210, 260);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 30);
            this.txtId.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(210, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 30);
            this.txtEmail.TabIndex = 52;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(210, 176);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 30);
            this.txtPhoneNumber.TabIndex = 51;
            // 
            // txtCourse
            // 
            this.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourse.Location = new System.Drawing.Point(210, 136);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(174, 30);
            this.txtCourse.TabIndex = 50;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAge.Location = new System.Drawing.Point(210, 103);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(174, 30);
            this.txtAge.TabIndex = 49;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(210, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 30);
            this.txtLastName.TabIndex = 48;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(210, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 30);
            this.txtFirstName.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Image = global::GoFitness.Properties.Resources._1427828850_858275;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(4, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 38);
            this.label8.TabIndex = 46;
            this.label8.Text = "Weight:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.Image = global::GoFitness.Properties.Resources._1427828797_1756245;
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Location = new System.Drawing.Point(6, 255);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(198, 38);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.Image = global::GoFitness.Properties.Resources._;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Location = new System.Drawing.Point(6, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(198, 38);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.Image = global::GoFitness.Properties.Resources.phonenumber;
            this.lblPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 171);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(198, 38);
            this.lblPhoneNumber.TabIndex = 43;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCourse.Image = global::GoFitness.Properties.Resources._1427829477_309036_1286;
            this.lblCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCourse.Location = new System.Drawing.Point(6, 131);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(198, 38);
            this.lblCourse.TabIndex = 42;
            this.lblCourse.Text = "Course:";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.Image = global::GoFitness.Properties.Resources.age;
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAge.Location = new System.Drawing.Point(6, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(198, 38);
            this.lblAge.TabIndex = 41;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.Image = global::GoFitness.Properties.Resources.fname_lname;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Location = new System.Drawing.Point(6, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(198, 38);
            this.lblLastName.TabIndex = 40;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.Image = global::GoFitness.Properties.Resources.fname_lname;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Location = new System.Drawing.Point(6, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(198, 38);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwimmingMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupMember);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupOperation);
            this.Controls.Add(this.GroupSwimmingMemberList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SwimmingMemberList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSwimmingMemberList)).EndInit();
            this.GroupnaNavigator.ResumeLayout(false);
            this.GroupOperation.ResumeLayout(false);
            this.GroupSwimmingMemberList.ResumeLayout(false);
            this.groupMember.ResumeLayout(false);
            this.groupMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridSwimmingMemberList;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox GroupSwimmingMemberList;
        private System.Windows.Forms.GroupBox groupMember;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}