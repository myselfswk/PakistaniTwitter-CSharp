using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakistaniTwitter_CSharp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblcloseWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void btnUploadTweets_Click(object sender, EventArgs e)
        {
            UploadTweets uploadTweets = new UploadTweets();
            uploadTweets.Show();
        }

        private void btnFollowUsers_Click(object sender, EventArgs e)
        {
            FollowUsers followUsers = new FollowUsers();
            followUsers.Show();
        }
    }
}
