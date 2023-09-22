namespace student_marks_and_grades_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n01, n02, n03, sum;
            double avg;

            n01 = Convert.ToInt32(this.txt3.Text);
            n02 = Convert.ToInt32(this.txt4.Text);
            n03 = Convert.ToInt32(this.txt5.Text);

            sum = n01 + n02 + n03;
            avg = sum / 3.00;

            this.txt6.Text = avg.ToString();

            if (avg < 45)
            {
                this.txt7.Text = "F";
                this.txt7.BackColor = Color.Red;
            }
            else if (avg < 60)
            {
                this.txt7.Text = "S";
                this.txt7.BackColor = Color.Yellow;
            }
            else if (avg < 75)
            {
                this.txt7.Text = "B";
                this.txt7.BackColor = Color.Blue;
            }
            else if (avg <= 100)
            {
                this.txt7.Text = "A";
                this.txt7.BackColor = Color.Green;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}