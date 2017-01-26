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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBrowseFileDir = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtBoxDoThings = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgImportExcelGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBrowseFileDir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImportToExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImportToSQL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.dgImportExcelGridNorm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcelGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcelGridNorm)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBrowseFileDir
            // 
            this.txtBrowseFileDir.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtBrowseFileDir.Location = new System.Drawing.Point(78, 38);
            this.txtBrowseFileDir.Name = "txtBrowseFileDir";
            this.txtBrowseFileDir.Size = new System.Drawing.Size(428, 20);
            this.txtBrowseFileDir.TabIndex = 0;
            // 
            // txtBoxDoThings
            // 
            this.txtBoxDoThings.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtBoxDoThings.Location = new System.Drawing.Point(78, 79);
            this.txtBoxDoThings.Name = "txtBoxDoThings";
            this.txtBoxDoThings.Size = new System.Drawing.Size(428, 20);
            this.txtBoxDoThings.TabIndex = 1;
            this.txtBoxDoThings.Text = "BOM-CMTR";
            // 
            // dgImportExcelGrid
            // 
            this.dgImportExcelGrid.AllowUserToAddRows = false;
            this.dgImportExcelGrid.AllowUserToDeleteRows = false;
            this.dgImportExcelGrid.AllowUserToResizeColumns = false;
            this.dgImportExcelGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgImportExcelGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgImportExcelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgImportExcelGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgImportExcelGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgImportExcelGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgImportExcelGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgImportExcelGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgImportExcelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImportExcelGrid.DoubleBuffered = true;
            this.dgImportExcelGrid.EnableHeadersVisualStyles = false;
            this.dgImportExcelGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgImportExcelGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgImportExcelGrid.Location = new System.Drawing.Point(1004, 120);
            this.dgImportExcelGrid.Name = "dgImportExcelGrid";
            this.dgImportExcelGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgImportExcelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgImportExcelGrid.Size = new System.Drawing.Size(347, 448);
            this.dgImportExcelGrid.TabIndex = 2;
            // 
            // btnBrowseFileDir
            // 
            this.btnBrowseFileDir.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseFileDir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseFileDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseFileDir.BorderRadius = 0;
            this.btnBrowseFileDir.ButtonText = "Browse";
            this.btnBrowseFileDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFileDir.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseFileDir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseFileDir.Iconimage = null;
            this.btnBrowseFileDir.Iconimage_right = null;
            this.btnBrowseFileDir.Iconimage_right_Selected = null;
            this.btnBrowseFileDir.Iconimage_Selected = null;
            this.btnBrowseFileDir.IconMarginLeft = 0;
            this.btnBrowseFileDir.IconMarginRight = 0;
            this.btnBrowseFileDir.IconRightVisible = true;
            this.btnBrowseFileDir.IconRightZoom = 0D;
            this.btnBrowseFileDir.IconVisible = true;
            this.btnBrowseFileDir.IconZoom = 90D;
            this.btnBrowseFileDir.IsTab = false;
            this.btnBrowseFileDir.Location = new System.Drawing.Point(512, 26);
            this.btnBrowseFileDir.Name = "btnBrowseFileDir";
            this.btnBrowseFileDir.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseFileDir.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnBrowseFileDir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseFileDir.selected = false;
            this.btnBrowseFileDir.Size = new System.Drawing.Size(131, 31);
            this.btnBrowseFileDir.TabIndex = 3;
            this.btnBrowseFileDir.Text = "Browse";
            this.btnBrowseFileDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseFileDir.Textcolor = System.Drawing.Color.White;
            this.btnBrowseFileDir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFileDir.Click += new System.EventHandler(this.btnBrowseFileDir_Click);
            // 
            // btnImportToExcel
            // 
            this.btnImportToExcel.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnImportToExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportToExcel.BorderRadius = 0;
            this.btnImportToExcel.ButtonText = "View";
            this.btnImportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportToExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnImportToExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImportToExcel.Iconimage = null;
            this.btnImportToExcel.Iconimage_right = null;
            this.btnImportToExcel.Iconimage_right_Selected = null;
            this.btnImportToExcel.Iconimage_Selected = null;
            this.btnImportToExcel.IconMarginLeft = 0;
            this.btnImportToExcel.IconMarginRight = 0;
            this.btnImportToExcel.IconRightVisible = true;
            this.btnImportToExcel.IconRightZoom = 0D;
            this.btnImportToExcel.IconVisible = true;
            this.btnImportToExcel.IconZoom = 90D;
            this.btnImportToExcel.IsTab = false;
            this.btnImportToExcel.Location = new System.Drawing.Point(512, 68);
            this.btnImportToExcel.Name = "btnImportToExcel";
            this.btnImportToExcel.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnImportToExcel.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnImportToExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImportToExcel.selected = false;
            this.btnImportToExcel.Size = new System.Drawing.Size(131, 31);
            this.btnImportToExcel.TabIndex = 4;
            this.btnImportToExcel.Text = "View";
            this.btnImportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportToExcel.Textcolor = System.Drawing.Color.White;
            this.btnImportToExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportToExcel.Click += new System.EventHandler(this.btnImportToExcel_Click);
            // 
            // btnImportToSQL
            // 
            this.btnImportToSQL.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnImportToSQL.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImportToSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportToSQL.BorderRadius = 0;
            this.btnImportToSQL.ButtonText = "Import";
            this.btnImportToSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportToSQL.DisabledColor = System.Drawing.Color.Gray;
            this.btnImportToSQL.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImportToSQL.Iconimage = null;
            this.btnImportToSQL.Iconimage_right = null;
            this.btnImportToSQL.Iconimage_right_Selected = null;
            this.btnImportToSQL.Iconimage_Selected = null;
            this.btnImportToSQL.IconMarginLeft = 0;
            this.btnImportToSQL.IconMarginRight = 0;
            this.btnImportToSQL.IconRightVisible = true;
            this.btnImportToSQL.IconRightZoom = 0D;
            this.btnImportToSQL.IconVisible = true;
            this.btnImportToSQL.IconZoom = 90D;
            this.btnImportToSQL.IsTab = false;
            this.btnImportToSQL.Location = new System.Drawing.Point(1220, 574);
            this.btnImportToSQL.Name = "btnImportToSQL";
            this.btnImportToSQL.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnImportToSQL.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnImportToSQL.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImportToSQL.selected = false;
            this.btnImportToSQL.Size = new System.Drawing.Size(131, 31);
            this.btnImportToSQL.TabIndex = 5;
            this.btnImportToSQL.Text = "Import";
            this.btnImportToSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportToSQL.Textcolor = System.Drawing.Color.White;
            this.btnImportToSQL.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportToSQL.Click += new System.EventHandler(this.btnImportToSQL_Click);
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(802, 78);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(232, 20);
            this.txtJobName.TabIndex = 6;
            // 
            // dgImportExcelGridNorm
            // 
            this.dgImportExcelGridNorm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImportExcelGridNorm.Location = new System.Drawing.Point(12, 120);
            this.dgImportExcelGridNorm.Name = "dgImportExcelGridNorm";
            this.dgImportExcelGridNorm.Size = new System.Drawing.Size(986, 448);
            this.dgImportExcelGridNorm.TabIndex = 7;
            // 
            // ImportExcelSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 690);
            this.Controls.Add(this.dgImportExcelGridNorm);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.btnImportToSQL);
            this.Controls.Add(this.btnImportToExcel);
            this.Controls.Add(this.btnBrowseFileDir);
            this.Controls.Add(this.dgImportExcelGrid);
            this.Controls.Add(this.txtBoxDoThings);
            this.Controls.Add(this.txtBrowseFileDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportExcelSheet";
            this.Text = "ImportExcelSheet";
            this.Load += new System.EventHandler(this.ImportExcelSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcelGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImportExcelGridNorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btnImportToExcel;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseFileDir;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgImportExcelGrid;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtBoxDoThings;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtBrowseFileDir;
        private Bunifu.Framework.UI.BunifuFlatButton btnImportToSQL;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.DataGridView dgImportExcelGridNorm;
    }
}