﻿namespace MTR_App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGrade));
            this.lblCreateJobName = new System.Windows.Forms.Label();
            this.btnCreateGrade = new System.Windows.Forms.Button();
            this.txtCreateGradeName = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.btnCreateGrade.Location = new System.Drawing.Point(504, 4);
            this.btnCreateGrade.Name = "btnCreateGrade";
            this.btnCreateGrade.Size = new System.Drawing.Size(1, 1);
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
            this.txtCreateGradeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreateGradeName_KeyDown);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Create New Standard";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(309, 65);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(186, 30);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Create New Standard";
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
            // NewGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lblCreateJobName);
            this.Controls.Add(this.btnCreateGrade);
            this.Controls.Add(this.txtCreateGradeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGrade";
            this.Text = "NewGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateJobName;
        private System.Windows.Forms.Button btnCreateGrade;
        private System.Windows.Forms.TextBox txtCreateGradeName;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}