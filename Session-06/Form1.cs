using Calculator;

namespace Session_06
{
    public partial class Form1 : Form
    {
        public Calc Calc { get; set; }
        public Reader Reader { get; set; }
        public FinalResult Result { get; set; }
        public Comma Dot { get; set; }


        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();
            Reader = new Reader();
            Result = new FinalResult();
            Dot = new Comma();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Handler(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber2.Text, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber3.Text, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber4.Text, textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber5.Text, textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber6.Text, textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber7.Text, textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber8.Text, textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber9.Text, textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.Add, textBox1.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.Minus, textBox1.Text);
            
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.Multiply, textBox1.Text);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.Divide, textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.Equals(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calc.Clear(textBox1.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Reader.ButtonReader(buttonNumber0.Text, textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Dot.Dot(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.Power, textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = Result.ValueAndOperator((int)Calculator.MathOperations.SquareRoot, textBox1.Text);
            textBox1.Text = Result.Equals(textBox1.Text);
        }
        private void Handler(object sender)
        {
            textBox1.Text = Reader.ButtonReader(sender, textBox1.Text);
        }
    }
}

