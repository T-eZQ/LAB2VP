

using System;
/*************************/

using lab2;

namespace lab2t
{
    class Program
    {

        private static void lab2()
        {
            ushort num1 = ((ushort)456);
            RomanNumber rom1 = new RomanNumber(num1);
            ushort num2 = ((ushort)321);
            RomanNumber rom2 = new RomanNumber(num2);
            Console.WriteLine("456 = " + rom1.ToString());
            Console.WriteLine("321 = " + rom2.ToString());
            Console.WriteLine("456 + 321 = 777 -> " + rom1.ToString() + " + " + rom2.ToString() + " = " + RomanNumber.Add(rom1, rom2));
            Console.WriteLine("456 - 321 = 777 -> " + rom1.ToString() + " - " + rom2.ToString() + " = " + RomanNumber.Sub(rom1, rom2));
            ushort num3 = ((ushort)12);
            ushort num4 = ((ushort)6);
            RomanNumber rom3 = new RomanNumber(num3);
            RomanNumber rom4 = new RomanNumber(num4);
            Console.WriteLine("12 * 6 = 72 -> " + rom3.ToString() + " * " + rom4.ToString() + " = " + RomanNumber.Mul(rom3, rom4));
            Console.WriteLine("12 / 6 = 2 -> " + rom3.ToString() + " / " + rom4.ToString() + " = " + RomanNumber.Div(rom3, rom4));
            short[] Values = new short[]
            { 1000, 777, 601, 444, 112, 72, 55, 41, 16, 9, 7, 3, 1 };
            RomanNumber[] rom5 = new RomanNumber[Values.Length];
            Console.WriteLine("\n");
            Console.WriteLine("Before sorting:");
            for (int i = 0; i < Values.Length; ++i)
            {
                rom5[i] = new RomanNumber(((ushort)Values[i]));
                Console.Write(Values[i] + "(" + rom5[i].ToString() + ")" + " ");
            }
            Console.WriteLine("\nAfter sorting:");
            Array.Sort(rom5);
            foreach (object el in rom5)
            {
                Console.Write(el.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
           
            lab2();
        }
    }
}