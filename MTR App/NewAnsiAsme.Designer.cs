namespace MTR_App
{
    partial class NewAnsiAsme
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
            this.btnSubmitAnsiAsme = new System.Windows.Forms.Button();
            this.txtCreateAnsiAsme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateCoating
            // 
            this.lblCreateCoating.AutoSize = true;
            this.lblCreateCoating.Location = new System.Drawing.Point(13, 19);
            this.lblCreateCoating.Name = "lblCreateCoating";
            this.lblCreateCoating.Size = new System.Drawing.Size(139, 13);
            this.lblCreateCoating.TabIndex = 20;
            this.lblCreateCoating.Text = "Enter A New ANSI / ASME:";
            // 
            // btnSubmitAnsiAsme
            // 
            this.btnSubmitAnsiAsme.Location = new System.Drawing.Point(344, 64);
            this.btnSubmitAnsiAsme.Name = "btnSubmitAnsiAsme";
            this.btnSubmitAnsiAsme.Size = new System.Drawing.Size(152, 23);
            this.btnSubmitAnsiAsme.TabIndex = 19;
            this.btnSubmitAnsiAsme.Text = "Add New ANSI / ASME";
            this.btnSubmitAnsiAsme.UseVisualStyleBackColor = true;
            this.btnSubmitAnsiAsme.Click += new System.EventHandler(this.btnSubmitAnsiAsme_Click);
            // 
            // txtCreateAnsiAsme
            // 
            this.txtCreateAnsiAsme.Location = new System.Drawing.Point(12, 38);
            this.txtCreateAnsiAsme.Name = "txtCreateAnsiAsme";
            this.txtCreateAnsiAsme.Size = new System.Drawing.Size(484, 20);
            this.txtCreateAnsiAsme.TabIndex = 18;
            this.txtCreateAnsiAsme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateAnsiAsme_KeyDown);
            // 
            // NewAnsiAsme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.lblCreateCoating);
            this.Controls.Add(this.btnSubmitAnsiAsme);
            this.Controls.Add(this.txtCreateAnsiAsme);
            this.Name = "NewAnsiAsme";
            this.Text = "Add New ANSI / ASME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCoating;
        private System.Windows.Forms.Button btnSubmitAnsiAsme;
        private System.Windows.Forms.TextBox txtCreateAnsiAsme;
    }
}