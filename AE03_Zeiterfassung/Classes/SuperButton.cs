using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE03_Zeiterfassung.Classes
{
    internal class SuperButton : Button
    {
        public User user;
        public IOSystem mainIO;
        public RichTextBox rtbLog;

        public SuperButton(User user, IOSystem mainIO, RichTextBox rtbLog)
        {
            this.Click += SuperButton_Click;
            this.user = user;
            this.mainIO = mainIO;
            this.rtbLog = rtbLog;
        }

        private void SuperButton_Click(object sender, EventArgs e)
        {
            ToggleStatus();
            mainIO.WriteUserState(user);
            mainIO.ParseLog(rtbLog);
        }

        public void ToggleStatus()
        {
            user.isPresent = !user.isPresent;
            if (user.isPresent)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
