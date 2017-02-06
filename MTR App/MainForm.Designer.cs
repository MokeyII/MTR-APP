namespace MTR_APP
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weldSeamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNSIASMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLastJobInput = new System.Windows.Forms.TextBox();
            this.txtLastManufacturerInput = new System.Windows.Forms.TextBox();
            this.txtLastMillLocationInput = new System.Windows.Forms.TextBox();
            this.txtLastProductDescriptionInput = new System.Windows.Forms.TextBox();
            this.txtLastWeldSeamTypeInput = new System.Windows.Forms.TextBox();
            this.txtLastOuterDimensionInput = new System.Windows.Forms.TextBox();
            this.txtLastWallThicknessInput = new System.Windows.Forms.TextBox();
            this.txtLastCoatingIput = new System.Windows.Forms.TextBox();
            this.txtLastGradeInput = new System.Windows.Forms.TextBox();
            this.txtLastHeatinput = new System.Windows.Forms.TextBox();
            this.txtLastPurchaseOrderInput = new System.Windows.Forms.TextBox();
            this.txtLastAnsiAsmeInput = new System.Windows.Forms.TextBox();
            this.txtLastStandardInput = new System.Windows.Forms.TextBox();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.txtLastNotesInput = new System.Windows.Forms.TextBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefreshJobName = new System.Windows.Forms.Button();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbMillLocation = new System.Windows.Forms.ComboBox();
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.txtPurchaseOrder = new System.Windows.Forms.TextBox();
            this.cmbProductDescription = new System.Windows.Forms.ComboBox();
            this.cmbWeldSeamType = new System.Windows.Forms.ComboBox();
            this.cmbOuterDimension = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cmbWallThickness = new System.Windows.Forms.ComboBox();
            this.cmbCoating = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbANSI = new System.Windows.Forms.ComboBox();
            this.cmbStandard = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgMasterGridBun = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgJobGridBun = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddSelection = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearchJob = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearchMaster = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExportToExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSubmitInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefreshComboBoxes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblJobName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateJobTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateMaster = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMaximizeApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizeApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCloseApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnInsertJobSidePanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridBun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobGridBun)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertJobSidePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTransition.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.addFieldToolStripMenuItem,
            this.importFromExcelToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newToolStripMenuItem.Text = "&New...";
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.jobToolStripMenuItem.Text = "&Job";
            this.jobToolStripMenuItem.Click += new System.EventHandler(this.jobToolStripMenuItem_Click);
            // 
            // addFieldToolStripMenuItem
            // 
            this.addFieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manufacturerToolStripMenuItem,
            this.millLocationToolStripMenuItem,
            this.productDescriptionToolStripMenuItem,
            this.weldSeamTypeToolStripMenuItem,
            this.wallThicknessToolStripMenuItem,
            this.coatingToolStripMenuItem,
            this.gradeToolStripMenuItem,
            this.aNSIASMEToolStripMenuItem,
            this.standardToolStripMenuItem});
            this.addFieldToolStripMenuItem.Name = "addFieldToolStripMenuItem";
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addFieldToolStripMenuItem.Text = "&Add Field";
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.manufacturerToolStripMenuItem.Text = "Manufacturer";
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
            // 
            // millLocationToolStripMenuItem
            // 
            this.millLocationToolStripMenuItem.Name = "millLocationToolStripMenuItem";
            this.millLocationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.millLocationToolStripMenuItem.Text = "Mill Location";
            this.millLocationToolStripMenuItem.Click += new System.EventHandler(this.millLocationToolStripMenuItem_Click);
            // 
            // productDescriptionToolStripMenuItem
            // 
            this.productDescriptionToolStripMenuItem.Name = "productDescriptionToolStripMenuItem";
            this.productDescriptionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.productDescriptionToolStripMenuItem.Text = "Product Description";
            this.productDescriptionToolStripMenuItem.Click += new System.EventHandler(this.productDescriptionToolStripMenuItem_Click);
            // 
            // weldSeamTypeToolStripMenuItem
            // 
            this.weldSeamTypeToolStripMenuItem.Name = "weldSeamTypeToolStripMenuItem";
            this.weldSeamTypeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.weldSeamTypeToolStripMenuItem.Text = "Weld Seam Type";
            this.weldSeamTypeToolStripMenuItem.Click += new System.EventHandler(this.weldSeamTypeToolStripMenuItem_Click);
            // 
            // wallThicknessToolStripMenuItem
            // 
            this.wallThicknessToolStripMenuItem.Name = "wallThicknessToolStripMenuItem";
            this.wallThicknessToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.wallThicknessToolStripMenuItem.Text = "Wall Thickness";
            this.wallThicknessToolStripMenuItem.Click += new System.EventHandler(this.wallThicknessToolStripMenuItem_Click);
            // 
            // coatingToolStripMenuItem
            // 
            this.coatingToolStripMenuItem.Name = "coatingToolStripMenuItem";
            this.coatingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.coatingToolStripMenuItem.Text = "Coating";
            this.coatingToolStripMenuItem.Click += new System.EventHandler(this.coatingToolStripMenuItem_Click);
            // 
            // gradeToolStripMenuItem
            // 
            this.gradeToolStripMenuItem.Name = "gradeToolStripMenuItem";
            this.gradeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gradeToolStripMenuItem.Text = "Grade";
            this.gradeToolStripMenuItem.Click += new System.EventHandler(this.gradeToolStripMenuItem_Click);
            // 
            // aNSIASMEToolStripMenuItem
            // 
            this.aNSIASMEToolStripMenuItem.Name = "aNSIASMEToolStripMenuItem";
            this.aNSIASMEToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aNSIASMEToolStripMenuItem.Text = "ANSI/ASME";
            this.aNSIASMEToolStripMenuItem.Click += new System.EventHandler(this.aNSIASMEToolStripMenuItem_Click);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // importFromExcelToolStripMenuItem
            // 
            this.importFromExcelToolStripMenuItem.Name = "importFromExcelToolStripMenuItem";
            this.importFromExcelToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importFromExcelToolStripMenuItem.Text = "&Import From Excel";
            this.importFromExcelToolStripMenuItem.Click += new System.EventHandler(this.importFromExcelToolStripMenuItem_Click);
            // 
            // txtLastJobInput
            // 
            this.txtLastJobInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastJobInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastJobInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastJobInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastJobInput.Enabled = false;
            this.txtLastJobInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastJobInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastJobInput.Location = new System.Drawing.Point(82, 17);
            this.txtLastJobInput.Name = "txtLastJobInput";
            this.txtLastJobInput.ReadOnly = true;
            this.txtLastJobInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastJobInput.TabIndex = 57;
            this.txtLastJobInput.TabStop = false;
            // 
            // txtLastManufacturerInput
            // 
            this.txtLastManufacturerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastManufacturerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastManufacturerInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastManufacturerInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastManufacturerInput.Enabled = false;
            this.txtLastManufacturerInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastManufacturerInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastManufacturerInput.Location = new System.Drawing.Point(172, 56);
            this.txtLastManufacturerInput.Name = "txtLastManufacturerInput";
            this.txtLastManufacturerInput.ReadOnly = true;
            this.txtLastManufacturerInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastManufacturerInput.TabIndex = 58;
            this.txtLastManufacturerInput.TabStop = false;
            // 
            // txtLastMillLocationInput
            // 
            this.txtLastMillLocationInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastMillLocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastMillLocationInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastMillLocationInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastMillLocationInput.Enabled = false;
            this.txtLastMillLocationInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMillLocationInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastMillLocationInput.Location = new System.Drawing.Point(172, 84);
            this.txtLastMillLocationInput.Name = "txtLastMillLocationInput";
            this.txtLastMillLocationInput.ReadOnly = true;
            this.txtLastMillLocationInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastMillLocationInput.TabIndex = 59;
            this.txtLastMillLocationInput.TabStop = false;
            // 
            // txtLastProductDescriptionInput
            // 
            this.txtLastProductDescriptionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastProductDescriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastProductDescriptionInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastProductDescriptionInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastProductDescriptionInput.Enabled = false;
            this.txtLastProductDescriptionInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastProductDescriptionInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastProductDescriptionInput.Location = new System.Drawing.Point(172, 111);
            this.txtLastProductDescriptionInput.Name = "txtLastProductDescriptionInput";
            this.txtLastProductDescriptionInput.ReadOnly = true;
            this.txtLastProductDescriptionInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastProductDescriptionInput.TabIndex = 60;
            this.txtLastProductDescriptionInput.TabStop = false;
            // 
            // txtLastWeldSeamTypeInput
            // 
            this.txtLastWeldSeamTypeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastWeldSeamTypeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastWeldSeamTypeInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastWeldSeamTypeInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastWeldSeamTypeInput.Enabled = false;
            this.txtLastWeldSeamTypeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastWeldSeamTypeInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastWeldSeamTypeInput.Location = new System.Drawing.Point(172, 138);
            this.txtLastWeldSeamTypeInput.Name = "txtLastWeldSeamTypeInput";
            this.txtLastWeldSeamTypeInput.ReadOnly = true;
            this.txtLastWeldSeamTypeInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastWeldSeamTypeInput.TabIndex = 61;
            this.txtLastWeldSeamTypeInput.TabStop = false;
            // 
            // txtLastOuterDimensionInput
            // 
            this.txtLastOuterDimensionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastOuterDimensionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastOuterDimensionInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastOuterDimensionInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastOuterDimensionInput.Enabled = false;
            this.txtLastOuterDimensionInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastOuterDimensionInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastOuterDimensionInput.Location = new System.Drawing.Point(172, 164);
            this.txtLastOuterDimensionInput.Name = "txtLastOuterDimensionInput";
            this.txtLastOuterDimensionInput.ReadOnly = true;
            this.txtLastOuterDimensionInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastOuterDimensionInput.TabIndex = 62;
            this.txtLastOuterDimensionInput.TabStop = false;
            // 
            // txtLastWallThicknessInput
            // 
            this.txtLastWallThicknessInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastWallThicknessInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastWallThicknessInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastWallThicknessInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastWallThicknessInput.Enabled = false;
            this.txtLastWallThicknessInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastWallThicknessInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastWallThicknessInput.Location = new System.Drawing.Point(172, 192);
            this.txtLastWallThicknessInput.Name = "txtLastWallThicknessInput";
            this.txtLastWallThicknessInput.ReadOnly = true;
            this.txtLastWallThicknessInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastWallThicknessInput.TabIndex = 63;
            this.txtLastWallThicknessInput.TabStop = false;
            // 
            // txtLastCoatingIput
            // 
            this.txtLastCoatingIput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastCoatingIput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastCoatingIput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastCoatingIput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastCoatingIput.Enabled = false;
            this.txtLastCoatingIput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastCoatingIput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastCoatingIput.Location = new System.Drawing.Point(172, 219);
            this.txtLastCoatingIput.Name = "txtLastCoatingIput";
            this.txtLastCoatingIput.ReadOnly = true;
            this.txtLastCoatingIput.Size = new System.Drawing.Size(114, 14);
            this.txtLastCoatingIput.TabIndex = 64;
            this.txtLastCoatingIput.TabStop = false;
            // 
            // txtLastGradeInput
            // 
            this.txtLastGradeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastGradeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastGradeInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastGradeInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastGradeInput.Enabled = false;
            this.txtLastGradeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastGradeInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastGradeInput.Location = new System.Drawing.Point(171, 246);
            this.txtLastGradeInput.Name = "txtLastGradeInput";
            this.txtLastGradeInput.ReadOnly = true;
            this.txtLastGradeInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastGradeInput.TabIndex = 65;
            this.txtLastGradeInput.TabStop = false;
            // 
            // txtLastHeatinput
            // 
            this.txtLastHeatinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastHeatinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastHeatinput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastHeatinput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastHeatinput.Enabled = false;
            this.txtLastHeatinput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastHeatinput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastHeatinput.Location = new System.Drawing.Point(171, 272);
            this.txtLastHeatinput.Name = "txtLastHeatinput";
            this.txtLastHeatinput.ReadOnly = true;
            this.txtLastHeatinput.Size = new System.Drawing.Size(115, 14);
            this.txtLastHeatinput.TabIndex = 66;
            this.txtLastHeatinput.TabStop = false;
            // 
            // txtLastPurchaseOrderInput
            // 
            this.txtLastPurchaseOrderInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastPurchaseOrderInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastPurchaseOrderInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastPurchaseOrderInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastPurchaseOrderInput.Enabled = false;
            this.txtLastPurchaseOrderInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPurchaseOrderInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastPurchaseOrderInput.Location = new System.Drawing.Point(171, 325);
            this.txtLastPurchaseOrderInput.Name = "txtLastPurchaseOrderInput";
            this.txtLastPurchaseOrderInput.ReadOnly = true;
            this.txtLastPurchaseOrderInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastPurchaseOrderInput.TabIndex = 67;
            this.txtLastPurchaseOrderInput.TabStop = false;
            // 
            // txtLastAnsiAsmeInput
            // 
            this.txtLastAnsiAsmeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastAnsiAsmeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastAnsiAsmeInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastAnsiAsmeInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastAnsiAsmeInput.Enabled = false;
            this.txtLastAnsiAsmeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastAnsiAsmeInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastAnsiAsmeInput.Location = new System.Drawing.Point(171, 299);
            this.txtLastAnsiAsmeInput.Name = "txtLastAnsiAsmeInput";
            this.txtLastAnsiAsmeInput.ReadOnly = true;
            this.txtLastAnsiAsmeInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastAnsiAsmeInput.TabIndex = 68;
            this.txtLastAnsiAsmeInput.TabStop = false;
            // 
            // txtLastStandardInput
            // 
            this.txtLastStandardInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastStandardInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastStandardInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastStandardInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastStandardInput.Enabled = false;
            this.txtLastStandardInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastStandardInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastStandardInput.Location = new System.Drawing.Point(171, 353);
            this.txtLastStandardInput.Name = "txtLastStandardInput";
            this.txtLastStandardInput.ReadOnly = true;
            this.txtLastStandardInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastStandardInput.TabIndex = 69;
            this.txtLastStandardInput.TabStop = false;
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.txtSearchJob, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtSearchJob, BunifuAnimatorNS.DecorationType.None);
            this.txtSearchJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtSearchJob.Location = new System.Drawing.Point(1124, 522);
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(243, 20);
            this.txtSearchJob.TabIndex = 18;
            // 
            // txtLastNotesInput
            // 
            this.txtLastNotesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txtLastNotesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logoTransition.SetDecoration(this.txtLastNotesInput, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtLastNotesInput, BunifuAnimatorNS.DecorationType.None);
            this.txtLastNotesInput.Enabled = false;
            this.txtLastNotesInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNotesInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtLastNotesInput.Location = new System.Drawing.Point(172, 380);
            this.txtLastNotesInput.Multiline = true;
            this.txtLastNotesInput.Name = "txtLastNotesInput";
            this.txtLastNotesInput.Size = new System.Drawing.Size(190, 75);
            this.txtLastNotesInput.TabIndex = 502;
            // 
            // toolTips
            // 
            this.toolTips.AutoPopDelay = 50000;
            this.toolTips.ForeColor = System.Drawing.Color.Black;
            this.toolTips.InitialDelay = 500;
            this.toolTips.ReshowDelay = 100;
            this.toolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTips.ToolTipTitle = "Tool Tip";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoTransition.SetDecoration(this.btnSubmit, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnSubmit, BunifuAnimatorNS.DecorationType.None);
            this.btnSubmit.Location = new System.Drawing.Point(0, 472);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(0, 0);
            this.btnSubmit.TabIndex = 15;
            this.toolTips.SetToolTip(this.btnSubmit, "Submit the information to the database.");
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnRefreshJobName
            // 
            this.btnRefreshJobName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshJobName.BackgroundImage")));
            this.btnRefreshJobName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoTransition.SetDecoration(this.btnRefreshJobName, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnRefreshJobName, BunifuAnimatorNS.DecorationType.None);
            this.btnRefreshJobName.Location = new System.Drawing.Point(309, 76);
            this.btnRefreshJobName.Name = "btnRefreshJobName";
            this.btnRefreshJobName.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshJobName.TabIndex = 2;
            this.toolTips.SetToolTip(this.btnRefreshJobName, "Click here to refresh your jobs list after adding a new job.");
            this.btnRefreshJobName.UseVisualStyleBackColor = true;
            this.btnRefreshJobName.Click += new System.EventHandler(this.btnRefreshJobName_Click);
            // 
            // cmbJobName
            // 
            this.cmbJobName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbJobName, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbJobName, BunifuAnimatorNS.DecorationType.None);
            this.cmbJobName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.Location = new System.Drawing.Point(182, 76);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(121, 21);
            this.cmbJobName.TabIndex = 1;
            this.toolTips.SetToolTip(this.cmbJobName, "Select the dropdown to select a job.");
            this.cmbJobName.SelectedIndexChanged += new System.EventHandler(this.cmbJobName_SelectedIndexChanged);
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbManufacturer, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbManufacturer, BunifuAnimatorNS.DecorationType.None);
            this.cmbManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(60, 136);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbManufacturer.TabIndex = 511;
            this.toolTips.SetToolTip(this.cmbManufacturer, resources.GetString("cmbManufacturer.ToolTip"));
            // 
            // cmbMillLocation
            // 
            this.cmbMillLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMillLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMillLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbMillLocation, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbMillLocation, BunifuAnimatorNS.DecorationType.None);
            this.cmbMillLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMillLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbMillLocation.FormattingEnabled = true;
            this.cmbMillLocation.Location = new System.Drawing.Point(60, 173);
            this.cmbMillLocation.Name = "cmbMillLocation";
            this.cmbMillLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbMillLocation.TabIndex = 512;
            this.toolTips.SetToolTip(this.cmbMillLocation, resources.GetString("cmbMillLocation.ToolTip"));
            // 
            // txtHeat
            // 
            this.txtHeat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHeat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.txtHeat, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtHeat, BunifuAnimatorNS.DecorationType.None);
            this.txtHeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtHeat.Location = new System.Drawing.Point(59, 446);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(123, 20);
            this.txtHeat.TabIndex = 519;
            this.toolTips.SetToolTip(this.txtHeat, "Type in a Heat Number for the item.");
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.txtPurchaseOrder, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtPurchaseOrder, BunifuAnimatorNS.DecorationType.None);
            this.txtPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtPurchaseOrder.Location = new System.Drawing.Point(58, 521);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(121, 20);
            this.txtPurchaseOrder.TabIndex = 521;
            this.toolTips.SetToolTip(this.txtPurchaseOrder, "Type in the Purchase Order");
            // 
            // cmbProductDescription
            // 
            this.cmbProductDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbProductDescription, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbProductDescription, BunifuAnimatorNS.DecorationType.None);
            this.cmbProductDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbProductDescription.FormattingEnabled = true;
            this.cmbProductDescription.Location = new System.Drawing.Point(60, 212);
            this.cmbProductDescription.Name = "cmbProductDescription";
            this.cmbProductDescription.Size = new System.Drawing.Size(121, 21);
            this.cmbProductDescription.TabIndex = 513;
            this.toolTips.SetToolTip(this.cmbProductDescription, resources.GetString("cmbProductDescription.ToolTip"));
            // 
            // cmbWeldSeamType
            // 
            this.cmbWeldSeamType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWeldSeamType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWeldSeamType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbWeldSeamType, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbWeldSeamType, BunifuAnimatorNS.DecorationType.None);
            this.cmbWeldSeamType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWeldSeamType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbWeldSeamType.FormattingEnabled = true;
            this.cmbWeldSeamType.Location = new System.Drawing.Point(60, 251);
            this.cmbWeldSeamType.Name = "cmbWeldSeamType";
            this.cmbWeldSeamType.Size = new System.Drawing.Size(121, 21);
            this.cmbWeldSeamType.TabIndex = 514;
            this.toolTips.SetToolTip(this.cmbWeldSeamType, resources.GetString("cmbWeldSeamType.ToolTip"));
            // 
            // cmbOuterDimension
            // 
            this.cmbOuterDimension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOuterDimension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOuterDimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbOuterDimension, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbOuterDimension, BunifuAnimatorNS.DecorationType.None);
            this.cmbOuterDimension.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOuterDimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbOuterDimension.FormattingEnabled = true;
            this.cmbOuterDimension.Location = new System.Drawing.Point(59, 290);
            this.cmbOuterDimension.Name = "cmbOuterDimension";
            this.cmbOuterDimension.Size = new System.Drawing.Size(121, 21);
            this.cmbOuterDimension.TabIndex = 515;
            this.toolTips.SetToolTip(this.cmbOuterDimension, resources.GetString("cmbOuterDimension.ToolTip"));
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.txtNotes, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.txtNotes, BunifuAnimatorNS.DecorationType.None);
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(59, 602);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(301, 20);
            this.txtNotes.TabIndex = 523;
            this.toolTips.SetToolTip(this.txtNotes, "Type in any notes for the item here.");
            // 
            // cmbWallThickness
            // 
            this.cmbWallThickness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWallThickness.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWallThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbWallThickness, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbWallThickness, BunifuAnimatorNS.DecorationType.None);
            this.cmbWallThickness.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWallThickness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbWallThickness.FormattingEnabled = true;
            this.cmbWallThickness.Location = new System.Drawing.Point(60, 329);
            this.cmbWallThickness.Name = "cmbWallThickness";
            this.cmbWallThickness.Size = new System.Drawing.Size(121, 21);
            this.cmbWallThickness.TabIndex = 516;
            // 
            // cmbCoating
            // 
            this.cmbCoating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCoating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCoating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbCoating, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbCoating, BunifuAnimatorNS.DecorationType.None);
            this.cmbCoating.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCoating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbCoating.FormattingEnabled = true;
            this.cmbCoating.Location = new System.Drawing.Point(60, 368);
            this.cmbCoating.Name = "cmbCoating";
            this.cmbCoating.Size = new System.Drawing.Size(121, 21);
            this.cmbCoating.TabIndex = 517;
            // 
            // cmbGrade
            // 
            this.cmbGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbGrade, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbGrade, BunifuAnimatorNS.DecorationType.None);
            this.cmbGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(60, 407);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 21);
            this.cmbGrade.TabIndex = 518;
            // 
            // cmbANSI
            // 
            this.cmbANSI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbANSI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbANSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbANSI, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbANSI, BunifuAnimatorNS.DecorationType.None);
            this.cmbANSI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbANSI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbANSI.FormattingEnabled = true;
            this.cmbANSI.Location = new System.Drawing.Point(58, 482);
            this.cmbANSI.Name = "cmbANSI";
            this.cmbANSI.Size = new System.Drawing.Size(121, 21);
            this.cmbANSI.TabIndex = 520;
            // 
            // cmbStandard
            // 
            this.cmbStandard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStandard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelTransition.SetDecoration(this.cmbStandard, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.cmbStandard, BunifuAnimatorNS.DecorationType.None);
            this.cmbStandard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.cmbStandard.FormattingEnabled = true;
            this.cmbStandard.Location = new System.Drawing.Point(60, 562);
            this.cmbStandard.Name = "cmbStandard";
            this.cmbStandard.Size = new System.Drawing.Size(121, 21);
            this.cmbStandard.TabIndex = 522;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgMasterGridBun
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgMasterGridBun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMasterGridBun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMasterGridBun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMasterGridBun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dgMasterGridBun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMasterGridBun.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgMasterGridBun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMasterGridBun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMasterGridBun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logoTransition.SetDecoration(this.dgMasterGridBun, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.dgMasterGridBun, BunifuAnimatorNS.DecorationType.None);
            this.dgMasterGridBun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMasterGridBun.DoubleBuffered = true;
            this.dgMasterGridBun.EnableHeadersVisualStyles = false;
            this.dgMasterGridBun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dgMasterGridBun.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgMasterGridBun.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgMasterGridBun.Location = new System.Drawing.Point(3, 16);
            this.dgMasterGridBun.MultiSelect = false;
            this.dgMasterGridBun.Name = "dgMasterGridBun";
            this.dgMasterGridBun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMasterGridBun.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgMasterGridBun.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgMasterGridBun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterGridBun.Size = new System.Drawing.Size(803, 446);
            this.dgMasterGridBun.TabIndex = 506;
            this.dgMasterGridBun.TabStop = false;
            // 
            // dgJobGridBun
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgJobGridBun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJobGridBun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgJobGridBun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgJobGridBun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dgJobGridBun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgJobGridBun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgJobGridBun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJobGridBun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgJobGridBun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobGridBun.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoTransition.SetDecoration(this.dgJobGridBun, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.dgJobGridBun, BunifuAnimatorNS.DecorationType.None);
            this.dgJobGridBun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgJobGridBun.DoubleBuffered = true;
            this.dgJobGridBun.EnableHeadersVisualStyles = false;
            this.dgJobGridBun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dgJobGridBun.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgJobGridBun.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgJobGridBun.Location = new System.Drawing.Point(3, 16);
            this.dgJobGridBun.Name = "dgJobGridBun";
            this.dgJobGridBun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJobGridBun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgJobGridBun.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.dgJobGridBun.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgJobGridBun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgJobGridBun.Size = new System.Drawing.Size(1185, 204);
            this.dgJobGridBun.TabIndex = 507;
            this.dgJobGridBun.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 525;
            this.label1.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.logoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 524;
            this.label2.Text = "Job Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.logoTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 523;
            this.label4.Text = "Standard:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.logoTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 522;
            this.label5.Text = "Purchase Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.logoTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 521;
            this.label6.Text = "ANSI/ASME:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.logoTransition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 520;
            this.label7.Text = "Heat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.logoTransition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 519;
            this.label8.Text = "Outer Dimension:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.logoTransition.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 518;
            this.label9.Text = "Grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.logoTransition.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 517;
            this.label10.Text = "Coating:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.logoTransition.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 14);
            this.label11.TabIndex = 516;
            this.label11.Text = "Wall Thickness:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.logoTransition.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 14);
            this.label12.TabIndex = 515;
            this.label12.Text = "Weld Seam Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.logoTransition.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 14);
            this.label13.TabIndex = 514;
            this.label13.Text = "Product Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.logoTransition.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 14);
            this.label14.TabIndex = 513;
            this.label14.Text = "Mill Location:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.logoTransition.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(71, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 14);
            this.label16.TabIndex = 512;
            this.label16.Text = "Manufacturer:";
            // 
            // btnAddSelection
            // 
            this.btnAddSelection.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnAddSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelection.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSelection.BorderRadius = 0;
            this.btnAddSelection.ButtonText = "Add Selection From Master to Current";
            this.btnAddSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnAddSelection, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnAddSelection, BunifuAnimatorNS.DecorationType.None);
            this.btnAddSelection.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSelection.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSelection.Iconimage = null;
            this.btnAddSelection.Iconimage_right = null;
            this.btnAddSelection.Iconimage_right_Selected = null;
            this.btnAddSelection.Iconimage_Selected = null;
            this.btnAddSelection.IconMarginLeft = 0;
            this.btnAddSelection.IconMarginRight = 0;
            this.btnAddSelection.IconRightVisible = true;
            this.btnAddSelection.IconRightZoom = 0D;
            this.btnAddSelection.IconVisible = true;
            this.btnAddSelection.IconZoom = 100D;
            this.btnAddSelection.IsTab = false;
            this.btnAddSelection.Location = new System.Drawing.Point(871, 519);
            this.btnAddSelection.Name = "btnAddSelection";
            this.btnAddSelection.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAddSelection.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnAddSelection.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSelection.selected = false;
            this.btnAddSelection.Size = new System.Drawing.Size(238, 25);
            this.btnAddSelection.TabIndex = 529;
            this.btnAddSelection.TabStop = false;
            this.btnAddSelection.Text = "Add Selection From Master to Current";
            this.btnAddSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSelection.Textcolor = System.Drawing.Color.White;
            this.btnAddSelection.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelection.Click += new System.EventHandler(this.btnAddSelection_Click);
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchJob.BorderRadius = 0;
            this.btnSearchJob.ButtonText = "Search Job";
            this.btnSearchJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnSearchJob, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnSearchJob, BunifuAnimatorNS.DecorationType.None);
            this.btnSearchJob.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchJob.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchJob.Iconimage = null;
            this.btnSearchJob.Iconimage_right = null;
            this.btnSearchJob.Iconimage_right_Selected = null;
            this.btnSearchJob.Iconimage_Selected = null;
            this.btnSearchJob.IconMarginLeft = 0;
            this.btnSearchJob.IconMarginRight = 0;
            this.btnSearchJob.IconRightVisible = true;
            this.btnSearchJob.IconRightZoom = 0D;
            this.btnSearchJob.IconVisible = true;
            this.btnSearchJob.IconZoom = 100D;
            this.btnSearchJob.IsTab = false;
            this.btnSearchJob.Location = new System.Drawing.Point(1373, 519);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSearchJob.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchJob.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchJob.selected = false;
            this.btnSearchJob.Size = new System.Drawing.Size(85, 25);
            this.btnSearchJob.TabIndex = 16;
            this.btnSearchJob.Text = "Search Job";
            this.btnSearchJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchJob.Textcolor = System.Drawing.Color.White;
            this.btnSearchJob.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // btnSearchMaster
            // 
            this.btnSearchMaster.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMaster.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchMaster.BorderRadius = 0;
            this.btnSearchMaster.ButtonText = "Search Master";
            this.btnSearchMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnSearchMaster, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnSearchMaster, BunifuAnimatorNS.DecorationType.None);
            this.btnSearchMaster.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchMaster.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchMaster.Iconimage = null;
            this.btnSearchMaster.Iconimage_right = null;
            this.btnSearchMaster.Iconimage_right_Selected = null;
            this.btnSearchMaster.Iconimage_Selected = null;
            this.btnSearchMaster.IconMarginLeft = 0;
            this.btnSearchMaster.IconMarginRight = 0;
            this.btnSearchMaster.IconRightVisible = true;
            this.btnSearchMaster.IconRightZoom = 0D;
            this.btnSearchMaster.IconVisible = true;
            this.btnSearchMaster.IconZoom = 100D;
            this.btnSearchMaster.IsTab = false;
            this.btnSearchMaster.Location = new System.Drawing.Point(1464, 519);
            this.btnSearchMaster.Name = "btnSearchMaster";
            this.btnSearchMaster.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSearchMaster.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchMaster.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchMaster.selected = false;
            this.btnSearchMaster.Size = new System.Drawing.Size(102, 25);
            this.btnSearchMaster.TabIndex = 17;
            this.btnSearchMaster.Text = "Search Master";
            this.btnSearchMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchMaster.Textcolor = System.Drawing.Color.White;
            this.btnSearchMaster.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMaster.Click += new System.EventHandler(this.btnSearchMaster_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportToExcel.BorderRadius = 0;
            this.btnExportToExcel.ButtonText = "Export To Excel";
            this.btnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnExportToExcel, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnExportToExcel, BunifuAnimatorNS.DecorationType.None);
            this.btnExportToExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportToExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.Iconimage = null;
            this.btnExportToExcel.Iconimage_right = null;
            this.btnExportToExcel.Iconimage_right_Selected = null;
            this.btnExportToExcel.Iconimage_Selected = null;
            this.btnExportToExcel.IconMarginLeft = 0;
            this.btnExportToExcel.IconMarginRight = 0;
            this.btnExportToExcel.IconRightVisible = true;
            this.btnExportToExcel.IconRightZoom = 0D;
            this.btnExportToExcel.IconVisible = true;
            this.btnExportToExcel.IconZoom = 100D;
            this.btnExportToExcel.IsTab = false;
            this.btnExportToExcel.Location = new System.Drawing.Point(1460, 785);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnExportToExcel.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnExportToExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExportToExcel.selected = false;
            this.btnExportToExcel.Size = new System.Drawing.Size(112, 25);
            this.btnExportToExcel.TabIndex = 18;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportToExcel.Textcolor = System.Drawing.Color.White;
            this.btnExportToExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnSubmitInfo
            // 
            this.btnSubmitInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmitInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitInfo.BorderRadius = 0;
            this.btnSubmitInfo.ButtonText = "Submit";
            this.btnSubmitInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnSubmitInfo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnSubmitInfo, BunifuAnimatorNS.DecorationType.None);
            this.btnSubmitInfo.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmitInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmitInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmitInfo.Iconimage")));
            this.btnSubmitInfo.Iconimage_right = null;
            this.btnSubmitInfo.Iconimage_right_Selected = null;
            this.btnSubmitInfo.Iconimage_Selected = null;
            this.btnSubmitInfo.IconMarginLeft = 0;
            this.btnSubmitInfo.IconMarginRight = 0;
            this.btnSubmitInfo.IconRightVisible = true;
            this.btnSubmitInfo.IconRightZoom = 0D;
            this.btnSubmitInfo.IconVisible = true;
            this.btnSubmitInfo.IconZoom = 90D;
            this.btnSubmitInfo.IsTab = false;
            this.btnSubmitInfo.Location = new System.Drawing.Point(59, 638);
            this.btnSubmitInfo.Name = "btnSubmitInfo";
            this.btnSubmitInfo.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitInfo.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSubmitInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitInfo.selected = false;
            this.btnSubmitInfo.Size = new System.Drawing.Size(96, 33);
            this.btnSubmitInfo.TabIndex = 15;
            this.btnSubmitInfo.Text = "Submit";
            this.btnSubmitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitInfo.Textcolor = System.Drawing.Color.White;
            this.btnSubmitInfo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitInfo.Click += new System.EventHandler(this.btnSubmitInfo_Click);
            // 
            // btnRefreshComboBoxes
            // 
            this.btnRefreshComboBoxes.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnRefreshComboBoxes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshComboBoxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshComboBoxes.BorderRadius = 0;
            this.btnRefreshComboBoxes.ButtonText = "Refresh Selections";
            this.btnRefreshComboBoxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnRefreshComboBoxes, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnRefreshComboBoxes, BunifuAnimatorNS.DecorationType.None);
            this.btnRefreshComboBoxes.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefreshComboBoxes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefreshComboBoxes.Iconimage = null;
            this.btnRefreshComboBoxes.Iconimage_right = null;
            this.btnRefreshComboBoxes.Iconimage_right_Selected = null;
            this.btnRefreshComboBoxes.Iconimage_Selected = null;
            this.btnRefreshComboBoxes.IconMarginLeft = 0;
            this.btnRefreshComboBoxes.IconMarginRight = 0;
            this.btnRefreshComboBoxes.IconRightVisible = true;
            this.btnRefreshComboBoxes.IconRightZoom = 0D;
            this.btnRefreshComboBoxes.IconVisible = true;
            this.btnRefreshComboBoxes.IconZoom = 100D;
            this.btnRefreshComboBoxes.IsTab = false;
            this.btnRefreshComboBoxes.Location = new System.Drawing.Point(187, 562);
            this.btnRefreshComboBoxes.Name = "btnRefreshComboBoxes";
            this.btnRefreshComboBoxes.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshComboBoxes.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnRefreshComboBoxes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshComboBoxes.selected = false;
            this.btnRefreshComboBoxes.Size = new System.Drawing.Size(127, 25);
            this.btnRefreshComboBoxes.TabIndex = 510;
            this.btnRefreshComboBoxes.Text = "Refresh Selections";
            this.btnRefreshComboBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshComboBoxes.Textcolor = System.Drawing.Color.White;
            this.btnRefreshComboBoxes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshComboBoxes.Click += new System.EventHandler(this.btnRefreshComboBoxes_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.logoTransition.SetDecoration(this.lblJobName, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.lblJobName, BunifuAnimatorNS.DecorationType.None);
            this.lblJobName.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(105, 80);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(70, 14);
            this.lblJobName.TabIndex = 27;
            this.lblJobName.Text = "Job Name:";
            // 
            // contextMenuStrip1
            // 
            this.panelTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLastJobInput);
            this.groupBox2.Controls.Add(this.txtLastManufacturerInput);
            this.groupBox2.Controls.Add(this.txtLastMillLocationInput);
            this.groupBox2.Controls.Add(this.txtLastProductDescriptionInput);
            this.groupBox2.Controls.Add(this.txtLastWeldSeamTypeInput);
            this.groupBox2.Controls.Add(this.txtLastOuterDimensionInput);
            this.groupBox2.Controls.Add(this.txtLastWallThicknessInput);
            this.groupBox2.Controls.Add(this.txtLastCoatingIput);
            this.groupBox2.Controls.Add(this.txtLastGradeInput);
            this.groupBox2.Controls.Add(this.txtLastHeatinput);
            this.groupBox2.Controls.Add(this.txtLastPurchaseOrderInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLastAnsiAsmeInput);
            this.groupBox2.Controls.Add(this.txtLastStandardInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLastNotesInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.panelTransition.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(381, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 465);
            this.groupBox2.TabIndex = 539;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgMasterGridBun);
            this.panelTransition.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.groupBox3.Location = new System.Drawing.Point(763, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(809, 465);
            this.groupBox3.TabIndex = 540;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.dgJobGridBun);
            this.panelTransition.SetDecoration(this.groupBox4, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.groupBox4, BunifuAnimatorNS.DecorationType.None);
            this.groupBox4.Location = new System.Drawing.Point(381, 556);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1191, 223);
            this.groupBox4.TabIndex = 541;
            this.groupBox4.TabStop = false;
            // 
            // btnUpdateJobTable
            // 
            this.btnUpdateJobTable.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateJobTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateJobTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateJobTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateJobTable.BorderRadius = 0;
            this.btnUpdateJobTable.ButtonText = "Update Job Table";
            this.btnUpdateJobTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnUpdateJobTable, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnUpdateJobTable, BunifuAnimatorNS.DecorationType.None);
            this.btnUpdateJobTable.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateJobTable.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateJobTable.Iconimage = null;
            this.btnUpdateJobTable.Iconimage_right = null;
            this.btnUpdateJobTable.Iconimage_right_Selected = null;
            this.btnUpdateJobTable.Iconimage_Selected = null;
            this.btnUpdateJobTable.IconMarginLeft = 0;
            this.btnUpdateJobTable.IconMarginRight = 0;
            this.btnUpdateJobTable.IconRightVisible = true;
            this.btnUpdateJobTable.IconRightZoom = 0D;
            this.btnUpdateJobTable.IconVisible = true;
            this.btnUpdateJobTable.IconZoom = 100D;
            this.btnUpdateJobTable.IsTab = false;
            this.btnUpdateJobTable.Location = new System.Drawing.Point(381, 782);
            this.btnUpdateJobTable.Name = "btnUpdateJobTable";
            this.btnUpdateJobTable.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateJobTable.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateJobTable.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateJobTable.selected = false;
            this.btnUpdateJobTable.Size = new System.Drawing.Size(148, 25);
            this.btnUpdateJobTable.TabIndex = 542;
            this.btnUpdateJobTable.Text = "Update Job Table";
            this.btnUpdateJobTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateJobTable.Textcolor = System.Drawing.Color.White;
            this.btnUpdateJobTable.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateJobTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // btnUpdateMaster
            // 
            this.btnUpdateMaster.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMaster.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateMaster.BorderRadius = 0;
            this.btnUpdateMaster.ButtonText = "Update Master Table";
            this.btnUpdateMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btnUpdateMaster, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.btnUpdateMaster, BunifuAnimatorNS.DecorationType.None);
            this.btnUpdateMaster.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateMaster.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateMaster.Iconimage = null;
            this.btnUpdateMaster.Iconimage_right = null;
            this.btnUpdateMaster.Iconimage_right_Selected = null;
            this.btnUpdateMaster.Iconimage_Selected = null;
            this.btnUpdateMaster.IconMarginLeft = 0;
            this.btnUpdateMaster.IconMarginRight = 0;
            this.btnUpdateMaster.IconRightVisible = true;
            this.btnUpdateMaster.IconRightZoom = 0D;
            this.btnUpdateMaster.IconVisible = true;
            this.btnUpdateMaster.IconZoom = 100D;
            this.btnUpdateMaster.IsTab = false;
            this.btnUpdateMaster.Location = new System.Drawing.Point(1166, 27);
            this.btnUpdateMaster.Name = "btnUpdateMaster";
            this.btnUpdateMaster.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateMaster.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateMaster.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateMaster.selected = false;
            this.btnUpdateMaster.Size = new System.Drawing.Size(156, 25);
            this.btnUpdateMaster.TabIndex = 543;
            this.btnUpdateMaster.Text = "Update Master Table";
            this.btnUpdateMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateMaster.Textcolor = System.Drawing.Color.White;
            this.btnUpdateMaster.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMaster.Click += new System.EventHandler(this.btnUpdateMaster_Click);
            // 
            // btnMaximizeApp
            // 
            this.btnMaximizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTransition.SetDecoration(this.btnMaximizeApp, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.btnMaximizeApp, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizeApp.Image")));
            this.btnMaximizeApp.ImageActive = null;
            this.btnMaximizeApp.Location = new System.Drawing.Point(1517, 0);
            this.btnMaximizeApp.Name = "btnMaximizeApp";
            this.btnMaximizeApp.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizeApp.TabIndex = 536;
            this.btnMaximizeApp.TabStop = false;
            this.btnMaximizeApp.Zoom = 2;
            this.btnMaximizeApp.Click += new System.EventHandler(this.btnMaximizeApp_Click);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTransition.SetDecoration(this.btnMinimizeApp, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.btnMinimizeApp, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.Image")));
            this.btnMinimizeApp.ImageActive = null;
            this.btnMinimizeApp.Location = new System.Drawing.Point(1487, 0);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeApp.TabIndex = 535;
            this.btnMinimizeApp.TabStop = false;
            this.btnMinimizeApp.Zoom = 2;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTransition.SetDecoration(this.btnCloseApp, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.btnCloseApp, BunifuAnimatorNS.DecorationType.None);
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.ImageActive = null;
            this.btnCloseApp.Location = new System.Drawing.Point(1547, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 24);
            this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseApp.TabIndex = 534;
            this.btnCloseApp.TabStop = false;
            this.btnCloseApp.Zoom = 2;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.menuStrip1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.logo);
            this.sidemenu.Controls.Add(this.lblJobName);
            this.sidemenu.Controls.Add(this.btnRefreshComboBoxes);
            this.sidemenu.Controls.Add(this.label29);
            this.sidemenu.Controls.Add(this.btnSubmitInfo);
            this.sidemenu.Controls.Add(this.label28);
            this.sidemenu.Controls.Add(this.label27);
            this.sidemenu.Controls.Add(this.label26);
            this.sidemenu.Controls.Add(this.label25);
            this.sidemenu.Controls.Add(this.label24);
            this.sidemenu.Controls.Add(this.label23);
            this.sidemenu.Controls.Add(this.label22);
            this.sidemenu.Controls.Add(this.label21);
            this.sidemenu.Controls.Add(this.label20);
            this.sidemenu.Controls.Add(this.label19);
            this.sidemenu.Controls.Add(this.label18);
            this.sidemenu.Controls.Add(this.label17);
            this.sidemenu.Controls.Add(this.cmbManufacturer);
            this.sidemenu.Controls.Add(this.cmbJobName);
            this.sidemenu.Controls.Add(this.cmbMillLocation);
            this.sidemenu.Controls.Add(this.btnRefreshJobName);
            this.sidemenu.Controls.Add(this.cmbWallThickness);
            this.sidemenu.Controls.Add(this.cmbCoating);
            this.sidemenu.Controls.Add(this.cmbGrade);
            this.sidemenu.Controls.Add(this.txtHeat);
            this.sidemenu.Controls.Add(this.cmbANSI);
            this.sidemenu.Controls.Add(this.txtPurchaseOrder);
            this.sidemenu.Controls.Add(this.cmbStandard);
            this.sidemenu.Controls.Add(this.cmbProductDescription);
            this.sidemenu.Controls.Add(this.cmbWeldSeamType);
            this.sidemenu.Controls.Add(this.cmbOuterDimension);
            this.sidemenu.Controls.Add(this.txtNotes);
            this.sidemenu.Controls.Add(this.btnInsertJobSidePanel);
            this.panelTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 24);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(375, 798);
            this.sidemenu.TabIndex = 544;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.logoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(348, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 539;
            this.logo.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.logoTransition.SetDecoration(this.label29, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label29, BunifuAnimatorNS.DecorationType.None);
            this.label29.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(58, 585);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 14);
            this.label29.TabIndex = 538;
            this.label29.Text = "Note:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.logoTransition.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(59, 544);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 14);
            this.label28.TabIndex = 537;
            this.label28.Text = "Standard:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.logoTransition.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(59, 506);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 14);
            this.label27.TabIndex = 536;
            this.label27.Text = "Purchase Order:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.logoTransition.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(58, 469);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 14);
            this.label26.TabIndex = 535;
            this.label26.Text = "ANSI/ASME:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.logoTransition.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(57, 431);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 14);
            this.label25.TabIndex = 534;
            this.label25.Text = "Heat:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.logoTransition.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(61, 390);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 14);
            this.label24.TabIndex = 533;
            this.label24.Text = "Grade:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.logoTransition.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(62, 352);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 14);
            this.label23.TabIndex = 532;
            this.label23.Text = "Coating:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.logoTransition.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(63, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 14);
            this.label22.TabIndex = 531;
            this.label22.Text = "Wall Thickness:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.logoTransition.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(61, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 14);
            this.label21.TabIndex = 530;
            this.label21.Text = "Outer Dimension:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.logoTransition.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(58, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 14);
            this.label20.TabIndex = 529;
            this.label20.Text = "Weld Seam Type:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.logoTransition.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(58, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 14);
            this.label19.TabIndex = 528;
            this.label19.Text = "Product Description:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.logoTransition.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(63, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 14);
            this.label18.TabIndex = 527;
            this.label18.Text = "Mill Location:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.logoTransition.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 14);
            this.label17.TabIndex = 526;
            this.label17.Text = "Manufacturer:";
            // 
            // btnInsertJobSidePanel
            // 
            this.btnInsertJobSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTransition.SetDecoration(this.btnInsertJobSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.btnInsertJobSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.btnInsertJobSidePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertJobSidePanel.Image")));
            this.btnInsertJobSidePanel.ImageActive = null;
            this.btnInsertJobSidePanel.Location = new System.Drawing.Point(12, 80);
            this.btnInsertJobSidePanel.Name = "btnInsertJobSidePanel";
            this.btnInsertJobSidePanel.Size = new System.Drawing.Size(29, 32);
            this.btnInsertJobSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInsertJobSidePanel.TabIndex = 0;
            this.btnInsertJobSidePanel.TabStop = false;
            this.btnInsertJobSidePanel.Zoom = 10;
            this.btnInsertJobSidePanel.Click += new System.EventHandler(this.btnInsertJobSidePanel_Click);
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.logoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation2;
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.panelTransition.DefaultAnimation = animation1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1584, 822);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.btnUpdateMaster);
            this.Controls.Add(this.btnUpdateJobTable);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMaximizeApp);
            this.Controls.Add(this.btnMinimizeApp);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnSearchMaster);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.btnAddSelection);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTRs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridBun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobGridBun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertJobSidePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLastJobInput;
        private System.Windows.Forms.TextBox txtLastManufacturerInput;
        private System.Windows.Forms.TextBox txtLastMillLocationInput;
        private System.Windows.Forms.TextBox txtLastProductDescriptionInput;
        private System.Windows.Forms.TextBox txtLastWeldSeamTypeInput;
        private System.Windows.Forms.TextBox txtLastOuterDimensionInput;
        private System.Windows.Forms.TextBox txtLastWallThicknessInput;
        private System.Windows.Forms.TextBox txtLastCoatingIput;
        private System.Windows.Forms.TextBox txtLastGradeInput;
        private System.Windows.Forms.TextBox txtLastHeatinput;
        private System.Windows.Forms.TextBox txtLastPurchaseOrderInput;
        private System.Windows.Forms.TextBox txtLastAnsiAsmeInput;
        private System.Windows.Forms.TextBox txtLastStandardInput;
        private System.Windows.Forms.ToolStripMenuItem addFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weldSeamTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNSIASMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearchJob;
        private System.Windows.Forms.TextBox txtLastNotesInput;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTips;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMasterGridBun;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgJobGridBun;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSelection;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchMaster;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchJob;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportToExcel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.ComboBox cmbJobName;
        private System.Windows.Forms.Button btnRefreshJobName;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefreshComboBoxes;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateJobTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateMaster;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizeApp;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeApp;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseApp;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbMillLocation;
        private System.Windows.Forms.ComboBox cmbWallThickness;
        private System.Windows.Forms.ComboBox cmbCoating;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.ComboBox cmbANSI;
        private System.Windows.Forms.TextBox txtPurchaseOrder;
        private System.Windows.Forms.ComboBox cmbStandard;
        private System.Windows.Forms.ComboBox cmbProductDescription;
        private System.Windows.Forms.ComboBox cmbWeldSeamType;
        private System.Windows.Forms.ComboBox cmbOuterDimension;
        private System.Windows.Forms.TextBox txtNotes;
        private Bunifu.Framework.UI.BunifuImageButton btnInsertJobSidePanel;
        private System.Windows.Forms.PictureBox logo;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
    }
}

