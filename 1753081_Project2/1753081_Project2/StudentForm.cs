using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1753081_Project2.Info;
using _1753081_Project2.BL;

namespace _1753081_Project2
{
    public partial class StudentForm : Form
    {
        string studentID;

        public StudentForm(List<string> student)
        {
            InitializeComponent();
            studentID = student[0];
            Hello.Text = $"Hello {student[1]}!";
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to log out??", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) e.Cancel = true;
        }

        private void StuChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword newForm = new ChangePassword(studentID);
            newForm.ShowDialog();
        }

        private void BindDataToListView(List<Information> Data)
        {
            ListViewItem newItem;
            int i = 1;
            foreach (Information data in Data)
            {
                newItem = new ListViewItem();
                newItem.Text = i.ToString();
                newItem.SubItems.Add(data.Id);
                newItem.SubItems.Add(data.Name);

                foreach (string info in data.Info)
                    newItem.SubItems.Add(info);
                listView.Items.Add(newItem);
                i++;
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            var service = new StudentServices();
            var Data = service.GetScoreFromDB(studentID);
            BindDataToListView(Data);
            listView.View = View.Details;
        }
    }
}
