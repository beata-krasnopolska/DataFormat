using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes a character as input and checks the input (lowercase) is a vowel, an integer number or decimal, or any other symbol.");

            Console.WriteLine("Enter the data");
            var dataType = Console.ReadLine();

            int tryInt;
            decimal tryDec;
            if (Int32.TryParse(dataType, out tryInt))
            {
                Console.WriteLine("The data type is integer");
            }
            else if (Decimal.TryParse(dataType, out tryDec))
            {
                Console.WriteLine("The data type is decimal");
            }
            else if (dataType =="a" || dataType == "e" || dataType == "i" || dataType == "o" || dataType == "u" || dataType == "y")
            {
                Console.WriteLine("The entered data type is a vovel");
            }
            else
            {
                Console.WriteLine("There is other data type");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
