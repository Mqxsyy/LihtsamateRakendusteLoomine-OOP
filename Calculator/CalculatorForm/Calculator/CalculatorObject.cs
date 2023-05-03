using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace Calculator
{
    // Made it this way since there was an issue with the library being .Net 6.0 and this project being .Net Framework 4.8
    // Functions Are Nearly The Same, Only Difference Being That This One Has EquationRaw Property
    public class CalculatorObject
    {
        private List<Char> chars = new List<char>();

        public void KeyPress(char key)
        {
            // Clear
            if (key == 'C')
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

        public string EquationRaw
        {
            get { return new string(chars.ToArray()); }
        }

        public string Equation
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

        public decimal Result
        {
            get
            {
                string equation = Equation;

                if (equation == null)
                    return 0;

                return Convert.ToDecimal(new DataTable().Compute(Equation, null));
            }
        }
    }
}
