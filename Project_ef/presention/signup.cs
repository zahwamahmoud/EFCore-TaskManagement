using Project_ef.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ef.views
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signupOp_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string pass = textBox3.Text;

            var validationResult = ValidateUserData(name, email, pass);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.ErrorMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new TaskManagementContext())
            {
                var existingUser = context.Users.SingleOrDefault(u => u.Email == email);
                if (existingUser != null)
                {
                    MessageBox.Show("This email is already in use. Please choose another.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var newUser = new User
                {
                    Name = name,
                    Email = email,
                    password = pass
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Sign up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                login login = new login();
                login.Show();

                this.Hide();


            }
        }

        private (bool IsValid, string ErrorMessage) ValidateUserData(string name, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return (false, "Name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                return (false, "Please enter a valid email address.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                return (false, "Password must be at least 6 characters long.");
            }

            return (true, null); // Return valid result  
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
