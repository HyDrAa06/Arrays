using System;

namespace EqualElementsInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elements in array:");

            int [] Array= Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); ;

            int elementsLeft=0;
            int elementsRight=0;
            int ifYes = 0;
            

            for(int i=0; i< Array.Length; i++)
            {
                elementsLeft = 0;
                elementsRight = 0;

                for (int j=0; j< Array.Length; j++)
                {
                    if (j < i)
                    {
                        elementsLeft = elementsLeft + Array[j];
                    }
                    if(j > i)
                    {
                        elementsRight = elementsRight + Array[j];
                    }
                    
                }
                if (elementsLeft == elementsRight)
                {
                    ifYes = i;
                }
            }

            

            if (ifYes != 0)
            {
                Console.WriteLine("Index: {0}", ifYes);
            }

            if(ifYes == 0)
            {
                if (Array.Length == 1)
                {
                    Console.WriteLine("Index: 0");
                    
                }

                else
                {
                    Console.WriteLine("No");
                }
            }



        }
    }
}