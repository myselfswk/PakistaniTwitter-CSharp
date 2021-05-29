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

namespace PakistaniTwitter_CSharp
{
    public partial class SignUpForm : Form
    {
        SqlConnection conn;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "Insert into [User_PakistaniTwitter] (name, password, email) values ('" + txtUserName.Text + "', '" + txtPass.Text + "', '" + txtEmail.Text + "')";
                sqlCommand.Connection = conn;

                conn.Open();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Data Enter Successfully");

                txtUserName.Text = "";
                txtPass.Text = "";
                txtEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
