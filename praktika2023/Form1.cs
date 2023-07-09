namespace praktika2023
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AreAllTextBoxesFilled(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9))
            {
                if (double.TryParse(textBox1.Text, out double x1) && double.TryParse(textBox2.Text, out double y1) &&
                    double.TryParse(textBox3.Text, out double z1) && double.TryParse(textBox4.Text, out double x2) &&
                    double.TryParse(textBox5.Text, out double y2) && double.TryParse(textBox6.Text, out double z2) &&
                    double.TryParse(textBox7.Text, out double x3) && double.TryParse(textBox8.Text, out double y3) &&
                    double.TryParse(textBox9.Text, out double z3))
                {
                    Points A = new Points(x1, y1, z1);
                    Points B = new Points(x2, y2, z2);
                    Points C = new Points(x3, y3, z3);
                    double S = A.TriangleSquare(B, C);
                    ShowResult(label1, S.ToString());
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (AreAllTextBoxesFilled(textBox10, textBox11, textBox12, textBox13, textBox14, textBox15))
            {
                if (double.TryParse(textBox10.Text, out double x1) && double.TryParse(textBox11.Text, out double y1) &&
                    double.TryParse(textBox12.Text, out double z1) && double.TryParse(textBox13.Text, out double x2) &&
                    double.TryParse(textBox14.Text, out double y2) && double.TryParse(textBox15.Text, out double z2))
                {
                    Points A = new Points(x1, y1, z1);
                    Points B = new Points(x2, y2, z2);
                    double distance = Math.Round(A.DistanceTo(B), 2);
                    ShowResult(label2, distance.ToString());
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (AreAllTextBoxesFilled(textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24))
            {
                if (double.TryParse(textBox16.Text, out double x) && double.TryParse(textBox17.Text, out double y) &&
                    double.TryParse(textBox18.Text, out double z) && double.TryParse(textBox19.Text, out double a) &&
                    double.TryParse(textBox20.Text, out double b) && double.TryParse(textBox21.Text, out double c) &&
                    double.TryParse(textBox22.Text, out double d) && double.TryParse(textBox23.Text, out double e1) &&
                    double.TryParse(textBox24.Text, out double f))
                {
                    Points A = new Points(x, y, z);
                    Line L = new Line(a, b, c, d, e1, f);
                    double distance = A.DistanceToLine(L);
                    ShowResult(label3, distance.ToString());
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private bool AreAllTextBoxesFilled(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void ShowResult(Label label, string result)
        {
            label.Text = result;
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Не все координаты были указаны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
