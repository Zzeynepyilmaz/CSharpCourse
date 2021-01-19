using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            string sentence = "My name is zeynep Yılmaz";
            var length =sentence.Length;
            Console.WriteLine(length);
            var clone =sentence.Clone();
            sentence = "My name is Beyza Yılmaz";
            Console.WriteLine(clone);
            bool endswith = sentence.EndsWith("z");
            bool startswith = sentence.StartsWith("M");
            var ındex = sentence.IndexOf("name");
            var lastindex = sentence.LastIndexOf(" ");
            Console.WriteLine(ındex);
            Console.WriteLine(lastindex);
            var insert = sentence.Insert(0, "Hello ");
            Console.WriteLine(insert);
            var substring = sentence.Substring(3);
            Console.WriteLine(substring);
            var tolower = sentence.ToLower();
            Console.WriteLine(tolower);
            var toupper = sentence.ToUpper();
            Console.WriteLine(toupper);
            var replace = sentence.Replace(" ", "-");
            Console.WriteLine(replace);
            var remove = sentence.Remove(2);
            Console.WriteLine(remove);
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Istanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
