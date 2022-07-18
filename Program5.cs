using System;

namespace LongestSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Array elements:");
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] array2 = new int[array.Length];

            int br1 = 1;
            int br2 = 1;
            int number = 0;

            for(int i = array.Length-1; i > 0; i--)
            {
                if(array[i] == array[i - 1])
                {
                    br1++;
                }
                else
                {
                    br1 = 1;
                }
                if (br1 > br2)
                {
                    br2 = br1;
                    number = array[i];
                }
            }

            for(int i =0; i < br2; i++)
            {
                array2[i] = number;
            }

            Console.WriteLine("Longest sequence of equal elements: ");
            for (int i = 0; i < br2; i++)
            {
                Console.Write(array2[i] + " ");
            }

        }
    }
}