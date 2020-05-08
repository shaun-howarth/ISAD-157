namespace ISAD157_MySQL_Data_Form
{
    partial class DataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnWorkplace = new System.Windows.Forms.Button();
            this.btnUniversities = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUser.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnUser.Location = new System.Drawing.Point(158, 123);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(140, 61);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User Table";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMessages.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnMessages.Location = new System.Drawing.Point(333, 123);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(140, 61);
            this.btnMessages.TabIndex = 2;
            this.btnMessages.Text = "Messages Table";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnWorkplace
            // 
            this.btnWorkplace.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnWorkplace.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnWorkplace.Location = new System.Drawing.Point(522, 123);
            this.btnWorkplace.Name = "btnWorkplace";
            this.btnWorkplace.Size = new System.Drawing.Size(140, 61);
            this.btnWorkplace.TabIndex = 3;
            this.btnWorkplace.Text = "Workplace Table";
            this.btnWorkplace.UseVisualStyleBackColor = false;
            this.btnWorkplace.Click += new System.EventHandler(this.btnWorkplace_Click);
            // 
            // btnUniversities
            // 
            this.btnUniversities.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUniversities.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnUniversities.Location = new System.Drawing.Point(702, 123);
            this.btnUniversities.Name = "btnUniversities";
            this.btnUniversities.Size = new System.Drawing.Size(140, 61);
            this.btnUniversities.TabIndex = 4;
            this.btnUniversities.Text = "Universities Table";
            this.btnUniversities.UseVisualStyleBackColor = false;
            this.btnUniversities.Click += new System.EventHandler(this.btnUniversities_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFriends.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnFriends.Location = new System.Drawing.Point(429, 200);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(140, 61);
            this.btnFriends.TabIndex = 5;
            this.btnFriends.Text = "Friends Table";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F);
            this.label1.Location = new System.Drawing.Point(374, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facebook: Profile Data";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.Location = new System.Drawing.Point(398, 762);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close Form";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(321, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a Table to view corresponding data from Database:";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 816);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnUniversities);
            this.Controls.Add(this.btnWorkplace);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataForm";
            this.Text = "Facebook Accounts: Data Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnWorkplace;
        private System.Windows.Forms.Button btnUniversities;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}

