namespace ProductPOS_Viral
{
    partial class frmSearch
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCopyIDtoPOS = new System.Windows.Forms.Button();
            this.txtCopyIDtoPOS = new System.Windows.Forms.TextBox();
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(562, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnCopyIDtoPOS
            // 
            this.btnCopyIDtoPOS.Location = new System.Drawing.Point(92, 466);
            this.btnCopyIDtoPOS.Name = "btnCopyIDtoPOS";
            this.btnCopyIDtoPOS.Size = new System.Drawing.Size(276, 35);
            this.btnCopyIDtoPOS.TabIndex = 6;
            this.btnCopyIDtoPOS.Text = "Copy ID to POS";
            this.btnCopyIDtoPOS.UseVisualStyleBackColor = true;
            this.btnCopyIDtoPOS.Click += new System.EventHandler(this.btnCopyIDtoPOS_Click);
            // 
            // txtCopyIDtoPOS
            // 
            this.txtCopyIDtoPOS.Location = new System.Drawing.Point(394, 466);
            this.txtCopyIDtoPOS.Multiline = true;
            this.txtCopyIDtoPOS.Name = "txtCopyIDtoPOS";
            this.txtCopyIDtoPOS.Size = new System.Drawing.Size(252, 36);
            this.txtCopyIDtoPOS.TabIndex = 5;
            // 
            // lstSearch
            // 
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 20;
            this.lstSearch.Location = new System.Drawing.Point(12, 21);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(733, 424);
            this.lstSearch.TabIndex = 8;
            this.lstSearch.SelectedIndexChanged += new System.EventHandler(this.lstSearch_SelectedIndexChanged);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 571);
            this.Controls.Add(this.lstSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopyIDtoPOS);
            this.Controls.Add(this.txtCopyIDtoPOS);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCopyIDtoPOS;
        private System.Windows.Forms.TextBox txtCopyIDtoPOS;
        private System.Windows.Forms.ListBox lstSearch;
    }
}