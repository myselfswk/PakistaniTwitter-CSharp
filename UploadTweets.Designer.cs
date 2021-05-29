
namespace PakistaniTwitter_CSharp
{
    partial class UploadTweets
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
            this.lblTweetH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTweetID = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.btnUpdateTweet = new System.Windows.Forms.Button();
            this.btnAddTweet = new System.Windows.Forms.Button();
            this.btnDelTweet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchTweets = new System.Windows.Forms.Button();
            this.dGVTweets = new System.Windows.Forms.DataGridView();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTweets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTweetH
            // 
            this.lblTweetH.AutoSize = true;
            this.lblTweetH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetH.Location = new System.Drawing.Point(78, 9);
            this.lblTweetH.Name = "lblTweetH";
            this.lblTweetH.Size = new System.Drawing.Size(199, 25);
            this.lblTweetH.TabIndex = 1;
            this.lblTweetH.Text = "Tweet Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tweet ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Content";
            // 
            // txtTweetID
            // 
            this.txtTweetID.Location = new System.Drawing.Point(180, 61);
            this.txtTweetID.Name = "txtTweetID";
            this.txtTweetID.Size = new System.Drawing.Size(364, 20);
            this.txtTweetID.TabIndex = 1;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(180, 99);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(364, 20);
            this.txtSub.TabIndex = 2;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(180, 134);
            this.txtCon.Multiline = true;
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(364, 79);
            this.txtCon.TabIndex = 3;
            // 
            // btnUpdateTweet
            // 
            this.btnUpdateTweet.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTweet.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTweet.Location = new System.Drawing.Point(423, 219);
            this.btnUpdateTweet.Name = "btnUpdateTweet";
            this.btnUpdateTweet.Size = new System.Drawing.Size(121, 42);
            this.btnUpdateTweet.TabIndex = 5;
            this.btnUpdateTweet.Text = "Update";
            this.btnUpdateTweet.UseVisualStyleBackColor = false;
            this.btnUpdateTweet.Click += new System.EventHandler(this.btnUpdateTweet_Click);
            // 
            // btnAddTweet
            // 
            this.btnAddTweet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTweet.ForeColor = System.Drawing.Color.White;
            this.btnAddTweet.Location = new System.Drawing.Point(178, 219);
            this.btnAddTweet.Name = "btnAddTweet";
            this.btnAddTweet.Size = new System.Drawing.Size(119, 42);
            this.btnAddTweet.TabIndex = 4;
            this.btnAddTweet.Text = "Add";
            this.btnAddTweet.UseVisualStyleBackColor = false;
            this.btnAddTweet.Click += new System.EventHandler(this.btnAddTweet_Click);
            // 
            // btnDelTweet
            // 
            this.btnDelTweet.BackColor = System.Drawing.Color.Red;
            this.btnDelTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTweet.ForeColor = System.Drawing.Color.White;
            this.btnDelTweet.Location = new System.Drawing.Point(304, 220);
            this.btnDelTweet.Name = "btnDelTweet";
            this.btnDelTweet.Size = new System.Drawing.Size(113, 41);
            this.btnDelTweet.TabIndex = 6;
            this.btnDelTweet.Text = "Delete";
            this.btnDelTweet.UseVisualStyleBackColor = false;
            this.btnDelTweet.Click += new System.EventHandler(this.btnDelTweet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(582, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "*ID Also Use for Delete Tweets";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(620, 148);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(159, 20);
            this.txtSearchUser.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Subject: (For Search Tweets)";
            // 
            // btnSearchTweets
            // 
            this.btnSearchTweets.BackColor = System.Drawing.Color.Blue;
            this.btnSearchTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTweets.ForeColor = System.Drawing.Color.White;
            this.btnSearchTweets.Location = new System.Drawing.Point(649, 174);
            this.btnSearchTweets.Name = "btnSearchTweets";
            this.btnSearchTweets.Size = new System.Drawing.Size(108, 42);
            this.btnSearchTweets.TabIndex = 15;
            this.btnSearchTweets.Text = "Search";
            this.btnSearchTweets.UseVisualStyleBackColor = false;
            this.btnSearchTweets.Click += new System.EventHandler(this.btnSearchTweets_Click);
            // 
            // dGVTweets
            // 
            this.dGVTweets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVTweets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dGVTweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTweets.GridColor = System.Drawing.Color.White;
            this.dGVTweets.Location = new System.Drawing.Point(180, 302);
            this.dGVTweets.Name = "dGVTweets";
            this.dGVTweets.Size = new System.Drawing.Size(364, 182);
            this.dGVTweets.TabIndex = 18;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowAllUsers.Location = new System.Drawing.Point(568, 302);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(241, 66);
            this.btnShowAllUsers.TabIndex = 19;
            this.btnShowAllUsers.Text = "Show All Tweets";
            this.btnShowAllUsers.UseVisualStyleBackColor = false;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // UploadTweets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 515);
            this.Controls.Add(this.btnShowAllUsers);
            this.Controls.Add(this.dGVTweets);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchTweets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelTweet);
            this.Controls.Add(this.btnUpdateTweet);
            this.Controls.Add(this.btnAddTweet);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtTweetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTweetH);
            this.Name = "UploadTweets";
            this.Text = "Upload Tweets-Twitter";
            this.Load += new System.EventHandler(this.UploadTweets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTweets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTweetH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTweetID;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button btnUpdateTweet;
        private System.Windows.Forms.Button btnAddTweet;
        private System.Windows.Forms.Button btnDelTweet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchTweets;
        private System.Windows.Forms.DataGridView dGVTweets;
        private System.Windows.Forms.Button btnShowAllUsers;
    }
}