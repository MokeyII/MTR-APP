namespace MTR_App
{
    partial class NewStandard
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
            this.btnSubmitStandard = new System.Windows.Forms.Button();
            this.txtCreateStandard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateCoating
            // 
            this.lblCreateCoating.AutoSize = true;
            this.lblCreateCoating.Location = new System.Drawing.Point(13, 19);
            this.lblCreateCoating.Name = "lblCreateCoating";
            this.lblCreateCoating.Size = new System.Drawing.Size(116, 13);
            this.lblCreateCoating.TabIndex = 23;
            this.lblCreateCoating.Text = "Enter A New Standard:";
            // 
            // btnSubmitStandard
            // 
            this.btnSubmitStandard.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitStandard.Name = "btnSubmitStandard";
            this.btnSubmitStandard.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitStandard.TabIndex = 22;
            this.btnSubmitStandard.Text = "Add New Standard";
            this.btnSubmitStandard.UseVisualStyleBackColor = true;
            this.btnSubmitStandard.Click += new System.EventHandler(this.btnSubmitStandard_Click);
            // 
            // txtCreateStandard
            // 
            this.txtCreateStandard.Location = new System.Drawing.Point(12, 38);
            this.txtCreateStandard.Name = "txtCreateStandard";
            this.txtCreateStandard.Size = new System.Drawing.Size(484, 20);
            this.txtCreateStandard.TabIndex = 21;
            // 
            // NewStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateCoating);
            this.Controls.Add(this.btnSubmitStandard);
            this.Controls.Add(this.txtCreateStandard);
            this.Name = "NewStandard";
            this.Text = "Add New Standard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewStandard_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCoating;
        private System.Windows.Forms.Button btnSubmitStandard;
        private System.Windows.Forms.TextBox txtCreateStandard;
    }
}