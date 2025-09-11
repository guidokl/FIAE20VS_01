using AE03_Zeiterfassung.Classes;

namespace AE03_Zeiterfassung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IOSystem mainIO = new IOSystem();

            List<User> users = mainIO.LoadUsers();

            foreach (User user in users)
            {
                SuperButton superButton = new SuperButton(user, mainIO, rtbLog);
                superButton.Size = new Size(150, 50);
                superButton.BackColor = Color.Red;
                superButton.Text = $"{user.lastName}, {user.firstName}\nID: {user.id}";

                flowLayoutPanel1.Controls.Add(superButton);
            }
        }
    }
}
