using System;

/*
Напишите программу, которая выведет на экран минимально
возможное и максимально возможное значение всех целых типов:
sbyte, byte, short, ushort, int, uint, long, ulong.
 */

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sbyte: min = " + sbyte.MinValue + ", max = " + sbyte.MaxValue);
            Console.WriteLine("byte: min = " + byte.MinValue + ", max = " + byte.MaxValue);
            Console.WriteLine("short: min = " + short.MinValue + ", max = " + short.MaxValue);
            Console.WriteLine("ushort: min = " + ushort.MinValue + ", max = " + ushort.MaxValue);
            Console.WriteLine("int: min = " + int.MinValue + ", max = " + int.MaxValue);
            Console.WriteLine("uint: min = " + uint.MinValue + ", max = " + uint.MaxValue);
            Console.WriteLine("long: min = " + long.MinValue + ", max = " + long.MaxValue);
            Console.WriteLine("ulong: min = " + ulong.MinValue + ", max = " + ulong.MaxValue);
            Console.ReadKey();
        }
    }
}
