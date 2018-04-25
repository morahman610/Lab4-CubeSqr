using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! this program calculates the square value and cubed value of numbers." +
            "and the squared value and cubed value of the numbers less than the one entered. \n" );
            bool programUsed = true;
            while (programUsed)
            {

                Console.WriteLine("Please enter an integer to calculate its squared and cubed value."); 
                string UsersInput = Console.ReadLine();
                int UsersInteger = int.Parse(UsersInput);

                for (int i = 0; i <= UsersInteger; i++)
                {
                    int Squared = i * i;
                    int Cubed = i * i * i;
                    Console.WriteLine($"Number: {i} \t     Squared: {Squared} \t     Cube: {Cubed}");
                }

                Console.WriteLine("Continue? (y/n)");
                string DoAgain = Console.ReadLine();
                if (DoAgain == "n")
                {
                    programUsed = false;
                }
            }

            Console.WriteLine("Thank you for using this program!");
        }

    }
}
