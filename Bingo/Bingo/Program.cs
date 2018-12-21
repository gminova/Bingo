using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring my fruits
            string x1y1 = "apple";
            string x1y2 = "grapes";
            string x1y3 = "peach";
            string x2y1 = "pear";
            string x2y2 = "melon";
            string x2y3 = "orange";
            string x3y1 = "strawberry";
            string x3y2 = "lemon";
            string x3y3 = "banana";
            //declaring 8 possible bingo combo counters, once bingo counter reaches 3, BINGO is achieved
            var bingo1 = 0;
            var bingo2 = 0;
            var bingo3 = 0;
            var bingo4 = 0;
            var bingo5 = 0;
            var bingo6 = 0;
            var bingo7 = 0;
            var bingo8 = 0;
            //computer asks non-randomly until bingo combo is achieved
            Console.Write("Find the APPLE: ");
            //user inputs answer which is automatically converted to lowercase
            var apple = Console.ReadLine().ToString().ToLower();
            //checks if answer is correct and appropriate bingo counters increment by 1
            if (apple == x1y1)
            {
                Console.WriteLine("Correct");
                bingo1 += 1;
                bingo4 += 1;
                bingo8 += 1;
                //checks if bingo is achieved
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the LEMON: ");
            var lemon = Console.ReadLine().ToString().ToLower();
            if (lemon == x3y2)
            {
                Console.WriteLine("Correct");
                bingo2 += 1;
                bingo6 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the STRAWBERRY: ");
            var strawberry = Console.ReadLine().ToString().ToLower();
            if (strawberry == x3y1)
            {
                Console.WriteLine("Correct");
                bingo1 += 1;
                bingo6 += 1;
                bingo7 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the PEAR: ");
            var pear = Console.ReadLine().ToString().ToLower();
            if (pear == x2y1)
            {
                Console.WriteLine("Correct");
                bingo1 += 1;
                bingo5 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the PEACH: ");
            var peach = Console.ReadLine().ToString().ToLower();
            if (peach == x1y3)
            {
                Console.WriteLine("Correct");
                bingo3 += 1;
                bingo4 += 1;
                bingo7 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the BANANA: ");
            var banana = Console.ReadLine().ToString().ToLower();
            if (banana == x3y3)
            {
                Console.WriteLine("Correct");
                bingo3 += 1;
                bingo6 += 1;
                bingo8 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the MELON: ");
            var melon = Console.ReadLine().ToString().ToLower();
            if (melon == x2y2)
            {
                Console.WriteLine("Correct");
                bingo1 += 1;
                bingo5 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the GRAPES: ");
            var grapes = Console.ReadLine().ToString().ToLower();
            if (grapes == x1y2)
            {
                Console.WriteLine("Correct");
                bingo2 += 1;
                bingo4 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("Find the ORANGE: ");
            var orange = Console.ReadLine().ToString().ToLower();
            if (orange == x2y3)
            {
                Console.WriteLine("Correct");
                bingo3 += 1;
                bingo5 += 1;
                if ((bingo1 == 3) || (bingo2 == 3) || (bingo3 == 3) || (bingo4 == 3) ||
                    (bingo5 == 3) || (bingo6 == 3) || (bingo7 == 3) || (bingo8 == 3))
                {
                    Console.WriteLine("BINGO!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}