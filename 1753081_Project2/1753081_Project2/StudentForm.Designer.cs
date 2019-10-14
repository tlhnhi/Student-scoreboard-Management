namespace _1753081_Project2
{
    partial class StudentForm
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
            this.StuChangePass = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Hello = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this._No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Score1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Score2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Score3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Score4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StuChangePass
            // 
            this.StuChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuChangePass.Location = new System.Drawing.Point(441, 12);
            this.StuChangePass.Name = "StuChangePass";
            this.StuChangePass.Size = new System.Drawing.Size(130, 40);
            this.StuChangePass.TabIndex = 1;
            this.StuChangePass.Text = "Change password";
            this.StuChangePass.UseVisualStyleBackColor = true;
            this.StuChangePass.Click += new System.EventHandler(this.StuChangePass_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(577, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(65, 40);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.Location = new System.Drawing.Point(12, 21);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(13, 20);
            this.Hello.TabIndex = 3;
            this.Hello.Text = ".";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._No,
            this._Id,
            this._Class,
            this._Name,
            this._Score1,
            this._Score2,
            this._Score3,
            this._Score4});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(16, 58);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(625, 290);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // _No
            // 
            this._No.Text = "No.";
            this._No.Width = 30;
            // 
            // _Id
            // 
            this._Id.Text = "Subject ID";
            this._Id.Width = 80;
            // 
            // _Class
            // 
            this._Class.Text = "Class ID";
            this._Class.Width = 80;
            // 
            // _Name
            // 
            this._Name.Text = "Subject Name";
            this._Name.Width = 135;
            // 
            // _Score1
            // 
            this._Score1.Text = "Mid-term score";
            this._Score1.Width = 70;
            // 
            // _Score2
            // 
            this._Score2.Text = "Final-term score";
            this._Score2.Width = 70;
            // 
            // _Score3
            // 
            this._Score3.Text = "Other score";
            this._Score3.Width = 70;
            // 
            // _Score4
            // 
            this._Score4.Text = "Final score";
            this._Score4.Width = 70;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.StuChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2 - Student Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StuChangePass;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader _No;
        private System.Windows.Forms.ColumnHeader _Id;
        private System.Windows.Forms.ColumnHeader _Class;
        private System.Windows.Forms.ColumnHeader _Name;
        private System.Windows.Forms.ColumnHeader _Score1;
        private System.Windows.Forms.ColumnHeader _Score2;
        private System.Windows.Forms.ColumnHeader _Score3;
        private System.Windows.Forms.ColumnHeader _Score4;
    }
}