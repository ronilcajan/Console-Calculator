using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_05_Cajan
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        public static int Substract(int num1, int num2)
        {
            int difference;
            difference = num1 - num2;
            return difference;
        }
        public static int Multiply(int num1, int num2)
        {
            int product;
            product = num1 * num2;
            return product;
        }
        public static int Divide(int num1,int num2)
        {
            int qoutient;
            qoutient = num1 / num2;
            return qoutient;
        }
        public static int Module(int num1, int num2)
        {
            int module;
            module = num1 % num2;
            return module;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                String choice;
                Console.WriteLine("SIMPLE CALCULATOR IN C#");
                Console.WriteLine("[A] - ADDITION");
                Console.WriteLine("[B] - SUBSTRACTION");
                Console.WriteLine("[C] - MULTIPLICATION");
                Console.WriteLine("[D] - DIVISION");
                Console.WriteLine("[E] - MODULE");
                Console.WriteLine("[X] - EXIT");

                Console.Write("Enter your choice : ");
                choice = Console.ReadLine();

                if (choice == "a" || choice == "A")
                {
                    Console.Write("Enter first number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Sum of two number is : {0} ", Sum(num1,num2));
                }
                else if (choice == "b" || choice == "B")
                {
                    Console.Write("Enter first number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Difference of two number is : {0} ", Substract(num1, num2));
                }
                else if (choice == "c" || choice == "C")
                {
                    Console.Write("Enter first number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Product of two number is : {0} ", Multiply(num1, num2));
                }
                else if (choice == "d" || choice == "D")
                {
                    Console.Write("Enter first number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Quotient of two number is : {0} ", Divide(num1, num2));
                }
                else if (choice == "e" || choice == "E")
                {
                    Console.Write("Enter first number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The Module of two number is : {0} ", Module(num1, num2));
                }
                else if (choice == "x" || choice == "X")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}
