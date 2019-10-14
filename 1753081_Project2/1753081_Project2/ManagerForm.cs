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
    public partial class ManagerForm : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        enum ListViewInfo
        {
            Students,
            Schedule,
            Scoreboard,
        };
        ListViewInfo listViewInfo = ListViewInfo.Students;
        List<Information> FileData;
        string currClass, currSubject;

        private System.Windows.Forms.ColumnHeader _No;
        private System.Windows.Forms.ColumnHeader _Id;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader _Info1;
        private System.Windows.Forms.ColumnHeader _Info2;
        private System.Windows.Forms.ColumnHeader _Info3;
        private System.Windows.Forms.ColumnHeader _Info4;
        private System.Windows.Forms.ColumnHeader _Info5;
        private System.Windows.Forms.ColumnHeader _Info6;
        private System.Windows.Forms.ColumnHeader _Info7;

        public ManagerForm()
        {
            InitializeComponent();

            openFileDialog.Filter = "Comma-separated values files (*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;

            NotiLabel.Text = "";

            _No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            _Info7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            _No.Text = "No.";
            _No.Width = 40;

            ComboBoxChangeable = false;
            Classes.Items.Add("All");
            Classes.SelectedIndex = 0;
            Subjects.Items.Add("All");
            Subjects.SelectedIndex = 0;
            ComboBoxChangeable = true;

            StudentServices service = new StudentServices();
            var data = service.GetClassesFromDB("All");
            foreach (string Class in data) Classes.Items.Add(Class);
            data = service.GetSubjectFromDB("All");
            foreach (string Subject in data) Subjects.Items.Add(Subject);

        }

        bool ComboBoxChangeable = true;

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword newForm = new ChangePassword("giaovu");
            newForm.ShowDialog();
            EditButton.Enabled = false;
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to log out??", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) e.Cancel = true;
            EditButton.Enabled = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            EditButton.Enabled = false;
            Close();
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

        private void ImportClass_Click(object sender, EventArgs e)
        {
            Classes.Enabled = false;
            Subjects.Enabled = false;
            listViewInfo = ListViewInfo.Students;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _Id.Text = "Student ID";
                _Id.Width = 170;
                _Name.Text = "Student name";
                _Name.Width = 200;
                _Info1.Text = "Gender";
                _Info1.Width = 170;
                _Info2.Text = "Identify Card No.";
                _Info2.Width = 170;
                _Info3.Text = "Date of Birth";
                _Info3.Width = 170;

                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _No, _Id, _Name, _Info1, _Info2, _Info3 });

                StudentServices service = new StudentServices();
                var Data = service.GetDataFromFile(openFileDialog.FileName);

                NotiLabel.Text = $"Press 'Import' button to import these students below to class '{Data[0].Id}'.";
                currClass = Data[0].Id;
                Data.RemoveAt(0);
                BindDataToListView(Data);
                listView.View = View.Details;

                FileData = Data;
                ImportButton.Enabled = true;
                EditButton.Enabled = false;
            }
        }
        
        private void ImportSchedule_Click(object sender, EventArgs e)
        {
            Classes.Enabled = false;
            Subjects.Enabled = false;
            listViewInfo = ListViewInfo.Schedule;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StudentServices service = new StudentServices();
                var Data = service.GetDataFromFile(openFileDialog.FileName);
                
                _Id.Text = "Subject ID";
                _Id.Width = 220;
                _Name.Text = "Subject name";
                _Name.Width = 440;
                _Info1.Text = "Room";
                _Info1.Width = 220;

                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _No, _Id, _Name, _Info1 });

                NotiLabel.Text = $"Press 'Import' button to import the schedule below to class '{Data[0].Id}'.";
                currClass = Data[0].Id;
                Data.RemoveAt(0);
                BindDataToListView(Data);
                listView.View = View.Details;

                FileData = Data;
                ImportButton.Enabled = true;
                EditButton.Enabled = false;
            }
        }

        private void ImportScore_Click(object sender, EventArgs e)
        {
            Classes.Enabled = false;
            Subjects.Enabled = false;
            listViewInfo = ListViewInfo.Scoreboard;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StudentServices service = new StudentServices();
                var Data = service.GetDataFromFile(openFileDialog.FileName);

                _Id.Text = "Student ID";
                _Id.Width = 170;
                _Name.Text = "Student name";
                _Name.Width = 210;
                _Info1.Text = "Mid-term score";
                _Info1.Width = 125;
                _Info2.Text = "Final-term score";
                _Info2.Width = 125;
                _Info3.Text = "Other score";
                _Info3.Width = 125;
                _Info4.Text = "Final score";
                _Info4.Width = 125;

                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                { _No, _Id, _Name, _Info1, _Info2, _Info3, _Info4 });

                NotiLabel.Text = $"Press 'Import' button to import the '{Data[0].Name}' scoreboard below for class '{Data[0].Id}'.";
                currClass = Data[0].Id;
                currSubject = Data[0].Name;
                Data.RemoveAt(0);
                BindDataToListView(Data);
                listView.View = View.Details;

                FileData = Data;
                ImportButton.Enabled = true;
                EditButton.Enabled = false;
            }
        }

        private void ViewStudents_Click(object sender, EventArgs e)
        {
            NotiLabel.Text = "";
            Classes.Enabled = true;
            Subjects.Enabled = true;
            EditButton.Enabled = false;
            listViewInfo = ListViewInfo.Students;

            _Id.Text = "Student ID";
            _Id.Width = 150;
            _Name.Text = "Student name";
            _Name.Width = 175;
            _Info1.Text = "Class";
            _Info1.Width = 125;
            _Info2.Text = "Date of Birth";
            _Info2.Width = 155;
            _Info3.Text = "Gender";
            _Info3.Width = 125;
            _Info4.Text = "Identify Card No.";
            _Info4.Width = 150;

            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            { _No, _Id, _Name, _Info1, _Info2, _Info3, _Info4 });

            try
            {
                StudentServices service = new StudentServices();
                var Data = service.GetStudentsFromDB(Classes.SelectedItem.ToString(), Subjects.SelectedItem.ToString());
                BindDataToListView(Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listView.Items.Count == 0) NotiLabel.Text = "Nothing is found...";
            listView.View = View.Details;
        }

        private void ViewSchedule_Click(object sender, EventArgs e)
        {
            NotiLabel.Text = "";
            EditButton.Enabled = false;
            Classes.Enabled = true;
            ComboBoxChangeable = false;
            Subjects.Enabled = false;
            Subjects.SelectedIndex = 0;
            ComboBoxChangeable = true;
            listViewInfo = ListViewInfo.Schedule;

            _Id.Text = "Subject ID";
            _Id.Width = 180;
            _Name.Text = "Class";
            _Name.Width = 180;
            _Info1.Text = "Subject";
            _Info1.Width = 340;
            _Info2.Text = "Room";
            _Info2.Width = 180;

            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _No, _Id, _Name, _Info1, _Info2 });

            try
            {
                StudentServices service = new StudentServices();
                var Data = service.GetScheduleFromDB(Classes.SelectedItem.ToString(), Subjects.SelectedItem.ToString());
                BindDataToListView(Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listView.Items.Count == 0) NotiLabel.Text = "Nothing is found...";
            listView.View = View.Details;
        }

        private void ViewScore_Click(object sender, EventArgs e)
        {
            NotiLabel.Text = "";
            EditButton.Enabled = true;
            Classes.Enabled = true;
            Subjects.Enabled = true;
            listViewInfo = ListViewInfo.Scoreboard;

            _Id.Text = "Student ID";
            _Id.Width = 110;
            _Name.Text = "Student name";
            _Name.Width = 190;
            _Info1.Text = "Class";
            _Info1.Width = 90;
            _Info2.Text = "Subject ID";
            _Info2.Width = 110;
            _Info3.Text = "Mid-term";
            _Info3.Width = 80;
            _Info4.Text = "Final-term";
            _Info4.Width = 80;
            _Info5.Text = "Other score";
            _Info5.Width = 80;
            _Info6.Text = "Final score";
            _Info6.Width = 80;
            _Info7.Text = "Pass";
            _Info7.Width = 60;

            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            { _No, _Id, _Name, _Info1, _Info2, _Info3, _Info4, _Info5, _Info6, _Info7 });

            try
            {
                StudentServices service = new StudentServices();
                var Data = service.GetScoreboardFromDB(Classes.SelectedItem.ToString(), Subjects.SelectedItem.ToString());
                int pass = 0;
                foreach (var data in Data)
                    if (data.Info[6] == "Yes") pass++;
                BindDataToListView(Data);
                if (Classes.SelectedItem.ToString() != "All" && Subjects.SelectedItem.ToString() != "All")
                    NotiLabel.Text = $"There are {pass} student(s) ({((float) pass / (float) Data.Count).ToString("p")}) " +
                        $"of class {Classes.SelectedItem.ToString()} passed this subject.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listView.Items.Count == 0) NotiLabel.Text = "Nothing is found...";
            listView.View = View.Details;
        }

        private void Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ComboBoxChangeable) return;
            ComboBoxChangeable = false;
            EditButton.Enabled = false;

            string Choosing = Subjects.SelectedItem.ToString();
            Subjects.Items.Clear();
            Subjects.Items.Add("All");

            StudentServices service = new StudentServices();
            var data = service.GetSubjectFromDB(Classes.SelectedItem.ToString());
            foreach (string Subject in data) Subjects.Items.Add(Subject);

            if (!Subjects.Items.Contains(Choosing)) Subjects.SelectedIndex = 0;
            else Subjects.SelectedIndex = Subjects.Items.IndexOf(Choosing);

            if (listViewInfo == ListViewInfo.Students) ViewStudents_Click(sender, e);
            else if (listViewInfo == ListViewInfo.Scoreboard) ViewScore_Click(sender, e);
            else if (listViewInfo == ListViewInfo.Schedule) ViewSchedule_Click(sender, e);
            ComboBoxChangeable = true;
        }

        private void Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ComboBoxChangeable) return;
            ComboBoxChangeable = false;
            EditButton.Enabled = false;

            string Choosing = Classes.SelectedItem.ToString();
            Classes.Items.Clear();
            Classes.Items.Add("All");

            StudentServices service = new StudentServices();
            var data = service.GetClassesFromDB(Subjects.SelectedItem.ToString());
            foreach (string Class in data) Classes.Items.Add(Class);

            if (!Classes.Items.Contains(Choosing)) Classes.SelectedIndex = 0;
            else Classes.SelectedIndex = Classes.Items.IndexOf(Choosing);

            if (listViewInfo == ListViewInfo.Students) ViewStudents_Click(sender, e);
            else if (listViewInfo == ListViewInfo.Scoreboard) ViewScore_Click(sender, e);
            else if (listViewInfo == ListViewInfo.Schedule) ViewSchedule_Click(sender, e);
            ComboBoxChangeable = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count < 1)
                NotiLabel.Text = "Please select a student to edit score!!";
            else
            {
                var newForm = new EditScore(listView.SelectedItems[0]);
                newForm.ShowDialog();
                NotiLabel.Text = "";
                ViewScore_Click(sender, e);
            }
        }

        private void ImportStudent_Click(object sender, EventArgs e)
        {
            var newForm = new ImportStudent();
            newForm.ShowDialog();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            StudentServices service = new StudentServices();
            int i = 0;
            if (listViewInfo == ListViewInfo.Students)
            {
                try
                {
                    service.InsertClassToDB(currClass);
                    Classes.Items.Add(currClass);

                    foreach (Information data in FileData)
                        try
                        {
                            service.InsertStudentToDB(data, currClass);
                            i++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Student with ID '{data.Id}' cannot be imported!!"
                                + Environment.NewLine + ex.Message);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Class '{currClass}' cannot be imported!!" + Environment.NewLine + ex.Message);
                }
                NotiLabel.Text = $"{i} student(s) have been imported to class '{currClass}' successfully.";
            }
            else if (listViewInfo == ListViewInfo.Schedule)
            {
                try
                {
                    service.InsertClassToDB(currClass);
                    Classes.Items.Add(currClass);
                }
                catch { }

                foreach (Information data in FileData)
                    try
                    {
                        service.InsertScheduleToDB(data, currClass);
                        i++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Subject with ID '{data.Id}' cannot be imported!!"
                            + Environment.NewLine + ex.Message);
                    }
                
                NotiLabel.Text = $"{i} subject(s) from schedule have been imported for class '{currClass}' successfully.";
            }
            else if (listViewInfo == ListViewInfo.Scoreboard)
            {
                try
                {
                    service.InsertClassToDB(currClass);
                    Classes.Items.Add(currClass);
                }
                catch { }

                foreach (Information data in FileData)
                    try
                    {
                        if (service.InsertScoreToDB(data, currClass, currSubject)) i++;
                        else MessageBox.Show($"Score of student with ID '{data.Id}' cannot be imported!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Score of student with ID '{data.Id}' cannot be imported!!"
                            + Environment.NewLine + ex.Message);
                    }

                NotiLabel.Text = $"{i} student(s)' score have been imported for class '{currClass}' successfully.";
            }
            ImportButton.Enabled = false;
        }
    }
}
