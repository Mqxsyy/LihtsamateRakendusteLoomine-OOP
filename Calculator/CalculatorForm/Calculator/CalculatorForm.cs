using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private bool _showingResult = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddInput('0');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddInput('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddInput('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddInput('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddInput('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddInput('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddInput('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddInput('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddInput('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddInput('9');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInput('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            AddInput('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddInput('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AddInput('/');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtResult.Text = Program.Calculator.Result.ToString();
            _showingResult = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddInput('C');
        }

        private void AddInput(char c)
        {
            if (_showingResult)
            {
                StartFromResult();
                _showingResult = false;
            }

            Program.Calculator.KeyPress(c);
            txtResult.Text = Program.Calculator.EquationRaw;
        }

        private void StartFromResult()
        {
            string result = Program.Calculator.Result.ToString();
            Program.Calculator.ClearData();

            foreach (char c in result)
            {
                Program.Calculator.KeyPress(c);
            }

            txtResult.Text = Program.Calculator.EquationRaw;
        }
    }
}