using System.Data;
using System.Text.RegularExpressions;

namespace CalculatorLib
{
    public class Calculator
    {
        private List<Char> chars = new List<char>();

        public void KeyPress(char key)
        {
            // Clear
            if (key == char.Parse("C"))
            {
                ClearData();
                return;
            }

            // Check If Entered Character Is Acceptable
            if (Regex.Matches(key.ToString(), @"[0-9\+\-\*\/\.]").Count == 0)
                return;

            // Prevent Double Special Symbols
            if (Regex.Matches(key.ToString(), @"[+\-\*\/\.]").Count > 0 && chars.Count != 0)
            {
                if (Regex.Matches(chars[chars.Count - 1].ToString(), @"[0-9]").Count == 0)
                    return;
            }

            chars.Add(key);
        }

        public void ClearData()
        {
            chars.Clear();
        }

        public string? Equation
        {
            get
            {
                if (chars.Count == 0)
                    return null;

                // If Last Symbol Entered Is A Special Symbol Then Remove It
                if (Regex.Matches(chars[chars.Count - 1].ToString(), @"[+\-\*\/\.]").Count > 0)
                    chars.RemoveAt(chars.Count - 1);

                return new string(chars.ToArray());
            }
        }

        public decimal? Result
        {
            get
            {
                string? equation = Equation;

                if (equation == null)
                    return null;

                return Convert.ToDecimal(new DataTable().Compute(Equation, null));
            }
        }
    }
}
