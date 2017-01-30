namespace MTR_App
{
    partial class NewProductDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductDescription));
            this.lblCreateProductDescription = new System.Windows.Forms.Label();
            this.btnSubmitProductDescription = new System.Windows.Forms.Button();
            this.txtCreateProductDescription = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblCreateProductDescription
            // 
            this.lblCreateProductDescription.AutoSize = true;
            this.lblCreateProductDescription.Location = new System.Drawing.Point(13, 19);
            this.lblCreateProductDescription.Name = "lblCreateProductDescription";
            this.lblCreateProductDescription.Size = new System.Drawing.Size(166, 13);
            this.lblCreateProductDescription.TabIndex = 11;
            this.lblCreateProductDescription.Text = "Enter A New Product Description:";
            // 
            // btnSubmitProductDescription
            // 
            this.btnSubmitProductDescription.Location = new System.Drawing.Point(505, 1);
            this.btnSubmitProductDescription.Name = "btnSubmitProductDescription";
            this.btnSubmitProductDescription.Size = new System.Drawing.Size(1, 1);
            this.btnSubmitProductDescription.TabIndex = 10;
            this.btnSubmitProductDescription.Text = "Add New Product Description";
            this.btnSubmitProductDescription.UseVisualStyleBackColor = true;
            this.btnSubmitProductDescription.Click += new System.EventHandler(this.btnSubmitProductDescription_Click);
            // 
            // txtCreateProductDescription
            // 
            this.txtCreateProductDescription.Location = new System.Drawing.Point(12, 38);
            this.txtCreateProductDescription.Name = "txtCreateProductDescription";
            this.txtCreateProductDescription.Size = new System.Drawing.Size(484, 20);
            this.txtCreateProductDescription.TabIndex = 9;
            this.txtCreateProductDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateProductDescription_KeyDown);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add Product Description";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(291, 65);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(204, 30);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Add Product Description";
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
            // NewProductDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lblCreateProductDescription);
            this.Controls.Add(this.btnSubmitProductDescription);
            this.Controls.Add(this.txtCreateProductDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewProductDescription";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Product Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateProductDescription;
        private System.Windows.Forms.Button btnSubmitProductDescription;
        private System.Windows.Forms.TextBox txtCreateProductDescription;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}