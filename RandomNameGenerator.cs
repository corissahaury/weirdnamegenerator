using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomString
{
    class Program
    {
        static void Main(string[] args)
        {
            var capital = "BCDFGHJKLMNPQRSTVWZ";
            var first = "aeiouy";
            var second = "bcdfghjklmnpqrstvwxz";
            var third = "abeiouy";
            var fourth = "aeiouy";
            var stringChars = new char[5];
            var random = new Random();

            stringChars[0] = capital[random.Next(capital.Length)];
            stringChars[1] = first[random.Next(first.Length)];
            stringChars[2] = second[random.Next(second.Length)];
            stringChars[3] = third[random.Next(third.Length)];
            stringChars[4] = fourth[random.Next(fourth.Length)];

            var finalString = new String(stringChars);

            Console.WriteLine(finalString);

            Console.ReadLine();

        }
    }
}
