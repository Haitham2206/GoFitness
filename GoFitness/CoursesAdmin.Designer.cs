namespace GoFitness
{
    partial class CoursesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesAdmin));
            this.txtIsAvailable = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCoursetPrice = new System.Windows.Forms.TextBox();
            this.groupCourse = new System.Windows.Forms.GroupBox();
            this.txtNameOfCourse = new System.Windows.Forms.TextBox();
            this.lblNameOfCourse = new System.Windows.Forms.Label();
            this.dateTimeExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dateTimeJoin = new System.Windows.Forms.DateTimePicker();
            this.lblisAvailable = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblQuantityOfMembers = new System.Windows.Forms.Label();
            this.lblCodeOfCourse = new System.Windows.Forms.Label();
            this.lblCoursePrice = new System.Windows.Forms.Label();
            this.GroupCoursetList = new System.Windows.Forms.GroupBox();
            this.dataGridCourseList = new System.Windows.Forms.DataGridView();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.printCourseTable = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupCourse.SuspendLayout();
            this.GroupCoursetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourseList)).BeginInit();
            this.GroupnaNavigator.SuspendLayout();
            this.GroupOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIsAvailable
            // 
            this.txtIsAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsAvailable.Location = new System.Drawing.Point(247, 183);
            this.txtIsAvailable.Name = "txtIsAvailable";
            this.txtIsAvailable.Size = new System.Drawing.Size(180, 30);
            this.txtIsAvailable.TabIndex = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(247, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(180, 30);
            this.txtQuantity.TabIndex = 49;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseCode.Location = new System.Drawing.Point(247, 98);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(180, 30);
            this.txtCourseCode.TabIndex = 48;
            // 
            // txtCoursetPrice
            // 
            this.txtCoursetPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCoursetPrice.Location = new System.Drawing.Point(247, 22);
            this.txtCoursetPrice.Name = "txtCoursetPrice";
            this.txtCoursetPrice.Size = new System.Drawing.Size(180, 30);
            this.txtCoursetPrice.TabIndex = 47;
            // 
            // groupCourse
            // 
            this.groupCourse.Controls.Add(this.txtNameOfCourse);
            this.groupCourse.Controls.Add(this.lblNameOfCourse);
            this.groupCourse.Controls.Add(this.dateTimeExpiration);
            this.groupCourse.Controls.Add(this.lblExpirationDate);
            this.groupCourse.Controls.Add(this.dateTimeJoin);
            this.groupCourse.Controls.Add(this.txtIsAvailable);
            this.groupCourse.Controls.Add(this.txtQuantity);
            this.groupCourse.Controls.Add(this.txtCourseCode);
            this.groupCourse.Controls.Add(this.txtCoursetPrice);
            this.groupCourse.Controls.Add(this.lblisAvailable);
            this.groupCourse.Controls.Add(this.lblJoinDate);
            this.groupCourse.Controls.Add(this.lblQuantityOfMembers);
            this.groupCourse.Controls.Add(this.lblCodeOfCourse);
            this.groupCourse.Controls.Add(this.lblCoursePrice);
            this.groupCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCourse.Location = new System.Drawing.Point(5, 12);
            this.groupCourse.Name = "groupCourse";
            this.groupCourse.Size = new System.Drawing.Size(433, 327);
            this.groupCourse.TabIndex = 27;
            this.groupCourse.TabStop = false;
            this.groupCourse.Text = "Courses:";
            // 
            // txtNameOfCourse
            // 
            this.txtNameOfCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameOfCourse.Location = new System.Drawing.Point(247, 60);
            this.txtNameOfCourse.Name = "txtNameOfCourse";
            this.txtNameOfCourse.Size = new System.Drawing.Size(180, 30);
            this.txtNameOfCourse.TabIndex = 56;
            // 
            // lblNameOfCourse
            // 
            this.lblNameOfCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameOfCourse.Image = global::GoFitness.Properties.Resources._1427829477_309036_1281;
            this.lblNameOfCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameOfCourse.Location = new System.Drawing.Point(19, 59);
            this.lblNameOfCourse.Name = "lblNameOfCourse";
            this.lblNameOfCourse.Size = new System.Drawing.Size(222, 31);
            this.lblNameOfCourse.TabIndex = 55;
            this.lblNameOfCourse.Text = "Name Of Course:";
            // 
            // dateTimeExpiration
            // 
            this.dateTimeExpiration.Location = new System.Drawing.Point(247, 270);
            this.dateTimeExpiration.Name = "dateTimeExpiration";
            this.dateTimeExpiration.Size = new System.Drawing.Size(180, 30);
            this.dateTimeExpiration.TabIndex = 54;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpirationDate.Image = global::GoFitness.Properties.Resources._1427828467_175021;
            this.lblExpirationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExpirationDate.Location = new System.Drawing.Point(19, 271);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(222, 29);
            this.lblExpirationDate.TabIndex = 53;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // dateTimeJoin
            // 
            this.dateTimeJoin.Location = new System.Drawing.Point(247, 226);
            this.dateTimeJoin.Name = "dateTimeJoin";
            this.dateTimeJoin.Size = new System.Drawing.Size(180, 30);
            this.dateTimeJoin.TabIndex = 52;
            // 
            // lblisAvailable
            // 
            this.lblisAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblisAvailable.Image = global::GoFitness.Properties.Resources.sign_available;
            this.lblisAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblisAvailable.Location = new System.Drawing.Point(19, 170);
            this.lblisAvailable.Name = "lblisAvailable";
            this.lblisAvailable.Size = new System.Drawing.Size(222, 52);
            this.lblisAvailable.TabIndex = 43;
            this.lblisAvailable.Text = "isAvailable:";
            this.lblisAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJoinDate.Image = global::GoFitness.Properties.Resources._1427828737_175267;
            this.lblJoinDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblJoinDate.Location = new System.Drawing.Point(19, 227);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(222, 38);
            this.lblJoinDate.TabIndex = 42;
            this.lblJoinDate.Text = "Join Date:";
            // 
            // lblQuantityOfMembers
            // 
            this.lblQuantityOfMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantityOfMembers.Image = global::GoFitness.Properties.Resources.quantity;
            this.lblQuantityOfMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantityOfMembers.Location = new System.Drawing.Point(19, 139);
            this.lblQuantityOfMembers.Name = "lblQuantityOfMembers";
            this.lblQuantityOfMembers.Size = new System.Drawing.Size(222, 31);
            this.lblQuantityOfMembers.TabIndex = 41;
            this.lblQuantityOfMembers.Text = "Quantity Of Members:";
            // 
            // lblCodeOfCourse
            // 
            this.lblCodeOfCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodeOfCourse.Image = global::GoFitness.Properties.Resources.barcode;
            this.lblCodeOfCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodeOfCourse.Location = new System.Drawing.Point(19, 97);
            this.lblCodeOfCourse.Name = "lblCodeOfCourse";
            this.lblCodeOfCourse.Size = new System.Drawing.Size(222, 31);
            this.lblCodeOfCourse.TabIndex = 40;
            this.lblCodeOfCourse.Text = "Code Of Course:";
            // 
            // lblCoursePrice
            // 
            this.lblCoursePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCoursePrice.Image = global::GoFitness.Properties.Resources._1427828776_175744;
            this.lblCoursePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCoursePrice.Location = new System.Drawing.Point(19, 21);
            this.lblCoursePrice.Name = "lblCoursePrice";
            this.lblCoursePrice.Size = new System.Drawing.Size(222, 38);
            this.lblCoursePrice.TabIndex = 39;
            this.lblCoursePrice.Text = "Course Price:";
            // 
            // GroupCoursetList
            // 
            this.GroupCoursetList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupCoursetList.Controls.Add(this.dataGridCourseList);
            this.GroupCoursetList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCoursetList.Location = new System.Drawing.Point(438, 12);
            this.GroupCoursetList.Name = "GroupCoursetList";
            this.GroupCoursetList.Size = new System.Drawing.Size(349, 327);
            this.GroupCoursetList.TabIndex = 24;
            this.GroupCoursetList.TabStop = false;
            this.GroupCoursetList.Text = "CourseList";
            // 
            // dataGridCourseList
            // 
            this.dataGridCourseList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridCourseList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourseList.Location = new System.Drawing.Point(6, 23);
            this.dataGridCourseList.Name = "dataGridCourseList";
            this.dataGridCourseList.Size = new System.Drawing.Size(331, 298);
            this.dataGridCourseList.TabIndex = 0;
            // 
            // GroupnaNavigator
            // 
            this.GroupnaNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupnaNavigator.Controls.Add(this.btnForward);
            this.GroupnaNavigator.Controls.Add(this.btnPrevious);
            this.GroupnaNavigator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupnaNavigator.Location = new System.Drawing.Point(5, 461);
            this.GroupnaNavigator.Name = "GroupnaNavigator";
            this.GroupnaNavigator.Size = new System.Drawing.Size(782, 100);
            this.GroupnaNavigator.TabIndex = 26;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(433, 30);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(116, 52);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(243, 30);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 52);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Controls.Add(this.btnPrint);
            this.GroupOperation.Controls.Add(this.btnUpdate);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.Location = new System.Drawing.Point(5, 345);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(782, 100);
            this.GroupOperation.TabIndex = 25;
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
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_216436;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(544, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "    Back";
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
            this.btnPrint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::GoFitness.Properties.Resources._1427824235_59191;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(333, 33);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 52);
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
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::GoFitness.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(104, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 52);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // printCourseTable
            // 
            this.printCourseTable.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCourseTable_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printCourseTable;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CoursesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupCourse);
            this.Controls.Add(this.GroupCoursetList);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoursesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            this.groupCourse.ResumeLayout(false);
            this.groupCourse.PerformLayout();
            this.GroupCoursetList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourseList)).EndInit();
            this.GroupnaNavigator.ResumeLayout(false);
            this.GroupOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsAvailable;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtCoursetPrice;
        private System.Windows.Forms.Label lblisAvailable;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblQuantityOfMembers;
        private System.Windows.Forms.GroupBox groupCourse;
        private System.Windows.Forms.Label lblCoursePrice;
        private System.Windows.Forms.GroupBox GroupCoursetList;
        private System.Windows.Forms.DataGridView dataGridCourseList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimeExpiration;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimeJoin;
        private System.Windows.Forms.TextBox txtNameOfCourse;
        private System.Windows.Forms.Label lblNameOfCourse;
        private System.Windows.Forms.Label lblCodeOfCourse;
        private System.Drawing.Printing.PrintDocument printCourseTable;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}