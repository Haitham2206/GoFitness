namespace GoFitness
{
    partial class EmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridEmployeeList = new System.Windows.Forms.DataGridView();
            this.GroupEmployeeList = new System.Windows.Forms.GroupBox();
            this.groupEmployee = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.printEmployeeList = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.GroupnaNavigator.SuspendLayout();
            this.GroupOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeList)).BeginInit();
            this.GroupEmployeeList.SuspendLayout();
            this.groupEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(168, 131);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 30);
            this.txtId.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(168, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 30);
            this.txtEmail.TabIndex = 52;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 220);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 30);
            this.txtPhoneNumber.TabIndex = 51;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAge.Location = new System.Drawing.Point(168, 171);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(142, 30);
            this.txtAge.TabIndex = 49;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(168, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 30);
            this.txtLastName.TabIndex = 48;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(168, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 30);
            this.txtFirstName.TabIndex = 47;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(477, 19);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(114, 36);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // GroupnaNavigator
            // 
            this.GroupnaNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupnaNavigator.Controls.Add(this.btnForward);
            this.GroupnaNavigator.Controls.Add(this.btnPrevious);
            this.GroupnaNavigator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupnaNavigator.ForeColor = System.Drawing.Color.Black;
            this.GroupnaNavigator.Location = new System.Drawing.Point(3, 500);
            this.GroupnaNavigator.Name = "GroupnaNavigator";
            this.GroupnaNavigator.Size = new System.Drawing.Size(777, 61);
            this.GroupnaNavigator.TabIndex = 28;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(186, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(114, 36);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_2164362;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(658, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.Controls.Add(this.btnFireEmployee);
            this.GroupOperation.Controls.Add(this.btnAdd);
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Controls.Add(this.btnPrint);
            this.GroupOperation.Controls.Add(this.btnUpdate);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.Location = new System.Drawing.Point(3, 425);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(777, 69);
            this.GroupOperation.TabIndex = 27;
            this.GroupOperation.TabStop = false;
            this.GroupOperation.Text = "Operation";
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFireEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFireEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFireEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFireEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFireEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFireEmployee.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployee.Image = global::GoFitness.Properties.Resources._1427828168_175264;
            this.btnFireEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFireEmployee.Location = new System.Drawing.Point(307, 27);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(163, 36);
            this.btnFireEmployee.TabIndex = 6;
            this.btnFireEmployee.Text = "Fire Employee";
            this.btnFireEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFireEmployee.UseVisualStyleBackColor = true;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GoFitness.Properties.Resources._1427822310_174634;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(9, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::GoFitness.Properties.Resources._1427824235_591912;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(505, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 36);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = global::GoFitness.Properties.Resources.update1;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(168, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridEmployeeList
            // 
            this.dataGridEmployeeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridEmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeeList.Location = new System.Drawing.Point(16, 29);
            this.dataGridEmployeeList.Name = "dataGridEmployeeList";
            this.dataGridEmployeeList.Size = new System.Drawing.Size(424, 372);
            this.dataGridEmployeeList.TabIndex = 0;
            this.dataGridEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployeeList_CellContentClick);
            // 
            // GroupEmployeeList
            // 
            this.GroupEmployeeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupEmployeeList.Controls.Add(this.dataGridEmployeeList);
            this.GroupEmployeeList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEmployeeList.ForeColor = System.Drawing.Color.Black;
            this.GroupEmployeeList.Location = new System.Drawing.Point(325, 12);
            this.GroupEmployeeList.Name = "GroupEmployeeList";
            this.GroupEmployeeList.Size = new System.Drawing.Size(455, 407);
            this.GroupEmployeeList.TabIndex = 26;
            this.GroupEmployeeList.TabStop = false;
            this.GroupEmployeeList.Text = "Employee List";
            // 
            // groupEmployee
            // 
            this.groupEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupEmployee.Controls.Add(this.txtPassword);
            this.groupEmployee.Controls.Add(this.lblPassword);
            this.groupEmployee.Controls.Add(this.txtUserName);
            this.groupEmployee.Controls.Add(this.lblUserName);
            this.groupEmployee.Controls.Add(this.txtId);
            this.groupEmployee.Controls.Add(this.txtEmail);
            this.groupEmployee.Controls.Add(this.txtPhoneNumber);
            this.groupEmployee.Controls.Add(this.txtAge);
            this.groupEmployee.Controls.Add(this.txtLastName);
            this.groupEmployee.Controls.Add(this.txtFirstName);
            this.groupEmployee.Controls.Add(this.lblId);
            this.groupEmployee.Controls.Add(this.lblEmail);
            this.groupEmployee.Controls.Add(this.lblPhoneNumber);
            this.groupEmployee.Controls.Add(this.lblAge);
            this.groupEmployee.Controls.Add(this.lblLastName);
            this.groupEmployee.Controls.Add(this.lblFirstName);
            this.groupEmployee.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEmployee.ForeColor = System.Drawing.Color.Black;
            this.groupEmployee.Location = new System.Drawing.Point(3, 12);
            this.groupEmployee.Name = "groupEmployee";
            this.groupEmployee.Size = new System.Drawing.Size(316, 407);
            this.groupEmployee.TabIndex = 29;
            this.groupEmployee.TabStop = false;
            this.groupEmployee.Text = "Employee";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(168, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 30);
            this.txtPassword.TabIndex = 57;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.Image = global::GoFitness.Properties.Resources._1418914146_309058;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPassword.Location = new System.Drawing.Point(8, 362);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(157, 37);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(168, 321);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 30);
            this.txtUserName.TabIndex = 55;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.Image = global::GoFitness.Properties.Resources.guest;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserName.Location = new System.Drawing.Point(7, 317);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(157, 37);
            this.lblUserName.TabIndex = 54;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.Image = global::GoFitness.Properties.Resources._1427828797_175624;
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Location = new System.Drawing.Point(5, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(157, 37);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.Image = global::GoFitness.Properties.Resources._1;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Location = new System.Drawing.Point(5, 268);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(157, 37);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.Image = global::GoFitness.Properties.Resources.phonenumber;
            this.lblPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 218);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(157, 37);
            this.lblPhoneNumber.TabIndex = 43;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.Image = global::GoFitness.Properties.Resources.age11;
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAge.Location = new System.Drawing.Point(5, 174);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(157, 37);
            this.lblAge.TabIndex = 41;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.Image = global::GoFitness.Properties.Resources.fname_lname;
            this.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Location = new System.Drawing.Point(5, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(157, 37);
            this.lblLastName.TabIndex = 40;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.Image = global::GoFitness.Properties.Resources.fname_lname;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Location = new System.Drawing.Point(5, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(157, 37);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printEmployeeList
            // 
            this.printEmployeeList.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printEmployeeList;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupOperation);
            this.Controls.Add(this.GroupEmployeeList);
            this.Controls.Add(this.groupEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.GroupnaNavigator.ResumeLayout(false);
            this.GroupOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeList)).EndInit();
            this.GroupEmployeeList.ResumeLayout(false);
            this.groupEmployee.ResumeLayout(false);
            this.groupEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.DataGridView dataGridEmployeeList;
        private System.Windows.Forms.GroupBox GroupEmployeeList;
        private System.Windows.Forms.GroupBox groupEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Drawing.Printing.PrintDocument printEmployeeList;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}