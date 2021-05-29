
namespace PakistaniTwitter_CSharp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUploadTweets = new System.Windows.Forms.Button();
            this.btnFollowUsers = new System.Windows.Forms.Button();
            this.lblcloseWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(242, 160);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(266, 51);
            this.btnManageUsers.TabIndex = 6;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploadTweets
            // 
            this.btnUploadTweets.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUploadTweets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUploadTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadTweets.ForeColor = System.Drawing.Color.White;
            this.btnUploadTweets.Location = new System.Drawing.Point(242, 221);
            this.btnUploadTweets.Name = "btnUploadTweets";
            this.btnUploadTweets.Size = new System.Drawing.Size(266, 51);
            this.btnUploadTweets.TabIndex = 6;
            this.btnUploadTweets.Text = "Upload Tweets";
            this.btnUploadTweets.UseVisualStyleBackColor = false;
            this.btnUploadTweets.Click += new System.EventHandler(this.btnUploadTweets_Click);
            // 
            // btnFollowUsers
            // 
            this.btnFollowUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFollowUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFollowUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollowUsers.ForeColor = System.Drawing.Color.White;
            this.btnFollowUsers.Location = new System.Drawing.Point(242, 278);
            this.btnFollowUsers.Name = "btnFollowUsers";
            this.btnFollowUsers.Size = new System.Drawing.Size(266, 51);
            this.btnFollowUsers.TabIndex = 6;
            this.btnFollowUsers.Text = "Follow Users";
            this.btnFollowUsers.UseVisualStyleBackColor = false;
            this.btnFollowUsers.Click += new System.EventHandler(this.btnFollowUsers_Click);
            // 
            // lblcloseWin
            // 
            this.lblcloseWin.AutoSize = true;
            this.lblcloseWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloseWin.ForeColor = System.Drawing.Color.Red;
            this.lblcloseWin.Location = new System.Drawing.Point(771, 9);
            this.lblcloseWin.Name = "lblcloseWin";
            this.lblcloseWin.Size = new System.Drawing.Size(17, 16);
            this.lblcloseWin.TabIndex = 7;
            this.lblcloseWin.Text = "X";
            this.lblcloseWin.Click += new System.EventHandler(this.lblcloseWin_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcloseWin);
            this.Controls.Add(this.btnFollowUsers);
            this.Controls.Add(this.btnUploadTweets);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUploadTweets;
        private System.Windows.Forms.Button btnFollowUsers;
        private System.Windows.Forms.Label lblcloseWin;
    }
}