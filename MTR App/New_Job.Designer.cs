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
            this.txtCreateJobName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSubmitJob = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblCreateJobName
            // 
            this.lblCreateJobName.AutoSize = true;
            this.lblCreateJobName.Location = new System.Drawing.Point(12, 9);
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
            // txtCreateJobName
            // 
            this.txtCreateJobName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCreateJobName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreateJobName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCreateJobName.BorderThickness = 3;
            this.txtCreateJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateJobName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCreateJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreateJobName.isPassword = false;
            this.txtCreateJobName.Location = new System.Drawing.Point(15, 26);
            this.txtCreateJobName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateJobName.Name = "txtCreateJobName";
            this.txtCreateJobName.Size = new System.Drawing.Size(479, 44);
            this.txtCreateJobName.TabIndex = 3;
            this.txtCreateJobName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSubmitJob
            // 
            this.btnSubmitJob.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmitJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitJob.BorderRadius = 0;
            this.btnSubmitJob.ButtonText = "Create";
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
            this.btnSubmitJob.Location = new System.Drawing.Point(401, 77);
            this.btnSubmitJob.Name = "btnSubmitJob";
            this.btnSubmitJob.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitJob.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSubmitJob.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitJob.selected = false;
            this.btnSubmitJob.Size = new System.Drawing.Size(93, 37);
            this.btnSubmitJob.TabIndex = 4;
            this.btnSubmitJob.Text = "Create";
            this.btnSubmitJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitJob.Textcolor = System.Drawing.Color.White;
            this.btnSubmitJob.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitJob.Click += new System.EventHandler(this.btnSubmitJob_Click);
            // 
            // New_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 126);
            this.Controls.Add(this.btnSubmitJob);
            this.Controls.Add(this.txtCreateJobName);
            this.Controls.Add(this.lblCreateJobName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "New_Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create A New Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreateJobName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitJob;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCreateJobName;
    }
}