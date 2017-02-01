using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //true if it doesn't contain letters

            if (txtEmail.Text == "" || txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".") == false)
            {
                MessageBox.Show("Please Enter a valid email address.");
            }
            if (txtUserName.Text == (""))
            {
                MessageBox.Show("Please enter a Username.");
            }
            if (txtPassword.Text == (""))
            {
                MessageBox.Show("You must enter a Password!");
            }
            if (txtConfirmPassword.Text == (""))
            {
                MessageBox.Show("Please Confirm Password!");
            }
            if (txtPassword.Text == txtConfirmPassword.Text && txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
            {
                lblPasswordsDoNotMatch.Hide();
                lblPasswordsMatch.Show();

                try
                {
                    using (SqlConnection con = new SqlConnection(Connection.UserCreds))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO dbo.[UserCreds] ([Username], [Password], [Email]) VALUES(@Username,@Password,@Email)";

                        cmd.Connection = con;

                        Credentials logIn = new Credentials();

                        String hashedPassword = logIn.GenHash(txtPassword.Text, logIn.salt);

                        // Parameters
                        logIn.Username = txtUserName.Text;
                        logIn.Password = hashedPassword;

                        //Parameters

                        cmd.Parameters.AddWithValue("@Username", logIn.Username);
                        cmd.Parameters.AddWithValue("@Password", logIn.Password);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        //execute
                        cmd.ExecuteNonQuery();

                        DialogResult result = MessageBox.Show("Please wait for your account to be activated! ", "Registration Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.OK)
                        {
                            Register fRegister = new Register();
                            fRegister.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            txtEmail.Focus();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblPasswordsMatch.Hide();
                lblPasswordsDoNotMatch.Show();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lblPasswordsMatch.Hide();
            lblPasswordsDoNotMatch.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}