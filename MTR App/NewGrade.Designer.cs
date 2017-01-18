namespace MTR_App
{
    partial class NewGrade
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
            this.lblCreateJobName = new System.Windows.Forms.Label();
            this.btnCreateGrade = new System.Windows.Forms.Button();
            this.txtCreateGradeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateJobName
            // 
            this.lblCreateJobName.AutoSize = true;
            this.lblCreateJobName.Location = new System.Drawing.Point(13, 19);
            this.lblCreateJobName.Name = "lblCreateJobName";
            this.lblCreateJobName.Size = new System.Drawing.Size(102, 13);
            this.lblCreateJobName.TabIndex = 5;
            this.lblCreateJobName.Text = "Enter A New Grade:";
            // 
            // btnCreateGrade
            // 
            this.btnCreateGrade.Location = new System.Drawing.Point(369, 64);
            this.btnCreateGrade.Name = "btnCreateGrade";
            this.btnCreateGrade.Size = new System.Drawing.Size(127, 23);
            this.btnCreateGrade.TabIndex = 4;
            this.btnCreateGrade.Text = "Create New Standard";
            this.btnCreateGrade.UseVisualStyleBackColor = true;
            this.btnCreateGrade.Click += new System.EventHandler(this.btnSubmitJobName_Click);
            // 
            // txtCreateGradeName
            // 
            this.txtCreateGradeName.Location = new System.Drawing.Point(12, 38);
            this.txtCreateGradeName.Name = "txtCreateGradeName";
            this.txtCreateGradeName.Size = new System.Drawing.Size(484, 20);
            this.txtCreateGradeName.TabIndex = 3;
            // 
            // NewGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateJobName);
            this.Controls.Add(this.btnCreateGrade);
            this.Controls.Add(this.txtCreateGradeName);
            this.Name = "NewGrade";
            this.Text = "NewGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateJobName;
        private System.Windows.Forms.Button btnCreateGrade;
        private System.Windows.Forms.TextBox txtCreateGradeName;
    }
}