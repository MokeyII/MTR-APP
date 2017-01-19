using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewMillLocation : Form
    {
        public NewMillLocation()
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
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[MillLocation] ([Mill Location]) VALUES (@MillLocation) ", con);
                cmd.Parameters.AddWithValue("@MillLocation", txtCreateMillLocation.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Mill Location Added!");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}