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

namespace MTR_App
{
    public partial class NewCoating : Form
    {
        public NewCoating()
        {
            InitializeComponent();
        }

        private void btnSubmitCoating_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[Coating] ([Coating]) VALUES (@Coating) ", con);
                cmd.Parameters.AddWithValue("@Coating", txtCreateCoating.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Coating Added!");
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
