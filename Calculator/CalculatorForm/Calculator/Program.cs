using System;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        public static CalculatorObject Calculator = new CalculatorObject();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
