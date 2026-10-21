namespace lab_3._3
{
    public partial class Form1 : Form
    {
        bool isPassıng(int score)
        {
            if (score >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        string getLetterGrade(int score)
        {
            if (score <= 100 && score >= 90)
            {
                return "A";
            }
            else if (score <= 89 && score >= 80)
            {
                return "B";
            }
            else if (score <= 79 && score >= 70)
            {
                return "C";
            }
            else if (score <= 69 && score >= 60)
            {
                return "D";
            }
            else if (score <= 59 && score >= 0)
            {
                return "F";
            }
            else
            {
                return "Error";
            }
        }
        int CalculateNeededScore(int score)
        {
            return 100 - score;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtScore.Text);
            if(isPassıng(num)==true)
            {
                lblResult.Text = "Pass";
            }
            else
            {
                lblResult.Text = "Fail";
            }
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtScore.Text);
            string result = getLetterGrade(num);
            lblResult.Text = result;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtScore.Text);
            int result = CalculateNeededScore(num);
            lblResult.Text = result.ToString();

        }
    }
}
