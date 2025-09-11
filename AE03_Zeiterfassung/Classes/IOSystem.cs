using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE03_Zeiterfassung.Classes
{
    internal class IOSystem
    {
        public List<User> LoadUsers()
        {
            List<User> users = new List<User>();
            int userid = 0;
            foreach (string line in File.ReadLines("./Data/userlist.txt"))
            {
                string[] parts = line.Split(";");
                // ensure line contains at least two data entries
                if (parts.Length >= 2)
                {
                    User user = new User()
                    {
                        id = userid,
                        firstName = parts[0].Trim(),
                        lastName = parts[1].Trim(),
                        isPresent = false
                    };
                    users.Add(user);
                }
                userid++;
            }
            return users;
        }

        public void WriteUserState(User user)
        {
            string action = user.isPresent ? "kommt" : "geht";
            string timelogEntry = $"{DateTime.Now};{user.id};{user.lastName};{user.firstName};{action}";
            File.AppendAllText("./Data/timelog.txt", timelogEntry + Environment.NewLine);
        }

        public void ParseLog(RichTextBox rtbLog)
        {
            if (File.Exists("./Data/timelog.txt"))
            {
                rtbLog.Text = File.ReadAllText("./Data/timelog.txt");
            }
            else
            {
                rtbLog.Text = "Log file not found.";
            }
        }
    }
}
