using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1753081_Project2.BL;

namespace _1753081_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginLogin_Click(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0)
                MessageBox.Show("Please enter username.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (Password.Text.Length == 0)
                MessageBox.Show("Please enter password.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else try
                {
                    StudentServices service = new StudentServices();
                    List<string> loginUser = service.LoginAccess(Username.Text, Password.Text);
                    Password.Text = "";
                    if (loginUser.Count > 0)
                        if (Username.Text == "giaovu")
                        {
                            ManagerForm newForm = new ManagerForm();
                            Visible = false;
                            newForm.ShowDialog();
                            Visible = true;
                        }
                        else
                        {
                            StudentForm newForm = new StudentForm(loginUser);
                            Visible = false;
                            newForm.ShowDialog();
                            Visible = true;
                        }
                    else MessageBox.Show("Wrong username or password.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void LoginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) LoginLogin_Click(sender, e);
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) LoginLogin_Click(sender, e);
        }
    }
}