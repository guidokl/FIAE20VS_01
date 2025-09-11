using System.Collections.Generic;

namespace AE02_VectorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(GetVec1());
                Vector v2 = new Vector(GetVec2());

                SetErg(v1.Add(v2));

                toolStripStatusLabel1.Text = "Vektorsumme";
            }
            catch (ArgumentException ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(GetVec1());
                Vector v2 = new Vector(GetVec2());

                SetErg(v1.Sub(v2));

                toolStripStatusLabel1.Text = "Vektordifferenz";
            }
            catch (ArgumentException ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(GetVec1());
                Vector v2 = new Vector(GetVec2());

                tbVecErg_a.Text = v1.Mul(v2).ToString();
                tbVecErg_b.Text = "";
                tbVecErg_c.Text = "";
                tbVecErg_d.Text = "";
                tbVecErg_e.Text = "";

                toolStripStatusLabel1.Text = "Skalarprodukt";
            }
            catch (ArgumentException ex)
            {
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            tbVec2_b.Text = "";
            tbVec2_c.Text = "";
            tbVec2_d.Text = "";
            tbVec2_e.Text = "";

            Vector v1 = new Vector(GetVec1());
            Vector v2 = new Vector(GetVec2());

            SetErg(v1.Div(v2));

            toolStripStatusLabel1.Text = "Division durch Skalar";
        }

        private double[] GetVec1()
        {
            List<double> vec1 = new List<double>();

            if (!string.IsNullOrWhiteSpace(tbVec1_a.Text))
                vec1.Add(double.Parse(tbVec1_a.Text));
            if (!string.IsNullOrWhiteSpace(tbVec1_b.Text))
                vec1.Add(double.Parse(tbVec1_b.Text));
            if (!string.IsNullOrWhiteSpace(tbVec1_c.Text))
                vec1.Add(double.Parse(tbVec1_c.Text));
            if (!string.IsNullOrWhiteSpace(tbVec1_d.Text))
                vec1.Add(double.Parse(tbVec1_d.Text));
            if (!string.IsNullOrWhiteSpace(tbVec1_e.Text))
                vec1.Add(double.Parse(tbVec1_e.Text));

            return vec1.ToArray();
        }

        private double[] GetVec2()
        {
            List<double> vec2 = new List<double>();

            if (!string.IsNullOrWhiteSpace(tbVec2_a.Text))
                vec2.Add(double.Parse(tbVec2_a.Text));
            if (!string.IsNullOrWhiteSpace(tbVec2_b.Text))
                vec2.Add(double.Parse(tbVec2_b.Text));
            if (!string.IsNullOrWhiteSpace(tbVec2_c.Text))
                vec2.Add(double.Parse(tbVec2_c.Text));
            if (!string.IsNullOrWhiteSpace(tbVec2_d.Text))
                vec2.Add(double.Parse(tbVec2_d.Text));
            if (!string.IsNullOrWhiteSpace(tbVec2_e.Text))
                vec2.Add(double.Parse(tbVec2_e.Text));

            return vec2.ToArray();
        }

        private void SetErg(Vector vErg)
        {
            var values = vErg.GetVector();

            if (values.Length > 0)
                tbVecErg_a.Text = values[0].ToString();
            if (values.Length > 1)
                tbVecErg_b.Text = values[1].ToString();
            if (values.Length > 2)
                tbVecErg_c.Text = values[2].ToString();
            if (values.Length > 3)
                tbVecErg_d.Text = values[3].ToString();
            if (values.Length > 4)
                tbVecErg_e.Text = values[4].ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
