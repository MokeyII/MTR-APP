using System;
using System.Data;
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
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Manufacturer] ([Manufacturer]) VALUES (@Manufacturer)";
                    cmd.Connection = con;

                    SqlParameter pManufacturer = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);

                    pManufacturer.Value = txtCreateManufacturer.Text;

                    cmd.Parameters.Add(pManufacturer);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Manufacturer Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitJobName.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Manufacturer] ([Manufacturer]) VALUES (@Manufacturer)";
                    cmd.Connection = con;

                    SqlParameter pManufacturer = new SqlParameter("@Manufacturer", SqlDbType.VarChar, 50);

                    pManufacturer.Value = txtCreateManufacturer.Text;

                    cmd.Parameters.Add(pManufacturer);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Manufacturer Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCreateManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitJobName_Click(sender, e);
            }
        }
    }
}