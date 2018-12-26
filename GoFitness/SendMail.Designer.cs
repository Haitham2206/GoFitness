namespace GoFitness
{
    partial class SendMail
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
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblattachment = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.openFileDialogBrowse = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxSend.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSend.Controls.Add(this.btnBrowse);
            this.groupBoxSend.Controls.Add(this.txtBody);
            this.groupBoxSend.Controls.Add(this.txtSubject);
            this.groupBoxSend.Controls.Add(this.txtAttachment);
            this.groupBoxSend.Controls.Add(this.txtTo);
            this.groupBoxSend.Controls.Add(this.lblattachment);
            this.groupBoxSend.Controls.Add(this.lblBody);
            this.groupBoxSend.Controls.Add(this.lblsubject);
            this.groupBoxSend.Controls.Add(this.lblTo);
            this.groupBoxSend.Controls.Add(this.btnSend);
            this.groupBoxSend.Controls.Add(this.txtEmail);
            this.groupBoxSend.Controls.Add(this.txtPassword);
            this.groupBoxSend.Controls.Add(this.lblEmail);
            this.groupBoxSend.Controls.Add(this.lblPassword);
            this.groupBoxSend.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSend.Location = new System.Drawing.Point(17, 6);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(750, 550);
            this.groupBoxSend.TabIndex = 2;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Send";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.Location = new System.Drawing.Point(522, 197);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(122, 45);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(213, 304);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(431, 173);
            this.txtBody.TabIndex = 26;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(213, 248);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(431, 30);
            this.txtSubject.TabIndex = 24;
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(213, 161);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.Size = new System.Drawing.Size(431, 30);
            this.txtAttachment.TabIndex = 21;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(213, 103);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(431, 30);
            this.txtTo.TabIndex = 19;
            // 
            // lblattachment
            // 
            this.lblattachment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblattachment.Location = new System.Drawing.Point(15, 161);
            this.lblattachment.Name = "lblattachment";
            this.lblattachment.Size = new System.Drawing.Size(192, 30);
            this.lblattachment.TabIndex = 20;
            this.lblattachment.Text = "Add Attachment";
            this.lblattachment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBody
            // 
            this.lblBody.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBody.Location = new System.Drawing.Point(15, 307);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(192, 28);
            this.lblBody.TabIndex = 25;
            this.lblBody.Text = "Body";
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsubject
            // 
            this.lblsubject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblsubject.Location = new System.Drawing.Point(12, 248);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(195, 30);
            this.lblsubject.TabIndex = 23;
            this.lblsubject.Text = "Subject";
            this.lblsubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTo
            // 
            this.lblTo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTo.Location = new System.Drawing.Point(15, 103);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(192, 30);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(608, 496);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 40);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 30);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(501, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Location = new System.Drawing.Point(15, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(192, 33);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPassword.Location = new System.Drawing.Point(374, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(121, 30);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialogBrowse
            // 
            this.openFileDialogBrowse.FileName = "Browse";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBoxSend);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblattachment;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowse;
    }
}