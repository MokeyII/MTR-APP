namespace MTR_App
{
    partial class New_Job
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
            this.txtCreateJobName = new System.Windows.Forms.TextBox();
            this.btnSubmitJobName = new System.Windows.Forms.Button();
            this.lblCreateJobName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCreateJobName
            // 
            this.txtCreateJobName.Location = new System.Drawing.Point(11, 42);
            this.txtCreateJobName.Name = "txtCreateJobName";
            this.txtCreateJobName.Size = new System.Drawing.Size(484, 20);
            this.txtCreateJobName.TabIndex = 0;
            this.txtCreateJobName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateJobName_KeyDown);
            // 
            // btnSubmitJobName
            // 
            this.btnSubmitJobName.Location = new System.Drawing.Point(420, 68);
            this.btnSubmitJobName.Name = "btnSubmitJobName";
            this.btnSubmitJobName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitJobName.TabIndex = 1;
            this.btnSubmitJobName.Text = "Create";
            this.btnSubmitJobName.UseVisualStyleBackColor = true;
            this.btnSubmitJobName.Click += new System.EventHandler(this.btnSubmitJobName_Click);
            // 
            // lblCreateJobName
            // 
            this.lblCreateJobName.AutoSize = true;
            this.lblCreateJobName.Location = new System.Drawing.Point(12, 23);
            this.lblCreateJobName.Name = "lblCreateJobName";
            this.lblCreateJobName.Size = new System.Drawing.Size(121, 13);
            this.lblCreateJobName.TabIndex = 2;
            this.lblCreateJobName.Text = "Enter A New Job Name:";
            // 
            // New_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateJobName);
            this.Controls.Add(this.btnSubmitJobName);
            this.Controls.Add(this.txtCreateJobName);
            this.Name = "New_Job";
            this.Text = "New_Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreateJobName;
        private System.Windows.Forms.Button btnSubmitJobName;
        private System.Windows.Forms.Label lblCreateJobName;
    }
}