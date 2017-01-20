namespace MTR_App
{
    partial class ImportExcel
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
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.txtFirstSell = new System.Windows.Forms.TextBox();
            this.txtLastCell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolderDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCellExample = new System.Windows.Forms.Label();
            this.lblExampleLastCell = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(125, 24);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(141, 20);
            this.txtJobName.TabIndex = 0;
            // 
            // txtFirstSell
            // 
            this.txtFirstSell.Location = new System.Drawing.Point(125, 52);
            this.txtFirstSell.Name = "txtFirstSell";
            this.txtFirstSell.Size = new System.Drawing.Size(40, 20);
            this.txtFirstSell.TabIndex = 1;
            // 
            // txtLastCell
            // 
            this.txtLastCell.Location = new System.Drawing.Point(125, 78);
            this.txtLastCell.Name = "txtLastCell";
            this.txtLastCell.Size = new System.Drawing.Size(40, 20);
            this.txtLastCell.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1st Item Number Cell:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Note Cell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Name:";
            // 
            // txtFolderDir
            // 
            this.txtFolderDir.Location = new System.Drawing.Point(12, 122);
            this.txtFolderDir.Name = "txtFolderDir";
            this.txtFolderDir.Size = new System.Drawing.Size(220, 20);
            this.txtFolderDir.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCellExample
            // 
            this.lblCellExample.AutoSize = true;
            this.lblCellExample.Location = new System.Drawing.Point(171, 55);
            this.lblCellExample.Name = "lblCellExample";
            this.lblCellExample.Size = new System.Drawing.Size(49, 13);
            this.lblCellExample.TabIndex = 8;
            this.lblCellExample.Text = "(ex: B14)";
            // 
            // lblExampleLastCell
            // 
            this.lblExampleLastCell.AutoSize = true;
            this.lblExampleLastCell.Location = new System.Drawing.Point(171, 81);
            this.lblExampleLastCell.Name = "lblExampleLastCell";
            this.lblExampleLastCell.Size = new System.Drawing.Size(55, 13);
            this.lblExampleLastCell.TabIndex = 9;
            this.lblExampleLastCell.Text = "(ex: P208)";
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 157);
            this.Controls.Add(this.lblExampleLastCell);
            this.Controls.Add(this.lblCellExample);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFolderDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastCell);
            this.Controls.Add(this.txtFirstSell);
            this.Controls.Add(this.txtJobName);
            this.Name = "ImportExcel";
            this.Text = "ImportExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.TextBox txtFirstSell;
        private System.Windows.Forms.TextBox txtLastCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolderDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCellExample;
        private System.Windows.Forms.Label lblExampleLastCell;
    }
}