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
    public partial class ManageUsers : Form
    {
        SqlConnection conn;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "Insert into [PakistaniTwitterDB].[dbo].[User_PakistaniTwitter] (name, password, email) values ('" + txtUsername.Text + "', '" + txtPass.Text + "', '" + txtEmail.Text + "')";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User Add Successfully");

                txtUsername.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "update [PakistaniTwitterDB].[dbo].[User_PakistaniTwitter] set name='" + txtUsername.Text + "', email='" + txtEmail.Text + "', password='" + txtPass.Text + "' where id='" + txtID.Text + "'";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User Successfully Updated");
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "delete [PakistaniTwitterDB].[dbo].[User_PakistaniTwitter] where id='"+ txtID.Text +"'";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User Successfully Deleted!");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "select * from [PakistaniTwitterDB].[dbo].[User_PakistaniTwitter] where name='"+ txtSearchUser.Text +"'";
                sqlCommand.Connection = conn;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dGVUsersShow.DataSource = dataTable;
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

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "select * from [PakistaniTwitterDB].[dbo].[User_PakistaniTwitter]";
                sqlCommand.Connection = conn;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dGVUsersShow.DataSource = dataTable;
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
    }
}
