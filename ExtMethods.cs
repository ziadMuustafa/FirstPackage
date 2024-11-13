using NumericSystemConverter.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NumericSystemConverter
{
    public static class ExtMethods
    {

        public static void TypeBaseCheck(this string value, string AllowableChars)
        { // "01"

            foreach (char Char in value)
            {

                if (!AllowableChars.Contains(Char))
                {

                    throw new InvalidDataException("Unallowed digits used");

                }

            }

        }


        public static string SystemConverterTo<T>(this T source, NumberBase ConvertTo) where T : Base
        {

            

                NumberBase FromBase;

                switch (source)
                {



                    case Binary:
                        FromBase = NumberBase.Bin; break;


                    case Octal:
                        FromBase = NumberBase.Oct; break;


                    case Hexdecimal:
                        FromBase = NumberBase.Hex; break;


                    case Decimal1:
                        FromBase = NumberBase.Dec; break;

                    default: FromBase = NumberBase.Bin;  break;


                }


            return Convert.ToString(Convert.ToInt32(source.Value, (int)FromBase) , (int)ConvertTo);


        }
    }
}
