using System.Linq.Expressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
            int num1 = int.Parse(textBox1.Text.Substring(0,1));
            char op = char.Parse(textBox1.Text.Substring(1,1));
            int num2 = int.Parse(textBox1.Text.Substring(2,1));
            int result=0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            textBox1.Text += result.ToString();


        }
    }
}