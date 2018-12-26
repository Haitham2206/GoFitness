namespace GoFitness
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.GroupGuest = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.richTextAbout = new System.Windows.Forms.RichTextBox();
            this.GroupGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupGuest
            // 
            this.GroupGuest.BackColor = System.Drawing.Color.White;
            this.GroupGuest.Controls.Add(this.btnBack);
            this.GroupGuest.Controls.Add(this.richTextAbout);
            this.GroupGuest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupGuest.ForeColor = System.Drawing.Color.Black;
            this.GroupGuest.Location = new System.Drawing.Point(12, 12);
            this.GroupGuest.Name = "GroupGuest";
            this.GroupGuest.Size = new System.Drawing.Size(776, 560);
            this.GroupGuest.TabIndex = 0;
            this.GroupGuest.TabStop = false;
            this.GroupGuest.Text = "About";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_2164361;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(627, 509);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richTextAbout
            // 
            this.richTextAbout.BackColor = System.Drawing.Color.White;
            this.richTextAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextAbout.Location = new System.Drawing.Point(3, 26);
            this.richTextAbout.Name = "richTextAbout";
            this.richTextAbout.ReadOnly = true;
            this.richTextAbout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextAbout.Size = new System.Drawing.Size(770, 531);
            this.richTextAbout.TabIndex = 0;
            this.richTextAbout.Text = resources.GetString("richTextAbout.Text");
            this.richTextAbout.TextChanged += new System.EventHandler(this.richTextAbout_TextChanged);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupGuest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoFitness";
            this.GroupGuest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupGuest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox richTextAbout;
    }
}