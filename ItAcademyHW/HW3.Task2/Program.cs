using System;

namespace HW3.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int-Int32
            int intVar = int.MaxValue;
            Int32 Int32Var = Int32.MinValue; 
            Console.WriteLine(intVar.GetType() + " max value(int) = " + intVar);
            Console.WriteLine(Int32Var.GetType() + " min value = " + Int32Var +"\n");

            ////uint-UInt32
            uint uintVar = uint.MaxValue;
            UInt32 UInt32Var = UInt32.MinValue;           
            Console.WriteLine(uintVar.GetType() + " max value(uint) = " + uintVar);
            Console.WriteLine(UInt32Var.GetType() + " min value = " + UInt32Var+"\n");

            ////short-Int16
            short shortVar = short.MaxValue;
            Int16 Int16Var = Int16.MinValue; 
            Console.WriteLine(shortVar.GetType() + " max value(short) = " + shortVar);
            Console.WriteLine(Int16Var.GetType() + " min value = " + Int16Var+"\n");

            ////ushort-UInt16
            ushort ushortVar = ushort.MaxValue;
            UInt16 UInt16Var = UInt16.MinValue;
            Console.WriteLine(ushortVar.GetType() + " max value(ushort) = " + ushortVar);
            Console.WriteLine(UInt16Var.GetType() + " min value = " + UInt16Var+ "\n");

            ////long-Int64
            long longVar = long.MaxValue;
            Int64 Int64Var = Int64.MinValue;
            Console.WriteLine(longVar.GetType() + " max value(long) = " + longVar);
            Console.WriteLine(Int64Var.GetType() + " min value = " + Int64Var + "\n");

            ////ulong-UInt64
            ulong ulongVar = ulong.MaxValue;
            UInt64 UInt64Var = UInt64.MinValue;
            Console.WriteLine(ulongVar.GetType() + " max value(ulong) = " + ulongVar);
            Console.WriteLine(UInt64Var.GetType() + " min value = " + UInt64Var + "\n");
            
            ////sbyte-SByte
            sbyte sbyteVar = sbyte.MaxValue;
            SByte SByteVar = SByte.MinValue;
            Console.WriteLine(sbyteVar.GetType() + " max value(sbyte) = " + sbyteVar);
            Console.WriteLine(SByteVar.GetType() + " min value = " + SByteVar + "\n");

            ////byte-Byte
            byte byteVar = byte.MaxValue;
            Byte ByteVar = Byte.MinValue;
            Console.WriteLine(byteVar.GetType() + " max value(byte) = " + byteVar);
            Console.WriteLine(ByteVar.GetType() + " min value = " + ByteVar + "\n");

            ////float-Single
            float floatVar = float.MaxValue;
            Single SingleVar = Single.MinValue;
            Console.WriteLine(floatVar.GetType() + " max value(float) = " + floatVar);
            Console.WriteLine(SingleVar.GetType() + " min value = " + SingleVar + "\n");

            ////double-Double
            double doubleVar = double.MaxValue;
            Double DoubleVar = Double.MinValue;
            Console.WriteLine(doubleVar.GetType() + " max value(double) = " + doubleVar);
            Console.WriteLine(DoubleVar.GetType() + " min value = " + DoubleVar + "\n");

            ////char-Char
            char charVar = char.MaxValue;
            Char CharVar = Char.MinValue;
            Console.WriteLine(charVar.GetType() + " max value(char) = " + charVar);
            Console.WriteLine(CharVar.GetType() + " min value = " + CharVar + "\n");

            ////bool-Bool
            bool boolVar = true;
            Boolean BooleanVar = false;
            Console.WriteLine(boolVar.GetType() + " true value(bool) = " + boolVar);
            Console.WriteLine(BooleanVar.GetType() + " false value = " + BooleanVar + "\n");

            ////decimal-Decimal
            decimal decimalVar = decimal.MaxValue;
            Decimal DecimalVar = Decimal.MinValue;
            Console.WriteLine(decimalVar.GetType() + " max value(decimal) = " + decimalVar);
            Console.WriteLine(DecimalVar.GetType() + " min value = " + DecimalVar + "\n");

            ////string-String
            string stringVar = " This is string";
            String StringVar = " This is System.String";
            Console.WriteLine(stringVar.GetType() + stringVar);
            Console.WriteLine(StringVar.GetType() + StringVar + "\n");

            ////decimal-Object
            object objectVar = " Object is abstract class, so here it's redefine to it's heritaged class(String)";
            Object ObjectVar = " Object is abstract class, so here it's redefine to it's heritaged class(String)";
            Console.WriteLine(objectVar.GetType() + (string)objectVar);
            Console.WriteLine(ObjectVar.GetType() + (string)ObjectVar + "\n");
        }
    }
}
