using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {   // Exercise 1
            //Console.Write("First name please: ");
            //string firstName = Console.ReadLine();
            //Console.Write("Last name please: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine($"Hello {firstName} {lastName}!" +
            //    " I’m glad to inform you that you are the test subject of my very first assignment!");

            //// Exercise 2
            //DateTime yesterday = DateTime.Now.AddDays(-1);
            //DateTime today = DateTime.Now;
            //DateTime tomorrow = DateTime.Now.AddDays(1);
            //Console.WriteLine($"\nYesterday's date was {yesterday}!");
            //Console.WriteLine($"Today's date is {today}!");
            //Console.WriteLine($"Tomorrow's date will be {tomorrow}!");

            //// Exercises 3
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine("\nFull name is " + fullName);

            //// Exercise 4
            //string s = "The quick fox Jumped Over the DOG";
            //int i = s.IndexOf('q');
            //string t = s.Replace("quick", "brown").Replace("J", "j").Replace("O", "o").Replace("DoG", "lazy dog");
            //Console.WriteLine($"\n{t}");

            // Exercise 5
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            int idx = str.IndexOf('[');
            int idx2 = str.IndexOf(']');
            string str2 = str.Substring(idx);
            Console.WriteLine(str2);
        }
    }
}
