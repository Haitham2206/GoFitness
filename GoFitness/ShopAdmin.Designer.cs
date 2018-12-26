namespace GoFitness
{
    partial class ShopAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopAdmin));
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.GroupnaNavigator = new System.Windows.Forms.GroupBox();
            this.GroupOperation = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.GroupProductList = new System.Windows.Forms.GroupBox();
            this.groupProduct = new System.Windows.Forms.GroupBox();
            this.txtIsAvailable = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProudctName = new System.Windows.Forms.TextBox();
            this.txtProudctPrice = new System.Windows.Forms.TextBox();
            this.lblisAvailable = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProudctCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProdctPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printShopTable = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.GroupnaNavigator.SuspendLayout();
            this.GroupOperation.SuspendLayout();
            this.GroupProductList.SuspendLayout();
            this.groupProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnBack.Image = global::GoFitness.Properties.Resources._1427821810_2164367;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(638, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridProductList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductList.Location = new System.Drawing.Point(6, 30);
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.Size = new System.Drawing.Size(345, 278);
            this.dataGridProductList.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.Location = new System.Drawing.Point(480, 29);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(119, 46);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.Location = new System.Drawing.Point(189, 29);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(119, 46);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
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
            this.GroupnaNavigator.TabIndex = 22;
            this.GroupnaNavigator.TabStop = false;
            this.GroupnaNavigator.Text = "Navigator";
            // 
            // GroupOperation
            // 
            this.GroupOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOperation.BackColor = System.Drawing.Color.Transparent;
            this.GroupOperation.Controls.Add(this.btnAdd);
            this.GroupOperation.Controls.Add(this.btnBack);
            this.GroupOperation.Controls.Add(this.btnPrint);
            this.GroupOperation.Controls.Add(this.btnDelete);
            this.GroupOperation.Controls.Add(this.btnUpdate);
            this.GroupOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOperation.Location = new System.Drawing.Point(0, 345);
            this.GroupOperation.Name = "GroupOperation";
            this.GroupOperation.Size = new System.Drawing.Size(782, 100);
            this.GroupOperation.TabIndex = 21;
            this.GroupOperation.TabStop = false;
            this.GroupOperation.Text = "Operation";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GoFitness.Properties.Resources._1427824518_174582;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(189, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 46);
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
            this.btnPrint.Image = global::GoFitness.Properties.Resources._1427824235_591916;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(480, 39);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 46);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GoFitness.Properties.Resources._1427824973_1752944;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(332, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 46);
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
            this.btnUpdate.Image = global::GoFitness.Properties.Resources.update4;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(31, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 46);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // GroupProductList
            // 
            this.GroupProductList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupProductList.BackColor = System.Drawing.Color.Transparent;
            this.GroupProductList.Controls.Add(this.dataGridProductList);
            this.GroupProductList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupProductList.Location = new System.Drawing.Point(425, 12);
            this.GroupProductList.Name = "GroupProductList";
            this.GroupProductList.Size = new System.Drawing.Size(357, 327);
            this.GroupProductList.TabIndex = 20;
            this.GroupProductList.TabStop = false;
            this.GroupProductList.Text = "ProductList";
            // 
            // groupProduct
            // 
            this.groupProduct.BackColor = System.Drawing.Color.Transparent;
            this.groupProduct.Controls.Add(this.txtIsAvailable);
            this.groupProduct.Controls.Add(this.txtQuantity);
            this.groupProduct.Controls.Add(this.txtProductCode);
            this.groupProduct.Controls.Add(this.txtProudctName);
            this.groupProduct.Controls.Add(this.txtProudctPrice);
            this.groupProduct.Controls.Add(this.lblisAvailable);
            this.groupProduct.Controls.Add(this.lblQuantity);
            this.groupProduct.Controls.Add(this.lblProudctCode);
            this.groupProduct.Controls.Add(this.lblProductName);
            this.groupProduct.Controls.Add(this.lblProdctPrice);
            this.groupProduct.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProduct.Location = new System.Drawing.Point(0, 12);
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Size = new System.Drawing.Size(419, 327);
            this.groupProduct.TabIndex = 23;
            this.groupProduct.TabStop = false;
            this.groupProduct.Text = "Product";
            // 
            // txtIsAvailable
            // 
            this.txtIsAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIsAvailable.Location = new System.Drawing.Point(238, 282);
            this.txtIsAvailable.Name = "txtIsAvailable";
            this.txtIsAvailable.Size = new System.Drawing.Size(173, 30);
            this.txtIsAvailable.TabIndex = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(238, 223);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(173, 30);
            this.txtQuantity.TabIndex = 50;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductCode.Location = new System.Drawing.Point(238, 153);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(173, 30);
            this.txtProductCode.TabIndex = 49;
            // 
            // txtProudctName
            // 
            this.txtProudctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProudctName.Location = new System.Drawing.Point(240, 92);
            this.txtProudctName.Name = "txtProudctName";
            this.txtProudctName.Size = new System.Drawing.Size(173, 30);
            this.txtProudctName.TabIndex = 48;
            // 
            // txtProudctPrice
            // 
            this.txtProudctPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProudctPrice.Location = new System.Drawing.Point(238, 34);
            this.txtProudctPrice.Name = "txtProudctPrice";
            this.txtProudctPrice.Size = new System.Drawing.Size(173, 30);
            this.txtProudctPrice.TabIndex = 47;
            // 
            // lblisAvailable
            // 
            this.lblisAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblisAvailable.Image = global::GoFitness.Properties.Resources.sign_available1;
            this.lblisAvailable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblisAvailable.Location = new System.Drawing.Point(30, 278);
            this.lblisAvailable.Name = "lblisAvailable";
            this.lblisAvailable.Size = new System.Drawing.Size(205, 37);
            this.lblisAvailable.TabIndex = 43;
            this.lblisAvailable.Text = "isAvailable:";
            this.lblisAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.Image = global::GoFitness.Properties.Resources.quantity;
            this.lblQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantity.Location = new System.Drawing.Point(30, 219);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(205, 37);
            this.lblQuantity.TabIndex = 42;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProudctCode
            // 
            this.lblProudctCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProudctCode.Image = global::GoFitness.Properties.Resources.barcode1;
            this.lblProudctCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProudctCode.Location = new System.Drawing.Point(27, 149);
            this.lblProudctCode.Name = "lblProudctCode";
            this.lblProudctCode.Size = new System.Drawing.Size(205, 37);
            this.lblProudctCode.TabIndex = 41;
            this.lblProudctCode.Text = "Product Code:";
            this.lblProudctCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.Image = global::GoFitness.Properties.Resources.product;
            this.lblProductName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProductName.Location = new System.Drawing.Point(30, 88);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(205, 37);
            this.lblProductName.TabIndex = 40;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProdctPrice
            // 
            this.lblProdctPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProdctPrice.Image = global::GoFitness.Properties.Resources._1427828776_1757441;
            this.lblProdctPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProdctPrice.Location = new System.Drawing.Point(30, 30);
            this.lblProdctPrice.Name = "lblProdctPrice";
            this.lblProdctPrice.Size = new System.Drawing.Size(205, 37);
            this.lblProdctPrice.TabIndex = 39;
            this.lblProdctPrice.Text = "Prouduct Price:";
            this.lblProdctPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigator";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(480, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(189, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // printShopTable
            // 
            this.printShopTable.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printShopTable_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printShopTable;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ShopAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupnaNavigator);
            this.Controls.Add(this.GroupOperation);
            this.Controls.Add(this.GroupProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go Fitness";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.GroupnaNavigator.ResumeLayout(false);
            this.GroupOperation.ResumeLayout(false);
            this.GroupProductList.ResumeLayout(false);
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridProductList;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox GroupnaNavigator;
        private System.Windows.Forms.GroupBox GroupOperation;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox GroupProductList;
        private System.Windows.Forms.GroupBox groupProduct;
        private System.Windows.Forms.TextBox txtIsAvailable;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProudctName;
        private System.Windows.Forms.TextBox txtProudctPrice;
        private System.Windows.Forms.Label lblisAvailable;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProudctCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProdctPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printShopTable;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}