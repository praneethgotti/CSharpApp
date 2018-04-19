namespace ProductPOS_Viral
{
    partial class frmMain
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
            this.lstScreen = new System.Windows.Forms.ListBox();
            this.txtRecipt = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblRecipt = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnSerchProducts = new System.Windows.Forms.Button();
            this.btnEnterSale = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnRemoveSelectedProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnGetDescripition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstScreen
            // 
            this.lstScreen.FormattingEnabled = true;
            this.lstScreen.ItemHeight = 20;
            this.lstScreen.Location = new System.Drawing.Point(334, 75);
            this.lstScreen.Name = "lstScreen";
            this.lstScreen.Size = new System.Drawing.Size(471, 544);
            this.lstScreen.TabIndex = 28;
            // 
            // txtRecipt
            // 
            this.txtRecipt.Location = new System.Drawing.Point(822, 70);
            this.txtRecipt.Multiline = true;
            this.txtRecipt.Name = "txtRecipt";
            this.txtRecipt.ReadOnly = true;
            this.txtRecipt.Size = new System.Drawing.Size(426, 543);
            this.txtRecipt.TabIndex = 27;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(55, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 26;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(55, 78);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 26);
            this.txtProductID.TabIndex = 25;
            // 
            // lblRecipt
            // 
            this.lblRecipt.AutoSize = true;
            this.lblRecipt.Location = new System.Drawing.Point(1171, 32);
            this.lblRecipt.Name = "lblRecipt";
            this.lblRecipt.Size = new System.Drawing.Size(55, 20);
            this.lblRecipt.TabIndex = 24;
            this.lblRecipt.Text = "Recipt";
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Location = new System.Drawing.Point(371, 32);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(60, 20);
            this.lblScreen.TabIndex = 23;
            this.lblScreen.Text = "Screen";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(61, 117);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(61, 55);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(81, 20);
            this.lblProductID.TabIndex = 21;
            this.lblProductID.Text = "ProductID";
            // 
            // btnSerchProducts
            // 
            this.btnSerchProducts.Location = new System.Drawing.Point(46, 363);
            this.btnSerchProducts.Name = "btnSerchProducts";
            this.btnSerchProducts.Size = new System.Drawing.Size(282, 45);
            this.btnSerchProducts.TabIndex = 20;
            this.btnSerchProducts.Text = "Search Products";
            this.btnSerchProducts.UseVisualStyleBackColor = true;
            this.btnSerchProducts.Click += new System.EventHandler(this.btnSerchProducts_Click);
            // 
            // btnEnterSale
            // 
            this.btnEnterSale.Location = new System.Drawing.Point(187, 251);
            this.btnEnterSale.Name = "btnEnterSale";
            this.btnEnterSale.Size = new System.Drawing.Size(141, 57);
            this.btnEnterSale.TabIndex = 19;
            this.btnEnterSale.Text = "Enter Sale";
            this.btnEnterSale.UseVisualStyleBackColor = true;
            this.btnEnterSale.Click += new System.EventHandler(this.btnEnterSale_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(46, 251);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(131, 57);
            this.btnCancelSale.TabIndex = 18;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnRemoveSelectedProduct
            // 
            this.btnRemoveSelectedProduct.Location = new System.Drawing.Point(55, 195);
            this.btnRemoveSelectedProduct.Name = "btnRemoveSelectedProduct";
            this.btnRemoveSelectedProduct.Size = new System.Drawing.Size(251, 35);
            this.btnRemoveSelectedProduct.TabIndex = 17;
            this.btnRemoveSelectedProduct.Text = "Remove Selected Products";
            this.btnRemoveSelectedProduct.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedProduct.Click += new System.EventHandler(this.btnRemoveSelectedProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(175, 135);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(131, 37);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // btnGetDescripition
            // 
            this.btnGetDescripition.Location = new System.Drawing.Point(175, 70);
            this.btnGetDescripition.Name = "btnGetDescripition";
            this.btnGetDescripition.Size = new System.Drawing.Size(131, 34);
            this.btnGetDescripition.TabIndex = 15;
            this.btnGetDescripition.Text = "Get Descripition";
            this.btnGetDescripition.UseVisualStyleBackColor = true;
            this.btnGetDescripition.Click += new System.EventHandler(this.btnGetDescripition_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 651);
            this.Controls.Add(this.lstScreen);
            this.Controls.Add(this.txtRecipt);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblRecipt);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnSerchProducts);
            this.Controls.Add(this.btnEnterSale);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.btnRemoveSelectedProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnGetDescripition);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstScreen;
        private System.Windows.Forms.TextBox txtRecipt;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblRecipt;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnSerchProducts;
        private System.Windows.Forms.Button btnEnterSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnRemoveSelectedProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnGetDescripition;
    }
}

