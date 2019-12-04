using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryExercises
{
    class Program
    {
        const byte Place1 = 0x01;
        const byte Place2 = 0x01 << 1;
        const byte Place3 = 0x01 << 2;
        const byte Place4 = 0x01 << 3;
        const byte Place5 = 0x01 << 4;
        const byte Place6 = 0x01 << 5;
        const byte Place7 = 0x01 << 6;
        const byte Place8 = 0x01 << 7;

        public static readonly string[] placeNum = { "1", "2", "3", "4", "5", "6", "7", "8" };
        static void Main(string[] args)
        {
            byte bitCheck = 0;
            bitCheck |= Place1;
            bitCheck |= Place2;
            bitCheck |= Place3;
            bitCheck |= Place4;
            bitCheck |= Place5;
            bitCheck |= Place6;
            bitCheck |= Place7;
            bitCheck |= Place8;
            Console.WriteLine(IsLeftMostBitSet(bitCheck));
            Console.WriteLine(IsRightMostBitSet(bitCheck));
            Console.WriteLine(IsBitSet(bitCheck, 4));
            Console.WriteLine(GetRightMostSetBit(bitCheck));
            PrintBinary(bitCheck);
            Console.ReadLine();
        }
        static bool IsLeftMostBitSet(UInt16 value)
        {
            int mask = 0x01;
            if ((value & mask) == mask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsRightMostBitSet(UInt16 value)
        {
            int mask = 0x01 << 7;
            if ((value & mask) == mask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsBitSet(UInt16 value, int bit_to_check)
        {
            int mask = 0x01 << bit_to_check - 1;
            if ((value & mask) == mask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int GetRightMostSetBit(UInt16 value)
        {
            int count = -1;
            for (int i = 0; i < 8; i++)
            {
                int mask = 0x01 << i;
                if ((mask & value) == mask)
                {
                    count = 8 - i;
                    break;
                }
            }

            if(count > -1)
            {
                count = 8 - count;
            }
            return count;
        }
        static void PrintBinary(byte value)
        {
            string outPut = "";
            for (int i = 0; i < 8; i++)
            {
                int mask = 0x01 << i;
                if ((mask & value) == mask)
                {
                    outPut += "1";
                }
                else
                {
                    outPut += "0";
                }
            }
            Console.WriteLine(outPut);
        }
    }
}
