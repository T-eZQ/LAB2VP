using System;
using System.Text;
using lab2.exc;

namespace lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort Number;

        private static short[] Val = new short[]
        { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        private static string[] Numerals = new string[]
        { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private short ToShort()
        {
            short res = ((short)Number);
            return res;
        }

        public RomanNumber(ushort n)
        {
            short CheckException = ((short)n);
            if (n <= 0)
            {
                throw new RomanNumberException("InvalidValueException: Число должно было быть больше 0");
            }
            Number = n;
        }

        public static RomanNumber Add(RomanNumber? ts1, RomanNumber? ts2)
        {
            ushort result = 0;
            short num1 = ts1.ToShort();
            short num2 = ts2.ToShort();
            short num3 = ((short)(num2 + num1));
            result = ((ushort)num3);
            RomanNumber res = new RomanNumber(result);
            return res;
        }

        public static RomanNumber Sub(RomanNumber? ts1, RomanNumber? ts2)
        {
            ushort result = 0;
            short num1 = ts1.ToShort();
            short num2 = ts2.ToShort();
            short num3 = ((short)(num1 - num2));
            if (num3 <= 0)
            {
                throw new RomanNumberException("\nInvalidValueException: Значение выражения (" + num3.ToString() + ") должно быть больше 0");
            }
            else
            {
                result = ((ushort)num3);
                RomanNumber res = new RomanNumber(result);
                return res;
            }
        }

        public static RomanNumber Mul(RomanNumber? ts1, RomanNumber? ts2)
        {
            ushort result = 0;
            short num1 = ts1.ToShort();
            short num2 = ts2.ToShort();
            short num3 = ((short)(num2 * num1));
            result = ((ushort)num3);
            RomanNumber res = new RomanNumber(result);
            return res;
        }

        public static RomanNumber Div(RomanNumber? ts1, RomanNumber? ts2)
        {
            ushort result = 0;
            short num1 = ts1.ToShort();
            short num2 = ts2.ToShort();
            short num3 = ((short)(num1 / num2));
            if (num3 <= 0)
            {
                throw new RomanNumberException("InvalidValueException: Значение выражения (" + num3.ToString() + "должно быть больше 0)");
            }
            else
            {
                result = ((ushort)(num3));
                RomanNumber res = new RomanNumber(result);
                return res;
            }
        }

        public override string ToString()
        {
            StringBuilder NumberInRomanSystem = new StringBuilder();

            int Range = 13;

            short Temp = ((short)Number);

            for (int i = 0; i < Range; ++i)
            {
                while (Temp >= Val[i])
                {
                    Temp -= Val[i];
                    NumberInRomanSystem.Append(Numerals[i]);
                }
            }

            return NumberInRomanSystem.ToString();
        }

        public object Clone()
        {
            return new RomanNumber(Number);
        }

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber rom) return ((short)Number).CompareTo(rom.ToShort());
            else throw new RomanNumberException("InvaludValueException: Некорректное значение параметра");
        }
    }
}