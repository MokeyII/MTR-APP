namespace MTR_App
{
    partial class NewManufacturer
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
            this.lblCreateManufacturer = new System.Windows.Forms.Label();
            this.btnSubmitJobName = new System.Windows.Forms.Button();
            this.txtCreateManufacturer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateManufacturer
            // 
            this.lblCreateManufacturer.AutoSize = true;
            this.lblCreateManufacturer.Location = new System.Drawing.Point(13, 19);
            this.lblCreateManufacturer.Name = "lblCreateManufacturer";
            this.lblCreateManufacturer.Size = new System.Drawing.Size(136, 13);
            this.lblCreateManufacturer.TabIndex = 5;
            this.lblCreateManufacturer.Text = "Enter A New Manufacturer:";
            // 
            // btnSubmitJobName
            // 
            this.btnSubmitJobName.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitJobName.Name = "btnSubmitJobName";
            this.btnSubmitJobName.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitJobName.TabIndex = 4;
            this.btnSubmitJobName.Text = "Add New Manufacturer";
            this.btnSubmitJobName.UseVisualStyleBackColor = true;
            this.btnSubmitJobName.Click += new System.EventHandler(this.btnSubmitJobName_Click);
            // 
            // txtCreateManufacturer
            // 
            this.txtCreateManufacturer.Location = new System.Drawing.Point(12, 38);
            this.txtCreateManufacturer.Name = "txtCreateManufacturer";
            this.txtCreateManufacturer.Size = new System.Drawing.Size(484, 20);
            this.txtCreateManufacturer.TabIndex = 3;
            // 
            // NewManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateManufacturer);
            this.Controls.Add(this.btnSubmitJobName);
            this.Controls.Add(this.txtCreateManufacturer);
            this.Name = "NewManufacturer";
            this.Text = "Add New Manufacturer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewManufacturer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateManufacturer;
        private System.Windows.Forms.Button btnSubmitJobName;
        private System.Windows.Forms.TextBox txtCreateManufacturer;
    }
}