using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AE03_Zeiterfassung.Classes
{
    internal class SuperButton : Button
    {
        // private set -> lesen ist von außen erlaubt, setzen nur innerhalb der Klasse
        public User User { get; private set; }
        public IOSystem MainIO { get; private set; }
        public RichTextBox RtbLog { get; private set; }

        public SuperButton(User user, IOSystem mainIO, RichTextBox rtbLog)
        {
            this.Click += SuperButton_Click;
            this.User = user;
            this.MainIO = mainIO;
            this.RtbLog = rtbLog;

            this.Size = new Size(150, 50);
            this.BackColor = User.IsPresent ? Color.Green : Color.Red;
            this.Text = $"{User.LastName}, {User.FirstName}\nID: {User.Id}";
        }

        private void SuperButton_Click(object sender, EventArgs e)
        {
            ToggleStatus();
            MainIO.WriteUserState(User);
            MainIO.ParseLog(RtbLog);
        }

        private void ToggleStatus()
        {
            User.IsPresent = !User.IsPresent;
            this.BackColor = User.IsPresent ? Color.Green : Color.Red;
        }
    }
}
