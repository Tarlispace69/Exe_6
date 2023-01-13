using System;

namespace exe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int length = 0, width = 0;

            //recieving width and length
            Console.WriteLine("Please enter quadrangular length:");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter quadrangular width:");
            width = int.Parse(Console.ReadLine());

            //if measures are equal print that is is a square
            if (length == width)
            {
                Console.WriteLine("The quadrangular is a square");
            }
            //if not print difference between measures
            else
            {
                Console.WriteLine($"The difference between the length and the width is {length-width}");
            }
        }
    }
}
