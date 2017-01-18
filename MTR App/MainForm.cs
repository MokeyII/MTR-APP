using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MTR_App;

namespace MTR_APP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter myDA;
        DataTable myDT;



        #region ComboBoxPopulate
        void zManufacturerCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[Manufacturer] ORDER by [Manufacturer] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zMillLocationCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[MillLocation] ORDER by [Mill Location] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zProductDescriptionCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[ProductDescription] ORDER by [Product Description] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

                //Datareader Execute with connection and slection
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Read from Department Dropdown box
                    cmbProductDescription1.Items.Add(reader["Product Description"].ToString());
                }

                //Close COnnection
                con.Close();
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zWeldSeamTypeCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[WeldSeamType] ORDER by [Weld Seam type] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

                //Datareader Execute with connection and slection
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Read from Department Dropdown box
                    cmbWeldSeamType1.Items.Add(reader["Weld Seam Type"].ToString());
                }

                //Close COnnection
                con.Close();
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zOuterDimensionCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[OuterDimension] ORDER by [SortOrder] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

                //Datareader Execute with connection and slection
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Read from Department Dropdown box
                    cmbOuterDimension1.Items.Add(reader["Outer Dimension"].ToString());
                }

                //Close COnnection
                con.Close();
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zWallThicknessCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[WallThickness] ORDER by [Wall Thickness] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zCoatingCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[Coating] ORDER by [Coating] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zGradeCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[Grade] ORDER by [Grade] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zAnsiAsmeCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[AnsiAsme] ORDER by [ANSI/ASME] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

                //Datareader Execute with connection and slection
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Read from Department Dropdown box
                    cmbANSI.Items.Add(reader["ANSI/ASME"].ToString());
                }

                //Close COnnection
                con.Close();
            }

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void zStandardCombo()
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");
                //Insert Query
                string selectQuery = "SELECT * FROM [dbo].[Standard] ORDER by [Standard] ASC";

                //Open Connection
                con.Open();

                //Command
                SqlCommand cmd = new SqlCommand(selectQuery, con);

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

            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
                //Insert Query
                string insertquery = "INSERT INTO dbo.[" + cmbJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard)";

                SqlCommand cmd = new SqlCommand(insertquery, con);

                //open connection
                con.Open();

                //Parameters
                cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription1.Text);
                cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType1.Text);
                cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension1.Text);
                cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);

                //REPEAT SUBMITTED INFORMATION TO TEXT BOXES FOR REVIEW.
                txtLastJobInput.Text = cmbJobName.Text.ToString();
                txtLastManufacturerInput.Text = cmbManufacturer.Text.ToString();
                txtLastMillLocationInput.Text = cmbMillLocation.Text.ToString();
                txtLastProductDescriptionInput.Text = cmbProductDescription1.Text.ToString();
                txtLastWeldSeamTypeInput.Text = cmbWeldSeamType1.Text.ToString();
                txtLastOuterDimensionInput.Text = cmbOuterDimension1.Text.ToString();
                txtLastWallThicknessInput.Text = cmbWallThickness.Text.ToString();
                txtLastCoatingIput.Text = cmbCoating.Text.ToString();
                txtLastGradeInput.Text = cmbGrade.Text.ToString();
                txtLastHeatinput.Text = txtHeat.Text.ToString();
                txtLastAnsiAsmeInput.Text = cmbANSI.Text.ToString();
                txtLastPurchaseOrderInput.Text = txtPurchaseOrder.Text.ToString();
                txtLastStandardInput.Text = cmbStandard.Text.ToString();


                //execute
                cmd.ExecuteNonQuery();

                MessageBox.Show("Line Submitted, Datagrid Will now re-populate!");

                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                //catch error
                MessageBox.Show(ex.Message);
            }
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[" + cmbJobName.Text + "]";
                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dataGridView1.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Connection to DB
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
                //Insert Query
                string insertquery = "INSERT INTO dbo.[MasterTable] ([Job Name], [Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard]) VALUES(@JobName,@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard)";

                SqlCommand cmd = new SqlCommand(insertquery, con);

                //open connection
                con.Open();

                //Parameters
                cmd.Parameters.AddWithValue("@JobName", cmbJobName.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", cmbManufacturer.Text);
                cmd.Parameters.AddWithValue("@MillLocation", cmbMillLocation.Text);
                cmd.Parameters.AddWithValue("@ProductDescription", cmbProductDescription1.Text);
                cmd.Parameters.AddWithValue("@WeldSeamType", cmbWeldSeamType1.Text);
                cmd.Parameters.AddWithValue("@OuterDimension", cmbOuterDimension1.Text);
                cmd.Parameters.AddWithValue("@WallThickness", cmbWallThickness.Text);
                cmd.Parameters.AddWithValue("@Coating", cmbCoating.Text);
                cmd.Parameters.AddWithValue("@Grade", cmbGrade.Text);
                cmd.Parameters.AddWithValue("@Heat", txtHeat.Text);
                cmd.Parameters.AddWithValue("@ANSIASME", cmbANSI.Text);
                cmd.Parameters.AddWithValue("@PurchaseOrder", txtPurchaseOrder.Text);
                cmd.Parameters.AddWithValue("@Standard", cmbStandard.Text);

                //execute
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                //catch error
                MessageBox.Show(ex.Message);
            }


            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[MasterTable]";

                // string selectQuery = "SELECT [Job Name], [Manufacturer], [Product Description], [Outer Dimension], [Wall Thickness], [Coating], [Heat] FROM [MasterTable]";

                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dgMasterGridView.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                //dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgMasterGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

            //////////////////////////////////////////////////////////////////////////
            /////////////////////      Populate MasterGrid       /////////////////////
            //////////////////////////////////////////////////////////////////////////

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[MasterTable]";

                // string selectQuery = "SELECT [Job Name], [Manufacturer], [Product Description], [Outer Dimension], [Wall Thickness], [Coating], [Heat] FROM [MasterTable]";

                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dgMasterGridView.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                //dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgMasterGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
                //Insert Query
                con.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        cmbJobName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbJobName.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            //Combo Boxes
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Job fNew_Job = new New_Job();
            fNew_Job.Show();
        }

        private void cmbJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[" + cmbJobName.Text + "]";
                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dataGridView1.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                lblDgJobTitle.Text = cmbJobName.Text.ToString();
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshJobName_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
                //Insert Query
                con.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        cmbJobName.Items.Clear();
                        while (reader.Read())
                        {
                            cmbJobName.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }



        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[" + cmbJobName.Text + "] WHERE ([Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%')";
                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dataGridView1.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMaster_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

                string selectQuery = "SELECT * FROM dbo.[MasterTable] WHERE ([Job Name] LIKE '" + txtSearchJob.Text + "%' OR [Manufacturer] LIKE '" + txtSearchJob.Text + "%' OR [Mill Location] LIKE '" + txtSearchJob.Text + "%' OR [Product Description] LIKE '" + txtSearchJob.Text + "%'  OR [Weld Seam Type] LIKE '" + txtSearchJob.Text + "%' OR [Outer Dimension] LIKE '" + txtSearchJob.Text + "%' OR [Wall Thickness] LIKE '" + txtSearchJob.Text + "%' OR [Coating] LIKE '" + txtSearchJob.Text + "%' OR [Grade] LIKE '" + txtSearchJob.Text + "%' OR [Heat] LIKE '" + txtSearchJob.Text + "%' OR [ANSI/ASME] LIKE '" + txtSearchJob.Text + "%' OR [Purchase Order] LIKE '" + txtSearchJob.Text + "%' OR [Standard] LIKE '" + txtSearchJob.Text + "%')";
                //DataAdapter
                myDA = new SqlDataAdapter(selectQuery, con);

                //MySqlCommand
                SqlCommand myCMD = new SqlCommand(selectQuery, con);

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
                dgMasterGridView.DataSource = myDT;

                //AutoSize Datagrid Rows and Colums to fit the Datagrid
                dgMasterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgMasterGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            //Catch Exception
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void weldSeamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWeldSeamType fWeldSeamType = new NewWeldSeamType();
            fWeldSeamType.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGrade fGrade = new NewGrade();
            fGrade.Show();
        }

        private void wallThicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWallThickness fWallThickness = new NewWallThickness();
            fWallThickness.Show();
        }

        private void coatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCoating fCoating = new NewCoating();
            fCoating.Show();
        }

        private void aNSIASMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAnsiAsme fAnsiAsme = new NewAnsiAsme();
            fAnsiAsme.Show();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStandard fStandard = new NewStandard();
            fStandard.Show();
        }

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
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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

        private void btnAddToCurrentJob_Click(object sender, EventArgs e)
        {

            string Selection;
            if (dgMasterGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgMasterGridView.SelectedRows[0];
                Selection = row.Cells[0].Value.ToString();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
                //open connection
                con.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)

                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[" + cmbJobName.Text + "]([Manufacturer],[Mill Location],[Product Description],[Weld Seam Type],[Outer Dimension],[Wall Thickness],[Coating],[Grade],[Heat],[ANSI/ASME],[Purchase Order],[Standard]) VALUES('" + dgMasterGridView.Rows[i].Cells["Manufacturer"].Value + "', '" + dgMasterGridView.Rows[i].Cells["Mill Location"].Value + "','" + dgMasterGridView.Rows[i].Cells["Product Description"].Value + "','" + dgMasterGridView.Rows[i].Cells["Weld Seam Type"].Value + "','" + dgMasterGridView.Rows[i].Cells["Outer Dimension"].Value + "','" + dgMasterGridView.Rows[i].Cells["Wall Thickness"].Value + "','" + dgMasterGridView.Rows[i].Cells["Coating"].Value + "','" + dgMasterGridView.Rows[i].Cells["Grade"].Value + "','" + dgMasterGridView.Rows[i].Cells["Heat"].Value + "','" + dgMasterGridView.Rows[i].Cells["ANSI/ASME"].Value + "','" + dgMasterGridView.Rows[i].Cells["Purchase Order"].Value + "','" + dgMasterGridView.Rows[i].Cells["Standard"].Value + "');", con);


                    cmd.ExecuteNonQuery();

                }
            }



            ///////////////////////////
            //string Selection;
            //if (dgMasterGridView.SelectedRows.Count != 0)
            //{
            //    DataGridViewRow row = this.dgMasterGridView.SelectedRows[0];
            //    Selection = row.Cells[0].Value.ToString();

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");
            //    //open connection
            //    con.Open();
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)

            //    {

            //        SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[" +cmbJobName.Text+ "]([Manufacturer],[Mill Location],[Product Description],[Weld Seam Type],[Outer Dimension],[Wall Thickness],[Coating],[Grade],[Heat],[ANSI/ASME],[Purchase Order],[Standard]) VALUES('"+dgMasterGridView.Rows[i].Cells["Manufacturer"].Value+"', '"+dgMasterGridView.Rows[i].Cells["Mill Location"].Value+"','"+dgMasterGridView.Rows[i].Cells["Product Description"].Value+ "','" + dgMasterGridView.Rows[i].Cells["Weld Seam Type"].Value + "','" + dgMasterGridView.Rows[i].Cells["Outer Dimension"].Value + "','" + dgMasterGridView.Rows[i].Cells["Wall Thickness"].Value + "','" + dgMasterGridView.Rows[i].Cells["Coating"].Value + "','" + dgMasterGridView.Rows[i].Cells["Grade"].Value + "','" + dgMasterGridView.Rows[i].Cells["Heat"].Value + "','" + dgMasterGridView.Rows[i].Cells["ANSI/ASME"].Value + "','" + dgMasterGridView.Rows[i].Cells["Purchase Order"].Value + "','" + dgMasterGridView.Rows[i].Cells["Standard"].Value + "');", con);
                 

            //        cmd.ExecuteNonQuery();

            //    }
            //    //close connection
            //    con.Close();
            //}
        }
    }
}