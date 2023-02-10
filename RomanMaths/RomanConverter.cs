using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanMaths
{
    /// <summary>
    /// Преобразователь чисел из арабских в римские и обратно.
    /// </summary>
    internal static class RomanConverter
    {
        /// <summary>
        /// Конвертим римские цифры в арабские
        /// (XV+XLVII)*XIII->(15+47)*13
        /// </summary>
        /// <param name="dig"></param>
        /// <returns></returns>
        public static string RomanToNum(string dig)
        {
            Roman v;
            if (Enum.TryParse<Roman>(dig, out v))
                return ((short)v).ToString();
            return dig;
        }
        /// <summary>
        /// Конвертим арабские цифры в римские
        /// (15+47)*13->(XV+XLVII)*XIII
        /// </summary>
        /// <param name="dig"></param>
        /// <returns></returns>
        public static string NumToRoman(string dig)
        {
            short v;
            if (short.TryParse(dig, out v))
                return ((Roman)v).ToString();
            return dig;
        }
    }
}
