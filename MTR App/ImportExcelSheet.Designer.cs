namespace MTR_App
{
    partial class ImportExcelSheet
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
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnFolderBrowserDiag = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtSheet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(390, 77);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "Import";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnFolderBrowserDiag
            // 
            this.btnFolderBrowserDiag.Location = new System.Drawing.Point(390, 48);
            this.btnFolderBrowserDiag.Name = "btnFolderBrowserDiag";
            this.btnFolderBrowserDiag.Size = new System.Drawing.Size(75, 23);
            this.btnFolderBrowserDiag.TabIndex = 2;
            this.btnFolderBrowserDiag.Text = "Browse";
            this.btnFolderBrowserDiag.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDiag.Click += new System.EventHandler(this.btnFolderBrowserDiag_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 52);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(372, 20);
            this.txtFilePath.TabIndex = 7;
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(12, 78);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(372, 20);
            this.txtSheet.TabIndex = 8;
            // 
            // ImportExcelSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 608);
            this.Controls.Add(this.txtSheet);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFolderBrowserDiag);
            this.Controls.Add(this.btnImportExcel);
            this.Name = "ImportExcelSheet";
            this.Text = "ImportExcelSheet";
            this.Load += new System.EventHandler(this.ImportExcelSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnFolderBrowserDiag;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtSheet;
    }
}