using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////implictit conversion
            int numInt = 3;               //first example int to float
            float numFloat = numInt;

            short numShort = 15;          //second example short to long
            long numLong = numShort;

            uint numUInt = 100;           //third example uint to double 
            double numDouble = numUInt;

            ////////explicit conversion
            double doublePI = 3.1415926535897932384626433832795;  //first example double to int
            int intPI = (int)doublePI;

            int maxInt = 2_147_483_647;
            short maxShort = (short)maxInt; //second example int to short

            byte maxByte = 255;            //third example byte to sbyte
            sbyte maxSByte = (sbyte)maxByte;

            ///////boxing
            int intUnbox = 20;
            object boxInt = intUnbox;       //first example boxing int

            char charUnbox = 'a';
            object boxChar = charUnbox;    //second example boxing char 

            double doubleUnbox = 89.23243;
            object boxDouble = doubleUnbox; //third example boxing double

            ///////unboxing
            int unboxInt = (int)boxInt; //first example unboxing int

            char unboxChar = (char)boxChar; //second example unboxing char

            double unboxDouble = (double)boxDouble; //third example unboxing double
        }
    }
}
