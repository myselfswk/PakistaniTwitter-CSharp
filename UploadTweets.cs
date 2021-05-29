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
    public partial class UploadTweets : Form
    {
        SqlConnection conn;
        public UploadTweets()
        {
            InitializeComponent();
        }

        private void UploadTweets_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTweet_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "Insert into [PakistaniTwitterDB].[dbo].[Tweets_PakistaniTwitter] (T_id, subject, content) values ('" + txtTweetID.Text + "','" + txtSub.Text + "','"+ txtCon.Text +"')";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Your Tweet is Uploaded!");

                txtTweetID.Text = "";
                txtSub.Text = "";
                txtCon.Text = "";
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

        private void btnUpdateTweet_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "update [PakistaniTwitterDB].[dbo].[Tweets_PakistaniTwitter] set T_id='"+ txtTweetID.Text +"', subject='"+ txtSub.Text +"', content='"+ txtCon.Text +"' where T_id='"+ txtTweetID.Text +"'";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Tweet is Updated!");

                txtTweetID.Text = "";
                txtSub.Text = "";
                txtCon.Text = "";
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

        private void btnDelTweet_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "delete [PakistaniTwitterDB].[dbo].[Tweets_PakistaniTwitter] where T_id='"+ txtTweetID.Text +"'";
                sqlCommand.Connection = conn;

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Tweet is Deleted!");

                txtTweetID.Text = "";
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

        private void btnSearchTweets_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-QG8ONMB;Initial Catalog=PakistaniTwitterDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();

                conn.Open();

                sqlCommand.CommandText = "select * from [PakistaniTwitterDB].[dbo].[Tweets_PakistaniTwitter] where subject='"+ txtSearchUser.Text +"'";
                sqlCommand.Connection = conn;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                dGVTweets.DataSource = dataTable;
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

                sqlCommand.CommandText = "select * from [PakistaniTwitterDB].[dbo].[Tweets_PakistaniTwitter]";
                sqlCommand.Connection = conn;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dGVTweets.DataSource = dataTable;
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
