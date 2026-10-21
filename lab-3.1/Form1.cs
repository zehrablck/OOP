namespace lab_3
{
    public partial class Form1 : Form
    {
        int calculateFactorıal(int number)
        {
            int result = 1;
            if(number==0 || number==1)
            {
                return 1;
            }
            for(int i=1;i<=number;i++)
            {
                result *= i;
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(txtnum.Text);
            int result=calculateFactorıal(num);
            label4.Text = result.ToString();
        }
    }
}
