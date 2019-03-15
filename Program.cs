using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber;
            string secondNumber;
            string thirdNumber;

            Stack<string> myStack = new Stack<string>();
            
            Console.WriteLine("Hello there");
            Console.WriteLine("I will need 3 numbers from you and return them to you in the reverse order you tyyped them in.");
            Console.WriteLine("Please give me the first number");
            firstNumber = Console.ReadLine();
            myStack.Push(firstNumber);

            Console.WriteLine("Good, please giv me the next number");
            secondNumber = Console.ReadLine();
            myStack.Push(secondNumber);

            Console.WriteLine("Now please give me the æast number");
            thirdNumber = Console.ReadLine();
            myStack.Push(thirdNumber);

            Console.WriteLine("This is the order of the numbers you typed in:");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            
            Console.WriteLine("This is the reversed order");
            //Write the numbers in the reversed order
            foreach (Object obj in myStack)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
