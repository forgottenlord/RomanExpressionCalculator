using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingSeb.ExpressionEvaluator;

namespace RomanMaths
{
    /// <summary>
    /// Декоратор обработчика выражений с конвертацией римских чисел до 3999(MMMCMXCIX).
    /// </summary>
    public static class RomanMathCalculator
    {
        private static string[] splitters = new string[] { "(", ")", "+", "-", "*", "/", "^" };
        public static ExpressionEvaluator evaluator;
        static RomanMathCalculator()
        {
            evaluator = new ExpressionEvaluator()
            {
                OptionScriptNeedSemicolonAtTheEndOfLastExpression = false,
                OptionCaseSensitiveEvaluationActive = false
            };
            evaluator.Namespaces.Add("System.Windows");
            evaluator.Namespaces.Add("System.Diagnostics");
        }
        /// <summary>
        /// Про
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static string CalculateExpression(string expression)
        {
            string script = evaluator.RemoveComments(expression);
            int iterations = 1;
            string innerResult = "null or void";
            for (int i = 0; i < iterations; i++)
                innerResult = evaluator.ScriptEvaluate(script)?.ToString() ?? "null or void";

            return innerResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Evalute(string input)
        {
            try
            {
                string[] digits = input.Trim().Split(splitters, StringSplitOptions.None).Where(x => !string.IsNullOrEmpty(x)).ToArray();

                string result = input;
                for (int n = 0; n < digits.Length; n++)
                {
                    result = result.Replace(digits[n], RomanConverter.RomanToNum(digits[n]));
                }
                return RomanConverter.NumToRoman(RomanMathCalculator.CalculateExpression(result));
            }
            catch
            {
                return "Wrong format";
            }
        }
    }
}
