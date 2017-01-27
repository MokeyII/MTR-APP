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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbMillLocation = new System.Windows.Forms.ComboBox();
            this.cmbWallThickness = new System.Windows.Forms.ComboBox();
            this.cmbCoating = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.cmbANSI = new System.Windows.Forms.ComboBox();
            this.txtPurchaseOrder = new System.Windows.Forms.TextBox();
            this.cmbStandard = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblMillLocation = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblWeldSeamType = new System.Windows.Forms.Label();
            this.lblWallThickness = new System.Windows.Forms.Label();
            this.lblCoating = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHeat = new System.Windows.Forms.Label();
            this.lblANSI = new System.Windows.Forms.Label();
            this.lblPurchasePrder = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.lblJobName = new System.Windows.Forms.Label();
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
            this.btnRefreshJobName = new System.Windows.Forms.Button();
            this.lblMasterDataGrid = new System.Windows.Forms.Label();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.lblDgJobTitle = new System.Windows.Forms.Label();
            this.cmbProductDescription = new System.Windows.Forms.ComboBox();
            this.cmbWeldSeamType = new System.Windows.Forms.ComboBox();
            this.cmbOuterDimension = new System.Windows.Forms.ComboBox();
            this.txtLastNotesInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgMasterGridBun = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mTR_DatabaseDataSet = new MTR_App.MTR_DatabaseDataSet();
            this.masterTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterTableTableAdapter = new MTR_App.MTR_DatabaseDataSetTableAdapters.MasterTableTableAdapter();
            this.dgJobGridBun = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSubmitBun = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddSelectionBun = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridBun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTR_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobGridBun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(151, 173);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbManufacturer.TabIndex = 3;
            this.toolTips.SetToolTip(this.cmbManufacturer, resources.GetString("cmbManufacturer.ToolTip"));
            this.cmbManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbManufacturer_KeyDown_1);
            // 
            // cmbMillLocation
            // 
            this.cmbMillLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMillLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMillLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMillLocation.FormattingEnabled = true;
            this.cmbMillLocation.Location = new System.Drawing.Point(151, 200);
            this.cmbMillLocation.Name = "cmbMillLocation";
            this.cmbMillLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbMillLocation.TabIndex = 4;
            this.toolTips.SetToolTip(this.cmbMillLocation, resources.GetString("cmbMillLocation.ToolTip"));
            this.cmbMillLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMillLocation_KeyDown_1);
            // 
            // cmbWallThickness
            // 
            this.cmbWallThickness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWallThickness.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWallThickness.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWallThickness.FormattingEnabled = true;
            this.cmbWallThickness.Location = new System.Drawing.Point(151, 308);
            this.cmbWallThickness.Name = "cmbWallThickness";
            this.cmbWallThickness.Size = new System.Drawing.Size(121, 21);
            this.cmbWallThickness.TabIndex = 8;
            this.toolTips.SetToolTip(this.cmbWallThickness, resources.GetString("cmbWallThickness.ToolTip"));
            this.cmbWallThickness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWallThickness_KeyDown_1);
            // 
            // cmbCoating
            // 
            this.cmbCoating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCoating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCoating.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCoating.FormattingEnabled = true;
            this.cmbCoating.Location = new System.Drawing.Point(151, 335);
            this.cmbCoating.Name = "cmbCoating";
            this.cmbCoating.Size = new System.Drawing.Size(121, 21);
            this.cmbCoating.TabIndex = 9;
            this.toolTips.SetToolTip(this.cmbCoating, resources.GetString("cmbCoating.ToolTip"));
            this.cmbCoating.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCoating_KeyDown_1);
            // 
            // cmbGrade
            // 
            this.cmbGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(151, 362);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 21);
            this.cmbGrade.TabIndex = 10;
            this.toolTips.SetToolTip(this.cmbGrade, resources.GetString("cmbGrade.ToolTip"));
            this.cmbGrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGrade_KeyDown_1);
            // 
            // txtHeat
            // 
            this.txtHeat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHeat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtHeat.Location = new System.Drawing.Point(149, 389);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(123, 20);
            this.txtHeat.TabIndex = 11;
            this.toolTips.SetToolTip(this.txtHeat, "Type in a Heat Number for the item.");
            this.txtHeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHeat_KeyDown_1);
            // 
            // cmbANSI
            // 
            this.cmbANSI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbANSI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbANSI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbANSI.FormattingEnabled = true;
            this.cmbANSI.Location = new System.Drawing.Point(151, 415);
            this.cmbANSI.Name = "cmbANSI";
            this.cmbANSI.Size = new System.Drawing.Size(121, 21);
            this.cmbANSI.TabIndex = 12;
            this.toolTips.SetToolTip(this.cmbANSI, resources.GetString("cmbANSI.ToolTip"));
            this.cmbANSI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbANSI_KeyDown_1);
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.Location = new System.Drawing.Point(151, 442);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(121, 20);
            this.txtPurchaseOrder.TabIndex = 13;
            this.toolTips.SetToolTip(this.txtPurchaseOrder, "Type in the Purchase Order");
            this.txtPurchaseOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseOrder_KeyDown_1);
            // 
            // cmbStandard
            // 
            this.cmbStandard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStandard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStandard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStandard.FormattingEnabled = true;
            this.cmbStandard.Location = new System.Drawing.Point(149, 469);
            this.cmbStandard.Name = "cmbStandard";
            this.cmbStandard.Size = new System.Drawing.Size(121, 21);
            this.cmbStandard.TabIndex = 14;
            this.toolTips.SetToolTip(this.cmbStandard, resources.GetString("cmbStandard.ToolTip"));
            this.cmbStandard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStandard_KeyDown_1);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(49, 176);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(98, 14);
            this.lblManufacturer.TabIndex = 14;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblMillLocation
            // 
            this.lblMillLocation.AutoSize = true;
            this.lblMillLocation.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMillLocation.Location = new System.Drawing.Point(42, 203);
            this.lblMillLocation.Name = "lblMillLocation";
            this.lblMillLocation.Size = new System.Drawing.Size(105, 14);
            this.lblMillLocation.TabIndex = 15;
            this.lblMillLocation.Text = "Mill Location:";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(0, 230);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(147, 14);
            this.lblProductDescription.TabIndex = 16;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // lblWeldSeamType
            // 
            this.lblWeldSeamType.AutoSize = true;
            this.lblWeldSeamType.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeldSeamType.Location = new System.Drawing.Point(35, 257);
            this.lblWeldSeamType.Name = "lblWeldSeamType";
            this.lblWeldSeamType.Size = new System.Drawing.Size(112, 14);
            this.lblWeldSeamType.TabIndex = 17;
            this.lblWeldSeamType.Text = "Weld Seam Type:";
            // 
            // lblWallThickness
            // 
            this.lblWallThickness.AutoSize = true;
            this.lblWallThickness.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallThickness.Location = new System.Drawing.Point(32, 311);
            this.lblWallThickness.Name = "lblWallThickness";
            this.lblWallThickness.Size = new System.Drawing.Size(112, 14);
            this.lblWallThickness.TabIndex = 18;
            this.lblWallThickness.Text = "Wall Thickness:";
            // 
            // lblCoating
            // 
            this.lblCoating.AutoSize = true;
            this.lblCoating.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoating.Location = new System.Drawing.Point(82, 338);
            this.lblCoating.Name = "lblCoating";
            this.lblCoating.Size = new System.Drawing.Size(63, 14);
            this.lblCoating.TabIndex = 19;
            this.lblCoating.Text = "Coating:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(96, 365);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(49, 14);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.Text = "Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Outer Dimension:";
            // 
            // lblHeat
            // 
            this.lblHeat.AutoSize = true;
            this.lblHeat.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeat.Location = new System.Drawing.Point(101, 391);
            this.lblHeat.Name = "lblHeat";
            this.lblHeat.Size = new System.Drawing.Size(42, 14);
            this.lblHeat.TabIndex = 22;
            this.lblHeat.Text = "Heat:";
            // 
            // lblANSI
            // 
            this.lblANSI.AutoSize = true;
            this.lblANSI.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANSI.Location = new System.Drawing.Point(66, 418);
            this.lblANSI.Name = "lblANSI";
            this.lblANSI.Size = new System.Drawing.Size(77, 14);
            this.lblANSI.TabIndex = 23;
            this.lblANSI.Text = "ANSI/ASME:";
            // 
            // lblPurchasePrder
            // 
            this.lblPurchasePrder.AutoSize = true;
            this.lblPurchasePrder.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrder.Location = new System.Drawing.Point(32, 445);
            this.lblPurchasePrder.Name = "lblPurchasePrder";
            this.lblPurchasePrder.Size = new System.Drawing.Size(112, 14);
            this.lblPurchasePrder.TabIndex = 24;
            this.lblPurchasePrder.Text = "Purchase Order:";
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(73, 472);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(70, 14);
            this.lblStandard.TabIndex = 25;
            this.lblStandard.Text = "Standard:";
            // 
            // cmbJobName
            // 
            this.cmbJobName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobName.BackColor = System.Drawing.SystemColors.Window;
            this.cmbJobName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.Location = new System.Drawing.Point(151, 135);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(121, 21);
            this.cmbJobName.TabIndex = 1;
            this.toolTips.SetToolTip(this.cmbJobName, "Select the dropdown to select a job.");
            this.cmbJobName.SelectedIndexChanged += new System.EventHandler(this.cmbJobName_SelectedIndexChanged);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(74, 139);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(70, 14);
            this.lblJobName.TabIndex = 27;
            this.lblJobName.Text = "Job Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
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
            this.txtLastJobInput.BackColor = System.Drawing.Color.White;
            this.txtLastJobInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastJobInput.Enabled = false;
            this.txtLastJobInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastJobInput.Location = new System.Drawing.Point(585, 139);
            this.txtLastJobInput.Name = "txtLastJobInput";
            this.txtLastJobInput.ReadOnly = true;
            this.txtLastJobInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastJobInput.TabIndex = 57;
            this.txtLastJobInput.TabStop = false;
            // 
            // txtLastManufacturerInput
            // 
            this.txtLastManufacturerInput.BackColor = System.Drawing.Color.White;
            this.txtLastManufacturerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastManufacturerInput.Enabled = false;
            this.txtLastManufacturerInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastManufacturerInput.Location = new System.Drawing.Point(585, 176);
            this.txtLastManufacturerInput.Name = "txtLastManufacturerInput";
            this.txtLastManufacturerInput.ReadOnly = true;
            this.txtLastManufacturerInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastManufacturerInput.TabIndex = 58;
            this.txtLastManufacturerInput.TabStop = false;
            // 
            // txtLastMillLocationInput
            // 
            this.txtLastMillLocationInput.BackColor = System.Drawing.Color.White;
            this.txtLastMillLocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastMillLocationInput.Enabled = false;
            this.txtLastMillLocationInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastMillLocationInput.Location = new System.Drawing.Point(585, 204);
            this.txtLastMillLocationInput.Name = "txtLastMillLocationInput";
            this.txtLastMillLocationInput.ReadOnly = true;
            this.txtLastMillLocationInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastMillLocationInput.TabIndex = 59;
            this.txtLastMillLocationInput.TabStop = false;
            // 
            // txtLastProductDescriptionInput
            // 
            this.txtLastProductDescriptionInput.BackColor = System.Drawing.Color.White;
            this.txtLastProductDescriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastProductDescriptionInput.Enabled = false;
            this.txtLastProductDescriptionInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastProductDescriptionInput.Location = new System.Drawing.Point(585, 231);
            this.txtLastProductDescriptionInput.Name = "txtLastProductDescriptionInput";
            this.txtLastProductDescriptionInput.ReadOnly = true;
            this.txtLastProductDescriptionInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastProductDescriptionInput.TabIndex = 60;
            this.txtLastProductDescriptionInput.TabStop = false;
            // 
            // txtLastWeldSeamTypeInput
            // 
            this.txtLastWeldSeamTypeInput.BackColor = System.Drawing.Color.White;
            this.txtLastWeldSeamTypeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastWeldSeamTypeInput.Enabled = false;
            this.txtLastWeldSeamTypeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastWeldSeamTypeInput.Location = new System.Drawing.Point(585, 258);
            this.txtLastWeldSeamTypeInput.Name = "txtLastWeldSeamTypeInput";
            this.txtLastWeldSeamTypeInput.ReadOnly = true;
            this.txtLastWeldSeamTypeInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastWeldSeamTypeInput.TabIndex = 61;
            this.txtLastWeldSeamTypeInput.TabStop = false;
            // 
            // txtLastOuterDimensionInput
            // 
            this.txtLastOuterDimensionInput.BackColor = System.Drawing.Color.White;
            this.txtLastOuterDimensionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastOuterDimensionInput.Enabled = false;
            this.txtLastOuterDimensionInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastOuterDimensionInput.Location = new System.Drawing.Point(585, 284);
            this.txtLastOuterDimensionInput.Name = "txtLastOuterDimensionInput";
            this.txtLastOuterDimensionInput.ReadOnly = true;
            this.txtLastOuterDimensionInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastOuterDimensionInput.TabIndex = 62;
            this.txtLastOuterDimensionInput.TabStop = false;
            // 
            // txtLastWallThicknessInput
            // 
            this.txtLastWallThicknessInput.BackColor = System.Drawing.Color.White;
            this.txtLastWallThicknessInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastWallThicknessInput.Enabled = false;
            this.txtLastWallThicknessInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastWallThicknessInput.Location = new System.Drawing.Point(585, 312);
            this.txtLastWallThicknessInput.Name = "txtLastWallThicknessInput";
            this.txtLastWallThicknessInput.ReadOnly = true;
            this.txtLastWallThicknessInput.Size = new System.Drawing.Size(114, 14);
            this.txtLastWallThicknessInput.TabIndex = 63;
            this.txtLastWallThicknessInput.TabStop = false;
            // 
            // txtLastCoatingIput
            // 
            this.txtLastCoatingIput.BackColor = System.Drawing.Color.White;
            this.txtLastCoatingIput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastCoatingIput.Enabled = false;
            this.txtLastCoatingIput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastCoatingIput.Location = new System.Drawing.Point(585, 339);
            this.txtLastCoatingIput.Name = "txtLastCoatingIput";
            this.txtLastCoatingIput.ReadOnly = true;
            this.txtLastCoatingIput.Size = new System.Drawing.Size(114, 14);
            this.txtLastCoatingIput.TabIndex = 64;
            this.txtLastCoatingIput.TabStop = false;
            // 
            // txtLastGradeInput
            // 
            this.txtLastGradeInput.BackColor = System.Drawing.Color.White;
            this.txtLastGradeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastGradeInput.Enabled = false;
            this.txtLastGradeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastGradeInput.Location = new System.Drawing.Point(584, 366);
            this.txtLastGradeInput.Name = "txtLastGradeInput";
            this.txtLastGradeInput.ReadOnly = true;
            this.txtLastGradeInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastGradeInput.TabIndex = 65;
            this.txtLastGradeInput.TabStop = false;
            // 
            // txtLastHeatinput
            // 
            this.txtLastHeatinput.BackColor = System.Drawing.Color.White;
            this.txtLastHeatinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastHeatinput.Enabled = false;
            this.txtLastHeatinput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastHeatinput.Location = new System.Drawing.Point(584, 392);
            this.txtLastHeatinput.Name = "txtLastHeatinput";
            this.txtLastHeatinput.ReadOnly = true;
            this.txtLastHeatinput.Size = new System.Drawing.Size(115, 14);
            this.txtLastHeatinput.TabIndex = 66;
            this.txtLastHeatinput.TabStop = false;
            // 
            // txtLastPurchaseOrderInput
            // 
            this.txtLastPurchaseOrderInput.BackColor = System.Drawing.Color.White;
            this.txtLastPurchaseOrderInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastPurchaseOrderInput.Enabled = false;
            this.txtLastPurchaseOrderInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPurchaseOrderInput.Location = new System.Drawing.Point(584, 445);
            this.txtLastPurchaseOrderInput.Name = "txtLastPurchaseOrderInput";
            this.txtLastPurchaseOrderInput.ReadOnly = true;
            this.txtLastPurchaseOrderInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastPurchaseOrderInput.TabIndex = 67;
            this.txtLastPurchaseOrderInput.TabStop = false;
            // 
            // txtLastAnsiAsmeInput
            // 
            this.txtLastAnsiAsmeInput.BackColor = System.Drawing.Color.White;
            this.txtLastAnsiAsmeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastAnsiAsmeInput.Enabled = false;
            this.txtLastAnsiAsmeInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastAnsiAsmeInput.Location = new System.Drawing.Point(584, 419);
            this.txtLastAnsiAsmeInput.Name = "txtLastAnsiAsmeInput";
            this.txtLastAnsiAsmeInput.ReadOnly = true;
            this.txtLastAnsiAsmeInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastAnsiAsmeInput.TabIndex = 68;
            this.txtLastAnsiAsmeInput.TabStop = false;
            // 
            // txtLastStandardInput
            // 
            this.txtLastStandardInput.BackColor = System.Drawing.Color.White;
            this.txtLastStandardInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastStandardInput.Enabled = false;
            this.txtLastStandardInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastStandardInput.Location = new System.Drawing.Point(584, 473);
            this.txtLastStandardInput.Name = "txtLastStandardInput";
            this.txtLastStandardInput.ReadOnly = true;
            this.txtLastStandardInput.Size = new System.Drawing.Size(115, 14);
            this.txtLastStandardInput.TabIndex = 69;
            this.txtLastStandardInput.TabStop = false;
            // 
            // btnRefreshJobName
            // 
            this.btnRefreshJobName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshJobName.BackgroundImage")));
            this.btnRefreshJobName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshJobName.Location = new System.Drawing.Point(278, 135);
            this.btnRefreshJobName.Name = "btnRefreshJobName";
            this.btnRefreshJobName.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshJobName.TabIndex = 2;
            this.toolTips.SetToolTip(this.btnRefreshJobName, "Click here to refresh your jobs list after adding a new job.");
            this.btnRefreshJobName.UseVisualStyleBackColor = true;
            this.btnRefreshJobName.Click += new System.EventHandler(this.btnRefreshJobName_Click);
            // 
            // lblMasterDataGrid
            // 
            this.lblMasterDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasterDataGrid.AutoSize = true;
            this.lblMasterDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMasterDataGrid.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterDataGrid.Location = new System.Drawing.Point(1125, 37);
            this.lblMasterDataGrid.Name = "lblMasterDataGrid";
            this.lblMasterDataGrid.Size = new System.Drawing.Size(142, 22);
            this.lblMasterDataGrid.TabIndex = 72;
            this.lblMasterDataGrid.Text = "Master Table";
            this.lblMasterDataGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchJob.Location = new System.Drawing.Point(1129, 576);
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(243, 20);
            this.txtSearchJob.TabIndex = 18;
            // 
            // lblDgJobTitle
            // 
            this.lblDgJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDgJobTitle.AutoSize = true;
            this.lblDgJobTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDgJobTitle.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgJobTitle.Location = new System.Drawing.Point(12, 576);
            this.lblDgJobTitle.Name = "lblDgJobTitle";
            this.lblDgJobTitle.Size = new System.Drawing.Size(109, 22);
            this.lblDgJobTitle.TabIndex = 75;
            this.lblDgJobTitle.Text = "Job Name:";
            // 
            // cmbProductDescription
            // 
            this.cmbProductDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProductDescription.FormattingEnabled = true;
            this.cmbProductDescription.Location = new System.Drawing.Point(151, 227);
            this.cmbProductDescription.Name = "cmbProductDescription";
            this.cmbProductDescription.Size = new System.Drawing.Size(121, 21);
            this.cmbProductDescription.TabIndex = 5;
            this.toolTips.SetToolTip(this.cmbProductDescription, resources.GetString("cmbProductDescription.ToolTip"));
            this.cmbProductDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductDescription_KeyDown);
            // 
            // cmbWeldSeamType
            // 
            this.cmbWeldSeamType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWeldSeamType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWeldSeamType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWeldSeamType.FormattingEnabled = true;
            this.cmbWeldSeamType.Location = new System.Drawing.Point(151, 254);
            this.cmbWeldSeamType.Name = "cmbWeldSeamType";
            this.cmbWeldSeamType.Size = new System.Drawing.Size(121, 21);
            this.cmbWeldSeamType.TabIndex = 6;
            this.toolTips.SetToolTip(this.cmbWeldSeamType, resources.GetString("cmbWeldSeamType.ToolTip"));
            this.cmbWeldSeamType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWeldSeamType_KeyDown);
            // 
            // cmbOuterDimension
            // 
            this.cmbOuterDimension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOuterDimension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOuterDimension.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOuterDimension.FormattingEnabled = true;
            this.cmbOuterDimension.Location = new System.Drawing.Point(149, 281);
            this.cmbOuterDimension.Name = "cmbOuterDimension";
            this.cmbOuterDimension.Size = new System.Drawing.Size(121, 21);
            this.cmbOuterDimension.TabIndex = 7;
            this.toolTips.SetToolTip(this.cmbOuterDimension, resources.GetString("cmbOuterDimension.ToolTip"));
            this.cmbOuterDimension.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOuterDimension_KeyDown);
            // 
            // txtLastNotesInput
            // 
            this.txtLastNotesInput.BackColor = System.Drawing.Color.White;
            this.txtLastNotesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastNotesInput.Enabled = false;
            this.txtLastNotesInput.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNotesInput.Location = new System.Drawing.Point(585, 500);
            this.txtLastNotesInput.Multiline = true;
            this.txtLastNotesInput.Name = "txtLastNotesInput";
            this.txtLastNotesInput.Size = new System.Drawing.Size(190, 96);
            this.txtLastNotesInput.TabIndex = 502;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(101, 500);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 505;
            this.label15.Text = "Note:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(149, 497);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(301, 20);
            this.txtNotes.TabIndex = 15;
            this.toolTips.SetToolTip(this.txtNotes, "Type in any notes for the item here.");
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
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
            this.btnSubmit.Location = new System.Drawing.Point(0, 472);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(0, 0);
            this.btnSubmit.TabIndex = 15;
            this.toolTips.SetToolTip(this.btnSubmit, "Submit the information to the database.");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgMasterGridBun
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMasterGridBun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMasterGridBun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMasterGridBun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMasterGridBun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMasterGridBun.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgMasterGridBun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMasterGridBun.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgMasterGridBun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMasterGridBun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMasterGridBun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasterGridBun.DoubleBuffered = true;
            this.dgMasterGridBun.EnableHeadersVisualStyles = false;
            this.dgMasterGridBun.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.dgMasterGridBun.HeaderForeColor = System.Drawing.Color.White;
            this.dgMasterGridBun.Location = new System.Drawing.Point(778, 65);
            this.dgMasterGridBun.Name = "dgMasterGridBun";
            this.dgMasterGridBun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMasterGridBun.RowHeadersVisible = false;
            this.dgMasterGridBun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterGridBun.Size = new System.Drawing.Size(794, 397);
            this.dgMasterGridBun.TabIndex = 506;
            // 
            // mTR_DatabaseDataSet
            // 
            this.mTR_DatabaseDataSet.DataSetName = "MTR_DatabaseDataSet";
            this.mTR_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterTableBindingSource
            // 
            this.masterTableBindingSource.DataMember = "MasterTable";
            this.masterTableBindingSource.DataSource = this.mTR_DatabaseDataSet;
            // 
            // masterTableTableAdapter
            // 
            this.masterTableTableAdapter.ClearBeforeFill = true;
            // 
            // dgJobGridBun
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgJobGridBun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJobGridBun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgJobGridBun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgJobGridBun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgJobGridBun.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgJobGridBun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgJobGridBun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgJobGridBun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJobGridBun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgJobGridBun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobGridBun.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgJobGridBun.DoubleBuffered = true;
            this.dgJobGridBun.EnableHeadersVisualStyles = false;
            this.dgJobGridBun.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.dgJobGridBun.HeaderForeColor = System.Drawing.Color.White;
            this.dgJobGridBun.Location = new System.Drawing.Point(12, 602);
            this.dgJobGridBun.Name = "dgJobGridBun";
            this.dgJobGridBun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgJobGridBun.RowHeadersVisible = false;
            this.dgJobGridBun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgJobGridBun.Size = new System.Drawing.Size(1560, 407);
            this.dgJobGridBun.TabIndex = 507;
            // 
            // btnSubmitBun
            // 
            this.btnSubmitBun.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmitBun.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitBun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitBun.BorderRadius = 0;
            this.btnSubmitBun.ButtonText = "Submit";
            this.btnSubmitBun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitBun.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmitBun.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmitBun.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmitBun.Iconimage")));
            this.btnSubmitBun.Iconimage_right = null;
            this.btnSubmitBun.Iconimage_right_Selected = null;
            this.btnSubmitBun.Iconimage_Selected = null;
            this.btnSubmitBun.IconMarginLeft = 0;
            this.btnSubmitBun.IconMarginRight = 0;
            this.btnSubmitBun.IconRightVisible = true;
            this.btnSubmitBun.IconRightZoom = 0D;
            this.btnSubmitBun.IconVisible = true;
            this.btnSubmitBun.IconZoom = 90D;
            this.btnSubmitBun.IsTab = false;
            this.btnSubmitBun.Location = new System.Drawing.Point(354, 523);
            this.btnSubmitBun.Name = "btnSubmitBun";
            this.btnSubmitBun.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitBun.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnSubmitBun.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmitBun.selected = false;
            this.btnSubmitBun.Size = new System.Drawing.Size(96, 33);
            this.btnSubmitBun.TabIndex = 508;
            this.btnSubmitBun.Text = "Submit";
            this.btnSubmitBun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitBun.Textcolor = System.Drawing.Color.White;
            this.btnSubmitBun.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitBun.Click += new System.EventHandler(this.btnSubmitBun_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh Selections";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(287, 465);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(127, 25);
            this.bunifuFlatButton1.TabIndex = 510;
            this.bunifuFlatButton1.Text = "Refresh Selections";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 525;
            this.label1.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 524;
            this.label2.Text = "Job Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 523;
            this.label4.Text = "Standard:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 522;
            this.label5.Text = "Purchase Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 521;
            this.label6.Text = "ANSI/ASME:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 520;
            this.label7.Text = "Heat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 519;
            this.label8.Text = "Outer Dimension:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 518;
            this.label9.Text = "Grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 517;
            this.label10.Text = "Coating:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(467, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 14);
            this.label11.TabIndex = 516;
            this.label11.Text = "Wall Thickness:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 14);
            this.label12.TabIndex = 515;
            this.label12.Text = "Weld Seam Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(435, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 14);
            this.label13.TabIndex = 514;
            this.label13.Text = "Product Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(477, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 14);
            this.label14.TabIndex = 513;
            this.label14.Text = "Mill Location:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(484, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 14);
            this.label16.TabIndex = 512;
            this.label16.Text = "Manufacturer:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(100, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 22);
            this.label17.TabIndex = 526;
            this.label17.Text = "Current Job";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(478, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 22);
            this.label18.TabIndex = 527;
            this.label18.Text = "Last Input";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(3, 27);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(131, 56);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 528;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 0;
            // 
            // btnAddSelectionBun
            // 
            this.btnAddSelectionBun.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnAddSelectionBun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelectionBun.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddSelectionBun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSelectionBun.BorderRadius = 0;
            this.btnAddSelectionBun.ButtonText = "Add Selection From Master to Current";
            this.btnAddSelectionBun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSelectionBun.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSelectionBun.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSelectionBun.Iconimage = null;
            this.btnAddSelectionBun.Iconimage_right = null;
            this.btnAddSelectionBun.Iconimage_right_Selected = null;
            this.btnAddSelectionBun.Iconimage_Selected = null;
            this.btnAddSelectionBun.IconMarginLeft = 0;
            this.btnAddSelectionBun.IconMarginRight = 0;
            this.btnAddSelectionBun.IconRightVisible = true;
            this.btnAddSelectionBun.IconRightZoom = 0D;
            this.btnAddSelectionBun.IconVisible = true;
            this.btnAddSelectionBun.IconZoom = 100D;
            this.btnAddSelectionBun.IsTab = false;
            this.btnAddSelectionBun.Location = new System.Drawing.Point(1334, 472);
            this.btnAddSelectionBun.Name = "btnAddSelectionBun";
            this.btnAddSelectionBun.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAddSelectionBun.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnAddSelectionBun.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSelectionBun.selected = false;
            this.btnAddSelectionBun.Size = new System.Drawing.Size(238, 25);
            this.btnAddSelectionBun.TabIndex = 529;
            this.btnAddSelectionBun.Text = "Add Selection From Master to Current";
            this.btnAddSelectionBun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSelectionBun.Textcolor = System.Drawing.Color.White;
            this.btnAddSelectionBun.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelectionBun.Click += new System.EventHandler(this.btnAddSelectionBun_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Search Job";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 100D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1378, 571);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(85, 25);
            this.bunifuFlatButton2.TabIndex = 530;
            this.bunifuFlatButton2.Text = "Search Job";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Search Master";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 100D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1469, 571);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(102, 25);
            this.bunifuFlatButton3.TabIndex = 531;
            this.bunifuFlatButton3.Text = "Search Master";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Export To Excel";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 100D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(1460, 1017);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(112, 25);
            this.bunifuFlatButton5.TabIndex = 533;
            this.bunifuFlatButton5.Text = "Export To Excel";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 1054);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnAddSelectionBun);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnSubmitBun);
            this.Controls.Add(this.dgJobGridBun);
            this.Controls.Add(this.dgMasterGridBun);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLastNotesInput);
            this.Controls.Add(this.cmbOuterDimension);
            this.Controls.Add(this.cmbWeldSeamType);
            this.Controls.Add(this.cmbProductDescription);
            this.Controls.Add(this.lblDgJobTitle);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.lblMasterDataGrid);
            this.Controls.Add(this.btnRefreshJobName);
            this.Controls.Add(this.txtLastStandardInput);
            this.Controls.Add(this.txtLastAnsiAsmeInput);
            this.Controls.Add(this.txtLastPurchaseOrderInput);
            this.Controls.Add(this.txtLastHeatinput);
            this.Controls.Add(this.txtLastGradeInput);
            this.Controls.Add(this.txtLastCoatingIput);
            this.Controls.Add(this.txtLastWallThicknessInput);
            this.Controls.Add(this.txtLastOuterDimensionInput);
            this.Controls.Add(this.txtLastWeldSeamTypeInput);
            this.Controls.Add(this.txtLastProductDescriptionInput);
            this.Controls.Add(this.txtLastMillLocationInput);
            this.Controls.Add(this.txtLastManufacturerInput);
            this.Controls.Add(this.txtLastJobInput);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.cmbJobName);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblPurchasePrder);
            this.Controls.Add(this.lblANSI);
            this.Controls.Add(this.lblHeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblCoating);
            this.Controls.Add(this.lblWallThickness);
            this.Controls.Add(this.lblWeldSeamType);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblMillLocation);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.cmbStandard);
            this.Controls.Add(this.txtPurchaseOrder);
            this.Controls.Add(this.cmbANSI);
            this.Controls.Add(this.txtHeat);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.cmbCoating);
            this.Controls.Add(this.cmbWallThickness);
            this.Controls.Add(this.cmbMillLocation);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridBun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTR_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobGridBun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbMillLocation;
        private System.Windows.Forms.ComboBox cmbWallThickness;
        private System.Windows.Forms.ComboBox cmbCoating;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.ComboBox cmbANSI;
        private System.Windows.Forms.TextBox txtPurchaseOrder;
        private System.Windows.Forms.ComboBox cmbStandard;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblMillLocation;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblWeldSeamType;
        private System.Windows.Forms.Label lblWallThickness;
        private System.Windows.Forms.Label lblCoating;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHeat;
        private System.Windows.Forms.Label lblANSI;
        private System.Windows.Forms.Label lblPurchasePrder;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblJobName;
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
        private System.Windows.Forms.Button btnRefreshJobName;
        private System.Windows.Forms.ComboBox cmbJobName;
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
        private System.Windows.Forms.Label lblMasterDataGrid;
        private System.Windows.Forms.TextBox txtSearchJob;
        private System.Windows.Forms.Label lblDgJobTitle;
        private System.Windows.Forms.ComboBox cmbProductDescription;
        private System.Windows.Forms.ComboBox cmbWeldSeamType;
        private System.Windows.Forms.ComboBox cmbOuterDimension;
        private System.Windows.Forms.TextBox txtLastNotesInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTips;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMasterGridBun;
        private MTR_App.MTR_DatabaseDataSet mTR_DatabaseDataSet;
        private System.Windows.Forms.BindingSource masterTableBindingSource;
        private MTR_App.MTR_DatabaseDataSetTableAdapters.MasterTableTableAdapter masterTableTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgJobGridBun;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmitBun;
        private System.Windows.Forms.Button btnSubmit;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSelectionBun;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
    }
}

