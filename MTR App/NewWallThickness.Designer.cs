namespace MTR_App
{
    partial class NewWallThickness
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
            this.btnSubmitWallThickness = new System.Windows.Forms.Button();
            this.txtCreateWallThickness = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateWeldSeamType
            // 
            this.lblCreateWeldSeamType.AutoSize = true;
            this.lblCreateWeldSeamType.Location = new System.Drawing.Point(13, 19);
            this.lblCreateWeldSeamType.Name = "lblCreateWeldSeamType";
            this.lblCreateWeldSeamType.Size = new System.Drawing.Size(146, 13);
            this.lblCreateWeldSeamType.TabIndex = 14;
            this.lblCreateWeldSeamType.Text = "Enter A New Wall Thickness:";
            // 
            // btnSubmitWallThickness
            // 
            this.btnSubmitWallThickness.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitWallThickness.Name = "btnSubmitWallThickness";
            this.btnSubmitWallThickness.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitWallThickness.TabIndex = 13;
            this.btnSubmitWallThickness.Text = "Add New Wall Thickness";
            this.btnSubmitWallThickness.UseVisualStyleBackColor = true;
            this.btnSubmitWallThickness.Click += new System.EventHandler(this.btnSubmitWallThickness_Click);
            // 
            // txtCreateWallThickness
            // 
            this.txtCreateWallThickness.Location = new System.Drawing.Point(12, 38);
            this.txtCreateWallThickness.Name = "txtCreateWallThickness";
            this.txtCreateWallThickness.Size = new System.Drawing.Size(484, 20);
            this.txtCreateWallThickness.TabIndex = 12;
            // 
            // NewWallThickness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateWeldSeamType);
            this.Controls.Add(this.btnSubmitWallThickness);
            this.Controls.Add(this.txtCreateWallThickness);
            this.Name = "NewWallThickness";
            this.Text = "NewWallThickness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateWeldSeamType;
        private System.Windows.Forms.Button btnSubmitWallThickness;
        private System.Windows.Forms.TextBox txtCreateWallThickness;
    }
}