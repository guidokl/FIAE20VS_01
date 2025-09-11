namespace AE01_BruchGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SuperEvent3000(object sender, EventArgs e)
        {
            Bruch br1 = new Bruch(int.Parse(tbZaehler1.Text), int.Parse(tbNenner1.Text));

            Bruch br2;
            br2 = new Bruch(int.Parse(tbZaehler2.Text), int.Parse(tbNenner2.Text));

            Button btnSender = (Button)sender;


            Bruch br3;
            if (btnSender.Text == "/")
            {
                br3 = br1.Div(br2);
            }
            else if (btnSender.Text == "+")
            {
                br3 = br1.Add(br2);
            }
            else if (btnSender.Text == "-")
            {
                br3 = br1.Sub(br2);
            }
            else
            {
                br3 = br1.Mult(br2);
            }


            Bruch brGekuerzt = br3.Kuerzen();

            tbErgZaehler.Text = brGekuerzt.GetZaehler().ToString();
            tbErgNenner.Text = "" + brGekuerzt.GetNenner();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bruch br1 = new Bruch(int.Parse(tbZaehler1.Text), int.Parse(tbNenner1.Text));

            Bruch br2;
            br2 = new Bruch(int.Parse(tbZaehler2.Text), int.Parse(tbNenner2.Text));

            ComboBox btnSender = (ComboBox)sender;


            Bruch br3;
            if (btnSender.SelectedText == "/")
            {
                br3 = br1.Div(br2);
            }
            else if (btnSender.SelectedText == "+")
            {
                br3 = br1.Add(br2);
            }
            else if (btnSender.SelectedText == "-")
            {
                br3 = br1.Sub(br2);
            }
            else
            {
                br3 = br1.Mult(br2);
            }


            Bruch brGekuerzt = br3.Kuerzen();

            tbErgZaehler.Text = brGekuerzt.GetZaehler().ToString();
            tbErgNenner.Text = "" + brGekuerzt.GetNenner();
        }
    }
}
