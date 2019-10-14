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
    public partial class ChangePassword : Form
    {
        string username;

        public ChangePassword(string ID)
        {
            InitializeComponent();
            username = ID;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if ((username != "giaovu" && CurrPass.Text.Length < 8) || CurrPass.Text.Length > 16)
                NotiLabel.Text = "Current password is not correct.";
            else if (NewPass.Text.Length < 8)
                NotiLabel.Text = "Password must contain at least 8 characters.";
            else if (NewPass.Text.Length > 16)
                NotiLabel.Text = "Password must contain at most 16 characters.";
            else if (NewPass.Text != ConfirmPass.Text)
                NotiLabel.Text = "Confirm new password does not match.";
            else if (NewPass.Text == CurrPass.Text)
                NotiLabel.Text = "New password must be different from the current one.";
            else
            {
                StudentServices services = new StudentServices();
                NotiLabel.Text = services.ChangePassword(username, CurrPass.Text, NewPass.Text);
            }

            CurrPass.Clear();
            NewPass.Clear();
            ConfirmPass.Clear();
        }

        private void CurrPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            NotiLabel.Text = "";
            if (e.KeyChar == 13) ChangeButton_Click(sender, e);
        }

        private void NewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            NotiLabel.Text = "";
            if (e.KeyChar == 13) ChangeButton_Click(sender, e);
        }

        private void ConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            NotiLabel.Text = "";
            if (e.KeyChar == 13) ChangeButton_Click(sender, e);
        }
    }
}
