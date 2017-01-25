using System;
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

        private void btnFolderBrowserDiag_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void ImportExcelSheet_Load(object sender, EventArgs e)
        {
        }
    }
}