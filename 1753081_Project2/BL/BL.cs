using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _1753081_Project2.DA;
using _1753081_Project2.Info;

namespace _1753081_Project2.BL
{
    public class StudentServices
    {
        public List<string> LoginAccess(string username, string password)
        {
            StudentRepo repo = new StudentRepo();
            if ((username != "giaovu" && password.Length < 8) || password.Length > 16)
                return new List<string>();
            return repo.CheckAccount(username, password);
        }

        public string ChangePassword(string username, string password, string newPassword)
        {
            StudentRepo repo = new StudentRepo();
            List<string> user = repo.CheckAccount(username, password);
            if (user.Count == 0) return "Current password is not correct.";
            if (repo.PasswordChanged(username, newPassword))
                return "Password has been changed successfully.";
            else return "Cannot change the password.";
        }

        public List<Information> GetDataFromFile(string fileName)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var data = repo.GetDataFromFile(fileName);
                return data;
            }
            catch { throw; }
        }

        public List<Information> GetStudentsFromDB(string Class, string Subject)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var Data = repo.GetStudentsFromDB();
                if (Class == "All" && Subject == "All") return Data;

                List<Information> students = new List<Information>();
                if (Class != "All" && Subject == "All")
                {
                    foreach (Information data in Data)
                        if (data.Info[0].Contains(Class)) students.Add(data);
                }
                var scoreboard = repo.GetScoreboardFromDB();
                foreach (Information sb in scoreboard)
                    if ((sb.Name.Contains(Class) || Class == "All") && Subject.Contains(sb.Info[0]))
                        foreach (Information data in Data)
                            if (data.Id == sb.Id)
                            {
                                Data.Remove(data);
                                students.Add(data);
                                break;
                            }
                return students;
            }
            catch { throw; }
        }

        public List<string> GetClassesFromDB(string Subject)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var data = repo.GetClassesFromDB();
                if (Subject == "All") return data;

                List<string> classes = new List<string>();
                var Schedule = repo.GetScheduleFromDB();

                foreach (Information sche in Schedule)
                    if (sche.Id + " - " + sche.Info[0] == Subject && !classes.Contains(sche.Name))
                        classes.Add(sche.Name);
                return classes;
            }
            catch { throw; }
        }

        public List<string> GetSubjectFromDB(string Class)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                List<string> subjects = new List<string>();
                var Schedule = repo.GetScheduleFromDB();

                foreach (Information sche in Schedule)
                    if ((sche.Name.Contains(Class) || Class == "All") && !subjects.Contains(sche.Id))
                        subjects.Add(sche.Id + " - " + sche.Info[0]);
                return subjects;
            }
            catch { throw; }
        }

        public List<Information> GetScoreboardFromDB(string Class, string Subject)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var Student = repo.GetStudentsFromDB();
                var Data = repo.GetScoreboardFromDB();
                List<Information> scoreboard = new List<Information>();
                foreach (Information data in Data)
                    if ((data.Name.Contains(Class) || Class == "All") && (Subject == "All" || Subject.Contains(data.Info[0])))
                        foreach (Information student in Student)
                            if (data.Id == student.Id)
                            {
                                Information newInfo = new Information();
                                newInfo.Id = data.Id;
                                newInfo.Name = student.Name;
                                newInfo.Info = new string[7];
                                newInfo.Info[0] = student.Info[0];
                                newInfo.Info[1] = data.Info[0];
                                newInfo.Info[2] = data.Info[1];
                                newInfo.Info[3] = data.Info[2];
                                newInfo.Info[4] = data.Info[3];
                                newInfo.Info[5] = data.Info[4];
                                float finalScore;
                                float.TryParse(newInfo.Info[5], out finalScore);
                                if (finalScore >= 5) newInfo.Info[6] = "Yes";
                                else newInfo.Info[6] = "No";
                                scoreboard.Add(newInfo);
                                break;
                            }
                return scoreboard;
            }
            catch { throw; }
        }

        public List<Information> GetScoreFromDB(string sID)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var Schedule = repo.GetScheduleFromDB();
                var Data = repo.GetScoreboardFromDB();
                List<Information> scoreboard = new List<Information>();
                foreach (Information data in Data)
                    if (data.Id.Contains(sID))
                        foreach (Information schedule in Schedule)
                            if (data.Info[0] == schedule.Id)
                            {
                                Information newInfo = new Information();
                                newInfo.Id = data.Info[0];
                                newInfo.Name = schedule.Name;
                                newInfo.Info = new string[5];
                                newInfo.Info[0] = schedule.Info[0];
                                newInfo.Info[1] = data.Info[1];
                                newInfo.Info[2] = data.Info[2];
                                newInfo.Info[3] = data.Info[3];
                                newInfo.Info[4] = data.Info[4];
                                
                                scoreboard.Add(newInfo);
                                break;
                            }
                return scoreboard;
            }
            catch
            {
                throw;
            }
        }

        public List<Information> GetScheduleFromDB(string Class, string Subject)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                var Data = repo.GetScheduleFromDB();
                List<Information> scoreboard = new List<Information>();
                foreach (Information data in Data)
                    if ((data.Name.Contains(Class) || Class == "All") && (Subject == "All" || Subject.Contains(data.Info[0])))
                        scoreboard.Add(data);
                return scoreboard;
            }
            catch { throw; }
        }

        public void InsertStudentToDB(Information Student, string Class)
        {
            try
            {
                StudentRepo repo = new StudentRepo();
                repo.InsertStudentToDB(Student, Class);
            }
            catch
            {
                throw;
            }
        }

        public void InsertClassToDB(string Class)
        {
            try
            {
                StudentRepo repo = new StudentRepo();
                repo.InsertClassToDB(Class);
            }
            catch
            {
                throw;
            }
        }

        public void InsertScheduleToDB(Information Subject, string Class)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                repo.InsertSubjectToDB(Subject, Class);
            }
            catch
            {
                throw;
            }

            var Students = GetStudentsFromDB(Class, "All");
            foreach (Information student in Students)
                try
                {
                    var newScore = new Information();
                    newScore.Id = student.Id;
                    newScore.Info = new string[4];
                    newScore.Info[0] = "0";
                    newScore.Info[1] = "0";
                    newScore.Info[2] = "0";
                    newScore.Info[3] = "0";
                    repo.InsertScoreToDB(newScore, Class, Subject.Id);
                }
                catch { throw; }
        }

        public bool InsertScoreToDB(Information Student, string Class, string Subject)
        {
            StudentRepo repo = new StudentRepo();
            try
            {
                repo.InsertScoreToDB(Student, Class, Subject);
                return true;
            }
            catch { }
            try
            {
                repo.UpdateScoreToDB(Student, Class, Subject);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
