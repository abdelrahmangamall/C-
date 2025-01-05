using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamand_IO_35.Models
{
    public static class NumberSystemExtensions
    {
        // should public, static, and this in parameter
        public static void Guard(this string source, string allwoChar, NumberBase numberBase)
        {
            foreach(var c in source)
            {
                if (!allwoChar.Contains(c))
                    throw new Exception($"{source} is invalied {numberBase} format");
            }
        }
        public static string To<T>(this T source, NumberBase ToBase) where T: Base
        {
            NumberBase fromBase;
            switch (source)
            {
                case BinarySystem: fromBase = NumberBase.Binary; break;
                case DecimalSystem: fromBase = NumberBase.Decimal; break;
                case HexaDeciamlSystem: fromBase = NumberBase.HexaDecimal; break;
                case OctalSystem: fromBase = NumberBase.Octal; break;
                default: fromBase = NumberBase.Decimal; break;
            }
            return Convert.ToString(Convert.ToInt32(source.Value,(int)fromBase),(int)ToBase);
          //return Convert.ToString(Convert.ToInt32(source.Value,(int)fromBase),(int)ToBase);

        }
    }
}
