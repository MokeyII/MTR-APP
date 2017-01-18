namespace MTR_App
{
    partial class NewProductDescription
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
            this.lblCreateProductDescription = new System.Windows.Forms.Label();
            this.btnSubmitProductDescription = new System.Windows.Forms.Button();
            this.txtCreateProductDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateProductDescription
            // 
            this.lblCreateProductDescription.AutoSize = true;
            this.lblCreateProductDescription.Location = new System.Drawing.Point(13, 19);
            this.lblCreateProductDescription.Name = "lblCreateProductDescription";
            this.lblCreateProductDescription.Size = new System.Drawing.Size(166, 13);
            this.lblCreateProductDescription.TabIndex = 11;
            this.lblCreateProductDescription.Text = "Enter A New Product Description:";
            // 
            // btnSubmitProductDescription
            // 
            this.btnSubmitProductDescription.Location = new System.Drawing.Point(325, 64);
            this.btnSubmitProductDescription.Name = "btnSubmitProductDescription";
            this.btnSubmitProductDescription.Size = new System.Drawing.Size(171, 23);
            this.btnSubmitProductDescription.TabIndex = 10;
            this.btnSubmitProductDescription.Text = "Add New Product Description";
            this.btnSubmitProductDescription.UseVisualStyleBackColor = true;
            this.btnSubmitProductDescription.Click += new System.EventHandler(this.btnSubmitProductDescription_Click);
            // 
            // txtCreateProductDescription
            // 
            this.txtCreateProductDescription.Location = new System.Drawing.Point(12, 38);
            this.txtCreateProductDescription.Name = "txtCreateProductDescription";
            this.txtCreateProductDescription.Size = new System.Drawing.Size(484, 20);
            this.txtCreateProductDescription.TabIndex = 9;
            // 
            // NewProductDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateProductDescription);
            this.Controls.Add(this.btnSubmitProductDescription);
            this.Controls.Add(this.txtCreateProductDescription);
            this.Name = "NewProductDescription";
            this.Text = "NewProductDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateProductDescription;
        private System.Windows.Forms.Button btnSubmitProductDescription;
        private System.Windows.Forms.TextBox txtCreateProductDescription;
    }
}