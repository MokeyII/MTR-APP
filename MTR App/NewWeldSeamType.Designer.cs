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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWeldSeamType));
            this.lblCreateWeldSeamType = new System.Windows.Forms.Label();
            this.btnSubmitWeldSeamType = new System.Windows.Forms.Button();
            this.txtCreateWeldSeamType = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.btnSubmitWeldSeamType.Location = new System.Drawing.Point(506, 3);
            this.btnSubmitWeldSeamType.Name = "btnSubmitWeldSeamType";
            this.btnSubmitWeldSeamType.Size = new System.Drawing.Size(1, 1);
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
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add New Weld Seam Type";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(278, 65);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(217, 30);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Add New Weld Seam Type";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NewWeldSeamType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lblCreateWeldSeamType);
            this.Controls.Add(this.btnSubmitWeldSeamType);
            this.Controls.Add(this.txtCreateWeldSeamType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewWeldSeamType";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewWeldSeamType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateWeldSeamType;
        private System.Windows.Forms.Button btnSubmitWeldSeamType;
        private System.Windows.Forms.TextBox txtCreateWeldSeamType;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}