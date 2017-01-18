namespace MTR_App
{
    partial class NewCoating
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
            this.lblCreateCoating = new System.Windows.Forms.Label();
            this.btnSubmitCoating = new System.Windows.Forms.Button();
            this.txtCreateCoating = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateCoating
            // 
            this.lblCreateCoating.AutoSize = true;
            this.lblCreateCoating.Location = new System.Drawing.Point(13, 19);
            this.lblCreateCoating.Name = "lblCreateCoating";
            this.lblCreateCoating.Size = new System.Drawing.Size(109, 13);
            this.lblCreateCoating.TabIndex = 17;
            this.lblCreateCoating.Text = "Enter A New Coating:";
            // 
            // btnSubmitCoating
            // 
            this.btnSubmitCoating.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitCoating.Name = "btnSubmitCoating";
            this.btnSubmitCoating.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitCoating.TabIndex = 16;
            this.btnSubmitCoating.Text = "Add New Coating";
            this.btnSubmitCoating.UseVisualStyleBackColor = true;
            this.btnSubmitCoating.Click += new System.EventHandler(this.btnSubmitCoating_Click);
            // 
            // txtCreateCoating
            // 
            this.txtCreateCoating.Location = new System.Drawing.Point(12, 38);
            this.txtCreateCoating.Name = "txtCreateCoating";
            this.txtCreateCoating.Size = new System.Drawing.Size(484, 20);
            this.txtCreateCoating.TabIndex = 15;
            // 
            // NewCoating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateCoating);
            this.Controls.Add(this.btnSubmitCoating);
            this.Controls.Add(this.txtCreateCoating);
            this.Name = "NewCoating";
            this.Text = "Add New Coating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCoating;
        private System.Windows.Forms.Button btnSubmitCoating;
        private System.Windows.Forms.TextBox txtCreateCoating;
    }
}