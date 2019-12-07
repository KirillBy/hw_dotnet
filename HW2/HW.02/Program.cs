using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader textReader = new StreamReader(@"C:\Users\Admin\Downloads\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for(int i = 0; i < arrayOfTextResult.Length-1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
                Console.WriteLine(arrayOfTextResult[i]);
            }
            File.WriteAllBytes(@"C:\Users\Admin\Downloads\image.png", imageBytes);
            
            Console.WriteLine("Hello World!");
        }
    }
}
