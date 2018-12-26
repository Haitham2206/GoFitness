namespace GoFitness
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.groupReceipt = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSendToEmail = new System.Windows.Forms.Button();
            this.richTextReceipt = new System.Windows.Forms.RichTextBox();
            this.printReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupReceipt
            // 
            this.groupReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupReceipt.BackColor = System.Drawing.Color.White;
            this.groupReceipt.Controls.Add(this.btnOk);
            this.groupReceipt.Controls.Add(this.btnPrint);
            this.groupReceipt.Controls.Add(this.btnSendToEmail);
            this.groupReceipt.Controls.Add(this.richTextReceipt);
            this.groupReceipt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupReceipt.Location = new System.Drawing.Point(12, 12);
            this.groupReceipt.Name = "groupReceipt";
            this.groupReceipt.Size = new System.Drawing.Size(768, 549);
            this.groupReceipt.TabIndex = 0;
            this.groupReceipt.TabStop = false;
            this.groupReceipt.Text = "Receipt";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = global::GoFitness.Properties.Resources.ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(601, 500);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(161, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "      Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::GoFitness.Properties.Resources._1427824235_591915;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(233, 500);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(161, 43);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSendToEmail
            // 
            this.btnSendToEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendToEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSendToEmail.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSendToEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSendToEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSendToEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToEmail.Image = global::GoFitness.Properties.Resources._;
            this.btnSendToEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendToEmail.Location = new System.Drawing.Point(434, 500);
            this.btnSendToEmail.Name = "btnSendToEmail";
            this.btnSendToEmail.Size = new System.Drawing.Size(161, 43);
            this.btnSendToEmail.TabIndex = 4;
            this.btnSendToEmail.Text = "Send To Email";
            this.btnSendToEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendToEmail.UseVisualStyleBackColor = true;
            // 
            // richTextReceipt
            // 
            this.richTextReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextReceipt.BackColor = System.Drawing.Color.White;
            this.richTextReceipt.Location = new System.Drawing.Point(24, 29);
            this.richTextReceipt.Name = "richTextReceipt";
            this.richTextReceipt.ReadOnly = true;
            this.richTextReceipt.Size = new System.Drawing.Size(738, 465);
            this.richTextReceipt.TabIndex = 0;
            this.richTextReceipt.Text = "";
            this.richTextReceipt.TextChanged += new System.EventHandler(this.richTextReceipt_TextChanged);
            // 
            // printReceipt
            // 
            this.printReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReceipt_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printReceipt;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoFitness";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.groupReceipt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupReceipt;
        private System.Windows.Forms.RichTextBox richTextReceipt;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSendToEmail;
        private System.Drawing.Printing.PrintDocument printReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}