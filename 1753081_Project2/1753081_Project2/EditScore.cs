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
    public partial class EditScore : Form
    {
        public EditScore(ListViewItem currStudent)
        {
            InitializeComponent();
            NotiLabel.Text = "";
            sID.Text = currStudent.SubItems[1].Text;
            Name.Text = currStudent.SubItems[2].Text;
            Class.Text = currStudent.SubItems[3].Text;
            Subject.Text = currStudent.SubItems[4].Text;
            Mid.Text = currStudent.SubItems[5].Text;
            Final.Text = currStudent.SubItems[6].Text;
            Other.Text = currStudent.SubItems[7].Text;
            Score.Text = currStudent.SubItems[8].Text;
            label4.BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            float mid = -1, final = -1, other = -1, score = -1;
            float.TryParse(Mid.Text, out mid);
            if (mid < 0 || mid > 10)
            {
                NotiLabel.Text = "Mid-term score must be between 0 and 10.";
                return;
            }
            float.TryParse(Final.Text, out final);
            if (final < 0 || final > 10)
            {
                NotiLabel.Text = "Final-term score must be between 0 and 10.";
                return;
            }
            float.TryParse(Other.Text, out other);
            if (other < 0 || other > 10)
            {
                NotiLabel.Text = "Other score must be between 0 and 10.";
                return;
            }
            float.TryParse(Score.Text, out score);
            if (score < 0 || score > 10)
            {
                NotiLabel.Text = "Final score must be between 0 and 10.";
                return;
            }

            var newInfo = new Information();
            newInfo.Id = sID.Text;
            newInfo.Info = new string[4];
            newInfo.Info[0] = mid.ToString();
            newInfo.Info[1] = final.ToString();
            newInfo.Info[2] = other.ToString();
            newInfo.Info[3] = score.ToString();

            try
            {
                var service = new StudentServices();
                string temp = $"Update BangDiem Set DiemGK = {newInfo.Info[0]}, DiemCK = {newInfo.Info[1]}, " +
                    $"DiemKhac = {newInfo.Info[2]}, DiemTong = {newInfo.Info[3]}" +
                    $"Where MSSV = '{newInfo.Id}' and MaLop = '{Class.Text}' and MaMon = '{Subject.Text}'";
                MessageBox.Show(temp);
                if (service.InsertScoreToDB(newInfo, Class.Text, Subject.Text)) Close();
                else MessageBox.Show($"Score of this student cannot be update!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Score of this student cannot be update!!" + Environment.NewLine + ex.Message);
            }
        }
    }
}
