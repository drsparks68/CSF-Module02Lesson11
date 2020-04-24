using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            string addMore;

            do
            {
                Console.WriteLine("Please enter your first name: ");
                firstNames.Add(Console.ReadLine());

                Console.WriteLine("Do you have another name to add? (y/n)");
                string askMore = Console.ReadLine();
                addMore = askMore.ToLower();
            } while (addMore == "y");

            foreach (var name in firstNames)
            {
                Console.WriteLine($"Hello, { name }");
            }

            //Dictionary<int, string> importantYears = new Dictionary<int, string>();
            //importantYears.Add(1492, "Columbus wrecked the world");
            //importantYears.Add(1968, "Derek was born");
            //importantYears.Add(2010, "I got a job at Microsoft");

            //foreach (var year in importantYears)
            //{
            //    Console.WriteLine($"In { year.Key }, { year.Value }" );
            //}
            //----------------------------------------------------------------------------------------
            //List<string> firstNames = new List<string>();

            //firstNames.Add("Tim");
            //firstNames.Add("Bob");
            //firstNames.Add("Sue");
            //firstNames.Add("Allen");

            //foreach (string name in firstNames)
            //{
            //    Console.WriteLine($"Hello, { name }");


            //}



            Console.ReadLine();
        }
    }
}
