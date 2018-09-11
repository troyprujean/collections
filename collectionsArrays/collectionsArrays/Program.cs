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

            int[] array3 = new int[100];
            Random rand = new Random();

            for (int i = 0; i < array3.Length; i++)
            {
                int num = rand.Next(1, 101);
                do
                {
                    num = rand.Next(1, 101);
                } while (array3.Contains(num));

                array3[i] = num;
            }

            BubbleSort(array3);

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

            
            //* METHODS */

            // Bubble sort
            int[] BubbleSort(int[] _arr)
            {
                int temp = _arr[0];

                for (int i = 0; i < _arr.Length; i++)
                {
                    for (int j = i + 1; j < _arr.Length; j++)
                    {
                        if (_arr[i] > _arr[j])
                        {
                            temp = _arr[i];

                            _arr[i] = _arr[j];

                            _arr[j] = temp;
                        }
                    }
                }
                return _arr;
            }
        }
    }
}
