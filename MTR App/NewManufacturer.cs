using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewManufacturer : Form
    {
        public NewManufacturer()
        {
            InitializeComponent();
        }

        private void btnSubmitJobName_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[Manufacturer] ([Manufacturer]) VALUES (@Manufacturer) ", con);
                cmd.Parameters.AddWithValue("@Manufacturer", txtCreateManufacturer.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Manufacturer Added!");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitJobName.PerformClick();
        }
    }
}