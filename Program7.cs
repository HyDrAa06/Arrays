using System;

namespace UniquePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array elements:");
            int[] array1=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[] array2= new string[array1.Length];

            Console.WriteLine("Number: ");
            int number=int.Parse(Console.ReadLine());
            int br = 0;

            for(int i = 0; i < array1.Length; i++)
            {    
                for(int p=0; p < i; p++)
                {
                    if (array1[i] + array1[p] == number)
                    {
                        array2[br] = array1[i] + " " + array1[p];
                        br++;                    
                    }                  
                }                            
            }  

            for(int i = 0; i <br; i++)
            {
                Console.WriteLine(array2[i]);
            }

        }
    }
}