using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //number = NewMethod2(number);
            //NewMethod3();
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber (int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void NewMethod3()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static int NewMethod2(int number)
        {
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
            return number;
        }

        private static void NewMethod1()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void NewMethod()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}

