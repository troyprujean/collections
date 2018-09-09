using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = new int[10];
            //int[] array2 = new int[5] { 1,2,3,4,5};
            //int[] array3 = { 1, 2, 3, 4, 5 };

            //int[] array1 = new int[10];

            //Console.WriteLine("Welcome to the array exercise");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.WriteLine($"Please enter a number to store in the indices of {i}");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int number in array1)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] array2 = new int[100];
            //Random random1 = new Random();

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = random1.Next(1000, 9999);
            //}

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    int counter = 0;
            //    for (int j = 0; j < array2.Length; j++)
            //    {
            //        if (array2[i] == array2[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine($"{array2[i]} occurs {counter} times");
            //}

            int[] array3 = new int[10];
            Random random = new Random();

            for (int i = 0; i < array3.Length; i++)
            {
                int randomNum;
                bool match = true;
                do
                {
                    array3[i] = randomNum;
                    randomNum = random.Next(1, 11);
                    foreach (int number in array3)
                    {
                        Console.WriteLine(randomNum);
                        if (randomNum == number)
                        {
                            Console.WriteLine("True " + number);
                            match = true;
                        }
                        else
                        {
                            Console.WriteLine("False " + number);
                            match = false;

                        }
                    }
                } while (match);
                
            }


            foreach (int number in array3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("What 4-digit number would you like to search for in the array");
            int searchNum = int.Parse(Console.ReadLine());
            int result = Array.IndexOf(array3, searchNum);
            if (result == -1)
            {
                Console.WriteLine($"The number {searchNum} was searched for in the array, the number was not found");
            }
            else Console.WriteLine($"The number {searchNum} was searched for in the array, the number was found in the {result} indices");







            ///* METHODS */

            //int ArrayCount(int[] array)
            //{

            //}
        }
        
    }
}
