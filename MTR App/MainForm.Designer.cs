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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dgMasterGridView = new System.Windows.Forms.DataGridView();
            this.lblMasterDataGrid = new System.Windows.Forms.Label();
            this.btnSearchJob = new System.Windows.Forms.Button();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.lblDgJobTitle = new System.Windows.Forms.Label();
            this.btnSearchMaster = new System.Windows.Forms.Button();
            this.btnRefreshInput = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnAddToCurrentJob = new System.Windows.Forms.Button();
            this.cmbProductDescription = new System.Windows.Forms.ComboBox();
            this.cmbWeldSeamType = new System.Windows.Forms.ComboBox();
            this.cmbOuterDimension = new System.Windows.Forms.ComboBox();
            this.txtLastNotesInput = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(387, 497);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(121, 100);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.cmbManufacturer.TabIndex = 3;
            // 
            // cmbMillLocation
            // 
            this.cmbMillLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMillLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMillLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMillLocation.FormattingEnabled = true;
            this.cmbMillLocation.Location = new System.Drawing.Point(121, 127);
            this.cmbMillLocation.Name = "cmbMillLocation";
            this.cmbMillLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbMillLocation.TabIndex = 4;
            // 
            // cmbWallThickness
            // 
            this.cmbWallThickness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWallThickness.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWallThickness.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWallThickness.FormattingEnabled = true;
            this.cmbWallThickness.Location = new System.Drawing.Point(121, 235);
            this.cmbWallThickness.Name = "cmbWallThickness";
            this.cmbWallThickness.Size = new System.Drawing.Size(121, 21);
            this.cmbWallThickness.TabIndex = 8;
            // 
            // cmbCoating
            // 
            this.cmbCoating.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCoating.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCoating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCoating.FormattingEnabled = true;
            this.cmbCoating.Location = new System.Drawing.Point(121, 262);
            this.cmbCoating.Name = "cmbCoating";
            this.cmbCoating.Size = new System.Drawing.Size(121, 21);
            this.cmbCoating.TabIndex = 9;
            // 
            // cmbGrade
            // 
            this.cmbGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(121, 289);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 21);
            this.cmbGrade.TabIndex = 10;
            // 
            // txtHeat
            // 
            this.txtHeat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHeat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtHeat.Location = new System.Drawing.Point(119, 316);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(123, 20);
            this.txtHeat.TabIndex = 11;
            // 
            // cmbANSI
            // 
            this.cmbANSI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbANSI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbANSI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbANSI.FormattingEnabled = true;
            this.cmbANSI.Location = new System.Drawing.Point(121, 342);
            this.cmbANSI.Name = "cmbANSI";
            this.cmbANSI.Size = new System.Drawing.Size(121, 21);
            this.cmbANSI.TabIndex = 12;
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.Location = new System.Drawing.Point(121, 369);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(121, 20);
            this.txtPurchaseOrder.TabIndex = 13;
            // 
            // cmbStandard
            // 
            this.cmbStandard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStandard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStandard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStandard.FormattingEnabled = true;
            this.cmbStandard.Location = new System.Drawing.Point(119, 396);
            this.cmbStandard.Name = "cmbStandard";
            this.cmbStandard.Size = new System.Drawing.Size(121, 21);
            this.cmbStandard.TabIndex = 14;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(42, 108);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 14;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblMillLocation
            // 
            this.lblMillLocation.AutoSize = true;
            this.lblMillLocation.Location = new System.Drawing.Point(47, 135);
            this.lblMillLocation.Name = "lblMillLocation";
            this.lblMillLocation.Size = new System.Drawing.Size(69, 13);
            this.lblMillLocation.TabIndex = 15;
            this.lblMillLocation.Text = "Mill Location:";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(12, 157);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(103, 13);
            this.lblProductDescription.TabIndex = 16;
            this.lblProductDescription.Text = "Product Description:";
            // 
            // lblWeldSeamType
            // 
            this.lblWeldSeamType.AutoSize = true;
            this.lblWeldSeamType.Location = new System.Drawing.Point(23, 184);
            this.lblWeldSeamType.Name = "lblWeldSeamType";
            this.lblWeldSeamType.Size = new System.Drawing.Size(92, 13);
            this.lblWeldSeamType.TabIndex = 17;
            this.lblWeldSeamType.Text = "Weld Seam Type:";
            // 
            // lblWallThickness
            // 
            this.lblWallThickness.AutoSize = true;
            this.lblWallThickness.Location = new System.Drawing.Point(32, 238);
            this.lblWallThickness.Name = "lblWallThickness";
            this.lblWallThickness.Size = new System.Drawing.Size(83, 13);
            this.lblWallThickness.TabIndex = 18;
            this.lblWallThickness.Text = "Wall Thickness:";
            // 
            // lblCoating
            // 
            this.lblCoating.AutoSize = true;
            this.lblCoating.Location = new System.Drawing.Point(69, 265);
            this.lblCoating.Name = "lblCoating";
            this.lblCoating.Size = new System.Drawing.Size(46, 13);
            this.lblCoating.TabIndex = 19;
            this.lblCoating.Text = "Coating:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(76, 292);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.Text = "Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Outer Dimension:";
            // 
            // lblHeat
            // 
            this.lblHeat.AutoSize = true;
            this.lblHeat.Location = new System.Drawing.Point(80, 319);
            this.lblHeat.Name = "lblHeat";
            this.lblHeat.Size = new System.Drawing.Size(33, 13);
            this.lblHeat.TabIndex = 22;
            this.lblHeat.Text = "Heat:";
            // 
            // lblANSI
            // 
            this.lblANSI.AutoSize = true;
            this.lblANSI.Location = new System.Drawing.Point(45, 345);
            this.lblANSI.Name = "lblANSI";
            this.lblANSI.Size = new System.Drawing.Size(70, 13);
            this.lblANSI.TabIndex = 23;
            this.lblANSI.Text = "ANSI/ASME:";
            // 
            // lblPurchasePrder
            // 
            this.lblPurchasePrder.AutoSize = true;
            this.lblPurchasePrder.Location = new System.Drawing.Point(31, 372);
            this.lblPurchasePrder.Name = "lblPurchasePrder";
            this.lblPurchasePrder.Size = new System.Drawing.Size(84, 13);
            this.lblPurchasePrder.TabIndex = 24;
            this.lblPurchasePrder.Text = "Purchase Order:";
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(62, 398);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(53, 13);
            this.lblStandard.TabIndex = 25;
            this.lblStandard.Text = "Standard:";
            // 
            // cmbJobName
            // 
            this.cmbJobName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobName.BackColor = System.Drawing.SystemColors.Window;
            this.cmbJobName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.Location = new System.Drawing.Point(121, 62);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(121, 21);
            this.cmbJobName.TabIndex = 1;
            this.cmbJobName.SelectedIndexChanged += new System.EventHandler(this.cmbJobName_SelectedIndexChanged_1);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(63, 65);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(58, 13);
            this.lblJobName.TabIndex = 27;
            this.lblJobName.Text = "Job Name:";
            // 
            // menuStrip1
            // 
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
            this.addFieldToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
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
            this.addFieldToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 640);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 376);
            this.dataGridView1.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Standard:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Purchase Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "ANSI/ASME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Heat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Outer Dimension:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Grade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Coating:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Wall Thickness:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Weld Seam Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Product Description:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Mill Location:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(475, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Manufacturer:";
            // 
            // txtLastJobInput
            // 
            this.txtLastJobInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastJobInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastJobInput.Location = new System.Drawing.Point(554, 70);
            this.txtLastJobInput.Name = "txtLastJobInput";
            this.txtLastJobInput.ReadOnly = true;
            this.txtLastJobInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastJobInput.TabIndex = 57;
            this.txtLastJobInput.TabStop = false;
            // 
            // txtLastManufacturerInput
            // 
            this.txtLastManufacturerInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastManufacturerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastManufacturerInput.Location = new System.Drawing.Point(554, 96);
            this.txtLastManufacturerInput.Name = "txtLastManufacturerInput";
            this.txtLastManufacturerInput.ReadOnly = true;
            this.txtLastManufacturerInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastManufacturerInput.TabIndex = 58;
            this.txtLastManufacturerInput.TabStop = false;
            // 
            // txtLastMillLocationInput
            // 
            this.txtLastMillLocationInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastMillLocationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastMillLocationInput.Location = new System.Drawing.Point(554, 122);
            this.txtLastMillLocationInput.Name = "txtLastMillLocationInput";
            this.txtLastMillLocationInput.ReadOnly = true;
            this.txtLastMillLocationInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastMillLocationInput.TabIndex = 59;
            this.txtLastMillLocationInput.TabStop = false;
            // 
            // txtLastProductDescriptionInput
            // 
            this.txtLastProductDescriptionInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastProductDescriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastProductDescriptionInput.Location = new System.Drawing.Point(554, 147);
            this.txtLastProductDescriptionInput.Name = "txtLastProductDescriptionInput";
            this.txtLastProductDescriptionInput.ReadOnly = true;
            this.txtLastProductDescriptionInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastProductDescriptionInput.TabIndex = 60;
            this.txtLastProductDescriptionInput.TabStop = false;
            // 
            // txtLastWeldSeamTypeInput
            // 
            this.txtLastWeldSeamTypeInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastWeldSeamTypeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastWeldSeamTypeInput.Location = new System.Drawing.Point(554, 173);
            this.txtLastWeldSeamTypeInput.Name = "txtLastWeldSeamTypeInput";
            this.txtLastWeldSeamTypeInput.ReadOnly = true;
            this.txtLastWeldSeamTypeInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastWeldSeamTypeInput.TabIndex = 61;
            this.txtLastWeldSeamTypeInput.TabStop = false;
            // 
            // txtLastOuterDimensionInput
            // 
            this.txtLastOuterDimensionInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastOuterDimensionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastOuterDimensionInput.Location = new System.Drawing.Point(554, 199);
            this.txtLastOuterDimensionInput.Name = "txtLastOuterDimensionInput";
            this.txtLastOuterDimensionInput.ReadOnly = true;
            this.txtLastOuterDimensionInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastOuterDimensionInput.TabIndex = 62;
            this.txtLastOuterDimensionInput.TabStop = false;
            // 
            // txtLastWallThicknessInput
            // 
            this.txtLastWallThicknessInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastWallThicknessInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastWallThicknessInput.Location = new System.Drawing.Point(554, 224);
            this.txtLastWallThicknessInput.Name = "txtLastWallThicknessInput";
            this.txtLastWallThicknessInput.ReadOnly = true;
            this.txtLastWallThicknessInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastWallThicknessInput.TabIndex = 63;
            this.txtLastWallThicknessInput.TabStop = false;
            // 
            // txtLastCoatingIput
            // 
            this.txtLastCoatingIput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastCoatingIput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastCoatingIput.Location = new System.Drawing.Point(554, 251);
            this.txtLastCoatingIput.Name = "txtLastCoatingIput";
            this.txtLastCoatingIput.ReadOnly = true;
            this.txtLastCoatingIput.Size = new System.Drawing.Size(100, 13);
            this.txtLastCoatingIput.TabIndex = 64;
            this.txtLastCoatingIput.TabStop = false;
            // 
            // txtLastGradeInput
            // 
            this.txtLastGradeInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastGradeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastGradeInput.Location = new System.Drawing.Point(554, 277);
            this.txtLastGradeInput.Name = "txtLastGradeInput";
            this.txtLastGradeInput.ReadOnly = true;
            this.txtLastGradeInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastGradeInput.TabIndex = 65;
            this.txtLastGradeInput.TabStop = false;
            // 
            // txtLastHeatinput
            // 
            this.txtLastHeatinput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastHeatinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastHeatinput.Location = new System.Drawing.Point(554, 303);
            this.txtLastHeatinput.Name = "txtLastHeatinput";
            this.txtLastHeatinput.ReadOnly = true;
            this.txtLastHeatinput.Size = new System.Drawing.Size(100, 13);
            this.txtLastHeatinput.TabIndex = 66;
            this.txtLastHeatinput.TabStop = false;
            // 
            // txtLastPurchaseOrderInput
            // 
            this.txtLastPurchaseOrderInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastPurchaseOrderInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastPurchaseOrderInput.Location = new System.Drawing.Point(554, 355);
            this.txtLastPurchaseOrderInput.Name = "txtLastPurchaseOrderInput";
            this.txtLastPurchaseOrderInput.ReadOnly = true;
            this.txtLastPurchaseOrderInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastPurchaseOrderInput.TabIndex = 67;
            this.txtLastPurchaseOrderInput.TabStop = false;
            // 
            // txtLastAnsiAsmeInput
            // 
            this.txtLastAnsiAsmeInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastAnsiAsmeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastAnsiAsmeInput.Location = new System.Drawing.Point(554, 329);
            this.txtLastAnsiAsmeInput.Name = "txtLastAnsiAsmeInput";
            this.txtLastAnsiAsmeInput.ReadOnly = true;
            this.txtLastAnsiAsmeInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastAnsiAsmeInput.TabIndex = 68;
            this.txtLastAnsiAsmeInput.TabStop = false;
            // 
            // txtLastStandardInput
            // 
            this.txtLastStandardInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastStandardInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastStandardInput.Location = new System.Drawing.Point(554, 381);
            this.txtLastStandardInput.Name = "txtLastStandardInput";
            this.txtLastStandardInput.ReadOnly = true;
            this.txtLastStandardInput.Size = new System.Drawing.Size(100, 13);
            this.txtLastStandardInput.TabIndex = 69;
            this.txtLastStandardInput.TabStop = false;
            // 
            // btnRefreshJobName
            // 
            this.btnRefreshJobName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshJobName.BackgroundImage")));
            this.btnRefreshJobName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshJobName.Location = new System.Drawing.Point(248, 62);
            this.btnRefreshJobName.Name = "btnRefreshJobName";
            this.btnRefreshJobName.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshJobName.TabIndex = 2;
            this.btnRefreshJobName.UseVisualStyleBackColor = true;
            this.btnRefreshJobName.Click += new System.EventHandler(this.btnRefreshJobName_Click);
            // 
            // dgMasterGridView
            // 
            this.dgMasterGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMasterGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMasterGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasterGridView.Location = new System.Drawing.Point(961, 60);
            this.dgMasterGridView.Name = "dgMasterGridView";
            this.dgMasterGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterGridView.Size = new System.Drawing.Size(611, 526);
            this.dgMasterGridView.TabIndex = 101;
            // 
            // lblMasterDataGrid
            // 
            this.lblMasterDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasterDataGrid.AutoSize = true;
            this.lblMasterDataGrid.Location = new System.Drawing.Point(1245, 44);
            this.lblMasterDataGrid.Name = "lblMasterDataGrid";
            this.lblMasterDataGrid.Size = new System.Drawing.Size(69, 13);
            this.lblMasterDataGrid.TabIndex = 72;
            this.lblMasterDataGrid.Text = "Master Table";
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchJob.Location = new System.Drawing.Point(1379, 601);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(75, 23);
            this.btnSearchJob.TabIndex = 19;
            this.btnSearchJob.Text = "Search Job";
            this.btnSearchJob.UseVisualStyleBackColor = true;
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchJob.Location = new System.Drawing.Point(1130, 604);
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(243, 20);
            this.txtSearchJob.TabIndex = 18;
            // 
            // lblDgJobTitle
            // 
            this.lblDgJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDgJobTitle.AutoSize = true;
            this.lblDgJobTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDgJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgJobTitle.Location = new System.Drawing.Point(12, 603);
            this.lblDgJobTitle.Name = "lblDgJobTitle";
            this.lblDgJobTitle.Size = new System.Drawing.Size(111, 24);
            this.lblDgJobTitle.TabIndex = 75;
            this.lblDgJobTitle.Text = "Job Name:";
            // 
            // btnSearchMaster
            // 
            this.btnSearchMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMaster.Location = new System.Drawing.Point(1460, 601);
            this.btnSearchMaster.Name = "btnSearchMaster";
            this.btnSearchMaster.Size = new System.Drawing.Size(112, 23);
            this.btnSearchMaster.TabIndex = 20;
            this.btnSearchMaster.Text = "Search Master";
            this.btnSearchMaster.UseVisualStyleBackColor = true;
            this.btnSearchMaster.Click += new System.EventHandler(this.btnSearchMaster_Click);
            // 
            // btnRefreshInput
            // 
            this.btnRefreshInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshInput.Location = new System.Drawing.Point(246, 398);
            this.btnRefreshInput.Name = "btnRefreshInput";
            this.btnRefreshInput.Size = new System.Drawing.Size(123, 20);
            this.btnRefreshInput.TabIndex = 100;
            this.btnRefreshInput.Text = "Refresh Selections";
            this.btnRefreshInput.UseVisualStyleBackColor = true;
            this.btnRefreshInput.Click += new System.EventHandler(this.btnRefreshInput_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Location = new System.Drawing.Point(1445, 1022);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(103, 23);
            this.btnExportToExcel.TabIndex = 500;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnAddToCurrentJob
            // 
            this.btnAddToCurrentJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddToCurrentJob.Location = new System.Drawing.Point(792, 564);
            this.btnAddToCurrentJob.Name = "btnAddToCurrentJob";
            this.btnAddToCurrentJob.Size = new System.Drawing.Size(163, 23);
            this.btnAddToCurrentJob.TabIndex = 17;
            this.btnAddToCurrentJob.Text = "Add Selection To Current Job";
            this.btnAddToCurrentJob.UseVisualStyleBackColor = true;
            this.btnAddToCurrentJob.Click += new System.EventHandler(btnAddToCurrentJob_Click);
            // 
            // cmbProductDescription
            // 
            this.cmbProductDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProductDescription.FormattingEnabled = true;
            this.cmbProductDescription.Location = new System.Drawing.Point(121, 154);
            this.cmbProductDescription.Name = "cmbProductDescription";
            this.cmbProductDescription.Size = new System.Drawing.Size(121, 21);
            this.cmbProductDescription.TabIndex = 5;
            // 
            // cmbWeldSeamType
            // 
            this.cmbWeldSeamType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWeldSeamType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWeldSeamType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWeldSeamType.FormattingEnabled = true;
            this.cmbWeldSeamType.Location = new System.Drawing.Point(121, 181);
            this.cmbWeldSeamType.Name = "cmbWeldSeamType";
            this.cmbWeldSeamType.Size = new System.Drawing.Size(121, 21);
            this.cmbWeldSeamType.TabIndex = 6;
            // 
            // cmbOuterDimension
            // 
            this.cmbOuterDimension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOuterDimension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOuterDimension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOuterDimension.FormattingEnabled = true;
            this.cmbOuterDimension.Location = new System.Drawing.Point(119, 208);
            this.cmbOuterDimension.Name = "cmbOuterDimension";
            this.cmbOuterDimension.Size = new System.Drawing.Size(121, 21);
            this.cmbOuterDimension.TabIndex = 7;
            // 
            // txtLastNotesInput
            // 
            this.txtLastNotesInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastNotesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastNotesInput.Location = new System.Drawing.Point(551, 410);
            this.txtLastNotesInput.Multiline = true;
            this.txtLastNotesInput.Name = "txtLastNotesInput";
            this.txtLastNotesInput.Size = new System.Drawing.Size(262, 96);
            this.txtLastNotesInput.TabIndex = 502;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(512, 410);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(33, 13);
            this.lblNotes.TabIndex = 503;
            this.lblNotes.Text = "Note:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(80, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 505;
            this.label15.Text = "Note:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(119, 424);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(301, 20);
            this.txtNotes.TabIndex = 506;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1584, 1054);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtLastNotesInput);
            this.Controls.Add(this.cmbOuterDimension);
            this.Controls.Add(this.cmbWeldSeamType);
            this.Controls.Add(this.cmbProductDescription);
            this.Controls.Add(this.btnAddToCurrentJob);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnRefreshInput);
            this.Controls.Add(this.btnSearchMaster);
            this.Controls.Add(this.lblDgJobTitle);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.lblMasterDataGrid);
            this.Controls.Add(this.dgMasterGridView);
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
            this.Controls.Add(this.dataGridView1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BomApplication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridView dgMasterGridView;
        private System.Windows.Forms.Label lblMasterDataGrid;
        private System.Windows.Forms.Button btnSearchJob;
        private System.Windows.Forms.TextBox txtSearchJob;
        private System.Windows.Forms.Label lblDgJobTitle;
        private System.Windows.Forms.Button btnSearchMaster;
        private System.Windows.Forms.Button btnRefreshInput;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnAddToCurrentJob;
        private System.Windows.Forms.ComboBox cmbProductDescription;
        private System.Windows.Forms.ComboBox cmbWeldSeamType;
        private System.Windows.Forms.ComboBox cmbOuterDimension;
        private System.Windows.Forms.TextBox txtLastNotesInput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNotes;
    }
}

