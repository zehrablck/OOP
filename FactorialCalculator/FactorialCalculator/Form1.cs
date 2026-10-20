namespace FactorialCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textnum1.Text);
            int num2 = int.Parse(textnum2.Text);
            Max(num1, num2);
        }
        private void Max(int number1, int number2)
        {
            if (number1 > number2)
            {
                MessageBox.Show("Maximum Num:" + number1);
            }
            else
            {
                MessageBox.Show("Maximum Num:" + number2);
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textnum1.Text);
            int num2 = int.Parse(textnum2.Text);

            if (num2 < 0)
            {
                MessageBox.Show("The exponent cannot be negative.");
                return;
            }

            Power(num1, num2);
        }
        private void Power(int number1, int number2)
        {
            int result = 1;
            for (int i = 1; i <= number2; i++)
            {
                result *= number1;
            }
            MessageBox.Show($"{number1} to the power of {number2} : " + result);
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textnum1.Text);

            IsPrime(num);
        }
        private void IsPrime(int number)
        {
            if (number < 2)
            {
                MessageBox.Show("This number is not a prime number.");
                return;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    MessageBox.Show("This number is not a prime number.");
                    return;
                }
            }
            MessageBox.Show("The number is a prime number.");
        }

        private void btnFactorıal_Click(object sender, EventArgs e)
        {
            int num=int.Parse(textnum1.Text);
            Factorıal(num);
        }
        private void Factorıal(int number)
        {
            int result=1;
            for(int i = 1;i <= number; i++)
            {
                result *= i;
            }
            MessageBox.Show($"The factorıal of the number {number} : {result}");
        }
    }
}
