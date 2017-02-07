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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Job));
            this.lblCreateJobName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSubmitJob = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtCreateJobName = new System.Windows.Forms.TextBox();
            this.txtChangeXML = new System.Windows.Forms.TextBox();
            this.btnChangeXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateJobName
            // 
            this.lblCreateJobName.AutoSize = true;
            this.lblCreateJobName.Location = new System.Drawing.Point(12, 89);
            this.lblCreateJobName.Name = "lblCreateJobName";
            this.lblCreateJobName.Size = new System.Drawing.Size(121, 13);
            this.lblCreateJobName.TabIndex = 2;
            this.lblCreateJobName.Text = "Enter A New Job Name:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSubmitJob
            // 
            this.btnSubmitJob.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmitJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitJob.BorderRadius = 0;
            this.btnSubmitJob.ButtonText = "Create Job";
            this.btnSubmitJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitJob.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmitJob.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmitJob.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmitJob.Iconimage")));
            this.btnSubmitJob.Iconimage_right = null;
            this.btnSubmitJob.Iconimage_right_Selected = null;
            this.btnSubmitJob.Iconimage_Selected = null;
            this.btnSubmitJob.IconMarginLeft = 0;
            this.btnSubmitJob.IconMarginRight = 0;
            this.btnSubmitJob.IconRightVisible = true;
            this.btnSubmitJob.IconRightZoom = 0D;
            this.btnSubmitJob.IconVisible = true;
            this.btnSubmitJob.IconZoom = 90D;
            this.btnSubmitJob.IsTab = false;
            this.btnSubmitJob.Location = new System.Drawing.Point(385, 145);
            this.btnSubmitJob.Name = "btnSubmitJob";
            this.btnSubmitJob.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitJob.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSubmitJob.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitJob.selected = false;
            this.btnSubmitJob.Size = new System.Drawing.Size(131, 37);
            this.btnSubmitJob.TabIndex = 4;
            this.btnSubmitJob.Text = "Create Job";
            this.btnSubmitJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitJob.Textcolor = System.Drawing.Color.White;
            this.btnSubmitJob.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitJob.Click += new System.EventHandler(this.btnSubmitJob_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(545, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 536;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtCreateJobName
            // 
            this.txtCreateJobName.Location = new System.Drawing.Point(16, 106);
            this.txtCreateJobName.Name = "txtCreateJobName";
            this.txtCreateJobName.Size = new System.Drawing.Size(500, 20);
            this.txtCreateJobName.TabIndex = 537;
            // 
            // txtChangeXML
            // 
            this.txtChangeXML.Location = new System.Drawing.Point(12, 12);
            this.txtChangeXML.Name = "txtChangeXML";
            this.txtChangeXML.Size = new System.Drawing.Size(24, 20);
            this.txtChangeXML.TabIndex = 538;
            // 
            // btnChangeXML
            // 
            this.btnChangeXML.Location = new System.Drawing.Point(42, 9);
            this.btnChangeXML.Name = "btnChangeXML";
            this.btnChangeXML.Size = new System.Drawing.Size(91, 23);
            this.btnChangeXML.TabIndex = 539;
            this.btnChangeXML.Text = "Change XML";
            this.btnChangeXML.UseVisualStyleBackColor = true;
            this.btnChangeXML.Click += new System.EventHandler(this.btnChangeXML_Click);
            // 
            // New_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 194);
            this.Controls.Add(this.btnChangeXML);
            this.Controls.Add(this.txtChangeXML);
            this.Controls.Add(this.txtCreateJobName);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnSubmitJob);
            this.Controls.Add(this.lblCreateJobName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create A New Job";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreateJobName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitJob;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox txtCreateJobName;
        private System.Windows.Forms.Button btnChangeXML;
        private System.Windows.Forms.TextBox txtChangeXML;
    }
}