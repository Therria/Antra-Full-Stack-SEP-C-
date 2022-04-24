using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Assignment1
{
    public static class UnderstandingTypes
    {
        public static void TypeRangeAndExtremum() 
        {
            Console.WriteLine($"sbyte type has {sizeof(sbyte)} bytes in memory, its minimum value is {sbyte.MinValue} and maximum value is {sbyte.MaxValue}" );
            Console.WriteLine($"byte type has {sizeof(byte)} bytes in memory, its minimum value is {byte.MinValue} and maximum value is {byte.MaxValue}");
            Console.WriteLine($"short type has {sizeof(short)} bytes in memory, its minimum value is {short.MinValue} and maximum value is {short.MaxValue}");
            Console.WriteLine($"ushort type has {sizeof(ushort)} bytes in memory, its minimum value is {ushort.MinValue} and maximum value is {ushort.MaxValue}");
            Console.WriteLine($"int type has {sizeof(int)} bytes in memory, its minimum value is {int.MinValue} and maximum value is {int.MaxValue}");
            Console.WriteLine($"uint type has {sizeof(uint)} bytes in memory, its minimum value is {uint.MinValue} and maximum value is {uint.MaxValue}");
            Console.WriteLine($"long type has {sizeof(long)} bytes in memory, its minimum value is {long.MinValue} and maximum value is {long.MaxValue}");
            Console.WriteLine($"ulong type has {sizeof(ulong)} bytes in memory, its minimum value is {ulong.MinValue} and maximum value is {ulong.MaxValue}");
            Console.WriteLine($"float type has {sizeof(float)} bytes in memory, its minimum value is {float.MinValue} and maximum value is {float.MaxValue}");
            Console.WriteLine($"double type has {sizeof(double)} bytes in memory, its minimum value is {double.MinValue} and maximum value is {double.MaxValue}");
            Console.WriteLine($"decimal type has {sizeof(decimal)} bytes in memory, its minimum value is {decimal.MinValue} and maximum value is {decimal.MaxValue}");
        }
        public static void TimeCovertion() 
        {
            Console.WriteLine("Enter your number of centeries: ");
            uint centery = uint.Parse(Console.ReadLine());
            uint year = centery * 100;
            uint day =(uint) ( year * 365.2422);
            ulong hour = (ulong)(day * 24);
            ulong minute = hour * 60;
            ulong second = minute * 60;
            ulong millisecond = second * 1000;
            BigInteger microsecond = millisecond * 1000;
            BigInteger nanosecond = microsecond * 1000;
            Console.WriteLine($"{centery} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds =" +
                $"{microsecond} microseconds = {nanosecond} nanoseconds");

        }
    }
}
