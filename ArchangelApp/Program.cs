using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchangelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionSelected;
            string name;

            Console.WriteLine("_______________________________________________________________");

            Console.WriteLine("Hello! Please enter your name...");

            Console.WriteLine("_______________________________________________________________");

            name = Console.ReadLine();

            Console.Write("Hello! Very happy to meet you "  + name + " :) \n");
 
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("My name is Mitchell, would you like to be my friend?  y / n ");

            Console.WriteLine("_______________________________________________________________");
            optionSelected = Console.ReadLine();

            if(optionSelected.ToLower() == "n" )
            {
                Console.WriteLine("It's OK, thank you for your time and I wish you all the very best!  ");
                Console.WriteLine("God Bless You! :) ");
            }           
            else
            {
                Console.WriteLine("I am very happy and look forward to hear from you :)  ");
                Console.WriteLine("You can contact me at: mwon341@gmail.com");
            }

            Console.WriteLine("\n\n_______________________________________________________________");
            Console.WriteLine("\n Press any key to exit..");
            Console.WriteLine("\n_______________________________________________________________");
            Console.ReadKey();
            
        }
    }
}
