using System;
using System.IO;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using CsvHelper;

namespace pokemon_database
{
    class readerWriter
    {
        public static List<pokemon> monStorage;

        public static void readCsvFile()
        {
            using (var reader = new StreamReader("pokemon.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<pokemon>().ToList();
                    tempList(records);
                }
            }
            readerWriterMenu();
        }

        public static void refreshCsvFile(List<pokemon> records)
        {
            databaseOperations.sortDex(ref records);
            using (var writer = new StreamWriter("pokemon.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
            }
            Console.WriteLine("The pokemon database file has now been refreshed!");
        }

        public static void addToCsvFile(List<pokemon> records)
        {
            databaseOperations.sortDex(ref records);
            using (var writer = new StreamWriter("pokemon.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                    var newMon = pokemon.getPokemon();
                    if (databaseOperations.alreadyPresent(records, newMon.dexNum))
                    {
                        Console.WriteLine("Oops! Looks like this pokemon is already in the database...");
                    }
                    else
                    {
                        csv.WriteRecord(newMon);
                        Console.WriteLine(newMon.monName + " has been added to the database!");
                    }
                }
            }
        }

        public static void tempList(List<pokemon> records)
        {
            monStorage = records;
        }

        private static void displayRecords(List<pokemon> records, int numOfMons)
        {
            databaseOperations.sortDex(ref records);
            Console.WriteLine("Pokedex Number, Name, Type, 2nd Type, HP, Attack, Defence, Sp.Attack, Sp.Defence, Speed, Ability");
            for(int i = 0; i < numOfMons; i++)
            {
                Console.WriteLine(records[i].dexNum.ToString() + ", " + records[i].monName + ", " + records[i].Type1 + ", " + 
                    records[i].Type2 + ", " + records[i].HP.ToString() + ", " + records[i].attack.ToString() + ", " + 
                    records[i].defence.ToString() + ", " + records[i].spAttack.ToString() + ", " +
                    records[i].spDefence.ToString() + ", " + records[i].speed.ToString() + ", " + records[i].ability);
            }
            Console.WriteLine("");
        }

        private static void readerWriterMenu()
        {
            Console.WriteLine("Would you like to add to the database (1), see the database (2), refresh the database (3), search for a pokemon in the database (4), or exit to the main menu (5)?");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                addToCsvFile(monStorage);
                Console.ReadLine();
            }
            else if (answer == "2")
            {
                int i = 0;
                foreach (pokemon mon in monStorage)
                {
                    i++;
                }
                Console.WriteLine("");
                displayRecords(monStorage, i);
                Console.ReadLine();
            }
            else if (answer == "3")
            {
                refreshCsvFile(monStorage);
                Console.ReadLine();
            }
            else if (answer == "4")
            {
                Console.Write("Enter the pokedex number of the pokemon you wish to view the stats of: ");
                int wantedNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (!databaseOperations.alreadyPresent(monStorage, wantedNum))
                {
                    Console.WriteLine("Sorry, but that pokemon is not in the database at the moment. Maybe you can find out about it!");
                }
                Console.ReadLine();
            }
            else if (answer == "5")
            {
                Console.WriteLine("Redirecting back to the main menu...");
            }
            else
            {
                Console.WriteLine("Invalid input. Redirecting back to the main menu...");
                Console.WriteLine("");
            }
        }
    }
}
