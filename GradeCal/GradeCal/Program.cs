using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCal
{
    class Program
    {
        static void Main(string[] args)
        {
            String grd;
            double gpa;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Today's date and time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please enter your Full Name: ");
            String stName = (Console.ReadLine());

            Console.Write("Please enter your Student ID (For ex. 749087): ");
            int stId = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Marks of Test1 are: ");
            double test1 = double.Parse(Console.ReadLine());
            while (test1 < 0 || test1 > 100)
            {
                Console.Write("Enter valid marks ");
                test1 = double.Parse(Console.ReadLine());
            }
            double perTest1 = ((test1) * 25) / 100;
            Console.WriteLine("The percentage of Test 1 (out of 25) is {0} ", perTest1);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Marks of Test2 are: ");
            double test2 = double.Parse(Console.ReadLine());
            while (test2 < 0 || test2 > 100)
            {
                Console.Write("Enter valid marks ");
                test2 = double.Parse(Console.ReadLine());
            }
            double perTest2 = ((test2) * 25) / 100;

            Console.WriteLine("The percentage of Test 2 (out of 25) is {0} ", perTest2);
            Console.Write("\n");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Marks of Test3 are: ");
            double test3 = double.Parse(Console.ReadLine());
            while (test3 < 0 || test3 > 100)
            {
                Console.Write("Enter valid marks ");
                test3 = double.Parse(Console.ReadLine());
            }
            double perTest3 = ((test3) * 25) / 100;
            Console.WriteLine("The percentage of Test 3 (out of 25) is {0} ", perTest3);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Marks of Assignment 1 are: ");
            double A1 = double.Parse(Console.ReadLine());
            while (A1 < 0 || A1 > 100)
            {
                Console.Write("Enter valid marks ");
                A1 = double.Parse(Console.ReadLine());
            }
            double perA1 = ((A1) * 5) / 100;
            Console.WriteLine("The percentage of assignment 1 (out of 5) is {0} ", perA1);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Marks of Assignment 2 are: ");
            double A2 = double.Parse(Console.ReadLine());
            while (A2 < 0 || A2 > 100)
            {
                Console.Write("Enter valid marks ");
                A2 = double.Parse(Console.ReadLine());
            }
            double perA2 = ((A2) * 5) / 100;
            Console.WriteLine("The percentage of assignment 2 (out of 5) is {0} ", perA2);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Marks of Assignment 3 are: ");
            double A3 = double.Parse(Console.ReadLine());
            while (A3 < 0 || A3 > 100)
            {
                Console.Write("Enter valid marks ");
                A3 = double.Parse(Console.ReadLine());
            }
            double perA3 = ((A3) * 5) / 100;
            Console.WriteLine("The percentage of assignment 3 (out of 5) is {0} ", perA3);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Marks of Assignment 4 are: ");
            double A4 = double.Parse(Console.ReadLine());
            while (A4 < 0 || A4 > 100)
            {
                Console.Write("Enter valid marks ");
                A4 = double.Parse(Console.ReadLine());
            }
            double perA4 = ((A4) * 5) / 100;
            Console.WriteLine("The percentage of assignment 4 (out of 5) is {0} ", perA4);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Marks of Assignment 5 are: ");
            double A5 = double.Parse(Console.ReadLine());
            while (A5 < 0 || A5 > 100)
            {
                Console.Write("Enter valid marks ");
                A5 = double.Parse(Console.ReadLine());
            }
            double perA5 = ((A5) * 5) / 100;
            Console.WriteLine("The percentage of assignment 5 (out of 5) is {0} ", perA5);
            Console.Write("\n");

            double total = (perTest1 + perTest2 + perTest3 + perA1 + perA2 + perA3 + perA4 + perA5);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The total percentage of student is {0} ", total);
            Console.Write("\n");


            if (total >= 94.00 && total <= 100)
            {
                grd = "A+"; gpa = 4.0;
            }

            else if (total >= 87.00 && total <= 93.99)
            {
                grd = "A"; gpa = 3.7;
            }

            else if (total >= 80.00 && total <= 86.99)
            {
                grd = "A-"; gpa = 3.5;
            }

            else if (total >= 77.00 && total <= 79.99)
            {
                grd = "B+"; gpa = 3.2;
            }

            else if (total >= 73.00 && total <= 76.99)
            {
                grd = "B"; gpa = 3.0;
            }

            else if (total >= 70.00 && total <= 72.99)
            {
                grd = "B-"; gpa = 2.7;
            }

            else if (total >= 67.00 && total <= 69.99)
            {
                grd = "C+"; gpa = 2.3;
            }

            else if (total >= 63.00 && total <= 66.99)
            {
                grd = "C"; gpa = 2.0;
            }

            else if (total >= 60.00 && total <= 62.99)
            {
                grd = "C-"; gpa = 1.7;
            }

            else if (total >= 50.00 && total <= 59.99)
            {
                grd = "D"; gpa = 1.0;
            }

            else
            {
                grd = "F"; gpa = 0.0;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Your overall grade is {0} ", grd);
            Console.WriteLine("Your overall GPA is {0} ", gpa);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("Enter the fees of a semester: ");
            double fees = double.Parse(Console.ReadLine());
            Console.Write("The fees paid for the semester is : {0} ", fees);

            Console.ReadKey();


        }
    }
}
