using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewWeldSeamType : Form
    {
        public NewWeldSeamType()
        {
            InitializeComponent();
        }

        private void btnSubmitWeldSeamType_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[WeldSeamType] ([Weld Seam Type]) VALUES (@WeldSeamType) ", con);
                cmd.Parameters.AddWithValue("@WeldSeamType", txtCreateWeldSeamType.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Weld Seam Type Added!");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateWeldSeamType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitWeldSeamType.PerformClick();
        }
    }
}