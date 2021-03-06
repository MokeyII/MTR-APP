﻿using System;
using System.Data;
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
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WallThickness] ([Wall Thickness]) VALUES (@WallThickness)";
                    cmd.Connection = con;

                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);

                    pWallThickness.Value = txtCreateWallThickness.Text;

                    cmd.Parameters.Add(pWallThickness);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Wall Thickness Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewWallThickness_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitWallThickness.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WallThickness] ([Wall Thickness]) VALUES (@WallThickness)";
                    cmd.Connection = con;

                    SqlParameter pWallThickness = new SqlParameter("@WallThickness", SqlDbType.VarChar, 50);

                    pWallThickness.Value = txtCreateWallThickness.Text;

                    cmd.Parameters.Add(pWallThickness);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Wall Thickness Added!");

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

        private void txtCreateWallThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitWallThickness_Click(sender, e);
            }
        }
    }
}