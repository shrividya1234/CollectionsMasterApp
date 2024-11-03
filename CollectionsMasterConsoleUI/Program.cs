using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the console formatted to display each section well

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            // Populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            // Print the first number of the array
            Console.WriteLine($"First number: {numbers[0]}");

            // Print the last number of the array             
            Console.WriteLine($"Last number: {numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            // Reverse the contents of the array and print it out
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            Console.WriteLine("-------------------");

            // Set numbers that are a multiple of 3 to zero and print
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            // Sort the array in order
            Array.Sort(numbers);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            // Create an integer List
            List<int> numberList = new List<int>();

            // Print the capacity of the list to the console
            Console.WriteLine($"Initial capacity: {numberList.Capacity}");

            // Populate the List with 50 random numbers between 0 and 50
            Populater(numberList);

            // Print the new capacity
            Console.WriteLine($"Capacity after population: {numberList.Capacity}");

            Console.WriteLine("---------------------");

            // Ask user for a number to search in the list
            Console.WriteLine("What number will you search for in the number list?");
            if (int.TryParse(Console.ReadLine(), out int searchNumber))
            {
                NumberChecker(numberList, searchNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers:");
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            // Remove all odd numbers from the list and print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            // Sort the list and print results
            numberList.Sort();
            Console.WriteLine("Sorted Evens!!");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            // Convert the list to an array and store that into a variable
            int[] arrayFromList = numberList.ToArray();

            // Clear the list
            numberList.Clear();

            Console.WriteLine("List cleared. Current count: " + numberList.Count);
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0; // Set multiples of 3 to 0
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(n => n % 2 != 0); // Remove all odd numbers
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is present in the list.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not present in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51)); // Populate list with random numbers between 0 and 50
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51); // Populate array with random numbers between 0 and 50
            }
        }

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]); // Custom reverse method
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}