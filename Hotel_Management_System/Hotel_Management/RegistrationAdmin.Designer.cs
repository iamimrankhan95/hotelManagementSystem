namespace Hotel_Management
{
    partial class RegistrationAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationAdmin));
            this.lblAdminRegistration = new System.Windows.Forms.Label();
            this.btnAdminRegister = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminRegistration
            // 
            this.lblAdminRegistration.AutoSize = true;
            this.lblAdminRegistration.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRegistration.Location = new System.Drawing.Point(188, 73);
            this.lblAdminRegistration.Name = "lblAdminRegistration";
            this.lblAdminRegistration.Size = new System.Drawing.Size(198, 51);
            this.lblAdminRegistration.TabIndex = 20;
            this.lblAdminRegistration.Text = "Registration";
            // 
            // btnAdminRegister
            // 
            this.btnAdminRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRegister.Location = new System.Drawing.Point(379, 292);
            this.btnAdminRegister.Name = "btnAdminRegister";
            this.btnAdminRegister.Size = new System.Drawing.Size(143, 34);
            this.btnAdminRegister.TabIndex = 19;
            this.btnAdminRegister.Text = "Register";
            this.btnAdminRegister.UseVisualStyleBackColor = true;
            this.btnAdminRegister.Click += new System.EventHandler(this.btnAdminRegister_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(245, 247);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(196, 20);
            this.txtAdminPassword.TabIndex = 18;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(245, 189);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(196, 20);
            this.txtAdminName.TabIndex = 15;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(114, 237);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(106, 33);
            this.lblAdminPassword.TabIndex = 14;
            this.lblAdminPassword.Text = "Password";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(124, 179);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(70, 33);
            this.lblAdminName.TabIndex = 11;
            this.lblAdminName.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 34);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegistrationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(637, 344);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAdminRegistration);
            this.Controls.Add(this.btnAdminRegister);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.lblAdminName);
            this.Name = "RegistrationAdmin";
            this.Text = "RegistrationAdmin";
            this.Load += new System.EventHandler(this.RegistrationAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminRegistration;
        private System.Windows.Forms.Button btnAdminRegister;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button btnBack;
    }
}