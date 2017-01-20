namespace MTR_App
{
    partial class NewWeldSeamType
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
            this.lblCreateWeldSeamType = new System.Windows.Forms.Label();
            this.btnSubmitWeldSeamType = new System.Windows.Forms.Button();
            this.txtCreateWeldSeamType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateWeldSeamType
            // 
            this.lblCreateWeldSeamType.AutoSize = true;
            this.lblCreateWeldSeamType.Location = new System.Drawing.Point(13, 19);
            this.lblCreateWeldSeamType.Name = "lblCreateWeldSeamType";
            this.lblCreateWeldSeamType.Size = new System.Drawing.Size(155, 13);
            this.lblCreateWeldSeamType.TabIndex = 11;
            this.lblCreateWeldSeamType.Text = "Enter A New Weld Seam Type:";
            // 
            // btnSubmitWeldSeamType
            // 
            this.btnSubmitWeldSeamType.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitWeldSeamType.Name = "btnSubmitWeldSeamType";
            this.btnSubmitWeldSeamType.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitWeldSeamType.TabIndex = 10;
            this.btnSubmitWeldSeamType.Text = "Add New Weld Seam Type";
            this.btnSubmitWeldSeamType.UseVisualStyleBackColor = true;
            this.btnSubmitWeldSeamType.Click += new System.EventHandler(this.btnSubmitWeldSeamType_Click);
            // 
            // txtCreateWeldSeamType
            // 
            this.txtCreateWeldSeamType.Location = new System.Drawing.Point(12, 38);
            this.txtCreateWeldSeamType.Name = "txtCreateWeldSeamType";
            this.txtCreateWeldSeamType.Size = new System.Drawing.Size(484, 20);
            this.txtCreateWeldSeamType.TabIndex = 9;
            this.txtCreateWeldSeamType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateWeldSeamType_KeyDown);
            // 
            // NewWeldSeamType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateWeldSeamType);
            this.Controls.Add(this.btnSubmitWeldSeamType);
            this.Controls.Add(this.txtCreateWeldSeamType);
            this.Name = "NewWeldSeamType";
            this.Text = "NewWeldSeamType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateWeldSeamType;
        private System.Windows.Forms.Button btnSubmitWeldSeamType;
        private System.Windows.Forms.TextBox txtCreateWeldSeamType;
    }
}