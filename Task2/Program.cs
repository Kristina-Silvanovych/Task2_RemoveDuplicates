using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 4, 56 };
            int[] new_arr = DeleteDublicates(arr); //Create new array by DeleteDublicates method

            //Show arrays
            Console.WriteLine("Input array: ");
            ShowArray(arr);

            Console.WriteLine("Output array: ");
            ShowArray(new_arr);

            Console.ReadKey();
        }

        static int[] DeleteDublicates(int[] arr) //Delete dublicates from the array
        {
            if (arr == null || arr.Length == 0) // Check if the array is null or empty
            {
                return new int[0];
            }

            int length = 1;

            for (int i = 1; i < arr.Length; i++) //Go through the array to count unique elements
            {
                if (arr[i] != arr[i-1])
                    length++; //Count length for our new array without dublicates
            }

            int[] new_arr = new int[length]; //Create new array
            new_arr[0] = arr[0];
            int currentIndex = 1;

            for (int i = 1; i < arr.Length; i++) //Go through array to fill new array with unique elements
            {
                if (arr[i] != arr[i - 1])
                {
                    new_arr[currentIndex] = arr[i];
                    currentIndex++;
                }
            }

            return new_arr;
        }

        static void ShowArray(int[] arr) // Method to display elements of an array
        {
            if (arr != null || arr.Length != 0) {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Element {i} : {arr[i]}");
                }
            }

            Console.WriteLine();
        }
    }
}
