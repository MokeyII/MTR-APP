﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewWallThickness : Form
    {
        public NewWallThickness()
        {
            InitializeComponent();
        }

        private void btnSubmitWallThickness_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[WallThickness] ([Wall Thickness]) VALUES (@WallThickness) ", con);
                cmd.Parameters.AddWithValue("@WallThickness", txtCreateWallThickness.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Wall Thickness Added!");
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