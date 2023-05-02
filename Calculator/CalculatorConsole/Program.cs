using CalculatorLib;

namespace CalculatorConsole
{
    class Program
    {
        private static Calculator calculator = new Calculator();
        
        static void Main(string[] args)
        {
            Calculate("");
            Calculate("1");
            Calculate("15-5/2");
            Calculate("2*3-1/5+8");
            Calculate("4+2C2+3");
            Calculate("500-20++2/abc=n");
        }

        static void Calculate(string expression)
        {
            calculator.ClearData();

            foreach (var c in expression)
            {
                calculator.KeyPress(c);
            }

            string? equation = calculator.Equation;
            if (equation == null)
                return;

            Console.Write(equation);
            Console.Write(" = "); 
            Console.Write(calculator.Result + "\n");
        }
    }
}
