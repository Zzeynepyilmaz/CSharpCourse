using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //Console.WriteLine("Hello World!");
            int number1 = 2147483647;//32 bit
            long number2 = 2147483648;//64bit
            short number3 = -32768;
            byte number4 = 0; //8 bit 1 byte
            bool condition = false;
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.4;//64 bit
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is:{0}",number1);
            Console.WriteLine("Number2 is:{0}", number2);
            Console.WriteLine("Number3 is:{0}",number3);
            Console.WriteLine("Number4 is:{0}", number4);
            Console.WriteLine("Character is:{0}", character);
            Console.WriteLine("Number5 is:{0}", number5);
            Console.WriteLine("Number6 is:{0}", number6);
            Console.WriteLine("Number7 is:{0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
