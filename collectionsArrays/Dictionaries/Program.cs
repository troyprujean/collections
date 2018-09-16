using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Person> dictionary = new Dictionary<int, Person>();
            Random rand = new Random();
            Console.WriteLine("Welcome to the person dictionary");

            for (int i = 0; i < 5; i++)
            {
                int num = rand.Next(1000, 9999);
                do
                {
                    num = rand.Next(1000, 9999);
                } while (dictionary.ContainsKey(num));

                Console.Write("Please enter the first name of the person: ");
                string firstName = Console.ReadLine();
                Console.Write("Please enter the last name of the person: ");
                string lastName = Console.ReadLine();
                Console.Write("Please enter the age of the person: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine($"Congratulations, {firstName} was added to the dictionary an assigned the unique ID of {num}\n");
                Console.WriteLine("\n********************************************************************************************");

                dictionary.Add(num, new Person(firstName,lastName,age));
            }

            foreach (KeyValuePair<int, Person> item in dictionary)
            {
                Console.WriteLine($"ID: {item.Key}\nFirst Name: {item.Value.FirstName}\nLast Name: {item.Value.LastName}\nAge: {item.Value.Age}\n\n");
            }





        }
    }
}
