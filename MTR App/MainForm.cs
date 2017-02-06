using MTR_App;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_APP
{
    public partial class MainForm : Form
    {
        #region Storing Variables

        private SqlDataAdapter myDA;
        private DataTable myDT;

        private SqlDataAdapter masterDA;
        private DataTable masterDT;

        #endregion Storing Variables

        public MainForm()
        {
            InitializeComponent();
        }

        #region Animated Side Panel

        private void btnInsertJobSidePanel_Click(object sender, EventArgs e)
        {
            //if (sidemenu.Width == 50)
            //{
            //    //EXPAND
            //    // Expand the panel
            //    //Show the Logo

            //    sidemenu.Visible = false;
            //    sidemenu.Width = 375;
            //    panelTransition.ShowSync(sidemenu);
            //    logoTransition.ShowSync(logo);
            //}
            //else
            //{
            //    //COLLAPSE
            //    //Using Bunifu Animator
            //    // 1. Hide the logo.
            //    // 2. Slide the Panel

            //    logoTransition.Hide(logo);
            //    sidemenu.Visible = false;
            //    sidemenu.Width = 50;
            //    panelTransition.ShowSync(sidemenu);
            //}
        }

        #endregion Animated Side Panel

        #region Combo Box Populate

        //Populate Ansi / ASME Combo Box
        private void zAnsiAsmeCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[AnsiAsme] ORDER by [ANSI/ASME] ASC";
                    cmd.Connection = con;
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Add ANSI / ASME ComboItems to combo box.
                        cmbANSI.Items.Add(reader["ANSI/ASME"].ToString());
                    }

                    //Close Connection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zCoatingCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[Coating] ORDER by [Coating] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbCoating.Items.Add(reader["Coating"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zGradeCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[Grade] ORDER by [Grade] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbGrade.Items.Add(reader["Grade"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zManufacturerCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[Manufacturer] ORDER by [Manufacturer] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbManufacturer.Items.Add(reader["Manufacturer"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zMillLocationCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[MillLocation] ORDER by [Mill Location] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbMillLocation.Items.Add(reader["Mill Location"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zOuterDimensionCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[OuterDimension] ORDER by [SortOrder] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbOuterDimension.Items.Add(reader["Outer Dimension"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zProductDescriptionCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[ProductDescription] ORDER by [Product Description] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbProductDescription.Items.Add(reader["Product Description"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zStandardCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[Standard] ORDER by [Standard] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbStandard.Items.Add(reader["Standard"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zWallThicknessCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[WallThickness] ORDER by [Wall Thickness] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbWallThickness.Items.Add(reader["Wall Thickness"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zWeldSeamTypeCombo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM [dbo].[WeldSeamType] ORDER by [Weld Seam type] ASC";
                    cmd.Connection = con;

                    //Datareader Execute with connection and slection
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Read from Department Dropdown box
                        cmbWeldSeamType.Items.Add(reader["Weld Seam Type"].ToString());
                    }

                    //Close COnnection
                    con.Close();
                }
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Combo Box Populate

        #region Export to Excel

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < dgJobGridBun.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgJobGridBun.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 0)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgJobGridBun.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgJobGridBun.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        #endregion Export to Excel

        #region Form Load Event

        private void Form1_Load(object sender, EventArgs e)
        {
            zManufacturerCombo();
            zMillLocationCombo();
            zProductDescriptionCombo();
            zWeldSeamTypeCombo();
            zOuterDimensionCombo();
            zWallThicknessCombo();
            zCoatingCombo();
            zGradeCombo();
            zAnsiAsmeCombo();
            zStandardCombo();
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable]";
                    cmd.Connection = con;

                    //DataAdapter
                    masterDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    masterDA.SelectCommand = myCMD;

                    //Define Datatable
                    masterDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(masterDA);

                    //Teach Command builder to be a boss!
                    masterDA.UpdateCommand = cb.GetUpdateCommand();
                    masterDA.InsertCommand = cb.GetInsertCommand();
                    masterDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    masterDA.Fill(masterDT);

                    //Fill DataTable with Database Schema
                    masterDA.FillSchema(masterDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgMasterGridBun.DataSource = masterDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    dgMasterGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //////////////////////////////////////////////////////////////////////////
            /////////////////////      Populate Job Name ComboBox    /////////////////
            //////////////////////////////////////////////////////////////////////////

            //Select Table
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                    cmd.Connection = con;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbJobName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbJobName.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Form Load Event

        #region Header Bar Buttons

        private void btnCloseApp_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeApp_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        #endregion Header Bar Buttons

        #region Job Combo Box Changed

        private void cmbJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "]";
                    cmd.Connection = con;

                    //DataAdapter
                    myDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    myDA.SelectCommand = myCMD;

                    //Define Datatable
                    myDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(myDA);

                    //Teach Command builder to be a boss!
                    myDA.UpdateCommand = cb.GetUpdateCommand();
                    myDA.InsertCommand = cb.GetInsertCommand();
                    myDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    myDA.Fill(myDT);

                    //Fill DataTable with Database Schema
                    myDA.FillSchema(myDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgJobGridBun.DataSource = myDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    // Resize the master DataGridView columns to fit the newly loaded data.
                    dgMasterGridBun.AutoResizeColumns();

                    // Configure the details DataGridView so that its columns automatically
                    // adjust their widths when the data changes.
                    dgMasterGridBun.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Job Combo Box Changed

        #region Perfrom clicks

        //Perform Clicks
        private void cmbManufacturer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbMillLocation_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbProductDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbWeldSeamType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbOuterDimension_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbWallThickness_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbCoating_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbGrade_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void txtHeat_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbANSI_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void txtPurchaseOrder_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void cmbStandard_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        #endregion Perfrom clicks

        #region Push from Master to Current

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            string ID = dgMasterGridBun.SelectedRows[0].Cells[0].Value + string.Empty;
            string JN = dgMasterGridBun.SelectedRows[0].Cells[1].Value + string.Empty;
            string Mnuf = dgMasterGridBun.SelectedRows[0].Cells[2].Value + string.Empty;
            string ML = dgMasterGridBun.SelectedRows[0].Cells[3].Value + string.Empty;
            string PD = dgMasterGridBun.SelectedRows[0].Cells[4].Value + string.Empty;
            string WST = dgMasterGridBun.SelectedRows[0].Cells[5].Value + string.Empty;
            string OD = dgMasterGridBun.SelectedRows[0].Cells[6].Value + string.Empty;
            string WT = dgMasterGridBun.SelectedRows[0].Cells[7].Value + string.Empty;
            string Coat = dgMasterGridBun.SelectedRows[0].Cells[8].Value + string.Empty;
            string Grad = dgMasterGridBun.SelectedRows[0].Cells[9].Value + string.Empty;
            string Heat = dgMasterGridBun.SelectedRows[0].Cells[10].Value + string.Empty;
            string Ansi = dgMasterGridBun.SelectedRows[0].Cells[12].Value + string.Empty;
            string PO = dgMasterGridBun.SelectedRows[0].Cells[13].Value + string.Empty;
            string STD = dgMasterGridBun.SelectedRows[0].Cells[14].Value + string.Empty;
            string Note = dgMasterGridBun.SelectedRows[0].Cells[15].Value + string.Empty;

            var vID = ID;
            var vJN = JN;
            var vMnuf = Mnuf;
            var vML = ML;
            var vPD = PD;
            var vWST = WST;
            var vOD = OD;
            var vWT = WT;
            var vCoat = Coat;
            var vGrad = Grad;
            var vHeat = Heat;
            var vAnsi = Ansi;
            var vPO = PO;
            var vSTD = STD;
            var vNote = Note;

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[" + cmbJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard, @Notes)";

                    cmd.Connection = con;

                    SqlParameter pManufactuter = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);
                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);
                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);
                    SqlParameter pWeldSeamType = new SqlParameter("@WeldSeamType", SqlDbType.VarChar, 50);
                    SqlParameter pOuterDimension = new SqlParameter("@OuterDimension", SqlDbType.VarChar, 50);
                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);
                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);
                    SqlParameter pGrade = new SqlParameter("@Grade", SqlDbType.VarChar, 50);
                    SqlParameter pHeat = new SqlParameter("@Heat", SqlDbType.VarChar, 50);
                    SqlParameter pAnsiAsme = new SqlParameter("@ANSIASME", SqlDbType.VarChar, 50);
                    SqlParameter pPurchaseOrder = new SqlParameter("@PurchaseOrder", SqlDbType.VarChar, 50);
                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);
                    SqlParameter pNotes = new SqlParameter("@Notes", SqlDbType.VarChar, 50);

                    pManufactuter.Value = vMnuf;
                    pMillLocation.Value = vML;
                    pProductDescription.Value = vPD;
                    pWeldSeamType.Value = vWST;
                    pOuterDimension.Value = vOD;
                    pWallThickness.Value = vWT;
                    pCoating.Value = vCoat;
                    pGrade.Value = vGrad;
                    pHeat.Value = vHeat;
                    pAnsiAsme.Value = vAnsi;
                    pPurchaseOrder.Value = vPO;
                    pStandard.Value = vSTD;
                    pNotes.Value = vNote;

                    cmd.Parameters.Add(pManufactuter);
                    cmd.Parameters.Add(pMillLocation);
                    cmd.Parameters.Add(pProductDescription);
                    cmd.Parameters.Add(pWeldSeamType);
                    cmd.Parameters.Add(pOuterDimension);
                    cmd.Parameters.Add(pWallThickness);
                    cmd.Parameters.Add(pCoating);
                    cmd.Parameters.Add(pGrade);
                    cmd.Parameters.Add(pHeat);
                    cmd.Parameters.Add(pAnsiAsme);
                    cmd.Parameters.Add(pPurchaseOrder);
                    cmd.Parameters.Add(pStandard);
                    cmd.Parameters.Add(pNotes);

                    //execute
                    cmd.ExecuteNonQuery();

                    //close connection
                    con.Close();

                    MessageBox.Show("" + vPD + " \nfrom " + vJN + " \nwith Heat Number: " + vHeat + " \nhas been transferred from the master table to \n" + cmbJobName.Text + "!");

                    cmbManufacturer.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "INSERT INTO " + vJN + " SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /// insert into Master Table
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MasterTable] ([Job Name], [Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@JobName,@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    SqlParameter pJobName = new SqlParameter("@JobName", SqlDbType.VarChar, 50);
                    SqlParameter pManufactuter = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);
                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);
                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);
                    SqlParameter pWeldSeamType = new SqlParameter("@WeldSeamType", SqlDbType.VarChar, 50);
                    SqlParameter pOuterDimension = new SqlParameter("@OuterDimension", SqlDbType.VarChar, 50);
                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);
                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);
                    SqlParameter pGrade = new SqlParameter("@Grade", SqlDbType.VarChar, 50);
                    SqlParameter pHeat = new SqlParameter("@Heat", SqlDbType.VarChar, 50);
                    SqlParameter pAnsiAsme = new SqlParameter("@ANSIASME", SqlDbType.VarChar, 50);
                    SqlParameter pPurchaseOrder = new SqlParameter("@PurchaseOrder", SqlDbType.VarChar, 50);
                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);
                    SqlParameter pNotes = new SqlParameter("@Notes", SqlDbType.VarChar, 50);

                    pJobName.Value = cmbJobName.Text;
                    pManufactuter.Value = vMnuf;
                    pMillLocation.Value = vML;
                    pProductDescription.Value = vPD;
                    pWeldSeamType.Value = vWST;
                    pOuterDimension.Value = vOD;
                    pWallThickness.Value = vWT;
                    pCoating.Value = vCoat;
                    pGrade.Value = vGrad;
                    pHeat.Value = vHeat;
                    pAnsiAsme.Value = vAnsi;
                    pPurchaseOrder.Value = vPO;
                    pStandard.Value = vSTD;
                    pNotes.Value = vNote;

                    cmd.Parameters.Add(pJobName);
                    cmd.Parameters.Add(pManufactuter);
                    cmd.Parameters.Add(pMillLocation);
                    cmd.Parameters.Add(pProductDescription);
                    cmd.Parameters.Add(pWeldSeamType);
                    cmd.Parameters.Add(pOuterDimension);
                    cmd.Parameters.Add(pWallThickness);
                    cmd.Parameters.Add(pCoating);
                    cmd.Parameters.Add(pGrade);
                    cmd.Parameters.Add(pHeat);
                    cmd.Parameters.Add(pAnsiAsme);
                    cmd.Parameters.Add(pPurchaseOrder);
                    cmd.Parameters.Add(pStandard);
                    cmd.Parameters.Add(pNotes);

                    cmd.CommandText.Replace("\\s+", " ");

                    //execute
                    cmd.ExecuteNonQuery();

                    //close connection
                    con.Close();

                    //REPEAT SUBMITTED INFORMATION TO TEXT BOXES FOR REVIEW. //REPEAT SUBMITTED INFORMATION TO TEXT BOXES FOR REVIEW.
                    txtLastJobInput.Text = cmbJobName.Text;
                    txtLastManufacturerInput.Text = vML;
                    txtLastMillLocationInput.Text = vPD;
                    txtLastProductDescriptionInput.Text = vPD;
                    txtLastWeldSeamTypeInput.Text = vWST;
                    txtLastOuterDimensionInput.Text = vOD;
                    txtLastWallThicknessInput.Text = vWT;
                    txtLastCoatingIput.Text = vCoat;
                    txtLastGradeInput.Text = vGrad;
                    txtLastHeatinput.Text = vHeat;
                    txtLastAnsiAsmeInput.Text = vAnsi;
                    txtLastPurchaseOrderInput.Text = vPO;
                    txtLastStandardInput.Text = vSTD;
                    txtLastNotesInput.Text = vNote;
                    txtLastJobInput.Text = cmbJobName.Text;
                    txtLastManufacturerInput.Text = vML;
                    txtLastMillLocationInput.Text = vPD;
                    txtLastProductDescriptionInput.Text = vPD;
                    txtLastWeldSeamTypeInput.Text = vWST;
                    txtLastOuterDimensionInput.Text = vOD;
                    txtLastWallThicknessInput.Text = vWT;
                    txtLastCoatingIput.Text = vCoat;
                    txtLastGradeInput.Text = vGrad;
                    txtLastHeatinput.Text = vHeat;
                    txtLastAnsiAsmeInput.Text = vAnsi;
                    txtLastPurchaseOrderInput.Text = vPO;
                    txtLastStandardInput.Text = vSTD;
                    txtLastNotesInput.Text = vNote;
                }
            }
            catch (Exception ex)
            {
                //catch error
                MessageBox.Show(this, ex.Message, "INSERT INTO MASTER SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "]";
                    cmd.Connection = con;

                    //DataAdapter
                    myDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    myDA.SelectCommand = myCMD;

                    //Define Datatable
                    myDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(myDA);

                    //Teach Command builder to be a boss!
                    myDA.UpdateCommand = cb.GetUpdateCommand();
                    myDA.InsertCommand = cb.GetInsertCommand();
                    myDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    myDA.Fill(myDT);

                    //Fill DataTable with Database Schema
                    myDA.FillSchema(myDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgJobGridBun.DataSource = myDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    dgJobGridBun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgJobGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "REFRESH JOB LIST SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable]";
                    cmd.Connection = con;

                    //DataAdapter
                    masterDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    masterDA.SelectCommand = myCMD;

                    //Define Datatable
                    masterDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(masterDA);

                    //Teach Command builder to be a boss!
                    masterDA.UpdateCommand = cb.GetUpdateCommand();
                    masterDA.InsertCommand = cb.GetInsertCommand();
                    masterDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    masterDA.Fill(masterDT);

                    //Fill DataTable with Database Schema
                    masterDA.FillSchema(masterDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgMasterGridBun.DataSource = masterDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    //dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgMasterGridBun.AutoResizeColumns();

                    // Configure the details DataGridView so that its columns automatically
                    // adjust their widths when the data changes.
                    dgMasterGridBun.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "REFRESH MASTER SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbManufacturer.Text = String.Empty;
            cmbMillLocation.Text = String.Empty;
            cmbProductDescription.Text = String.Empty;
            cmbWeldSeamType.Text = String.Empty;
            cmbOuterDimension.Text = String.Empty;
            cmbWallThickness.Text = String.Empty;
            cmbCoating.Text = String.Empty;
            cmbGrade.Text = String.Empty;
            txtHeat.Clear();
            cmbANSI.Text = String.Empty;
            txtHeat.Clear();
            txtPurchaseOrder.Clear();
            cmbStandard.Text = String.Empty;
            txtNotes.Clear();
        }

        #endregion Push from Master to Current

        #region Refresh Combo Boxes

        // Refresh Combo Buttons
        private void btnRefreshComboBoxes_Click(object sender, EventArgs e)
        {
            cmbManufacturer.Items.Clear();
            cmbMillLocation.Items.Clear();
            cmbProductDescription.Items.Clear();
            cmbWeldSeamType.Items.Clear();
            cmbOuterDimension.Items.Clear();
            cmbWallThickness.Items.Clear();
            cmbCoating.Items.Clear();
            cmbGrade.Items.Clear();
            cmbANSI.Items.Clear();
            cmbStandard.Items.Clear();

            zManufacturerCombo();
            zMillLocationCombo();
            zProductDescriptionCombo();
            zWeldSeamTypeCombo();
            zOuterDimensionCombo();
            zWallThicknessCombo();
            zCoatingCombo();
            zGradeCombo();
            zAnsiAsmeCombo();
            zStandardCombo();
        }

        #endregion Refresh Combo Boxes

        #region Refresh Job List

        // RefreshJob Name ComboBox
        private void btnRefreshJobName_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                    cmd.Connection = con;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbJobName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbJobName.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Refresh Job List

        #region Search Job Table

        //Search Job Table
        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "] WHERE ([Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%' OR [Notes] LIKE'" + txtSearchJob.Text + "')";

                    cmd.Connection = con;

                    myDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    myDA.SelectCommand = myCMD;

                    //Define Datatable
                    myDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(myDA);

                    //Teach Command builder to be a boss!
                    myDA.UpdateCommand = cb.GetUpdateCommand();
                    myDA.InsertCommand = cb.GetInsertCommand();
                    myDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    myDA.Fill(myDT);

                    //Fill DataTable with Database Schema
                    myDA.FillSchema(myDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgJobGridBun.DataSource = myDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    dgJobGridBun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgJobGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Search Job Table

        #region Search Master Table

        private void btnSearchMaster_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable] WHERE ([Job Name] LIKE '" + txtSearchJob.Text + "%' OR [Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%' OR [Notes] LIKE'" + txtNotes.Text + "')";

                    cmd.Connection = con;
                    masterDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    masterDA.SelectCommand = myCMD;

                    //Define Datatable
                    masterDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(masterDA);

                    //Teach Command builder to be a boss!
                    masterDA.UpdateCommand = cb.GetUpdateCommand();
                    masterDA.InsertCommand = cb.GetInsertCommand();
                    masterDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    masterDA.Fill(masterDT);

                    //Fill DataTable with Database Schema
                    masterDA.FillSchema(masterDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgMasterGridBun.DataSource = masterDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    dgMasterGridBun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgMasterGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Search Master Table

        #region Show New Forms Btn

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Job fNew_Job = new New_Job();
            fNew_Job.ShowDialog();
        }

        private void aNSIASMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAnsiAsme fAnsiAsme = new NewAnsiAsme();
            fAnsiAsme.ShowDialog();
        }

        private void coatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCoating fCoating = new NewCoating();
            fCoating.ShowDialog();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGrade fGrade = new NewGrade();
            fGrade.ShowDialog();
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewManufacturer fManufacturer = new NewManufacturer();
            fManufacturer.ShowDialog();
        }

        private void millLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMillLocation fMillLocation = new NewMillLocation();
            fMillLocation.ShowDialog();
        }

        private void productDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductDescription fProductDescription = new NewProductDescription();
            fProductDescription.ShowDialog();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStandard fStandard = new NewStandard();
            fStandard.ShowDialog();
        }

        private void wallThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWallThickness fWallThickness = new NewWallThickness();
            fWallThickness.ShowDialog();
        }

        private void weldSeamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWeldSeamType fWeldSeamType = new NewWeldSeamType();
            fWeldSeamType.ShowDialog();
        }

        private void importFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExcel fImportExcel = new ImportExcel();
            fImportExcel.ShowDialog();
        }

        #endregion Show New Forms Btn

        #region Submit Fields to Databases

        private void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[" + cmbJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    SqlParameter pManufactuter = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);
                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);
                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);
                    SqlParameter pWeldSeamType = new SqlParameter("@WeldSeamType", SqlDbType.VarChar, 50);
                    SqlParameter pOuterDimension = new SqlParameter("@OuterDimension", SqlDbType.VarChar, 50);
                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);
                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);
                    SqlParameter pGrade = new SqlParameter("@Grade", SqlDbType.VarChar, 50);
                    SqlParameter pHeat = new SqlParameter("@Heat", SqlDbType.VarChar, 50);
                    SqlParameter pAnsiAsme = new SqlParameter("@ANSIASME", SqlDbType.VarChar, 50);
                    SqlParameter pPurchaseOrder = new SqlParameter("@PurchaseOrder", SqlDbType.VarChar, 50);
                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);
                    SqlParameter pNotes = new SqlParameter("@Notes", SqlDbType.VarChar, 50);

                    pManufactuter.Value = cmbManufacturer.Text;
                    pMillLocation.Value = cmbMillLocation.Text;
                    pProductDescription.Value = cmbProductDescription.Text;
                    pWeldSeamType.Value = cmbWeldSeamType.Text;
                    pOuterDimension.Value = cmbOuterDimension.Text;
                    pWallThickness.Value = cmbWallThickness.Text;
                    pCoating.Value = cmbCoating.Text;
                    pGrade.Value = cmbGrade.Text;
                    pHeat.Value = txtHeat.Text;
                    pAnsiAsme.Value = cmbANSI.Text;
                    pPurchaseOrder.Value = txtPurchaseOrder.Text;
                    pStandard.Value = cmbStandard.Text;
                    pNotes.Value = txtNotes.Text;

                    cmd.Parameters.Add(pManufactuter);
                    cmd.Parameters.Add(pMillLocation);
                    cmd.Parameters.Add(pProductDescription);
                    cmd.Parameters.Add(pWeldSeamType);
                    cmd.Parameters.Add(pOuterDimension);
                    cmd.Parameters.Add(pWallThickness);
                    cmd.Parameters.Add(pCoating);
                    cmd.Parameters.Add(pGrade);
                    cmd.Parameters.Add(pHeat);
                    cmd.Parameters.Add(pAnsiAsme);
                    cmd.Parameters.Add(pPurchaseOrder);
                    cmd.Parameters.Add(pStandard);
                    cmd.Parameters.Add(pNotes);

                    // Connection to DB
                    cmd.CommandText.Replace("\\s+", " ");

                    //REPEAT SUBMITTED INFORMATION TO TEXT BOXES FOR REVIEW.
                    txtLastJobInput.Text = cmbJobName.Text.ToString();
                    txtLastManufacturerInput.Text = cmbManufacturer.Text.ToString();
                    txtLastMillLocationInput.Text = cmbMillLocation.Text.ToString();
                    txtLastProductDescriptionInput.Text = cmbProductDescription.Text.ToString();
                    txtLastWeldSeamTypeInput.Text = cmbWeldSeamType.Text.ToString();
                    txtLastOuterDimensionInput.Text = cmbOuterDimension.Text.ToString();
                    txtLastWallThicknessInput.Text = cmbWallThickness.Text.ToString();
                    txtLastCoatingIput.Text = cmbCoating.Text.ToString();
                    txtLastGradeInput.Text = cmbGrade.Text.ToString();
                    txtLastHeatinput.Text = txtHeat.Text.ToString();
                    txtLastAnsiAsmeInput.Text = cmbANSI.Text.ToString();
                    txtLastPurchaseOrderInput.Text = txtPurchaseOrder.Text.ToString();
                    txtLastStandardInput.Text = cmbStandard.Text.ToString();
                    txtLastNotesInput.Text = txtNotes.Text.ToString();

                    //execute
                    cmd.ExecuteNonQuery();

                    //close connection
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //catch error
                MessageBox.Show(ex.Message);
            }
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "]";
                    cmd.Connection = con;

                    //DataAdapter
                    myDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    myDA.SelectCommand = myCMD;

                    //Define Datatable
                    myDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(myDA);

                    //Teach Command builder to be a boss!
                    myDA.UpdateCommand = cb.GetUpdateCommand();
                    myDA.InsertCommand = cb.GetInsertCommand();
                    myDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    myDA.Fill(myDT);

                    //Fill DataTable with Database Schema
                    myDA.FillSchema(myDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgJobGridBun.DataSource = myDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    dgJobGridBun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgJobGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MasterTable] ([Job Name], [Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@JobName,@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    SqlParameter pJobName = new SqlParameter("@JobName", System.Data.SqlDbType.VarChar, 50);
                    SqlParameter pManufactuter = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);
                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);
                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);
                    SqlParameter pWeldSeamType = new SqlParameter("@WeldSeamType", SqlDbType.VarChar, 50);
                    SqlParameter pOuterDimension = new SqlParameter("@OuterDimension", SqlDbType.VarChar, 50);
                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);
                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);
                    SqlParameter pGrade = new SqlParameter("@Grade", SqlDbType.VarChar, 50);
                    SqlParameter pHeat = new SqlParameter("@Heat", SqlDbType.VarChar, 50);
                    SqlParameter pAnsiAsme = new SqlParameter("@ANSIASME", SqlDbType.VarChar, 50);
                    SqlParameter pPurchaseOrder = new SqlParameter("@PurchaseOrder", SqlDbType.VarChar, 50);
                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);
                    SqlParameter pNotes = new SqlParameter("@Notes", SqlDbType.VarChar, 50);

                    pJobName.Value = cmbJobName.Text;
                    pManufactuter.Value = cmbManufacturer.Text;
                    pMillLocation.Value = cmbMillLocation.Text;
                    pProductDescription.Value = cmbProductDescription.Text;
                    pWeldSeamType.Value = cmbWeldSeamType.Text;
                    pOuterDimension.Value = cmbOuterDimension.Text;
                    pWallThickness.Value = cmbWallThickness.Text;
                    pCoating.Value = cmbCoating.Text;
                    pGrade.Value = cmbGrade.Text;
                    pHeat.Value = txtHeat.Text;
                    pAnsiAsme.Value = cmbANSI.Text;
                    pPurchaseOrder.Value = txtPurchaseOrder.Text;
                    pStandard.Value = cmbStandard.Text;
                    pNotes.Value = txtNotes.Text;

                    cmd.Parameters.Add(pJobName);
                    cmd.Parameters.Add(pManufactuter);
                    cmd.Parameters.Add(pMillLocation);
                    cmd.Parameters.Add(pProductDescription);
                    cmd.Parameters.Add(pWeldSeamType);
                    cmd.Parameters.Add(pOuterDimension);
                    cmd.Parameters.Add(pWallThickness);
                    cmd.Parameters.Add(pCoating);
                    cmd.Parameters.Add(pGrade);
                    cmd.Parameters.Add(pHeat);
                    cmd.Parameters.Add(pAnsiAsme);
                    cmd.Parameters.Add(pPurchaseOrder);
                    cmd.Parameters.Add(pStandard);
                    cmd.Parameters.Add(pNotes);

                    cmd.CommandText.Replace("\\s+", " ");

                    //execute
                    cmd.ExecuteNonQuery();

                    //close connection
                }
            }
            catch (SqlException ex)
            {
                //catch error
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable]";
                    cmd.Connection = con;

                    //DataAdapter
                    masterDA = new SqlDataAdapter(cmd.CommandText, con);

                    //MySqlCommand
                    SqlCommand myCMD = new SqlCommand(cmd.CommandText, con);

                    //DataAdapter to Command
                    masterDA.SelectCommand = myCMD;

                    //Define Datatable
                    masterDT = new DataTable();

                    //Command Builder (IS GOD!)
                    SqlCommandBuilder cb = new SqlCommandBuilder(masterDA);

                    //Teach Command builder to be a boss!
                    masterDA.UpdateCommand = cb.GetUpdateCommand();
                    masterDA.InsertCommand = cb.GetInsertCommand();
                    masterDA.DeleteCommand = cb.GetDeleteCommand();

                    //Fill the DataTable with DataAdapter information
                    masterDA.Fill(masterDT);

                    //Fill DataTable with Database Schema
                    masterDA.FillSchema(masterDT, SchemaType.Source);

                    //Bind The Data Table to the DataGrid
                    dgMasterGridBun.DataSource = masterDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    //dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgMasterGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbManufacturer.Text = String.Empty;
            cmbMillLocation.Text = String.Empty;
            cmbProductDescription.Text = String.Empty;
            cmbWeldSeamType.Text = String.Empty;
            cmbOuterDimension.Text = String.Empty;
            cmbWallThickness.Text = String.Empty;
            cmbCoating.Text = String.Empty;
            cmbGrade.Text = String.Empty;
            txtHeat.Clear();
            cmbANSI.Text = String.Empty;
            txtHeat.Clear();
            txtPurchaseOrder.Clear();
            cmbStandard.Text = String.Empty;
            txtNotes.Clear();
            cmbManufacturer.Focus();
        }

        #endregion Submit Fields to Databases

        #region Update Tables

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            int rows = myDA.Update(myDT);
        }

        private void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            int rows = masterDA.Update(masterDT);
        }

        #endregion Update Tables
    }
}