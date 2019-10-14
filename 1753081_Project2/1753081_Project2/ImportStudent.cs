using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1753081_Project2.BL;
using _1753081_Project2.Info;

namespace _1753081_Project2
{
    public partial class ImportStudent : Form
    {
        public ImportStudent()
        {
            InitializeComponent();
            NotiLabel.Text = "";
            StudentServices service = new StudentServices();
            var data = service.GetClassesFromDB("All");
            foreach (string Class in data) Classes.Items.Add(Class);
            Classes.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (sID.Text == "")
                NotiLabel.Text = "Please enter student ID!!";
            else
            {
                var newStudent = new Information();
                newStudent.Id = sID.Text;
                newStudent.Name = Name.Text;
                newStudent.Info = new string[3];
                if (Male.Checked) newStudent.Info[0] = "Nam";
                else newStudent.Info[0] = "Nữ";
                newStudent.Info[1] = IdCard.Text;
                newStudent.Info[2] = DOB.Text;
                try
                {
                    var service = new StudentServices();
                    service.InsertStudentToDB(newStudent, Classes.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
