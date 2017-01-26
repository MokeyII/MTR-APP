using MTR_App;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_APP
{
    public partial class MainForm : Form
    {
        private SqlDataAdapter myDA;

        private DataTable myDT;

        public MainForm()
        {
            InitializeComponent();
        }


        // Testing|
        private void zProgressbar()
        {

        }


        // Populate All Combo Boxes

        #region ComboBoxPopulate

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

        #endregion ComboBoxPopulate

        //Export Job Table to Excel
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

        //Search Job Table
        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "] WHERE ([Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%' OR [Notes] LIKE'" + txtNotes.Text + "')";

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

        // Search Master Table
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
                    dgMasterGridBun.DataSource = myDT;

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

        //Insert New Item in Job && Master
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[" + cmbJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    // Connection to DB
                    cmd.CommandText.Replace("\\s+", " ");

                    //Parameters
                    cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                    cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                    cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription.Text);
                    cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType.Text);
                    cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension.Text);
                    cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                    cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                    cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                    cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                    cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                    cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.ToString());
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

                    //Parameters
                    cmd.Parameters.AddWithValue("@JobName", cmbJobName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                    cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                    cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription.Text);
                    cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType.Text);
                    cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension.Text);
                    cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                    cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                    cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                    cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                    cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                    cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.ToString());

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
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable]";
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
                    dgMasterGridBun.DataSource = myDT;

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

        //Insert To Job From Master Table
        private void btnAddToCurrentJob_Click(object sender, EventArgs e)
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

                    //Parameters
                    cmd.Parameters.AddWithValue("@Manufacturer", vMnuf);
                    cmd.Parameters.AddWithValue("@MillLocation", vML);
                    cmd.Parameters.AddWithValue("@ProductDescription", vPD);
                    cmd.Parameters.AddWithValue("@WeldSeamType", vWST);
                    cmd.Parameters.AddWithValue("@OuterDimension", vOD);
                    cmd.Parameters.AddWithValue("@WallThickness", vWT);
                    cmd.Parameters.AddWithValue("@Coating", vCoat);
                    cmd.Parameters.AddWithValue("@Grade", vGrad);
                    cmd.Parameters.AddWithValue("@Heat", vHeat);
                    cmd.Parameters.AddWithValue("@ANSIASME", vAnsi);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", vPO);
                    cmd.Parameters.AddWithValue("@Standard", vSTD);
                    cmd.Parameters.AddWithValue("@Notes", vNote);

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

                    //Parameters
                    cmd.Parameters.AddWithValue("@JobName", cmbJobName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", vMnuf);
                    cmd.Parameters.AddWithValue("@MillLocation", vML);
                    cmd.Parameters.AddWithValue("@ProductDescription", vPD);
                    cmd.Parameters.AddWithValue("@WeldSeamType", vWST);
                    cmd.Parameters.AddWithValue("@OuterDimension", vOD);
                    cmd.Parameters.AddWithValue("@WallThickness", vWT);
                    cmd.Parameters.AddWithValue("@Coating", vCoat);
                    cmd.Parameters.AddWithValue("@Grade", vGrad);
                    cmd.Parameters.AddWithValue("@Heat", vHeat);
                    cmd.Parameters.AddWithValue("@ANSIASME", vAnsi);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", vPO);
                    cmd.Parameters.AddWithValue("@Standard", vSTD);
                    cmd.Parameters.AddWithValue("@Notes", vNote);

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

                    lblDgJobTitle.Text = cmbJobName.Text.ToString();
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
                    dgMasterGridBun.DataSource = myDT;

                    //AutoSize Datagrid Rows and Colums to fit the Datagrid
                    //dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgMasterGridBun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

                    lblDgJobTitle.Text = cmbJobName.Text.ToString();
                }
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                    dgMasterGridBun.DataSource = myDT;

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

        #region EnterKeyDownSubmit

        private void cmbANSI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbCoating_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbMillLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbOuterDimension1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbProductDescription1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbStandard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbWallThickness_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cmbWeldSeamType1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void txtHeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void txtPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        #endregion EnterKeyDownSubmit

        #region Show New Forms Btn

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Job fNew_Job = new New_Job();
            fNew_Job.Show();
        }

        private void aNSIASMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAnsiAsme fAnsiAsme = new NewAnsiAsme();
            fAnsiAsme.Show();
        }

        private void coatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCoating fCoating = new NewCoating();
            fCoating.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGrade fGrade = new NewGrade();
            fGrade.Show();
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewManufacturer fManufacturer = new NewManufacturer();
            fManufacturer.Show();
        }

        private void millLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMillLocation fMillLocation = new NewMillLocation();
            fMillLocation.Show();
        }

        private void productDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductDescription fProductDescription = new NewProductDescription();
            fProductDescription.Show();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStandard fStandard = new NewStandard();
            fStandard.Show();
        }

        private void wallThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWallThickness fWallThickness = new NewWallThickness();
            fWallThickness.Show();
        }

        private void weldSeamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWeldSeamType fWeldSeamType = new NewWeldSeamType();
            fWeldSeamType.Show();
        }

        #endregion Show New Forms Btn

        private void btnRefreshInput_Click(object sender, EventArgs e)
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

        private void importFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmitBun_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[" + cmbJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    // Connection to DB
                    cmd.CommandText.Replace("\\s+", " ");

                    //Parameters
                    cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                    cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                    cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription.Text);
                    cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType.Text);
                    cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension.Text);
                    cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                    cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                    cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                    cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                    cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                    cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.ToString());
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

                    //Parameters
                    cmd.Parameters.AddWithValue("@JobName", cmbJobName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                    cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                    cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription.Text);
                    cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType.Text);
                    cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension.Text);
                    cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                    cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                    cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                    cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                    cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                    cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.ToString());

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
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable]";
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
                    dgMasterGridBun.DataSource = myDT;

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void btnAddSelectionBun_Click(object sender, EventArgs e)
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

                    //Parameters
                    cmd.Parameters.AddWithValue("@Manufacturer", vMnuf);
                    cmd.Parameters.AddWithValue("@MillLocation", vML);
                    cmd.Parameters.AddWithValue("@ProductDescription", vPD);
                    cmd.Parameters.AddWithValue("@WeldSeamType", vWST);
                    cmd.Parameters.AddWithValue("@OuterDimension", vOD);
                    cmd.Parameters.AddWithValue("@WallThickness", vWT);
                    cmd.Parameters.AddWithValue("@Coating", vCoat);
                    cmd.Parameters.AddWithValue("@Grade", vGrad);
                    cmd.Parameters.AddWithValue("@Heat", vHeat);
                    cmd.Parameters.AddWithValue("@ANSIASME", vAnsi);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", vPO);
                    cmd.Parameters.AddWithValue("@Standard", vSTD);
                    cmd.Parameters.AddWithValue("@Notes", vNote);

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
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MasterTable] ([Job Name], [Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@JobName,@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard,@Notes)";

                    cmd.Connection = con;

                    //Parameters
                    cmd.Parameters.AddWithValue("@JobName", cmbJobName.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", vMnuf);
                    cmd.Parameters.AddWithValue("@MillLocation", vML);
                    cmd.Parameters.AddWithValue("@ProductDescription", vPD);
                    cmd.Parameters.AddWithValue("@WeldSeamType", vWST);
                    cmd.Parameters.AddWithValue("@OuterDimension", vOD);
                    cmd.Parameters.AddWithValue("@WallThickness", vWT);
                    cmd.Parameters.AddWithValue("@Coating", vCoat);
                    cmd.Parameters.AddWithValue("@Grade", vGrad);
                    cmd.Parameters.AddWithValue("@Heat", vHeat);
                    cmd.Parameters.AddWithValue("@ANSIASME", vAnsi);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", vPO);
                    cmd.Parameters.AddWithValue("@Standard", vSTD);
                    cmd.Parameters.AddWithValue("@Notes", vNote);

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

                    lblDgJobTitle.Text = cmbJobName.Text.ToString();
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
                    dgMasterGridBun.DataSource = myDT;

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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[" + cmbJobName.Text + "] WHERE ([Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%' OR [Notes] LIKE'" + txtNotes.Text + "')";

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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM dbo.[MasterTable] WHERE ([Job Name] LIKE '" + txtSearchJob.Text + "%' OR [Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%' OR [Notes] LIKE'" + txtNotes.Text + "')";

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
                    dgMasterGridBun.DataSource = myDT;

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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
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
    }
}