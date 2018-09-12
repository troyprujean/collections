using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArraysAdvanced
{
    class Program
    {
        static int ticketsPurchased = 0;
        static Seat[,] movies = new Seat[20, 20];
        static void Main(string[] args)
        {
            int seat = 1;

            // Initialise an empty cinema
            for (int row = 0; row < movies.GetLength(1); row++)
            {
                for (int column = 0; column < movies.GetLength(0); column++)
                {
                    movies[column, row] = new Seat(seat, true);
                    seat++;
                }
            }

            SellTickets();
        }

        public static void SellTickets()
        {
            int tickets = 0;
            string fName;
            string lName;
            int age;

            Console.WriteLine("----* Welcome to the movie theatre *----");
            Console.Write("Please enter the number of tickets you would like to purchase: ");
            tickets = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            Console.Write("Please enter the first name of the ticket holder: ");
            fName = Console.ReadLine();
            Console.Write("Please enter the last name of the ticket holder: ");
            lName = Console.ReadLine();
            Console.Write("Please enter the age of the ticket holder: ");
            age = int.Parse(Console.ReadLine());

            people.Add(new Person(fName, lName, age) { TicketAmount = tickets });

            Console.WriteLine("............Checking for available seats............");

            int spareSeats = 0;

            for (int row = 0; row < movies.GetLength(1); row++)
            {
                for (int column = 0; column < movies.GetLength(0); column++)
                {
                    if (movies[column, row].Availability)
                    {
                        spareSeats++;
                    }
                }
            }
            
            if (spareSeats == 0)
            {
                Console.WriteLine("The cinema is fully booked sorry");
            }
            else
                Console.WriteLine($"There are {spareSeats} seats available");

            ticketsPurchased += tickets;



            Console.WriteLine($"Thank you {fName} you have purchased {tickets} tickets");
           
        }
    }
}
