using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       




        private void loginOp_Click(object sender, EventArgs e)
        {
            string email = emailtxt.Text;
            string pass = password.Text;

            using (var userRepository = new TaskManagementContext())
            {
                var user = userRepository.Users.SingleOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.Email == email && user.password == pass)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    index index = new index();
                    index.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signupOp_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();

            this.Hide();

        }

       
    }
}
