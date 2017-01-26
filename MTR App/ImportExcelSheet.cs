using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class ImportExcelSheet : Form
    {
        public ImportExcelSheet()
        {
            InitializeComponent();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowseFileDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtBrowseFileDir.Text = openFileDialog1.FileName;
            }
        }

        private void btnImportToExcel_Click(object sender, EventArgs e)
        {
            string EPath = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtBrowseFileDir.Text + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\";";
            OleDbConnection conn = new OleDbConnection(EPath);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + txtBoxDoThings.Text + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dgImportExcelGridNorm.DataSource = dt;

            string JN = dgImportExcelGridNorm.Rows[0].Cells[3].Value + string.Empty;

            txtJobName.Text = JN;
        }

        private void ImportExcelSheet_Load(object sender, EventArgs e)
        {
        }

        private void btnImportToSQL_Click(object sender, EventArgs e)
        {
            //Create Job Table
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CREATE TABLE[dbo].[" + txtJobName.Text + "]([Item #] INT NOT NULL PRIMARY KEY IDENTITY,[Manufacturer] VARCHAR(55) NULL,[Mill Location] VARCHAR(55) NULL,[Product Description] VARCHAR(55) NULL,[Weld Seam Type] VARCHAR(55) NULL,[Outer Dimension] VARCHAR(55) NULL,[Wall Thickness] VARCHAR(55) NULL,[Coating] VARCHAR(55) NULL,[Grade] VARCHAR(55) NULL,[Heat] VARCHAR(55) NULL,[i] VARCHAR(1) NULL,[ANSI/ASME] VARCHAR(55) NULL,[Purchase Order] VARCHAR(55) NULL,[Standard] VARCHAR(55) NULL,[Notes] VARCHAR(55) NULL);";
                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();

                    con.Close();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                string Mnuf = dgImportExcelGridNorm.SelectedRows[0].Cells[2].Value.ToString();
                string ML = dgImportExcelGridNorm.SelectedRows[0].Cells[3].Value.ToString();
                string PD = dgImportExcelGridNorm.SelectedRows[0].Cells[4].Value + string.Empty;
                string WST = dgImportExcelGridNorm.SelectedRows[0].Cells[5].Value + string.Empty;
                string OD = dgImportExcelGridNorm.SelectedRows[0].Cells[6].Value + string.Empty;
                string WT = dgImportExcelGridNorm.SelectedRows[0].Cells[7].Value + string.Empty;
                string Coat = dgImportExcelGridNorm.SelectedRows[0].Cells[8].Value + string.Empty;
                string Grad = dgImportExcelGridNorm.SelectedRows[0].Cells[9].Value + string.Empty;
                string Heat = dgImportExcelGridNorm.SelectedRows[0].Cells[10].Value + string.Empty;
                string Ansi = dgImportExcelGridNorm.SelectedRows[0].Cells[12].Value + string.Empty;
                string PO = dgImportExcelGridNorm.SelectedRows[0].Cells[13].Value + string.Empty;
                string STD = dgImportExcelGridNorm.SelectedRows[0].Cells[14].Value + string.Empty;
                string Note = dgImportExcelGridNorm.SelectedRows[0].Cells[15].Value + string.Empty;


            foreach (DataGridViewRow row in dgImportExcelGridNorm.SelectedRows)
            {

                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[" + txtJobName.Text + "] ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) VALUES(@Manufacturer,@MillLocation,@ProductDescription,@WeldSeamType,@OuterDimension,@WallThickness,@Coating,@Grade,@Heat,@ANSIASME,@PurchaseOrder,@Standard, @Notes)";

                    cmd.Connection = con;

                    //Parameters
                    cmd.Parameters.AddWithValue("@Manufacturer", Mnuf);
                    cmd.Parameters.AddWithValue("@MillLocation", ML);
                    cmd.Parameters.AddWithValue("@ProductDescription", PD);
                    cmd.Parameters.AddWithValue("@WeldSeamType", WST);
                    cmd.Parameters.AddWithValue("@OuterDimension", OD);
                    cmd.Parameters.AddWithValue("@WallThickness", WT);
                    cmd.Parameters.AddWithValue("@Coating", Coat);
                    cmd.Parameters.AddWithValue("@Grade", Grad);
                    cmd.Parameters.AddWithValue("@Heat", Heat);
                    cmd.Parameters.AddWithValue("@ANSIASME", Ansi);
                    cmd.Parameters.AddWithValue("@PurchaseOrder", PO);
                    cmd.Parameters.AddWithValue("@Standard", STD);
                    cmd.Parameters.AddWithValue("@Notes", Note);

                    //execute
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}