using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab_3._2
{
    public partial class Form1 : Form
    {
        int sumDigits(int number)
        {
            int hundreds = (number / 100);
            int tens = (number % 100) / 10;
            int ones = number % 10;
            int sum = hundreds + tens + ones;
            return sum;
        }
        int countEvenDigits(int number)
        {
            int hundreds = (number / 100);
            int tens = (number % 100) / 10;
            int ones = number % 10;
            int count = 0;
            if(hundreds%2==0)
            {
                count++;
            }
            if(tens%2==0)
            {
                count++;
            }
            if(ones%2==0)
            {
                count++;
            }
            return count;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumDigits_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int result = sumDigits(num);
            label2.Text = result.ToString();

        }

        private void btnCountEven_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int result = countEvenDigits(num);
            label2.Text = result.ToString();
        }
    }
}
