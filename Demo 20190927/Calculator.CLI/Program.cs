using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList myNumbers = new System.Collections.ArrayList();

            string userInput = "";
            Console.WriteLine("Enter any amount of numbers, press 'x' to finish: ");
            do
            {
                userInput = Console.ReadLine();
                myNumbers.Add(userInput);

            } while (userInput != "x");

            Console.WriteLine("Tack! Du matade in {0} nummer.", myNumbers.Count);

            Console.WriteLine("Enter operation '+' or '-' or '*' or '/': ");
            string op = Console.ReadLine();

            Calculator.Component.Calculator myCalculator = new Component.Calculator(); //skapar ny objekt i class?
            if (op == "+")
            {
                foreach (int i in myNumbers)
                {
                    Console.Write("{0} {1} ", i, op);

                    Console.Write(" = {3}", myCalculator.Add2(int i));
                }
                
            }

        }
    }
}
