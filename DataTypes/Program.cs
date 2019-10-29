using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes a character as input and checks the input (lowercase) is a vowel, an integer number or decimal, or any other symbol.");

            Console.WriteLine("Enter the data");
            string dataType = Console.ReadLine();

            var newData = new DataDifferencer().Differencer(dataType);

            Console.WriteLine(newData);
            Console.ReadKey();
        }
    }
}
