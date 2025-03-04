namespace Project_ef.views
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            emailtxt = new TextBox();
            password = new TextBox();
            email = new Label();
            label3 = new Label();
            loginOp = new Label();
            signupOp = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.White;
            emailtxt.BorderStyle = BorderStyle.None;
            emailtxt.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtxt.Location = new Point(66, 116);
            emailtxt.Multiline = true;
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(332, 41);
            emailtxt.TabIndex = 0;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(80, 225);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(318, 41);
            password.TabIndex = 1;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Wide Latin", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.White;
            email.Location = new Point(34, 62);
            email.Name = "email";
            email.Size = new Size(137, 28);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 180);
            label3.Name = "label3";
            label3.Size = new Size(150, 31);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // loginOp
            // 
            loginOp.AutoSize = true;
            loginOp.BackColor = Color.DarkBlue;
            loginOp.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginOp.ForeColor = Color.Snow;
            loginOp.Location = new Point(149, 289);
            loginOp.Name = "loginOp";
            loginOp.Size = new Size(119, 43);
            loginOp.TabIndex = 6;
            loginOp.Text = "login";
            loginOp.Click += loginOp_Click;
            // 
            // signupOp
            // 
            signupOp.AutoSize = true;
            signupOp.BackColor = Color.Transparent;
            signupOp.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupOp.ForeColor = Color.Transparent;
            signupOp.Location = new Point(275, 479);
            signupOp.Name = "signupOp";
            signupOp.Size = new Size(90, 26);
            signupOp.TabIndex = 7;
            signupOp.Text = "sign up";
            signupOp.Click += signupOp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(53, 482);
            label2.Name = "label2";
            label2.Size = new Size(216, 21);
            label2.TabIndex = 9;
            label2.Text = "I don't have an account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._360_F_119115529_mEnw3lGpLdlDkfLgRcVSbFRuVl6sMDty1;
            ClientSize = new Size(533, 553);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(signupOp);
            Controls.Add(loginOp);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(emailtxt);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private TextBox emailtxt;
        private TextBox password;
        private Label email;
        private Label label3;
        private Label loginOp;
        private Label signupOp;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}