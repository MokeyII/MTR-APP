using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MTR_App
{
    public partial class ImportExcelSheet : Form
    {
        public ImportExcelSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strExcelConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + richTextBox1.Text + ";Extended Properties='Excel 8.0;HDR=Yes'";

            OleDbConnection connExcel = new OleDbConnection(strExcelConn);

            OleDbCommand cmdExcel = new OleDbCommand();

            cmdExcel.Connection = connExcel;

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            connExcel.Close();

            DataSet ds = new DataSet();


            string SheetName = dtExcelSchema.Rows[3][5].ToString();
            cmdExcel.CommandText = "SELECT Manufacturer, Name From [" + SheetName + "]";

            OleDbDataAdapter da = new OleDbDataAdapter();

            da.SelectCommand = cmdExcel;

            da.Fill(ds);

            string Manufacturer = ds.Tables[0].Columns[0].ColumnName.ToString();
            string MillLocation = ds.Tables[0].Rows[0][0].ToString();
            string ProductDescription = ds.Tables[0].Rows[5][2].ToString();
            string WeldSeamType = ds.Tables[0].Rows[2][0].ToString();
            string OuterDimension = ds.Tables[0].Rows[3][0].ToString();
            string WallThickness = ds.Tables[0].Rows[4][0].ToString();
            string Coating = ds.Tables[0].Rows[4][0].ToString();
            string Grade = ds.Tables[0].Rows[4][0].ToString();
            string Heat = ds.Tables[0].Rows[4][0].ToString();
            string ANSI_ASME = ds.Tables[0].Rows[4][0].ToString();
            string PurchaseOrder = ds.Tables[0].Rows[4][0].ToString();
            string Standard = ds.Tables[0].Rows[4][0].ToString();
            string Notes = ds.Tables[0].Rows[4][0].ToString();

            textBox1.Text = Manufacturer;
            textBox2.Text = ProductDescription;
            //insert this data into sql database 
        }

        private void btnFolderBrowserDiag_Click(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    string filename = fileDialog.FileName;

                    richTextBox1.Text = fileDialog.FileName;
                }

                ////Show Folder Browser Dialog Box on Click
                //DialogResult btnFolderDir_Click = openFileDialog1.ShowDialog();
                //        if (btnFolderDir_Click == DialogResult.OK)
                //        {
                //            //Clear Dir Text Box if new directory is selected.
                //            txtImportFolderBrowserDiag.Clear();

                //            //Convert selection of FBD to string
                //            string[] files = System.IO.Directory.GetFiles(openFileDialog1.ToString());

                //            //Put string into textbox
                //            txtImportFolderBrowserDiag.Text = openFileDialog1.ToString();
                //        }
            }
        }
    }
}