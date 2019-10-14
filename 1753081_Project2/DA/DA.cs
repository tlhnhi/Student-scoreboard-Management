using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _1753081_Project2.Info;

namespace _1753081_Project2.DA
{
    public class StudentRepo
    {
        string connString = "Provider=SQLNCLI11;Server=DESKTOP-29S7I19\\SQLEXPRESS;Database=Project2Database;Trusted_Connection=yes;";

        public List<string> CheckAccount(string username, string password)
        {
            var loginUser = new List<string>();
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"select * from SinhVien where MSSV = '{username}' and MatKhau = '{password}'";
                var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    loginUser.Add(rd.GetString(0));
                    loginUser.Add(rd.GetString(2));
                }
                cnn.Close();
            }
            catch { }

            return loginUser;
        }

        public bool PasswordChanged(string username, string password)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"update SinhVien set MatKhau = '{password}' where MSSV = '{username}'";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<Information> GetDataFromFile(string fileName)
        {
            var data = new List<Information>();

            StreamReader reader = new StreamReader(fileName);
            string s = reader.ReadLine();

            string[] fileInfo = s.Split(',');
            var lineData = new Information();
            lineData.Id = fileInfo[0];
            if (fileInfo.Length > 1) lineData.Name = fileInfo[1];
            data.Add(lineData);

            s = reader.ReadLine();
            s = reader.ReadLine();
            while (s != null)
            {
                fileInfo = s.Split(',');
                lineData = new Information();

                lineData.Id = fileInfo[1];
                lineData.Name = fileInfo[2];
                lineData.Info = new string[fileInfo.Length - 3];
                for (int i = 3; i < fileInfo.Length; i++)
                    lineData.Info[i - 3] = fileInfo[i];

                data.Add(lineData);
                s = reader.ReadLine();
            }

            return data;
        }

        public List<Information> GetStudentsFromDB()
        {
            var data = new List<Information>();
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Select * from SinhVien";

                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    var lineData = new Information();

                    lineData.Id = rd.GetString(0);
                    if (lineData.Id == "giaovu    ") continue;
                    lineData.Name = rd.GetString(2);

                    lineData.Info = new string[4];
                    lineData.Info[0] = rd.GetString(3);
                    lineData.Info[1] = rd.GetDateTime(4).ToShortDateString();
                    lineData.Info[2] = rd.GetString(5);
                    lineData.Info[3] = rd.GetString(6);

                    data.Add(lineData);
                }
                cnn.Close();
            }
            catch { throw; }

            return data;
        }

        public List<string> GetClassesFromDB()
        {
            var classes = new List<string>();
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Select * from LopHoc";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                    classes.Add(rd.GetString(0));
                cnn.Close();
            }
            catch { }

            return classes;
        }

        public List<Information> GetScheduleFromDB()
        {
            var data = new List<Information>();
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Select * from MonHoc";

                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    var lineData = new Information();
                    lineData.Id = rd.GetString(0);
                    lineData.Name = rd.GetString(1);
                    lineData.Info = new string[2];
                    lineData.Info[0] = rd.GetString(2);
                    lineData.Info[1] = rd.GetString(3);

                    data.Add(lineData);
                }
                cnn.Close();
            }
            catch { throw; }

            return data;
        }

        public List<Information> GetScoreboardFromDB()
        {
            var data = new List<Information>();
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "Select * from BangDiem";

                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    var lineData = new Information();
                    lineData.Id = rd.GetString(0);
                    lineData.Name = rd.GetString(1);
                    lineData.Info = new string[5];
                    lineData.Info[0] = rd.GetString(2);
                    lineData.Info[1] = rd.GetDouble(3).ToString();
                    lineData.Info[2] = rd.GetDouble(4).ToString();
                    lineData.Info[3] = rd.GetDouble(5).ToString();
                    lineData.Info[4] = rd.GetDouble(6).ToString();

                    data.Add(lineData);
                }
                cnn.Close();
            }
            catch { throw; }

            return data;
        }

        public void InsertStudentToDB(Information Student, string Class)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Insert into SinhVien (MSSV, MatKhau, HoTen, MaLop, NgaySinh, GioiTinh, CMND) values " +
                    $"('{Student.Id}', '{Student.Info[2].Replace("/", "")}', N'{Student.Name}', '{Class}', " +
                    $"Convert(date, '{Student.Info[2]}', 103), N'{Student.Info[0]}', '{Student.Info[1]}')";
                cmd.ExecuteNonQuery();
                cnn.Close();
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
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Insert into LopHoc (MaLop) values ('{Class}')";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                throw;
            }
        }

        public void InsertSubjectToDB(Information Subject, string Class)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Insert into MonHoc (MaMon, MaLop, TenMon, PhongHoc) values " +
                    $"('{Subject.Id}', '{Class}', N'{Subject.Name}', '{Subject.Info[0]}')";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                throw;
            }
        }

        public void InsertScoreToDB(Information Student, string Class, string Subject)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Insert into BangDiem (MSSV, MaLop, MaMon, DiemGK, DiemCK, DiemKhac, DiemTong) values " +
                    $"('{Student.Id}', '{Class}', '{Subject}', {Student.Info[0]}," +
                    $" {Student.Info[1]}, {Student.Info[2]}, {Student.Info[3]})";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateScoreToDB(Information Student, string Class, string Subject)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = connString;
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"Update BangDiem Set DiemGK = {Student.Info[0]}, DiemCK = {Student.Info[1]}, " +
                    $"DiemKhac = {Student.Info[2]}, DiemTong = {Student.Info[3]}" +
                    $"Where MSSV = '{Student.Id}' and MaLop = '{Class}' and MaMon = '{Subject}'";
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}


