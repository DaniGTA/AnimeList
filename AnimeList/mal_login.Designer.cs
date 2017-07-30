namespace AnimeList
{
    partial class mal_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mal_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mal_username_label = new System.Windows.Forms.Label();
            this.mal_password_label = new System.Windows.Forms.Label();
            this.mal_username = new System.Windows.Forms.TextBox();
            this.mal_password = new System.Windows.Forms.TextBox();
            this.mal_login_button = new System.Windows.Forms.Button();
            this.mal_cancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.error_box = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mal_username_label
            // 
            this.mal_username_label.Font = new System.Drawing.Font("Ashby Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mal_username_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mal_username_label.Location = new System.Drawing.Point(12, 102);
            this.mal_username_label.Name = "mal_username_label";
            this.mal_username_label.Size = new System.Drawing.Size(189, 23);
            this.mal_username_label.TabIndex = 1;
            this.mal_username_label.Text = "Username";
            this.mal_username_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mal_password_label
            // 
            this.mal_password_label.Font = new System.Drawing.Font("Ashby Medium", 12F);
            this.mal_password_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mal_password_label.Location = new System.Drawing.Point(12, 180);
            this.mal_password_label.Name = "mal_password_label";
            this.mal_password_label.Size = new System.Drawing.Size(189, 23);
            this.mal_password_label.TabIndex = 2;
            this.mal_password_label.Text = "Password";
            this.mal_password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mal_username
            // 
            this.mal_username.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mal_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mal_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mal_username.ForeColor = System.Drawing.Color.White;
            this.mal_username.Location = new System.Drawing.Point(16, 139);
            this.mal_username.MaxLength = 32;
            this.mal_username.Name = "mal_username";
            this.mal_username.Size = new System.Drawing.Size(185, 15);
            this.mal_username.TabIndex = 3;
            // 
            // mal_password
            // 
            this.mal_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mal_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mal_password.Font = new System.Drawing.Font("Arial", 9.75F);
            this.mal_password.ForeColor = System.Drawing.Color.White;
            this.mal_password.Location = new System.Drawing.Point(13, 221);
            this.mal_password.MaxLength = 32;
            this.mal_password.Name = "mal_password";
            this.mal_password.Size = new System.Drawing.Size(188, 15);
            this.mal_password.TabIndex = 4;
            this.mal_password.UseSystemPasswordChar = true;
            // 
            // mal_login_button
            // 
            this.mal_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mal_login_button.Location = new System.Drawing.Point(12, 248);
            this.mal_login_button.Name = "mal_login_button";
            this.mal_login_button.Size = new System.Drawing.Size(75, 23);
            this.mal_login_button.TabIndex = 5;
            this.mal_login_button.Text = "button1";
            this.mal_login_button.UseVisualStyleBackColor = true;
            this.mal_login_button.Click += new System.EventHandler(this.mal_login_button_Click);
            // 
            // mal_cancel
            // 
            this.mal_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mal_cancel.Location = new System.Drawing.Point(126, 248);
            this.mal_cancel.Name = "mal_cancel";
            this.mal_cancel.Size = new System.Drawing.Size(75, 23);
            this.mal_cancel.TabIndex = 6;
            this.mal_cancel.Text = "button1";
            this.mal_cancel.UseVisualStyleBackColor = true;
            this.mal_cancel.Click += new System.EventHandler(this.mal_cancel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // error_box
            // 
            this.error_box.ForeColor = System.Drawing.Color.Coral;
            this.error_box.Location = new System.Drawing.Point(0, 274);
            this.error_box.Name = "error_box";
            this.error_box.Size = new System.Drawing.Size(216, 30);
            this.error_box.TabIndex = 7;
            // 
            // mal_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(213, 309);
            this.Controls.Add(this.error_box);
            this.Controls.Add(this.mal_cancel);
            this.Controls.Add(this.mal_login_button);
            this.Controls.Add(this.mal_password);
            this.Controls.Add(this.mal_username);
            this.Controls.Add(this.mal_password_label);
            this.Controls.Add(this.mal_username_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mal_login";
            this.Text = "mal_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mal_username_label;
        private System.Windows.Forms.Label mal_password_label;
        private System.Windows.Forms.TextBox mal_username;
        private System.Windows.Forms.TextBox mal_password;
        public System.Windows.Forms.Button mal_login_button;
        private System.Windows.Forms.Button mal_cancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label error_box;
    }
}