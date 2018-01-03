namespace Hotel_Management
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panelLeftSideOfAdmin = new System.Windows.Forms.Panel();
            this.btnAddNewReceptionist = new System.Windows.Forms.Button();
            this.btnAddNewAdmin = new System.Windows.Forms.Button();
            this.btnGuestInfoToAdmin = new System.Windows.Forms.Button();
            this.lblReceptionistDetailsToAdmin = new System.Windows.Forms.Button();
            this.btnBackToForm1 = new System.Windows.Forms.Button();
            this.panelReceptionistDetailsToAdmin = new System.Windows.Forms.Panel();
            this.btnViewAllReceptionistDetails = new System.Windows.Forms.Button();
            this.dataGridViewSelectedUserDetails = new System.Windows.Forms.DataGridView();
            this.btnSearchReceptionistByAdmin = new System.Windows.Forms.Button();
            this.txtReceptionistIdByAdmin = new System.Windows.Forms.TextBox();
            this.lblReceptionistIdByAdmin = new System.Windows.Forms.Label();
            this.panelUserDetailsToAdmin = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dataGridViewUserDetailsToAdmin = new System.Windows.Forms.DataGridView();
            this.btnSearchUserDetailsByAdmin = new System.Windows.Forms.Button();
            this.txtUserDetailsByAdmin = new System.Windows.Forms.TextBox();
            this.lblUserDetailsByAdmin = new System.Windows.Forms.Label();
            this.pictureBoxAdminPanel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLeftSideOfAdmin.SuspendLayout();
            this.panelReceptionistDetailsToAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedUserDetails)).BeginInit();
            this.panelUserDetailsToAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDetailsToAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSideOfAdmin
            // 
            this.panelLeftSideOfAdmin.Controls.Add(this.btnAddNewReceptionist);
            this.panelLeftSideOfAdmin.Controls.Add(this.btnAddNewAdmin);
            this.panelLeftSideOfAdmin.Controls.Add(this.btnGuestInfoToAdmin);
            this.panelLeftSideOfAdmin.Controls.Add(this.lblReceptionistDetailsToAdmin);
            this.panelLeftSideOfAdmin.Controls.Add(this.btnBackToForm1);
            this.panelLeftSideOfAdmin.Location = new System.Drawing.Point(16, 178);
            this.panelLeftSideOfAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeftSideOfAdmin.Name = "panelLeftSideOfAdmin";
            this.panelLeftSideOfAdmin.Size = new System.Drawing.Size(303, 357);
            this.panelLeftSideOfAdmin.TabIndex = 0;
            // 
            // btnAddNewReceptionist
            // 
            this.btnAddNewReceptionist.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewReceptionist.Location = new System.Drawing.Point(12, 245);
            this.btnAddNewReceptionist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewReceptionist.Name = "btnAddNewReceptionist";
            this.btnAddNewReceptionist.Size = new System.Drawing.Size(279, 64);
            this.btnAddNewReceptionist.TabIndex = 5;
            this.btnAddNewReceptionist.Text = "Add New Receptionist";
            this.btnAddNewReceptionist.UseVisualStyleBackColor = true;
            this.btnAddNewReceptionist.Click += new System.EventHandler(this.btnAddNewReceptionist_Click);
            // 
            // btnAddNewAdmin
            // 
            this.btnAddNewAdmin.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAdmin.Location = new System.Drawing.Point(12, 185);
            this.btnAddNewAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewAdmin.Name = "btnAddNewAdmin";
            this.btnAddNewAdmin.Size = new System.Drawing.Size(279, 64);
            this.btnAddNewAdmin.TabIndex = 4;
            this.btnAddNewAdmin.Text = "Add New Admin";
            this.btnAddNewAdmin.UseVisualStyleBackColor = true;
            this.btnAddNewAdmin.Click += new System.EventHandler(this.btnAddNewAdmin_Click);
            // 
            // btnGuestInfoToAdmin
            // 
            this.btnGuestInfoToAdmin.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestInfoToAdmin.Location = new System.Drawing.Point(12, 124);
            this.btnGuestInfoToAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuestInfoToAdmin.Name = "btnGuestInfoToAdmin";
            this.btnGuestInfoToAdmin.Size = new System.Drawing.Size(279, 64);
            this.btnGuestInfoToAdmin.TabIndex = 3;
            this.btnGuestInfoToAdmin.Text = "Guest Info";
            this.btnGuestInfoToAdmin.UseVisualStyleBackColor = true;
            this.btnGuestInfoToAdmin.Click += new System.EventHandler(this.btnGuestInfoToAdmin_Click);
            // 
            // lblReceptionistDetailsToAdmin
            // 
            this.lblReceptionistDetailsToAdmin.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistDetailsToAdmin.Location = new System.Drawing.Point(12, 64);
            this.lblReceptionistDetailsToAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblReceptionistDetailsToAdmin.Name = "lblReceptionistDetailsToAdmin";
            this.lblReceptionistDetailsToAdmin.Size = new System.Drawing.Size(279, 64);
            this.lblReceptionistDetailsToAdmin.TabIndex = 2;
            this.lblReceptionistDetailsToAdmin.Text = "Receptionist";
            this.lblReceptionistDetailsToAdmin.UseVisualStyleBackColor = true;
            this.lblReceptionistDetailsToAdmin.Click += new System.EventHandler(this.lblReceptionistDetailsToAdmin_Click);
            // 
            // btnBackToForm1
            // 
            this.btnBackToForm1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToForm1.Location = new System.Drawing.Point(12, 4);
            this.btnBackToForm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToForm1.Name = "btnBackToForm1";
            this.btnBackToForm1.Size = new System.Drawing.Size(279, 64);
            this.btnBackToForm1.TabIndex = 1;
            this.btnBackToForm1.Text = "Home";
            this.btnBackToForm1.UseVisualStyleBackColor = true;
            this.btnBackToForm1.Click += new System.EventHandler(this.btnBackToForm1_Click);
            // 
            // panelReceptionistDetailsToAdmin
            // 
            this.panelReceptionistDetailsToAdmin.Controls.Add(this.btnViewAllReceptionistDetails);
            this.panelReceptionistDetailsToAdmin.Controls.Add(this.dataGridViewSelectedUserDetails);
            this.panelReceptionistDetailsToAdmin.Controls.Add(this.btnSearchReceptionistByAdmin);
            this.panelReceptionistDetailsToAdmin.Controls.Add(this.txtReceptionistIdByAdmin);
            this.panelReceptionistDetailsToAdmin.Controls.Add(this.lblReceptionistIdByAdmin);
            this.panelReceptionistDetailsToAdmin.Location = new System.Drawing.Point(328, 178);
            this.panelReceptionistDetailsToAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReceptionistDetailsToAdmin.Name = "panelReceptionistDetailsToAdmin";
            this.panelReceptionistDetailsToAdmin.Size = new System.Drawing.Size(632, 357);
            this.panelReceptionistDetailsToAdmin.TabIndex = 1;
            // 
            // btnViewAllReceptionistDetails
            // 
            this.btnViewAllReceptionistDetails.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllReceptionistDetails.Location = new System.Drawing.Point(456, 295);
            this.btnViewAllReceptionistDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAllReceptionistDetails.Name = "btnViewAllReceptionistDetails";
            this.btnViewAllReceptionistDetails.Size = new System.Drawing.Size(156, 48);
            this.btnViewAllReceptionistDetails.TabIndex = 15;
            this.btnViewAllReceptionistDetails.Text = "View All";
            this.btnViewAllReceptionistDetails.UseVisualStyleBackColor = true;
            this.btnViewAllReceptionistDetails.Click += new System.EventHandler(this.btnViewAllReceptionistDetails_Click);
            // 
            // dataGridViewSelectedUserDetails
            // 
            this.dataGridViewSelectedUserDetails.AllowUserToAddRows = false;
            this.dataGridViewSelectedUserDetails.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedUserDetails.Location = new System.Drawing.Point(4, 79);
            this.dataGridViewSelectedUserDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSelectedUserDetails.Name = "dataGridViewSelectedUserDetails";
            this.dataGridViewSelectedUserDetails.ReadOnly = true;
            this.dataGridViewSelectedUserDetails.Size = new System.Drawing.Size(608, 209);
            this.dataGridViewSelectedUserDetails.TabIndex = 9;
            // 
            // btnSearchReceptionistByAdmin
            // 
            this.btnSearchReceptionistByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReceptionistByAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReceptionistByAdmin.Image")));
            this.btnSearchReceptionistByAdmin.Location = new System.Drawing.Point(467, 30);
            this.btnSearchReceptionistByAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchReceptionistByAdmin.Name = "btnSearchReceptionistByAdmin";
            this.btnSearchReceptionistByAdmin.Size = new System.Drawing.Size(43, 34);
            this.btnSearchReceptionistByAdmin.TabIndex = 8;
            this.btnSearchReceptionistByAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchReceptionistByAdmin.UseVisualStyleBackColor = true;
            this.btnSearchReceptionistByAdmin.Click += new System.EventHandler(this.btnSearchReceptionistByAdmin_Click);
            // 
            // txtReceptionistIdByAdmin
            // 
            this.txtReceptionistIdByAdmin.Location = new System.Drawing.Point(197, 30);
            this.txtReceptionistIdByAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReceptionistIdByAdmin.Name = "txtReceptionistIdByAdmin";
            this.txtReceptionistIdByAdmin.Size = new System.Drawing.Size(260, 22);
            this.txtReceptionistIdByAdmin.TabIndex = 7;
            this.txtReceptionistIdByAdmin.TextChanged += new System.EventHandler(this.txtReceptionistIdByAdmin_TextChanged);
            // 
            // lblReceptionistIdByAdmin
            // 
            this.lblReceptionistIdByAdmin.AutoSize = true;
            this.lblReceptionistIdByAdmin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistIdByAdmin.Location = new System.Drawing.Point(12, 22);
            this.lblReceptionistIdByAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionistIdByAdmin.Name = "lblReceptionistIdByAdmin";
            this.lblReceptionistIdByAdmin.Size = new System.Drawing.Size(165, 35);
            this.lblReceptionistIdByAdmin.TabIndex = 6;
            this.lblReceptionistIdByAdmin.Text = "Receptionist ID";
            // 
            // panelUserDetailsToAdmin
            // 
            this.panelUserDetailsToAdmin.Controls.Add(this.btnViewAll);
            this.panelUserDetailsToAdmin.Controls.Add(this.dataGridViewUserDetailsToAdmin);
            this.panelUserDetailsToAdmin.Controls.Add(this.btnSearchUserDetailsByAdmin);
            this.panelUserDetailsToAdmin.Controls.Add(this.txtUserDetailsByAdmin);
            this.panelUserDetailsToAdmin.Controls.Add(this.lblUserDetailsByAdmin);
            this.panelUserDetailsToAdmin.Location = new System.Drawing.Point(980, 178);
            this.panelUserDetailsToAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUserDetailsToAdmin.Name = "panelUserDetailsToAdmin";
            this.panelUserDetailsToAdmin.Size = new System.Drawing.Size(661, 357);
            this.panelUserDetailsToAdmin.TabIndex = 2;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(479, 295);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(156, 48);
            this.btnViewAll.TabIndex = 14;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dataGridViewUserDetailsToAdmin
            // 
            this.dataGridViewUserDetailsToAdmin.AllowUserToAddRows = false;
            this.dataGridViewUserDetailsToAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewUserDetailsToAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDetailsToAdmin.Location = new System.Drawing.Point(27, 79);
            this.dataGridViewUserDetailsToAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUserDetailsToAdmin.Name = "dataGridViewUserDetailsToAdmin";
            this.dataGridViewUserDetailsToAdmin.ReadOnly = true;
            this.dataGridViewUserDetailsToAdmin.Size = new System.Drawing.Size(608, 209);
            this.dataGridViewUserDetailsToAdmin.TabIndex = 13;
            // 
            // btnSearchUserDetailsByAdmin
            // 
            this.btnSearchUserDetailsByAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUserDetailsByAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchUserDetailsByAdmin.Image")));
            this.btnSearchUserDetailsByAdmin.Location = new System.Drawing.Point(491, 27);
            this.btnSearchUserDetailsByAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchUserDetailsByAdmin.Name = "btnSearchUserDetailsByAdmin";
            this.btnSearchUserDetailsByAdmin.Size = new System.Drawing.Size(43, 34);
            this.btnSearchUserDetailsByAdmin.TabIndex = 12;
            this.btnSearchUserDetailsByAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchUserDetailsByAdmin.UseVisualStyleBackColor = true;
            this.btnSearchUserDetailsByAdmin.Click += new System.EventHandler(this.btnSearchUserDetailsByAdmin_Click);
            // 
            // txtUserDetailsByAdmin
            // 
            this.txtUserDetailsByAdmin.Location = new System.Drawing.Point(221, 27);
            this.txtUserDetailsByAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserDetailsByAdmin.Name = "txtUserDetailsByAdmin";
            this.txtUserDetailsByAdmin.Size = new System.Drawing.Size(260, 22);
            this.txtUserDetailsByAdmin.TabIndex = 11;
            // 
            // lblUserDetailsByAdmin
            // 
            this.lblUserDetailsByAdmin.AutoSize = true;
            this.lblUserDetailsByAdmin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetailsByAdmin.Location = new System.Drawing.Point(104, 20);
            this.lblUserDetailsByAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetailsByAdmin.Name = "lblUserDetailsByAdmin";
            this.lblUserDetailsByAdmin.Size = new System.Drawing.Size(88, 35);
            this.lblUserDetailsByAdmin.TabIndex = 10;
            this.lblUserDetailsByAdmin.Text = "User ID";
            // 
            // pictureBoxAdminPanel
            // 
            this.pictureBoxAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdminPanel.Image")));
            this.pictureBoxAdminPanel.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxAdminPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAdminPanel.Name = "pictureBoxAdminPanel";
            this.pictureBoxAdminPanel.Size = new System.Drawing.Size(944, 156);
            this.pictureBoxAdminPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdminPanel.TabIndex = 3;
            this.pictureBoxAdminPanel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Revenue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1153, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 33);
            this.textBox1.TabIndex = 5;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1655, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAdminPanel);
            this.Controls.Add(this.panelUserDetailsToAdmin);
            this.Controls.Add(this.panelReceptionistDetailsToAdmin);
            this.Controls.Add(this.panelLeftSideOfAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panelLeftSideOfAdmin.ResumeLayout(false);
            this.panelReceptionistDetailsToAdmin.ResumeLayout(false);
            this.panelReceptionistDetailsToAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedUserDetails)).EndInit();
            this.panelUserDetailsToAdmin.ResumeLayout(false);
            this.panelUserDetailsToAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDetailsToAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSideOfAdmin;
        private System.Windows.Forms.Button btnGuestInfoToAdmin;
        private System.Windows.Forms.Button lblReceptionistDetailsToAdmin;
        private System.Windows.Forms.Button btnBackToForm1;
        private System.Windows.Forms.Panel panelReceptionistDetailsToAdmin;
        private System.Windows.Forms.DataGridView dataGridViewSelectedUserDetails;
        private System.Windows.Forms.Button btnSearchReceptionistByAdmin;
        private System.Windows.Forms.TextBox txtReceptionistIdByAdmin;
        private System.Windows.Forms.Label lblReceptionistIdByAdmin;
        private System.Windows.Forms.Panel panelUserDetailsToAdmin;
        private System.Windows.Forms.DataGridView dataGridViewUserDetailsToAdmin;
        private System.Windows.Forms.Button btnSearchUserDetailsByAdmin;
        private System.Windows.Forms.TextBox txtUserDetailsByAdmin;
        private System.Windows.Forms.Label lblUserDetailsByAdmin;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.PictureBox pictureBoxAdminPanel;
        private System.Windows.Forms.Button btnAddNewReceptionist;
        private System.Windows.Forms.Button btnAddNewAdmin;
        private System.Windows.Forms.Button btnViewAllReceptionistDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}