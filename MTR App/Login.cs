using MTR_APP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.UserCreds))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT Count (*) from dbo.UserCreds WHERE Username=@Username AND Password=@Password AND IsActive=1";

                    Credentials logIn = new Credentials();

                    String hashedPassword = logIn.GenHash(txtPassword.Text, logIn.salt);

                    // Parameters
                    logIn.Username = txtUserName.Text;
                    logIn.Password = hashedPassword;

                    SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50);
                    SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarChar, 50);

                    pUsername.Value = logIn.Username;
                    pPassword.Value = hashedPassword;

                    cmd.Parameters.Add(pUsername);
                    cmd.Parameters.Add(pPassword);

                    cmd.Connection = con;

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Login Success");
                        this.Hide();
                        MainForm fMainForm = new MainForm();
                        fMainForm.Show();
                    }
                    else
                    {
                        //If Count doesn't == 1 then show

                        //Incorrect login Credentials
                        MessageBox.Show(this, "Incorrect Username or Password! Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Refocus Username TxtBox, makes user interface easier
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnLogin_Click(sender, e);
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register fRegister = new Register();
            fRegister.Show();
        }
    }
}