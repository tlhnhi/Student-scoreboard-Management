namespace _1753081_Project2
{
    partial class ManagerForm
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
            this.ImportClass = new System.Windows.Forms.Button();
            this.ImportStudent = new System.Windows.Forms.Button();
            this.ImportSchedule = new System.Windows.Forms.Button();
            this.ViewStudents = new System.Windows.Forms.Button();
            this.ViewSchedule = new System.Windows.Forms.Button();
            this.ImportScrore = new System.Windows.Forms.Button();
            this.ViewScore = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Classes = new System.Windows.Forms.ComboBox();
            this.Subjects = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.NotiLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImportClass
            // 
            this.ImportClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportClass.Location = new System.Drawing.Point(15, 110);
            this.ImportClass.Name = "ImportClass";
            this.ImportClass.Size = new System.Drawing.Size(170, 30);
            this.ImportClass.TabIndex = 0;
            this.ImportClass.Text = "Import a class";
            this.ImportClass.UseVisualStyleBackColor = true;
            this.ImportClass.Click += new System.EventHandler(this.ImportClass_Click);
            // 
            // ImportStudent
            // 
            this.ImportStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStudent.Location = new System.Drawing.Point(15, 160);
            this.ImportStudent.Name = "ImportStudent";
            this.ImportStudent.Size = new System.Drawing.Size(170, 30);
            this.ImportStudent.TabIndex = 1;
            this.ImportStudent.Text = "Import a student";
            this.ImportStudent.UseVisualStyleBackColor = true;
            this.ImportStudent.Click += new System.EventHandler(this.ImportStudent_Click);
            // 
            // ImportSchedule
            // 
            this.ImportSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportSchedule.Location = new System.Drawing.Point(15, 210);
            this.ImportSchedule.Name = "ImportSchedule";
            this.ImportSchedule.Size = new System.Drawing.Size(170, 30);
            this.ImportSchedule.TabIndex = 2;
            this.ImportSchedule.Text = "Import a class schedule";
            this.ImportSchedule.UseVisualStyleBackColor = true;
            this.ImportSchedule.Click += new System.EventHandler(this.ImportSchedule_Click);
            // 
            // ViewStudents
            // 
            this.ViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudents.Location = new System.Drawing.Point(15, 330);
            this.ViewStudents.Name = "ViewStudents";
            this.ViewStudents.Size = new System.Drawing.Size(170, 30);
            this.ViewStudents.TabIndex = 3;
            this.ViewStudents.Text = "View student list";
            this.ViewStudents.UseVisualStyleBackColor = true;
            this.ViewStudents.Click += new System.EventHandler(this.ViewStudents_Click);
            // 
            // ViewSchedule
            // 
            this.ViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSchedule.Location = new System.Drawing.Point(15, 380);
            this.ViewSchedule.Name = "ViewSchedule";
            this.ViewSchedule.Size = new System.Drawing.Size(170, 30);
            this.ViewSchedule.TabIndex = 4;
            this.ViewSchedule.Text = "View class schedule";
            this.ViewSchedule.UseVisualStyleBackColor = true;
            this.ViewSchedule.Click += new System.EventHandler(this.ViewSchedule_Click);
            // 
            // ImportScrore
            // 
            this.ImportScrore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportScrore.Location = new System.Drawing.Point(15, 260);
            this.ImportScrore.Name = "ImportScrore";
            this.ImportScrore.Size = new System.Drawing.Size(170, 30);
            this.ImportScrore.TabIndex = 5;
            this.ImportScrore.Text = "Import scoreboard";
            this.ImportScrore.UseVisualStyleBackColor = true;
            this.ImportScrore.Click += new System.EventHandler(this.ImportScore_Click);
            // 
            // ViewScore
            // 
            this.ViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScore.Location = new System.Drawing.Point(15, 430);
            this.ViewScore.Name = "ViewScore";
            this.ViewScore.Size = new System.Drawing.Size(170, 30);
            this.ViewScore.TabIndex = 6;
            this.ViewScore.Text = "View scoreboard";
            this.ViewScore.UseVisualStyleBackColor = true;
            this.ViewScore.Click += new System.EventHandler(this.ViewScore_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.Location = new System.Drawing.Point(15, 500);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(170, 30);
            this.ChangePassword.TabIndex = 7;
            this.ChangePassword.Text = "Change password";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(15, 550);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(170, 30);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(210, 110);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(945, 500);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Classes
            // 
            this.Classes.Enabled = false;
            this.Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(263, 50);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(100, 24);
            this.Classes.TabIndex = 10;
            this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
            // 
            // Subjects
            // 
            this.Subjects.Enabled = false;
            this.Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjects.FormattingEnabled = true;
            this.Subjects.Location = new System.Drawing.Point(446, 50);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(250, 24);
            this.Subjects.TabIndex = 11;
            this.Subjects.SelectedIndexChanged += new System.EventHandler(this.Subjects_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(1075, 49);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(80, 25);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Enabled = false;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(970, 49);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(80, 25);
            this.ImportButton.TabIndex = 13;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // NotiLabel
            // 
            this.NotiLabel.AutoSize = true;
            this.NotiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotiLabel.ForeColor = System.Drawing.Color.Red;
            this.NotiLabel.Location = new System.Drawing.Point(207, 85);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(78, 17);
            this.NotiLabel.TabIndex = 14;
            this.NotiLabel.Text = "Notification";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(207, 51);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(50, 18);
            this.ClassLabel.TabIndex = 15;
            this.ClassLabel.Text = "Class:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(379, 51);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(61, 18);
            this.SubjectLabel.TabIndex = 16;
            this.SubjectLabel.Text = "Subject:";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.NotiLabel);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.ViewScore);
            this.Controls.Add(this.ImportScrore);
            this.Controls.Add(this.ViewSchedule);
            this.Controls.Add(this.ViewStudents);
            this.Controls.Add(this.ImportSchedule);
            this.Controls.Add(this.ImportStudent);
            this.Controls.Add(this.ImportClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2 - Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportClass;
        private System.Windows.Forms.Button ImportStudent;
        private System.Windows.Forms.Button ImportSchedule;
        private System.Windows.Forms.Button ViewStudents;
        private System.Windows.Forms.Button ViewSchedule;
        private System.Windows.Forms.Button ImportScrore;
        private System.Windows.Forms.Button ViewScore;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox Classes;
        private System.Windows.Forms.ComboBox Subjects;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label NotiLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label SubjectLabel;
    }
}