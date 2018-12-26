namespace GoFitness
{
    partial class ShopUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopUser));
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.GroupProductList = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.GroupProductList.SuspendLayout();
            this.GroupnaNavigator.SuspendLayout();
            this.GroupOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridProductList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductList.Location = new System.Drawing.Point(12, 30);
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.Size = new System.Drawing.Size(755, 278);
            this.dataGridProductList.TabIndex = 0;
            this.dataGridProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductList_CellContentClick);
            // 
            // GroupProductList
            // 
            this.GroupProductList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupProductList.BackColor = System.Drawing.Color.Transparent;
            this.GroupProductList.Controls.Add(this.dataGridProductList);
            this.GroupProductList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupProductList.Location = new System.Drawing.Point(0, 12);
            this.GroupProductList.Name = "GroupProductList";
            this.GroupProductList.Size = new System.Drawing.Size(782, 327);
            this.GroupProductList.TabIndex = 24;
            this.GroupProductList.TabStop = false;
            this.GroupProductList.Text = "ProductList";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(145, 29);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(152, 46);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(452, 29);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(152, 46);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // GroupnaNavigator
            // 
            this.GroupnaNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupnaNavigator.BackColor = System.Drawing.Color.Transparent;
            this.GroupnaNavigator.Controls.Add(this.btnForward);
            this.GroupnaNavigator.Controls.Add(this.btnPrevious);
            this.GroupnaNavigator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupnaNavigator.Location = new System.Drawing.Point(0, 461);
            this.GroupnaNavigator.Name = "GroupnaNavigator";
            this.GroupnaNavigator.Size = new System.Drawing.Size(782, 100);
            this.GroupnaNavigator.TabIndex = 26;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.BackColor = System.Drawing.Color.Transparent;
            this.GroupOperation.Controls.Add(this.btnPurchase);
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.Location = new System.Drawing.Point(0, 345);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(782, 100);
            this.GroupOperation.TabIndex = 25;
            this.GroupOperation.TabStop = false;
            this.GroupOperation.Text = "Operation";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPurchase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Image = global::GoFitness.Properties.Resources._1427825289_175374;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchase.Location = new System.Drawing.Point(145, 36);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(152, 46);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_2164368;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(452, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "    Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShopUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupOperation);
            this.Controls.Add(this.GroupProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopUser";
            this.Text = "Go Fitness";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.GroupProductList.ResumeLayout(false);
            this.GroupnaNavigator.ResumeLayout(false);
            this.GroupOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProductList;
        private System.Windows.Forms.GroupBox GroupProductList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.Button btnPurchase;
    }
}