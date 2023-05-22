using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon_database
{
    class mainMenu
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Welcome to the Pokemon Database! The database was created by Professor Noroozi" +
                    " and is currently incomplete. Here is what you can do at the moment. Type: ");

                Console.WriteLine("1) Begin operations on the database");
                Console.WriteLine("2) Exit database");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    readerWriter.readCsvFile();
                    Console.WriteLine("Operations complete!");
                }
                else if (choice == "2")
                {
                    running = false;
                    Console.WriteLine("Thank you for visiting the pokemon database!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input made. Please try again..");
                }
            }
        }

    }
}
