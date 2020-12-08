using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //TODO - 1) Ask user for name, string
    //TODO - 2) Ask user for how many in party, int
    //TODO - 3) Track number of party members, int
    //TODO - 4) Print out guest list, and total guest numbers, string and int
    class Program
    {
        public static string fullName;
        public static string[,] partyList;
        public static string groupSize;
        public static List<int> partySize = new List<int>();
        public static int totalGuests;

        public static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the party guest list.");
            AddPartyMemember();
            
            Console.ReadLine();
        }

        public static void AddPartyMemember()
        {
            Console.Write($"Do you have any guests you would like to add? Yes or No => ");
            string @continue = Console.ReadLine();
            while (@continue.ToLower().Equals("yes"))
            {
                Console.Write($"Please enter the guest's Full Name=> ");
                fullName = Console.ReadLine();

                Console.Write($"Please enter the number of guests attending with {fullName} => ");
                groupSize = Console.ReadLine();

                if (Convert.ToInt32(groupSize) <= 0 )
                {
                    groupSize = "1";
                    Console.WriteLine($"You at least count as one person! Marking you down as {groupSize}");
                }

                partySize.Add(Convert.ToInt32(groupSize));
                //TODO - check how it is adding, if it is totaling for just adding ints to list size

            }
        }

        public static void GuestsToCollection()
        {
            
        }


        public static void PresentList()
        {
            foreach (var member in partySize)
            {
                Console.WriteLine($"{fullName} will be attending with {groupSize} guests");

                totalGuests = totalGuests + Convert.ToInt32(groupSize);
            }

            Console.WriteLine($"There will be a total of {totalGuests} attending.");
        }
    }
}
