namespace Session_06
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        int count;
        public Calculator.Calc calc = new Calculator.Calc();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
            count = 1;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
            count = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
            count = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calc.Compute(4, operand1, operand2, input=string.Empty, '/');
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            {
                calc.Compute(count, operand1, operand2, input, operation);  
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calc.Clear(count, operand1,operand2, input);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 0;
            this.textBox1.Text += input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;     
            input = string.Empty;
            count = 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operand1 = input; 
            input = string.Empty;
            count = 6;
        }

       
        }
    }
